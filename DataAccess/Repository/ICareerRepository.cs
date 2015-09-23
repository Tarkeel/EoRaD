using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICareerRepository
    {
        IEnumerable<Career> GetAll();
        Career GetCareer(int ID);
        Career GetCareer(string title);
        Career CreateOrGetCareer(string title, bool persist = true);
        void UpdateCareer(Career updated, bool persist = true);
        void DeleteCareer(Career deleted, bool persist = true);
    }
}