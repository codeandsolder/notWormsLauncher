namespace notWormsLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.clientListbox = new System.Windows.Forms.ListBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nicknameBox = new System.Windows.Forms.TextBox();
            this.nicknameButton = new System.Windows.Forms.Button();
            this.availableCheckbox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(247, 30);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 22);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // clientListbox
            // 
            this.clientListbox.FormattingEnabled = true;
            this.clientListbox.Location = new System.Drawing.Point(11, 119);
            this.clientListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientListbox.Name = "clientListbox";
            this.clientListbox.Size = new System.Drawing.Size(311, 147);
            this.clientListbox.TabIndex = 1;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(93, 28);
            this.serverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(134, 13);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server state: disconnected";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(96, 6);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(226, 20);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "localhost:8000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Available players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nickname:";
            // 
            // nicknameBox
            // 
            this.nicknameBox.Location = new System.Drawing.Point(96, 61);
            this.nicknameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.Size = new System.Drawing.Size(163, 20);
            this.nicknameBox.TabIndex = 7;
            // 
            // nicknameButton
            // 
            this.nicknameButton.Location = new System.Drawing.Point(263, 60);
            this.nicknameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nicknameButton.Name = "nicknameButton";
            this.nicknameButton.Size = new System.Drawing.Size(59, 22);
            this.nicknameButton.TabIndex = 8;
            this.nicknameButton.Text = "Set";
            this.nicknameButton.UseVisualStyleBackColor = true;
            this.nicknameButton.Click += new System.EventHandler(this.nicknameButton_Click);
            // 
            // availableCheckbox
            // 
            this.availableCheckbox.AutoSize = true;
            this.availableCheckbox.Location = new System.Drawing.Point(96, 85);
            this.availableCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.availableCheckbox.Name = "availableCheckbox";
            this.availableCheckbox.Size = new System.Drawing.Size(86, 17);
            this.availableCheckbox.TabIndex = 9;
            this.availableCheckbox.Text = "ready to play";
            this.availableCheckbox.UseVisualStyleBackColor = true;
            this.availableCheckbox.CheckedChanged += new System.EventHandler(this.availableCheckbox_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 270);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Invite";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 298);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.availableCheckbox);
            this.Controls.Add(this.nicknameButton);
            this.Controls.Add(this.nicknameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.clientListbox);
            this.Controls.Add(this.connectButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "notWormsLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox clientListbox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nicknameBox;
        private System.Windows.Forms.Button nicknameButton;
        private System.Windows.Forms.CheckBox availableCheckbox;
        private System.Windows.Forms.Button button3;
    }
}

