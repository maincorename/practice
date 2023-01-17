using ConsolePracticeApp.Interfaces;

namespace ConsolePracticeApp.Models
{
    /// <summary>
    /// Класс оружия.
    /// </summary>
    internal class Gun : IGun
    {
        /// <summary>
        /// Патроны.
        /// </summary>
        public int Ammo { get; set; }

        /// <summary>
        /// Наименование оружия.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Перезаряжаемые патроны.
        /// </summary>
        public int ReloadingAmmo;

        /// <summary>
        /// Иниицализация оружия.
        /// </summary>
        /// <param name="Name"> Наименование оружия. </param>
        /// <param name="Ammo"> Кол-во патронов. </param>
        public Gun(string Name, int Ammo)
        {
            this.Name = Name;
            ReloadingAmmo = Ammo;
            Reload();
        }

        /// <summary>
        /// Проверить имя оружия.
        /// </summary>
        /// <returns> Имя оружия. </returns>
        public string CheckNameGun()
        {
            return Name;
        }

        /// <summary>
        /// Изменить имя оружия.
        /// </summary>
        public void ChangeNameGun()
        {
            Console.WriteLine("Введите новое имя для оружия: ");
            Name = Console.ReadLine() ?? "Имя не может быть пустым.";
        }

        /// <summary>
        /// Перезарядить оружие.
        /// </summary>
        public void Reload()
        {
            Ammo = ReloadingAmmo;
        }

        /// <summary>
        /// Проверить патроны.
        /// </summary>
        /// <returns> Кол-во патронов. </returns>
        public int CheckAmmo()
        {
            return Ammo;
        }

        /// <summary>
        /// Зажим курка.
        /// </summary>
        public void Fire()
        {
            Console.WriteLine("Очередь выстрелов.");
            while(Ammo > 0)
            {
                Console.WriteLine("Пиу");
                Ammo -= 1;
            }
            Console.WriteLine("Закончились патроны.");
        }

        /// <summary>
        /// Одиночный выстрел.
        /// </summary>
        /// <param name="target"> Цель для выстрела. </param>
        public void Shoot(object? target = null)
        {
            Console.WriteLine("Одиночный выстрел.");
            Ammo -= 1;
        }
    }
}
