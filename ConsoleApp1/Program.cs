using System;
using DAL.EF;
using DAL.Entities;
using DAL.Repositories;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {           
            DAL.Interfaces.IRepository<DAL.Entities.ManagerReport> dd = new ManagerReportRepository();
                                            
            var user1 = new ManagerReport (DateTime.Now,"Jon","Vlad","Petrov","Tomatos",12);
            var user2 = new ManagerReport(DateTime.Now, "Jonas", "Hood", "Aroon", "Chips", 7);

            // добавляем их в бд
            dd.Create(user1);
            dd.Create(user2);
            dd.SaveChanges();
            //Console.WriteLine("Объекты успешно сохранены");

            // получаем объекты из бд и выводим на консоль
            
            var reports = dd.GetAll();
            Console.WriteLine("Список объектов:");
            foreach (ManagerReport u in reports)
            {
              Console.WriteLine("{0},{1},{2},{3},{4},{5}",u.Id,u.ManagerLastName,u.ClienFirstName,u.ClientLastName,u.ProductName,u.ProductCost);
            }
            
            Console.Read();
        }
    }
}