using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Penguin myPenguin;
    public float speed;
   
   
    // Start is called before the first frame update
    void Start()
    {
        myPenguin = GameObject.Find("Penguiny").GetComponent<Penguin>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!myPenguin.isPaused)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

            if (gameObject.CompareTag("Pipe"))
            {
                if (transform.position.x <= -5.5)
                {
                    Destroy(gameObject);
                }
            }
        }
       

        

    }
}
