using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Dominic Paxson
 * 11/12/25
 * Handles the You Win Screen
 */


public class YouWin : MonoBehaviour
{

    void Update()
    {
        
       


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            SceneManager.LoadScene(3);
        }
    }

}
