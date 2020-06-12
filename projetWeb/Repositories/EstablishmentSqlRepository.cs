using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projetWeb.Models;

namespace projetWeb.Repositories
{
    public class EstablishmentSqlRepository: IEstablishmentRepository
    {
        private readonly AppDbContext db = null;

        public EstablishmentSqlRepository(AppDbContext db)
        {
            this.db = db;
        }

        public List<Establishment> SelectAll()
        {
            // FromSqlRaw return a IQueryable<T>
            // and ToList get the data as a List<Establishment>
            List<Establishment> data = db.Establishments.FromSqlRaw(
                "SELECT EstablishmentID,Name FROM Establishment " +
                "ORDER BY EstablishmentID ASC").ToList();
            return data;  
        }

        public Establishment SelectByID(int id)
        {
            // return null if no match is found
            Establishment est = db.Establishments.FromSqlRaw(
                "SELECT EstablishmentID, Name FROM Establishment " +
                "WHERE EstablishmentID={0}", id).SingleOrDefault();  
            return est; 
        }

        public void Insert(Establishment est)
        {
            // The ExecuteSqlRaw() executes the action query
            // and returns the number of records affected by it
            int count = db.Database.ExecuteSqlRaw(
                "INSERT INTO Establishment(Name) VALUES({0})", est.Name);
        }

        public void Update(Establishment est)
        {
            // The ExecuteSqlRaw() executes the action query
            // and returns the number of records affected by it
            int count = db.Database.ExecuteSqlRaw(
                "UPDATE Establishment SET Name={0} WHERE EstablishmentID={1}",
                est.Name, est.EstablishmentID);
        }

        public void Delete(int id)
        {
            // The ExecuteSqlRaw() executes the action query
            // and returns the number of records affected by it
            int count = db.Database.ExecuteSqlRaw(
                "DELETE FROM Establishment WHERE EstablishmentID={0}", id);
        }
    }
}
