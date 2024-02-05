using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    protected override void TakeDamage(int damage)
    {
        damage *= 10;

        //base.TakeDamage(damage);
    }
}
