using UnityEngine;
using System.Collections;

public class catapult_launch : MonoBehaviour
{
    public float rotation = 1.0f;
    private int count = 0;
    public int limit = 60; 
    private bool active = false;

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetButtonDown ("Jump"))
        {
            active = true;
        }

        if (active)
        {
            transform.Rotate(0, 0, -rotation);
            count++;
        }

        if (count == limit)
        {
            rotation *= -1.0f;
        }

        if(count == (limit*2))
        {
            active = false;
            rotation *= -1.0f;
            count = 0;
        }


    }
}
