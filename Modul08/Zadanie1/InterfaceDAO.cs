using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public interface InterfaceDAO<T>
    {
        T select(int id);

        List<T> selectAll();

        void update(T obj);

        void insert(T obj);

        void delete(int id);
    }
}
