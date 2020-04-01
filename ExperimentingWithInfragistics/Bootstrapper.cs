using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;
using ExperimentingWithInfragistics.ViewModels;
using Infragistics.Windows.DataPresenter;

namespace ExperimentingWithInfragistics
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
            var c =ConventionManager.AddElementConvention<XamDataGrid>(XamDataGrid.DataSourceProperty, "DataSource", "Loaded");
                c.ApplyBinding = (viewModelType, path, property, element, convention) =>
                {
                    if (!ConventionManager.SetBindingWithoutBindingOverwrite(viewModelType, path, property, element, convention, TextBox.TextProperty))
                    {
                        return false;
                    }
                
                    // ConventionManager.Configure
                
                    var xamDataGrid = (XamDataGrid) element;
                
                    // xamDataGrid.DataSource = property.;
                
                    return true;
                };
        }

        // protected override void Configure()
        // {
        //     _container.Singleton<IWindowManager, WindowManager>()
        //         .PerRequest<IShell, ShellViewModel>();
        // }
        //
        // protected override object GetInstance(Type serviceType, string key)
        // {
        //     var instance = _container.GetInstance(serviceType, key);
        //     if (instance != null)
        //         return instance;
        //     throw new InvalidOperationException("Could not locate any instances.");
        // }
        //
        // protected override IEnumerable<object> GetAllInstances(Type serviceType)
        // {
        //     return _container.GetAllInstances(serviceType);
        // }
        //
        // protected override void BuildUp(object instance)
        // {
        //     _container.BuildUp(instance);
        // }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
