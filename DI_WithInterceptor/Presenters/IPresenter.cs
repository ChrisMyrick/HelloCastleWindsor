using DiWithInterceptors.Views;

namespace DiWithInterceptors.Presenters
{
    public interface IPresenter
    {
        void Display();

        void Initialize(IMainView view);

        void DoSomething();
        void RobBank();
        void Shoot();
        void Arrest();
        void Speak();
    }
}
