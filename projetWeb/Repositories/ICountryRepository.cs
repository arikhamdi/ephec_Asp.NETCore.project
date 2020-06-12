using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetWeb.Models;

namespace projetWeb.Repositories
{
    public interface ICountryRepository
    {
        List<Country> SelectAll();
    }
}
