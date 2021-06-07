using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    public class Healer: Being, Fighter, Dealer, Doctor  //новый класс Хил, наследующий базовый класс Существо, а также интерфейсы Торговец, Лекарь
    {
        public string error;
        public void Treat(Being sub, HelpHP help) //реализация метода Лечение
        {
            if (this.Inventory.Contains(help) == true)
            {
                sub.HP += help.effect;
                this.Inventory.Remove(help);
            }
        }
        public void Attack(Being sub, Weapon wea) //реализация метода Атака
        {
            if (sub.HP > 0 && this.Inventory.Contains(wea) == true)
            {
                sub.HP -= wea.Damage;
            }
            else
            {
                error = "Персонаж" + sub.Name + "уже мертв";
            }
        }
        public void Receive(Being sub, Thing obj)  //реализация метода Отдать
        {
            if (obj.Price < this.Wallet && sub.Inventory.Contains(obj) == true)
            {
                this.Inventory.Add(obj);
                this.Wallet -= obj.Price;
                this.CarryWeight += obj.Weight;

                sub.Wallet += obj.Price;
                sub.CarryWeight -= obj.Weight;
                sub.Inventory.Remove(obj);
            }
            else if (sub.Inventory.Contains(obj) == false)
            {
                error = "У персонажа" + sub.Name + "нет этого предмета";
            }
        }

        public void Give(Being sub, Thing obj)  //реализация метода Взять
        {
            if (obj.Price < this.Wallet && sub.Inventory.Contains(obj) == true)
            {
                this.Inventory.Add(obj);
                this.Wallet -= obj.Price;
                this.CarryWeight += obj.Weight;

                sub.Wallet += obj.Price;
                sub.CarryWeight -= obj.Weight;
                sub.Inventory.Remove(obj);
            }
            else if (sub.Inventory.Contains(obj) == false)
            {
                error = "У персонажа" + sub.Name + "нет этого предмета";
            }
        }
    }
}
