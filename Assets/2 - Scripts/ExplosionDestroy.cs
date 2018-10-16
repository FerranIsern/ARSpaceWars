using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("AutoDestroy", 3f);
	}
	
	void AutoDestroy()
    {
        Destroy(transform.gameObject);
    }
}
