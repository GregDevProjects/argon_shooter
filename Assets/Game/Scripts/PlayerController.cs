using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    [Header("General")]
    [SerializeField] float xClamp = 100f;
    [SerializeField] float yClamp = 50f;
    [Tooltip("In ms^-1")][SerializeField] float speed = 40f;

    [Header("Sceen position based")]
    [SerializeField] float positionRollFactor = 1f;
    [SerializeField] float positionPitchFactor = 1f;
    
    [Header("Control throw based")]
    [SerializeField] float controlRollFactor = -10f;
    [SerializeField] float controlPitchFactor = -10f;

    Camera mainCamera;

    Boolean isDead = false;
    float xThrow, yThrow;
    // Start is called before the first frame update
    void Start()
    {

        mainCamera = GetComponentInParent<Camera>();
    }

    public void OnDeathStart() //called by string refrence
    {
        print("player got death");
        isDead = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }
        
        ProcessTranslation();
        ProcessRotation();

    }



    private void ProcessRotation()
    {
        float pitchDueToPosition = transform.localPosition.y * positionPitchFactor;
        float pitchDueToControlThrow = yThrow * controlPitchFactor;
        float pitch = pitchDueToControlThrow + pitchDueToPosition;


        float rollDueToPosition = transform.localPosition.x * positionRollFactor;
        float rollDueToControlThrow = xThrow * controlRollFactor;
        float roll = rollDueToControlThrow + rollDueToControlThrow;


        transform.localRotation = Quaternion.Euler(-pitch, 0, roll);

    }

    private void ProcessTranslation()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        //if the frame takes longer, you want to move further
        //this is why we multiply by deltatime
        float xOffset = speed * xThrow * Time.deltaTime;
        float rawNewXPos = Mathf.Clamp(
            transform.localPosition.x + xOffset,
            -xClamp,
            xClamp
            );

        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = speed * yThrow * Time.deltaTime;

        float rawNewYPos = Mathf.Clamp(
            transform.localPosition.y + yOffset,
            -yClamp,
            yClamp
            );



        transform.localPosition = new Vector3(rawNewXPos, rawNewYPos, transform.localPosition.z);
    }
}
