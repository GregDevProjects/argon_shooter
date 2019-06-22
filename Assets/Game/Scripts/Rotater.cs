 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] float speed = 15;
    [Tooltip("lowercase")] [SerializeField] string axis = "z";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (axis)
        {
            case "x":
                gameObject.transform.Rotate(Time.deltaTime * speed, 0,0);
                break;
            case "y":
                gameObject.transform.Rotate(0, Time.deltaTime * speed, 0);
                break;
            case "z":
                gameObject.transform.Rotate(0, 0, Time.deltaTime * speed);
                break;
        }
        
    }
}
