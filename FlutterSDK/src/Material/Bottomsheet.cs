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
namespace FlutterSDK.Material.Bottomsheet{
public delegate void BottomSheetDragStartHandler(FlutterSDK.Gestures.Dragdetails.DragStartDetails details);
public delegate void BottomSheetDragEndHandler(FlutterSDK.Gestures.Dragdetails.DragEndDetails details,bool isClosing = default(bool));
internal static class BottomsheetDefaultClass{
public static TimeSpan _BottomSheetEnterDuration = default(TimeSpan);
public static TimeSpan _BottomSheetExitDuration = default(TimeSpan);
public static FlutterSDK.Animation.Curves.Curve _ModalBottomSheetCurve = default(FlutterSDK.Animation.Curves.Curve);
public static double _MinFlingVelocity = default(double);
public static double _CloseProgressThreshold = default(double);
internal static Future<T> ShowModalBottomSheet<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext),FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),double elevation = default(double),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),FlutterBinding.UI.Color barrierColor = default(FlutterBinding.UI.Color),bool isScrollControlled = false,bool useRootNavigator = false,bool isDismissible = true,bool enableDrag = true){
throw new NotImplementedException();
}

internal static FlutterSDK.Material.Scaffold.PersistentBottomSheetController<T> ShowBottomSheet<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext),FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),double elevation = default(double),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip)){
throw new NotImplementedException();
}

}

