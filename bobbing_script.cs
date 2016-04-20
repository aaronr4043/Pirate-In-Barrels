using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{

    public float rotSpeed = 0.1f;
    public float bobSpeed = 0.05f;
    public float xSpeed = 0.1f;
    public int rotCount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotSpeed, 0, 0);
        transform.Translate(xSpeed, 0, bobSpeed);
        rotCount++;

        if (rotCount % 70 == 0)
        {
            bobSpeed *= -1;
        }

        if (rotCount > 250)
        {
            rotCount = 0;
            rotSpeed *= -1;
        }



    }
}

