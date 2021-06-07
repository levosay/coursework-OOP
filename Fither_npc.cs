using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    public class Fither_npc : Being, Fighter, Dealer
    {
        public string error;
        public void Attack(Being sub, Weapon wea)
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
        public void Receive(Being sub, Thing obj)
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
                error = "У персонажа" + this.Name + "нет этого предмета";
            }
        }
        public void Give(Being sub, Thing obj)
        {
            if (obj.Price < sub.Wallet && this.Inventory.Contains(obj) == true)
            {
                sub.Inventory.Add(obj);
                sub.Wallet -= obj.Price;
                sub.CarryWeight += obj.Weight;

                this.Wallet += obj.Price;
                this.CarryWeight -= obj.Weight;
                this.Inventory.Remove(obj);
            }
            else if (this.Inventory.Contains(obj) == false)
            {
                error = "У персонажа" + this.Name + "нет этого предмета";
            }
        }
    }
}
