using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Numerics; // Required for Vector2

public class EnemyMovement : MonoBehaviour
{
    class Enemy
    {
        public System.Numerics.Vector2 Position { get; private set; }
        public float Speed { get; private set; }

        public Enemy(System.Numerics.Vector2 position, float speed)
        {
            Position = position;
            Speed = speed;
        }

        public void MoveTowardsPlayer(System.Numerics.Vector2 playerPosition)
        {
            // Calculate direction from enemy to player
            System.Numerics.Vector2 direction = System.Numerics.Vector2.Normalize(playerPosition - Position);

            // Move enemy towards the player
            Position += direction * Speed;
        }
    }

    class Program
    {
        static void Main()
        {
            // Example usage
            System.Numerics.Vector2 playerPosition = new System.Numerics.Vector2(10, 10); // Replace this with actual player position
            Enemy enemy = new Enemy(new System.Numerics.Vector2(5, 5), 1.5f); // Initial enemy position and speed

            // Simulate movement in a loop (this would be in your game loop)
            for (int i = 0; i < 10; i++) // Replace with your actual game loop condition
            {
                // Update enemy movement towards the player
                enemy.MoveTowardsPlayer(playerPosition);

                // Print or use enemy position in your game
                Console.WriteLine($"Enemy Position: ({enemy.Position.X}, {enemy.Position.Y})");

                // Simulate game tick delay
                System.Threading.Thread.Sleep(500); // Delay for demonstration purposes
            }
        }
    }
}
