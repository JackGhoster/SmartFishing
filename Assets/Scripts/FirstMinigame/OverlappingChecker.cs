using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlappingChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        print("I am overlapping");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
