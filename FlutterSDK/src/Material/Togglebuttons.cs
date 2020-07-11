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
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
namespace FlutterSDK.Material.Togglebuttons
{
    internal static class TogglebuttonsDefaultClass
    {
    }

    public class ToggleButtons : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public ToggleButtons(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), List<bool> isSelected = default(List<bool>), Action<int> onPressed = default(Action<int>), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), List<FlutterSDK.Widgets.Focusmanager.FocusNode> focusNodes = default(List<FlutterSDK.Widgets.Focusmanager.FocusNode>), bool renderBorder = true, FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedBorderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledBorderColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double borderWidth = default(double))
        : base(key: key)
        {
            this.Children = children;
            this.IsSelected = isSelected;
            this.OnPressed = onPressed;
            this.TextStyle = textStyle;
            this.Constraints = constraints;
            this.Color = color;
            this.SelectedColor = selectedColor;
            this.DisabledColor = disabledColor;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HighlightColor = highlightColor;
            this.HoverColor = hoverColor;
            this.SplashColor = splashColor;
            this.FocusNodes = focusNodes;
            this.RenderBorder = renderBorder;
            this.BorderColor = borderColor;
            this.SelectedBorderColor = selectedBorderColor;
            this.DisabledBorderColor = disabledBorderColor;
            this.BorderRadius = borderRadius;
            this.BorderWidth = borderWidth; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _DefaultBorderWidth { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual List<bool> IsSelected { get; set; }
        public virtual Action<int> OnPressed { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> FocusNodes { get; set; }
        public virtual bool RenderBorder { get; set; }
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }
        public virtual FlutterBinding.UI.Color SelectedBorderColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledBorderColor { get; set; }
        public virtual double BorderWidth { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        #endregion

        #region methods

        private bool _IsFirstIndex(int index, int length, TextDirection textDirection) { throw new NotImplementedException(); }


        private bool _IsLastIndex(int index, int length, TextDirection textDirection) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Borderradius.BorderRadius _GetEdgeBorderRadius(int index, int length, TextDirection textDirection, FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Borderradius.BorderRadius _GetClipBorderRadius(int index, int length, TextDirection textDirection, FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Borders.BorderSide _GetLeadingBorderSide(int index, FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Borders.BorderSide _GetHorizontalBorderSide(int index, FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Borders.BorderSide _GetTrailingBorderSide(int index, FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ToggleButton : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _ToggleButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool selected = false, FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Painting.Borders.BorderSide leadingBorderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide horizontalBorderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide trailingBorderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borderradius.BorderRadius clipRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), bool isFirstButton = default(bool), bool isLastButton = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Selected = selected;
            this.TextStyle = textStyle;
            this.Constraints = constraints;
            this.Color = color;
            this.SelectedColor = selectedColor;
            this.DisabledColor = disabledColor;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HighlightColor = highlightColor;
            this.HoverColor = hoverColor;
            this.SplashColor = splashColor;
            this.FocusNode = focusNode;
            this.OnPressed = onPressed;
            this.LeadingBorderSide = leadingBorderSide;
            this.HorizontalBorderSide = horizontalBorderSide;
            this.TrailingBorderSide = trailingBorderSide;
            this.BorderRadius = borderRadius;
            this.ClipRadius = clipRadius;
            this.IsFirstButton = isFirstButton;
            this.IsLastButton = isLastButton;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Selected { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual VoidCallback OnPressed { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide LeadingBorderSide { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide HorizontalBorderSide { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide TrailingBorderSide { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius ClipRadius { get; set; }
        public virtual bool IsFirstButton { get; set; }
        public virtual bool IsLastButton { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SelectToggleButton : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _SelectToggleButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Borders.BorderSide leadingBorderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide horizontalBorderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borders.BorderSide trailingBorderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), bool isFirstButton = default(bool), bool isLastButton = default(bool))
        : base(key: key, child: child)
        {
            this.LeadingBorderSide = leadingBorderSide;
            this.HorizontalBorderSide = horizontalBorderSide;
            this.TrailingBorderSide = trailingBorderSide;
            this.BorderRadius = borderRadius;
            this.IsFirstButton = isFirstButton;
            this.IsLastButton = isLastButton; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Borders.BorderSide LeadingBorderSide { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide HorizontalBorderSide { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide TrailingBorderSide { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual bool IsFirstButton { get; set; }
        public virtual bool IsLastButton { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Togglebuttons._SelectToggleButtonRenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Togglebuttons._SelectToggleButtonRenderObject renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SelectToggleButtonRenderObject : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        #region constructors
        public _SelectToggleButtonRenderObject(FlutterSDK.Painting.Borders.BorderSide _leadingBorderSide, FlutterSDK.Painting.Borders.BorderSide _horizontalBorderSide, FlutterSDK.Painting.Borders.BorderSide _trailingBorderSide, FlutterSDK.Painting.Borderradius.BorderRadius _borderRadius, bool _isFirstButton, bool _isLastButton, TextDirection _textDirection, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            this._LeadingBorderSide = _leadingBorderSide;
            this._HorizontalBorderSide = _horizontalBorderSide;
            this._TrailingBorderSide = _trailingBorderSide;
            this._BorderRadius = _borderRadius;
            this._IsFirstButton = _isFirstButton;
            this._IsLastButton = _isLastButton;
            this._TextDirection = _textDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Borders.BorderSide _LeadingBorderSide { get; set; }
        internal virtual FlutterSDK.Painting.Borders.BorderSide _HorizontalBorderSide { get; set; }
        internal virtual FlutterSDK.Painting.Borders.BorderSide _TrailingBorderSide { get; set; }
        internal virtual FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius { get; set; }
        internal virtual bool _IsFirstButton { get; set; }
        internal virtual bool _IsLastButton { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Borders.BorderSide LeadingBorderSide { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Borders.BorderSide HorizontalBorderSide { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Borders.BorderSide TrailingBorderSide { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFirstButton { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsLastButton { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private double _MaxHeight(FlutterSDK.Rendering.Box.RenderBox box, double width) { throw new NotImplementedException(); }


        private double _MinWidth(FlutterSDK.Rendering.Box.RenderBox box, double height) { throw new NotImplementedException(); }


        private double _MaxWidth(FlutterSDK.Rendering.Box.RenderBox box, double height) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }

        #endregion
    }

}
