using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Selection
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<Task> items;

        #endregion

        #region Constructor
        public ViewModel()
        {
            AddItemDetails();
        }

        #endregion

        #region Properties

        public ObservableCollection<Task> Items
        {
            get { return items; }
            set
            {
                if (items != value)
                {
                    items = value;
                    OnPropertyChanged("Items");
                }
            }
        }

        #endregion

        #region Methods
        private void AddItemDetails()
        {
            Items = new ObservableCollection<Task>();

            Task item = new Task();
            item.Title = "UWP Issue - 6593";
            item.Description = "Sorting is not working properly in DataGrid";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image1.png");
            Items.Add(item);

            item = new Task();
            item.Title = "New Feature - 7213";
            item.Description = "Need to implement DeckofCards support";
            item.Tag = "New Control";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image2.png");
            Items.Add(item);

            item = new Task();
            item.Title = "UG - 6516";
            item.Description = "Need to do post processing work for closed incidents";
            item.Tag = "Post Processing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image5.png");
            Items.Add(item);

            item = new Task();
            item.Title = "UWP Issue - 651";
            item.Description = "Itemstyle is not update when the background is changed for the item";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image3.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WinPhone Issue - 646";
            item.Description = "Group header is not collapsed in WinPhone";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image4.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WPF Issue - 23822";
            item.Description = "Need to implement tooltip support for Fill series.";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image6.png");
            Items.Add(item);

            item = new Task();
            item.Title = "ListView Feature - 25678";
            item.Description = "Need to prepare SampleBrowser sample";
            item.Tag = "New Control";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image7.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WinForms Issue - 1254";
            item.Description = "HorizontalAlignment for tooltip is not working";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image8.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WPF Issue - 28066";
            item.Description = "In minimized state, first and last segment have incorrect spacing";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image9.png");
            Items.Add(item);

            item = new Task();
            item.Title = "Android Issue - 29477";
            item.Description = "Null reference exception throws when the Sticky header is changed.";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image10.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WPF Issue - 29574";
            item.Description = "Minimum and maximum property are not working in dynamic update";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image11.png");
            Items.Add(item);

            item = new Task();
            item.Title = "ListView Feature - 27654";
            item.Description = "Need to prepare demo sample";
            item.Tag = "New Control";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image12.png");
            Items.Add(item);

            item = new Task();
            item.Title = "Spreadsheet Feature - 2674";
            item.Description = "Need to implement tooltip support for Spreadsheet";
            item.Tag = "New Control";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image13.png");
            Items.Add(item);

            item = new Task();
            item.Title = "New Feature - 21274";
            item.Description = "Dragging events support for ListView";
            item.Tag = "New Control";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image14.png");
            Items.Add(item);

            item = new Task();
            item.Title = "iOS Issue - 19574";
            item.Description = "Selection is not working on multiple selection mode";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "UWP Issue - 31621";
            item.Description = "Need to remove the Pdf's Bookmark button from the Print Preview window";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WPF Issue - 31528";
            item.Description = "Formula cell values are not undo correctly after deleting the row and perform undo";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WinForms Issue - 31425";
            item.Description = "SUMPRODUCT formula doesn't returns calculated value correctly";
            item.Tag =  "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "UWP Issue - 2339";
            item.Description = "Selection Highlight on Header Cells are not working properly";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "Spreadsheet Issue - 31335";
            item.Description = "Issue in NamedRanges when placed inside of paranthesis";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "New Control - 29574";
            item.Description = "Create sample for Selection for ListView";
            item.Tag = "New Control";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "Spreadsheet Control - 31529";
            item.Description = "Build testing – Phase 2 (Toolbox, designer, certification testing, warnings)";
            item.Tag = "Release Work";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "New Feature - 24190";
            item.Description = "Need to implement Item-reorder for Datagrid.";
            item.Tag = "DataGrid Feature";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "WinPhone Issue - 2824";
            item.Description = "Group header is not expanded in WinPhone";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

            item = new Task();
            item.Title = "iOS Issue - 2740";
            item.Description = "Item template is not working when orientation is changed";
            item.Tag = "Bug Fixing";
            item.Imagesource = ImageSource.FromResource("ListViewSelection.Images.Image15.png");
            Items.Add(item);

        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
