using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Resendiz Edward
 * 11/6/25
 * Handles the health pack
 */

public class HealthPack : MonoBehaviour
{
    public int healthpackValue = 50;
    public float rotateSpeed = 10f;
    private float xValue = 50;

    // Update is called once per frame
    void Update()
    {
        //Spin coin on the Y axis
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        float xPos = Mathf.Clamp(xValue, 0, 99);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().health += healthpackValue;
            Destroy(gameObject);
        }
    }
}
