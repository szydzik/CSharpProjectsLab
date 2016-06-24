using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public sealed class Singleton<T> where T : class,new()
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

    public sealed class Singleton2<T> where T : class, new()
    {
        private static object _syncobj = new object();
        private static volatile T _instance = null;

        public Singleton2()
        {
        }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
