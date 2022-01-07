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

namespace JanuaryExam2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> members = new List<Member>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Member> CreateMembers()
        { 


        JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
        JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
        JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };

        Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
        Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
        Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };

        SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
        SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
        SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };

            members.Add(jm1);
            members.Add(jm2);
            members.Add(jm3);

            members.Add(m1);
            members.Add(m2);
            members.Add(m3);

            members.Add(sm1);
            members.Add(sm2);
            members.Add(sm3);


            return members;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            members = CreateMembers();

            lbxMembers.ItemsSource = members;
        }


    }
}
