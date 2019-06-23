using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvoBobSceneOne : MonoBehaviour
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

    public void Greeting()
    {
        convoText.text = "It's your last day in the sim! How are you feeling, Fred?";
    }

    public void Moving()
    {
        convoText.text = "Sounds good, we'll start with some movement tests. Use the WASD keys or left analogue stick to move";
    }

    public void NiceWork()
    {
        convoText.text = "Nice Work!";
    }

    public void Shooting()
    {
        convoText.text = "Not quite, we'll need a weapons test. Press space or the A button to fire";
    }
}
