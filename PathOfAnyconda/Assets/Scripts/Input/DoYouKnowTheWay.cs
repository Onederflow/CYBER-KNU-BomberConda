using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoYouKnowTheWay : MonoBehaviour
{
    //direction
    public byte direction = 0;
    public Snake snake;


    public void NewWay(int direction)
    {
        way.AddToWay(direction);
    }

}
