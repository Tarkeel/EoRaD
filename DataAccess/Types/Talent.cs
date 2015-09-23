using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Talent : Observable
    {
        internal Talent()
        {

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
        private Boolean ranked;
        public Boolean Ranked
        {
            get { return ranked; }
            set { VerifyPropertyChange(ref ranked, ref value); }
        }
        private string activation;
        public string Activation
        {
            get { return activation; }
            set { VerifyPropertyChange(ref activation, ref value); }
        }
        private string shortText;
        public string ShortText
        {
            get { return shortText; }
            set { VerifyPropertyChange(ref shortText, ref value); }
        }
        private string longText;
        public string LongText
        {
            get { return longText; }
            set { VerifyPropertyChange(ref longText, ref value); }
        }
    }
    public class ObservableTalentCollection : ObservableCollection<Talent> { }
}