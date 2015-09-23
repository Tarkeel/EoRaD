using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICharacteristicRepository
    {
        IEnumerable<Characteristic> GetAll();
        Characteristic GetCharacteristic(int ID);
        Characteristic GetCharacteristic(string title);
        Characteristic CreateOrGetCharacteristic(string title, bool persist = true);
        void UpdateCharacteristic(Characteristic updated, bool persist = true);
        void DeleteCharacteristic(Characteristic deleted, bool persist = true);
    }
}