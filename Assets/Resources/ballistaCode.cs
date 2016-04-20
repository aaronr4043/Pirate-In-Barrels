using UnityEngine;
using System.Collections;

public class ballistaCode : MonoBehaviour {


    float timer;

    // Use this for initialization
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //code to delete cannonball
        if (timer > 2.5f || this.gameObject.transform.position.y < -2)
        {
            Destroy(this.gameObject);
        }//end if

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Enemy")
        {
            UnityEngine.GameObject enemy = collision.gameObject;
            Debug.Log("hit ship");
            Destroy(this.gameObject);
            //Show amber this
            collision.collider.GetComponent<PathFollowing>().shipHealth -= 1;
            //PathFollowing.shipHealth -= 1;

        }
        else if (collision.collider.tag == "Terrain")
        {
            Debug.Log("hit terrain");
            Destroy(this.gameObject);
        }

        //   Destroy(collision.gameObject);

    }
}
