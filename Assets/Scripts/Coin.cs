using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public string objectTag = "Player";
    public AudioClip pickupSound;
    public GameObject pickupParticlesPrefab;
    public TMP_Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(objectTag))
        {
            BallMove otherScript = other.GetComponent<BallMove>();
            otherScript.coins++;
            scoreText.text = "Coins score: "+ otherScript.coins;
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            if (pickupParticlesPrefab != null)
            {
                Instantiate(pickupParticlesPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
