﻿using System;
using System.Collections.Generic;
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

namespace AdministrationProgram.wpf.ConfigurationWizard
{

    public partial class SaveAndClosePage : Page
    {   

        Wizard wizard;

        public SaveAndClosePage()
        {
            InitializeComponent();
        }

        public SaveAndClosePage(Wizard wizard) : this()
        {
            this.wizard = wizard;
        }

    }
}
