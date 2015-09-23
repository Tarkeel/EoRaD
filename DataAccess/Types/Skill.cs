using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Skill : Observable
    {
        internal Skill(Characteristic _characteristic)
        {
            characteristic = _characteristic;
            characteristic.Skills.Add(this);
        }

        private long id;
        public long ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { VerifyPropertyChange(ref title, ref value); }
        }
        private string group;
        public string Group
        {
            get { return group; }
            set { VerifyPropertyChange(ref group, ref value); }
        }
        private Characteristic characteristic;
        public Characteristic Characteristic
        {
            get { return characteristic; }
            set
            {
                Characteristic oldValue = characteristic;
                if (VerifyPropertyChange(ref characteristic, ref value))
                {
                    if (oldValue != null) { oldValue.Skills.Remove(this); }
                    if (characteristic != null) { characteristic.Skills.Add(this); }
                }
            }
        }
    }
    public class ObservableSkillCollection : ObservableCollection<Skill> { }
}
