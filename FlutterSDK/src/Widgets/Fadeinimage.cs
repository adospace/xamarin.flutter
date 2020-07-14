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
namespace FlutterSDK.Widgets.Fadeinimage
{
    internal static class FadeinimageDefaultClass
    {
    }

    /// <Summary>
    /// An image that shows a [placeholder] image while the target [image] is
    /// loading, then fades in the new image when it loads.
    ///
    /// Use this class to display long-loading images, such as [new NetworkImage],
    /// so that the image appears on screen with a graceful animation rather than
    /// abruptly popping onto the screen.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=pK738Pg9cxc}
    ///
    /// If the [image] emits an [ImageInfo] synchronously, such as when the image
    /// has been loaded and cached, the [image] is displayed immediately, and the
    /// [placeholder] is never displayed.
    ///
    /// The [fadeOutDuration] and [fadeOutCurve] properties control the fade-out
    /// animation of the [placeholder].
    ///
    /// The [fadeInDuration] and [fadeInCurve] properties control the fade-in
    /// animation of the target [image].
    ///
    /// Prefer a [placeholder] that's already cached so that it is displayed
    /// immediately. This prevents it from popping onto the screen.
    ///
    /// When [image] changes, it is resolved to a new [ImageStream]. If the new
    /// [ImageStream.key] is different, this widget subscribes to the new stream and
    /// replaces the displayed image with images emitted by the new stream.
    ///
    /// When [placeholder] changes and the [image] has not yet emitted an
    /// [ImageInfo], then [placeholder] is resolved to a new [ImageStream]. If the
    /// new [ImageStream.key] is different, this widget subscribes to the new stream
    /// and replaces the displayed image to images emitted by the new stream.
    ///
    /// When either [placeholder] or [image] changes, this widget continues showing
    /// the previously loaded image (if any) until the new image provider provides a
    /// different image. This is known as "gapless playback" (see also
    /// [Image.gaplessPlayback]).
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// FadeInImage(
    ///   // here `bytes` is a Uint8List containing the bytes for the in-memory image
    ///   placeholder: MemoryImage(bytes),
    ///   image: NetworkImage('https://backend.example.com/image.png'),
    /// )
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class FadeInImage : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public FadeInImage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Imageprovider.ImageProvider<object> placeholder = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), bool excludeFromSemantics = false, string imageSemanticLabel = default(string), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve), double width = default(double), double height = default(double), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false)
        : base(key: key)
    
}
    public static FadeInImage MemoryNetwork(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Uint8List placeholder = default(Uint8List), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string image = default(string), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), double placeholderScale = 1.0, double imageScale = 1.0, bool excludeFromSemantics = false, string imageSemanticLabel = default(string), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve), double width = default(double), double height = default(double), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false, int placeholderCacheWidth = default(int), int placeholderCacheHeight = default(int), int imageCacheWidth = default(int), int imageCacheHeight = default(int))

}
public static FadeInImage AssetNetwork(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string placeholder = default(string), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder placeholderErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), string image = default(string), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder imageErrorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), double placeholderScale = default(double), double imageScale = 1.0, bool excludeFromSemantics = false, string imageSemanticLabel = default(string), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve), double width = default(double), double height = default(double), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), bool matchTextDirection = false, int placeholderCacheWidth = default(int), int placeholderCacheHeight = default(int), int imageCacheWidth = default(int), int imageCacheHeight = default(int))

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> Placeholder { get; set; }
public virtual FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder PlaceholderErrorBuilder { get; set; }
public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> Image { get; set; }
public virtual FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder ImageErrorBuilder { get; set; }
public virtual TimeSpan FadeOutDuration { get; set; }
public virtual FlutterSDK.Animation.Curves.Curve FadeOutCurve { get; set; }
public virtual TimeSpan FadeInDuration { get; set; }
public virtual FlutterSDK.Animation.Curves.Curve FadeInCurve { get; set; }
public virtual double Width { get; set; }
public virtual double Height { get; set; }
public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
public virtual FlutterSDK.Painting.Decorationimage.ImageRepeat Repeat { get; set; }
public virtual bool MatchTextDirection { get; set; }
public virtual bool ExcludeFromSemantics { get; set; }
public virtual string ImageSemanticLabel { get; set; }
#endregion

#region methods

private FlutterSDK.Widgets.Image.Image _Image(FlutterSDK.Painting.Imageprovider.ImageProvider<object> image = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder errorBuilder = default(FlutterSDK.Widgets.Image.ImageErrorWidgetBuilder), FlutterSDK.Widgets.Image.ImageFrameBuilder frameBuilder = default(FlutterSDK.Widgets.Image.ImageFrameBuilder))
{

    return new Image(image: image, errorBuilder: errorBuilder, frameBuilder: frameBuilder, width: Width, height: Height, fit: Fit, alignment: Alignment, repeat: Repeat, matchTextDirection: MatchTextDirection, gaplessPlayback: true, excludeFromSemantics: true);
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    Widget result = _Image(image: Image, errorBuilder: ImageErrorBuilder, frameBuilder: (BuildContext context, Widget child, int frame, bool wasSynchronouslyLoaded) =>
    {
        if (wasSynchronouslyLoaded) return child;
        return new _AnimatedFadeOutFadeIn(target: child, placeholder: _Image(image: Placeholder, errorBuilder: PlaceholderErrorBuilder), isTargetLoaded: frame != null, fadeInDuration: FadeInDuration, fadeOutDuration: FadeOutDuration, fadeInCurve: FadeInCurve, fadeOutCurve: FadeOutCurve);
    }
    );
    if (!ExcludeFromSemantics)
    {
        result = new Semantics(container: ImageSemanticLabel != null, image: true, label: ImageSemanticLabel ?? "", child: result);
    }

    return result;
}



