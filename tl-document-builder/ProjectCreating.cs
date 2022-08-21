using System;
using System.IO;
using System.Windows.Forms;

namespace tl_document_builder
{
    public partial class ProjectCreating : Form
    {
        public ProjectCreating()
        {
            InitializeComponent();
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            createFolderProject();
        }

        //Creates a project folder inside the application folder
        private void createFolderProject()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string projectFolder = Path.Combine(folder, "TLDocumentBuilder", ProjName.Text);
            Directory.CreateDirectory(projectFolder);

        }
    }
}
