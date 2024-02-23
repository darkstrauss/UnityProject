using Unity.VisualScripting;
using UnityEngine;

public interface ITower
{
    enum FireType
    {
        Bullet,
        Cone,
        Lazor
    }
    enum TowerType
    {
        None,
        Cannon,
        PoisonSprayer,
        FlameThrower,
        Lazor
    }
    SO_Tower Properties { get; }
    int Cost { get; set; }
    float Damage { get; set; }
    float HealthDamageMultiplier { get; set; }
    float ShieldDamageMultiplier { get; set; }
    float ArmorDamageMultiplier { get; set; }
    
    FireType TowerFireType { get; set; }
    int Range { get; set; }
    float FireRate { get; set; }
    int MaxLevel { get; }
    int CurrentLevel { get; set; }
    AnimationCurve UpgradeCurve { get; set; }
    GameObject Prefab { get; }


    void FindTarget();
    void Fire(IEnemy i_target);
    void Upgrade();
    void PlaceTower();
    void RefundTower();
}
