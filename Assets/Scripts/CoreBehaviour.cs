using UnityEngine;
using System.Collections;

public class CoreBehaviour : MonoBehaviour {
    public static bool upgradeOn = false;
    public static bool buildOn = false;
    static int towerhealth;
    static bool gameOn;
    public static int waveNumber;
	// Use this for initialization
	void Start () {
        towerhealth = 100;
        gameOn = false;
        waveNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (towerhealth <= 0)
        {
            //GAMEOVER
            Application.LoadLevel(4);

        }//end if
	}

    public static void addHealth(int x)
    {
        towerhealth += x;

    }//end addHealth

    public static void takeHealth(int x)
    {
        towerhealth -= x;

    }//end takeHealth

    public static int getHealth()
    {
        return towerhealth;
    }

    public static void waveIncrement()
    {
        Debug.Log("Wave Incremented");
        waveNumber++;
    }
}

