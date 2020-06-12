using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetWeb.Models;

namespace projetWeb.Repositories
{
    public interface IEstablishmentRepository
    {
        List<Establishment> SelectAll();
        Establishment SelectByID(int id);
        void Insert(Establishment est);
        void Update(Establishment est);
        void Delete(int id);

    }
}
