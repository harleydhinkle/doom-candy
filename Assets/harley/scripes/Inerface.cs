using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IDamageable
{
    void takeDamage(int damageTaken,int pointgain, player_movment player);
}
