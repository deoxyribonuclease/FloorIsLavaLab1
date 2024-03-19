using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{
    public int coins = 0;
    public float speed = 10f;
    Rigidbody rb;
    [SerializeField]
    private Slider speedSlider;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, 0.0f, v) * speed;
        rb.AddForce(movement);

    }
    public void UpdateSpeed()
    {
        speed = speedSlider.value;
    }
}
