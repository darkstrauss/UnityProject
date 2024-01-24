
using UnityEngine;

[CreateAssetMenu(fileName = "NewTower", menuName = "ScriptableObjects/Tower")]
public class SO_Tower : ScriptableObject, ITower
{
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

    public void Fire(GameObject i_target)
    {
        
    }

    public void RefundTower()
    {
        
    }

    public void Upgrade()
    {
        
    }

}
