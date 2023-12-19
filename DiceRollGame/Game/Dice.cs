﻿namespace DiceRollGame.Game;
public class Dice
{
    private readonly int SidesCount = 6;
    private readonly Random _random;
    public Dice(Random random)
    {
        _random = random;
    }
    public int Roll() => _random.Next(1, SidesCount + 1);
    public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides");
}
