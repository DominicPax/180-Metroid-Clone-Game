using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBulletPickup : MonoBehaviour
{

    public float rotateSpeed = 10f;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

    }
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.GetComponent<PlayerController>())
            {
                other.gameObject.GetComponent<PlayerController>().HeavyGun();

                    Destroy(gameObject);
            }
        }
    }


}
