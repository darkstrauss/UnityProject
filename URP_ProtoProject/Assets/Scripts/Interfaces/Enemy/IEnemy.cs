using UnityEngine;

public interface IEnemy
{
    float Health { get; set; }
    float Shield { get; set; }
    float Armor { get; set; }
    float MovementSpeed { get; set; }
    Mesh Visuals { get; set; }
    AnimationClip Clip { get; set; }

    void MoveToTarget(Vector3 i_target);
    void Damage(float i_damage, ITower i_damageSource);
    void Kill();

}
