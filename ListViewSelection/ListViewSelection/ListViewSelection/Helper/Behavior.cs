using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Selection
{
   public class Behavior : Behavior<SfListView>
    {
        SfListView ListView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.SelectionController = new SelectionControllerExt(ListView);
            base.OnAttachedTo(bindable);
        }
    }
}
