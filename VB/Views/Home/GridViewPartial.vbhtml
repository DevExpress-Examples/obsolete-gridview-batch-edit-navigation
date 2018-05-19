@Html.DevExpress().GridView(Sub(settings)

    settings.Name = "gridView"
    settings.KeyFieldName = "ID"
    settings.Width = 500
    settings.CallbackRouteValues = new With { .Controller = "Home", .Action = "GridViewPartial" }
    settings.SettingsEditing.BatchUpdateRouteValues = new With { .Controller = "Home", .Action = "GridViewBatchUpdatePartial" }
    settings.ClientSideEvents.Init = "OnInit"
    settings.ClientSideEvents.BatchEditStartEditing = "OnStartEditCell"
    settings.ClientSideEvents.BatchEditEndEditing = "OnEndEditCell"
    settings.SettingsPager.PageSize = 20
    settings.SettingsEditing.Mode = GridViewEditingMode.Batch
    settings.Styles.Cell.HorizontalAlign = HorizontalAlign.Left
    settings.SettingsPager.Visible = true
    settings.CellEditorInitialize = Sub (s, e)
         CType(e.Editor, ASPxEdit).ValidationSettings.Display = Display.Dynamic
    End Sub
End Sub).Bind(Model).GetHtml()
