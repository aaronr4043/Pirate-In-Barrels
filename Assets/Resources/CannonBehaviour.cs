using UnityEngine;
using System.Collections;

public class CannonBehaviour : MonoBehaviour
{
    public Transform target;
    int upgradeState;
    GameObject prefab;
    float timer;
    float globalTimer;
    bool shipDetected;
    GameObject thisCannon;
    public int cost = 250;
    //Vector3 offset = new Vector3(0, 40, 137);
    void Start()
    {
        if (this.tag == "catapult")
        {
            prefab = Resources.Load("ballista") as GameObject;

        }
        else
        {
            prefab = Resources.Load("cannonball") as GameObject;

        }//end else
        
        timer = 0;
        shipDetected = false;
        globalTimer = 0.0f;
    }

    

    void Update()
    {
        globalTimer += Time.deltaTime;
        timer += Time.deltaTime;
        
        globalTimer = 0.0f;
        if (PathFollowing.enemies.Count != 0)
        {
            foreach (GameObject enemy in PathFollowing.enemies)
            {
                
                if (enemy != null)
                {
                    if (enemy.tag == "Enemy")
                    {

                        Vector3 lookAtPoint = new Vector3(enemy.transform.position.x, 30, enemy.transform.position.z);

                        if (Vector3.Distance(transform.position, lookAtPoint) < 90)
                        {
                            transform.LookAt(lookAtPoint);

                            //transform.right = (target.position - transform.position);
                            if (timer > 3.5f)
                            {
                                transform.LookAt(lookAtPoint);
                                timer = 0.0f;
                                GameObject projectile = Instantiate(prefab) as GameObject;
                                projectile.transform.position = transform.position + this.transform.forward * 2;

                                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                                if(this.gameObject.tag == "cannon")
                                {
                                    rb.velocity = this.transform.forward * 180;
                                }
                                
                                else if (this.gameObject.tag == "catapult")
                                {
                                    rb.velocity = this.transform.forward * 160;

                                }//end else if
                                transform.LookAt(lookAtPoint);
                            }

                        }//end if
                    }
                    
                }

            }//end for each 
        }

        
        
    }
    
}