using Day06_assignment;
using System;
using Day06_assignment._4BasicPrinciple;
using Day06_assignment.PersonType;
using Day06_assignment.PersonService;
using Day06_assignment.ColorBall;

////reverse an array
//ReverseArray.Reverse();

////Fibonacci
//int[] fib = Fibonacci.Fib(10);
//foreach (int i in fib)
//{
//    Console.Write(i+" ");
//}

////1. 4 basic principles
//Shape shape = new Rectangle(5.0,3.0);
//Console.WriteLine(shape.Area());

////2.3.4.5. define different classes for each person type
//Person[] person = new Person[2];
//person[0] = new Students("Tom", 12, 2);
//person[1] = new Instructor("Dennis", 30, "CS",5000);
//person[0].Behavior();
//person[1].Behavior();


// 7. Color ball
Color redColor = new Color(255, 0, 0);
Color greenColor = new Color(0, 255, 0);
Color blueColor = new Color(0, 0, 255);

// Create Ball instances
Ball redBall = new Ball(10, redColor);
Ball greenBall = new Ball(15, greenColor);
Ball blueBall = new Ball(20, blueColor);

// Throw the balls
redBall.Throw();
redBall.Throw();
greenBall.Throw();

// Pop the blue ball and try to throw it
blueBall.Pop();
blueBall.Throw();

// Print the number of times each ball has been thrown
Console.WriteLine($"Red ball thrown {redBall.GetThrowCount()} times.");
Console.WriteLine($"Green ball thrown {greenBall.GetThrowCount()} times.");
Console.WriteLine($"Blue ball thrown {blueBall.GetThrowCount()} times.");

// Print the grayscale value of the colors
Console.WriteLine($"Red color grayscale value: {redColor.GetGrayscale()}");
Console.WriteLine($"Green color grayscale value: {greenColor.GetGrayscale()}");
Console.WriteLine($"Blue color grayscale value: {blueColor.GetGrayscale()}");

// Print ball details
Console.WriteLine(redBall);
Console.WriteLine(greenBall);
Console.WriteLine(blueBall);