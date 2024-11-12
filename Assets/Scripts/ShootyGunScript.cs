using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // If the player presses the left mouse button
        if (Input.GetMouseButtonUp(0))
        {
            // Call the Shoot function
            Shoot();
        }
    }
    void Shoot()
    {
        // Create a bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletPrefab.transform.position, bulletPrefab.transform.rotation);
        // set the bullet to active
        bullet.SetActive(true);

    }
}
