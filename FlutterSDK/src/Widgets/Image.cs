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
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Image
{
    public delegate FlutterSDK.Widgets.Framework.Widget ImageFrameBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, int frame, bool wasSynchronouslyLoaded);
    public delegate FlutterSDK.Widgets.Framework.Widget ImageLoadingBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Imagestream.ImageChunkEvent loadingProgress);
    public delegate FlutterSDK.Widgets.Framework.Widget ImageErrorWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, @Object error, StackTrace stackTrace);
    internal static class ImageDefaultClass
    {
        internal static FlutterSDK.Painting.Imageprovider.ImageConfiguration CreateLocalImageConfiguration(FlutterSDK.Widgets.Framework.BuildContext context, Size size = default(Size))
        {
            throw new NotImplementedException();
        }

        internal static Future<object> PrecacheImage(FlutterSDK.Painting.Imageprovider.ImageProvider<object> provider, FlutterSDK.Widgets.Framework.BuildContext context, Size size = default(Size), FlutterSDK.Painting.Imagestream.ImageErrorListener onError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener))
        {
            throw new NotImplementedException();
        }

    }

    public class Image : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Image(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageLoadingBuilder loadingBuilder = default(FlutterSDK.Widgets.Image.ImageLoadingBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality))
        : base(key: key)
        {
            this.ImageValue = image;
            this.FrameBuilder = frameBuilder;
            this.LoadingBuilder = loadingBuilder;
            this.ErrorBuilder = errorBuilder;
            this.SemanticLabel = semanticLabel;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.ColorBlendMode = colorBlendMode;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.CenterSlice = centerSlice;
            this.MatchTextDirection = matchTextDirection;
            this.GaplessPlayback = gaplessPlayback;
            this.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        public static Image Network(string src, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = 1.0, FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageLoadingBuilder loadingBuilder = default(FlutterSDK.Widgets.Image.ImageLoadingBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality), Dictionary<string, string> headers = default(Dictionary<string, string>), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.LoadingBuilder = loadingBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        public static Image File(File file, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = 1.0, FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        public static Image Asset(string name, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double scale = default(double), double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, string package = default(string), FilterQuality filterQuality = default(FilterQuality), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        public static Image Memory(Uint8List bytes, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = 1.0, FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string semanticLabel = default(string), bool excludeFromSemantics = false, double width = default(double), double height = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool gaplessPlayback = false, FilterQuality filterQuality = default(FilterQuality), int cacheWidth = default(int), int cacheHeight = default(int))
        {
            var instance = new Image(key: key); instance.FrameBuilder = frameBuilder;
            instance.ErrorBuilder = errorBuilder;
            instance.SemanticLabel = semanticLabel;
            instance.ExcludeFromSemantics = excludeFromSemantics;
            instance.Width = width;
            instance.Height = height;
            instance.Color = color;
            instance.ColorBlendMode = colorBlendMode;
            instance.Fit = fit;
            instance.Alignment = alignment;
            instance.Repeat = repeat;
            instance.CenterSlice = centerSlice;
            instance.MatchTextDirection = matchTextDirection;
            instance.GaplessPlayback = gaplessPlayback;
            instance.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ImageValue { get; set; }
        public virtual FlutterSDK.Widgets.Image.ImageFrameBuilder FrameBuilder { get; set; }
        public virtual FlutterSDK.Widgets.Image.ImageLoadingBuilder LoadingBuilder { get; set; }
        public virtual FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder ErrorBuilder { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FilterQuality FilterQuality { get; set; }
        public virtual FlutterBinding.UI.BlendMode ColorBlendMode { get; set; }
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Painting.Decorationimage.ImageRepeat Repeat { get; set; }
        public virtual FlutterBinding.UI.Rect CenterSlice { get; set; }
        public virtual bool MatchTextDirection { get; set; }
        public virtual bool GaplessPlayback { get; set; }
        public virtual string SemanticLabel { get; set; }
        public virtual bool ExcludeFromSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Image._ImageState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ImageState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Image.Image>, IWidgetsBindingObserver
    {
        #region constructors
        public _ImageState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Imagestream.ImageStream _ImageStream { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageInfo _ImageInfo { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageChunkEvent _LoadingProgress { get; set; }
        internal virtual bool _IsListeningToStream { get; set; }
        internal virtual bool _InvertColors { get; set; }
        internal virtual int _FrameNumber { get; set; }
        internal virtual bool _WasSynchronouslyLoaded { get; set; }
        internal virtual FlutterSDK.Widgets.Disposablebuildcontext.DisposableBuildContext<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Image.Image>> _ScrollAwareContext { get; set; }
        internal virtual @Object _LastException { get; set; }
        internal virtual StackTrace _LastStack { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Image.Image oldWidget) { throw new NotImplementedException(); }


        public new void DidChangeAccessibilityFeatures() { throw new NotImplementedException(); }


        public new void Reassemble() { throw new NotImplementedException(); }


        private void _UpdateInvertColors() { throw new NotImplementedException(); }


        private void _ResolveImage() { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Imagestream.ImageStreamListener _GetListener(FlutterSDK.Widgets.Image.ImageLoadingBuilder loadingBuilder = default(FlutterSDK.Widgets.Image.ImageLoadingBuilder)) { throw new NotImplementedException(); }


        private void _HandleImageFrame(FlutterSDK.Painting.Imagestream.ImageInfo imageInfo, bool synchronousCall) { throw new NotImplementedException(); }


        private void _HandleImageChunk(FlutterSDK.Painting.Imagestream.ImageChunkEvent @event) { throw new NotImplementedException(); }


        private void _UpdateSourceStream(FlutterSDK.Painting.Imagestream.ImageStream newStream) { throw new NotImplementedException(); }


        private void _ListenToStream() { throw new NotImplementedException(); }


        private void _StopListeningToStream() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }

}
