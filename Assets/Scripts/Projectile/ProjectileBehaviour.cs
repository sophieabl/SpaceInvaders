using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;
    public float destroyAfter = 3f;

    // Destroy the projectile if it's outside the camera view
    // (only works if the object has a Sprite renderer (2D) or Mesh renderer (3D) components)
    void OnBecameInvisible()    
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    // Projecttile will be destroyed when colliding with the barricade 
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the other object is the projectile by its tag
        if (collision.tag == "Laser")
        {
            // Destroy the projectile game object
            Destroy(collision.gameObject);
        }
    }
}
