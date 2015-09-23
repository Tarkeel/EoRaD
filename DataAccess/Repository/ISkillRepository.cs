using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetAll();
        Skill GetSkill(int ID);
        Skill GetSkill(string title);
        Skill CreateOrGetSkill(Characteristic characteristic, string title, bool persist = true);
        void UpdateSkill(Skill updated, bool persist = true);
        void DeleteSkill(Skill deleted, bool persist = true);
    }
}