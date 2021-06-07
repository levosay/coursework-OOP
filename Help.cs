using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    //интерфейс Помощь
    public interface Help
    {
        //void GetEffect(); //метод Получить эффект
        int effect { get; } //количество восстанавливаемого за одну сессию лечения здоровья
    }

    public class HelpHP : Object, Help // зелье лечения
    {
        public int effect { get; }
    }
}
