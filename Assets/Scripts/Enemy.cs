using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    void Start()
    {
        AttackPlayer();
    }

    protected virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }
}
