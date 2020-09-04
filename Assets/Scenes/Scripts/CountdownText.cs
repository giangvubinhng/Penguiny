using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownText : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public GameObject startButton;
    public void BeginGame()
    {
        countdownDisplay.gameObject.SetActive(true);
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        startButton.SetActive(false); 
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
            
        }
        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
    
}
