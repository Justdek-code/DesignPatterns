using System;

namespace Singleton
{
    class DataBase
    {
        private static DataBase _instance;
        private string _data;   

        public static DataBase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataBase();
            }

            return _instance;
        }

        public void StoreData(string data)
        {
            _data = data;
        }

        public string LoadData()
        {
            return _data;
        }
    }
}