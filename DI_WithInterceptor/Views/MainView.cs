using System;
using System.Windows.Forms;
using DiWithInterceptors.Presenters;

namespace DiWithInterceptors.Views
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
