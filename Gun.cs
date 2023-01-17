using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    /// <summary>
    /// Класс оружия.
    /// </summary>
    internal class Gun
    {
        int AmmoCount;
        public Gun()
        {
            Reload();
        }
        public void Reload()
        {
            AmmoCount = 10;
        }
        public int CheckAmmo()
        {
            return AmmoCount;
        }
        public void Fire()
        {
            AmmoCount -= 1;
        }
    }
}
