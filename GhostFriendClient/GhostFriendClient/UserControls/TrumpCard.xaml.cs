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

namespace GhostFriendClient.UserControls
{
    /// <summary>
    /// TrumpCard.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TrumpCard : UserControl
    {
        public TrumpCard()
        {
            InitializeComponent();
        }

        public string CardValue
        {
            get { return (string)GetValue(CardValueProperty); }
            set { SetValue(CardValueProperty, value); }
        }

        public static readonly DependencyProperty CardValueProperty
            = DependencyProperty.Register("CardValue", typeof(string), typeof(TrumpCard), new FrameworkPropertyMetadata(default(string)));
    }
}
