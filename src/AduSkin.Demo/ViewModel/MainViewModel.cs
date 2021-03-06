﻿using AduSkin.Demo.Data;
using AduSkin.Demo.Models;
using AduSkin.Demo.UserControls;
using AduSkin.Demo.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace AduSkin.Demo.ViewModel
{
   public class MainViewModel : ViewModelBase
   {
      public MainViewModel()
      {

      }


      private int _SelectedModularIndex;
      /// <summary>
      /// 属性.
      /// </summary>
      public int SelectedModularIndex
      {
         get { return _SelectedModularIndex; }
         set { 
            Set(ref _SelectedModularIndex, value);
            if (value == 2)
               MainBackground= new SolidColorBrush(Color.FromRgb(28, 64, 139));
            else
               MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
         }
      }

      private SolidColorBrush _MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
      /// <summary>
      /// 属性.
      /// </summary>
      public SolidColorBrush MainBackground
      {
         get { return _MainBackground; }
         set { Set(ref _MainBackground, value); }
      }
      /// <summary>
      /// 命令Command
      /// </summary>
      public ICommand OpenClick => new RelayCommand<string>((e) =>
      {
         switch (e)
         {
            case "AduSkinDemo":
               new AduSkinDemo().Show();
               return;
            default:
               break;
         }
      });

      /// <summary>
      /// 常见控件
      /// </summary>
      private UserControl _CommonControlCase = new CommonControlCase();
      public UserControl CommonControlCase
      {
         get { return _CommonControlCase; }
         set { Set(ref _CommonControlCase, value); }
      }
      /// <summary>
      /// 实用案例
      /// </summary>
      private UserControl _PracticalCase = new PracticalCase();
      public UserControl PracticalCase
      {
         get { return _PracticalCase; }
         set { Set(ref _PracticalCase, value); }
      }
      /// <summary>
      /// 关于
      /// </summary>
      private UserControl _AduSkinAbout = new AduSkinAbout();
      public UserControl AduSkinAbout
      {
         get { return _AduSkinAbout; }
         set { Set(ref _AduSkinAbout, value); }
      }
   }
}
