using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Dragon : Enemy
{
    protected override void AttackPlayer()
    {
        print("Dragon is attacking player");
    }
}