namespace mvp_template
{
    class MainPresenter : IPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;

            //todo
            //_view.{Event} += () => {Method}
        }

        //todo
        //public MainPresenter(IMainView view, ...)

        public void Run()
        {
            _view.Open();
        }
    }
}
