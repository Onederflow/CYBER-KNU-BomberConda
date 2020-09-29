using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Speed, how many iterations the block will pass (in one cube)
    public float value = 50;
    //Timer tick now
    private float tick = 0;

    public void Increase()
    {
        tick++;
        if (tick > value)
            tick = 1;
    }

    public float GetProgress()
    {
        float res = tick / value;
        return res;
    }

    public void ResetToZero()
    {
        tick = 1;
    }

}
