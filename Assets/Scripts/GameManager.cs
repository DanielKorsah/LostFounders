using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[System.Serializable]
public class UpdateResourcesEvent : UnityEvent<int>{}



public class GameManager : MonoBehaviour
{

    public static UpdateResourcesEvent ResourcesEvent;


    public static long Resources;
    public static List<bool> Unlocks = new List<bool>() { false, false, false, false, false };

    private void Awake()
    {
        if (ResourcesEvent == null)
            ResourcesEvent = new UpdateResourcesEvent();

        ResourcesEvent.AddListener(Refresh);
    }

    private void Refresh(int yield)
    {
        Resources += yield;
    }
    


}
