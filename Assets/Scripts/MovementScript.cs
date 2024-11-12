using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private bool isGrounded;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Move(Vector3 direction)
    {
        // Move the player in the direction of the input
        transform.Translate(direction * Time.deltaTime * speed);
    }
    public void Jump()
    {
        //if the player is on the ground
        if (isGrounded)
        {
            //add a force to the player in the y direction
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if the player collides with an object tagged "Floor"
        if (collision.gameObject.CompareTag("Floor"))
        {
            //set isGrounded to true
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        //if the player exits the collision with an object tagged "Floor"
        if (collision.gameObject.CompareTag("Floor"))
        {
            //set isGrounded to false
            isGrounded = false;
        }
    }
}
