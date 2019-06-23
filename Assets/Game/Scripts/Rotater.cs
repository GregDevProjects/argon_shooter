 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    enum Axis { X, Y, Z };
    [SerializeField] float speed = 15;
    [SerializeField] Axis axis = Axis.Z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (axis)
        {
            case Axis.X:
                gameObject.transform.Rotate(Time.deltaTime * speed, 0,0);
                break;
            case Axis.Y:
                gameObject.transform.Rotate(0, Time.deltaTime * speed, 0);
                break;
            case Axis.Z:
                gameObject.transform.Rotate(0, 0, Time.deltaTime * speed);
                break;
        }
        
    }
}
