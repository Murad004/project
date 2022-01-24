using project.Commands;
using project.Helpers;
using project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace project.ViewModels
{
    public class RegisterWindowViewModel : BaseViewModel
    {

        public RelayCommand SendBtnCommand { get; set; }
        public static string VerifyCodee { get; set; }
        public RegisterWindowViewModel(RegisterPage registerPage)
        {
            SendBtnCommand = new RelayCommand((sender) =>
            {
                VerifyCodee = VerifyCode();


                string accountSid = "ACd7a8f894246b1a5ec31f2c19e95e2db7";
                string authToken = "9cdb57aff5ce171148cd35f4781e966c";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: $"{12121}",
                    from: new PhoneNumber("+16065179556"),
                    to: new PhoneNumber($"+994{registerPage.NumberTxtBox.Text}")
                );
                HelperClass.User = new Models.User();
                HelperClass.User.PhoneNumber = $"+994{registerPage.NumberTxtBox.Text}";

                VerifyNumberUserControl verifyNumberUserControl = new VerifyNumberUserControl(VerifyCodee);
                registerPage.MainGrid.Children.Add(verifyNumberUserControl);

            });
        }
        private string VerifyCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
