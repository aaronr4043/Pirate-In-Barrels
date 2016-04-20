using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour
{ 
    public void OnValueChanged(float newValue)
    {
        AudioListener.volume = newValue;
    }
}
