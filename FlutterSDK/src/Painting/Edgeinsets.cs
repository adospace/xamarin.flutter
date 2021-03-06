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
namespace FlutterSDK.Painting.Edgeinsets
{
    internal static class EdgeinsetsDefaultClass
    {
    }

    /// <Summary>
    /// Base class for [EdgeInsets] that allows for text-direction aware
    /// resolution.
    ///
    /// A property or argument of this type accepts classes created either with [new
    /// EdgeInsets.fromLTRB] and its variants, or [new
    /// EdgeInsetsDirectional.fromSTEB] and its variants.
    ///
    /// To convert an [EdgeInsetsGeometry] object of indeterminate type into a
    /// [EdgeInsets] object, call the [resolve] method.
    ///
    /// See also:
    ///
    ///  * [Padding], a widget that describes margins using [EdgeInsetsGeometry].
    /// </Summary>
    public interface IEdgeInsetsGeometry
    {
        double Along(FlutterSDK.Painting.Basictypes.Axis axis);
        Size InflateSize(Size size);
        Size DeflateSize(Size size);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Clamp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry min, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry max);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Unary();
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry MultiplyOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideIntegerResultOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ModuloOperator(double other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry a, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry b, double t);
        FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction);
        string ToString();
        bool Equals(@Object other);
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Infinity { get; }
        bool IsNonNegative { get; }
        double Horizontal { get; }
        double Vertical { get; }
        Size CollapsedSize { get; }
        FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Flipped { get; }
        int HashCode { get; }
    }


    /// <Summary>
    /// Base class for [EdgeInsets] that allows for text-direction aware
    /// resolution.
    ///
    /// A property or argument of this type accepts classes created either with [new
    /// EdgeInsets.fromLTRB] and its variants, or [new
    /// EdgeInsetsDirectional.fromSTEB] and its variants.
    ///
    /// To convert an [EdgeInsetsGeometry] object of indeterminate type into a
    /// [EdgeInsets] object, call the [resolve] method.
    ///
    /// See also:
    ///
    ///  * [Padding], a widget that describes margins using [EdgeInsetsGeometry].
    /// </Summary>
    public class EdgeInsetsGeometry
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public EdgeInsetsGeometry()
        {

        }
        /// <Summary>
        /// An [EdgeInsetsGeometry] with infinite offsets in each direction.
        ///
        /// Can be used as an infinite upper bound for [clamp].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Infinity { get; set; }
        internal virtual double _Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _End { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNonNegative { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Horizontal { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Vertical { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size CollapsedSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The total offset in the given direction.
        /// </Summary>
        public virtual double Along(FlutterSDK.Painting.Basictypes.Axis axis)
        {

            switch (axis) { case Axis.Horizontal: return Horizontal; case Axis.Vertical: return Vertical; }
            return null;
        }




        /// <Summary>
        /// Returns a new size that is bigger than the given size by the amount of
        /// inset in the horizontal and vertical directions.
        ///
        /// See also:
        ///
        ///  * [EdgeInsets.inflateRect], to inflate a [Rect] rather than a [Size] (for
        ///    [EdgeInsetsDirectional], requires first calling [resolve] to establish
        ///    how the start and end map to the left or right).
        ///  * [deflateSize], to deflate a [Size] rather than inflating it.
        /// </Summary>
        public virtual Size InflateSize(Size size)
        {
            return new Size(size.Width + Horizontal, size.Height + Vertical);
        }




        /// <Summary>
        /// Returns a new size that is smaller than the given size by the amount of
        /// inset in the horizontal and vertical directions.
        ///
        /// If the argument is smaller than [collapsedSize], then the resulting size
        /// will have negative dimensions.
        ///
        /// See also:
        ///
        ///  * [EdgeInsets.deflateRect], to deflate a [Rect] rather than a [Size]. (for
        ///    [EdgeInsetsDirectional], requires first calling [resolve] to establish
        ///    how the start and end map to the left or right).
        ///  * [inflateSize], to inflate a [Size] rather than deflating it.
        /// </Summary>
        public virtual Size DeflateSize(Size size)
        {
            return new Size(size.Width - Horizontal, size.Height - Vertical);
        }




        /// <Summary>
        /// Returns the difference between two [EdgeInsetsGeometry] objects.
        ///
        /// If you know you are applying this to two [EdgeInsets] or two
        /// [EdgeInsetsDirectional] objects, consider using the binary infix `-`
        /// operator instead, which always returns an object of the same type as the
        /// operands, and is typed accordingly.
        ///
        /// If [subtract] is applied to two objects of the same type ([EdgeInsets] or
        /// [EdgeInsetsDirectional]), an object of that type will be returned (though
        /// this is not reflected in the type system). Otherwise, an object
        /// representing a combination of both is returned. That object can be turned
        /// into a concrete [EdgeInsets] using [resolve].
        ///
        /// This method returns the same result as [add] applied to the result of
        /// negating the argument (using the prefix unary `-` operator or multiplying
        /// the argument by -1.0 using the `*` operator).
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other)
        {
            return _MixedEdgeInsets.FromLRSETB(_Left - other._Left, _Right - other._Right, _Start - other._Start, _End - other._End, _Top - other._Top, _Bottom - other._Bottom);
        }




        /// <Summary>
        /// Returns the sum of two [EdgeInsetsGeometry] objects.
        ///
        /// If you know you are adding two [EdgeInsets] or two [EdgeInsetsDirectional]
        /// objects, consider using the `+` operator instead, which always returns an
        /// object of the same type as the operands, and is typed accordingly.
        ///
        /// If [add] is applied to two objects of the same type ([EdgeInsets] or
        /// [EdgeInsetsDirectional]), an object of that type will be returned (though
        /// this is not reflected in the type system). Otherwise, an object
        /// representing a combination of both is returned. That object can be turned
        /// into a concrete [EdgeInsets] using [resolve].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other)
        {
            return _MixedEdgeInsets.FromLRSETB(_Left + other._Left, _Right + other._Right, _Start + other._Start, _End + other._End, _Top + other._Top, _Bottom + other._Bottom);
        }




        /// <Summary>
        /// Returns the a new [EdgeInsetsGeometry] object with all values greater than
        /// or equal to `min`, and less than or equal to `max`.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Clamp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry min, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry max)
        {
            return _MixedEdgeInsets.FromLRSETB(_Left.Clamp(min._Left, max._Left) as double, _Right.Clamp(min._Right, max._Right) as double, _Start.Clamp(min._Start, max._Start) as double, _End.Clamp(min._End, max._End) as double, _Top.Clamp(min._Top, max._Top) as double, _Bottom.Clamp(min._Bottom, max._Bottom) as double);
        }




        /// <Summary>
        /// Returns the [EdgeInsetsGeometry] object with each dimension negated.
        ///
        /// This is the same as multiplying the object by -1.0.
        ///
        /// This operator returns an object of the same type as the operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Unary()
        {
            return default(EdgeInsetsGeometry);
        }


        /// <Summary>
        /// Scales the [EdgeInsetsGeometry] object in each dimension by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry MultiplyOperator(double other)
        {
            return default(EdgeInsetsGeometry);
        }


        /// <Summary>
        /// Divides the [EdgeInsetsGeometry] object in each dimension by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideOperator(double other)
        {
            return default(EdgeInsetsGeometry);
        }


        /// <Summary>
        /// Integer divides the [EdgeInsetsGeometry] object in each dimension by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        ///
        /// This operator may have unexpected results when applied to a mixture of
        /// [EdgeInsets] and [EdgeInsetsDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry DivideIntegerResultOperator(double other)
        {
            return default(EdgeInsetsGeometry);
        }


        /// <Summary>
        /// Computes the remainder in each dimension by the given factor.
        ///
        /// This operator returns an object of the same type as the operand.
        ///
        /// This operator may have unexpected results when applied to a mixture of
        /// [EdgeInsets] and [EdgeInsetsDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ModuloOperator(double other)
        {
            return default(EdgeInsetsGeometry);
        }


        /// <Summary>
        /// Linearly interpolate between two [EdgeInsetsGeometry] objects.
        ///
        /// If either is null, this function interpolates from [EdgeInsets.zero], and
        /// the result is an object of the same type as the non-null argument.
        ///
        /// If [lerp] is applied to two objects of the same type ([EdgeInsets] or
        /// [EdgeInsetsDirectional]), an object of that type will be returned (though
        /// this is not reflected in the type system). Otherwise, an object
        /// representing a combination of both is returned. That object can be turned
        /// into a concrete [EdgeInsets] using [resolve].
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry a, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b * t;
            if (b == null) return a * (1.0 - t);
            if (a is EdgeInsets && b is EdgeInsets) return EdgeinsetsDefaultClass.EdgeInsets.Lerp(a, b, t);
            if (a is EdgeInsetsDirectional && b is EdgeInsetsDirectional) return EdgeinsetsDefaultClass.EdgeInsetsDirectional.Lerp(a, b, t);
            return _MixedEdgeInsets.FromLRSETB(Dart.UI.UiDefaultClass.LerpDouble(a._Left, b._Left, t), Dart.UI.UiDefaultClass.LerpDouble(a._Right, b._Right, t), Dart.UI.UiDefaultClass.LerpDouble(a._Start, b._Start, t), Dart.UI.UiDefaultClass.LerpDouble(a._End, b._End, t), Dart.UI.UiDefaultClass.LerpDouble(a._Top, b._Top, t), Dart.UI.UiDefaultClass.LerpDouble(a._Bottom, b._Bottom, t));
        }




        /// <Summary>
        /// Convert this instance into an [EdgeInsets], which uses literal coordinates
        /// (i.e. the `left` coordinate being explicitly a distance from the left, and
        /// the `right` coordinate being explicitly a distance from the right).
        ///
        /// See also:
        ///
        ///  * [EdgeInsets], for which this is a no-op (returns itself).
        ///  * [EdgeInsetsDirectional], which flips the horizontal direction
        ///    based on the `direction` argument.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction)
        {
            return default(EdgeInsets);
        }



        public new bool Equals(@Object other)
        {
            return other is EdgeInsetsGeometry && other._Left == _Left && other._Right == _Right && other._Start == _Start && other._End == _End && other._Top == _Top && other._Bottom == _Bottom;
        }



    }


    /// <Summary>
    /// An immutable set of offsets in each of the four cardinal directions.
    ///
    /// Typically used for an offset from each of the four sides of a box. For
    /// example, the padding inside a box can be represented using this class.
    ///
    /// The [EdgeInsets] class specifies offsets in terms of visual edges, left,
    /// top, right, and bottom. These values are not affected by the
    /// [TextDirection]. To support both left-to-right and right-to-left layouts,
    /// consider using [EdgeInsetsDirectional], which is expressed in terms of
    /// _start_, top, _end_, and bottom, where start and end are resolved in terms
    /// of a [TextDirection] (typically obtained from the ambient [Directionality]).
    ///
    /// {@tool snippet}
    ///
    /// Here are some examples of how to create [EdgeInsets] instances:
    ///
    /// Typical eight-pixel margin on all sides:
    ///
    /// ```dart
    /// const EdgeInsets.all(8.0)
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// Eight pixel margin above and below, no horizontal margins:
    ///
    /// ```dart
    /// const EdgeInsets.symmetric(vertical: 8.0)
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// Left margin indent of 40 pixels:
    ///
    /// ```dart
    /// const EdgeInsets.only(left: 40.0)
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Padding], a widget that accepts [EdgeInsets] to describe its margins.
    ///  * [EdgeInsetsDirectional], which (for properties and arguments that accept
    ///    the type [EdgeInsetsGeometry]) allows the horizontal insets to be
    ///    specified in a [TextDirection]-aware manner.
    /// </Summary>
    public class EdgeInsets : FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry
    {
        /// <Summary>
        /// Creates insets from offsets from the left, top, right, and bottom.
        /// </Summary>
        public static EdgeInsets FromLTRB(double left, double top, double right, double bottom)
        => new EdgeInsets(left, top, right, bottom);

        private EdgeInsets(double left, double top, double right, double bottom)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }
        /// <Summary>
        /// Creates insets where all the offsets are `value`.
        ///
        /// {@tool snippet}
        ///
        /// Typical eight-pixel margin on all sides:
        ///
        /// ```dart
        /// const EdgeInsets.all(8.0)
        /// ```
        /// {@end-tool}
        /// </Summary>
        public static EdgeInsets All(double value)
        => new EdgeInsets(value);

        private EdgeInsets(double value)
        : base()
        {

        }
        /// <Summary>
        /// Creates insets with only the given values non-zero.
        ///
        /// {@tool snippet}
        ///
        /// Left margin indent of 40 pixels:
        ///
        /// ```dart
        /// const EdgeInsets.only(left: 40.0)
        /// ```
        /// {@end-tool}
        /// </Summary>
        public static EdgeInsets Only(double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0)
        => new EdgeInsets(left, top, right, bottom, null);

        private EdgeInsets(double left, double top, double right, double bottom, object ___dummy_param___1)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }
        /// <Summary>
        /// Creates insets with symmetrical vertical and horizontal offsets.
        ///
        /// {@tool snippet}
        ///
        /// Eight pixel margin above and below, no horizontal margins:
        ///
        /// ```dart
        /// const EdgeInsets.symmetric(vertical: 8.0)
        /// ```
        /// {@end-tool}
        /// </Summary>
        public static EdgeInsets Symmetric(double vertical = 0.0, double horizontal = 0.0)
        => new EdgeInsets(vertical, horizontal);

        private EdgeInsets(double vertical, double horizontal)
        : base()
        {

        }
        /// <Summary>
        /// Creates insets that match the given window padding.
        ///
        /// If you need the current system padding or view insets in the context of a
        /// widget, consider using [MediaQuery.of] to obtain these values rather than
        /// using the value from [dart:ui.window], so that you get notified of
        /// changes.
        /// </Summary>
        public static EdgeInsets FromWindowPadding(WindowPadding padding, double devicePixelRatio)
        => new EdgeInsets(padding, devicePixelRatio);

        private EdgeInsets(WindowPadding padding, double devicePixelRatio)
        : base()
        {

        }
        /// <Summary>
        /// An [EdgeInsets] with zero offsets in each direction.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Zero { get; set; }
        /// <Summary>
        /// The offset from the left.
        /// </Summary>
        public virtual double Left { get; set; }
        /// <Summary>
        /// The offset from the top.
        /// </Summary>
        public virtual double Top { get; set; }
        /// <Summary>
        /// The offset from the right.
        /// </Summary>
        public virtual double Right { get; set; }
        /// <Summary>
        /// The offset from the bottom.
        /// </Summary>
        public virtual double Bottom { get; set; }
        internal virtual double _Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _End { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset TopLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset TopRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset BottomLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset BottomRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns a new rect that is bigger than the given rect in each direction by
        /// the amount of inset in each direction. Specifically, the left edge of the
        /// rect is moved left by [left], the top edge of the rect is moved up by
        /// [top], the right edge of the rect is moved right by [right], and the
        /// bottom edge of the rect is moved down by [bottom].
        ///
        /// See also:
        ///
        ///  * [inflateSize], to inflate a [Size] rather than a [Rect].
        ///  * [deflateRect], to deflate a [Rect] rather than inflating it.
        /// </Summary>
        public virtual Rect InflateRect(FlutterBinding.UI.Rect rect)
        {
            return Rect.FromLTRB(rect.Left - Left, rect.Top - Top, rect.Right + Right, rect.Bottom + Bottom);
        }




        /// <Summary>
        /// Returns a new rect that is smaller than the given rect in each direction by
        /// the amount of inset in each direction. Specifically, the left edge of the
        /// rect is moved right by [left], the top edge of the rect is moved down by
        /// [top], the right edge of the rect is moved left by [right], and the
        /// bottom edge of the rect is moved up by [bottom].
        ///
        /// If the argument's [Rect.size] is smaller than [collapsedSize], then the
        /// resulting rectangle will have negative dimensions.
        ///
        /// See also:
        ///
        ///  * [deflateSize], to deflate a [Size] rather than a [Rect].
        ///  * [inflateRect], to inflate a [Rect] rather than deflating it.
        /// </Summary>
        public virtual Rect DeflateRect(FlutterBinding.UI.Rect rect)
        {
            return Rect.FromLTRB(rect.Left + Left, rect.Top + Top, rect.Right - Right, rect.Bottom - Bottom);
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other)
        {
            if (other is EdgeInsets) return this - other;
            return base.Subtract(other);
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other)
        {
            if (other is EdgeInsets) return this + other;
            return base.Add(other);
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Clamp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry min, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry max)
        {
            return EdgeInsets.FromLTRB(_Left.Clamp(min._Left, max._Left) as double, _Top.Clamp(min._Top, max._Top) as double, _Right.Clamp(min._Right, max._Right) as double, _Bottom.Clamp(min._Bottom, max._Bottom) as double);
        }




        /// <Summary>
        /// Returns the difference between two [EdgeInsets].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Unary(FlutterSDK.Painting.Edgeinsets.EdgeInsets other)
        {
            return EdgeInsets.FromLTRB(Left - other.Left, Top - other.Top, Right - other.Right, Bottom - other.Bottom);
        }




        /// <Summary>
        /// Returns the sum of two [EdgeInsets].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets AddOperator(FlutterSDK.Painting.Edgeinsets.EdgeInsets other)
        {
            return EdgeInsets.FromLTRB(Left + other.Left, Top + other.Top, Right + other.Right, Bottom + other.Bottom);
        }




        /// <Summary>
        /// Returns the [EdgeInsets] object with each dimension negated.
        ///
        /// This is the same as multiplying the object by -1.0.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Unary()
        {
            return EdgeInsets.FromLTRB(-Left, -Top, -Right, -Bottom);
        }




        /// <Summary>
        /// Scales the [EdgeInsets] in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets MultiplyOperator(double other)
        {
            return EdgeInsets.FromLTRB(Left * other, Top * other, Right * other, Bottom * other);
        }




        /// <Summary>
        /// Divides the [EdgeInsets] in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets DivideOperator(double other)
        {
            return EdgeInsets.FromLTRB(Left / other, Top / other, Right / other, Bottom / other);
        }




        /// <Summary>
        /// Integer divides the [EdgeInsets] in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets DivideIntegerResultOperator(double other)
        {
            return EdgeInsets.FromLTRB((Left~/ other).ToDouble(), (Top~/ other).ToDouble(), (Right~/ other).ToDouble(), (Bottom~/ other).ToDouble());
        }




        /// <Summary>
        /// Computes the remainder in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets ModuloOperator(double other)
        {
            return EdgeInsets.FromLTRB(Left % other, Top % other, Right % other, Bottom % other);
        }




        /// <Summary>
        /// Linearly interpolate between two [EdgeInsets].
        ///
        /// If either is null, this function interpolates from [EdgeInsets.zero].
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsets a, FlutterSDK.Painting.Edgeinsets.EdgeInsets b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b * t;
            if (b == null) return a * (1.0 - t);
            return EdgeInsets.FromLTRB(Dart.UI.UiDefaultClass.LerpDouble(a.Left, b.Left, t), Dart.UI.UiDefaultClass.LerpDouble(a.Top, b.Top, t), Dart.UI.UiDefaultClass.LerpDouble(a.Right, b.Right, t), Dart.UI.UiDefaultClass.LerpDouble(a.Bottom, b.Bottom, t));
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction) => this;



        /// <Summary>
        /// Creates a copy of this EdgeInsets but with the given fields replaced
        /// with the new values.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets CopyWith(double left = default(double), double top = default(double), double right = default(double), double bottom = default(double))
        {
            return EdgeInsets.Only(left: left == default(double) ? this.left : left, top: top == default(double) ? this.top : top, right: right == default(double) ? this.right : right, bottom: bottom == default(double) ? this.bottom : bottom);
        }



    }


    /// <Summary>
    /// An immutable set of offsets in each of the four cardinal directions, but
    /// whose horizontal components are dependent on the writing direction.
    ///
    /// This can be used to indicate padding from the left in [TextDirection.ltr]
    /// text and padding from the right in [TextDirection.rtl] text without having
    /// to be aware of the current text direction.
    ///
    /// See also:
    ///
    ///  * [EdgeInsets], a variant that uses physical labels (left and right instead
    ///    of start and end).
    /// </Summary>
    public class EdgeInsetsDirectional : FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry
    {
        /// <Summary>
        /// Creates insets from offsets from the start, top, end, and bottom.
        /// </Summary>
        public static EdgeInsetsDirectional FromSTEB(double start, double top, double end, double bottom)
        => new EdgeInsetsDirectional(start, top, end, bottom);

        private EdgeInsetsDirectional(double start, double top, double end, double bottom)
        {
            this.Start = start;
            this.Top = top;
            this.End = end;
            this.Bottom = bottom;
        }
        /// <Summary>
        /// Creates insets with only the given values non-zero.
        ///
        /// {@tool snippet}
        ///
        /// A margin indent of 40 pixels on the leading side:
        ///
        /// ```dart
        /// const EdgeInsetsDirectional.only(start: 40.0)
        /// ```
        /// {@end-tool}
        /// </Summary>
        public static EdgeInsetsDirectional Only(double start = 0.0, double top = 0.0, double end = 0.0, double bottom = 0.0)
        => new EdgeInsetsDirectional(start, top, end, bottom, null);

        private EdgeInsetsDirectional(double start, double top, double end, double bottom, object ___dummy_param___1)
        {
            this.Start = start;
            this.Top = top;
            this.End = end;
            this.Bottom = bottom;
        }
        /// <Summary>
        /// An [EdgeInsetsDirectional] with zero offsets in each direction.
        ///
        /// Consider using [EdgeInsets.zero] instead, since that object has the same
        /// effect, but will be cheaper to [resolve].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Zero { get; set; }
        /// <Summary>
        /// The offset from the start side, the side from which the user will start
        /// reading text.
        ///
        /// This value is normalized into an [EdgeInsets.left] or [EdgeInsets.right]
        /// value by the [resolve] method.
        /// </Summary>
        public virtual double Start { get; set; }
        /// <Summary>
        /// The offset from the top.
        ///
        /// This value is passed through to [EdgeInsets.top] unmodified by the
        /// [resolve] method.
        /// </Summary>
        public virtual double Top { get; set; }
        /// <Summary>
        /// The offset from the end side, the side on which the user ends reading
        /// text.
        ///
        /// This value is normalized into an [EdgeInsets.left] or [EdgeInsets.right]
        /// value by the [resolve] method.
        /// </Summary>
        public virtual double End { get; set; }
        /// <Summary>
        /// The offset from the bottom.
        ///
        /// This value is passed through to [EdgeInsets.bottom] unmodified by the
        /// [resolve] method.
        /// </Summary>
        public virtual double Bottom { get; set; }
        internal virtual double _Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Top { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _End { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Bottom { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Left { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _Right { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsNonNegative { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Subtract(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other)
        {
            if (other is EdgeInsetsDirectional) return this - other;
            return base.Subtract(other);
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Add(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry other)
        {
            if (other is EdgeInsetsDirectional) return this + other;
            return base.Add(other);
        }




        /// <Summary>
        /// Returns the difference between two [EdgeInsetsDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Unary(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional other)
        {
            return EdgeInsetsDirectional.FromSTEB(Start - other.Start, Top - other.Top, End - other.End, Bottom - other.Bottom);
        }




        /// <Summary>
        /// Returns the sum of two [EdgeInsetsDirectional] objects.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional AddOperator(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional other)
        {
            return EdgeInsetsDirectional.FromSTEB(Start + other.Start, Top + other.Top, End + other.End, Bottom + other.Bottom);
        }




        /// <Summary>
        /// Returns the [EdgeInsetsDirectional] object with each dimension negated.
        ///
        /// This is the same as multiplying the object by -1.0.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Unary()
        {
            return EdgeInsetsDirectional.FromSTEB(-Start, -Top, -End, -Bottom);
        }




        /// <Summary>
        /// Scales the [EdgeInsetsDirectional] object in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional MultiplyOperator(double other)
        {
            return EdgeInsetsDirectional.FromSTEB(Start * other, Top * other, End * other, Bottom * other);
        }




        /// <Summary>
        /// Divides the [EdgeInsetsDirectional] object in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional DivideOperator(double other)
        {
            return EdgeInsetsDirectional.FromSTEB(Start / other, Top / other, End / other, Bottom / other);
        }




        /// <Summary>
        /// Integer divides the [EdgeInsetsDirectional] object in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional DivideIntegerResultOperator(double other)
        {
            return EdgeInsetsDirectional.FromSTEB((Start~/ other).ToDouble(), (Top~/ other).ToDouble(), (End~/ other).ToDouble(), (Bottom~/ other).ToDouble());
        }




        /// <Summary>
        /// Computes the remainder in each dimension by the given factor.
        /// </Summary>
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional ModuloOperator(double other)
        {
            return EdgeInsetsDirectional.FromSTEB(Start % other, Top % other, End % other, Bottom % other);
        }




        /// <Summary>
        /// Linearly interpolate between two [EdgeInsetsDirectional].
        ///
        /// If either is null, this function interpolates from [EdgeInsetsDirectional.zero].
        ///
        /// To interpolate between two [EdgeInsetsGeometry] objects of arbitrary type
        /// (either [EdgeInsets] or [EdgeInsetsDirectional]), consider the
        /// [EdgeInsetsGeometry.lerp] static method.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Lerp(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional a, FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return b * t;
            if (b == null) return a * (1.0 - t);
            return EdgeInsetsDirectional.FromSTEB(Dart.UI.UiDefaultClass.LerpDouble(a.Start, b.Start, t), Dart.UI.UiDefaultClass.LerpDouble(a.Top, b.Top, t), Dart.UI.UiDefaultClass.LerpDouble(a.End, b.End, t), Dart.UI.UiDefaultClass.LerpDouble(a.Bottom, b.Bottom, t));
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction)
        {

            switch (direction) { case TextDirection.Rtl: return EdgeInsets.FromLTRB(End, Top, Start, Bottom); case TextDirection.Ltr: return EdgeInsets.FromLTRB(Start, Top, End, Bottom); }
            return null;
        }



    }


    public class _MixedEdgeInsets : FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry
    {
        public static _MixedEdgeInsets FromLRSETB(double _left, double _right, double _start, double _end, double _top, double _bottom)
        => new _MixedEdgeInsets(_left, _right, _start, _end, _top, _bottom);

        private _MixedEdgeInsets(double _left, double _right, double _start, double _end, double _top, double _bottom)
        {
            this._Left = _left;
            this._Right = _right;
            this._Start = _start;
            this._End = _end;
            this._Top = _top;
            this._Bottom = _bottom;
        }
        internal new double _Left { get; set; }
        internal new double _Right { get; set; }
        internal new double _Start { get; set; }
        internal new double _End { get; set; }
        internal new double _Top { get; set; }
        internal new double _Bottom { get; set; }
        public virtual bool IsNonNegative { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets Unary()
        {
            return _MixedEdgeInsets.FromLRSETB(-_Left, -_Right, -_Start, -_End, -_Top, -_Bottom);
        }




        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets MultiplyOperator(double other)
        {
            return _MixedEdgeInsets.FromLRSETB(_Left * other, _Right * other, _Start * other, _End * other, _Top * other, _Bottom * other);
        }




        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets DivideOperator(double other)
        {
            return _MixedEdgeInsets.FromLRSETB(_Left / other, _Right / other, _Start / other, _End / other, _Top / other, _Bottom / other);
        }




        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets DivideIntegerResultOperator(double other)
        {
            return _MixedEdgeInsets.FromLRSETB((_Left~/ other).ToDouble(), (_Right~/ other).ToDouble(), (_Start~/ other).ToDouble(), (_End~/ other).ToDouble(), (_Top~/ other).ToDouble(), (_Bottom~/ other).ToDouble());
        }




        public new FlutterSDK.Painting.Edgeinsets._MixedEdgeInsets ModuloOperator(double other)
        {
            return _MixedEdgeInsets.FromLRSETB(_Left % other, _Right % other, _Start % other, _End % other, _Top % other, _Bottom % other);
        }




        public new FlutterSDK.Painting.Edgeinsets.EdgeInsets Resolve(TextDirection direction)
        {

            switch (direction) { case TextDirection.Rtl: return EdgeInsets.FromLTRB(_End + _Left, _Top, _Start + _Right, _Bottom); case TextDirection.Ltr: return EdgeInsets.FromLTRB(_Start + _Left, _Top, _End + _Right, _Bottom); }
            return null;
        }



    }

}
