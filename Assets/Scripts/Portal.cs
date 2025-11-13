using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        //Sets the touched objects position to the teleport points position
        if(other.GetComponent<PlayerController>())
        {
            other.transform.position = teleportPoint.position;
        }





    }
}