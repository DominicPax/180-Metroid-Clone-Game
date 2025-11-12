using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Resendiz Edward
 * 11/6/25
 * Handles the extra health pack
 */
public class ExtraHealthPack : MonoBehaviour
{
    public int exhealthValue = 100;
    public float rotateSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        //Spin coin on the Y axis
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().ExtraHealth(exhealthValue);
            Destroy(gameObject);
        }
    }
}
