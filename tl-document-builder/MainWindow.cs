using System;
using System.IO;
using System.Windows.Forms;

namespace tl_document_builder
{
    static class MainWindow
    {
        [STAThread]
        static void Main()
        {
            //Create an application folder 
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(folder, "TLDocumentBuilder");
            Directory.CreateDirectory(appFolder);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
