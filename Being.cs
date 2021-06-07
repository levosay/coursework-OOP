using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    //Базовый класс Существо
    public class Being
    {
        public string Name; //Имя существа
        public int HP; //Количество здоровья
        public int CarryWeight; //Переносимый вес
        public int Wallet; //Кошелек
        public List<Object> Inventory; //Инвентарь

       /* public Being(string name, int hp, int weight, int carrywallet, List<object> inventory)
        {
            this.Name = name;
            this.HP = hp;
            this.CarryWeight = weight;
            this.Wallet = carrywallet;
            this.Inventory = inventory;
        }*/

    }
}
