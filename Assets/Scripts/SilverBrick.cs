using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SilverBrick : Brick
{
    int value = 2;

    protected void Awake()
    {
        base.pointValue = value;
    }

    // POLYMORPHISM
    public override void destorySelf()
    {
        GameManager.GetInstance().UpdateScore(value);
        Destroy(gameObject, 0.2f);
    }
}
