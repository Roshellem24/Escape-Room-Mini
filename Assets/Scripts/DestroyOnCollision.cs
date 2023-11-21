using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{

    public int Respawn;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PLayer"))
        {
            SceneManager.LoadScene(Respawn);
        }
    }

}
