using ConsolePracticeApp.Models;

namespace ConsolePracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GunAK = new Gun("АК-47", 30);
            var SoldierOleg = new Soldier(GunAK, "Олег");

            Console.WriteLine(SoldierOleg.Name + " готов.");
            var checkedAmmo = SoldierOleg.Gun.CheckAmmo();
            Console.WriteLine("Кол-во патронов: " + checkedAmmo);
            Console.WriteLine("Модель оружия: " + SoldierOleg.Gun.Name);

            Console.WriteLine("Стреляем?");
            Console.ReadKey(true);
            SoldierOleg.Gun.Shoot();
            SoldierOleg.Gun.Fire();
            SoldierOleg.Gun.Reload();
            Console.WriteLine(SoldierOleg.Name + " готов.");
        }
    }
}