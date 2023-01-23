using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    static public bool upInput = false;
    static public bool downInput = false;
    static public bool rightInput = false;
    static public bool leftInput = false;
    static public bool upRightInput = false;
    static public bool upLeftInput = false;
    static public bool downRightInput = false;
    static public bool downLeftInput = false;
    static public int numberOfWASDButtons = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("w")) upInput = true;
        else upInput = false;
        if (Input.GetKey("s")) downInput = true;
        else downInput = false;
        if (Input.GetKey("d")) rightInput = true;
        else rightInput = false;
        if (Input.GetKey("a")) leftInput = true;
        else leftInput = false;
        if (upInput && rightInput) upRightInput = true;
        else upRightInput = false;
        if (upInput && leftInput) upLeftInput = true;
        else upLeftInput = false;
        if (downInput && rightInput) downRightInput = true;
        else downRightInput = false;
        if (downInput && leftInput) downLeftInput = true;
        else downLeftInput = false;

        if (upInput && downInput)
        {
            upInput = false;
            downInput = false;
            upRightInput = false;
            upLeftInput = false;
            downRightInput = false;
            downLeftInput = false;
        }

        if (rightInput && leftInput)
        {
            rightInput = false;
            leftInput = false;
            upRightInput = false;
            upLeftInput = false;
            downRightInput = false;
            downLeftInput = false;
        }
        
        numberOfWASDButtons = 0;
        if (upInput) numberOfWASDButtons++;
        if (downInput) numberOfWASDButtons++;
        if (rightInput) numberOfWASDButtons++;
        if (leftInput) numberOfWASDButtons++;
        
        if (numberOfWASDButtons >= 3)
        {
            upInput = false;
            downInput = false;
            rightInput = false;
            leftInput = false;
            upRightInput = false;
            upLeftInput = false;
            downRightInput = false;
            downLeftInput = false;
        }

        
    }
}
