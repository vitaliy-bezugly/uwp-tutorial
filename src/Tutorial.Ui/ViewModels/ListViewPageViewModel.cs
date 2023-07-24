using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Tutorial.Ui.Utilities;

namespace Tutorial.Ui.ViewModels
{
    public class ListViewPageViewModel : ViewModelBase
    {
        private string _selected;
        private ObservableCollection<string> _dataList;
        private readonly ICommand _updateListCommand;

        public ListViewPageViewModel()
        {
            _dataList = new ObservableCollection<string>();
            _selected = string.Empty;

            _updateListCommand = new CommandHandler((obj) => UpdateList(), (obj) => true);
        }

        public ObservableCollection<string> DataList
        {
            get => _dataList;
            set
            {
                _dataList = value;
                OnPropertyChanged();
            }
        }

        public string SelectedItem
        {
            get => _selected;
            set
            {
                _selected = value;
                OnPropertyChanged();
            }
        }

        public ICommand UpdateListCommand => _updateListCommand;

        private void UpdateList()
        {
            var random = new Random();
            DataList.Clear();

            for (int i = 0; i < 10; i++)
            {
                DataList.Add($"Random item {random.Next(1, 100)}");
            }
        }
    }
}
