using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "ScriptableObjects/Enemy")]
public class SO_Enemy : ScriptableObject
{
    [SerializeField]
    private float _health;
    public float Health
    {
        get => _health;
        set => _health = value;
    }

    [SerializeField]
    private float _shield;
    public float Shield
    {
        get => _shield;
        set => _shield = value;
    }

    [SerializeField]
    private float _armor;
    public float Armor
    {
        get => _armor;
        set => _armor = value;
    }

    [SerializeField]
    private float _movementSpeed;
    public float MovementSpeed
    {
        get => _movementSpeed;
        set => _movementSpeed = value;
    }

    [SerializeField]
    private Mesh _visualMesh;
    public Mesh VisualMesh
    {
        get => _visualMesh;
        set => _visualMesh = value;
    }

    [SerializeField]
    private AnimationClip _clip;
    public AnimationClip Clip
    {
        get => _clip;
        set => _clip = value;
    }
}
