using CastleWindsorDI_Example.DomainObjects;
using CastleWindsorDI_Example.Interfaces;
using CastleWindsorDI_Example.Views;
using System;
using System.Windows.Forms;

namespace CastleWindsorDI_Example.Presenters
{
    public class Presenter : IPresenter
    {
        private MainView View { get; set; }
        private ICriminal Criminal { get; set; }
        private IPoliceOfficer PoliceOfficer { get; set; }

        public Presenter(ICriminal criminal, IPoliceOfficer officer, IPersonFactory personFactory) 
        {
            // We need to remember to compose a person with the criminal. 
            // A factory maybe needed as the creation process gets more complicated.
            criminal.Personify(personFactory.Create("Joker", "criminal", 46, 198));
            Criminal = criminal;

            // Similarly, compose a peron with the officer 
            officer.Personify(personFactory.Create("Batman", "police officer", 39, 214));
            PoliceOfficer = officer;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Initialize(IMainView view)
        {
            view.Message = "This is a message from the presenter.";
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        public void RobBank()
        {
            Criminal.RobBank();
        }

        public void Shoot()
        {
            PoliceOfficer.Shoot();
        }

        public void Arrest()
        {
            PoliceOfficer.Arrest();
        }

        public void Speak()
        {
            var criminalQuote = Criminal.Speak();
            var policeQuote = PoliceOfficer.Speak();
            MessageBox.Show($"{criminalQuote} said the criminal. {Environment.NewLine} {Environment.NewLine} {policeQuote} said the police officer.");
            
        }

        public void WhoWeAre()
        {
            MessageBox.Show($"{Criminal.WhomAmI()} said the criminal. {Environment.NewLine} {Environment.NewLine} {PoliceOfficer.WhomAmI()} said the police officer.");
        }

        public void CriminalShootGun()
        {
            // Now, let's give the criminal a gun and ask him to attack.
            var handgun = new Handgun(9, "Glock Special");
            Criminal.Attack(handgun);
        }

        public void ShowCriminalWeaponDesc()
        {
            Criminal.ShowWeaponDescription();
        }
    }
}
