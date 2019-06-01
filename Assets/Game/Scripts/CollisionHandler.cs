using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
    }

    private void StartDeathSequence()
    {
        gameObject.SendMessage("OnDeathStart");
        //   print("dead");
    }

    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        
        // print("trigger");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
