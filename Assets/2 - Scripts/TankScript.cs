using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour {

    public bool blue;

    public GameObject bullet;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Shoot", 1, 1);
	}
	
    void Shoot()
    {
        GameObject _bullet = Instantiate(bullet, transform.position, bullet.transform.rotation) as GameObject;
        if (blue)
            _bullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.right * 3, ForceMode.Impulse);
        else
            _bullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 3, ForceMode.Impulse);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
