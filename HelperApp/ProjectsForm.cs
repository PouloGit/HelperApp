using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace HelperApp
{
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
        {
            InitializeComponent();
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "NameColumn";
            nameColumn.Width = 150;
            projectsGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.Name = "DescriptionColumn";
            descriptionColumn.Width = 250;
            projectsGrid.Columns.Add(descriptionColumn);

            DataGridViewLinkColumn pathColumn = new DataGridViewLinkColumn();
            pathColumn.HeaderText = "Path to folder";
            pathColumn.Name = "PathColumn";
            pathColumn.LinkBehavior = LinkBehavior.SystemDefault;
            pathColumn.Width = 250;
            projectsGrid.Columns.Add(pathColumn);
        }

        private void openFolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathToFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        private void addNewProject_Click(object sender, EventArgs e)
        {
            string name = nameProjectsTextBox.Text;
            string description = descriptionProjectsTextBox.Text;
            string path = pathToFolderTextBox.Text;

            int rowIndex = projectsGrid.Rows.Add();

            projectsGrid.Rows[rowIndex].Cells["NameColumn"].Value = name;
            projectsGrid.Rows[rowIndex].Cells["DescriptionColumn"].Value = description;
            projectsGrid.Rows[rowIndex].Cells["PathColumn"].Value = path;
        }

        private void deleteProjectRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.projectsGrid.SelectedRows)
            {
                projectsGrid.Rows.RemoveAt(item.Index);
            }
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private void projectsGridFolderPath_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = projectsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewLinkCell)
                {
                    string path = cell.Value.ToString();
                    OpenFolder(path);
                }
            }
        }
        
    }
}
