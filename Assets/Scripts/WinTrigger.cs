using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public GameObject youWinText;
    public float delay;
    // Start is called before the first frame update
    //this makes the text appear invisible until it collides with the cube
    //the cube is also invisible but outside the door
    //so that when the player goes through it the You Win text will appear on screen
    //the game will completly reset after 5 seconds since you already won
    //and then you can play again HOORAY!
    
    void Start()
    {
        youWinText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            youWinText.SetActive(true);
            StartCoroutine(Countdown());
        }
    }

    //Restarts the level after a few seconds after you win
    IEnumerator Countdown ()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0);
    }
}
