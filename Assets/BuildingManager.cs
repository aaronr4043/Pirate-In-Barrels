﻿using UnityEngine;
using System.Collections;

public class BuildingManager : MonoBehaviour {

    public GameObject selectedTower;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SelectTowerType(GameObject prefab)
    {
        selectedTower = prefab;
        CoreBehaviour.upgradeOn = false;
        CoreBehaviour.buildOn = true;
    }
    public void UpgradeTower(GameObject prefab)
    {
        CoreBehaviour.upgradeOn = true;
        CoreBehaviour.buildOn = false;

    }
}
