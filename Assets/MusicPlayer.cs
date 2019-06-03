using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        int numMusicPLayers = FindObjectsOfType<MusicPlayer>().Length;
        //destroy ourself if more than 1 music player
        
        print(numMusicPLayers);
        if (numMusicPLayers > 1)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
