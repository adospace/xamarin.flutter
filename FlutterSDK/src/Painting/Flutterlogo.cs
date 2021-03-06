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
namespace FlutterSDK.Painting.Flutterlogo
{
    internal static class FlutterlogoDefaultClass
    {
    }

    /// <Summary>
    /// An immutable description of how to paint Flutter's logo.
    /// </Summary>
    public class FlutterLogoDecoration : FlutterSDK.Painting.Decoration.Decoration
    {
        /// <Summary>
        /// Creates a decoration that knows how to paint Flutter's logo.
        ///
        /// The [lightColor] and [darkColor] are used to fill the logo. The [style]
        /// controls whether and where to draw the "Flutter" label. If one is shown,
        /// the [textColor] controls the color of the label.
        ///
        /// The [lightColor], [darkColor], [textColor], [style], and [margin]
        /// arguments must not be null.
        /// </Summary>
        public FlutterLogoDecoration(FlutterBinding.UI.Color lightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Flutterlogo.FlutterLogoStyle style = default(FlutterSDK.Painting.Flutterlogo.FlutterLogoStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsets margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets))
        : base()
        {
            this.LightColor = lightColor;
            this.DarkColor = darkColor;
            this.TextColor = textColor;
            this.Style = style;
            this.Margin = margin;
        }
        internal FlutterLogoDecoration(FlutterBinding.UI.Color lightColor, FlutterBinding.UI.Color darkColor, FlutterBinding.UI.Color textColor, FlutterSDK.Painting.Flutterlogo.FlutterLogoStyle style, FlutterSDK.Painting.Edgeinsets.EdgeInsets margin, double _position, double _opacity)
        {
            this.LightColor = lightColor;
            this.DarkColor = darkColor;
            this.TextColor = textColor;
            this.Style = style;
            this.Margin = margin;
            this._Position = _position;
            this._Opacity = _opacity;
        }
        /// <Summary>
        /// The lighter of the two colors used to paint the logo.
        ///
        /// If possible, the default should be used. It corresponds to the 400 and 900
        /// values of [material.Colors.blue] from the Material library.
        ///
        /// If for some reason that color scheme is impractical, the same entries from
        /// [material.Colors.amber], [material.Colors.red], or
        /// [material.Colors.indigo] colors can be used. These are Flutter's secondary
        /// colors.
        ///
        /// In extreme cases where none of those four color schemes will work,
        /// [material.Colors.pink], [material.Colors.purple], or
        /// [material.Colors.cyan] can be used. These are Flutter's tertiary colors.
        /// </Summary>
        public virtual FlutterBinding.UI.Color LightColor { get; set; }
        /// <Summary>
        /// The darker of the two colors used to paint the logo.
        ///
        /// See [lightColor] for more information about selecting the logo's colors.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DarkColor { get; set; }
        /// <Summary>
        /// The color used to paint the "Flutter" text on the logo, if [style] is
        /// [FlutterLogoStyle.horizontal] or [FlutterLogoStyle.stacked]. The
        /// appropriate color is `const Color(0xFF616161)` (a medium gray), against a
        /// white background.
        /// </Summary>
        public virtual FlutterBinding.UI.Color TextColor { get; set; }
        /// <Summary>
        /// Whether and where to draw the "Flutter" text. By default, only the logo
        /// itself is drawn.
        /// </Summary>
        public virtual FlutterSDK.Painting.Flutterlogo.FlutterLogoStyle Style { get; set; }
        /// <Summary>
        /// How far to inset the logo from the edge of the container.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Margin { get; set; }
        internal virtual double _Position { get; set; }
        internal virtual double _Opacity { get; set; }
        internal virtual bool _InTransition { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsComplex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool DebugAssertIsValid()
        {

            return true;
        }




        /// <Summary>
        /// Linearly interpolate between two Flutter logo descriptions.
        ///
        /// Interpolates both the color and the style in a continuous fashion.
        ///
        /// If both values are null, this returns null. Otherwise, it returns a
        /// non-null value. If one of the values is null, then the result is obtained
        /// by scaling the other value's opacity and [margin].
        ///
        /// {@macro dart.ui.shadow.lerp}
        ///
        /// See also:
        ///
        ///  * [Decoration.lerp], which interpolates between arbitrary decorations.
        /// </Summary>
        public virtual FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration Lerp(FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration a, FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration b, double t)
        {



            if (a == null && b == null) return null;
            if (a == null)
            {
                return FlutterLogoDecoration._(((EdgeInsets)b).LightColor, ((EdgeInsets)b).DarkColor, ((EdgeInsets)b).TextColor, ((EdgeInsets)b).Style, ((EdgeInsets)b).Margin * t, ((EdgeInsets)b)._Position, ((EdgeInsets)b)._Opacity * t.Clamp(0.0, 1.0));
            }

            if (b == null)
            {
                return FlutterLogoDecoration._(a.LightColor, a.DarkColor, a.TextColor, a.Style, a.Margin * t, a._Position, a._Opacity * (1.0 - t).Clamp(0.0, 1.0));
            }

            if (t == 0.0) return a;
            if (t == 1.0) return b;
            return FlutterLogoDecoration._(Dart.UI.UiDefaultClass.Color.Lerp(a.LightColor, b.LightColor, t), Dart.UI.UiDefaultClass.Color.Lerp(a.DarkColor, b.DarkColor, t), Dart.UI.UiDefaultClass.Color.Lerp(a.TextColor, b.TextColor, t), t < 0.5 ? a.Style : b.Style, EdgeinsetsDefaultClass.EdgeInsets.Lerp(a.Margin, b.Margin, t), a._Position + (b._Position - a._Position) * t, (a._Opacity + (b._Opacity - a._Opacity) * t).Clamp(0.0, 1.0) as double);
        }




        public new FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration LerpFrom(FlutterSDK.Painting.Decoration.Decoration a, double t)
        {

            if (a == null || a is FlutterLogoDecoration)
            {

                return FlutterlogoDefaultClass.FlutterLogoDecoration.Lerp(((FlutterLogoDecoration)a) as FlutterLogoDecoration, this, t);
            }

            return base.LerpFrom(a, t) as FlutterLogoDecoration;
        }




        public new FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration LerpTo(FlutterSDK.Painting.Decoration.Decoration b, double t)
        {

            if (b == null || b is FlutterLogoDecoration)
            {

                return FlutterlogoDefaultClass.FlutterLogoDecoration.Lerp(this, ((FlutterLogoDecoration)b) as FlutterLogoDecoration, t);
            }

            return base.LerpTo(b, t) as FlutterLogoDecoration;
        }




        public new bool HitTest(Size size, FlutterBinding.UI.Offset position, TextDirection textDirection = default(TextDirection)) => true;



        public new FlutterSDK.Painting.Decoration.BoxPainter CreateBoxPainter(VoidCallback onChanged = default(VoidCallback))
        {

            return new _FlutterLogoPainter(this);
        }




        public new bool Equals(@Object other)
        {

            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            return other is FlutterLogoDecoration && other.LightColor == LightColor && other.DarkColor == DarkColor && other.TextColor == TextColor && other._Position == _Position && other._Opacity == _Opacity;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(DiagnosticsNode.Message($"'{LightColor}/{DarkColor} on {TextColor}'"));
            properties.Add(new EnumProperty<FlutterLogoStyle>("style", Style));
            if (_InTransition) properties.Add(DiagnosticsNode.Message($"'transition {DebugDefaultClass.DebugFormatDouble(_Position)}:{DebugDefaultClass.DebugFormatDouble(_Opacity)}'"));
        }



    }


