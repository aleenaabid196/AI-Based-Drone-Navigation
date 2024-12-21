using UnityEngine;

public class DistanceCalc : MonoBehaviour
{
    public Transform object1;
    public Transform object2;

    void Update()
    {
        // Check if both objects are assigned
        if (object1 != null && object2 != null)
        {
            // Calculate the distance between object1 and object2
            float distance = Vector3.Distance(object1.position, object2.position);

            // Print the distance to the console
            Debug.Log("Distance between object1 and object2: " + distance);
        }
        else
        {
            Debug.LogWarning("Assign both objects in the inspector.");
        }
    }
}
