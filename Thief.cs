using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    //интерфейс Вор
    public interface Thief
    {
        void Receive(Being dealer, Thing obj); //метод Получить, аналогичный Торговцу, но с другой реализацией
    }
}
