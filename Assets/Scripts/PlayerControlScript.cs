using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControlScript : MonoBehaviour
{
    //serialize field allows us to see the private variable in the inspector
    [SerializeField] private MovementScript movementScript;
    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // Call the Move function from PlayerMovement
        if (direction.magnitude > 0)
        {
            movementScript.Move(direction);
        }
        // determine a jump
        if (Input.GetKeyDown(KeyCode.W))
        {
            movementScript.Jump();
        }
    }
}
