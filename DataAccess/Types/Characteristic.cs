using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Characteristic : Observable
    {
        internal Characteristic()
        {
            skills = new ObservableSkillCollection();
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

        private ObservableSkillCollection skills;
        public ObservableSkillCollection Skills { get { return skills; } }
    }
    public class ObservableCharacteristicCollection : ObservableCollection<Characteristic> { }
}
