using UnityEngine;
using System.Collections.Generic;

public class PathFollowing : MonoBehaviour {

    public Vector3 velocity;
    public static List<GameObject> enemies = new List<GameObject>();
    public List<Vector3> waypoints = new List<Vector3>();
    int currentWaypoint = 0;
    public float mass = 1.0f;
    public float maxSpeed = 4.0f;
    public int shipHealth;
    bool done;
    public int moneyValue;
    int damage;
	// Use this for initialization
	void Start () {
        Debug.Log(gameObject.transform.name);
        enemies.Add(gameObject);
        done = false;
        if (gameObject.transform.name == "PirateBarrel(Clone)")
        {
            shipHealth = 2 + (CoreBehaviour.waveNumber/2);
            damage = 5;
            moneyValue = 15;
        }
        else if(gameObject.transform.name== "Galleon(Clone)")
        {
            shipHealth = 5 + (CoreBehaviour.waveNumber/2);
            damage = 25;
            moneyValue = 60;
        }

        else if(gameObject.transform.name== "GhostSphereForWavePause(Clone)")
        {
            shipHealth = 1;
            damage = 0;
            moneyValue = 0;

        }//end else if

	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(waypoints[currentWaypoint], transform.position) < 1.0f)
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Count;
        }
        Vector3 desired = waypoints[currentWaypoint] - transform.position;
        desired.Normalize();
        desired *= maxSpeed;
        Vector3 force = desired - velocity;

        Vector3 acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;
        transform.Translate(velocity * (Time.deltaTime * 4), Space.World);
        transform.forward = velocity;
        checkDeath();
        if (gameObject.transform.position.z < -20)
        {
            CoreBehaviour.takeHealth(damage);
            Debug.Log("Death by position");
            Destroy(this.gameObject);
            done = true;
        }
    }

    public void checkDeath()
    {
        if (shipHealth <= 0)
        {
            GameObject.FindObjectOfType<ScoreMoney>().money+=moneyValue;
            Destroy(this.gameObject);
            Debug.Log("death by health");
        }

    }//end checkDeath

    public static int getSize()
    {
        return enemies.Count;
    }
}
