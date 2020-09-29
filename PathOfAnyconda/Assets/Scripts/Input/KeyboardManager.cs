using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public DoYouKnowTheWay way;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Debug.Log("Down 9");
            way.NewWay(1);
        };
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Debug.Log("Down 7");
            way.NewWay(2);
        };
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("Down 1");
            way.NewWay(3);
        };
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("Down 3");
            way.NewWay(4);
        };
    }

}