    /// <Summary>
    /// An object that paints a [BoxDecoration] into a canvas.
    /// </Summary>
    public class _FlutterLogoPainter : FlutterSDK.Painting.Decoration.BoxPainter
    {
        public _FlutterLogoPainter(FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration _config)
        : base(null)
        {
            this._Config = _config;
            _PrepareText();
        }


        internal virtual FlutterSDK.Painting.Flutterlogo.FlutterLogoDecoration _Config { get; set; }
        internal virtual FlutterSDK.Painting.Textpainter.TextPainter _TextPainter { get; set; }
        internal virtual FlutterBinding.UI.Rect _TextBoundingRect { get; set; }

        private void _PrepareText()
        {
            string kLabel = "Flutter";
            _TextPainter = new TextPainter(text: new TextSpan(text: kLabel, style: new TextStyle(color: _Config.TextColor, fontFamily: "Roboto", fontSize: 100.0 * 350.0 / 247.0, fontWeight: Dart.UiDefaultClass.FontWeight.W300, textBaseline: TextBaseline.Alphabetic)), textDirection: TextDirection.Ltr);
            _TextPainter.Layout();
            Dart.UI.TextBox textSize = _TextPainter.GetBoxesForSelection(new TextSelection(baseOffset: 0, extentOffset: kLabel.Length)).Single();
            _TextBoundingRect = Rect.FromLTRB(textSize.Left, textSize.Top, textSize.Right, textSize.Bottom);
        }




