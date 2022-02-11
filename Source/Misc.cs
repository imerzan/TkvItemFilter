using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TkvItemFilter
{
    public class GameItem
    {
        [JsonIgnore]
        public ListViewItem View
        {
            get
            {
                string[] arr = new string[8];
                arr[0] = Key;
                arr[1] = Name;
                arr[2] = ShortName;
                arr[3] = QuestItem.ToString();
                arr[4] = Group.ToString();
                arr[5] = Important.ToString();
                arr[6] = ShowItem.ToString();
                arr[7] = DontUpdate.ToString();
                var item = new ListViewItem(arr);
                item.Tag = this;
                return item;
            }
        }

        public GameItem()
        {
            Key = String.Empty;
            Name = String.Empty;
            ShortName = String.Empty;
            QuestItem = false;
            Group = 5;
            Important = false;
            ShowItem = true;
            DontUpdate = false;
        }
        [JsonIgnore]
        public string Key { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }

        [JsonProperty("QuestItem")]
        public bool QuestItem { get; set; }

        [JsonProperty("group")]
        public long Group { get; set; }

        [JsonProperty("important")]
        public bool Important { get; set; }

        [JsonProperty("showItem")]
        public bool ShowItem { get; set; }
        [JsonProperty("dontUpdate")]
        public bool DontUpdate { get; set; }

    }

    public class GameItemDB
    {
        private readonly FileInfo _file;
        public readonly Dictionary<string, GameItem> Items;
        private static readonly JsonSerializer _json = new JsonSerializer()
        {
            Formatting = Formatting.Indented
        };
        public ListViewItem[] View
        {
            get
            {
                ListViewItem[] view = new ListViewItem[this.Items.Count];
                int index = 0;
                foreach (KeyValuePair<string, GameItem> item in this.Items) // Populate array
                {
                    view[index] = item.Value.View;
                    index++;
                }
                return view;
            }
        }

        public ListViewItem[] Search(string query)
        {
            var results = this.Items.Where(x =>
            x.Value.Name.Contains(query, StringComparison.OrdinalIgnoreCase));
            ListViewItem[] view = new ListViewItem[results.Count()];
            int index = 0;
            foreach (KeyValuePair<string, GameItem> item in results) // Populate array
            {
                view[index] = item.Value.View;
                index++;
            }
            return view;
        }

        public GameItemDB(string jsonFile)
        {
            try
            {
                _file = new FileInfo(jsonFile);
                if (!_file.Exists)
                {
                    throw new FileNotFoundException("JSON File does not exist!");
                }
                using (var stream = File.OpenText(_file.FullName))
                {
                    this.Items = (Dictionary<string, GameItem>)_json.Deserialize(stream, typeof(Dictionary<string, GameItem>));
                }
                foreach (KeyValuePair<string, GameItem> item in this.Items) // Populate list
                {
                    item.Value.Key = item.Key; // Let each item know it's key
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR loading JSON File: {ex}", "TkvItemFilter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void SaveJson()
        {
            try
            {
                var prompt = MessageBox.Show("Would you like to save your changes?", "TkvItemFilter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (prompt == DialogResult.Yes)
                {
                    using (var stream = File.CreateText(_file.FullName))
                    {
                        stream.NewLine = "\n"; // Unix LF instead of Windows CRLF
                        _json.Serialize(stream, this.Items);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR saving JSON File: {ex}", "TkvItemFilter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class ListViewItemComparer : IComparer
    {
        private int _col;
        private SortOrder _order;
        public ListViewItemComparer()
        {
            _col = 0;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            _col = column;
            _order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[_col].Text,
                            ((ListViewItem)y).SubItems[_col].Text);
            // Determine whether the sort order is descending.
            if (_order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;
            return returnVal;
        }
    }

    internal static class Extensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }

        public static void Reset(this System.Timers.Timer timer)
        {
            timer.Stop();
            timer.Start();
        }
    }
}
