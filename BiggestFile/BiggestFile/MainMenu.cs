using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiggestFile
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        CancellationTokenSource cancel;
        Task searchTask;

        private void SetResult(FileInfo[] files)
        {
            resultsList.Invoke(new Action(()=>
            {
                resultsList.Items.Clear();
                for(int i = 0; i<files.Length;i++)
                {
                    if (files[i] != null)
                    {
                        ListViewItem item = new ListViewItem(files[i].Name);
                        item.SubItems.Add("" + files[i].Length);
                        resultsList.Items.Add(item);
                    }   
                }
                infoLabel.Visible = false;
                resultsList.Visible = true;
                cancelButton.Visible = false;
                progressList.Visible = false;
            }));

        }

        private void ShowInfo(string info)
        {
            infoLabel.Invoke(new Action(() => {
                infoLabel.Text = info;
                resultsList.Visible = false;
                infoLabel.Visible = true;
            }));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Searching.";
            infoLabel.Visible = true; ;
            int fileNumber;
            int.TryParse(this.fileNumber.Text, out fileNumber);
           /* Reporter reporter = new Reporter();
            reporter.reportDir = (string dir) =>
            {
                ListViewItem item = new ListViewItem("Dir");
                item.SubItems.Add(dir);
                progressList.Invoke(new Action(()=>
                {
                    progressList.Items.Add(item);
                    progressList.Visible = true;
                }));
            };

            reporter.reportFile = (string file) =>
            {
                ListViewItem item = new ListViewItem("File");
                item.SubItems.Add(file);
                progressList.Invoke(new Action(() =>
                {
                    progressList.Items.Add(item);
                    progressList.Visible = true;
                }));
            };*/
            
            this.cancelButton.Visible = true;
            cancel = new CancellationTokenSource();
            BiggestFileSearch fileSearch = new BiggestFileSearch(fileNumber);
            searchTask = fileSearch.Search(this.path.Text, fileNumber,cancel.Token);
            searchTask.ContinueWith((task) =>
            {
                if (cancel.IsCancellationRequested)
                    ShowInfo("Operation cancelled.");
                else
                {
                    if (fileSearch.biggestFiles.error == true)
                        ShowInfo(fileSearch.biggestFiles.errorMsg);
                    else
                    {
                        FileInfo[] files = fileSearch.biggestFiles.GetFiles();
                        SetResult(files);
                    }
                }
            });    
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancel.Cancel();
        }
    }
}
