using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkButton : MonoBehaviour
{
    
    public void Click()
    {
        GameManager.ResourcesEvent.Invoke(1);
        
    }
}
