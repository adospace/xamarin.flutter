﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Widgets.Mediaquery
{
    internal static class MediaqueryDefaultClass
    {
    }

    /// <Summary>
    /// Information about a piece of media (e.g., a window).
    ///
    /// For example, the [MediaQueryData.size] property contains the width and
    /// height of the current window.
    ///
    /// To obtain the current [MediaQueryData] for a given [BuildContext], use the
    /// [MediaQuery.of] function. For example, to obtain the size of the current
    /// window, use `MediaQuery.of(context).size`.
    ///
    /// If no [MediaQuery] is in scope then the [MediaQuery.of] method will throw an
    /// exception, unless the `nullOk` argument is set to true, in which case it
    /// returns null.
    ///
    /// ## Insets and Padding
    ///
    /// ![A diagram of padding, viewInsets, and viewPadding in correlation with each
    /// other](https://flutter.github.io/assets-for-api-docs/assets/widgets/media_query.png)
    ///
    /// This diagram illustrates how [padding] relates to [viewPadding] and
    /// [viewInsets], shown here in its simplest configuration, as the difference
    /// between the two. In cases when the viewInsets exceed the viewPadding, like
    /// when a software keyboard is shown below, padding goes to zero rather than a
    /// negative value. Therefore, padding is calculated by taking
    /// `max(0.0, viewPadding - viewInsets)`.
    ///
    /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/widgets/window_padding.mp4}
    ///
    /// In this diagram, the black areas represent system UI that the app cannot
    /// draw over. The red area represents view padding that the application may not
    /// be able to detect gestures in and may not want to draw in. The grey area
    /// represents the system keyboard, which can cover over the bottom view padding
    /// when visible.
    ///
    /// MediaQueryData includes three [EdgeInsets] values:
    /// [padding], [viewPadding], and [viewInsets]. These values reflect the
    /// configuration of the device and are used and optionally consumed by widgets
    /// that position content within these insets. The padding value defines areas
    /// that might not be completely visible, like the display "notch" on the iPhone
    /// X. The viewInsets value defines areas that aren't visible at all, typically
    /// because they're obscured by the device's keyboard. Similar to viewInsets,
    /// viewPadding does not differentiate padding in areas that may be obscured.
    /// For example, by using the viewPadding property, padding would defer to the
    /// iPhone "safe area" regardless of whether a keyboard is showing.
    ///
    /// The viewInsets and viewPadding are independent values, they're
    /// measured from the edges of the MediaQuery widget's bounds. Together they
    /// inform the [padding] property. The bounds of the top level MediaQuery
    /// created by [WidgetsApp] are the same as the window that contains the app.
    ///
    /// Widgets whose layouts consume space defined by [viewInsets], [viewPadding],
    /// or [padding] should enclose their children in secondary MediaQuery
    /// widgets that reduce those properties by the same amount.
    /// The [removePadding], [removeViewPadding], and [removeViewInsets] methods are
    /// useful for this.
    ///
    /// See also:
    ///
    ///  * [Scaffold], [SafeArea], [CupertinoTabScaffold], and
    ///    [CupertinoPageScaffold], all of which are informed by [padding],
    ///    [viewPadding], and [viewInsets].
    /// </Summary>
    public class MediaQueryData
    {
        /// <Summary>
        /// Creates data for a media query with explicit values.
        ///
        /// Consider using [MediaQueryData.fromWindow] to create data based on a
        /// [Window].
        /// </Summary>
        public MediaQueryData(Size size = default(Size), double devicePixelRatio = 1.0, double textScaleFactor = 1.0, Brightness platformBrightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets viewInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets systemGestureInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets viewPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), double physicalDepth = default(double), bool alwaysUse24HourFormat = false, bool accessibleNavigation = false, bool invertColors = false, bool highContrast = false, bool disableAnimations = false, bool boldText = false)
        : base()
        {
            this.Size = size;
            this.DevicePixelRatio = devicePixelRatio;
            this.TextScaleFactor = textScaleFactor;
            this.PlatformBrightness = platformBrightness;
            this.Padding = padding;
            this.ViewInsets = viewInsets;
            this.SystemGestureInsets = systemGestureInsets;
            this.ViewPadding = viewPadding;
            this.PhysicalDepth = physicalDepth;
            this.AlwaysUse24HourFormat = alwaysUse24HourFormat;
            this.AccessibleNavigation = accessibleNavigation;
            this.InvertColors = invertColors;
            this.HighContrast = highContrast;
            this.DisableAnimations = disableAnimations;
            this.BoldText = boldText;
        }
        /// <Summary>
        /// Creates data for a media query based on the given window.
        ///
        /// If you use this, you should ensure that you also register for
        /// notifications so that you can update your [MediaQueryData] when the
        /// window's metrics change. For example, see
        /// [WidgetsBindingObserver.didChangeMetrics] or [Window.onMetricsChanged].
        /// </Summary>
        public static MediaQueryData FromWindow(Window window)
        => new MediaQueryData(window);

        private MediaQueryData(Window window)
        : base()
        {

        }
        /// <Summary>
        /// The size of the media in logical pixels (e.g, the size of the screen).
        ///
        /// Logical pixels are roughly the same visual size across devices. Physical
        /// pixels are the size of the actual hardware pixels on the device. The
        /// number of physical pixels per logical pixel is described by the
        /// [devicePixelRatio].
        /// </Summary>
        public virtual Size Size { get; set; }
        /// <Summary>
        /// The number of device pixels for each logical pixel. This number might not
        /// be a power of two. Indeed, it might not even be an integer. For example,
        /// the Nexus 6 has a device pixel ratio of 3.5.
        /// </Summary>
        public virtual double DevicePixelRatio { get; set; }
        /// <Summary>
        /// The number of font pixels for each logical pixel.
        ///
        /// For example, if the text scale factor is 1.5, text will be 50% larger than
        /// the specified font size.
        ///
        /// See also:
        ///
        ///  * [MediaQuery.textScaleFactorOf], a convenience method which returns the
        ///    textScaleFactor defined for a [BuildContext].
        /// </Summary>
        public virtual double TextScaleFactor { get; set; }
        /// <Summary>
        /// The current brightness mode of the host platform.
        ///
        /// For example, starting in Android Pie, battery saver mode asks all apps to
        /// render in a "dark mode".
        ///
        /// Not all platforms necessarily support a concept of brightness mode. Those
        /// platforms will report [Brightness.light] in this property.
        /// </Summary>
        public virtual Brightness PlatformBrightness { get; set; }
        /// <Summary>
        /// The parts of the display that are completely obscured by system UI,
        /// typically by the device's keyboard.
        ///
        /// When a mobile device's keyboard is visible `viewInsets.bottom`
        /// corresponds to the top of the keyboard.
        ///
        /// This value is independent of the [padding] and [viewPadding]. viewPadding
        /// is measured from the edges of the [MediaQuery] widget's bounds. Padding is
        /// calculated based on the viewPadding and viewInsets. The bounds of the top
        /// level MediaQuery created by [WidgetsApp] are the same as the window
        /// (often the mobile device screen) that contains the app.
        ///
        /// See also:
        ///
        ///  * [ui.window], which provides some additional detail about this property
        ///    and how it relates to [padding] and [viewPadding].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ViewInsets { get; set; }
        /// <Summary>
        /// The parts of the display that are partially obscured by system UI,
        /// typically by the hardware display "notches" or the system status bar.
        ///
        /// If you consumed this padding (e.g. by building a widget that envelops or
        /// accounts for this padding in its layout in such a way that children are
        /// no longer exposed to this padding), you should remove this padding
        /// for subsequent descendants in the widget tree by inserting a new
        /// [MediaQuery] widget using the [MediaQuery.removePadding] factory.
        ///
        /// Padding is derived from the values of [viewInsets] and [viewPadding].
        ///
        /// See also:
        ///
        ///  * [ui.window], which provides some additional detail about this
        ///    property and how it relates to [viewInsets] and [viewPadding].
        ///  * [SafeArea], a widget that consumes this padding with a [Padding] widget
        ///    and automatically removes it from the [MediaQuery] for its child.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        /// <Summary>
        /// The parts of the display that are partially obscured by system UI,
        /// typically by the hardware display "notches" or the system status bar.
        ///
        /// This value remains the same regardless of whether the system is reporting
        /// other obstructions in the same physical area of the screen. For example, a
        /// software keyboard on the bottom of the screen that may cover and consume
        /// the same area that requires bottom padding will not affect this value.
        ///
        /// This value is independent of the [padding] and [viewInsets]: their values
        /// are measured from the edges of the [MediaQuery] widget's bounds. The
        /// bounds of the top level MediaQuery created by [WidgetsApp] are the
        /// same as the window that contains the app. On mobile devices, this will
        /// typically be the full screen.
        ///
        /// See also:
        ///
        ///  * [ui.window], which provides some additional detail about this
        ///    property and how it relates to [padding] and [viewInsets].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ViewPadding { get; set; }
        /// <Summary>
        /// The areas along the edges of the display where the system consumes
        /// certain input events and blocks delivery of those events to the app.
        ///
        /// Starting with Android Q, simple swipe gestures that start within the
        /// [systemGestureInsets] areas are used by the system for page navigation
        /// and may not be delivered to the app. Taps and swipe gestures that begin
        /// with a long-press are delivered to the app, but simple press-drag-release
        /// swipe gestures which begin within the area defined by [systemGestureInsets]
        /// may not be.
        ///
        /// Apps should avoid locating gesture detectors within the system gesture
        /// insets area. Apps should feel free to put visual elements within
        /// this area.
        ///
        /// This property is currently only expected to be set to a non-default value
        /// on Android starting with version Q.
        ///
        /// {@tool dartpad --template=stateful_widget_material}
        ///
        /// For apps that might be deployed on Android Q devices with full gesture
        /// navigation enabled, use [MediaQuery.systemGestureInsets] with [Padding]
        /// to avoid having the left and right edges of the [Slider] from appearing
        /// within the area reserved for system gesture navigation.
        ///
        /// By default, [Slider]s expand to fill the available width. So, we pad the
        /// left and right sides.
        ///
        /// ```dart
        /// double _currentValue = 0.2;
        ///
        /// @override
        /// Widget build(BuildContext context) {
        ///   EdgeInsets systemGestureInsets = MediaQuery.of(context).systemGestureInsets;
        ///   return Scaffold(
        ///     appBar: AppBar(title: Text('Pad Slider to avoid systemGestureInsets')),
        ///     body: Padding(
        ///       padding: EdgeInsets.only( // only left and right padding are needed here
        ///         left: systemGestureInsets.left,
        ///         right: systemGestureInsets.right,
        ///       ),
        ///       child: Slider(
        ///         value: _currentValue.toDouble(),
        ///         onChanged: (double newValue) {
        ///           setState(() {
        ///             _currentValue = newValue;
        ///           });
        ///         },
        ///       ),
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets SystemGestureInsets { get; set; }
        /// <Summary>
        /// The physical depth is the maximum elevation that the Window allows.
        ///
        /// Physical layers drawn at or above this elevation will have their elevation
        /// clamped to this value. This can happen if the physical layer itself has
        /// an elevation larger than the available depth, or if some ancestor of the
        /// layer causes it to have a cumulative elevation that is larger than the
        /// available depth.
        ///
        /// The default value is [double.maxFinite], which is used for platforms that
        /// do not specify a maximum elevation. This property is currently only
        /// expected to be set to a non-default value on Fuchsia.
        /// </Summary>
        public virtual double PhysicalDepth { get; set; }
        /// <Summary>
        /// Whether to use 24-hour format when formatting time.
        ///
        /// The behavior of this flag is different across platforms:
        ///
        /// - On Android this flag is reported directly from the user settings called
        ///   "Use 24-hour format". It applies to any locale used by the application,
        ///   whether it is the system-wide locale, or the custom locale set by the
        ///   application.
        /// - On iOS this flag is set to true when the user setting called "24-Hour
        ///   Time" is set or the system-wide locale's default uses 24-hour
        ///   formatting.
        /// </Summary>
        public virtual bool AlwaysUse24HourFormat { get; set; }
        /// <Summary>
        /// Whether the user is using an accessibility service like TalkBack or
        /// VoiceOver to interact with the application.
        ///
        /// When this setting is true, features such as timeouts should be disabled or
        /// have minimum durations increased.
        ///
        /// See also:
        ///
        ///  * [Window.AccessibilityFeatures], where the setting originates.
        /// </Summary>
        public virtual bool AccessibleNavigation { get; set; }
        /// <Summary>
        /// Whether the device is inverting the colors of the platform.
        ///
        /// This flag is currently only updated on iOS devices.
        ///
        /// See also:
        ///
        ///  * [Window.AccessibilityFeatures], where the setting originates.
        /// </Summary>
        public virtual bool InvertColors { get; set; }
        /// <Summary>
        /// Whether the user requested a high contrast between foreground and background
        /// content on iOS, via Settings -> Accessibility -> Increase Contrast.
        ///
        /// This flag is currently only updated on iOS devices that are running iOS 13
        /// or above.
        /// </Summary>
        public virtual bool HighContrast { get; set; }
        /// <Summary>
        /// Whether the platform is requesting that animations be disabled or reduced
        /// as much as possible.
        ///
        /// See also:
        ///
        ///  * [Window.AccessibilityFeatures], where the setting originates.
        /// </Summary>
        public virtual bool DisableAnimations { get; set; }
        /// <Summary>
        /// Whether the platform is requesting that text be drawn with a bold font
        /// weight.
        ///
        /// See also:
        ///
        ///  * [Window.AccessibilityFeatures], where the setting originates.
        /// </Summary>
        public virtual bool BoldText { get; set; }
        public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this media query data but with the given fields replaced
        /// with the new values.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData CopyWith(Size size = default(Size), double devicePixelRatio = default(double), double textScaleFactor = default(double), Brightness platformBrightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets viewPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets viewInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Painting.Edgeinsets.EdgeInsets systemGestureInsets = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), double physicalDepth = default(double), bool alwaysUse24HourFormat = default(bool), bool highContrast = default(bool), bool disableAnimations = default(bool), bool invertColors = default(bool), bool accessibleNavigation = default(bool), bool boldText = default(bool))
        {
            return new MediaQueryData(size: size ?? this.Size, devicePixelRatio: devicePixelRatio == default(double) ? this.devicePixelRatio : devicePixelRatio, textScaleFactor: textScaleFactor == default(double) ? this.textScaleFactor : textScaleFactor, platformBrightness: platformBrightness ?? this.PlatformBrightness, padding: padding ?? this.Padding, viewPadding: viewPadding ?? this.ViewPadding, viewInsets: viewInsets ?? this.ViewInsets, systemGestureInsets: systemGestureInsets ?? this.SystemGestureInsets, physicalDepth: physicalDepth == default(double) ? this.physicalDepth : physicalDepth, alwaysUse24HourFormat: alwaysUse24HourFormat ?? this.AlwaysUse24HourFormat, invertColors: invertColors ?? this.InvertColors, highContrast: highContrast ?? this.HighContrast, disableAnimations: disableAnimations ?? this.DisableAnimations, accessibleNavigation: accessibleNavigation ?? this.AccessibleNavigation, boldText: boldText ?? this.BoldText);
        }




        /// <Summary>
        /// Creates a copy of this media query data but with the given [padding]s
        /// replaced with zero.
        ///
        /// The `removeLeft`, `removeTop`, `removeRight`, and `removeBottom` arguments
        /// must not be null. If all four are false (the default) then this
        /// [MediaQueryData] is returned unmodified.
        ///
        /// See also:
        ///
        ///  * [MediaQuery.removePadding], which uses this method to remove [padding]
        ///    from the ambient [MediaQuery].
        ///  * [SafeArea], which both removes the padding from the [MediaQuery] and
        ///    adds a [Padding] widget.
        ///  * [removeViewInsets], the same thing but for [viewInsets].
        ///  * [removeViewPadding], the same thing but for [viewPadding].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData RemovePadding(bool removeLeft = false, bool removeTop = false, bool removeRight = false, bool removeBottom = false)
        {
            if (!(removeLeft || removeTop || removeRight || removeBottom)) return this;
            return new MediaQueryData(size: Size, devicePixelRatio: DevicePixelRatio, textScaleFactor: TextScaleFactor, platformBrightness: PlatformBrightness, padding: Padding.CopyWith(left: removeLeft ? 0.0 : null, top: removeTop ? 0.0 : null, right: removeRight ? 0.0 : null, bottom: removeBottom ? 0.0 : null), viewPadding: ViewPadding.CopyWith(left: removeLeft ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Left - Padding.Left) : null, top: removeTop ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Top - Padding.Top) : null, right: removeRight ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Right - Padding.Right) : null, bottom: removeBottom ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Bottom - Padding.Bottom) : null), viewInsets: ViewInsets, alwaysUse24HourFormat: AlwaysUse24HourFormat, highContrast: HighContrast, disableAnimations: DisableAnimations, invertColors: InvertColors, accessibleNavigation: AccessibleNavigation, boldText: BoldText);
        }




        /// <Summary>
        /// Creates a copy of this media query data but with the given [viewInsets]
        /// replaced with zero.
        ///
        /// The `removeLeft`, `removeTop`, `removeRight`, and `removeBottom` arguments
        /// must not be null. If all four are false (the default) then this
        /// [MediaQueryData] is returned unmodified.
        ///
        /// See also:
        ///
        ///  * [MediaQuery.removeViewInsets], which uses this method to remove
        ///    [viewInsets] from the ambient [MediaQuery].
        ///  * [removePadding], the same thing but for [padding].
        ///  * [removeViewPadding], the same thing but for [viewPadding].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData RemoveViewInsets(bool removeLeft = false, bool removeTop = false, bool removeRight = false, bool removeBottom = false)
        {
            if (!(removeLeft || removeTop || removeRight || removeBottom)) return this;
            return new MediaQueryData(size: Size, devicePixelRatio: DevicePixelRatio, textScaleFactor: TextScaleFactor, platformBrightness: PlatformBrightness, padding: Padding, viewPadding: ViewPadding.CopyWith(left: removeLeft ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Left - ViewInsets.Left) : null, top: removeTop ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Top - ViewInsets.Top) : null, right: removeRight ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Right - ViewInsets.Right) : null, bottom: removeBottom ? Dart.Math.MathDefaultClass.Max(0.0, ViewPadding.Bottom - ViewInsets.Bottom) : null), viewInsets: ViewInsets.CopyWith(left: removeLeft ? 0.0 : null, top: removeTop ? 0.0 : null, right: removeRight ? 0.0 : null, bottom: removeBottom ? 0.0 : null), alwaysUse24HourFormat: AlwaysUse24HourFormat, highContrast: HighContrast, disableAnimations: DisableAnimations, invertColors: InvertColors, accessibleNavigation: AccessibleNavigation, boldText: BoldText);
        }




        /// <Summary>
        /// Creates a copy of this media query data but with the given [viewPadding]
        /// replaced with zero.
        ///
        /// The `removeLeft`, `removeTop`, `removeRight`, and `removeBottom` arguments
        /// must not be null. If all four are false (the default) then this
        /// [MediaQueryData] is returned unmodified.
        ///
        /// See also:
        ///
        ///  * [MediaQuery.removeViewPadding], which uses this method to remove
        ///    [viewPadding] from the ambient [MediaQuery].
        ///  * [removePadding], the same thing but for [padding].
        ///  * [removeViewInsets], the same thing but for [viewInsets].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData RemoveViewPadding(bool removeLeft = false, bool removeTop = false, bool removeRight = false, bool removeBottom = false)
        {
            if (!(removeLeft || removeTop || removeRight || removeBottom)) return this;
            return new MediaQueryData(size: Size, devicePixelRatio: DevicePixelRatio, textScaleFactor: TextScaleFactor, platformBrightness: PlatformBrightness, padding: Padding.CopyWith(left: removeLeft ? 0.0 : null, top: removeTop ? 0.0 : null, right: removeRight ? 0.0 : null, bottom: removeBottom ? 0.0 : null), viewInsets: ViewInsets, viewPadding: ViewPadding.CopyWith(left: removeLeft ? 0.0 : null, top: removeTop ? 0.0 : null, right: removeRight ? 0.0 : null, bottom: removeBottom ? 0.0 : null), alwaysUse24HourFormat: AlwaysUse24HourFormat, highContrast: HighContrast, disableAnimations: DisableAnimations, invertColors: InvertColors, accessibleNavigation: AccessibleNavigation, boldText: BoldText);
        }




        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is MediaQueryData && other.Size == Size && other.DevicePixelRatio == DevicePixelRatio && other.TextScaleFactor == TextScaleFactor && other.PlatformBrightness == PlatformBrightness && other.Padding == Padding && other.ViewPadding == ViewPadding && other.ViewInsets == ViewInsets && other.PhysicalDepth == PhysicalDepth && other.AlwaysUse24HourFormat == AlwaysUse24HourFormat && other.HighContrast == HighContrast && other.DisableAnimations == DisableAnimations && other.InvertColors == InvertColors && other.AccessibleNavigation == AccessibleNavigation && other.BoldText == BoldText;
        }




    }


    /// <Summary>
    /// Establishes a subtree in which media queries resolve to the given data.
    ///
    /// For example, to learn the size of the current media (e.g., the window
    /// containing your app), you can read the [MediaQueryData.size] property from
    /// the [MediaQueryData] returned by [MediaQuery.of]:
    /// `MediaQuery.of(context).size`.
    ///
    /// Querying the current media using [MediaQuery.of] will cause your widget to
    /// rebuild automatically whenever the [MediaQueryData] changes (e.g., if the
    /// user rotates their device).
    ///
    /// If no [MediaQuery] is in scope then the [MediaQuery.of] method will throw an
    /// exception, unless the `nullOk` argument is set to true, in which case it
    /// returns null.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=A3WrA4zAaPw}
    ///
    /// See also:
    ///
    ///  * [WidgetsApp] and [MaterialApp], which introduce a [MediaQuery] and keep
    ///    it up to date with the current screen metrics as they change.
    ///  * [MediaQueryData], the data structure that represents the metrics.
    /// </Summary>
    public class MediaQuery : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        /// <Summary>
        /// Creates a widget that provides [MediaQueryData] to its descendants.
        ///
        /// The [data] and [child] arguments must not be null.
        /// </Summary>
        public MediaQuery(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Mediaquery.MediaQueryData data = default(FlutterSDK.Widgets.Mediaquery.MediaQueryData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data;
        }
        /// <Summary>
        /// Creates a new [MediaQuery] that inherits from the ambient [MediaQuery]
        /// from the given context, but removes the specified padding.
        ///
        /// This should be inserted into the widget tree when the [MediaQuery] padding
        /// is consumed by a widget in such a way that the padding is no longer
        /// exposed to the widget's descendants or siblings.
        ///
        /// The [context] argument is required, must not be null, and must have a
        /// [MediaQuery] in scope.
        ///
        /// The `removeLeft`, `removeTop`, `removeRight`, and `removeBottom` arguments
        /// must not be null. If all four are false (the default) then the returned
        /// [MediaQuery] reuses the ambient [MediaQueryData] unmodified, which is not
        /// particularly useful.
        ///
        /// The [child] argument is required and must not be null.
        ///
        /// See also:
        ///
        ///  * [SafeArea], which both removes the padding from the [MediaQuery] and
        ///    adds a [Padding] widget.
        ///  * [MediaQueryData.padding], the affected property of the
        ///    [MediaQueryData].
        ///  * [removeViewInsets], the same thing but for [MediaQueryData.viewInsets].
        ///  * [removeViewPadding], the same thing but for
        ///    [MediaQueryData.viewPadding].
        /// </Summary>
        public static MediaQuery RemovePadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), bool removeLeft = false, bool removeTop = false, bool removeRight = false, bool removeBottom = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {

            return new MediaQuery(key: key, data: MediaqueryDefaultClass.MediaQuery.Of(context).RemovePadding(removeLeft: removeLeft, removeTop: removeTop, removeRight: removeRight, removeBottom: removeBottom), child: child);
        }


        /// <Summary>
        /// Creates a new [MediaQuery] that inherits from the ambient [MediaQuery]
        /// from the given context, but removes the specified view insets.
        ///
        /// This should be inserted into the widget tree when the [MediaQuery] view
        /// insets are consumed by a widget in such a way that the view insets are no
        /// longer exposed to the widget's descendants or siblings.
        ///
        /// The [context] argument is required, must not be null, and must have a
        /// [MediaQuery] in scope.
        ///
        /// The `removeLeft`, `removeTop`, `removeRight`, and `removeBottom` arguments
        /// must not be null. If all four are false (the default) then the returned
        /// [MediaQuery] reuses the ambient [MediaQueryData] unmodified, which is not
        /// particularly useful.
        ///
        /// The [child] argument is required and must not be null.
        ///
        /// See also:
        ///
        ///  * [MediaQueryData.viewInsets], the affected property of the
        ///    [MediaQueryData].
        ///  * [removePadding], the same thing but for [MediaQueryData.padding].
        ///  * [removeViewPadding], the same thing but for
        ///    [MediaQueryData.viewPadding].
        /// </Summary>
        public static MediaQuery RemoveViewInsets(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), bool removeLeft = false, bool removeTop = false, bool removeRight = false, bool removeBottom = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {

            return new MediaQuery(key: key, data: MediaqueryDefaultClass.MediaQuery.Of(context).RemoveViewInsets(removeLeft: removeLeft, removeTop: removeTop, removeRight: removeRight, removeBottom: removeBottom), child: child);
        }


        /// <Summary>
        /// Creates a new [MediaQuery] that inherits from the ambient [MediaQuery]
        /// from the given context, but removes the specified view padding.
        ///
        /// This should be inserted into the widget tree when the [MediaQuery] view
        /// padding is consumed by a widget in such a way that the view padding is no
        /// longer exposed to the widget's descendants or siblings.
        ///
        /// The [context] argument is required, must not be null, and must have a
        /// [MediaQuery] in scope.
        ///
        /// The `removeLeft`, `removeTop`, `removeRight`, and `removeBottom` arguments
        /// must not be null. If all four are false (the default) then the returned
        /// [MediaQuery] reuses the ambient [MediaQueryData] unmodified, which is not
        /// particularly useful.
        ///
        /// The [child] argument is required and must not be null.
        ///
        /// See also:
        ///
        ///  * [MediaQueryData.viewPadding], the affected property of the
        ///    [MediaQueryData].
        ///  * [removePadding], the same thing but for [MediaQueryData.padding].
        ///  * [removeViewInsets], the same thing but for [MediaQueryData.viewInsets].
        /// </Summary>
        public static MediaQuery RemoveViewPadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), bool removeLeft = false, bool removeTop = false, bool removeRight = false, bool removeBottom = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {

            return new MediaQuery(key: key, data: MediaqueryDefaultClass.MediaQuery.Of(context).RemoveViewPadding(removeLeft: removeLeft, removeTop: removeTop, removeRight: removeRight, removeBottom: removeBottom), child: child);
        }


        /// <Summary>
        /// Contains information about the current media.
        ///
        /// For example, the [MediaQueryData.size] property contains the width and
        /// height of the current window.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData Data { get; set; }

        /// <Summary>
        /// The data from the closest instance of this class that encloses the given
        /// context.
        ///
        /// You can use this function to query the size an orientation of the screen.
        /// When that information changes, your widget will be scheduled to be
        /// rebuilt, keeping your widget up-to-date.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// MediaQueryData media = MediaQuery.of(context);
        /// ```
        ///
        /// If there is no [MediaQuery] in scope, then this will throw an exception.
        /// To return null if there is no [MediaQuery], then pass `nullOk: true`.
        ///
        /// If you use this from a widget (e.g. in its build function), consider
        /// calling [debugCheckHasMediaQuery].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {


            MediaQuery query = context.DependOnInheritedWidgetOfExactType();
            if (query != null) return query.Data;
            if (nullOk) return null;
            throw FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary("MediaQuery.of() called with a context that does not contain a MediaQuery."), new ErrorDescription("No MediaQuery ancestor could be found starting from the context that was passed " + "to MediaQuery.of(). This can happen because you do not have a WidgetsApp or " + "MaterialApp widget (those widgets introduce a MediaQuery), or it can happen " + "if the context you use comes from a widget above those widgets."), context.DescribeElement("The context used was") });
        }




        /// <Summary>
        /// Returns textScaleFactor for the nearest MediaQuery ancestor or 1.0, if
        /// no such ancestor exists.
        /// </Summary>
        public virtual double TextScaleFactorOf(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true)?.TextScaleFactor ?? 1.0;
        }




        /// <Summary>
        /// Returns platformBrightness for the nearest MediaQuery ancestor or
        /// [Brightness.light], if no such ancestor exists.
        ///
        /// Use of this method will cause the given [context] to rebuild any time that
        /// any property of the ancestor [MediaQuery] changes.
        /// </Summary>
        public virtual Brightness PlatformBrightnessOf(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true)?.PlatformBrightness ?? Brightness.Light;
        }




        /// <Summary>
        /// Returns the boldText accessibility setting for the nearest MediaQuery
        /// ancestor, or false if no such ancestor exists.
        /// </Summary>
        public virtual bool BoldTextOverride(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true)?.BoldText ?? false;
        }




        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Mediaquery.MediaQuery oldWidget) => Data != oldWidget.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<MediaQueryData>("data", Data, showName: false));
        }



    }


    /// <Summary>
    /// Whether in portrait or landscape.
    /// </Summary>
    public enum Orientation
    {

        /// <Summary>
        /// Taller than wide.
        /// </Summary>
        Portrait,
        /// <Summary>
        /// Wider than tall.
        /// </Summary>
        Landscape,
    }

}
