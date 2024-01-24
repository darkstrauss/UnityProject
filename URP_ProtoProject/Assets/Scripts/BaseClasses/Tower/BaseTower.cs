using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : MonoBehaviour, ITower
{
    public int Cost { get; set; }
    public float Damage { get; set; }
    public float HealthDamageMultiplier { get; set; }
    public float ShieldDamageMultiplier { get; set; }
    public float ArmorDamageMultiplier { get; set; }
    public int Range { get; set; }
    public float FireRate { get; set; }

    public BaseTower(int i_cost, int i_damage, float i_healthDamageMultiplier, float i_shieldDamageMultiplier, float i_armorDamageMultiplier, int i_range, float i_fireRate)
    {
        Cost = i_cost;
        Damage = i_damage;
        HealthDamageMultiplier = i_healthDamageMultiplier;
        ShieldDamageMultiplier = i_shieldDamageMultiplier;
        ArmorDamageMultiplier = i_armorDamageMultiplier;
        Range = i_range;
        FireRate = i_fireRate;
    }

    public void Fire(GameObject i_target)
    {
        
    }

    public void Upgrade()
    {
        
    }

    public void RefundTower()
    {

    }

}
