namespace HelperApp
{
    partial class ProjectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            projectsGrid = new DataGridView();
            addNewProject = new Button();
            deleteProjectRow = new Button();
            nameProjectsTextBox = new TextBox();
            descriptionProjectsTextBox = new TextBox();
            pathToFolderTextBox = new TextBox();
            NameLabel = new Label();
            label2 = new Label();
            PathToFileLabel = new Label();
            openFolderBrowser = new Button();
            ((System.ComponentModel.ISupportInitialize)projectsGrid).BeginInit();
            SuspendLayout();
            // 
            // projectsGrid
            // 
            projectsGrid.AllowUserToAddRows = false;
            projectsGrid.AllowUserToDeleteRows = false;
            projectsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsGrid.BackgroundColor = Color.Tan;
            projectsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsGrid.Location = new Point(12, 48);
            projectsGrid.Name = "projectsGrid";
            projectsGrid.ReadOnly = true;
            projectsGrid.RowTemplate.Height = 25;
            projectsGrid.Size = new Size(630, 333);
            projectsGrid.TabIndex = 0;
            projectsGrid.CellClick += projectsGrid_CellClick;
            // 
            // addNewProject
            // 
            addNewProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addNewProject.Location = new Point(555, 395);
            addNewProject.Name = "addNewProject";
            addNewProject.Size = new Size(87, 37);
            addNewProject.TabIndex = 3;
            addNewProject.TabStop = false;
            addNewProject.Text = "Add";
            addNewProject.UseVisualStyleBackColor = true;
            addNewProject.Click += addNewProject_Click;
            // 
            // deleteProjectRow
            // 
            deleteProjectRow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteProjectRow.Location = new Point(555, 453);
            deleteProjectRow.Name = "deleteProjectRow";
            deleteProjectRow.Size = new Size(87, 38);
            deleteProjectRow.TabIndex = 4;
            deleteProjectRow.Text = "Delete";
            deleteProjectRow.UseVisualStyleBackColor = true;
            deleteProjectRow.Click += deleteProjectRow_Click;
            // 
            // nameProjectsTextBox
            // 
            nameProjectsTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameProjectsTextBox.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameProjectsTextBox.Location = new Point(110, 387);
            nameProjectsTextBox.Multiline = true;
            nameProjectsTextBox.Name = "nameProjectsTextBox";
            nameProjectsTextBox.Size = new Size(375, 37);
            nameProjectsTextBox.TabIndex = 5;
            // 
            // descriptionProjectsTextBox
            // 
            descriptionProjectsTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            descriptionProjectsTextBox.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionProjectsTextBox.Location = new Point(110, 436);
            descriptionProjectsTextBox.Multiline = true;
            descriptionProjectsTextBox.Name = "descriptionProjectsTextBox";
            descriptionProjectsTextBox.Size = new Size(375, 37);
            descriptionProjectsTextBox.TabIndex = 6;
            // 
            // pathToFolderTextBox
            // 
            pathToFolderTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pathToFolderTextBox.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pathToFolderTextBox.Location = new Point(110, 487);
            pathToFolderTextBox.Multiline = true;
            pathToFolderTextBox.Name = "pathToFolderTextBox";
            pathToFolderTextBox.Size = new Size(375, 37);
            pathToFolderTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(55, 395);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 19);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 444);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // PathToFileLabel
            // 
            PathToFileLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PathToFileLabel.AutoSize = true;
            PathToFileLabel.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PathToFileLabel.Location = new Point(5, 494);
            PathToFileLabel.Name = "PathToFileLabel";
            PathToFileLabel.Size = new Size(102, 19);
            PathToFileLabel.TabIndex = 10;
            PathToFileLabel.Text = "Path to folder";
            // 
            // openFolderBrowser
            // 
            openFolderBrowser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            openFolderBrowser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            openFolderBrowser.Location = new Point(491, 494);
            openFolderBrowser.Name = "openFolderBrowser";
            openFolderBrowser.Size = new Size(32, 19);
            openFolderBrowser.TabIndex = 11;
            openFolderBrowser.Text = "...";
            openFolderBrowser.UseVisualStyleBackColor = true;
            openFolderBrowser.Click += openFolderBrowser_Click;
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(654, 536);
            Controls.Add(openFolderBrowser);
            Controls.Add(PathToFileLabel);
            Controls.Add(label2);
            Controls.Add(NameLabel);
            Controls.Add(pathToFolderTextBox);
            Controls.Add(descriptionProjectsTextBox);
            Controls.Add(nameProjectsTextBox);
            Controls.Add(deleteProjectRow);
            Controls.Add(addNewProject);
            Controls.Add(projectsGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectsForm";
            Text = "ProjectsForm";
            Load += ProjectsForm_Load;
            ((System.ComponentModel.ISupportInitialize)projectsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView projectsGrid;
        private Button openFolderBrowser;
        private Button addNewProject;
        private Button deleteProjectRow;
        private TextBox nameProjectsTextBox;
        private TextBox descriptionProjectsTextBox;
        private TextBox pathToFolderTextBox;
        private Label NameLabel;
        private Label label2;
        private Label PathToFileLabel;
    }
}