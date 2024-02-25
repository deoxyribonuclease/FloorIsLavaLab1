using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string objectTag = "Player";
    public float restartDelay = 0.5f; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(objectTag))
        {
            StartCoroutine(RestartWithDelay());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(objectTag))
        {
            StartCoroutine(RestartWithDelay());
        }
    }

    private IEnumerator RestartWithDelay()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
