using System;
using FlutterSDK;
using FlutterSDK.Widgets.Framework;
using System.Net.Http;
using FlutterBinding.UI;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using SkiaSharp;
using FlutterBinding.Engine.Painting;
using static FlutterSDK.Global;
using FlutterBinding.Mapping;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Willpopscope;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Scrollview;
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
namespace FlutterSDK.Material.Popupmenu
{
    public delegate void PopupMenuItemSelected<T>(T value);
    public delegate void PopupMenuCanceled();
    public delegate List<FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>> PopupMenuItemBuilder<T>(FlutterSDK.Widgets.Framework.BuildContext context);
    internal static class PopupmenuDefaultClass
    {
        public static TimeSpan _KMenuDuration = default(TimeSpan);
        public static double _KMenuCloseIntervalEnd = default(double);
        public static double _KMenuHorizontalPadding = default(double);
        public static double _KMenuDividerHeight = default(double);
        public static double _KMenuMaxWidth = default(double);
        public static double _KMenuMinWidth = default(double);
        public static double _KMenuVerticalPadding = default(double);
        public static double _KMenuWidthStep = default(double);
        public static double _KMenuScreenPadding = default(double);
        internal static Future<T> ShowMenu<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Rendering.Stack.RelativeRect position = default(FlutterSDK.Rendering.Stack.RelativeRect), List<FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>> items = default(List<FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>>), T initialValue = default(T), double elevation = default(double), string semanticLabel = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool captureInheritedThemes = true, bool useRootNavigator = false)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A base class for entries in a material design popup menu.
    ///
    /// The popup menu widget uses this interface to interact with the menu items.
    /// To show a popup menu, use the [showMenu] function. To create a button that
    /// shows a popup menu, consider using [PopupMenuButton].
    ///
    /// The type `T` is the type of the value(s) the entry represents. All the
    /// entries in a given menu must represent values with consistent types.
    ///
    /// A [PopupMenuEntry] may represent multiple values, for example a row with
    /// several icons, or a single entry, for example a menu item with an icon (see
    /// [PopupMenuItem]), or no value at all (for example, [PopupMenuDivider]).
    ///
    /// See also:
    ///
    ///  * [PopupMenuItem], a popup menu entry for a single value.
    ///  * [PopupMenuDivider], a popup menu entry that is just a horizontal line.
    ///  * [CheckedPopupMenuItem], a popup menu item with a checkmark.
    ///  * [showMenu], a method to dynamically show a popup menu at a given location.
    ///  * [PopupMenuButton], an [IconButton] that automatically shows a menu when
    ///    it is tapped.
    /// </Summary>
    public interface IPopupMenuEntry<T>
    {
        bool Represents(T value);
        double Height { get; }
    }


