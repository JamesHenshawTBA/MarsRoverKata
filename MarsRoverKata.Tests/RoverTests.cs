namespace MarsRoverKata.Tests;

public class RoverTests
{
    [Test]
    public void InitialiseRoverFacingThisDirection()
    {
        const string expectedDirection = "NORTH";

        var rover = new Rover(expectedDirection, 0, 0);

        Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
    }

    [Test]
    public void InitialiseRoverWithTheseCoordinates()
    {
        const int xCoordinate = 2;
        const int yCoordinate = 4;

        var rover = new Rover("NORTH", xCoordinate, yCoordinate);

        Assert.That(rover.XCoordinate, Is.EqualTo(xCoordinate));
        Assert.That(rover.YCoordinate, Is.EqualTo(yCoordinate));
    }
}