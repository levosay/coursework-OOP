using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    //интерфейс Торговец
    public interface Dealer
    {
        void Receive(Being dealer, Thing obj); //метод Получить
        void Give(Being dealer, Thing obj); //метод Отдать
    }
}
