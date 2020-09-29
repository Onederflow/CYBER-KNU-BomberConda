using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class SmoothMoving : MonoBehaviour
{
    public bool active = false; // if true is working
    //final
    public Vector3 to;
    //smooth coefficient
    public float smoothTime = 1;
    //end coefficient
    public float maxCF = 0.1f;
    public float minCF = 0.01f;
    //velocity
    private Vector3 velocity = Vector3.zero;
    
    //End
    public float GetDif()
    {
        float dif = (to - this.transform.localPosition).magnitude;
        return dif;
    }

    private void Update()
    {
        if(active)
        {
            float dif = GetDif();
            float sm;
            if (dif > maxCF)
                sm = smoothTime;
            else if (dif < minCF)
                sm = 0;
            else sm = (dif - minCF / (maxCF - minCF));
            this.transform.localPosition = Vector3.SmoothDamp(transform.localPosition, to,ref velocity, sm);
        }
    }

}
