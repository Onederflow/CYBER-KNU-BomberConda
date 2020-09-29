using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCircle : MonoBehaviour
{
    //Snake
    public Snake snake;

    public bool working = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // FixedUpdate is called once every 20 ms.
    void FixedUpdate()
    {
        if(true)
        {
            snake.FrameUpdate();
        }
    }
}
