namespace HelperApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            exitButton = new Button();
            settingsButton = new Button();
            helpButton = new Button();
            projectsButton = new Button();
            subMenuNotesPanel = new Panel();
            page3Button = new Button();
            page2Button = new Button();
            page1Button = new Button();
            notesButton = new Button();
            toDoButton = new Button();
            topPanelHome = new Panel();
            buttonsCRUDpanel = new Panel();
            childFormPanel = new Panel();
            panelMenu.SuspendLayout();
            subMenuNotesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSlateGray;
            panelMenu.Controls.Add(exitButton);
            panelMenu.Controls.Add(settingsButton);
            panelMenu.Controls.Add(helpButton);
            panelMenu.Controls.Add(projectsButton);
            panelMenu.Controls.Add(subMenuNotesPanel);
            panelMenu.Controls.Add(notesButton);
            panelMenu.Controls.Add(toDoButton);
            panelMenu.Controls.Add(topPanelHome);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 581);
            panelMenu.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightSteelBlue;
            exitButton.Dock = DockStyle.Bottom;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(0, 536);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(10, 0, 0, 0);
            exitButton.Size = new Size(250, 45);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Dock = DockStyle.Top;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            settingsButton.Location = new Point(0, 417);
            settingsButton.Name = "settingsButton";
            settingsButton.Padding = new Padding(5, 0, 0, 0);
            settingsButton.Size = new Size(250, 45);
            settingsButton.TabIndex = 6;
            settingsButton.Text = "Settings";
            settingsButton.TextAlign = ContentAlignment.MiddleLeft;
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            helpButton.Dock = DockStyle.Top;
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            helpButton.Location = new Point(0, 372);
            helpButton.Name = "helpButton";
            helpButton.Padding = new Padding(5, 0, 0, 0);
            helpButton.Size = new Size(250, 45);
            helpButton.TabIndex = 5;
            helpButton.Text = "Help";
            helpButton.TextAlign = ContentAlignment.MiddleLeft;
            helpButton.UseVisualStyleBackColor = true;
            // 
            // projectsButton
            // 
            projectsButton.Dock = DockStyle.Top;
            projectsButton.FlatAppearance.BorderSize = 0;
            projectsButton.FlatStyle = FlatStyle.Flat;
            projectsButton.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            projectsButton.Location = new Point(0, 327);
            projectsButton.Name = "projectsButton";
            projectsButton.Padding = new Padding(5, 0, 0, 0);
            projectsButton.Size = new Size(250, 45);
            projectsButton.TabIndex = 4;
            projectsButton.Text = "Projects";
            projectsButton.TextAlign = ContentAlignment.MiddleLeft;
            projectsButton.UseVisualStyleBackColor = true;
            projectsButton.Click += projectsButton_Click;
            // 
            // subMenuNotesPanel
            // 
            subMenuNotesPanel.Controls.Add(page3Button);
            subMenuNotesPanel.Controls.Add(page2Button);
            subMenuNotesPanel.Controls.Add(page1Button);
            subMenuNotesPanel.Dock = DockStyle.Top;
            subMenuNotesPanel.Location = new Point(0, 190);
            subMenuNotesPanel.Name = "subMenuNotesPanel";
            subMenuNotesPanel.Size = new Size(250, 137);
            subMenuNotesPanel.TabIndex = 3;
            // 
            // page3Button
            // 
            page3Button.BackColor = Color.SlateGray;
            page3Button.Dock = DockStyle.Top;
            page3Button.FlatAppearance.BorderSize = 0;
            page3Button.FlatStyle = FlatStyle.Flat;
            page3Button.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            page3Button.Location = new Point(0, 90);
            page3Button.Name = "page3Button";
            page3Button.Padding = new Padding(15, 0, 0, 0);
            page3Button.Size = new Size(250, 45);
            page3Button.TabIndex = 2;
            page3Button.Text = "Page 3";
            page3Button.TextAlign = ContentAlignment.MiddleLeft;
            page3Button.UseVisualStyleBackColor = false;
            // 
            // page2Button
            // 
            page2Button.BackColor = Color.SlateGray;
            page2Button.Dock = DockStyle.Top;
            page2Button.FlatAppearance.BorderSize = 0;
            page2Button.FlatStyle = FlatStyle.Flat;
            page2Button.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            page2Button.Location = new Point(0, 45);
            page2Button.Name = "page2Button";
            page2Button.Padding = new Padding(15, 0, 0, 0);
            page2Button.Size = new Size(250, 45);
            page2Button.TabIndex = 1;
            page2Button.Text = "Page 2";
            page2Button.TextAlign = ContentAlignment.MiddleLeft;
            page2Button.UseVisualStyleBackColor = false;
            // 
            // page1Button
            // 
            page1Button.BackColor = Color.SlateGray;
            page1Button.Dock = DockStyle.Top;
            page1Button.FlatAppearance.BorderSize = 0;
            page1Button.FlatStyle = FlatStyle.Flat;
            page1Button.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            page1Button.Location = new Point(0, 0);
            page1Button.Name = "page1Button";
            page1Button.Padding = new Padding(15, 0, 0, 0);
            page1Button.Size = new Size(250, 45);
            page1Button.TabIndex = 0;
            page1Button.Text = "Page 1";
            page1Button.TextAlign = ContentAlignment.MiddleLeft;
            page1Button.UseVisualStyleBackColor = false;
            // 
            // notesButton
            // 
            notesButton.Dock = DockStyle.Top;
            notesButton.FlatAppearance.BorderSize = 0;
            notesButton.FlatStyle = FlatStyle.Flat;
            notesButton.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            notesButton.Location = new Point(0, 145);
            notesButton.Name = "notesButton";
            notesButton.Padding = new Padding(5, 0, 0, 0);
            notesButton.Size = new Size(250, 45);
            notesButton.TabIndex = 2;
            notesButton.Text = "Notes";
            notesButton.TextAlign = ContentAlignment.MiddleLeft;
            notesButton.UseVisualStyleBackColor = true;
            notesButton.Click += notesButton_Click;
            // 
            // toDoButton
            // 
            toDoButton.Dock = DockStyle.Top;
            toDoButton.FlatAppearance.BorderSize = 0;
            toDoButton.FlatStyle = FlatStyle.Flat;
            toDoButton.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            toDoButton.Location = new Point(0, 100);
            toDoButton.Name = "toDoButton";
            toDoButton.Padding = new Padding(5, 0, 0, 0);
            toDoButton.Size = new Size(250, 45);
            toDoButton.TabIndex = 1;
            toDoButton.Text = "To-Do List";
            toDoButton.TextAlign = ContentAlignment.MiddleLeft;
            toDoButton.UseVisualStyleBackColor = true;
            toDoButton.Click += toDoButton_Click;
            // 
            // topPanelHome
            // 
            topPanelHome.BackColor = Color.LightSlateGray;
            topPanelHome.BackgroundImage = (Image)resources.GetObject("topPanelHome.BackgroundImage");
            topPanelHome.BackgroundImageLayout = ImageLayout.Stretch;
            topPanelHome.Dock = DockStyle.Top;
            topPanelHome.Location = new Point(0, 0);
            topPanelHome.Name = "topPanelHome";
            topPanelHome.Size = new Size(250, 100);
            topPanelHome.TabIndex = 0;
            // 
            // buttonsCRUDpanel
            // 
            buttonsCRUDpanel.BackColor = SystemColors.ScrollBar;
            buttonsCRUDpanel.Dock = DockStyle.Bottom;
            buttonsCRUDpanel.Location = new Point(250, 536);
            buttonsCRUDpanel.Name = "buttonsCRUDpanel";
            buttonsCRUDpanel.Size = new Size(654, 45);
            buttonsCRUDpanel.TabIndex = 1;
            // 
            // childFormPanel
            // 
            childFormPanel.BackColor = SystemColors.ControlDark;
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Location = new Point(250, 0);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(654, 536);
            childFormPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 581);
            Controls.Add(childFormPanel);
            Controls.Add(buttonsCRUDpanel);
            Controls.Add(panelMenu);
            MinimumSize = new Size(920, 620);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Helper";
            panelMenu.ResumeLayout(false);
            subMenuNotesPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel topPanelHome;
        private Button notesButton;
        private Button toDoButton;
        private Panel subMenuNotesPanel;
        private Button page3Button;
        private Button page2Button;
        private Button page1Button;
        private Button exitButton;
        private Button settingsButton;
        private Button helpButton;
        private Button projectsButton;
        private Panel buttonsCRUDpanel;
        private Panel childFormPanel;
    }
}