using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBrick : Brick //Inheritance
{
    private int value = 3;

    protected void Awake()
    {
        base.pointValue = value;
    }

    public override void destorySelf()
    {
        GameManager.GetInstance().UpdateScore(value);
        Destroy(gameObject);
    }
}
