namespace Fable.MaterialUI
open Fable.Core
open Fable.Core.JsInterop

module Core =
    open Fable.Helpers.React
    open Fable.Helpers.React.Props
    open Fable.MaterialUI.Props
    open Fable.MaterialUI.Themes
    open Fable.Import.React

    let toObj p = keyValueList CaseRules.LowerFirst p

    let inline appBar (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/AppBar" (toObj b) c
    let inline avatar (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Avatar" (toObj b) c
    let inline backdrop (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Backdrop" (toObj b) []
    let inline badge (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Badge" (toObj b) c
    let inline bottomNavigation (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/BottomNavigation" (toObj b) c
    let inline bottomNavigationAction (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/BottomNavigationAction" (toObj b) []
    let inline button (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Button" (toObj b) c
    let inline buttonBase (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ButtonBase" (toObj b) c
    let inline card (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Card" (toObj b) c
    let inline cardActionArea (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/CardActionArea" (toObj b) c
    let inline cardActions (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/CardActions" (toObj b) c
    let inline cardContent (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/CardContent" (toObj b) c
    let inline cardHeader (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/CardHeader" (toObj b) c
    let inline cardMedia (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/CardMedia" (toObj b) []
    let inline checkbox (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Checkbox" (toObj b) []
    let inline chip (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Chip" (toObj b) []
    let inline circularProgress (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/CircularProgress" (toObj b) []
    let inline clickAwayListener (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ClickAwayListener" (toObj b) c
    let inline collapse (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Collapse" (toObj b) c
    let inline cssBaseline (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/CssBaseline" (toObj b) []
    let inline dialog (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Dialog" (toObj b) c
    let inline dialogActions (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/DialogActions" (toObj b) c
    let inline dialogContent (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/DialogContent" (toObj b) c
    let inline dialogContentText (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/DialogContentText" (toObj b) c
    let inline dialogTitle (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/DialogTitle" (toObj b) c
    let inline divider (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Divider" (toObj b) []
    let inline drawer (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Drawer" (toObj b) c
    let inline expansionPanel (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanel" (toObj b) c
    let inline expansionPanelActions (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanelActions" (toObj b) c
    let inline expansionPanelDetails (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanelDetails" (toObj b) c
    let inline expansionPanelSummary (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanelSummary" (toObj b) c
    let inline fab (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Fab" (toObj b) c
    let inline fade (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Fade" (toObj b) c
    let inline filledInput (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/FilledInput" (toObj b) c
    let inline formControl (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/FormControl" (toObj b) c
    let inline formControlLabel (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/FormControlLabel" (toObj b) c
    let inline formGroup (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/FormGroup" (toObj b) c
    let inline formHelperText (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/FormHelperText" (toObj b) c
    let inline formLabel (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/FormLabel" (toObj b) c
    let inline grid (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Grid" (toObj b) c
    let inline gridList (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/GridList" (toObj b) c
    let inline gridListTile (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/GridListTile" (toObj b) c
    let inline gridListTileBar (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/GridListTileBar" (toObj b) c
    let inline grow (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Grow" (toObj b) c
    let inline hidden (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Hidden" (toObj b) c
    let inline icon (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Icon" (toObj b) c
    let inline iconButton (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/IconButton" (toObj b) c
    let inline input (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Input" (toObj b) []
    let inline inputAdornment (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/InputAdornment" (toObj b) c
    let inline inputBase (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/InputBase" (toObj b) []
    let inline inputLabel (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/InputLabel" (toObj b) c
    let inline linearProgress (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/LinearProgress" (toObj b) []
    let inline list (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/List" (toObj b) c
    let inline listItem (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ListItem" (toObj b) c
    let inline listItemAvatar (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ListItemAvatar" (toObj b) c
    let inline listItemIcon (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ListItemIcon" (toObj b) c
    let inline listItemSecondaryAction (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ListItemSecondaryAction" (toObj b) c
    let inline listItemText (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ListItemText" (toObj b) c
    let inline listSubheader (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ListSubheader" (toObj b) c
    let inline menu (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Menu" (toObj b) c
    let inline menuItem (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/MenuItem" (toObj b) c
    let inline menuList (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/MenuList" (toObj b) c
    let inline mobileStepper (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/MobileStepper" (toObj b) []
    let inline modal (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Modal" (toObj b) c
    let inline nativeSelect (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/NativeSelect" (toObj b) c
    let inline outlinedInput (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/OutlinedInput" (toObj b) c
    let inline paper (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Paper" (toObj b) c
    let inline popover (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Popover" (toObj b) c
    let inline popper (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Popper" (toObj b) c
    let inline portal (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Portal" (toObj b) c
    let inline radio (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Radio" (toObj b) []
    let inline radioGroup (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/RadioGroup" (toObj b) c
    let inline rootRef (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/RootRef" (toObj b) c
    let inline select (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Select" (toObj b) c
    let inline slide (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Slide" (toObj b) c
    let inline snackbar (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Snackbar" (toObj b) c
    let inline snackbarContent (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/SnackbarContent" (toObj b) c
    let inline step (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Step" (toObj b) c
    let inline stepButton (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/StepButton" (toObj b) c
    let inline stepConnector (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/StepConnector" (toObj b) c
    let inline stepContent (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/StepContent" (toObj b) c
    let inline stepIcon (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/StepIcon" (toObj b) c
    let inline stepLabel (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/StepLabel" (toObj b) c
    let inline stepper (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Stepper" (toObj b) c
    let inline svgIcon (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/SvgIcon" (toObj b) c
    let inline swipeableDrawer (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/SwipeableDrawer" (toObj b) c
    let inline switch (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Switch" (toObj b) []
    let inline tab (b : IHTMLProp list) : ReactElement = ofImport "default" "@material-ui/core/Tab" (toObj b) []
    let inline tabs (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Tabs" (toObj b) c
    let inline table (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Table" (toObj b) c
    let inline tableBody (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TableBody" (toObj b) c
    let inline tableCell (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TableCell" (toObj b) c
    let inline tableFooter (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TableFooter" (toObj b) c
    let inline tableHead (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TableHead" (toObj b) c
    let inline tablePagination (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TablePagination" (toObj b) c
    let inline tableRow (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TableRow" (toObj b) c
    let inline tableSortLabel (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TableSortLabel" (toObj b) c
    let inline textField (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/TextField" (toObj b) c
    let inline toolbar (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Toolbar" (toObj b) c
    let inline tooltip (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Tooltip" (toObj b) c
    let inline touchRipple (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/ButtonBase/TouchRipple" (toObj b) c
    let inline typography (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Typography" (toObj b) c
    let inline zoom (b : IHTMLProp list) c : ReactElement = ofImport "default" "@material-ui/core/Zoom" (toObj b) c

    type IClasses = interface end
    type IClassesProps =
        abstract member classes: IClasses

    let withStyles'<'P, 'O when 'P :> IClassesProps>
        styles (options: 'O) (fn : 'P->Fable.Import.React.ReactElement) : Fable.Import.React.ComponentClass<'P> =
        !!((import "withStyles" "@material-ui/core/styles") $ (styles, options) $ fn)

    let withStyles<'P when 'P :> IClassesProps>
        (styles : StyleType)
        (options: StyleOption list)
        (fn : 'P -> Fable.Import.React.ReactElement) =
        let styles' =
            match styles with
            | StyleType.Styles styles -> (keyValueList CaseRules.LowerFirst styles |> unbox)
            | StyleType.Func func -> func >> keyValueList CaseRules.LowerFirst
        withStyles' styles' (keyValueList CaseRules.LowerFirst options) fn

    let inline muiThemeProvider (b : IHTMLProp list) c = ofImport "MuiThemeProvider" "@material-ui/core/styles" (toObj b) c

    [<Import("createMuiTheme", "@material-ui/core/styles")>]
    let private createMuiTheme'<'O> (options: 'O) : ITheme = jsNative

    let createMuiTheme (options: ThemeProp list) =
        options
        |> keyValueList CaseRules.LowerFirst
        |> unbox
        |> createMuiTheme'

    type IThemeProps =
        abstract member theme : ITheme

    [<Import("withTheme", "@material-ui/core/styles")>]
    let withTheme' : obj = jsNative

    let withTheme<'P when 'P :> IThemeProps>
        (fn : 'P->Fable.Import.React.ReactElement) : Fable.Import.React.ComponentClass<'P> =
        !!(withTheme' $ () $ fn)

    let withWidth'<'O, 'P>
        (options: 'O)
        (fn : 'P->Fable.Import.React.ReactElement) : Fable.Import.React.ComponentClass<'P> =
        !!((importDefault "@material-ui/core/withWidth") $ options $ fn)

    let withWidth<'P>
        (options: WithWidthOption list)
        (fn: ('P -> Fable.Import.React.ReactElement)) =
        withWidth' (keyValueList CaseRules.LowerFirst options |> unbox) fn

    type IWidthProps =
        abstract member width : Breakpoint

    let isWidthUp (breakpoint : Breakpoint) (screenWidth : Breakpoint) (inclusive : bool) =
        importMember "@material-ui/core/withWidth"

    let isWidthDown (breakpoint : Breakpoint) (screenWidth : Breakpoint) (inclusive : bool) =
        importMember "@material-ui/core/withWidth"

module ColorManipulator =

    [<StringEnum; RequireQualifiedAccess>]
    type ColorFormat = Rgb | Rgba | Hsl | Hsla

    type ColorObject =
        abstract member ``type``: ColorFormat
        abstract member values: float array

    let recomposeColor (color: ColorObject): string =
        import "recomposeColor" "@material-ui/core/styles/colorManipulator"

    let convertHexToRGB (hex: string): string =
        import "convertHexToRGB" "@material-ui/core/styles/colorManipulator"

    let rbgToHex (color: string): string =
        import "rbgToHex" "@material-ui/core/styles/colorManipulator"

    let decomposeColor (color: string): ColorObject =
        import "decomposeColor" "@material-ui/core/styles/colorManipulator"

    let getContrastRatio ((foreground: string), (background: string)): float =
        import "getContrastRatio" "@material-ui/core/styles/colorManipulator"

    let getLuminance (color: string) =
        import "getLuminance" "@material-ui/core/styles/colorManipulator"

    let emphasize ((color: string), (coefficient: float)): string =
        import "emphasize" "@material-ui/core/styles/colorManipulator"

    let fade ((color: string), (value: float)): string =
        import "fade" "@material-ui/core/styles/colorManipulator"

    let darken ((color: string), (coefficient: float)): string =
        import "darken" "@material-ui/core/styles/colorManipulator"

    let lighten ((color: string), (coefficient: float)): string =
        import "lighten" "@material-ui/core/styles/colorManipulator"
