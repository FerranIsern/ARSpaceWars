using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject [] tanks;
    public Image imatge;
    int russianTankHp, germanTankHp;

	// Use this for initialization
	void Start () {
        russianTankHp = 10;
        germanTankHp = 10;
    }
    
    public void Hit(int tankIndex)
    {
        print(russianTankHp + "   -   " + germanTankHp);
        if (tankIndex == 0)
            russianTankHp = tanks[0].GetComponent<Tank>().hp;
        else
            germanTankHp = tanks[1].GetComponent<Tank>().hp;
        if (russianTankHp == 0 || germanTankHp == 0)
            GameOver();
    }

    void GameOver()
    {
        tanks[0].GetComponentInChildren<CannonScript>().dead = true;
        tanks[1].GetComponentInChildren<CannonScript>().dead = true;
        imatge.gameObject.SetActive(true);
        Invoke("LoadMenu", 3);
    }

    void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
