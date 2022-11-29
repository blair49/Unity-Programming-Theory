using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzeBrick : Brick //inheritance
{
    private int value = 1;

    protected void Awake()
    {
        base.pointValue = value;
    }

}
