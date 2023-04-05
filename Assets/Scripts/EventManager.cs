using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public event Action OnSit;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }  
    }

    public void Sit()
    {
        if(OnSit != null)
        {
            OnSit();
        }
    }
}
