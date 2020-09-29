using UnityEngine;

public class Point
{
    public int x = 0;
    public int y = 0;
    public int z = 0;

    public Point(){}

    public Point(int newX, int newY, int newZ)
    {
        x = newX;
        y = newY;
        z = newZ;
    }

    public void SetData(int newX, int newY, int newZ)
    {
        x = newX;
        y = newY;
        z = newZ;
    }

    public Vector3 Pos3D()
    {
        return new Vector3(x, y, z);
    }

    public bool IsIdentical(Point p)
    {
        if (p.x == x && p.y == y && p.z == z)
            return true;
        return false;
    }
}
