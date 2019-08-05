using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingleClass
    {
        private SingleClass()
        {
            Random r = new Random();
            deger = r.Next();
        }
        private static SingleClass _instance;
        private static SingleClass instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingleClass();
                }
                return _instance;

            }
            set
            {
                _instance = value;
            }

        }
        public int deger;
        public static SingleClass getInstance()
        {
            return instance;
        }
    }
}
