﻿using SmartmanApps;
using Amporis.Xamarin.Forms.ColorPicker;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace SmartmanApps {public class ColourSettingsPage :ContentPage {
#region variables
public ColorPickerEntry AccentColourEntry,BgColourEntry,EntryBgColourEntry,EntryTextColourEntry,FgColourEntry,WarnColourEntry;
public FontAttributes FontProperty=FontAttributes.Bold;
public Grid ColourSettingsGrid;
public Label AccentLabel,BgLabel,EntryBgLabel,EntryTextLabel,FgLabel,WarnLabel;
#endregion
#region constructor
public ColourSettingsPage(IColours Colours)
{
Padding=new Thickness(30,20,30,0);
Title="ColourSettings Page";
#region views
#region ColourEntries
#region AccentColourEntry
AccentColourEntry=new ColorPickerEntry{
    EditAlfa=false,
    BackgroundColor=Color.White,
    Color=Colours.Accent,
    };
//AccentColourEntry.SetBinding(ColorPickerEntry.TextColorProperty,new Binding(nameof(EntryTextColourEntry.Color),source:EntryTextColourEntry));
//AccentColourEntry.SetBinding(ColorPickerEntry.BackgroundColorProperty,new Binding(nameof(EntryBgColourEntry.Color),source:EntryBgColourEntry));
#endregion
#region BgColourEntry
BgColourEntry=new ColorPickerEntry{
    EditAlfa=false,
    BackgroundColor=Color.White,
    Color=Colours.Background,
    };
#endregion
#region EntryBgColourEntry
EntryBgColourEntry=new ColorPickerEntry{
    EditAlfa=false,
    BackgroundColor=Color.White,
    Color=Colours.EntryBackground,
    };
#endregion
#region EntryTextColourEntry
EntryTextColourEntry=new ColorPickerEntry{
    EditAlfa=false,
    BackgroundColor=Color.White,
    Color=Colours.EntryText,
    };
#endregion
#region FgColourEntry
FgColourEntry=new ColorPickerEntry{
    EditAlfa=false,
    BackgroundColor=Color.White,
    Color=Colours.Foreground,
    };
#endregion
#region WarnColourEntry
WarnColourEntry=new ColorPickerEntry{
    EditAlfa=false,
    BackgroundColor=Color.White,
    Color=Colours.Warning,
    };
#endregion
#endregion
#region labels
#region AccentLabel
AccentLabel=new Label{
    Text="Accent colour",
    FontAttributes=FontProperty,
    };
AccentLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(FgColourEntry.Color),source:FgColourEntry));
AccentLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(AccentColourEntry.Color),source:AccentColourEntry));
#endregion
#region BgLabel
BgLabel=new Label{
    Text="Background colour",
    FontAttributes=FontProperty,
    };
BgLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(FgColourEntry.Color),source:FgColourEntry));
BgLabel.SetBinding(Label.BackgroundProperty,new Binding(nameof(BgColourEntry.Color),source:BgColourEntry));
#endregion
#region EntryBgLabel
EntryBgLabel=new Label{
    Text="Entry background colour",
    FontAttributes=FontProperty,
    };
EntryBgLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(EntryTextColourEntry.Color),source:EntryTextColourEntry));
EntryBgLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(EntryBgColourEntry.Color),source:EntryBgColourEntry));
#endregion
#region EntryTextLabel
EntryTextLabel=new Label{
    Text="Entry text colour",
    FontAttributes=FontProperty,
    };
EntryTextLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(EntryTextColourEntry.Color),source:EntryTextColourEntry));
EntryTextLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(EntryBgColourEntry.Color),source:EntryBgColourEntry));
#endregion
#region FgLabel
FgLabel=new Label{
    Text="Foreground (text) colour",
    FontAttributes=FontProperty,
    };
FgLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(FgColourEntry.Color),source:FgColourEntry));
FgLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(BgColourEntry.Color),source:BgColourEntry));
#endregion
#region WarnLabel
WarnLabel=new Label{
    Text="Warning colour",
    FontAttributes=FontProperty,
    };
WarnLabel.SetBinding(Label.TextColorProperty,new Binding(nameof(WarnColourEntry.Color),source:WarnColourEntry));
WarnLabel.SetBinding(Label.BackgroundColorProperty,new Binding(nameof(BgColourEntry.Color),source:BgColourEntry));
#endregion
#endregion
#endregion
#region assemble GUI
this.SetBinding(BackgroundColorProperty,new Binding(nameof(BgColourEntry.Color),source:BgColourEntry));
ColourSettingsGrid=new Grid();
ColourSettingsGrid.ColumnDefinitions.Add(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
ColourSettingsGrid.ColumnDefinitions.Add(new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.RowDefinitions.Add(new RowDefinition{Height=GridLength.Auto});
ColourSettingsGrid.Children.Add(BgLabel,0,0);
ColourSettingsGrid.Children.Add(BgColourEntry,1,0);
ColourSettingsGrid.Children.Add(FgLabel,0,1);
ColourSettingsGrid.Children.Add(FgColourEntry,1,1);
ColourSettingsGrid.Children.Add(AccentLabel,0,2);
ColourSettingsGrid.Children.Add(AccentColourEntry,1,2);
ColourSettingsGrid.Children.Add(WarnLabel,0,3);
ColourSettingsGrid.Children.Add(WarnColourEntry,1,3);
ColourSettingsGrid.Children.Add(EntryTextLabel,0,4);
ColourSettingsGrid.Children.Add(EntryTextColourEntry,1,4);
ColourSettingsGrid.Children.Add(EntryBgLabel,0,5);
ColourSettingsGrid.Children.Add(EntryBgColourEntry,1,5);
#endregion
}
#region methods
#region RemoveWarningColourEntry
public void RemoveWarningColourEntry()
{
ColourSettingsGrid.Children.Remove(WarnLabel);
ColourSettingsGrid.Children.Remove(WarnColourEntry);
ColourSettingsGrid.RowDefinitions.RemoveAt(3);
}
#endregion
#endregion
#endregion
}}