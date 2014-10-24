using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SharpRenamer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolder.Text = fdb.SelectedPath;
            }
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            if(Directory.Exists(txtFolder.Text))
            {
                lbxItems.Items.Clear();
                CustomSort(Directory.GetFiles(txtFolder.Text)).All(x => { lbxItems.Items.Add(Path.GetFileName(x)); return true; });
                txtFilter.ReadOnly = false;
            }
            else
            {
                txtExample.Clear();
                txtFilter.ReadOnly = true;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            foreach (string s in lbxItems.Items)
            {
                try
                {
                    File.Move(Path.Combine(txtFolder.Text, s), Path.Combine(txtFolder.Text, GetNewName(s)));
                }
                catch(Exception exc)
                {
                    throw exc;
                }
                backgroundWorker.ReportProgress(i);
                i++;
            }
        }

        public string LeadingZeros(int number, int max = 99)
        {
            if(number.ToString().Length >= max.ToString().Length)
            {
                return number.ToString();
            }
            else
            {
                return new string('0', max.ToString().Length - number.ToString().Length) + number.ToString();
            }
        }

        public string GetNewName(string fname)
        {
            int fileNumber = lbxItems.Items.IndexOf(fname) + 1;
            string fullPath = Path.Combine(txtFolder.Text, fname);
            string rootFolder = txtFolder.Text;
            string corresponding = "";
            try { corresponding = lbxList.Items[fileNumber - 1].ToString(); }
            catch { corresponding = ""; }

            /*foreach(Match m in Regex.Matches(fname, "{([A-Za-z0-9]+)}"))
            {
                string varn = m.Value;
                if(varn == "{fn}")
                {

                }
            }*/
            string nname = txtFilter.Text;
            nname = nname.Replace("{fn}", fileNumber.ToString());
            nname = nname.Replace("{fn0}", LeadingZeros(fileNumber, lbxItems.Items.Count));
            nname = nname.Replace("{rootn}", Path.GetFileName(Path.GetDirectoryName(fullPath)));
            nname = nname.Replace("{ROOTN}", Path.GetFileName(Path.GetDirectoryName(fullPath)).ToUpper());
            nname = nname.Replace("{lid}", corresponding);
            nname = nname.Replace("{LID}", corresponding.ToUpper());

            return nname;
        }

        public bool Valid()
        {
            return Directory.Exists(txtFolder.Text);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(Valid())
            {
                txtExample.Text = GetNewName(lbxItems.Items[0].ToString());
            }
        }


        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            if(ofpList.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtListPath.Text = ofpList.FileName;
                lbxList.Items.Clear();
                File.ReadAllLines(txtListPath.Text, Encoding.UTF8).All(x => { lbxList.Items.Add(x); return true; });
                if(lbxItems.Items.Count < lbxList.Items.Count)
                {
                    lblError.Text = "There is not enough elements in the list, blank strings will be used.";
                }
                else
                {
                    lblError.Text = "";
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnRename.Text = e.ProgressPercentage + "/" + lbxItems.Items.Count;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRename.Text = "Rename";
            if(MessageBox.Show("Renaming finished!\nDo you want to open target folder?", "Finished", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start(txtFolder.Text);
            }
        }

        public IEnumerable<string> CustomSort(IEnumerable<string> list)
        {
            int maxLen = list.Select(s => s.Length).Max();

            return list.Select(s => new
            {
                OrgStr = s,
                SortStr = Regex.Replace(s, @"(\d+)|(\D+)", m => m.Value.PadLeft(maxLen, char.IsDigit(m.Value[0]) ? ' ' : '\xffff'))
            })
            .OrderBy(x => x.SortStr)
            .Select(x => x.OrgStr);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }
    }
}
