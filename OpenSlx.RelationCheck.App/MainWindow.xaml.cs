﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenSlx.RelationCheck.App.ViewModel;
using OpenSlx.RelationCheck.UI;


/*
   OpenSlx - Open Source SalesLogix Library and Tools
   Copyright 2010 nicocrm (http://github.com/nicocrm/OpenSlx)

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/


namespace OpenSlx.RelationCheck.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var model = new MainWindowViewModel();
            model.Initialize();
            model.LoginSuccessful += new EventHandler(model_LoginSuccessful);
            DataContext = model;
        }

        void model_LoginSuccessful(object sender, EventArgs e)
        {
            //NavigationService.GetNavigationService(this).Navigate("/OpenSlx.RelationCheck;component/UI/RelationshipCheckWin");
            Hide();
            new RelationshipCheckWin().ShowDialog();
            Close();
        }
    }
}