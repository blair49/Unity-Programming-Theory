using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class Brick : MonoBehaviour
{
    protected int pointValue;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            takeDamage();
            if (pointValue <= 0)
                destorySelf();
        }
    }

    void takeDamage()
    {
        pointValue--;
    }

    public virtual void destorySelf()
    {
        GameManager.GetInstance().UpdateScore(1);
        Destroy(gameObject);
    }
}
