using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    
    public void openMenu() 
    {
        gameObject.SetActive(true);
    }

    public void closeMenu()
    {
        gameObject.SetActive(false);
    }

}
