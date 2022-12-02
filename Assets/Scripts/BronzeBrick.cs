using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BronzeBrick : Brick
{
    private int value = 1;

    protected void Awake()
    {
        base.pointValue = value;
    }

}
