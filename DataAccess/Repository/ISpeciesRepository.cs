using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ISpeciesRepository
    {
        IEnumerable<Species> GetAll();
        Species GetSpecies(int ID);
        Species GetSpecies(string title);
        Species CreateOrGetSpecies(string title, bool persist = true);
        void UpdateSpecies(Species updated, bool persist = true);
        void DeleteSpecies(Species deleted, bool persist = true);
    }
}