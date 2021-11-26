namespace TkvItemFilter
{
    partial class MainForm
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
            this.button_Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader_Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ShortName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_QuestItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Important = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ShowItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(704, 406);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(92, 23);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Json Files|*.json";
            this.openFileDialog1.Title = "Select json file";
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Key,
            this.columnHeader_Name,
            this.columnHeader_ShortName,
            this.columnHeader_QuestItem,
            this.columnHeader_Group,
            this.columnHeader_Important,
            this.columnHeader_ShowItem});
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.GridLines = true;
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(12, 12);
            this.listView_Main.MultiSelect = false;
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(675, 426);
            this.listView_Main.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_Main.TabIndex = 1;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.SelectedIndexChanged += new System.EventHandler(this.listView_Main_SelectedIndexChanged);
            // 
            // columnHeader_Key
            // 
            this.columnHeader_Key.Text = "Key";
            this.columnHeader_Key.Width = 50;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 200;
            // 
            // columnHeader_ShortName
            // 
            this.columnHeader_ShortName.Text = "ShortName";
            this.columnHeader_ShortName.Width = 170;
            // 
            // columnHeader_QuestItem
            // 
            this.columnHeader_QuestItem.Text = "QuestItem?";
            this.columnHeader_QuestItem.Width = 68;
            // 
            // columnHeader_Group
            // 
            this.columnHeader_Group.Text = "Group";
            this.columnHeader_Group.Width = 45;
            // 
            // columnHeader_Important
            // 
            this.columnHeader_Important.Text = "Important?";
            this.columnHeader_Important.Width = 68;
            // 
            // columnHeader_ShowItem
            // 
            this.columnHeader_ShowItem.Text = "Show?";
            this.columnHeader_ShowItem.Width = 50;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(704, 193);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(92, 23);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Enabled = false;
            this.button_Edit.Location = new System.Drawing.Point(704, 121);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(92, 23);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.Location = new System.Drawing.Point(704, 222);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(92, 23);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(704, 48);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(184, 20);
            this.textBox_Search.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.button_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TkvItemFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_ShortName;
        private System.Windows.Forms.ColumnHeader columnHeader_QuestItem;
        private System.Windows.Forms.ColumnHeader columnHeader_Group;
        private System.Windows.Forms.ColumnHeader columnHeader_Important;
        private System.Windows.Forms.ColumnHeader columnHeader_ShowItem;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.ColumnHeader columnHeader_Key;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
    }
}

