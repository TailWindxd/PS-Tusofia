using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    internal class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            string displayMSG = String.Format($"Welcome\n" +
                $"User:{_viewModel.Name}\n" +
                $"Role:{_viewModel.Role}");

            
            Console.WriteLine(displayMSG);

        }                     
    }                         
}
