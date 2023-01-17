namespace ConsolePracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя солдата: ");
            var nameSoldier = Console.ReadLine();
            if(nameSoldier is "")
            {
                Console.WriteLine("Имя не может быть пустым.");
            }

            var gun1 = new Gun();
            var gun2 = new Gun();

            var warrior2 = new Soldier(gun2, nameSoldier);
            var warrior = new Soldier(gun1);
           
            warrior.Fire();
            var ammo = gun1.CheckAmmo();

            while(ammo > 0)
            {
                warrior.Fire();
                Console.WriteLine(ammo);
                ammo = gun1.CheckAmmo();
            }

            gun1.Reload();
            Console.WriteLine("RELOADING! READY TO FIGHT!");

            var random = new Random();
            var value = random.Next(1, 10);
            Console.WriteLine(value);
            if (value > 0)
                Console.WriteLine(warrior2._name.ToString() + " is DEAD.");
        }
    }
}