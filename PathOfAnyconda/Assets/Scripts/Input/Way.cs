using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way
{
    //Direction
    public byte direction;

    public Vector3 ReturnWay3D(byte a)
    {
        Vector3 res = new Vector3();
        switch(a)
        {
            case 1:
                res = new Vector3(0, 1, 0);
                break;
            case 2:
                res = new Vector3(-1, 0, 0);
                break;
            case 3:
                res = new Vector3(0, -1, 0);
                break;
            case 4:
                res = new Vector3(1, 0, 0);
                break;
            default:
                res = new Vector3(0, 0, 0);
                break;
        }
        return res;
    }



    private bool AntiDist(int d1, int d2)
    {
        if (d1 == 1 && d2 == 3)
            return true;
        if (d1 == 2 && d2 == 4)
            return true;
        if (d1 == 3 && d2 == 1)
            return true;
        if (d1 == 4 && d2 == 2)
            return true;
        return false;
    }

    public void AddToWay(byte new_value)
    {
        if (lenght < max_lenght)
        {
            if (lenght > 0 && theway[lenght - 1] != new_value  && !AntiDist(new_value, theway[lenght - 1]))
            {
                theway[lenght] = new_value;
                lenght++;
            }
            else
            if(lenght == 0 && last_dir != new_value && !AntiDist(new_value, last_dir))
            {
                theway[lenght] = new_value;
                lenght++;
            }
        }
        else if(lenght == max_lenght)
        {
            theway[lenght - 1] = new_value;
        };
    }

    public void AddNewSwipe(bool leftOrRight)
    {
        if (lenght < max_lenght)
        {
            byte tempdist;
            if (lenght > 1)
            {
                tempdist = theway[lenght - 1];
            }
            else
            {
                tempdist = last_dir;
            };

            byte next = leftOrRight ? (byte)(tempdist + 1) : (byte)(tempdist - 1);
            if (next > 4)
                next = 1;
            if (next == 0)
                next = 4;

            theway[lenght] = next;
            lenght++;
        }
    }

    public void DeleteLastItem()
    {
        if (lenght > 0)
        {
            if (lenght == 1)
                last_dir = theway[0];
            lenght--;
        }
    }

    //delete and <<< values
    public void DeleteFirstItem()
    {
        if (lenght > 0)
        {
            if (lenght == 1)
                last_dir = theway[0];
            for (byte i = 0; i < lenght; i++)
                theway[i] = theway[i + 1];
            theway[lenght] = 0;
            lenght--;
        }
    }

    public Vector3 GiveMeTheWay3D()
    {
        if (lenght > 0)
            return ReturnWay3D(theway[0]);
        return ReturnWay3D(last_dir);
    }
    public byte GiveMeTheWay()
    {
        if (lenght > 0)
            return theway[0];
        return last_dir;
    }
}
