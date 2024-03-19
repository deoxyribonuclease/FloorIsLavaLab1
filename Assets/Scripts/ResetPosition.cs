using UnityEngine;
using UnityEngine.Events;

public class ResetPosition : MonoBehaviour
{
    public Transform objectToReset;

    private Vector3 originalPosition;
    private Vector3 originalVelocity;

    public UnityEvent onReset;

    private Rigidbody rb;

    void Start()
    {
        originalPosition = objectToReset.position;
        rb = objectToReset.GetComponent<Rigidbody>();
        if (rb != null)
            originalVelocity = rb.velocity;
    }

    public void ResetObject()
    {
        objectToReset.position = originalPosition;
        if (rb != null)
        {
            rb.velocity = Vector3.zero; 
            rb.angularVelocity = Vector3.zero; 
        }

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.Sleep(); 
        }

        onReset.Invoke();
    }
}
