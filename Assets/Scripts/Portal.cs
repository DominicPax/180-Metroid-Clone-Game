using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Dominic Paxson
 * 11/10/25
 * Handles the portal mechanic
 */

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