using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeManager : MonoBehaviour
{
    //way
    public Way way;
    //for only one
    private bool ready = false;

    private Vector3 fp;   //First position
    private Vector3 lp;   //Last position
    private float dragDistance;  //Min distance for swipe

    public Animator anim;
    public ArrowControl arc;

    // Start is called before the first frame update
    void Start()
    {
        dragDistance = Screen.width * 15 / 100; //dragDistance это 15% ширины экрана
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)  // For input touching
        {
            if (touch.phase == TouchPhase.Began) //проверяем первое касание
            {
                fp = touch.position;
                ready = false;
                anim.SetInteger("CAnim",1);
                arc.work = true;
            }

            if (touch.phase == TouchPhase.Ended) //проверяем last
            {
                anim.SetInteger("CAnim", 2);
                arc.work = false;
            }

            if (touch.phase == TouchPhase.Moved) //Only when moving
            {
                lp = touch.position;
                if (fp != lp && !ready)
                {
                    byte res = 0;
                    // More than minimum distance
                    if (Mathf.Sqrt(Mathf.Pow(Mathf.Abs(lp.x - fp.x), 2) + Mathf.Pow(Mathf.Abs(lp.y - fp.y), 2)) > dragDistance)
                    {
                        //Right or Left
                        if (lp.x - fp.x > 0) // Right
                        {
                            if (lp.y - fp.y > 0) //Up or down
                            {   // Direction(1)
                                res = 1;
                            }
                            else
                            {   // Direction(4)
                                res = 4;
                            }
                        }
                        else //Left
                        {
                            if (lp.y - fp.y > 0)  //Up or down
                            {   // Direction(2)
                                res = 2;
                            }
                            else
                            {   // Direction(3)
                                res = 3;
                            }
                        }

                    };

                    if(res != 0)
                    {
                        way.AddToWay(res);
                        ready = true;
                    }
                }
                arc.Calculation(lp.x - fp.x, lp.y - fp.y, dragDistance);
            }
        }
    }
}
