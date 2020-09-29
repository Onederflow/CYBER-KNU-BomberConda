using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControl : MonoBehaviour
{
    public Vector3 def;
    public Quaternion qt;
    public float scale;

    public bool work = false;


    public void Calculation(float x, float y, float max)
    {
        float pifagor = Mathf.Sqrt(x * x + y * y);
        scale = pifagor / (2 * max);
        if (scale > 1)
            scale = 1;
        Vector3 from = new Vector3(-1, -1, 0);
        Vector3 to = new Vector3(x, y, 0.0f);
        qt = Quaternion.FromToRotation(from, to);
    }

    // Start is called before the first frame update
    void Start()
    {
        def = this.transform.localScale;
        this.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
       /* 
        Calculation(-1, -0.5f, 1);
        work = true;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(work)
        {
            this.transform.localScale = new Vector3(scale * def.x, scale * def.y, def.z);
            this.transform.localRotation = qt;
        }
        else
        {
            Vector3 v = new Vector3();
            this.transform.localScale = Vector3.SmoothDamp(transform.localPosition, Vector3.zero, ref v, 1f);
            scale = 0;
        }
    }


}
