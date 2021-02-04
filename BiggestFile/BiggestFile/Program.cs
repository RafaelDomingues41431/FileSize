using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiggestFile
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }

    public class BiggestFiles
    {
        FileInfo[] biggestFiles;
        public bool error;
        public string errorMsg;

        public BiggestFiles(int numberOfFiles)
        {
            biggestFiles = new FileInfo[numberOfFiles];
            error = false;
        }

        public void CheckFile(FileInfo file)
        {
            FileInfo currFile = file;
            for (int i = 0; i < biggestFiles.Length; ++i)
            {
                while (true)
                {
                    if (Interlocked.CompareExchange(ref biggestFiles[i], currFile, null) == null)
                        return;
                    FileInfo aux = biggestFiles[i];
                    if (aux.Length >= currFile.Length)
                        break;
                    else {
                        FileInfo aux2 = Interlocked.CompareExchange(ref biggestFiles[i], currFile, aux);
                        if (aux2 == aux) {
                            currFile = aux;
                            break;        
                        }
                    }
                }     
            }
        }

        public FileInfo[] GetFiles()
        {
            return biggestFiles;
        }
    }


    class BiggestFileSearch
    {
        public BiggestFiles biggestFiles;
        public Reporter reporter;

        public BiggestFileSearch(int numberOfFiles,Reporter reporter)
        {
            biggestFiles = new BiggestFiles(numberOfFiles);
            this.reporter = reporter;
        }

        public BiggestFileSearch(int numberOfFiles)
        {
            biggestFiles = new BiggestFiles(numberOfFiles);
        }

        public Task Search(string path, int filesToCheck, CancellationToken cancel)
        {
            return Task.Run(() =>
            {
                SearchRecursive(path, cancel);
            });   
        }

        private void SearchRecursive(string path,CancellationToken cancel)
        {
            string[] files=null;
            try
            {
                files = Directory.GetFiles(path);
            }
            catch (Exception e)
            {
                biggestFiles.errorMsg = e.Message;
                biggestFiles.error = true;
                return;
            }

            try
            {
                Parallel.ForEach<string>(files, new ParallelOptions { CancellationToken = cancel }, (string file) =>
                   {
                       FileInfo currentFile = new FileInfo(file);
                       biggestFiles.CheckFile(currentFile);
                       if (reporter != null)
                           reporter.reportFile(file);
                   });
            }
            catch (OperationCanceledException)
            {
                return;
            }

            string[] directories = Directory.GetDirectories(path);
            if (directories.Length > 0)
                try
                {
                    Parallel.ForEach<string>(directories, new ParallelOptions { CancellationToken = cancel }, (string directory) =>
                     {
                         SearchRecursive(directory, cancel);
                         if (reporter != null)
                             reporter.reportDir(directory);
                     });
                }
                catch (OperationCanceledException)
                {
                    return;
                }
        }
    }

    public class Reporter
    {
        public delegate void ReportFile(string file);
        public delegate void ReportDir(string dir);

        public ReportFile reportFile;
        public ReportDir reportDir;
    }

}
