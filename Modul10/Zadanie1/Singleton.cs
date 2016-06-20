using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Singleton<T> where T : class,new()
    {
        private static T instance;

        private Singleton()
        {
            return;
        }
        public static T getInstance()
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }

    }
}
