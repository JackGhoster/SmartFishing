using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatScript : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            EventManager.Instance.Sit();
        }
    }
}
