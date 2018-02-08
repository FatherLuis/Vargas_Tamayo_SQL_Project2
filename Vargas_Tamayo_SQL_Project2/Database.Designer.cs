namespace Vargas_Tamayo_SQL_Project2
{
    partial class Database
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditViewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditViewFaculty = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvViewData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1342, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(64, 36);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(268, 38);
            this.mnuFileExit.Text = "&Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAdd,
            this.mnuEditView});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(67, 36);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditAdd
            // 
            this.mnuEditAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.newTeacherToolStripMenuItem});
            this.mnuEditAdd.Name = "mnuEditAdd";
            this.mnuEditAdd.Size = new System.Drawing.Size(268, 38);
            this.mnuEditAdd.Text = "&Add";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.newStudentToolStripMenuItem.Text = "&New Student";
            // 
            // newTeacherToolStripMenuItem
            // 
            this.newTeacherToolStripMenuItem.Name = "newTeacherToolStripMenuItem";
            this.newTeacherToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.newTeacherToolStripMenuItem.Text = "New &Faculty";
            // 
            // mnuEditView
            // 
            this.mnuEditView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditViewStudent,
            this.mnuEditViewFaculty});
            this.mnuEditView.Name = "mnuEditView";
            this.mnuEditView.Size = new System.Drawing.Size(268, 38);
            this.mnuEditView.Text = "&View";
            // 
            // mnuEditViewStudent
            // 
            this.mnuEditViewStudent.Name = "mnuEditViewStudent";
            this.mnuEditViewStudent.Size = new System.Drawing.Size(268, 38);
            this.mnuEditViewStudent.Text = "&Students";
            // 
            // mnuEditViewFaculty
            // 
            this.mnuEditViewFaculty.Name = "mnuEditViewFaculty";
            this.mnuEditViewFaculty.Size = new System.Drawing.Size(268, 38);
            this.mnuEditViewFaculty.Text = "&Faculty";
            // 
            // dgvViewData
            // 
            this.dgvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewData.Location = new System.Drawing.Point(0, 44);
            this.dgvViewData.Name = "dgvViewData";
            this.dgvViewData.RowTemplate.Height = 33;
            this.dgvViewData.Size = new System.Drawing.Size(1342, 829);
            this.dgvViewData.TabIndex = 1;
            this.dgvViewData.Visible = false;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 873);
            this.Controls.Add(this.dgvViewData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Database";
            this.Text = "Database";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditView;
        private System.Windows.Forms.ToolStripMenuItem mnuEditViewStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuEditViewFaculty;
        private System.Windows.Forms.DataGridView dgvViewData;
    }
}