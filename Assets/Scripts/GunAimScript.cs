using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sets the transform.rotation of
        // the Gun to Quaternion.Euler(0, 0, rot), calculating rot according to the angle
        // between the Input.mousePosition and the Gun.

        // Get the position of the mouse in the world
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Get the direction from the Gun to the mouse
        Vector3 direction = mousePos - transform.position;
        // Calculate the angle between the Gun and the mouse
        float rot = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 180f;
        // Set the rotation of the Gun to the calculated angle
        transform.localRotation = Quaternion.Euler(0, 0, rot);

    }
}
