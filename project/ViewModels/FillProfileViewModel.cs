using Newtonsoft.Json;
using project.Commands;
using project.Helpers;
using project.Models;
using project.Views;
using server.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace project.ViewModels
{
    public class FillProfileViewModel:BaseViewModel
    {
        public RelayCommand DoneBtnCommand { get; set; }
        public RelayCommand ChooseImageBtnCommand { get; set; }
        public string ImagePath { get; set; }
        public string Path { get; set; }
        public FillProfileViewModel(FillProfileUserControl fillProfileUserControl)
        {
            DoneBtnCommand = new RelayCommand((sender) =>
            {
                try
                {
                    User user = new User()
                    {
                        Name = fillProfileUserControl.nametxtbox.Text,
                        About = fillProfileUserControl.Infotxtbox.Text,
                        PhoneNumber = fillProfileUserControl.Phone.Text,
                        ImagePath = ImagePath
                    };
                    MainWindow mainWindow = new MainWindow();
                    TcpClient client = new TcpClient();
                    client.Connect(ConnectHelper.IpAdress, ConnectHelper.Port);
                    HelperClass.Client = client;
                    //HelperClass.clientDict = new Dictionary<TcpClient,User>();
                    //HelperClass.clientDict.Add(client, user);
                    string json = JsonConvert.SerializeObject(user);

                    if (File.Exists(@"C:\Users\Sadi_er59\source\repos\project\project\bin\Debug\1.json"))
                    {
                        File.WriteAllText(@"C:\Users\Sadi_er59\source\repos\project\project\bin\Debug\1.json", json);
                    }
                    else
                    {
                        File.WriteAllText(@"C:\Users\Sadi_er59\source\repos\project\project\bin\Debug\1.json", json);

                    }
                    //string json = JsonConvert.SerializeObject(HelperClass.clientDict);
                    try
                    {

                        HelperClass.register.Close();
                    }
                    catch (Exception)
                    {

                    }
                    mainWindow.ShowDialog();
                }
                catch (Exception ex)
                {

                }


            });
            ChooseImageBtnCommand = new RelayCommand((sender) =>
            {

                try
                {
                    var open = new Microsoft.Win32.OpenFileDialog();

                    open.Multiselect = false;
                    open.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                    open.ShowDialog();
                    //Text = PdfHelper.ReadPdfFile(open.FileName);
                    ImagePath = open.FileName;
                    //fillProfileUserControl.img.ImageSource = new BitmapImage(new Uri(ImagePath));

                    //mainWindow.image1.Source = new BitmapImage(new Uri(open.FileName));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }
    }
}