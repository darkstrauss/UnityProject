using UnityEngine;

[CreateAssetMenu(fileName = "NewTower", menuName = "ScriptableObjects/Tower")]
public class SO_Tower : ScriptableObject, ITower
{

    #region VARIABLES

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
    private ITower.FireType _towerFireType;
    public ITower.FireType TowerFireType
    {
        get => _towerFireType;
        set => _towerFireType = value;
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
    private GameObject _prefab;
    public GameObject Prefab
    {
        get => _prefab;
    }

    [SerializeField]
    private AnimationCurve _upgradeCurve;
    public AnimationCurve UpgradeCurve
    {
        get => _upgradeCurve;
        set => _upgradeCurve = value;
    }

    private SO_Tower _properties;
    public SO_Tower Properties
    {
        get => _properties;
        set => _properties = value;
    }

    private int _currentLevel;
    public int CurrentLevel
    {
        get => _currentLevel;
        set => _currentLevel = value;
    }

    public void FindTarget()
    {

    }

    public void Fire(IEnemy i_target)
    {

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

    #endregion

}