#endregion
}


public class _AnimatedFadeOutFadeIn : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public _AnimatedFadeOutFadeIn(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget target = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget placeholder = default(FlutterSDK.Widgets.Framework.Widget), bool isTargetLoaded = default(bool), TimeSpan fadeOutDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeOutCurve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan fadeInDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve fadeInCurve = default(FlutterSDK.Animation.Curves.Curve))
    : base(key: key, duration: fadeInDuration + fadeOutDuration)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Target { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget Placeholder { get; set; }
public virtual bool IsTargetLoaded { get; set; }
public virtual TimeSpan FadeInDuration { get; set; }
public virtual TimeSpan FadeOutDuration { get; set; }
public virtual FlutterSDK.Animation.Curves.Curve FadeInCurve { get; set; }
public virtual FlutterSDK.Animation.Curves.Curve FadeOutCurve { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Fadeinimage._AnimatedFadeOutFadeInState CreateState() => new _AnimatedFadeOutFadeInState();


#endregion
}


public class _AnimatedFadeOutFadeInState : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidgetState<FlutterSDK.Widgets.Fadeinimage._AnimatedFadeOutFadeIn>
{
    #region constructors
    public _AnimatedFadeOutFadeInState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _TargetOpacity { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _PlaceholderOpacity { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _TargetOpacityAnimation { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _PlaceholderOpacityAnimation { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _TargetOpacity = visitor(_TargetOpacity, Widget.IsTargetLoaded ? 1.0 : 0.0, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _PlaceholderOpacity = visitor(_PlaceholderOpacity, Widget.IsTargetLoaded ? 0.0 : 1.0, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
    }




    public new void DidUpdateTweens()
    {
        _PlaceholderOpacityAnimation = Animation.Drive(new TweenSequence<double>(new List<TweenSequenceItem<double>>() { new TweenSequenceItem<double>(tween: _PlaceholderOpacity.Chain(new CurveTween(curve: Widget.FadeOutCurve)), weight: Widget.FadeOutDuration.InMilliseconds.ToDouble()), new TweenSequenceItem<double>(tween: new ConstantTween<double>(0), weight: Widget.FadeInDuration.InMilliseconds.ToDouble()) }));
        Animation.Drive(new TweenSequence<double>(new List<TweenSequenceItem<double>>() { new TweenSequenceItem<double>(tween: _PlaceholderOpacity.Chain(new CurveTween(curve: Widget.FadeOutCurve)), weight: Widget.FadeOutDuration.InMilliseconds.ToDouble()), new TweenSequenceItem<double>(tween: new ConstantTween<double>(0), weight: Widget.FadeInDuration.InMilliseconds.ToDouble()) })).AddStatusListener((AnimationStatus status) =>
        {
            if (_PlaceholderOpacityAnimation.IsCompleted)
            {
                SetState(() =>
                {
                }
                );
            }

        }
        );
        _TargetOpacityAnimation = Animation.Drive(new TweenSequence<double>(new List<TweenSequenceItem<double>>() { new TweenSequenceItem<double>(tween: new ConstantTween<double>(0), weight: Widget.FadeOutDuration.InMilliseconds.ToDouble()), new TweenSequenceItem<double>(tween: _TargetOpacity.Chain(new CurveTween(curve: Widget.FadeInCurve)), weight: Widget.FadeInDuration.InMilliseconds.ToDouble()) }));
        if (!Widget.IsTargetLoaded && _IsValid(_PlaceholderOpacity) && _IsValid(_TargetOpacity))
        {
            Controller.Value = Controller.UpperBound;
        }

    }




    private bool _IsValid(FlutterSDK.Animation.Tween.Tween<double> tween)
    {
        return tween.Begin != null && tween.End != null;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        Widget target = new FadeTransition(opacity: _TargetOpacityAnimation, child: Widget.Target);
        if (_PlaceholderOpacityAnimation.IsCompleted)
        {
            return target;
        }

        return new Stack(fit: StackFit.Passthrough, alignment: AlignmentDefaultClass.AlignmentDirectional.Center, textDirection: TextDirection.Ltr, children: new List<Widget>() { target, new FadeTransition(opacity: _PlaceholderOpacityAnimation, child: Widget.Placeholder) });
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<Animation<double>>("targetOpacity", _TargetOpacityAnimation));
        properties.Add(new DiagnosticsProperty<Animation<double>>("placeholderOpacity", _PlaceholderOpacityAnimation));
    }



    #endregion
}

}
