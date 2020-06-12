using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projetWeb.Models;

namespace projetWeb.Repositories
{
    public class CountrySqlRepository : ICountryRepository
    {
        private readonly AppDbContext db = null;

        public CountrySqlRepository(AppDbContext db)
        {
            // AppDbContext is injected into the constructor
            // db variable is then used by other methods
            // to execute the respective queries.
            this.db = db;
        }

        public List<Country> SelectAll()
        {
            // FromSqlRaw return a IQueryable<T>
            // and ToList get the data as a List<Establishment>
            List<Country> data = db.Countries.FromSqlRaw(
                "SELECT CountryID, Name FROM Country " +
                "ORDER BY Name ASC").ToList();
            return data;
        }
    }
}
