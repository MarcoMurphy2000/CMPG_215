namespace CMPG215_Encryption_Assignment
{
    partial class EncryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionForm));
            this.txtPasswordEnc = new System.Windows.Forms.TextBox();
            this.EncryptionResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptionOpenFileButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.txtPasswordDec = new System.Windows.Forms.TextBox();
            this.DecryptionResultLabel = new System.Windows.Forms.Label();
            this.DecryptionOpenFileButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SideBarHeader = new System.Windows.Forms.Panel();
            this.headImage = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.EncryptPane = new System.Windows.Forms.Panel();
            this.EncryptionSelectedFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayActionLabel = new System.Windows.Forms.Label();
            this.DecryptPane = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptionSelectedFileLabel = new System.Windows.Forms.Label();
            this.TopBarHeader = new System.Windows.Forms.Panel();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.DecryptTabButton = new System.Windows.Forms.Button();
            this.EncryptTabButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SideBarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).BeginInit();
            this.EncryptPane.SuspendLayout();
            this.DecryptPane.SuspendLayout();
            this.TopBarHeader.SuspendLayout();
            this.SideBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPasswordEnc
            // 
            this.txtPasswordEnc.Location = new System.Drawing.Point(133, 57);
            this.txtPasswordEnc.Margin = new System.Windows.Forms.Padding(0);
            this.txtPasswordEnc.Multiline = true;
            this.txtPasswordEnc.Name = "txtPasswordEnc";
            this.txtPasswordEnc.Size = new System.Drawing.Size(311, 33);
            this.txtPasswordEnc.TabIndex = 6;
            // 
            // EncryptionResultLabel
            // 
            this.EncryptionResultLabel.AutoSize = true;
            this.EncryptionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.EncryptionResultLabel.Location = new System.Drawing.Point(130, 124);
            this.EncryptionResultLabel.Name = "EncryptionResultLabel";
            this.EncryptionResultLabel.Size = new System.Drawing.Size(154, 13);
            this.EncryptionResultLabel.TabIndex = 5;
            this.EncryptionResultLabel.Text = "{{EncryptionResultLabel}}";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Select:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EncryptionOpenFileButton
            // 
            this.EncryptionOpenFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EncryptionOpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.EncryptionOpenFileButton.FlatAppearance.BorderSize = 0;
            this.EncryptionOpenFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.EncryptionOpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptionOpenFileButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionOpenFileButton.ForeColor = System.Drawing.Color.White;
            this.EncryptionOpenFileButton.Location = new System.Drawing.Point(352, 16);
            this.EncryptionOpenFileButton.Name = "EncryptionOpenFileButton";
            this.EncryptionOpenFileButton.Size = new System.Drawing.Size(90, 32);
            this.EncryptionOpenFileButton.TabIndex = 1;
            this.EncryptionOpenFileButton.Text = "Browse";
            this.EncryptionOpenFileButton.UseVisualStyleBackColor = false;
            this.EncryptionOpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.EncryptButton.FlatAppearance.BorderSize = 0;
            this.EncryptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.ForeColor = System.Drawing.Color.White;
            this.EncryptButton.Location = new System.Drawing.Point(352, 102);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(90, 32);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // txtPasswordDec
            // 
            this.txtPasswordDec.Location = new System.Drawing.Point(133, 57);
            this.txtPasswordDec.Margin = new System.Windows.Forms.Padding(0);
            this.txtPasswordDec.Multiline = true;
            this.txtPasswordDec.Name = "txtPasswordDec";
            this.txtPasswordDec.Size = new System.Drawing.Size(311, 33);
            this.txtPasswordDec.TabIndex = 12;
            // 
            // DecryptionResultLabel
            // 
            this.DecryptionResultLabel.AutoSize = true;
            this.DecryptionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptionResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.DecryptionResultLabel.Location = new System.Drawing.Point(130, 124);
            this.DecryptionResultLabel.Name = "DecryptionResultLabel";
            this.DecryptionResultLabel.Size = new System.Drawing.Size(155, 13);
            this.DecryptionResultLabel.TabIndex = 11;
            this.DecryptionResultLabel.Text = "{{DecryptionResultLabel}}";
            // 
            // DecryptionOpenFileButton
            // 
            this.DecryptionOpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.DecryptionOpenFileButton.FlatAppearance.BorderSize = 0;
            this.DecryptionOpenFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.DecryptionOpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptionOpenFileButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptionOpenFileButton.ForeColor = System.Drawing.Color.White;
            this.DecryptionOpenFileButton.Location = new System.Drawing.Point(352, 16);
            this.DecryptionOpenFileButton.Name = "DecryptionOpenFileButton";
            this.DecryptionOpenFileButton.Size = new System.Drawing.Size(90, 32);
            this.DecryptionOpenFileButton.TabIndex = 7;
            this.DecryptionOpenFileButton.Text = "Browse";
            this.DecryptionOpenFileButton.UseVisualStyleBackColor = false;
            this.DecryptionOpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.DecryptButton.FlatAppearance.BorderSize = 0;
            this.DecryptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.ForeColor = System.Drawing.Color.White;
            this.DecryptButton.Location = new System.Drawing.Point(352, 102);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(90, 32);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // SideBarHeader
            // 
            this.SideBarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.SideBarHeader.Controls.Add(this.headImage);
            this.SideBarHeader.Controls.Add(this.lblHeader);
            this.SideBarHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarHeader.Location = new System.Drawing.Point(0, 0);
            this.SideBarHeader.Margin = new System.Windows.Forms.Padding(0);
            this.SideBarHeader.Name = "SideBarHeader";
            this.SideBarHeader.Size = new System.Drawing.Size(169, 50);
            this.SideBarHeader.TabIndex = 0;
            // 
            // headImage
            // 
            this.headImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headImage.BackgroundImage = global::CMPG215_Encryption_Assignment.Properties.Resources.data_encryption_64;
            this.headImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headImage.InitialImage = null;
            this.headImage.Location = new System.Drawing.Point(9, 9);
            this.headImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(30, 32);
            this.headImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headImage.TabIndex = 1;
            this.headImage.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(44, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(125, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Feistal Cipher";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncryptPane
            // 
            this.EncryptPane.AutoSize = true;
            this.EncryptPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.EncryptPane.Controls.Add(this.EncryptionSelectedFileLabel);
            this.EncryptPane.Controls.Add(this.label2);
            this.EncryptPane.Controls.Add(this.EncryptionResultLabel);
            this.EncryptPane.Controls.Add(this.txtPasswordEnc);
            this.EncryptPane.Controls.Add(this.EncryptButton);
            this.EncryptPane.Controls.Add(this.label1);
            this.EncryptPane.Controls.Add(this.EncryptionOpenFileButton);
            this.EncryptPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptPane.Location = new System.Drawing.Point(0, 0);
            this.EncryptPane.Margin = new System.Windows.Forms.Padding(0);
            this.EncryptPane.Name = "EncryptPane";
            this.EncryptPane.Size = new System.Drawing.Size(474, 318);
            this.EncryptPane.TabIndex = 2;
            // 
            // EncryptionSelectedFileLabel
            // 
            this.EncryptionSelectedFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncryptionSelectedFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptionSelectedFileLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionSelectedFileLabel.Location = new System.Drawing.Point(133, 16);
            this.EncryptionSelectedFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EncryptionSelectedFileLabel.Name = "EncryptionSelectedFileLabel";
            this.EncryptionSelectedFileLabel.Size = new System.Drawing.Size(215, 33);
            this.EncryptionSelectedFileLabel.TabIndex = 10;
            this.EncryptionSelectedFileLabel.Text = "label3";
            this.EncryptionSelectedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Security Key:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisplayActionLabel
            // 
            this.DisplayActionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayActionLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayActionLabel.ForeColor = System.Drawing.Color.White;
            this.DisplayActionLabel.Location = new System.Drawing.Point(169, 0);
            this.DisplayActionLabel.Name = "DisplayActionLabel";
            this.DisplayActionLabel.Size = new System.Drawing.Size(474, 50);
            this.DisplayActionLabel.TabIndex = 1;
            this.DisplayActionLabel.Text = "Encrypt";
            this.DisplayActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecryptPane
            // 
            this.DecryptPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.DecryptPane.Controls.Add(this.label4);
            this.DecryptPane.Controls.Add(this.label3);
            this.DecryptPane.Controls.Add(this.DecryptionSelectedFileLabel);
            this.DecryptPane.Controls.Add(this.DecryptionResultLabel);
            this.DecryptPane.Controls.Add(this.txtPasswordDec);
            this.DecryptPane.Controls.Add(this.DecryptButton);
            this.DecryptPane.Controls.Add(this.DecryptionOpenFileButton);
            this.DecryptPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptPane.Location = new System.Drawing.Point(0, 0);
            this.DecryptPane.Name = "DecryptPane";
            this.DecryptPane.Size = new System.Drawing.Size(474, 318);
            this.DecryptPane.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Security Key:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "File Select:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DecryptionSelectedFileLabel
            // 
            this.DecryptionSelectedFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecryptionSelectedFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptionSelectedFileLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptionSelectedFileLabel.Location = new System.Drawing.Point(133, 16);
            this.DecryptionSelectedFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DecryptionSelectedFileLabel.Name = "DecryptionSelectedFileLabel";
            this.DecryptionSelectedFileLabel.Size = new System.Drawing.Size(215, 33);
            this.DecryptionSelectedFileLabel.TabIndex = 11;
            this.DecryptionSelectedFileLabel.Text = "label3";
            this.DecryptionSelectedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopBarHeader
            // 
            this.TopBarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.TopBarHeader.Controls.Add(this.DisplayActionLabel);
            this.TopBarHeader.Controls.Add(this.SideBarHeader);
            this.TopBarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarHeader.Location = new System.Drawing.Point(0, 0);
            this.TopBarHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopBarHeader.Name = "TopBarHeader";
            this.TopBarHeader.Size = new System.Drawing.Size(643, 50);
            this.TopBarHeader.TabIndex = 2;
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.SideBarPanel.Controls.Add(this.DecryptTabButton);
            this.SideBarPanel.Controls.Add(this.EncryptTabButton);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 50);
            this.SideBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(169, 318);
            this.SideBarPanel.TabIndex = 3;
            // 
            // DecryptTabButton
            // 
            this.DecryptTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.DecryptTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecryptTabButton.FlatAppearance.BorderSize = 0;
            this.DecryptTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.DecryptTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.DecryptTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptTabButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptTabButton.ForeColor = System.Drawing.Color.White;
            this.DecryptTabButton.Image = global::CMPG215_Encryption_Assignment.Properties.Resources.key_32;
            this.DecryptTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecryptTabButton.Location = new System.Drawing.Point(0, 65);
            this.DecryptTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.DecryptTabButton.Name = "DecryptTabButton";
            this.DecryptTabButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DecryptTabButton.Size = new System.Drawing.Size(135, 41);
            this.DecryptTabButton.TabIndex = 1;
            this.DecryptTabButton.Text = "  Decrypt";
            this.DecryptTabButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DecryptTabButton.UseVisualStyleBackColor = false;
            this.DecryptTabButton.Click += new System.EventHandler(this.DecryptTabButton_Click);
            // 
            // EncryptTabButton
            // 
            this.EncryptTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.EncryptTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EncryptTabButton.FlatAppearance.BorderSize = 0;
            this.EncryptTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.EncryptTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.EncryptTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptTabButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptTabButton.ForeColor = System.Drawing.Color.White;
            this.EncryptTabButton.Image = global::CMPG215_Encryption_Assignment.Properties.Resources.lock_32;
            this.EncryptTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptTabButton.Location = new System.Drawing.Point(0, 12);
            this.EncryptTabButton.Margin = new System.Windows.Forms.Padding(0);
            this.EncryptTabButton.Name = "EncryptTabButton";
            this.EncryptTabButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EncryptTabButton.Size = new System.Drawing.Size(135, 41);
            this.EncryptTabButton.TabIndex = 0;
            this.EncryptTabButton.Text = "  Encrypt";
            this.EncryptTabButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EncryptTabButton.UseVisualStyleBackColor = false;
            this.EncryptTabButton.Click += new System.EventHandler(this.EncryptTabButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EncryptPane);
            this.panel1.Controls.Add(this.DecryptPane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(169, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 318);
            this.panel1.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Decrypted File";
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(643, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.TopBarHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encryption and Decryption";
            this.Load += new System.EventHandler(this.EncryptionForm_Load);
            this.SideBarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).EndInit();
            this.EncryptPane.ResumeLayout(false);
            this.EncryptPane.PerformLayout();
            this.DecryptPane.ResumeLayout(false);
            this.DecryptPane.PerformLayout();
            this.TopBarHeader.ResumeLayout(false);
            this.SideBarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label EncryptionResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptionOpenFileButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label DecryptionResultLabel;
        private System.Windows.Forms.Button DecryptionOpenFileButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox txtPasswordEnc;
        private System.Windows.Forms.TextBox txtPasswordDec;
        private System.Windows.Forms.Panel SideBarHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox headImage;
        private System.Windows.Forms.Panel EncryptPane;
        private System.Windows.Forms.Label DisplayActionLabel;
        private System.Windows.Forms.Panel DecryptPane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DecryptTabButton;
        private System.Windows.Forms.Button EncryptTabButton;
        private System.Windows.Forms.Panel TopBarHeader;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Label EncryptionSelectedFileLabel;
        private System.Windows.Forms.Label DecryptionSelectedFileLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

