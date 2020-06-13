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
                "SELECT " +
                    "EstablishmentID, " +
                    "Name, " +
                    "EstablishmentType, " +
                    "Vat, " +
                    "EmailPro, " +
                    "Description, " +
                    "Logo, " +
                    "Street, " +
                    "StreetNumber, " +
                    "PostalCode, " +
                    "City, " +
                    "Country, " +
                    "PhoneNumber, " +
                    "EstablishmentEmail, " +
                    "WebSite, " +
                    "Instagram, " +
                    "Facebook, " +
                    "Linkedin " +
                "FROM Establishment " +
                "ORDER BY EstablishmentID ASC").ToList();
            return data;  
        }

        public Establishment SelectByID(int id)
        {
            // return null if no match is found
            Establishment est = db.Establishments.FromSqlRaw(
                "SELECT " +
                    "EstablishmentID, " +
                    "Name, " +
                    "EstablishmentType, " +
                    "Vat, " +
                    "EmailPro, " +
                    "Description, " +
                    "Logo, " +
                    "Street, " +
                    "StreetNumber, " +
                    "PostalCode, " +
                    "City, " +
                    "Country, " +
                    "PhoneNumber, " +
                    "EstablishmentEmail, " +
                    "WebSite, " +
                    "Instagram, " +
                    "Facebook, " +
                    "Linkedin " +
                "FROM Establishment " +
                "WHERE EstablishmentID={0}", id).SingleOrDefault();  
            return est; 
        }

        public void Insert(Establishment est)
        {
            // The ExecuteSqlRaw() executes the action query
            // and returns the number of records affected by it
            int count = db.Database.ExecuteSqlRaw(
                "INSERT INTO Establishment(" +
                    "Name, " +
                    "EstablishmentType, " +
                    "Vat, " +
                    "EmailPro, " +
                    "Description, " +
                    "Logo, " +  
                    "Street, " +
                    "StreetNumber, " +
                    "PostalCode, " +
                    "City, " +
                    "Country, " +
                    "PhoneNumber, " +
                    "EstablishmentEmail, " +
                    "WebSite, " +
                    "Instagram, " +
                    "Facebook, " +
                    "Linkedin " +
                ") VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}," +
                " {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16})",
                est.Name, est.EstablishmentType, est.Vat, est.EmailPro, est.Description, est.Logo,
                est.Street, est.StreetNumber, est.PostalCode, est.City, est.Country,
                est.PhoneNumber, est.EstablishmentEmail, est.WebSite, est.Instagram,
                est.Facebook, est.Linkedin);
        }

        public void Update(Establishment est)
        {
            // The ExecuteSqlRaw() executes the action query
            // and returns the number of records affected by it
            int count = db.Database.ExecuteSqlRaw(
                "UPDATE Establishment SET " +
                    "Name={0}, " +
                    "EstablishmentType={1}, " +
                    "Vat={2}, " +
                    "EmailPro={3}, " +
                    "Description={4}, " +
                    "Logo={5}, " +
                    "Street={6}, " +
                    "StreetNumber={7}, " +
                    "PostalCode={8}, " +
                    "City={9}, " +
                    "Country={10}, " +
                    "PhoneNumber={11}, " +
                    "EstablishmentEmail={12}, " +
                    "WebSite={13}, " +
                    "Instagram={14}, " +
                    "Facebook={15}, " +
                    "Linkedin={16} " +
                "WHERE EstablishmentID={17}",
                est.Name, est.EstablishmentType, est.Vat, est.EmailPro, est.Description,
                est.Logo, est.Street, est.StreetNumber, est.PostalCode, est.City, est.Country,
                est.PhoneNumber, est.EstablishmentEmail, est.WebSite, est.Instagram,
                est.Facebook, est.Linkedin, est.EstablishmentID);
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
