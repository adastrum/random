namespace mvp_template
{
    interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;
    }
}
