namespace HelperApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            subMenuNotesPanel.Visible = false;
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            if (subMenuNotesPanel.Visible == false)
            {
                subMenuNotesPanel.Visible = true;
            }
            else
                subMenuNotesPanel.Visible = false;
        }

        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (childForm == null)
            {
                if (activeForm != null)
                    activeForm.Close();
                return;
            }

            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void toDoButton_Click(object sender, EventArgs e)
        {
            openChildForm(new To_DoForm());
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ProjectsForm());
        }

        public void exitButton_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}