﻿using Reservoom.Store;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservoom.Services;

namespace Reservoom.Commands
{
    public class NavigationCommand : CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigationCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
