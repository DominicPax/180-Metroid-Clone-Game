using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    public bool goingLeft = false;

    public int bulletDamage = 1;


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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ground>())
        {
            {
                Destroy(gameObject);
            }
        }
    }

}