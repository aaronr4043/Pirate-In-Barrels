using UnityEngine;
using System.Collections;

public class OptionsMenu : MonoBehaviour
{
    public bool isMenu;

    void OnMouseUP()
    {
        if (isMenu)
        {
            Application.LoadLevel(0);
        }
    }
}