    /// <Summary>
    /// A base class for entries in a material design popup menu.
    ///
    /// The popup menu widget uses this interface to interact with the menu items.
    /// To show a popup menu, use the [showMenu] function. To create a button that
    /// shows a popup menu, consider using [PopupMenuButton].
    ///
    /// The type `T` is the type of the value(s) the entry represents. All the
    /// entries in a given menu must represent values with consistent types.
    ///
    /// A [PopupMenuEntry] may represent multiple values, for example a row with
    /// several icons, or a single entry, for example a menu item with an icon (see
    /// [PopupMenuItem]), or no value at all (for example, [PopupMenuDivider]).
    ///
    /// See also:
    ///
    ///  * [PopupMenuItem], a popup menu entry for a single value.
    ///  * [PopupMenuDivider], a popup menu entry that is just a horizontal line.
    ///  * [CheckedPopupMenuItem], a popup menu item with a checkmark.
    ///  * [showMenu], a method to dynamically show a popup menu at a given location.
    ///  * [PopupMenuButton], an [IconButton] that automatically shows a menu when
    ///    it is tapped.
    /// </Summary>
    public class PopupMenuEntry<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public PopupMenuEntry(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Height { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Whether this entry represents a particular value.
        ///
        /// This method is used by [showMenu], when it is called, to align the entry
        /// representing the `initialValue`, if any, to the given `position`, and then
        /// later is called on each entry to determine if it should be highlighted (if
        /// the method returns true, the entry will have its background color set to
        /// the ambient [ThemeData.highlightColor]). If `initialValue` is null, then
        /// this method is not called.
        ///
        /// If the [PopupMenuEntry] represents a single value, this should return true
        /// if the argument matches that value. If it represents multiple values, it
        /// should return true if the argument matches any of them.
        /// </Summary>
        public virtual bool Represents(T value) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A horizontal divider in a material design popup menu.
    ///
    /// This widget adapts the [Divider] for use in popup menus.
    ///
    /// See also:
    ///
    ///  * [PopupMenuItem], for the kinds of items that this widget divides.
    ///  * [showMenu], a method to dynamically show a popup menu at a given location.
    ///  * [PopupMenuButton], an [IconButton] that automatically shows a menu when
    ///    it is tapped.
    /// </Summary>
    public class PopupMenuDivider : FlutterSDK.Material.Popupmenu.PopupMenuEntry<Null>
    {
        #region constructors
        public PopupMenuDivider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double height = default(double))
        : base(key: key)
        {
            this.Height = height; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new double Height { get; set; }
        #endregion

        #region methods

        public new bool Represents(void value) { throw new NotImplementedException(); }


        public new FlutterSDK.Material.Popupmenu._PopupMenuDividerState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _PopupMenuDividerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Popupmenu.PopupMenuDivider>
    {
        #region constructors
        public _PopupMenuDividerState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _MenuItem : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _MenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Basictypes.ValueChanged<Size> onLayout = default(FlutterSDK.Foundation.Basictypes.ValueChanged<Size>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OnLayout = onLayout; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<Size> OnLayout { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Popupmenu._RenderMenuItem renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderMenuItem : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        #region constructors
        public _RenderMenuItem(FlutterSDK.Foundation.Basictypes.ValueChanged<Size> onLayout, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            this.OnLayout = onLayout; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<Size> OnLayout { get; set; }
        #endregion

        #region methods

        public new void PerformLayout() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An item in a material design popup menu.
    ///
    /// To show a popup menu, use the [showMenu] function. To create a button that
    /// shows a popup menu, consider using [PopupMenuButton].
    ///
    /// To show a checkmark next to a popup menu item, consider using
    /// [CheckedPopupMenuItem].
    ///
    /// Typically the [child] of a [PopupMenuItem] is a [Text] widget. More
    /// elaborate menus with icons can use a [ListTile]. By default, a
    /// [PopupMenuItem] is kMinInteractiveDimension pixels high. If you use a widget
    /// with a different height, it must be specified in the [height] property.
    ///
    /// {@tool snippet}
    ///
    /// Here, a [Text] widget is used with a popup menu item. The `WhyFarther` type
    /// is an enum, not shown here.
    ///
    /// ```dart
    /// const PopupMenuItem<WhyFarther>(
    ///   value: WhyFarther.harder,
    ///   child: Text('Working a lot harder'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See the example at [PopupMenuButton] for how this example could be used in a
    /// complete menu, and see the example at [CheckedPopupMenuItem] for one way to
    /// keep the text of [PopupMenuItem]s that use [Text] widgets in their [child]
    /// slot aligned with the text of [CheckedPopupMenuItem]s or of [PopupMenuItem]
    /// that use a [ListTile] in their [child] slot.
    ///
    /// See also:
    ///
    ///  * [PopupMenuDivider], which can be used to divide items from each other.
    ///  * [CheckedPopupMenuItem], a variant of [PopupMenuItem] with a checkmark.
    ///  * [showMenu], a method to dynamically show a popup menu at a given location.
    ///  * [PopupMenuButton], an [IconButton] that automatically shows a menu when
    ///    it is tapped.
    /// </Summary>
    public class PopupMenuItem<T> : FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>
    {
        #region constructors
        public PopupMenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T value = default(T), bool enabled = true, double height = default(double), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Value = value;
            this.Enabled = enabled;
            this.Height = height;
            this.TextStyle = textStyle;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual T Value { get; set; }
        public virtual bool Enabled { get; set; }
        public new double Height { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new bool Represents(T value) { throw new NotImplementedException(); }


        public new PopupMenuItemState<T, FlutterSDK.Material.Popupmenu.PopupMenuItem<T>> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// The [State] for [PopupMenuItem] subclasses.
    ///
    /// By default this implements the basic styling and layout of Material Design
    /// popup menu items.
    ///
    /// The [buildChild] method can be overridden to adjust exactly what gets placed
    /// in the menu. By default it returns [PopupMenuItem.child].
    ///
    /// The [handleTap] method can be overridden to adjust exactly what happens when
    /// the item is tapped. By default, it uses [Navigator.pop] to return the
    /// [PopupMenuItem.value] from the menu route.
    ///
    /// This class takes two type arguments. The second, `W`, is the exact type of
    /// the [Widget] that is using this [State]. It must be a subclass of
    /// [PopupMenuItem]. The first, `T`, must match the type argument of that widget
    /// class, and is the type of values returned from this menu.
    /// </Summary>
    public class PopupMenuItemState<T, W> : FlutterSDK.Widgets.Framework.State<W>
    {
        #region constructors
        public PopupMenuItemState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// The menu item contents.
        ///
        /// Used by the [build] method.
        ///
        /// By default, this returns [PopupMenuItem.child]. Override this to put
        /// something else in the menu entry.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildChild() { throw new NotImplementedException(); }


        /// <Summary>
        /// The handler for when the user selects the menu item.
        ///
        /// Used by the [InkWell] inserted by the [build] method.
        ///
        /// By default, uses [Navigator.pop] to return the [PopupMenuItem.value] from
        /// the menu route.
        /// </Summary>
        public virtual void HandleTap() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An item with a checkmark in a material design popup menu.
    ///
    /// To show a popup menu, use the [showMenu] function. To create a button that
    /// shows a popup menu, consider using [PopupMenuButton].
    ///
    /// A [CheckedPopupMenuItem] is kMinInteractiveDimension pixels high, which
    /// matches the default minimum height of a [PopupMenuItem]. The horizontal
    /// layout uses [ListTile]; the checkmark is an [Icons.done] icon, shown in the
    /// [ListTile.leading] position.
    ///
    /// {@tool snippet}
    ///
    /// Suppose a `Commands` enum exists that lists the possible commands from a
    /// particular popup menu, including `Commands.heroAndScholar` and
    /// `Commands.hurricaneCame`, and further suppose that there is a
    /// `_heroAndScholar` member field which is a boolean. The example below shows a
    /// menu with one menu item with a checkmark that can toggle the boolean, and
    /// one menu item without a checkmark for selecting the second option. (It also
    /// shows a divider placed between the two menu items.)
    ///
    /// ```dart
    /// PopupMenuButton<Commands>(
    ///   onSelected: (Commands result) {
    ///     switch (result) {
    ///       case Commands.heroAndScholar:
    ///         setState(() { _heroAndScholar = !_heroAndScholar; });
    ///         break;
    ///       case Commands.hurricaneCame:
    ///         // ...handle hurricane option
    ///         break;
    ///       // ...other items handled here
    ///     }
    ///   },
    ///   itemBuilder: (BuildContext context) => <PopupMenuEntry<Commands>>[
    ///     CheckedPopupMenuItem<Commands>(
    ///       checked: _heroAndScholar,
    ///       value: Commands.heroAndScholar,
    ///       child: const Text('Hero and scholar'),
    ///     ),
    ///     const PopupMenuDivider(),
    ///     const PopupMenuItem<Commands>(
    ///       value: Commands.hurricaneCame,
    ///       child: ListTile(leading: Icon(null), title: Text('Bring hurricane')),
    ///     ),
    ///     // ...other items listed here
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// In particular, observe how the second menu item uses a [ListTile] with a
    /// blank [Icon] in the [ListTile.leading] position to get the same alignment as
    /// the item with the checkmark.
    ///
    /// See also:
    ///
    ///  * [PopupMenuItem], a popup menu entry for picking a command (as opposed to
    ///    toggling a value).
    ///  * [PopupMenuDivider], a popup menu entry that is just a horizontal line.
    ///  * [showMenu], a method to dynamically show a popup menu at a given location.
    ///  * [PopupMenuButton], an [IconButton] that automatically shows a menu when
    ///    it is tapped.
    /// </Summary>
    public class CheckedPopupMenuItem<T> : FlutterSDK.Material.Popupmenu.PopupMenuItem<T>
    {
        #region constructors
        public CheckedPopupMenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T value = default(T), bool @checked = false, bool enabled = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, value: value, enabled: enabled, child: child)
        {
            this.@checked = @checked; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool @checked { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new _CheckedPopupMenuItemState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _CheckedPopupMenuItemState<T> : FlutterSDK.Material.Popupmenu.PopupMenuItemState<T, FlutterSDK.Material.Popupmenu.CheckedPopupMenuItem<T>>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _CheckedPopupMenuItemState()
        { }
        #endregion

        #region fields
        internal virtual TimeSpan _FadeDuration { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Opacity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void HandleTap() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildChild() { throw new NotImplementedException(); }

        #endregion
    }


    public class _PopupMenu<T> : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _PopupMenu(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Popupmenu._PopupMenuRoute<T> route = default(FlutterSDK.Material.Popupmenu._PopupMenuRoute<T>), string semanticLabel = default(string))
        : base(key: key)
        {
            this.Route = route;
            this.SemanticLabel = semanticLabel; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Popupmenu._PopupMenuRoute<T> Route { get; set; }
        public virtual string SemanticLabel { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _PopupMenuRouteLayout : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
    {
        #region constructors
        public _PopupMenuRouteLayout(FlutterSDK.Rendering.Stack.RelativeRect position, List<Size> itemSizes, int selectedItemIndex, TextDirection textDirection)
        {
            this.Position = position;
            this.ItemSizes = itemSizes;
            this.SelectedItemIndex = selectedItemIndex;
            this.TextDirection = textDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Position { get; set; }
        public virtual List<Size> ItemSizes { get; set; }
        public virtual int SelectedItemIndex { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        public new Offset GetPositionForChild(Size size, Size childSize) { throw new NotImplementedException(); }


        public new bool ShouldRelayout(FlutterSDK.Material.Popupmenu._PopupMenuRouteLayout oldDelegate) { throw new NotImplementedException(); }
        public new bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class _PopupMenuRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
    {
        #region constructors
        public _PopupMenuRoute(FlutterSDK.Rendering.Stack.RelativeRect position = default(FlutterSDK.Rendering.Stack.RelativeRect), List<FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>> items = default(List<FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>>), T initialValue = default(T), double elevation = default(double), FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), string barrierLabel = default(string), string semanticLabel = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.BuildContext showMenuContext = default(FlutterSDK.Widgets.Framework.BuildContext), bool captureInheritedThemes = default(bool))
        : base()
        {
            this.Position = position;
            this.Items = items;
            this.InitialValue = initialValue;
            this.Elevation = elevation;
            this.Theme = theme;
            this.PopupMenuTheme = popupMenuTheme;
            this.BarrierLabel = barrierLabel;
            this.SemanticLabel = semanticLabel;
            this.Shape = shape;
            this.Color = color;
            this.ShowMenuContext = showMenuContext;
            this.CaptureInheritedThemes = captureInheritedThemes; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Position { get; set; }
        public virtual List<FlutterSDK.Material.Popupmenu.PopupMenuEntry<T>> Items { get; set; }
        public virtual List<Size> ItemSizes { get; set; }
        public virtual T InitialValue { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterSDK.Material.Themedata.ThemeData Theme { get; set; }
        public virtual string SemanticLabel { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData PopupMenuTheme { get; set; }
        public virtual FlutterSDK.Widgets.Framework.BuildContext ShowMenuContext { get; set; }
        public virtual bool CaptureInheritedThemes { get; set; }
        public new string BarrierLabel { get; set; }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Animation.Animation.Animation<double> CreateAnimation() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Displays a menu when pressed and calls [onSelected] when the menu is dismissed
    /// because an item was selected. The value passed to [onSelected] is the value of
    /// the selected menu item.
    ///
    /// One of [child] or [icon] may be provided, but not both. If [icon] is provided,
    /// then [PopupMenuButton] behaves like an [IconButton].
    ///
    /// If both are null, then a standard overflow icon is created (depending on the
    /// platform).
    ///
    /// {@tool snippet}
    ///
    /// This example shows a menu with four items, selecting between an enum's
    /// values and setting a `_selection` field based on the selection.
    ///
    /// ```dart
    /// // This is the type used by the popup menu below.
    /// enum WhyFarther { harder, smarter, selfStarter, tradingCharter }
    ///
    /// // This menu button widget updates a _selection field (of type WhyFarther,
    /// // not shown here).
    /// PopupMenuButton<WhyFarther>(
    ///   onSelected: (WhyFarther result) { setState(() { _selection = result; }); },
    ///   itemBuilder: (BuildContext context) => <PopupMenuEntry<WhyFarther>>[
    ///     const PopupMenuItem<WhyFarther>(
    ///       value: WhyFarther.harder,
    ///       child: Text('Working a lot harder'),
    ///     ),
    ///     const PopupMenuItem<WhyFarther>(
    ///       value: WhyFarther.smarter,
    ///       child: Text('Being a lot smarter'),
    ///     ),
    ///     const PopupMenuItem<WhyFarther>(
    ///       value: WhyFarther.selfStarter,
    ///       child: Text('Being a self-starter'),
    ///     ),
    ///     const PopupMenuItem<WhyFarther>(
    ///       value: WhyFarther.tradingCharter,
    ///       child: Text('Placed in charge of trading charter'),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [PopupMenuItem], a popup menu entry for a single value.
    ///  * [PopupMenuDivider], a popup menu entry that is just a horizontal line.
    ///  * [CheckedPopupMenuItem], a popup menu item with a checkmark.
    ///  * [showMenu], a method to dynamically show a popup menu at a given location.
    /// </Summary>
    public class PopupMenuButton<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public PopupMenuButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Popupmenu.PopupMenuItemBuilder<T> itemBuilder = default(FlutterSDK.Material.Popupmenu.PopupMenuItemBuilder<T>), T initialValue = default(T), FlutterSDK.Material.Popupmenu.PopupMenuItemSelected<T> onSelected = default(FlutterSDK.Material.Popupmenu.PopupMenuItemSelected<T>), FlutterSDK.Material.Popupmenu.PopupMenuCanceled onCanceled = default(FlutterSDK.Material.Popupmenu.PopupMenuCanceled), string tooltip = default(string), double elevation = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), bool enabled = true, FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool captureInheritedThemes = true)
        : base(key: key)
        {
            this.ItemBuilder = itemBuilder;
            this.InitialValue = initialValue;
            this.OnSelected = onSelected;
            this.OnCanceled = onCanceled;
            this.Tooltip = tooltip;
            this.Elevation = elevation;
            this.Padding = padding;
            this.Child = child;
            this.Icon = icon;
            this.Offset = offset;
            this.Enabled = enabled;
            this.Shape = shape;
            this.Color = color;
            this.CaptureInheritedThemes = captureInheritedThemes; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Popupmenu.PopupMenuItemBuilder<T> ItemBuilder { get; set; }
        public virtual T InitialValue { get; set; }
        public virtual FlutterSDK.Material.Popupmenu.PopupMenuItemSelected<T> OnSelected { get; set; }
        public virtual FlutterSDK.Material.Popupmenu.PopupMenuCanceled OnCanceled { get; set; }
        public virtual string Tooltip { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual bool CaptureInheritedThemes { get; set; }
        #endregion

        #region methods

        public new PopupMenuButtonState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// The [State] for a [PopupMenuButton].
    ///
    /// See [showButtonMenu] for a way to programmatically open the popup menu
    /// of your button state.
    /// </Summary>
    public class PopupMenuButtonState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Popupmenu.PopupMenuButton<T>>
    {
        #region constructors
        public PopupMenuButtonState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// A method to show a popup menu with the items supplied to
        /// [PopupMenuButton.itemBuilder] at the position of your [PopupMenuButton].
        ///
        /// By default, it is called when the user taps the button and [PopupMenuButton.enabled]
        /// is set to `true`. Moreover, you can open the button by calling the method manually.
        ///
        /// You would access your [PopupMenuButtonState] using a [GlobalKey] and
        /// show the menu of the button with `globalKey.currentState.showButtonMenu`.
        /// </Summary>
        public virtual void ShowButtonMenu() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Icon.Icon _GetIcon(FlutterSDK.Foundation.Platform.TargetPlatform platform) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }

}
