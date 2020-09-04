using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpAndDown : MonoBehaviour
{
    private Penguin myPenguin;
    public float yMin, yMax;
    public float thrust;
    Rigidbody2D rb;
    Vector2 direction;
    Vector2 upDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float randPos = Random.Range(yMin, yMax);
        transform.position = new Vector2(transform.position.x, randPos);
        direction = Vector2.down;
        upDirection = Vector2.up;
        myPenguin = GameObject.Find("Penguiny").GetComponent<Penguin>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        
        Movement();

        
       



    }
    void Movement()
    {
        if (!myPenguin.isPaused)
        {
            if (gameObject.CompareTag("P1"))
            {
                rb.velocity = direction * thrust;
            }
            if (gameObject.CompareTag("P2"))
            {
                rb.velocity = upDirection * thrust;
            }

        }
        else {
            rb.simulated = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("P1"))
        {
            if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Ground2"))
            {
                direction = -direction;

            }
        }
        if (gameObject.CompareTag("P2"))
        {
            if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Ground2"))
            {
                upDirection = -upDirection;

            }
        }
            

    }

        
        








    }









