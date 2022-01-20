using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;

    void OnCollisionEnter(Collision Collision) 
    {
        if (Collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 3);
        }
        else if (Collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
