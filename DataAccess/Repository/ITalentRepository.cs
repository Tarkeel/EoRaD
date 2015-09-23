using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ITalentRepository
    {
        IEnumerable<Talent> GetAll();
        Talent GetTalent(int ID);
        Talent GetTalent(string title);
        Talent CreateOrGetTalent(string title, bool persist = true);
        void UpdateTalent(Talent updated, bool persist = true);
        void DeleteTalent(Talent deleted, bool persist = true);
    }
}