using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Entities;
using System.IO;

namespace Task4
{
    class DbHandler
    {
        IRepository<DAL.Entities.ManagerReport> managerRepository;
        
        public DbHandler()
        {
            managerRepository = new DAL.Repositories.ManagerReportRepository();            
        }         
        public void AddReportToDatabase(DTO.ManagerReport report)
        {                                
            
            lock (this)
            {
                var newReport = new DAL.Entities.ManagerReport (report.ReportDate,report.ManagerLastName,report.ClienFirstName,report.ClientLastName,report.ProductName,report.ProductCost);               
                managerRepository.Create(newReport); 
                managerRepository.SaveChanges();
            }
            
        }
        public IEnumerable<DAL.Entities.ManagerReport> getAll()
        {
            IEnumerable<DAL.Entities.ManagerReport> reports = managerRepository.GetAll();
            return reports;
        }
    }
}

