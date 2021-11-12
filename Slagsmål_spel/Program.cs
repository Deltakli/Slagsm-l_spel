using System;

int heroHp = 100;
int enemieHp = 100;
Random generator = new Random();

 

  
while (heroHp > 0 && enemieHp > 0)
{

  Console.WriteLine("\n----- ===== NEW ROUND ===== -----");
  Console.WriteLine($"HERO: {heroHp}  ENEMIE: {enemieHp}\n");

  int heroDamage = generator.Next(20);
  enemieHp -= heroDamage;
  enemieHp = Math.Max(0, enemieHp);
  Console.WriteLine($"HERO does {heroDamage} damage on ENEMIE");

  int enemieDamage = generator.Next(30);
  heroHp -= enemieDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"ENEMIE does {enemieDamage} damage on HERO");

  Console.WriteLine("Press E to use potion");
  string p = Console.ReadLine();
  if (p == "e")
  {
    heroHp = heroHp + 20;
    Console.WriteLine($"Healed to {heroHp} hp.");
  }

  Console.WriteLine("Press any button to countinue");
  Console.ReadLine();

}
Console.WriteLine("\n----- ===== Battle is over! ===== -----");

if (heroHp == 0 && enemieHp == 0)
{
  Console.WriteLine("A TIE!");
}
else if (heroHp == 0)
{
  Console.WriteLine("ENEMIE WON!");
}
else
{
  Console.WriteLine("HERO WON!");
}


Console.WriteLine("Press any button to end.");
Console.ReadKey(); 
