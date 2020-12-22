using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
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
using System.Threading;
using System.Windows.Media.Animation;

namespace PC__Cleaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window    {


      public  string[] paths = { @"C:\Windows\Temp", System.IO.Path.GetTempPath() , Environment.GetFolderPath(Environment.SpecialFolder.Cookies), Environment.GetFolderPath(Environment.SpecialFolder.History) };


        public MainWindow()
        {
            InitializeComponent();

            date.Text =  File.ReadAllText(@"C:\Users\youcode\source\repos\helloWord\PC__Cleaner\history.txt").Replace('/' , '.');


        }





        private void Nettoyer_Button_Click(object sender, RoutedEventArgs E)
        {

            

            analysetext.Text = "Nettoyer en cours !";

            foreach (string path in paths)
            {

                var di = new DirectoryInfo(path);

                ClearTempData(di);

            }

            Analyser_Button_Click(sender , E);

            analysetext.Text = "Nettoyer completed !";


        }


        private void Analyser_Button_Click( object sender, RoutedEventArgs E)
        {
             
            long size = 0;  
            long files = 0;

            analysetext.Text = " analyse en cours ... ";


            try
            {
                

                foreach( string path in paths)
                {

                    var di = new DirectoryInfo(path);

                    size += DirSize(di)[0];
                    files += DirSize(di)[1];


                }


                if(files > 5 )
                analyseResult.Text = files.ToString() + " files  " + String.Format("{0:0.0}", (size / 1024)) + "  KB";
                else
                analyseResult.Text =  " 0  KB";


                date.Text = GetDate().Replace('/', '.'); ;

                File.WriteAllText(@"C:\Users\youcode\source\repos\helloWord\PC__Cleaner\history.txt", GetDate());
                


                analysetext.Text = "analyse completed ! ";

            }
            catch (Exception e )
            {


                analysetext.Text = e.Message;
                
                
                
            }


        }


        public string GetDate()
        {

            DateTime date = DateTime.Today;
           return date.ToString("d");
           



        }



        public long[]  DirSize(DirectoryInfo d)
        {
            long size = 0;
            long files = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)

            {

                try
                {
                    if (!FileIsLocked(fi.FullName))

                    { 
                        size += fi.Length;
                        files += 1;

                    }
                       
                    
                }
                catch
                {
                    continue ;
                }
                 
                
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di)[0];
                files += DirSize(di)[1];
            }
             long[] values =  { size , files };
            return values;

        }


        public bool FileIsLocked(string strFullFileName)
        {
            bool blnReturn = false;
            FileStream fs;
            try
            {
                fs = File.Open(strFullFileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                fs.Close();
            }
            catch (IOException ex)
            {
                blnReturn = true;
            }
            return blnReturn;
        }




        private  void ClearTempData(DirectoryInfo di)
        {


                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {

                       File.Delete(file.FullName);

                    }
                    catch (Exception )
                    {

                  

                        continue;
                    }
                }

                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                    ClearTempData(dir);

                }
                    catch (Exception )
                    {

                        continue;
                    }
                }

   
        }



     
    }
}
