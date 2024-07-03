using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentButton : MonoBehaviour
{
    public GameObject curScreen;
    
    public void EnableContent(GameObject content)
    {
        curScreen.SetActive(false);
        content.SetActive(true);
    }
}
