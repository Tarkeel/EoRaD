using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ISpecializationRepository
    {
        IEnumerable<Specialization> GetAll();
        Specialization GetSpecialization(int ID);
        Specialization GetSpecialization(string title);
        Specialization CreateOrGetSpecialization(string title, bool persist = true);
        void UpdateSpecialization(Specialization updated, bool persist = true);
        void DeleteSpecialization(Specialization deleted, bool persist = true);
    }
}