using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    /// <summary>
    /// Класс солдат.
    /// </summary>
    internal class Soldier
    {
        Gun _gun;
        public String _name { get; set; }
        public Soldier(Gun gun, String name = "undefined")
        {
            _gun = gun;
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void Fire()
        {
            _gun.Fire();
        }
    }
}
