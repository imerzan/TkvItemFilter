namespace TkvItemFilter
{
    partial class ItemForm
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
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Quest = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Important = new System.Windows.Forms.CheckBox();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ShortName = new System.Windows.Forms.TextBox();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.checkBox_DontUpdate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Key
            // 
            this.textBox_Key.Enabled = false;
            this.textBox_Key.Location = new System.Drawing.Point(104, 16);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(271, 20);
            this.textBox_Key.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Short Name";
            // 
            // checkBox_Quest
            // 
            this.checkBox_Quest.AutoSize = true;
            this.checkBox_Quest.Location = new System.Drawing.Point(15, 101);
            this.checkBox_Quest.Name = "checkBox_Quest";
            this.checkBox_Quest.Size = new System.Drawing.Size(83, 17);
            this.checkBox_Quest.TabIndex = 4;
            this.checkBox_Quest.Text = "Quest Item?";
            this.checkBox_Quest.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Group";
            // 
            // checkBox_Important
            // 
            this.checkBox_Important.AutoSize = true;
            this.checkBox_Important.Location = new System.Drawing.Point(15, 157);
            this.checkBox_Important.Name = "checkBox_Important";
            this.checkBox_Important.Size = new System.Drawing.Size(76, 17);
            this.checkBox_Important.TabIndex = 6;
            this.checkBox_Important.Text = "Important?";
            this.checkBox_Important.UseVisualStyleBackColor = true;
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.Location = new System.Drawing.Point(15, 191);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(82, 17);
            this.checkBox_Show.TabIndex = 7;
            this.checkBox_Show.Text = "Show Item?";
            this.checkBox_Show.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(104, 44);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(271, 20);
            this.textBox_Name.TabIndex = 8;
            // 
            // textBox_ShortName
            // 
            this.textBox_ShortName.Location = new System.Drawing.Point(104, 73);
            this.textBox_ShortName.Name = "textBox_ShortName";
            this.textBox_ShortName.Size = new System.Drawing.Size(193, 20);
            this.textBox_ShortName.TabIndex = 9;
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(104, 128);
            this.textBox_Group.MaxLength = 1;
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(52, 20);
            this.textBox_Group.TabIndex = 10;
            this.textBox_Group.TextChanged += new System.EventHandler(this.textBox_Group_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(179, 238);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(85, 57);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // checkBox_DontUpdate
            // 
            this.checkBox_DontUpdate.AutoSize = true;
            this.checkBox_DontUpdate.Location = new System.Drawing.Point(15, 223);
            this.checkBox_DontUpdate.Name = "checkBox_DontUpdate";
            this.checkBox_DontUpdate.Size = new System.Drawing.Size(93, 17);
            this.checkBox_DontUpdate.TabIndex = 12;
            this.checkBox_DontUpdate.Text = "Dont Update?";
            this.checkBox_DontUpdate.UseVisualStyleBackColor = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 327);
            this.Controls.Add(this.checkBox_DontUpdate);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.textBox_ShortName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.checkBox_Show);
            this.Controls.Add(this.checkBox_Important);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_Quest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.Text = "Item Edit";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Quest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Important;
        private System.Windows.Forms.CheckBox checkBox_Show;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ShortName;
        private System.Windows.Forms.TextBox textBox_Group;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckBox checkBox_DontUpdate;
    }
}