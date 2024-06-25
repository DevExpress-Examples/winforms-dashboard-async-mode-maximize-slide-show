<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/ViewerForm1.cs) (VB: [Form1.vb](./VB/ViewerForm1.vb))
<!-- default file list end -->

# How to Create a Slide Show with Asynchronous Maximize and Restore Methods

This example demonstrates how to call the asynchronous maximize and restore methods to create a slide show with the dashboard items.

![screenshot](/images/screenshot.png)

## API

* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.MaximizeDashboardItemAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.MaximizeDashboardItemAsync(System.String)) method. Maximizes the specified dashboard item asynchronously.
* [DashboardViewer.RestoreDashboardItemAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.RestoreDashboardItemAsync) method. Restores the item size if an item is expanded to the entire dashboard size (maximized), asynchronously.


## Documentation

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)

## More Examples

- [Dashboard Viewer: How to Get Dashboard Item Data Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-get-item-data)
- [Dashboard Viewer: How to Get FIlter Values and Set Master Filter Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-random-filter)
- [Dashboard Viewer: How to Invoke the Data Inspector Asynchronously When the Dashboard is Loaded](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-show-data-inspector)
