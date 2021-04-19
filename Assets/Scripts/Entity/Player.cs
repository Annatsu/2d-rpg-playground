using UnityEngine;

public class Player : Entity, IInputMoveable<Vector2>
{
    public bool CanMove()
    {
        return ActiveEntityState != EntityState.ATTACKING;
    }

    public Vector2 MoveTowards(Vector2 currentPosition, Vector2 direction, float deltaTime)
    {
        return currentPosition + direction * 2f * deltaTime;
    }
}
