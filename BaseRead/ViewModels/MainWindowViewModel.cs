using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ReactiveUI;
using System.Reactive;
using Microsoft.Data.Sqlite;
using System.IO;
using System;
using System.Reactive.Linq;

namespace BaseRead.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _base;
        private DataBaseViewModel data;
        private RequestEditorViewModel request_editor;

        public ViewModelBase Page
        {
            set => this.RaiseAndSetIfChanged(ref _base, value);
            get => _base;
        }
        public MainWindowViewModel()
        {
            data = new DataBaseViewModel();
            request_editor = new RequestEditorViewModel(data);
            Page = data;
        }

        public void OpenRequestEditor()
        {
            Page = request_editor;
        }

        public void OpenDataBase()
        {
            Page = data;
        }
    }
}
