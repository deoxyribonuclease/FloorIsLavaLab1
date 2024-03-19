using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrackingV2 : MonoBehaviour
{
    public float FollowSpeed = 5f;
    public Transform target;

    void Start()
    {
       // transform.position = new Vector3(-2.23f, 35.07f, -46.33f);
    }

    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + 5f, target.position.z - 6f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);

        Vector3 direction = (target.position - transform.position).normalized;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, FollowSpeed * Time.deltaTime);
    }
}
