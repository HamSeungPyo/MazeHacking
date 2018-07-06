using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
	void Start ()
    {
		
	}
    void Update()
    {
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
        transform.Translate(test[0], 0, test[1]);
    }
}
