using UnityEngine;

public interface ITower
{
    SO_Tower Properties { get; }
    int Cost { get; set; }
    float Damage { get; set; }
    float HealthDamageMultiplier { get; set; }
    float ShieldDamageMultiplier { get; set; }
    float ArmorDamageMultiplier { get; set; }
    int Range { get; set; }
    float FireRate { get; set; }
    int MaxLevel { get; }
    int CurrentLevel { get; set; }
    AnimationCurve UpgradeCurve { get; set; }


    void FindTarget();
    void Fire(IEnemy i_target);
    void Upgrade();
    void PlaceTower();
    void RefundTower();
}
