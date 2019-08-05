using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Selection
{
    public class Task : INotifyPropertyChanged
    {
        #region Fields

        private string _Title;
        private string _Description;
        private string _Tag;
        private ImageSource _Imagesource;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a value that indicates Task's header. 
        /// </summary>
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                this.RaisePropertyChanged("Title");
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates Task's description. 
        /// </summary>
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                this.RaisePropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates Task's tag collection. 
        /// </summary>
        public string Tag
        {
            get
            {
                return _Tag;
            }
            set
            {
                _Tag = value;
                this.RaisePropertyChanged("Tag");
            }
        }

        /// <summary>
        /// Gets or sets a ImageSource that indicates Task's image. 
        /// </summary>
        public ImageSource Imagesource
        {
            get
            {
                return _Imagesource;
            }
            set
            {
                _Imagesource = value;
                this.RaisePropertyChanged("Imagesource");
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
