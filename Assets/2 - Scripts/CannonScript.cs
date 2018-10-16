﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour {

    public bool active = false;
    public bool blue;
    public float timing;
    float impulse = 7.5f;

    public GameObject bullet;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Shoot", timing, timing);
	}
	
    void Shoot()
    {
        if (active)
        {
            //GameObject _bullet = Instantiate(bullet, transform.position, bullet.transform.rotation, transform) as GameObject;
            //_bullet.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            GameObject _bullet = Instantiate(bullet, transform.position, bullet.transform.rotation) as GameObject;
            _bullet.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            if (blue)
                _bullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.right * impulse, ForceMode.Impulse);
            else
                _bullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * impulse, ForceMode.Impulse);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
