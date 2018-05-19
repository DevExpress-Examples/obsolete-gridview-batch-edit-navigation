
<script type="text/javascript">
    var FocusedCellColumnIndex = 0;
    var FocusedCellRowIndex = 0;
    var command = "";
    function OnInit(s, e) {
        ASPxClientUtils.AttachEventToElement(s.GetMainElement(), "keydown", function (evt) {
            if (evt.keyCode === ASPxClientUtils.StringToShortcutCode("UP"))
                UpPressed(s);
            else if (evt.keyCode === ASPxClientUtils.StringToShortcutCode("DOWN"))
                DownPressed(s);
            else if (evt.keyCode === ASPxClientUtils.StringToShortcutCode("RIGHT"))
                RightPressed(s);
            else if (evt.keyCode === ASPxClientUtils.StringToShortcutCode("LEFT"))
                LeftPressed(s);
        });
    }
    function OnEndEditCell(s, e) {
        FocusedCellColumnIndex = 0;
        FocusedCellRowIndex = 0;
    }
   
    function OnStartEditCell(s, e) {
        FocusedCellColumnIndex = e.focusedColumn.index;
        FocusedCellRowIndex = e.visibleIndex;
    }
    
    function UpPressed(grid) {
        if (FocusedCellRowIndex > grid.GetTopVisibleIndex())
            grid.batchEditApi.StartEdit(FocusedCellRowIndex - 1, FocusedCellColumnIndex);
       
    }
    function DownPressed(grid) {
        var bottomRowIndex = grid.GetVisibleRowsOnPage() + grid.GetTopVisibleIndex() - 1;
        if (FocusedCellRowIndex < bottomRowIndex)
            grid.batchEditApi.StartEdit(FocusedCellRowIndex + 1, FocusedCellColumnIndex);
     
    }
    function RightPressed(grid) {
        if (FocusedCellColumnIndex < grid.GetColumnCount() - 1)
            grid.batchEditApi.StartEdit(FocusedCellRowIndex, FocusedCellColumnIndex + 1);
      
    }
    function LeftPressed(grid) {
        if (FocusedCellColumnIndex > 0)
            grid.batchEditApi.StartEdit(FocusedCellRowIndex, FocusedCellColumnIndex - 1);     
    }
</script>
<form>
    @Html.Action("GridViewPartial")
</form>