using UnityEngine;
using System.Collections;

public class UpgradeScript : MonoBehaviour {

    GameObject initialObject;
    GameObject swapObject;

    Mesh initialMesh;
    Mesh swapMesh;

    // Use this for initialization
    void Start () {
        initialObject = this.gameObject;
        if (this.tag == "catapult")
        {
            swapObject = Resources.Load("Cannon") as GameObject;


        }//end if
        else {
            Debug.Log("Hi");
        }//end else
	}

    void OnMouseDown()
    {
        ScoreMoney sm = GameObject.FindObjectOfType<ScoreMoney>();

        //GetComponent<Renderer>().material.color = Color.black;
        if (CoreBehaviour.upgradeOn== true && sm.money>=300 && this.tag=="catapult")
        {
            sm.money -= 300;
            Destroy(this.gameObject);
            Instantiate(swapObject, this.transform.position, this.transform.rotation);
            this.tag = "notCatapult";
            
        }



    }
    // Update is called once per frame
    void Update () {

	
	}
}
