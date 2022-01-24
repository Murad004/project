using Newtonsoft.Json;
using project.Commands;
using project.Helpers;
using project.Models;
using project.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModels
{
    public class StartWindowViewModel : BaseViewModel
    {
        public RelayCommand AgreeAndContinueBtnCommand { get; set; }
        public List<User> Users { get; set; }
        public StartWindowViewModel(StartWindow startWindow)
        {
            AgreeAndContinueBtnCommand = new RelayCommand((sender) => {
                try
                {
                    Users = new List<User>();
                    if (File.Exists(@"C:\Users\mehsu\source\repos\WhatsAppDemo\WhatsAppDemo\bin\Debug\1.json"))
                    {
                        // Users.Add(JsonConvert.DeserializeObject<User>(File.ReadAllText(@"C:\Users\mehsu\source\repos\WhatsAppDemo\WhatsAppDemo\bin\Debug\1.json")));
                        HelperClass.MainUser = JsonConvert.DeserializeObject<User>(File.ReadAllText(@"C:\Users\mehsu\source\repos\WhatsAppDemo\WhatsAppDemo\bin\Debug\1.json"));
                    }
                    RegisterPage registerPage = new RegisterPage();
                    startWindow.Close();
                    registerPage.ShowDialog();

                }
                catch (Exception)
                {

                }

            });
        }
    }
}
