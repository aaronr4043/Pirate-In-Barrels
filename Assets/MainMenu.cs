using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public bool isPlay;
    public bool isHelp;
    public bool isOptions;
    public bool isExit;
    
	void OnMouseUP()
    {
        if(isPlay)
        {

            Application.LoadLevel(1);

        }

        if (isHelp)
        {

        }

        if (isOptions)
        {

        }

        if (isExit)
        {
            Application.Quit();
        }
    }
}
