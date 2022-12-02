using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GoldBrick : Brick
{
    private int value = 3;

    protected void Awake()
    {
        base.pointValue = value;
    }

    // POLYMORPHISM
    public override void destorySelf()
    {
        GameManager.GetInstance().UpdateScore(value);
        Destroy(gameObject);
    }
}
