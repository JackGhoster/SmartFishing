using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public event Action OnSit;
    public event Action OnMinigame1;
    public event Action OnCirclesSpawned;
    public event Action OnTick;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;        
        }  
    }
    /// <summary>
    /// Method that activates all functions connected to OnSit event
    /// </summary>
    public void Sit()
    {
        if(OnSit != null)
        {
            OnSit();
        }
    }
    /// <summary>
    /// Method that activates all functions connected to OnMinigame1 event
    /// </summary>
    public void StartMinigame1()
    {
        if (OnMinigame1 != null)
        {
            OnMinigame1();
        }
    }
    /// <summary>
    /// Method that activates all functions connected to OnCirclesSpawned event
    /// </summary>
    public void CirclesSpawned()
    {
        if(OnCirclesSpawned != null)
        {
            OnCirclesSpawned();
        }
    }

    public void TickTime()
    {
        if(OnTick != null)
        {
            OnTick();
            
        }
        print("ticktokc");
    }

}
