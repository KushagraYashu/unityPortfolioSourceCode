using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{

    public GameObject curScreen;

    public void Back(GameObject prevScreen)
    {
        prevScreen.SetActive(true);
        curScreen.SetActive(false);
        
    }
}
