using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject explosion;

    private void Start()
    {
        Invoke("AutoDestroy", 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.tag = "undefined";
        Instantiate(explosion, transform.position, explosion.transform.rotation);
        AutoDestroy();
    }
    void AutoDestroy()
    {
        Destroy(transform.gameObject);
    }
}
