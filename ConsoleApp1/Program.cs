using System;
using DAL.EF;
using DAL.Entities;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( ManagerReportContext db = new ManagerReportContext() )
            {                      
                ManagerReport user1 = new ManagerReport { ManagerFirstName = "Tom", ManagerLastName = "Jenkins", ClienFirstName = "Karl", ClientLastName  = "Sprezevalski", ProductName  = "Tomatos" , ProductCost = 3 };
                ManagerReport user2 = new ManagerReport { ManagerFirstName = "Martin", ManagerLastName = "Vainstaiger", ClienFirstName = "Oleg", ClientLastName = "Gulakov", ProductName = "Chips", ProductCost = 6 };

                // добавляем их в бд
                db.Reports.Add(user1);
                db.Reports.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var reports = db.Reports;
                Console.WriteLine("Список объектов:");
                foreach (ManagerReport u in reports)
                {
                    Console.WriteLine("{0},{1},{2},{3},{4},{5}",u.Id,u.ManagerFirstName,u.ManagerLastName,u.ClienFirstName,u.ClientLastName,u.ProductName);
                }
            }
            Console.Read();
        }
    }
}