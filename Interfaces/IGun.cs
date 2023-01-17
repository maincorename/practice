namespace ConsolePracticeApp.Interfaces
{
    /// <summary>
    /// Интерфейс оружия.
    /// </summary>
    internal interface IGun
    {
        /// <summary>
        /// Выстрел из оружия.
        /// </summary>
        /// <param name="target"> Цель для выстрела. </param>
        public void Shoot(object? target = null);

        /// <summary>
        /// Перезарядка оружия.
        /// </summary>
        public void Reload();
    }
}
