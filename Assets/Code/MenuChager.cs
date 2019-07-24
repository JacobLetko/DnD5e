using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChager : MonoBehaviour
{
    public Gameobject[] screens;
    
    public void screenChange(Gameobject target)
    {
        foreach (Gameobject screen in screens)
        {
            if (screen == target)
                screen.enabled = true;
            else
                screen.enabled = false;
        }
    }
}
