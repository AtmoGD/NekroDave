using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Crystal : AttackTower
{
    public Action OnCrystalDestroyed;

    public override void Die()
    {
        OnCrystalDestroyed?.Invoke();

        base.Die();
    }
}
