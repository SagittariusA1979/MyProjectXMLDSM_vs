using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectXMLDSM_vs.ModelViews;
using MyProjectXMLDSM_vs.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MyProjectXMLDSM_vs.ModelViews
{
    public partial class NavigatorModelView : ObservableObject
    {
        #region Instance
        private static NavigatorModelView _instanceNav;
        public static NavigatorModelView InstanceNav => _instanceNav ??= new NavigatorModelView();
        #endregion

        public NavigatorModelView() 
        {
            SelectViewModel = new StartView();
        }

        #region ObservalProperty
        [ObservableProperty]
        private object selectViewModel;

        #endregion

        #region RealyCommand
        [RelayCommand]
        private void ICitem01() 
        {
            SelectViewModel = new PrintView();
        }

        [RelayCommand]
        private void ICitem02()
        {
            SelectViewModel = new PreparingView();
        }

        [RelayCommand] 
        private void ICitem03()
        {
            SelectViewModel = new SettingView();
        }
        #endregion


    }
}
