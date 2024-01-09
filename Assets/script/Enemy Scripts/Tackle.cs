using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tackle : MonoBehaviour
{
    class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool CheckCollision(Player player)
        {
            // Check for collision between enemy and player
            return (X == player.X && Y == player.Y);
        }
    }

    class Game
    {
        static void Main()
        {
            // Create instances of Player and Enemy
            Player player = new Player { X = 5, Y = 5 };
            Enemy enemy = new Enemy { X = 5, Y = 5 };

            // Check for collision
            if (enemy.CheckCollision(player))
            {
                Console.WriteLine("Game Over - Enemy touched the player!");
                // Add additional game over logic here
            }
            else
            {
                Console.WriteLine("No collision detected.");
                // Add other game logic here
            }
        }
    }
}
