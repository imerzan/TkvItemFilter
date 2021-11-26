using System;
using System.Windows.Forms;

namespace TkvItemFilter
{
    public partial class MainForm : Form
    {
        private GameItemDB _db;
        private GameItem _currentItem;
        private int _sortColumn = -1;
        private readonly System.Timers.Timer _searchDelayTimer;

        public MainForm()
        {
            InitializeComponent();
            _searchDelayTimer = new System.Timers.Timer(800); // 800 ms search delay
            _searchDelayTimer.AutoReset = false;
            _searchDelayTimer.Elapsed += this.TimerBeginSearch;
            this.Shown += MainForm_Shown;
            listView_Main.ColumnClick += this.OnColumnClick;
            listView_Main.MouseDoubleClick += this.listView_Main_MouseDoubleClick;
            listView_Main.MouseDown += this.listView_Main_MouseDown;
            textBox_Search.KeyDown += this.SearchKeyDown;
        }

        //
        // Events

        private void TimerBeginSearch(Object source, System.Timers.ElapsedEventArgs e)
        {
            Search();
        }

        private void SearchKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _searchDelayTimer.Stop();
                Search();
            }
            else
            {
                _searchDelayTimer.Reset();
            }
        }
        private void OnColumnClick(object o, ColumnClickEventArgs e)
        {
            if (e.Column != _sortColumn)
            {
                _sortColumn = e.Column;
                listView_Main.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listView_Main.Sorting == SortOrder.Ascending) listView_Main.Sorting = SortOrder.Descending;
                else listView_Main.Sorting = SortOrder.Ascending;
            }
            listView_Main.ListViewItemSorter = new ListViewItemComparer(_sortColumn, listView_Main.Sorting);
            listView_Main.Sort();
        }

        private void listView_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Main.SelectedItems.Count == 0)
            {
                _currentItem = null;
                ViewReset();
            }
            else
            {
                var selection = listView_Main.SelectedItems[0];
                _currentItem = (GameItem)selection.Tag;
                button_Edit.Enabled = true;
                button_Remove.Enabled = true;
            }
        }
        private void listView_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView_Main.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            if (item != null)
            {
                Edit();
            }
            else // Clear selection, clicked in empty space
            {
                listView_Main.SelectedItems.Clear();
            }
        }

        private void listView_Main_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView_Main.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            if (item is null) // Clear selection, clicked in empty space
            {
                listView_Main.SelectedItems.Clear();
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                var dialog = openFileDialog1.ShowDialog();
                if (dialog != DialogResult.OK) throw new Exception("Cancelled by user.");
                _db = new GameItemDB(openFileDialog1.FileName);
                listView_Main.Items.AddRange(_db.View);
            }
            catch // No json loaded, close down
            {
                Environment.Exit(-1);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        //
        // Buttons
        private void button_Save_Click(object sender, EventArgs e)
        {
            _db.SaveJson();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var dialog = new ItemForm();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                if (_db.Items.ContainsKey(dialog.Item.Key))
                {
                    MessageBox.Show("Key is already in use!", 
                        "TkvItemFilter", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }
                _db.Items.Add(dialog.Item.Key, dialog.Item);
                listView_Main.Items.Add(dialog.Item.View);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            var item = listView_Main.SelectedItems[0];
            var dialog = MessageBox.Show($"Are you sure you want to remove [{_currentItem.Name}]?", 
                "TkvItemFilter", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                _db.Items.Remove(_currentItem.Key);
                listView_Main.Items.Remove(item);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        //
        // Custom Methods
        private void Edit()
        {
            var item = listView_Main.SelectedItems[0];
            var dialog = new ItemForm(_currentItem);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                listView_Main.Items.Remove(item);
                listView_Main.Items.Add(dialog.Item.View);
            }
        }
        private void Search()
        {
            try
            {
                this.Enabled = false;
                textBox_Search.Text = textBox_Search.Text.Trim();
                listView_Main.Items.Clear();
                if (textBox_Search.Text == String.Empty)
                {
                    listView_Main.Items.AddRange(_db.View);
                }
                else
                {
                    listView_Main.Items.AddRange(_db.Search(textBox_Search.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search ERROR: {ex}", "TkvItemFilter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ViewReset();
                this.Enabled = true;
            }
        }

        private void ViewReset()
        {
            button_Edit.Enabled = false;
            button_Remove.Enabled = false;
        }

        //
        // Overrides
        protected override void OnFormClosing(FormClosingEventArgs e) // Raised on Program Exit
        {
            try
            {
                _db.SaveJson();
            }
            finally { base.OnFormClosing(e); }
        }
    }
}
