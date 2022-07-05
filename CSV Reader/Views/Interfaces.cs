using System;

namespace Views
{
    public interface IErrorMessage
    {
        void ShowErrorMessageView(string windowTitle, string errorMessage);
    }

    public interface IBasePresenter
    {
       
    }

    public interface IMainPresenter
    {
        IMainView GetMainView();
    }

    public interface IMainView
    {
        event EventHandler btnLoadFileClick;
        void ShowMainView();
    }

}