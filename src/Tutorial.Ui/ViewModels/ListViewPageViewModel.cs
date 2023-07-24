using System.Collections.ObjectModel;
using System.Windows.Input;
using Tutorial.Ui.Helpers;
using Tutorial.Ui.Services;
using Tutorial.Ui.Utilities;

namespace Tutorial.Ui.ViewModels
{
    public class ListViewPageViewModel : ViewModelBase
    {
        private string _selected;
        private ObservableCollection<string> _dataList;
        private readonly ICommand _updateListCommand;
        private readonly DataService _dataService;

        public ListViewPageViewModel()
        {
            _dataList = new ObservableCollection<string>();
            _selected = string.Empty;

            _dataService = App.Current.GetService<DataService>();
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
            DataList.Clear();

            foreach (var item in _dataService.GetRandomData(15))
            {
                DataList.Add(item);
            }
        }
    }
}
