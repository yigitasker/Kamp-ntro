using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Managaer(),                        // bu yolla bir nesneye atama yapmadan kullanabileceğimiz çalışma işlemi başlattık.
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();                        // Manager,Worker,Robot interface den impemente ettikleri work metodunu kendi içlerinde çalıştırır.
            }


            IEat[] eats = new IEat[2]
            {
                new Managaer(),
                new Worker()                        // Robot tanımlanamaz çünkü robot class'ını IEat interface ne implemente etmedik.
            };


            foreach (var eat in eats)
            {
                eat.Eat();
            }




        }
    }







    interface IWorker
    {
        void Work();
        
    }


    interface IEat
    {
        void Eat();
        
    }


    interface ISalary
    {
        void GetSalary();
    }







    class Managaer : IWorker, IEat, ISalary                 // bir class birden fazla interface' i implement edebilir.
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }



    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }



    class Robot : IWorker                              // robot ne yemek yer nede maaş alır.
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }


}
