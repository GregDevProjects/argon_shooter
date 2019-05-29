using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] float xClamp = 1f;
    [SerializeField] float yClamp = 1f;
    [Tooltip("In ms^-1")][SerializeField] float speed = 4f;

    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {

        mainCamera = GetComponentInParent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        //if the frame takes longer, you want to move further
        //this is why we multiply by deltatime
        float xOffset = speed * xThrow * Time.deltaTime;
        float rawNewXPos = Mathf.Clamp(
            transform.localPosition.x + xOffset,
            -xClamp,
            xClamp
            );

        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = speed * yThrow * Time.deltaTime;

        float rawNewYPos = transform.localPosition.y + yOffset;

        Mathf.Clamp(
            transform.localPosition.y + yOffset,
            -yClamp,
            yClamp
            );

        transform.localPosition = mainCamera.ViewportToWorldPoint(new Vector3(rawNewXPos, rawNewYPos, transform.localPosition.z));
        print(xThrow);
    }
}
