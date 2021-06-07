using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5
{
    //интерфейс Лекарь
    public interface Doctor
    {
        void Treat(Being nps, HelpHP help); //метод Лечить
    }
}
