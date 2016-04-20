using UnityEngine;
using System.Collections;

public class Play_video : MonoBehaviour
{
    bool initialPlay = false;
    
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer r = GetComponent<Renderer>();
        MovieTexture movie = (MovieTexture)r.material.mainTexture;
        if(initialPlay == false)
        {
            movie.Play();
            initialPlay = true;
        }

        if(movie.isPlaying)
        {
            Debug.Log("Running");
        }
        else
        {
            Application.LoadLevel(1);
        }
       
    }
}
