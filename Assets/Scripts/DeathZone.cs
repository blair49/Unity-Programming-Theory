using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            Destroy(other.gameObject);
            GameManager.GetInstance().GameOver();
        }
    }
}
