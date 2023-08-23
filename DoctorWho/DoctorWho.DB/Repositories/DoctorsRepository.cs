using DoctorWho.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.DB.Repositories
{
    public class DoctorsRepository
    {
        private DoctorWhoCoreDBContext _dbContext; 
        public DoctorsRepository() 
        {
            _dbContext= new DoctorWhoCoreDBContext();
        }

        public void CreateDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Add(doctor);
            _dbContext.SaveChanges();
        }
        public void UpdateDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Update(doctor);
            _dbContext.SaveChanges();
        }
        public void DeleteDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Remove(doctor);
            _dbContext.SaveChanges();
        }
    }
}
