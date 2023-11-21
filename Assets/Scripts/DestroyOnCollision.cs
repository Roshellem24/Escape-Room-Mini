using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    //If the player collides with the enemies the player will destroy
    //and respwan right away
    //cus respawn time on the script is set to 0
    //the enemies don't move but they do have an aggresive animation
    //the room is small so it would be kinda hard 
    public int Respawn;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PLayer"))
        {
            SceneManager.LoadScene(Respawn);
        }
    }

}
