namespace MarsRoverKata.Tests;

public class RoverTests
{
    [Test]
    public void InitialiseRoverFacingThisDirection()
    {
        const string expectedDirection = "NORTH";

        var rover = new Rover(expectedDirection);

        Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
    }
}