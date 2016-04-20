using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
    public Transform target;

    GameObject prefab;
    float timer;
    bool shipDetected;

	// Use this for initialization
	void Start () {
        prefab = Resources.Load("cannonball") as GameObject;
        timer = 0.0f;
        shipDetected = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (shipDetected)
        {
            timer += Time.deltaTime;
            Debug.Log("level 1");
            transform.LookAt(target);
            if (timer > 3.0f)
            {
                Debug.Log("level2"); 
                GameObject projectile = Instantiate(prefab) as GameObject;
                projectile.transform.position = transform.position + this.transform.forward;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = this.transform.forward * 20;
                timer = 0.0f;
            }

        }//end if


    }
    void OnTriggerStay(Collider other)
    {
        shipDetected = true;
    
    }
    void OnTriggerExit(Collider other)
    {
        shipDetected = false;

    }

}
