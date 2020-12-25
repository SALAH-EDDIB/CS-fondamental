using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Compression;
using System.IO;

namespace cleanerUpdater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            update();

        }


        public void update()
        {


            Task.Run(  () => {

                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(40);

                    this.Dispatcher.Invoke(async () => {

                        if (i == 100)
                        {

                            WebClient client = new WebClient();

                            string[] files = Directory.GetFiles(@"C:\Users\Youcode\source\repos\helloWord\PC__Cleaner\bin\backup");

                            foreach (string file in files)
                            {
                                File.Delete(file);
                            }

                            client.DownloadFile("https://download1647.mediafire.com/vz5jb6tt16lg/zwfo8bq1pe4xaoj/Release.zip", @"C:\Users\youcode\source\repos\helloWord\PC__Cleaner\bin\backup\Release.zip");

                            string zipPath = @"C:\Users\Youcode\source\repos\helloWord\PC__Cleaner\bin\backup\Release.zip";

                            string zipDurection = @"C:\Users\Youcode\source\repos\helloWord\PC__Cleaner\bin\Release";


                            string extractPath = @"C:\Users\Youcode\source\repos\helloWord\PC__Cleaner\bin\backup";

                           
                                foreach (var file in new DirectoryInfo(zipDurection).GetFiles())
                                {
                                    file.MoveTo(extractPath +@"\"+ file.Name);
                                }


                            ZipFile.ExtractToDirectory(zipPath, zipDurection);

                            File.Delete(zipPath);


                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = @"C:\Users\Youcode\source\repos\helloWord\PC__Cleaner\bin\Release\PC__Cleaner.exe";

                            Process.Start(startInfo);
                            this.Close();






                        }

                    });


                }
            });

          

        }



    }
}
