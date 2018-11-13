using CastleWindsorDI_Example.Views;

namespace CastleWindsorDI_Example.Presenters
{
    public interface IPresenter
    {
        void Display();

        void Initialize(IMainView view);

        void Speak();
    }
}
