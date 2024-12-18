﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AwesomeNetwork.ViewModels.Account
{
    public class MainViewModel
    {
        public RegisterViewModel RegisterView { get; set; }
        public LoginViewModel LoginView { get; set; }

        public MainViewModel()
        {
            RegisterView = new RegisterViewModel();
            LoginView = new LoginViewModel();
        }

    }
}
