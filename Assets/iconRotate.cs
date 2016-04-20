using UnityEngine;
using System.Collections;

public class iconRotate : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.tag == "menuObject")
        {
            transform.Rotate(0, 0.1f, 0);
            
        }
        else
        {
            transform.Rotate(0, 1, 0);

        }
        
    }
}
