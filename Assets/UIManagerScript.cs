using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour
{
    public void GoMain()
    {
        Application.LoadLevel(1);

    }

    public void PlayGame()
    {
        Application.LoadLevel(2);
    }

    public void GoHelp()
    {
        Application.LoadLevel(3);
    }




    public void ExitGame()
    {
        Application.Quit();
    }
}
