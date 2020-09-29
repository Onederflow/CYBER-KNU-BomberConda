using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    /// <summary>Body, list of ActionBlock</summary>
    public List<ActionBlock> body;
    private int tail = 0;

    public Timer timer;

    public void FrameUpdate()
    {
        timer.Increase();



        foreach(ActionBlock bn in body)
        {
            if (bn.FrameUpdate() == 0)
                body.Remove(bn);
        }
    }

    ///UNITY

    private void Start()
    {
        
    }
}
