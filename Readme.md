<!-- default file list -->
*Files to look at*:

* [Global.asax](./CS/Global.asax) (VB: [Global.asax](./VB/Global.asax))
* [Global.asax.cs](./CS/Global.asax.cs) (VB: [Global.asax.vb](./VB/Global.asax.vb))
* [TestModel.cs](./CS/Models/TestModel.cs) (VB: [TestModel.vb](./VB/Models/TestModel.vb))
* [GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)
* **[Index.cshtml](./CS/Views/Home/Index.cshtml)**
<!-- default file list end -->
# OBSOLETE - GridView - How to implement navigation by Up/Left/Down/Right keyboard arrows in the Batch Edit mode 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t350476)**
<!-- run online end -->


<p><strong>UPDATED:</strong><br><br>Starting with version v2016 vol 1 (v16.1), this functionality is available out of the box. Set the grid's <a href="http://help.devexpress.com/#AspNet/DevExpressWebGridBatchEditSettings_StartEditActiontopic">ASPxGridView.SettingsEditing.BatchEditSettings.StartEditAction</a> property to the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebGridViewBatchStartEditActionEnumtopic">FocusedCellClick</a> value to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2016/06/02/asp-net-grid-cell-bands-cell-merging-and-cell-focus-coming-soon-in-v16-1.aspx">ASP.NET Grid - Cell Bands, Cell Merging, and Cell Focus - (Coming soon in v16.1)</a> blog post, the <a href="http://demos.devexpress.com/MVCxGridViewDemos/Editing/BatchEditing">Batch Editing and Updating</a> demo and <a href="https://www.devexpress.com/Support/Center/p/T363560">ASPxGridView - Batch Edit - Provide cell focusing and keyboard navigation</a> thread for more information.<br><br>If you have version v16.1+ available, consider using the built-in functionality instead of the approach detailed below.<br><br><strong>For earlier versions:</strong><br><br>This example illustrates how to implement custom keyboard navigation in Batch Edit mode.  <br>The main idea is to handle the keydown event for the grid's HTML table and manually switch the next cell to edit mode using  the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientGridViewBatchEditApi_StartEdittopic">ASPxClientGridViewBatchEditApi.StartEdit</a>  method. <br>The <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientGridView_BatchEditStartEditingtopic">ASPxClientGridView.BatchEditStartEditing</a>  event is used to remember the last editing row and column indices.<br><br>Note that keyboard navigation (via arrows) won’t work well for such editors as the ComboBox and SpinEdit because they have their own key event handlers, which will prevent custom logic from being executed. So, this approach is mainly for TextBox and Memo editors. However, it will be possible to use different keys in this scenario. <br><br>This example doesn't implement data updates. Please refer to the <a href="https://www.devexpress.com/Support/Center/p/E5046">GridView - A simple Batch Editing implementation</a> example illustrating how to work with a model in Batch Edit mode.<br><br><strong>Web Forms: </strong><br><a href="https://www.devexpress.com/Support/Center/p/T283418">ASPxGridView - How to implement navigation by Up/Left/Down/Right buttons when the Batch Edit mode is used</a></p>

<br/>


