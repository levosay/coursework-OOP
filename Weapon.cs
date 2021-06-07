using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    //интерфейс Оружие
    public interface Weapon
    {
       //void ReceiveDamage(); //метод Получить урон
        int Damage { get; }
    }

    public class NWeapon : Object, Weapon // оружие
    {
        public int Damage { get; }
    }
}
