using System;

namespace Singleton
{
    class SingletonTesting
    {
        static void Main(string[] args)
        {
            string data = "Something important...";
            DataBase dataBase = DataBase.GetInstance();
            dataBase.StoreData(data);
            DataBase dataBase2 = DataBase.GetInstance();

            string data1 = dataBase.LoadData();
            string data2 = dataBase2.LoadData();
            Console.WriteLine($"Database 1: {data1} \nDatabase 2: {data2}");
        }
    }
}
