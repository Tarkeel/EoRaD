using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class CharacteristicValue : Observable
    {
        internal CharacteristicValue(Characteristic _characteristic)
        {
            characteristic = _characteristic;
        }
        private Characteristic characteristic;
        public Characteristic Characteristic { get { return characteristic; } }

        private int value;
        public long Value
        {
            get { return value; }
            set { VerifyPropertyChange(ref value, ref value); }
        }
    }

    public class ObservableCharacteristicValueCollection : ObservableCollection<CharacteristicValue> { }

}