        private void _PaintLogo(Canvas canvas, FlutterBinding.UI.Rect rect)
        {
            canvas.Save();
            canvas.Translate(rect.Left, rect.Top);
            canvas.Scale(rect.Width / 202.0, rect.Height / 202.0);
            canvas.Translate((202.0 - 166.0) / 2.0, 0.0);
            Paint lightPaint = new Paint()..Color = _Config.LightColor.WithOpacity(0.8);
            Paint mediumPaint = new Paint()..Color = _Config.LightColor;
            Paint darkPaint = new Paint()..Color = _Config.DarkColor;
            Dart.UI.Gradient triangleGradient = Dart.UI.Gradient.Linear(new Offset(87.2623 + 37.9092, 28.8384 + 123.4389), new Offset(42.9205 + 37.9092, 35.0952 + 123.4389), new List<Color>() { new Color(0xBFFFFFFF), new Color(0xBFFCFCFC), new Color(0xBFF4F4F4), new Color(0xBFE5E5E5), new Color(0xBFD1D1D1), new Color(0xBFB6B6B6), new Color(0xBF959595), new Color(0xBF6E6E6E), new Color(0xBF616161) }, new List<double>() { 0.2690, 0.4093, 0.4972, 0.5708, 0.6364, 0.6968, 0.7533, 0.8058, 0.8219 });
            Paint trianglePaint = new Paint()..Shader = triangleGradient..BlendMode = BlendMode.Multiply;
            Dart.UI.Gradient rectangleGradient = Dart.UI.Gradient.Linear(new Offset(62.3643 + 37.9092, 40.135 + 123.4389), new Offset(54.0376 + 37.9092, 31.8083 + 123.4389), new List<Color>() { new Color(0x80FFFFFF), new Color(0x80FCFCFC), new Color(0x80F4F4F4), new Color(0x80E5E5E5), new Color(0x80D1D1D1), new Color(0x80B6B6B6), new Color(0x80959595), new Color(0x806E6E6E), new Color(0x80616161) }, new List<double>() { 0.4588, 0.5509, 0.6087, 0.6570, 0.7001, 0.7397, 0.7768, 0.8113, 0.8219 });
            Paint rectanglePaint = new Paint()..Shader = rectangleGradient..BlendMode = BlendMode.Multiply;
            Path topBeam = new Path();
            new Path().MoveTo(37.7, 128.9);
            new Path().LineTo(9.8, 101.0);
            new Path().LineTo(100.4, 10.4);
            new Path().LineTo(156.2, 10.4);
            canvas.DrawPath(topBeam, lightPaint);
            Path middleBeam = new Path();
            new Path().MoveTo(156.2, 94.0);
            new Path().LineTo(100.4, 94.0);
            new Path().LineTo(79.5, 114.9);
            new Path().LineTo(107.4, 142.8);
            canvas.DrawPath(middleBeam, lightPaint);
            Path bottomBeam = new Path();
            new Path().MoveTo(79.5, 170.7);
            new Path().LineTo(100.4, 191.6);
            new Path().LineTo(156.2, 191.6);
            new Path().LineTo(156.2, 191.6);
            new Path().LineTo(107.4, 142.8);
            canvas.DrawPath(bottomBeam, darkPaint);
            canvas.Save();
            canvas.Transform(List<float>.FromList(new List<double>() { 0.7071, -0.7071, 0.0, 0.0, 0.7071, 0.7071, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, -77.697, 98.057, 0.0, 1.0 }));
            canvas.DrawRect(Rect.FromLTWH(59.8, 123.1, 39.4, 39.4), mediumPaint);
            canvas.Restore();
            Path triangle = new Path();
            new Path().MoveTo(79.5, 170.7);
            new Path().LineTo(120.9, 156.4);
            new Path().LineTo(107.4, 142.8);
            canvas.DrawPath(triangle, trianglePaint);
            Path rectangle = new Path();
            new Path().MoveTo(107.4, 142.8);
            new Path().LineTo(79.5, 170.7);
            new Path().LineTo(86.1, 177.3);
            new Path().LineTo(114.0, 149.4);
            canvas.DrawPath(rectangle, rectanglePaint);
            canvas.Restore();
        }




