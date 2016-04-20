using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        //transform.Rotate(Vector3.up, speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime);
        //transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        

    }
}