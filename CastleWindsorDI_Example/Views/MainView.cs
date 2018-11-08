using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CastleWindsorDI_Example.Presenters;

namespace CastleWindsorDI_Example.Views
{
    public partial class MainView : Form, IMainView
    {
        private IPresenter Presenter { get; }

        public MainView(IPresenter presenter)
        {
            InitializeComponent();

            Presenter = presenter;
            Presenter.Initialize(this);

            // bind events
        }

        public string Message {
            get=> this.lblMessage.Text;
            set=> this.lblMessage.Text = value;
        }

        private void btnRobBank_Click(object sender, EventArgs e)
        {
            Presenter.RobBank();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            Presenter.Shoot();
        }

        private void btnArrest_Click(object sender, EventArgs e)
        {
            Presenter.Arrest();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            Presenter.Speak();
        }
    }
}
