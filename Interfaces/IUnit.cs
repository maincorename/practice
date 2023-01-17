namespace ConsolePracticeApp.Interfaces
{
    /// <summary>
    /// Интерфейс для юнитов.
    /// </summary>
    internal interface IUnit
    { 
        /// <summary>
        /// Движение юнита.
        /// </summary>
        public void Move();

        /// <summary>
        /// Метод разговора юнита.
        /// </summary>
        /// <returns> Речь. </returns>
        public void Say(string Speech);
    }
}
