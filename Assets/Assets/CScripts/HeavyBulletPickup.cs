using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBulletPickup : MonoBehaviour
{

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
