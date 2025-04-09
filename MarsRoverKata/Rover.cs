namespace MarsRoverKata;

public class Rover
{
    public string Direction { get; }
    public int XCoordinate { get; }
    public int YCoordinate { get; }

    public Rover(string direction, int xCoordinate, int yCoordinate)
    {
        Direction = direction;
        XCoordinate = xCoordinate;
        YCoordinate = yCoordinate;
    }
}