public class BottomSheet : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public BottomSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Animation.Animationcontroller.AnimationController animationController = default(FlutterSDK.Animation.Animationcontroller.AnimationController),bool enableDrag = true,FlutterSDK.Material.Bottomsheet.BottomSheetDragStartHandler onDragStart = default(FlutterSDK.Material.Bottomsheet.BottomSheetDragStartHandler),FlutterSDK.Material.Bottomsheet.BottomSheetDragEndHandler onDragEnd = default(FlutterSDK.Material.Bottomsheet.BottomSheetDragEndHandler),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),double elevation = default(double),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),VoidCallback onClosing = default(VoidCallback),FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder))
: base(key:key)
{
this.AnimationController = animationController;
this.EnableDrag = enableDrag;
this.OnDragStart = onDragStart;
this.OnDragEnd = onDragEnd;
this.BackgroundColor = backgroundColor;
this.Elevation = elevation;
this.Shape = shape;
this.ClipBehavior = clipBehavior;
this.OnClosing = onClosing;
this.Builder = builder;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animationcontroller.AnimationController AnimationController{get;set;}
public virtual VoidCallback OnClosing{get;set;}
public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder{get;set;}
public virtual bool EnableDrag{get;set;}
public virtual FlutterSDK.Material.Bottomsheet.BottomSheetDragStartHandler OnDragStart{get;set;}
public virtual FlutterSDK.Material.Bottomsheet.BottomSheetDragEndHandler OnDragEnd{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual double Elevation{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual FlutterBinding.UI.Clip ClipBehavior{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Bottomsheet._BottomSheetState CreateState(){ throw new NotImplementedException(); }


public virtual FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController(FlutterSDK.Scheduler.Ticker.TickerProvider vsync){ throw new NotImplementedException(); }

#endregion
}


public class _BottomSheetState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Bottomsheet.BottomSheet>
{
#region constructors
public _BottomSheetState()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ChildKey{get;set;}
internal virtual double _ChildHeight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual bool _DismissUnderway{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details){ throw new NotImplementedException(); }


private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details){ throw new NotImplementedException(); }


private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details){ throw new NotImplementedException(); }


public virtual bool ExtentChanged(FlutterSDK.Widgets.Draggablescrollablesheet.DraggableScrollableNotification notification){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _ModalBottomSheetLayout : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
{
#region constructors
public _ModalBottomSheetLayout(double progress,bool isScrollControlled)
{
this.Progress = progress;
this.IsScrollControlled = isScrollControlled;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Progress{get;set;}
public virtual bool IsScrollControlled{get;set;}
#endregion

#region methods

public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints){ throw new NotImplementedException(); }


public new Offset GetPositionForChild(Size size,Size childSize){ throw new NotImplementedException(); }


public new bool ShouldRelayout(FlutterSDK.Material.Bottomsheet._ModalBottomSheetLayout oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class _ModalBottomSheet<T> : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _ModalBottomSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Material.Bottomsheet._ModalBottomSheetRoute<T> route = default(FlutterSDK.Material.Bottomsheet._ModalBottomSheetRoute<T>),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),double elevation = default(double),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),bool isScrollControlled = false,bool enableDrag = true)
: base(key:key)
{
this.Route = route;
this.BackgroundColor = backgroundColor;
this.Elevation = elevation;
this.Shape = shape;
this.ClipBehavior = clipBehavior;
this.IsScrollControlled = isScrollControlled;
this.EnableDrag = enableDrag;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Bottomsheet._ModalBottomSheetRoute<T> Route{get;set;}
public virtual bool IsScrollControlled{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual double Elevation{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual FlutterBinding.UI.Clip ClipBehavior{get;set;}
public virtual bool EnableDrag{get;set;}
#endregion

#region methods

public new _ModalBottomSheetState<T> CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _ModalBottomSheetState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Bottomsheet._ModalBottomSheet<T>>
{
#region constructors
public _ModalBottomSheetState()
{ }
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.ParametricCurve<double> AnimationCurve{get;set;}
#endregion

#region methods

private string _GetRouteLabel(FlutterSDK.Material.Materiallocalizations.MaterialLocalizations localizations){ throw new NotImplementedException(); }


public virtual void HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details){ throw new NotImplementedException(); }


public virtual void HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details,bool isClosing = default(bool)){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _ModalBottomSheetRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<T>
{
#region constructors
public _ModalBottomSheetRoute(FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder),FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData),string barrierLabel = default(string),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),double elevation = default(double),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),FlutterBinding.UI.Color modalBarrierColor = default(FlutterBinding.UI.Color),bool isDismissible = true,bool enableDrag = true,bool isScrollControlled = default(bool),FlutterSDK.Widgets.Navigator.RouteSettings settings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
: base(settings:settings)
{
this.Builder = builder;
this.Theme = theme;
this.BarrierLabel = barrierLabel;
this.BackgroundColor = backgroundColor;
this.Elevation = elevation;
this.Shape = shape;
this.ClipBehavior = clipBehavior;
this.ModalBarrierColor = modalBarrierColor;
this.IsDismissible = isDismissible;
this.EnableDrag = enableDrag;
this.IsScrollControlled = isScrollControlled;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder{get;set;}
public virtual FlutterSDK.Material.Themedata.ThemeData Theme{get;set;}
public virtual bool IsScrollControlled{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual double Elevation{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual FlutterBinding.UI.Clip ClipBehavior{get;set;}
public virtual FlutterBinding.UI.Color ModalBarrierColor{get;set;}
public virtual bool IsDismissible{get;set;}
public virtual bool EnableDrag{get;set;}
public new string BarrierLabel{get;set;}
internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _AnimationController{get;set;}
public virtual TimeSpan TransitionDuration{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual TimeSpan ReverseTransitionDuration{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool BarrierDismissible{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Color BarrierColor{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Animation.Animationcontroller.AnimationController CreateAnimationController(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Animation.Animation.Animation<double> animation,FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation){ throw new NotImplementedException(); }

#endregion
}


public class _BottomSheetSuspendedCurve : FlutterSDK.Animation.Curves.ParametricCurve<double>
{
#region constructors
public _BottomSheetSuspendedCurve(double startingPoint,FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
: base()
{
this.StartingPoint = startingPoint;
this.Curve = curve;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double StartingPoint{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve Curve{get;set;}
#endregion

#region methods

public new double Transform(double t){ throw new NotImplementedException(); }


#endregion
}

}
