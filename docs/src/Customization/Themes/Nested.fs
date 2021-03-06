module Customization.Themes.Nested

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI
open Fable.Import

let styles (theme : ITheme) : IStyles list = [
    Styles.Root [
        CSSProp.Color theme?status?color
        CSSProp.Custom ("&$checked", [
            CSSProp.Color theme?status?color
        ] |> keyValueList CaseRules.LowerFirst)
    ]
    Styles.Checked []
]

let nestedCheckBox (props : IClassesProps) =
    checkbox [
        HTMLAttr.DefaultChecked true
        MaterialProp.Classes [
            ClassNames.Root !!props.classes?root
            ClassNames.Checked !!props.classes?``checked``
        ]
    ]

let nestedWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] nestedCheckBox

let theme1 = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
                ThemeProp.Custom ("status", [
                    CSSProp.Color Colors.orange.``500``
                ] |> keyValueList CaseRules.LowerFirst)
            ]

let theme2 = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
                ThemeProp.Custom ("status", [
                    CSSProp.Color Colors.green.``500``
                ] |> keyValueList CaseRules.LowerFirst)
            ]

let theme3 (theme : ITheme) =
    let newTheme : ITheme = !!JS.Object.assign(createEmpty, theme)
    newTheme?status?color <- Colors.pink.``500``
    newTheme

let view () =
    muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme1) ] [
        ReactElementType.create nestedWithStyles createEmpty []
        muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme2) ] [
            ReactElementType.create nestedWithStyles createEmpty []
        ]
        muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Func theme3) ] [
            ReactElementType.create nestedWithStyles createEmpty []
        ]
    ]
