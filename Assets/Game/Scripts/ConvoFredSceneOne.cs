using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvoFredSceneOne : MonoBehaviour
{
    Text convoText;
    // Start is called before the first frame update
    void Start()
    {
        convoText = GetComponent<Text>();
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TubeGetOverWith()
    {
        convoText.text = "It's your last day in the sim! How are you feeling, Fred?";
    }
}
