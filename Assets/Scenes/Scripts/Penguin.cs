using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Penguin : MonoBehaviour
{
  
    public float speed;
    Rigidbody2D rb;
   
    //preferences
    public Score scoreText;
    public GameObject replayBtn;
    public bool isPaused = true;
    public int countdownTime;
    public Text countdownDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        isPaused = false;

        








    }
   
    
    // Update is called once per frame
    void Update()
    {
        




        if (!isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
            {
                rb.velocity = Vector2.up * speed;
            }

        }
        
        
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipe"))
        {
            
            scoreText.ScoreUp();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("P1") || collision.gameObject.CompareTag("P2") || collision.gameObject.CompareTag("Ground"))
        {
            isPaused = true;
            replayBtn.SetActive(true);
            rb.simulated = false;
            scoreText.ShowHighScore();
           
        }
    }
    
    public void ReplayGame()
    {



        replayBtn.SetActive(false);
        countdownDisplay.gameObject.SetActive(true);

        StartCoroutine(CountdownToStart());

    }
    IEnumerator CountdownToStart()
    {
       
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;

        }
        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }



}
