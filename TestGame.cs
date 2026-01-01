using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("3D Game Logic Test");
        Console.WriteLine("Use WASD keys, Space to jump, Q to quit");
        
        float x = 0, y = 0, z = 0;
        float moveSpeed = 5f;
        
        while (true)
        {
            Console.WriteLine($"Position: X={x:F1}, Y={y:F1}, Z={z:F1}");
            Console.Write("Input: ");
            
            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            switch (key)
            {
                case 'w': z += moveSpeed; break;
                case 's': z -= moveSpeed; break;
                case 'a': x -= moveSpeed; break;
                case 'd': x += moveSpeed; break;
                case ' ': y += 10; Console.WriteLine("Jump!"); break;
                case 'q': return;
            }
        }
    }
}