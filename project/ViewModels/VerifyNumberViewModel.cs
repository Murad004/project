using project.Commands;
using project.Helpers;
using project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModels
{
    public class VerifyNumberViewModel:BaseViewModel
    {
        public RelayCommand SendBtnCommand { get; set; }
        public VerifyNumberViewModel(VerifyNumberUserControl verifyNumberUserControl, string VerifyCode)
        {
            verifyNumberUserControl.VerifyNumbertxt.Text = HelperClass.User.PhoneNumber;
            verifyNumberUserControl.VerifyNumbertxt2.Text = HelperClass.User.PhoneNumber;
            SendBtnCommand = new RelayCommand((sender) =>
            {
                //if (verifyNumberUserControl.CodeTextBox.Text == VerifyCode)
                //{
                FillProfileUserControl fillProfileUserControl = new FillProfileUserControl();
                verifyNumberUserControl.MainGrid.Children.Add(fillProfileUserControl);

                //}
                //else
                //{
                //    MessageBox.Show("Wrong Code.Try Again");
                //}


            });
        }
    }
}