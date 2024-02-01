using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : MonoBehaviour, ITower
{
    [SerializeField]
    private SO_Tower properties;

    public int Cost { get; set; }
    public float Damage { get; set; }
    public float HealthDamageMultiplier { get; set; }
    public float ShieldDamageMultiplier { get; set; }
    public float ArmorDamageMultiplier { get; set; }
    public int Range { get; set; }
    public float FireRate { get; set; }

    public BaseTower()
    {
        Cost = properties.Cost;
        Damage = properties.Damage;
        HealthDamageMultiplier = properties.HealthDamageMultiplier;
        ShieldDamageMultiplier = properties.ShieldDamageMultiplier;
        ArmorDamageMultiplier = properties.ArmorDamageMultiplier;
        Range = properties.Range;
        FireRate = properties.FireRate;
    }

    public void Fire(IEnemy i_target)
    {
        i_target.Damage(Damage, this);
    }

    public void Upgrade()
    {
        
    }

    public void RefundTower()
    {

    }

}
