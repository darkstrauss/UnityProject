
public interface IEnemy
{
    float Health { get; set; }
    float Shield { get; set; }
    float Armor { get; set; }
    float MovementSpeed { get; set; }

    void Enemy(float health, float shield, float armor, float movementSpeed);
    void Damage(float damage, ITower damageSource);
    void Kill();

}