        public new void Paint(Canvas canvas, FlutterBinding.UI.Offset offset, FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration)
        {
            offset += _Config.Margin.TopLeft;
            Size canvasSize = _Config.Margin.DeflateSize(configuration.Size);
            if (canvasSize.IsEmpty()) return;
            Size logoSize = default(Size);
            if (_Config._Position > 0.0)
            {
                logoSize = new Size(820.0, 232.0);
            }
            else if (_Config._Position < 0.0)
            {
                logoSize = new Size(252.0, 306.0);
            }
            else
            {
                logoSize = new Size(202.0, 202.0);
            }

            FittedSizes fittedSize = BoxfitDefaultClass.ApplyBoxFit(BoxFit.Contain, logoSize, canvasSize);

            Rect rect = AlignmentDefaultClass.Alignment.Center.Inscribe(fittedSize.Destination, offset & canvasSize);
            double centerSquareHeight = canvasSize.ShortestSide;
            Rect centerSquare = Rect.FromLTWH(offset.Dx + (canvasSize.Width - centerSquareHeight) / 2.0, offset.Dy + (canvasSize.Height - centerSquareHeight) / 2.0, centerSquareHeight, centerSquareHeight);
            Rect logoTargetSquare = default(Rect);
            if (_Config._Position > 0.0)
            {
                logoTargetSquare = Rect.FromLTWH(rect.Left, rect.Top, rect.Height, rect.Height);
            }
            else if (_Config._Position < 0.0)
            {
                double logoHeight = rect.Height * 191.0 / 306.0;
                logoTargetSquare = Rect.FromLTWH(rect.Left + (rect.Width - logoHeight) / 2.0, rect.Top, logoHeight, logoHeight);
            }
            else
            {
                logoTargetSquare = centerSquare;
            }

            Rect logoSquare = Dart.UI.UiDefaultClass.Rect.Lerp(centerSquare, logoTargetSquare, _Config._Position.Abs());
            if (_Config._Opacity < 1.0)
            {
                canvas.SaveLayer(offset & canvasSize, new Paint()..ColorFilter = ColorFilter.Mode(new Color(0xFFFFFFFF).WithOpacity(_Config._Opacity), BlendMode.Modulate));
            }

            if (_Config._Position != 0.0)
            {
                if (_Config._Position > 0.0)
                {
                    double fontSize = 2.0 / 3.0 * logoSquare.Height * (1 - (10.4 * 2.0) / 202.0);
                    double scale = fontSize / 100.0;
                    double finalLeftTextPosition = (256.4 / 820.0) * rect.Width - (32.0 / 350.0) * fontSize;
                    double initialLeftTextPosition = rect.Width / 2.0 - _TextBoundingRect.Width * scale;
                    Offset textOffset = new Offset(rect.Left + Dart.UI.UiDefaultClass.LerpDouble(initialLeftTextPosition, finalLeftTextPosition, _Config._Position), rect.Top + (rect.Height - _TextBoundingRect.Height * scale) / 2.0);
                    canvas.Save();
                    if (_Config._Position < 1.0)
                    {
                        Offset center = logoSquare.Center;
                        Path path = new Path();
                        new Path().MoveTo(center.Dx, center.Dy);
                        new Path().LineTo(center.Dx + rect.Width, center.Dy - rect.Width);
                        new Path().LineTo(center.Dx + rect.Width, center.Dy + rect.Width);
                        new Path().Close();
                        canvas.ClipPath(path);
                    }

                    canvas.Translate(textOffset.Dx, textOffset.Dy);
                    canvas.Scale(scale, scale);
                    _TextPainter.Paint(canvas, Dart.UI.UiDefaultClass.Offset.Zero);
                    canvas.Restore();
                }
                else if (_Config._Position < 0.0)
                {
                    double fontSize = 0.35 * logoTargetSquare.Height * (1 - (10.4 * 2.0) / 202.0);
                    double scale = fontSize / 100.0;
                    if (_Config._Position > -1.0)
                    {
                        canvas.SaveLayer(_TextBoundingRect, new Paint());
                    }
                    else
                    {
                        canvas.Save();
                    }

                    canvas.Translate(logoTargetSquare.Center.Dx - (_TextBoundingRect.Width * scale / 2.0), logoTargetSquare.Bottom);
                    canvas.Scale(scale, scale);
                    _TextPainter.Paint(canvas, Dart.UI.UiDefaultClass.Offset.Zero);
                    if (_Config._Position > -1.0)
                    {
                        canvas.DrawRect(_TextBoundingRect.Inflate(_TextBoundingRect.Width * 0.5), new Paint()..BlendMode = BlendMode.Modulate..Shader = Dart.UI.Gradient.Linear(new Offset(_TextBoundingRect.Width * -0.5, 0.0), new Offset(_TextBoundingRect.Width * 1.5, 0.0), new List<Color>() { new Color(0xFFFFFFFF), new Color(0xFFFFFFFF), new Color(0x00FFFFFF), new Color(0x00FFFFFF) }, new List<double>() { 0.0, Dart.Math.MathDefaultClass.Max(0.0, _Config._Position.Abs() - 0.1), Dart.Math.MathDefaultClass.Min(_Config._Position.Abs() + 0.1, 1.0), 1.0 }));
                    }

                    canvas.Restore();
                }

            }

            _PaintLogo(canvas, logoSquare);
            if (_Config._Opacity < 1.0) canvas.Restore();
        }



    }


    /// <Summary>
    /// Possible ways to draw Flutter's logo.
    /// </Summary>
    public enum FlutterLogoStyle
    {

        /// <Summary>
        /// Show only Flutter's logo, not the "Flutter" label.
        ///
        /// This is the default behavior for [FlutterLogoDecoration] objects.
        /// </Summary>
        MarkOnly,
        /// <Summary>
        /// Show Flutter's logo on the left, and the "Flutter" label to its right.
        /// </Summary>
        Horizontal,
        /// <Summary>
        /// Show Flutter's logo above the "Flutter" label.
        /// </Summary>
        Stacked,
    }

}
