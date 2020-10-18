﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using U41.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace U41
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;

        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>
            {
                new Icon { IconPath = "Assets/male-01.png" },
                new Icon { IconPath = "Assets/male-02.png" },
                new Icon { IconPath = "Assets/male-03.png" },
                new Icon { IconPath = "Assets/female-01.png" },
                new Icon { IconPath = "Assets/female-02.png" },
                new Icon { IconPath = "Assets/female-03.png" }
            };

            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { FirstName = "Dang Kim", LastName = "Thi", AvatarPath = "Assets/female-01.png" });
            Contacts.Add(new Contact { FirstName = "Dang", LastName = "Minh", AvatarPath = "Assets/male-03.png" });
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarCombobox.SelectedValue).IconPath;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, AvatarPath = avatar });

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AvatarCombobox.SelectedIndex = -1;

            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
        
    }
}
