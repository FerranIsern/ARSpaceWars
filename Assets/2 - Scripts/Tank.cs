using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

    GameController gameController;
    public int tankIndex;
    public int hp = 10;
    public GameObject tankLife;
    public GameObject lifeBarPrefab;
    public GameObject explosionPrefab;

	void Start () {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
            Hit();
    }

    void Hit()
    {
        hp--;          
        Destroy(tankLife.transform.GetChild(0).gameObject);
        gameController.Hit(tankIndex);
        if (hp == 0)
            Explode();
    }

    void AddHealth()
    {
        var newBar = Instantiate(lifeBarPrefab);
        newBar.transform.parent = tankLife.transform;
    }

    void Explode()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        explosion.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        transform.gameObject.SetActive(false);
    }

}
