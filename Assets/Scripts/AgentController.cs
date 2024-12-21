using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class AgentController : Agent
{
    public GameObject target;
    public float moveSpeed;
    public GameManager gameManager;
    public SpriteRenderer[] walls;

    float oldDistanceToTarget;

    //STAGE 1
    public Transform startingPosition;

    private void Start()
    {
        gameManager = GetComponentInParent<GameManager>();
    }


    public override void OnEpisodeBegin()
    {
        /*int index = Random.Range(0, 106);
        this.transform.localPosition = gameManager.spawnPoints[index].localPosition;

        index = Random.Range(0, 106);
        target.transform.localPosition = gameManager.spawnPoints[index].localPosition;*/

        //setWallsGreen();

        //=======STAGE 1=========
        this.transform.localPosition = startingPosition.localPosition;
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation((Vector2)transform.localPosition);
        sensor.AddObservation((Vector2)target.transform.localPosition);
    }

    /*public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveY = actions.ContinuousActions[1];

        transform.localPosition += new Vector3(moveX, moveY) * Time.deltaTime * moveSpeed;
        //AddReward(0.01f);
    }*/

    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveY = actions.ContinuousActions[1];

        Vector3 oldPosition = transform.localPosition;

        // Move the agent
        transform.localPosition += new Vector3(moveX, moveY) * Time.deltaTime * moveSpeed;

        // Calculate the new distance to the target
        float newDistanceToTarget = Vector2.Distance(transform.localPosition, target.transform.localPosition);

        // Calculate the change in distance (positive if getting closer, negative if moving away)
        float distanceChange = oldPosition != transform.localPosition ? (oldPosition - transform.localPosition).magnitude : 0f;

        // Check if the agent moved towards the target
        bool movedTowardsTarget = distanceChange < 0 || newDistanceToTarget < oldDistanceToTarget;

        // Set the reward based on the movement direction and distance change
        if (movedTowardsTarget)
        {
            // Reward based on how close the agent got to the target
            //22 is max distance
            float distanceReward = Mathf.Clamp01(1.0f - newDistanceToTarget / 16f);
            //AddReward(0.1f * distanceReward); // Adjust the positive reward as needed
            AddReward(0.000001f * distanceReward); // Adjust the positive reward as needed
            Debug.Log(0.000001f * distanceReward); // Adjust the positive reward as needed
        }
        else
        {
            // Negative reward based on how far the agent moved away
            AddReward(-5f * distanceChange); // Adjust the negative reward as needed
        }

        // Optionally, add a small negative reward for each step to encourage reaching the target sooner
        //AddReward(-0.1f);
        AddReward(-1f);

        // You can experiment with different scaling factors or adjust the rewards as needed

        // Uncomment the line below if you want to end the episode when the agent is far from the target
        if (newDistanceToTarget >= oldDistanceToTarget) { AddReward(-5f); }

        // Remember to update the oldDistanceToTarget for the next step
        oldDistanceToTarget = newDistanceToTarget;
    }


    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            //AddReward(-30f);
            AddReward(-10f);
            setWallsRed();
            EndEpisode();
        }
        if (collision.gameObject.tag == "Building")
        {
            //AddReward(-15f);
            AddReward(-1000f);
            setWallsRed();
            EndEpisode();
        }/*
        if (collision.gameObject.tag == "Tree")
        {
            //AddReward(-10f);
            SetReward(-5f);
            setWallsRed();
            EndEpisode();
        }*/
        if (collision.gameObject.tag == "Target")
        {
            //AddReward(5f);
            AddReward(50f);
            setWallsGreen();
            EndEpisode();
        }
    }

    void setWallsGreen()
    {
        foreach (SpriteRenderer sr in walls)
        {
            sr.color = Color.green;
        }
    }

    void setWallsRed()
    {
        foreach (SpriteRenderer sr in walls)
        {
            sr.color = Color.red;
        }
    }
}
