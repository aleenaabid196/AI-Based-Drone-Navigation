using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float speed = 3f; // Adjust the speed of the bird
    public float turnSpeed = 2f; // Adjust the turn speed of the bird
    public float changeDirectionInterval = 2.5f; // Adjust how often the bird changes direction

    private Vector3 randomDirection;
    private float elapsedTime;

    void Start()
    {
        ChooseNewRandomDirection();
    }

    void Update()
    {
        MoveBird();
        UpdateDirection();
    }

    void MoveBird()
    {
        transform.Translate(randomDirection * speed * Time.deltaTime, Space.World);
    }

    void UpdateDirection()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= changeDirectionInterval)
        {
            ChooseNewRandomDirection();
            elapsedTime = 0f;
        }

        // Rotate smoothly towards the desired direction
        Quaternion lookRotation = Quaternion.LookRotation(Vector3.forward, randomDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, turnSpeed * Time.deltaTime);
    }

    void ChooseNewRandomDirection()
    {
        randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
            //Debug.Log("DEEWAR");
            // Collided with a wall, change direction to opposite
            randomDirection = -randomDirection;
            //ChooseNewRandomDirection();
        }
    }
}