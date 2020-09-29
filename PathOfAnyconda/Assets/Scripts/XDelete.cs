using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XDelete : MonoBehaviour
{
    public float time_min = 10;
    public float time_max = 20;
    private float time_final;
    private float time_now = 0;

    public float duration = 20;

    // Start is called before the first frame update
    void Start()
    {
        Random rand = new Random();
        time_final = Random.Range(time_min, time_max);
    }

    // Update is called once per frame
    void Update()
    {
        //Pause
        time_now++;
         if(time_now < time_final)
         {

         }
         else if (time_now < time_final + duration)
         {
             float alpha = 0.125f - 0.125f * (time_now - time_final) / (time_final + duration);
             Vector3 vx = new Vector3(alpha, alpha, alpha);
             this.transform.localScale = vx;
         }
         else
         {
             Destroy(this.gameObject);
         }
    }
}
