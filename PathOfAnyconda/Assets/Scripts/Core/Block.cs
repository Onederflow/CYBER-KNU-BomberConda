using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    /*public Point position = new Point();
    public int number = 0;
    public byte direction = 0;

    public float progress = 0;
    public float size = 1.0f;

    public string type = "NONE";
    public string status = "NONE"; 

    public int indexOfTheGroud = 0;

    public List<GameObject> around;

    public Block newBlockOfSnake;
    public bool newBlockReady = false;

    public Way way;

    public void Rectification()
    {
        Vector3 pos = position.Pos3D() + way.ReturnWay3D(direction) * progress;
        this.transform.localPosition = pos;
    }

    public void ParcePos()
    {
        Vector3 pos = this.transform.localPosition;
        int xpos = Mathf.RoundToInt(pos.x);
        int ypos = Mathf.RoundToInt(pos.y);
        int zpos = Mathf.RoundToInt(pos.z);
        position.SetData(xpos, ypos, zpos);
    }
    public void ParcePos(Vector3 dif)
    {
        Vector3 pos = this.transform.localPosition + dif;
        int xpos = Mathf.RoundToInt(pos.x);
        int ypos = Mathf.RoundToInt(pos.y);
        int zpos = Mathf.RoundToInt(pos.z);
        position.SetData(xpos, ypos, zpos);
    }

    public Point Shift3D(Point p, byte a)
    {
        Vector3 vc = way.ReturnWay3D(a);
        return new Point(p.x + (int)vc.x, p.y + (int)vc.y, p.z + (int)vc.z);
    }

    public void EndProgress()
    {
        position = Shift3D(position, direction);
    }

    public bool NewBlockReady()
    {
        return newBlockReady;
    }

    public Block GetNewBlock()
    {
        newBlockReady = false;
        return newBlockOfSnake;
    }

    public void CheckTheGround()
    {
        Vector3 w = way.ReturnWay3D(direction);
        Point poswanga = new Point(position.x + (int)w.x, position.y + (int)w.y, position.z + (int)w.z);
        bool imOk = false;
        foreach (GameObject go in around)
        {
            if (go != null)
            {
                if (go.tag == "Ground")
                {
                    Block bK = go.GetComponent<Block>();
                    if (poswanga.x == bK.position.x && poswanga.y == bK.position.y)
                    {
                        if (bK.position.z == 0)
                            imOk = true;
                    };
                };
                if (go.tag == "RealVision")
                {
                    Block bK = go.GetComponent<RealVision>().real;
                    if (poswanga.IsIdentical(bK.position))
                    {
                        newBlockOfSnake = bK;
                        newBlockReady = true;
                    };
                };

            }
            else
            {
                around.Remove(go);
            }
        };

        if(!imOk)
        {
            status = "FALLDOWN";
        }

       // Debug.Log(this.name + "  " + position.x + "  " + position.y + "  " + position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        around.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        around.Remove(other.gameObject);
    }

    public void UpdateModelWithStatus()
    {
        if(status == "FALLDOWN")
        {
            Debug.Log("Help me im falling");
        }
    }

    private void Start()
    {
        if (type == "GROUND")
        {
            ParcePos(new Vector3(0.5f,0.5f,-0.5f));
        };
        if(type == "ACTION")
        {
            ParcePos();
            Rectification();
        }
    }*/



    //New Old gen

    ///<summary>Position in the grid</summary>
    public Point position;


    /// <summary>
    /// Parsing position with grid
    /// </summary>
    /// <returns>Point</returns>
    public Point ParcePos()
    {
        Vector3 pos = this.transform.localPosition;
        int xpos = Mathf.RoundToInt(pos.x);
        int ypos = Mathf.RoundToInt(pos.y);
        int zpos = Mathf.RoundToInt(pos.z);
        return new Point(xpos, ypos, zpos);
    }

    /// <summary>
    /// Set position as point
    /// </summary>
    public void Rectification()
    {
        this.transform.localPosition = position.Pos3D();
    }





    //DEFAULT UNITY METHODS
    //USING FOR ACTIONS
    //AND ANITHING ELSE

    private void Start()
    {
        position = ParcePos();
        Rectification();
    }
}
