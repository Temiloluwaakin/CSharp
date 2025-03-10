using System;

public static class SpeedCamera
{
    public static void CheckSpeed()
    {
        Console.Write("Enter speed limit: ");
        string speedLimitInput = Console.ReadLine();

        Console.Write("Enter the speed of the car: ");
        string carSpeedInput = Console.ReadLine();

        bool isSpeedLimitValid = int.TryParse(speedLimitInput, out int speedLimit);
        bool isCarSpeedValid = int.TryParse(carSpeedInput, out int carSpeed);

        if (isSpeedLimitValid && isCarSpeedValid)
        {
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int excessSpeed = carSpeed - speedLimit;
                int demeritPoints = excessSpeed / 5;

                Console.WriteLine($"Demerit Points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License has been Suspended");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }
}
