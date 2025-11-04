using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Resendiz Edward
 * 10/30/25
 * Handles Behaviors of the Player
 */

public class PlayerController : MonoBehaviour
{

    private Vector3 direction;
    private Rigidbody rb;

    public float speed = 10f;
    public float jumpForce = 10f;
    public float groundCheckDist = 1.2f;
    public float deathHeight = -3f;
    public int health = 99;

    private bool facingLeft = false;

    public GameObject bullet;

    

    private Vector3 respawnPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawnPos = transform.position;
    }

    // Start is called before the first frame update


    // Update is called once per frame
    private void Update()
    {
        Jump();
        CheckForFallDeath();
        Shooting();
    }

    //Called every 0.02
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void CheckForFallDeath()
    {
        if (transform.position.y < deathHeight)
            Respawn();
    }

    private void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded() == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {
        bool isGrounded = false;

        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.down, out hit, groundCheckDist))
        {
            isGrounded = true;
        }

        return isGrounded;
    }


    private void MovePlayer()
    {

        //Get input to move Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            direction = Vector3.left;
            //transform.position += direction * speed * Time.deltaTime;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);

            if (!facingLeft)
            {
                transform.Rotate(0, 180, 0);
                facingLeft = true;
            }
            
        }

        //Get input to move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
            //transform.position += direction * speed * Time.deltaTime;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);

            if (facingLeft)
            {
                transform.Rotate(0, 180, 0);
                facingLeft = false;
            }
        }
        
    }

    public void Respawn()
    {
        transform.position = respawnPos;
        health--;

        if(health <= 0)
        {
            print("GAME OVER");
        }
    }


    public void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space) && facingLeft)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Bullet>().goingLeft = true;
        }
       else if(Input.GetKeyDown(KeyCode.Space) && !facingLeft)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.GetComponent<Bullet>().goingLeft = false;
        }
    }




}
