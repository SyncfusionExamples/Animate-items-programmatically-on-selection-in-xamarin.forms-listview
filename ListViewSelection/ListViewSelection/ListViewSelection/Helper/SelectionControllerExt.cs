using Syncfusion.ListView.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Selection
{
    public class SelectionControllerExt : SelectionController
    {
        public SelectionControllerExt(SfListView listView) : base(listView)
        {
        }

        protected async override void AnimateSelectedItem(ListViewItem selectedListViewItem)
        {
            base.AnimateSelectedItem(selectedListViewItem);
            selectedListViewItem.Opacity = 0;
            selectedListViewItem.FadeTo(1, 3000, Easing.SinInOut);
            //await selectedListViewItem.ScaleTo(0.95, 500, Easing.SinInOut);
            //await selectedListViewItem.ScaleTo(1, 500, Easing.SinInOut);
        }
    }
}