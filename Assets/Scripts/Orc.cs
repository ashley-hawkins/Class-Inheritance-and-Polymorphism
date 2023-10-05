using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Orc : Enemy
{
    protected override void AttackPlayer()
    {
        print("Orc is attacking player");
    }
}
