using System;
using Builder;

class Program
{
    static void Main(string[] args)
    {
        var enemyBuilder = new EnemyBuilder();
        var heroBuilder = new HeroBuilder();

        var director = new UnitDirector(enemyBuilder);
        var enemy1 = director.ConstructUnit("Joe", 180, "Average","Warrior", "Steal food and beat up the seller"); 
        enemy1.ShowUnitInfo();

        director = new UnitDirector(heroBuilder);
        var hero1 = director.ConstructUnit("John", 175, "Athletic", "Knight", "Protect the villagers");
        hero1.ShowUnitInfo();
    }
}