using Unity.Mathematics;

public class Cell
{
    public int3 Position;
    public byte State; // 1 = vivante, 2 = zone active

    public Cell(int3 position, byte state)
    {
        Position = position;
        State = state;
    }
}
