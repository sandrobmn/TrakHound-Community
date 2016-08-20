﻿using System.Windows;
using System.Windows.Controls;

namespace TrakHound_Device_Manager.Pages.Cycles.Controls
{
    /// <summary>
    /// Interaction logic for OverrideLinkItem.xaml
    /// </summary>
    public partial class OverrideLinkItem : UserControl
    {
        public OverrideLinkItem()
        {
            InitializeComponent();
            DataContext = this;
        }

        public Page ParentPage
        {
            get { return (Page)GetValue(ParentPageProperty); }
            set { SetValue(ParentPageProperty, value); }
        }

        public static readonly DependencyProperty ParentPageProperty =
            DependencyProperty.Register("ParentPage", typeof(Page), typeof(OverrideLinkItem), new PropertyMetadata(null));



        public object SelectedId
        {
            get { return (object)GetValue(SelectedIdProperty); }
            set { SetValue(SelectedIdProperty, value); }
        }

        public static readonly DependencyProperty SelectedIdProperty =
            DependencyProperty.Register("SelectedId", typeof(object), typeof(OverrideLinkItem), new PropertyMetadata(null));



        public delegate void SettingChanged_Handler();
        public event SettingChanged_Handler SettingChanged;

        public delegate void Clicked_Handler(OverrideLinkItem item);

        private void Link_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.IsKeyboardFocusWithin)
            {
                if (SettingChanged != null) SettingChanged();
            }
        }

        private void ComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.IsKeyboardFocusWithin || combo.IsMouseCaptured)
            {
                if (SettingChanged != null) SettingChanged();
            }
        }

        #region "Remove"

        public event Clicked_Handler RemoveClicked;

        private void Removed_Clicked(TrakHound_UI.Button bt)
        {
            if (RemoveClicked != null) RemoveClicked(this);
            if (SettingChanged != null) SettingChanged();
        }

        #endregion

        public event Clicked_Handler RefreshClicked;

        private void Refresh_Clicked(TrakHound_UI.Button bt)
        {
            if (RefreshClicked != null) RefreshClicked(this);
        }

    }
}
