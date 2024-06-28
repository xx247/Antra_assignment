using System;

namespace Day06_assignment.ColorBall;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    // Constructor
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Pop method
    public void Pop()
    {
        size = 0;
    }

    // Throw method
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    // Method to get the throw count
    public int GetThrowCount()
    {
        return throwCount;
    }

    public override string ToString()
    {
        return $"Ball(Size={size}, Color={color}, ThrowCount={throwCount})";
    }
}
