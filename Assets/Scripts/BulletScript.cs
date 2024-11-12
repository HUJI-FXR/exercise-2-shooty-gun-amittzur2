using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    void Start()
    {
        // set the bullet's velocity to the right
        GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
    }
}
