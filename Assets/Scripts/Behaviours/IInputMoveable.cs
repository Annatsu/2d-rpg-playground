public interface IInputMoveable<T>
{
    public T MoveTowards(T currentPosition, T direction, float deltaTime);

    public bool CanMove();
}
