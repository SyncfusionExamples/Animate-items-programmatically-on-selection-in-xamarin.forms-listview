# Programmatic animation in ListView

When the [SfListView.SelectionMode](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectionMode.html) is other than `None`, the item or items in the SfListView can be selected from the code by setting the [SfListView.SelectedItem](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectedItem.html), or adding items to the [SfListView.SelectedItems](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectedItems.html) property based on the `SfListView.SelectionMode`.

When the selection mode is `Single`, programmatically select an item by setting the underlying object to the `SfListView.SelectedItem` property.

```
//Perform selection using selected item
listView.SelectedItem = viewModel.Items[5];
```

When the selection mode is Multiple, programmatically select more than one item by adding the underlying object to the SfListView.SelectedItems property.

```
//Perform multiple selection using selected items
listView.SelectedItems.Add (viewModel.Items [4]);
listView.SelectedItems.Add (viewModel.Items[5]);
```

All items of the SfListView can be selected using the [SelectAll](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectAll.html) method.

```
listView.SelectAll();
```

## Note
When programmatically select an item then the selection related events will not be triggered. It triggers only on UI interactions.
However, get the notification from the SelectedItems collection changed event which will be triggered when add an item at runtime.

To know more about the Selection in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/selection)