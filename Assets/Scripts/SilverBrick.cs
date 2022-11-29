using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverBrick : Brick //Inheritance
{
    int value = 2;

    protected void Awake()
    {
        base.pointValue = value;
    }

    public override void destorySelf()
    {
        GameManager.GetInstance().UpdateScore(value);
        Destroy(gameObject, 0.2f);
    }
}
