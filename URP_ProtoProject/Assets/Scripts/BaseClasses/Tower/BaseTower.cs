using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTower : MonoBehaviour, ITower
{
    #region VARIABLES

    [SerializeField]
    private SO_Tower _properties;
    public SO_Tower Properties 
    { 
        get => _properties; 
    }

    [SerializeField]
    private int _cost;
    public int Cost
    {
        get => _cost;
        set => _cost = value;
    }

    [SerializeField]
    private float _damage;
    public float Damage
    {
        get => _damage;
        set => _damage = value;
    }

    [SerializeField]
    private float _healthDamageMultiplier;
    public float HealthDamageMultiplier
    {
        get => _healthDamageMultiplier;
        set => _healthDamageMultiplier = value;
    }

    [SerializeField]
    private float _shieldDamageMultiplier;
    public float ShieldDamageMultiplier
    {
        get => _shieldDamageMultiplier;
        set => _shieldDamageMultiplier = value;
    }

    [SerializeField]
    private float _armorDamageMultiplier;
    public float ArmorDamageMultiplier
    {
        get => _armorDamageMultiplier;
        set => _armorDamageMultiplier = value;
    }

    [SerializeField]
    private int _range;
    public int Range
    {
        get => _range;
        set => _range = value;
    }

    [SerializeField]
    private float _fireRate;
    public float FireRate
    {
        get => _fireRate;
        set => _fireRate = value;
    }

    [SerializeField]
    private int _maxLevel;
    public int MaxLevel
    {
        get => _maxLevel;
        set => _maxLevel = value;
    }

    [SerializeField]
    private int _currentLevel;
    public int CurrentLevel
    {
        get => _currentLevel;
        set => _currentLevel = value;
    }

    [SerializeField]
    private Mesh _visualMesh;
    public Mesh VisualMesh
    {
        get => _visualMesh;
        set => _visualMesh = value;
    }

    [SerializeField]
    private AnimationCurve _upgradeCurve;
    public AnimationCurve UpgradeCurve
    {
        get => _upgradeCurve;
        set => _upgradeCurve = value;
    }

    #endregion

    #region CONSTRUCTION

    public BaseTower()
    {
        Cost = Properties.Cost;
        Damage = Properties.Damage;
        HealthDamageMultiplier = Properties.HealthDamageMultiplier;
        ShieldDamageMultiplier = Properties.ShieldDamageMultiplier;
        ArmorDamageMultiplier = Properties.ArmorDamageMultiplier;
        Range = Properties.Range;
        FireRate = Properties.FireRate;
        MaxLevel = Properties.MaxLevel;
        VisualMesh = Properties.VisualMesh;
    }

    #endregion

    #region FUNCTIONS

    public void Fire(IEnemy i_target)
    {
        i_target.Damage(Damage, this);
    }

    public void Upgrade()
    {

    }

    public void PlaceTower()
    {

    }

    public void RefundTower()
    {

    }

    public void FindTarget()
    {
        
    }

    #endregion


}
