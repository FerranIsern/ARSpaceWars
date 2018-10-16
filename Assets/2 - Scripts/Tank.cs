using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    public int hp = 10;
    public GameObject tankLife;
    public GameObject lifeBarPrefab;
    // Use this for initialization

    bool test = true;

	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
            Hit();
    }

    void Hit()
    {
        if (test)
        {
            if (tankLife.transform.childCount > 0)
                Destroy(tankLife.transform.GetChild(0).gameObject);
            if (tankLife.transform.childCount == 0)
            {
                test = false;
                print("lost");
            }
        }
        else
        {
            if (tankLife.transform.childCount < 10)
                AddHealth();
            if (tankLife.transform.childCount == 10)
            {
                test = true;
                print("fullhp");
            }
        }
    }

    void AddHealth()
    {
        var newBar = Instantiate(lifeBarPrefab);
        newBar.transform.parent = tankLife.transform;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
