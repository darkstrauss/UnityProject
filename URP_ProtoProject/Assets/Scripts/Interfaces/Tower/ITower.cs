using UnityEngine;

public interface ITower
{
    int Cost { get; set; }
    float Damage { get; set; }
    float HealthDamageMultiplier { get; set; }
    float ShieldDamageMultiplier { get; set; }
    float ArmorDamageMultiplier { get; set; }
    int Range { get; set; }
    float FireRate { get; set; }

    void Fire(GameObject i_target);
    void Upgrade();
    void RefundTower();
}
