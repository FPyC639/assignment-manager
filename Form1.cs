using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                var txt = new StringBuilder();
                var subject = EntryField1.Text;
                var assignment = EntryField2.Text;
                var details = EntryField3.Text;
                var newline = string.Format("{0},{1},{2}\n", subject, assignment,details);
                var fpath = Environment.CurrentDirectory + "\\record.csv";
                if (!File.Exists(fpath))
                    File.WriteAllText(fpath, newline);
                else
                    File.AppendAllText(fpath, newline);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var subjects = new Dictionary<string, ListView>();
            var csvFilePath = Environment.CurrentDirectory + "\\record.csv";

            using (var reader = new StreamReader(csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var subject = values[0];
                    var assignment = values[1];
                    var details = values[2];

                    // Check if the subject tab already exists
                    if (!subjects.ContainsKey(subject))
                    {
                        // Create a new TabPage and ListView
                        var tabPage = new TabPage(subject);
                        var listView = new ListView
                        {
                            Dock = DockStyle.Fill,
                            View = View.Details // Use Details view mode
                        };

                        // Add columns to the ListView
                        listView.Columns.Add("Assignment", -2, HorizontalAlignment.Left);
                        listView.Columns.Add("Details", -2, HorizontalAlignment.Left);

                        // Add the ListView to the TabPage
                        tabPage.Controls.Add(listView);

                        // Add the TabPage to the TabControl
                        tabControl1.TabPages.Add(tabPage);

                        // Add the ListView to the dictionary
                        subjects[subject] = listView;
                    }

                    // Create a new ListViewItem for the assignment and details
                    var item = new ListViewItem(assignment);
                    item.SubItems.Add(details);

                    // Add the item to the corresponding ListView
                    subjects[subject].Items.Add(item);
                }
            }
        }
    }
}
