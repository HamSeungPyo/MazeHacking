using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    GameObject mainCa;
    public AngleJoystickControl script_AngleJoy;
    void Start ()
    {
        mainCa = Camera.main.gameObject;
    }
    void Update()
    {
        Vector2 angle = script_AngleJoy.GetAngleValue();
        int[] test = new int[2];
        if (Input.GetKey(KeyCode.W))
        {
            test[1] = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            test[1] = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            test[0] = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            test[0] = 1;
        }
        mainCa.transform.Rotate(angle.y*-1,0,0);
        transform.Rotate(0,angle.x, 0);
        transform.Translate(test[0]* Time.deltaTime, 0, test[1]*Time.deltaTime);
    }
}
