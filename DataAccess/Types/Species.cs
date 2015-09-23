using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Species : Observable
    {
        internal Species()
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
        private int baseWound;
        public int BaseWound
        {
            get { return baseWound; }
            set { VerifyPropertyChange(ref baseWound, ref value); }
        }
        private int baseStrain;
        public int BaseStrain
        {
            get { return baseStrain; }
            set { VerifyPropertyChange(ref baseStrain, ref value); }
        }
        private int startXP;
        public int StartXP
        {
            get { return startXP; }
            set { VerifyPropertyChange(ref startXP, ref value); }
        }
        private string shortText;
        public string ShortText
        {
            get { return shortText; }
            set { VerifyPropertyChange(ref shortText, ref value); }
        }
        private string descriptionPhysiology;
        public string DescriptionPhysiology
        {
            get { return descriptionPhysiology; }
            set { VerifyPropertyChange(ref descriptionPhysiology, ref value); }
        }
        private string descriptionSociety;
        public string DescriptionSociety
        {
            get { return descriptionSociety; }
            set { VerifyPropertyChange(ref descriptionSociety, ref value); }
        }
        private string descriptionHomeworld;
        public string DescriptionHomeworld
        {
            get { return descriptionHomeworld; }
            set { VerifyPropertyChange(ref descriptionHomeworld, ref value); }
        }
        private string descriptionLanguage;
        public string DescriptionLanguage
        {
            get { return descriptionLanguage; }
            set { VerifyPropertyChange(ref descriptionLanguage, ref value); }
        }
        private string descriptionFringe;
        public string DescriptionFringe
        {
            get { return descriptionFringe; }
            set { VerifyPropertyChange(ref descriptionFringe, ref value); }
        }
        private string descriptionRebellion;
        public string DescriptionRebellion
        {
            get { return descriptionRebellion; }
            set { VerifyPropertyChange(ref descriptionRebellion, ref value); }
        }
        private string descriptionForce;
        public string DescriptionForce
        {
            get { return descriptionForce; }
            set { VerifyPropertyChange(ref descriptionForce, ref value); }
        }
        private string descriptionBonus;
        public string DescriptionBonus
        {
            get { return descriptionBonus; }
            set { VerifyPropertyChange(ref descriptionBonus, ref value); }
        }

        private ObservableCharacteristicValueCollection characteristicValues;
        public ObservableCharacteristicValueCollection CharacteristicValues { get { return characteristicValues; } }

    }
    public class ObservableSpeciesCollection : ObservableCollection<Species> { }
}