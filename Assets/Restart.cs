using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string objectTag = "Player"; 
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(objectTag))
        {
            RestartScene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {    
        if (other.CompareTag(objectTag))
        {
            RestartScene();
        }
    }

    private void RestartScene()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
