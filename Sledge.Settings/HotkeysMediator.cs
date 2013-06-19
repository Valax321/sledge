namespace Sledge.Settings
{
    public enum HotkeysMediator
    {
        FourViewAutosize,
        FourViewFocusTopLeft,
        FourViewFocusTopRight,
        FourViewFocusBottomLeft,
        FourViewFocusBottomRight,

        FileNew,
        FileOpen,
        FileClose,
        FileSave,
        FileSaveAs,
        FileExport,
        FileCompile,

        HistoryUndo,
        HistoryRedo,

        OperationsCopy,
        OperationsCut,
        OperationsPaste,
        OperationsPasteSpecial,
        OperationsDelete,

        SelectAll,
        SelectionClear,

        ObjectProperties,

        Carve,
        MakeHollow,

        GroupingGroup,
        GroupingUngroup,
        GroupingToggleIgnore,

        TieToEntity,
        TieToWorld,

        Transform,

        SnapSelectionToGrid,
        SnapSelectionToGridIndividually,

        AlignXMin,
        AlignXMax,
        AlignYMin,
        AlignYMax,
        AlignZMin,
        AlignZMax,

        FlipX,
        FlipY,
        FlipZ,

        GridIncrease,
        GridDecrease,

        CenterAllViewsOnSelection,
        Center3DViewsOnSelection,
        Center2DViewsOnSelection,

        GoToCoordinates,
        GoToBrushID,
        ShowSelectedBrushID,

        ToggleSnapToGrid,
        ToggleShow2DGrid,
        ToggleShow3DGrid,

        ShowMapInformation,
        ShowEntityReport,
        CheckForProblems,

        QuickLoadPointfile,
        LoadPointfile,
        UnloadPointfile,
    }
}