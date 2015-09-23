using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Career : Observable
    {
        internal Career()
        {
            careerSkills = new ObservableSkillCollection();
            specializations = new ObservableSpecializationCollection();
        }
        private long id;
        public long ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }
        private string shortDesc;
        public string ShortDesc
        {
            get { return shortDesc; }
            set { VerifyPropertyChange(ref shortDesc, ref value); }
        }
        private string longDesc;
        public string LongDesc
        {
            get { return longDesc; }
            set { VerifyPropertyChange(ref longDesc, ref value); }
        }

        private ObservableSkillCollection careerSkills;
        public ObservableSkillCollection CareerSkills { get { return careerSkills; } }
        private ObservableSpecializationCollection specializations;
        private ObservableSpecializationCollection Specializations;
    }
    public class ObservableCareerCollection : ObservableCollection<Career> { }
}