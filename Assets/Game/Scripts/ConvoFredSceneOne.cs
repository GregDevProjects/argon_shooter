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
        convoText.text = "I feel like I'm stuck in a damn tube. Can we just get this over with?";
    }

    public void SimOverYet()
    {
        convoText.text = "Sim over yet?";
    }
}
