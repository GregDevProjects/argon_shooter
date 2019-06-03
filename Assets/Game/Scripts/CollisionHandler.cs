using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CollisionHandler : MonoBehaviour
{
    [Tooltip("prefab ")][SerializeField] GameObject deathFx;
    [SerializeField] float loadDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
    }

    private void StartDeathSequence()
    {
        deathFx.SetActive(true);
        gameObject.SendMessage("OnDeathStart");
        Invoke("RestartScene", loadDelay);
    }

    private void RestartScene() //string refrenced
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        return;
        StartDeathSequence();
        
        // print("trigger");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
