using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMoney : MonoBehaviour {

    public int money = 1000000;
	public Text moneyText;
    public Text healthText;

	void Update()
	{
		moneyText.text = "Gold: " + money.ToString();
        healthText.text = "Health: " + CoreBehaviour.getHealth();
	}
}
