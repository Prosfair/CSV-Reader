using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Views;
using DataAccess;
using Microsoft.VisualBasic.FileIO;

namespace CSV_Reader
{
    internal static class Program
    {
        /// The main entry point for the application.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            IMainView mainView = mainPresenter.GetMainView();


           
        }
    }
}

namespace DataAccess
{
    public class FileReader
    {
        public static string LocateFile()
        {
            OpenFileDialog FileFinder = new OpenFileDialog();

            if (FileFinder.ShowDialog() == DialogResult.OK)
            {
                if (FileFinder.FileName.Contains(".csv") == true)
                {
                    return FileFinder.FileName;
                }
                else
                {
                    return "fileTypeError";
                }
            }
            else
            {
                return null;
            }
        }
    }
}

namespace Model
{
    public class CSVModel  //Allows access to all CSV files
    { 
        public static string SelectFile()
            {
            MessageBox.Show("TEST");
            return FileReader.LocateFile();
            }

        
        public static String[] GetFileDataWithHeaders(string filepath)
        {
            String[] data = new string[System.IO.File.ReadAllLines(filepath).Length];

            using (TextFieldParser csvParser = new TextFieldParser(filepath))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                while (!csvParser.EndOfData)
                {      
                    data = csvParser.ReadFields(); // Read current line fields, pointer moves to the next line.
                }
                return data;
            }
        }

        public static String[] GetFileDataWithoutHeaders(string filepath)
        {
            String[] data = new string[System.IO.File.ReadAllLines(filepath).Length];

            using (TextFieldParser csvParser = new TextFieldParser(filepath))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                csvParser.ReadLine(); //Skip first line

                while (!csvParser.EndOfData)
                {
                    data = csvParser.ReadFields(); // Read current line fields, pointer moves to the next line.
                }
                return data;
            }
        }
    }
}

namespace Presenter
{
    public class BasePresenter : IBasePresenter
    {
        private IErrorMessage _errorMessageView;

        public BasePresenter()
        {

        }

        BasePresenter(IErrorMessage errorMessageView)
        {
            _errorMessageView = errorMessageView;  
        }

        public void ShowErrorMessage(string windowTitle, string errorMessage)
        {
          frmErrorMessage frmErrorMessage = new frmErrorMessage();
          frmErrorMessage.ShowErrorMessageView(windowTitle, errorMessage);
        }
    }
    
    public class MainPresenter : IMainPresenter
    {
        IMainView _mainView;

        public IMainView GetMainView() { return _mainView; }

        public MainPresenter(IMainView mainView)
        {
          _mainView = mainView;

            _mainView.btnLoadFileClick += (x, y) => Model.CSVModel.SelectFile();
        }


      

   






     private Views.frmMainView _view = null;




    }
}

