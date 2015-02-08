using Microsoft.Practices.Unity;

namespace mvp_template
{
    class ApplicationController : IApplicationController
    {
        public IApplicationController RegisterView<TView, TImplementation>()
            where TView : IView
            where TImplementation : class, TView
        {
            DependencyFactory.Container.RegisterType<TView, TImplementation>("");
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if(!DependencyFactory.Container.IsRegistered<TPresenter>())
            {
                DependencyFactory.Container.RegisterType<TPresenter>();
            }
            var presenter = DependencyFactory.Resolve<TPresenter>();
            presenter.Run();
        }
    }
}
