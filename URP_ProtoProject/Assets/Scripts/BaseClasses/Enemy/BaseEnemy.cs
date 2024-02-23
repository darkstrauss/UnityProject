using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour, IEnemy
{
    #region VARIABLES

    [SerializeField]
    private SO_Enemy properties;
    public SO_Enemy Properties
    {
        get { return properties; }
    }

    [SerializeField]
    private float _health;
    public float Health
    {
        get { return _health; }
        set { _health = Mathf.Clamp(value, 0, float.MaxValue); }
    }

    [SerializeField]
    private float _shield;
    public float Shield
    {
        get { return _shield; }
        set { _shield = Mathf.Clamp(value, 0, float.MaxValue); }
    }

    [SerializeField]
    private float _armor;
    public float Armor
    {
        get { return _armor; }
        set { _armor = Mathf.Clamp(value, 0, float.MaxValue); }
    }

    [SerializeField]
    private float _movementSpeed;
    public float MovementSpeed
    {
        get { return _movementSpeed; }
        set { _movementSpeed = value; }
    }

    [SerializeField]
    private Mesh _visuals;
    public Mesh Visuals
    {
        get { return _visuals; }
        set { _visuals = value; }
    }

    [SerializeField]
    private AnimationClip _clip;
    public AnimationClip Clip
    {
        get { return _clip; }
        set { _clip = value; }
    }

    #endregion


    public BaseEnemy()
    {
        
    }

    protected virtual void Start()
    {
        ValidateProperties(Properties);
    }

    private void OnValidate()
    {
        ValidateProperties(Properties);
    }

    private void ValidateProperties(SO_Enemy i_properties)
    {
        Health = i_properties.Health;
        Shield = i_properties.Shield;
        Armor = i_properties.Armor;
        MovementSpeed = i_properties.MovementSpeed;
        Visuals = i_properties.VisualMesh;
        Clip = i_properties.Clip;
    }


    public void Damage(float i_damage, ITower i_damageSource)
    {
        if (Shield > 0)
        {
            Shield -= i_damage * i_damageSource.ShieldDamageMultiplier;
        }
        else if (Armor > 0)
        {
            Armor -= i_damage * i_damageSource.ArmorDamageMultiplier;
        }
        else
        {
            Health -= i_damage * i_damageSource.HealthDamageMultiplier;
        }


        if (Health <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(this);
    }

    public void MoveToTarget(Vector3 i_target)
    {
        
    }
}
