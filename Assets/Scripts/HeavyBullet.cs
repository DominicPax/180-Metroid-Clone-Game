using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBullet : MonoBehaviour
{

    public float speed;

    public bool goingLeft = false;




    // Update is called once per frame
    void Update()
    {

        if (goingLeft == true)
        {
            transform.position += speed * Vector3.left * Time.deltaTime;

        }
        else
        {
            transform.position += speed * Vector3.right * Time.deltaTime;

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.GetComponent<Ground>())
            {
                {
                    Destroy(gameObject);
                }
            }
            if (other.gameObject.GetComponent<Enemy>())
            {
                Destroy(gameObject);
            }
            if (other.gameObject.GetComponent<HardEnemy>())
            {
                Destroy(gameObject);
            }
        }

    }

}
