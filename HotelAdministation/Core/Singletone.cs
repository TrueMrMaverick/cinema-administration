using System;
using System.Collections.Generic;

namespace HotelAdministation.Core
{
    public class Singleton : Dictionary<Type, object>
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton()
        {
        }

        protected Singleton()
        {
        }

        public static IDictionary<Type, object> GetSingletonInstaces()
        {
            return instance;
        }
    }

    public class Singleton<T> : Singleton
    {
        private static T instance;

        //
        public static T Instance
        {
            get => instance;
            set
            {
                instance = value;
                GetSingletonInstaces()[typeof(T)] = value;
            }
        }
    }
}