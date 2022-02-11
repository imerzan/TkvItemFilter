using System;
using System.Windows.Forms;

namespace TkvItemFilter
{
    public partial class ItemForm : Form
    {
        private readonly GameItem _item;
        public GameItem Item
        {
            get
            {
                return _item;
            }
        }
        public ItemForm(GameItem item = null)
        {
            InitializeComponent();
            if (item is null)
            {
                _item = new GameItem();
                textBox_Key.Enabled = true;
            }
            else
            {
                _item = item;
            }
            textBox_Key.Text = _item.Key;
            textBox_Name.Text = _item.Name;
            textBox_ShortName.Text = _item.ShortName;
            textBox_Group.Text = _item.Group.ToString();
            checkBox_Important.Checked = _item.Important;
            checkBox_Quest.Checked = _item.QuestItem;
            checkBox_Show.Checked = _item.ShowItem;
            checkBox_DontUpdate.Checked = _item.DontUpdate;
        }

        private void textBox_Group_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox_Group.Text, out long number))
            {
                textBox_Group.Text = null;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_Key.Enabled) _item.Key = textBox_Key.Text;
            _item.Name = textBox_Name.Text;
            _item.ShortName = textBox_ShortName.Text;
            _item.Group = long.Parse(textBox_Group.Text);
            _item.ShowItem = checkBox_Show.Checked;
            _item.Important = checkBox_Important.Checked;
            _item.QuestItem = checkBox_Quest.Checked;
            _item.DontUpdate = checkBox_DontUpdate.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
