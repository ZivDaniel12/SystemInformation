using SI.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Threading;

namespace SI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel vm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        /// <summary>
        /// Update the UI every 7 sec
        /// </summary>
        private void UpdateUI()
        {
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(7)
            };
            timer.Tick += new EventHandler((object s, EventArgs a) =>
            {
                var thread = new Thread(() =>
                {

                    txtUpdateStatus.Dispatcher.Invoke(() =>
                    {
                        txtUpdateStatus.Text = "Updating parameters...";
                    });

                    Refresh_Click(s, a);
                    CheckIfURLIsValid(s, a);
                    IsPathExists(s, a);

                    txtUpdateStatus.Dispatcher.Invoke(() =>
                    {
                        txtUpdateStatus.Text = "Last updated " + DateTime.Now;
                    });
                });

                thread.Start();
            });
            timer.Start();
        }



        /// <summary>
        /// refresh th system parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_Click(object sender, EventArgs e)
        {

            txtblockCPU.Dispatcher.Invoke(() =>
            {
                txtblockCPU.Text = vm.CPU;
            });

            txtNumberOfProccess.Dispatcher.Invoke(() =>
            {
                txtNumberOfProccess.Text = vm.ProccessNumber.ToString();
            });

            txtblockMemoryCommitted.Dispatcher.Invoke(() =>
            {
                txtblockMemoryCommitted.Text = vm.MemoryCommitted;
            });

        }


        /// <summary>
        /// check if the url is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckIfURLIsValid(object sender, EventArgs e)
        {

            txtblckIsURLValid.Dispatcher.Invoke(() =>
            {
                txtblckIsURLValid.Text = "Start to check the URL...";
                IsURLValid(txtboxURL.Text);
            });

        }

        /// <summary>
        /// check if the path is exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsPathExists(object sender, EventArgs e)
        {

            string path = string.Empty;
            txtblckIsPathExits.Dispatcher.Invoke(() =>
            {
                txtblckIsPathExits.Text = "Start to find the path";
                path = txtboxDicPath.Text;
            });

            var thread = new Thread(() =>
            {
                string message = string.Empty;
                if (!string.IsNullOrEmpty(path))
                {
                    message = $"Path{(File.Exists(path) || Directory.Exists(path) ? string.Empty : " Not")} Exists";
                }
                else message = "Path is empty";

                txtblckIsPathExits.Dispatcher.Invoke(() =>
                {
                    txtblckIsPathExits.Text = message;
                });

            });

            thread.Start();
        }

        /// <summary>
        /// check if the url is valid and in the correct format
        /// </summary>
        /// <param name="url">the url to check</param>
        /// <param name="errorText">the error text</param>
        /// <returns></returns>
        private void IsURLValid(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                txtblckIsURLValid.Dispatcher.Invoke(() => { txtblckIsURLValid.Text = "URL is empty"; }, DispatcherPriority.Normal);
                return;
            }

            string errorText = string.Empty;
            bool isValid;
            try
            {
                Thread.Sleep(1000);
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 15000;
                request.Method = "HEAD";
                txtblckIsURLValid.Dispatcher.Invoke(() => { txtblckIsURLValid.Text = "Almost there.."; }, DispatcherPriority.Normal);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    isValid = response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (UriFormatException)
            {
                errorText = "-URL format is not valid";
                isValid = false;
            }
            catch (WebException)
            {
                isValid = false;
            }

            string txt_url_not_valid = $"URL is not valid {(string.IsNullOrEmpty(errorText) ? string.Empty : errorText)}";
            string message = isValid ? "URL is valid" : txt_url_not_valid; ;
            txtblckIsURLValid.Dispatcher.Invoke(() => { txtblckIsURLValid.Text = message; }, DispatcherPriority.Normal);
        }




    }

}
