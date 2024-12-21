using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    //public GameObject targetPregab, dronePrefab;
    public GameObject birdPrefab1, birdPrefab2;

    private void Start()
    {
        /*spawnTarget();
        spawnDrone();
        spawnBirds();*/
    }



    /*void spawnTarget() {
        int index = Random.Range(0, 106);
        GameObject instantiatedObject = Instantiate(targetPregab, spawnPoints[index].localPosition,Quaternion.identity);
        instantiatedObject.transform.parent = this.transform;
    }
    void spawnDrone() {
        int index = Random.Range(0, 106);
        GameObject instantiatedObject = Instantiate(dronePrefab, spawnPoints[index].localPosition, Quaternion.identity);
        instantiatedObject.transform.parent = this.transform;
    }*/

    /*void spawnBirds()
    {
        int index;

        for(int i = 0; i < 3; i++)
        {
            index = Random.Range(0, 106);
            GameObject instantiatedObject = Instantiate(birdPrefab1,spawnPoints[index].localPosition, Quaternion.identity);
            instantiatedObject.transform.parent = this.transform;
        }
        for (int i = 0; i < 3; i++)
        {
            index = Random.Range(0, 106);
            GameObject instantiatedObject = Instantiate(birdPrefab2, spawnPoints[index].localPosition, Quaternion.identity);
            instantiatedObject.transform.parent = this.transform;
        }
    }*/

}
