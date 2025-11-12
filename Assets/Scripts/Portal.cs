using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        //Sets the touched objects position to the teleport points position
        other.transform.position = teleportPoint.position;




    }
}