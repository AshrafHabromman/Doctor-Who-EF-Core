

using DoctorWho.DB.Models;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace DoctorWho.DB.Repositories
{
    public class AuthorsRepository
    {
        private DoctorWhoCoreDBContext _dbContext;

        public AuthorsRepository()
        {
            _dbContext= new DoctorWhoCoreDBContext();  
        }

        public void CreateAuthor(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();

        }
        public void UpdateAuthor(Author author)
        {
            _dbContext.Authors.Update(author);
            _dbContext.SaveChanges();
        }
        public void DeleteAuthor(Author author)
        {
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }
    }
}
