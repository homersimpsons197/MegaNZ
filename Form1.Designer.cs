namespace meganz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConnect = new Button();
            lblState = new Label();
            lblStatus = new Label();
            btnDisconnect = new Button();
            gboxConnection = new GroupBox();
            gboxDloadPath = new GroupBox();
            lblFolderName = new Label();
            label1 = new Label();
            btnPath = new Button();
            txtPath = new TextBox();
            gboxDloadProgress = new GroupBox();
            btnDownload = new Button();
            lblFilename = new Label();
            progressBar = new ProgressBar();
            gboxConnection.SuspendLayout();
            gboxDloadPath.SuspendLayout();
            gboxDloadProgress.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.ForeColor = Color.Black;
            btnConnect.Location = new Point(10, 25);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.ForeColor = Color.Black;
            lblState.Location = new Point(10, 60);
            lblState.Name = "lblState";
            lblState.Size = new Size(46, 17);
            lblState.TabIndex = 1;
            lblState.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(60, 60);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "OFFLINE";
            // 
            // btnDisconnect
            // 
            btnDisconnect.ForeColor = Color.Black;
            btnDisconnect.Location = new Point(95, 25);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // gboxConnection
            // 
            gboxConnection.Controls.Add(btnConnect);
            gboxConnection.Controls.Add(lblStatus);
            gboxConnection.Controls.Add(btnDisconnect);
            gboxConnection.Controls.Add(lblState);
            gboxConnection.ForeColor = Color.Black;
            gboxConnection.Location = new Point(10, 10);
            gboxConnection.Name = "gboxConnection";
            gboxConnection.Size = new Size(180, 90);
            gboxConnection.TabIndex = 4;
            gboxConnection.TabStop = false;
            gboxConnection.Text = "Connection";
            // 
            // gboxDloadPath
            // 
            gboxDloadPath.Controls.Add(lblFolderName);
            gboxDloadPath.Controls.Add(label1);
            gboxDloadPath.Controls.Add(btnPath);
            gboxDloadPath.Controls.Add(txtPath);
            gboxDloadPath.ForeColor = Color.Black;
            gboxDloadPath.Location = new Point(200, 10);
            gboxDloadPath.Name = "gboxDloadPath";
            gboxDloadPath.Size = new Size(475, 90);
            gboxDloadPath.TabIndex = 5;
            gboxDloadPath.TabStop = false;
            gboxDloadPath.Text = "Download location";
            // 
            // lblFolderName
            // 
            lblFolderName.AutoSize = true;
            lblFolderName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFolderName.Location = new Point(95, 25);
            lblFolderName.Name = "lblFolderName";
            lblFolderName.Size = new Size(61, 17);
            lblFolderName.TabIndex = 3;
            lblFolderName.Text = "Unknown";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 2;
            label1.Text = "Folder name:";
            // 
            // btnPath
            // 
            btnPath.BackColor = Color.Transparent;
            btnPath.BackgroundImage = Properties.Resources.folder;
            btnPath.BackgroundImageLayout = ImageLayout.Stretch;
            btnPath.FlatAppearance.BorderSize = 0;
            btnPath.FlatStyle = FlatStyle.Flat;
            btnPath.Location = new Point(440, 55);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(25, 25);
            btnPath.TabIndex = 1;
            btnPath.UseVisualStyleBackColor = false;
            btnPath.Click += btnPath_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(10, 55);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(420, 23);
            txtPath.TabIndex = 0;
            // 
            // gboxDloadProgress
            // 
            gboxDloadProgress.Controls.Add(btnDownload);
            gboxDloadProgress.Controls.Add(lblFilename);
            gboxDloadProgress.Controls.Add(progressBar);
            gboxDloadProgress.ForeColor = Color.Black;
            gboxDloadProgress.Location = new Point(10, 110);
            gboxDloadProgress.Name = "gboxDloadProgress";
            gboxDloadProgress.Size = new Size(665, 110);
            gboxDloadProgress.TabIndex = 6;
            gboxDloadProgress.TabStop = false;
            gboxDloadProgress.Text = "Download progress";
            // 
            // btnDownload
            // 
            btnDownload.ForeColor = Color.Black;
            btnDownload.Location = new Point(580, 80);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilename.Location = new Point(15, 25);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(0, 17);
            lblFilename.TabIndex = 5;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(10, 50);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(645, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(684, 230);
            Controls.Add(gboxDloadProgress);
            Controls.Add(gboxDloadPath);
            Controls.Add(gboxConnection);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 269);
            MinimumSize = new Size(700, 269);
            Name = "Form1";
            Text = "MegaNzLoader";
            Load += Form1_Load;
            gboxConnection.ResumeLayout(false);
            gboxConnection.PerformLayout();
            gboxDloadPath.ResumeLayout(false);
            gboxDloadPath.PerformLayout();
            gboxDloadProgress.ResumeLayout(false);
            gboxDloadProgress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblState;
        public Label lblStatus;
        public Button btnConnect;
        public Button btnDisconnect;
        private Button btnPath;
        public TextBox txtPath;
        private Label label1;
        public Label lblFolderName;
        public ProgressBar progressBar;
        private Button btnDownload;
        public Label lblFilename;
        public GroupBox gboxConnection;
        public GroupBox gboxDloadPath;
        public GroupBox gboxDloadProgress;
    }
}