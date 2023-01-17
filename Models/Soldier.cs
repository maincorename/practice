using ConsolePracticeApp.Interfaces;

namespace ConsolePracticeApp.Models
{
    /// <summary>
    /// Класс солдат.
    /// </summary>
    internal class Soldier : IUnit
    {
        /// <summary>
        /// Наименование юнита.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Здоровье юнита.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Оружие.
        /// </summary>
        public Gun Gun;

        /// <summary>
        /// Проверить здоровье.
        /// </summary>
        /// <returns> Здоровье. </returns>
        public int CheckHealth()
        {
            return Health;
        }

        /// <summary>
        /// Использовать аптечку.
        /// </summary>
        public void UseMedication() 
        {
            Health += 30;
        }

        /// <summary>
        /// Проверить жетон на груди.
        /// </summary>
        /// <returns> Имя солдата. </returns>
        public string CheckToken()
        {
            return Name;
        }

        /// <summary>
        /// Изменить имя.
        /// </summary>
        public void ChangeToken()
        {
            Console.WriteLine("Напишите новое имя для бойца: ");
            Name = Console.ReadLine() ?? "Боец не может быть без имени.";
        }

        /// <summary>
        /// Инициализация солдата.
        /// </summary>
        /// <param name="Gun"> Оружие. </param>
        /// <param name="Name"> Имя солдата. </param>
        public Soldier(Gun Gun, string Name = "Контуженный.")
        {
            this.Gun = Gun;
            this.Name = Name;
            Health = 100;
        }

        /// <summary>
        /// Движение солдата.
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Боец движется.");
        }

        /// <summary>
        /// Речь солдата.
        /// </summary>
        /// <param name="Speech"> Произнесённая фраза. </param>
        public void Say(string Speech)
        {
            Console.WriteLine($"Боец говорит: {Speech}!");
        }
    }
}
