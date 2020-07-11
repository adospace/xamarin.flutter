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
namespace FlutterSDK.Gestures.Events{
internal static class EventsDefaultClass{
public static int KPrimaryButton = default(int);
public static int KSecondaryButton = default(int);
public static int KPrimaryMouseButton = default(int);
public static int KSecondaryMouseButton = default(int);
public static int KStylusContact = default(int);
public static int KPrimaryStylusButton = default(int);
public static int KMiddleMouseButton = default(int);
public static int KSecondaryStylusButton = default(int);
public static int KBackMouseButton = default(int);
public static int KForwardMouseButton = default(int);
public static int KTouchContact = default(int);
internal static int NthMouseButton(int number){
throw new NotImplementedException();
}

internal static int NthStylusButton(int number){
throw new NotImplementedException();
}

internal static int SmallestButton(int buttons){
throw new NotImplementedException();
}

internal static bool IsSingleButton(int buttons){
throw new NotImplementedException();
}

}

public interface IPointerEvent{
FlutterSDK.Gestures.Events.PointerEvent Transformed(Matrix4 transform);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
string ToStringFull();
Offset TransformPosition(Matrix4 transform,FlutterBinding.UI.Offset position);
Offset TransformDeltaViaPositions(FlutterBinding.UI.Offset untransformedEndPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset transformedEndPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset untransformedDelta = default(FlutterBinding.UI.Offset),Matrix4 transform = default(Matrix4));
Matrix4 RemovePerspectiveTransform(Matrix4 transform);
TimeSpan TimeStamp{get;}
int Pointer{get;}
PointerDeviceKind Kind{get;}
int Device{get;}
FlutterBinding.UI.Offset Position{get;}
FlutterBinding.UI.Offset LocalPosition{get;}
FlutterBinding.UI.Offset Delta{get;}
FlutterBinding.UI.Offset LocalDelta{get;}
int Buttons{get;}
bool Down{get;}
bool Obscured{get;}
double Pressure{get;}
double PressureMin{get;}
double PressureMax{get;}
double Distance{get;}
double DistanceMax{get;}
double Size{get;}
double RadiusMajor{get;}
double RadiusMinor{get;}
double RadiusMin{get;}
double RadiusMax{get;}
double Orientation{get;}
double Tilt{get;}
int PlatformData{get;}
bool Synthesized{get;}
Matrix4 Transform{get;}
FlutterSDK.Gestures.Events.PointerEvent Original{get;}
double DistanceMin{get;}
}


public interface IPointerSignalEvent{
}


public class PointerEvent : IDiagnosticable
{
#region constructors
public PointerEvent(TimeSpan timeStamp = default(TimeSpan),int pointer = 0,PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset),int buttons = 0,bool down = false,bool obscured = false,double pressure = 1.0,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,int platformData = 0,bool synthesized = false,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerEvent original = default(FlutterSDK.Gestures.Events.PointerEvent))
: base()
{
this.TimeStamp = timeStamp;
this.Pointer = pointer;
this.Kind = kind;
this.Device = device;
this.Position = position;
this.Delta = delta;
this.Buttons = buttons;
this.Down = down;
this.Obscured = obscured;
this.Pressure = pressure;
this.PressureMin = pressureMin;
this.PressureMax = pressureMax;
this.Distance = distance;
this.DistanceMax = distanceMax;
this.Size = size;
this.RadiusMajor = radiusMajor;
this.RadiusMinor = radiusMinor;
this.RadiusMin = radiusMin;
this.RadiusMax = radiusMax;
this.Orientation = orientation;
this.Tilt = tilt;
this.PlatformData = platformData;
this.Synthesized = synthesized;
this.Transform = transform;
this.Original = original;throw new NotImplementedException(); }
#endregion

#region fields
public virtual TimeSpan TimeStamp{get;set;}
public virtual int Pointer{get;set;}
public virtual PointerDeviceKind Kind{get;set;}
public virtual int Device{get;set;}
public virtual FlutterBinding.UI.Offset Position{get;set;}
public virtual FlutterBinding.UI.Offset LocalPosition{get;set;}
public virtual FlutterBinding.UI.Offset Delta{get;set;}
public virtual FlutterBinding.UI.Offset LocalDelta{get;set;}
public virtual int Buttons{get;set;}
public virtual bool Down{get;set;}
public virtual bool Obscured{get;set;}
public virtual double Pressure{get;set;}
public virtual double PressureMin{get;set;}
public virtual double PressureMax{get;set;}
public virtual double Distance{get;set;}
public virtual double DistanceMax{get;set;}
public virtual double Size{get;set;}
public virtual double RadiusMajor{get;set;}
public virtual double RadiusMinor{get;set;}
public virtual double RadiusMin{get;set;}
public virtual double RadiusMax{get;set;}
public virtual double Orientation{get;set;}
public virtual double Tilt{get;set;}
public virtual int PlatformData{get;set;}
public virtual bool Synthesized{get;set;}
public virtual Matrix4 Transform{get;set;}
public virtual FlutterSDK.Gestures.Events.PointerEvent Original{get;set;}
public virtual double DistanceMin{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Gestures.Events.PointerEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public virtual string ToStringFull(){ throw new NotImplementedException(); }


public virtual Offset TransformPosition(Matrix4 transform,FlutterBinding.UI.Offset position){ throw new NotImplementedException(); }


public virtual Offset TransformDeltaViaPositions(FlutterBinding.UI.Offset untransformedEndPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset transformedEndPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset untransformedDelta = default(FlutterBinding.UI.Offset),Matrix4 transform = default(Matrix4)){ throw new NotImplementedException(); }


public virtual Matrix4 RemovePerspectiveTransform(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerAddedEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerAddedEvent(TimeSpan timeStamp = default(TimeSpan),PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),bool obscured = false,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerAddedEvent original = default(FlutterSDK.Gestures.Events.PointerAddedEvent))
: base(timeStamp:timeStamp,kind:kind,device:device,position:position,localPosition:localPosition,obscured:obscured,pressure:0.0,pressureMin:pressureMin,pressureMax:pressureMax,distance:distance,distanceMax:distanceMax,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerAddedEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerRemovedEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerRemovedEvent(TimeSpan timeStamp = default(TimeSpan),PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),bool obscured = false,double pressureMin = 1.0,double pressureMax = 1.0,double distanceMax = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerRemovedEvent original = default(FlutterSDK.Gestures.Events.PointerRemovedEvent))
: base(timeStamp:timeStamp,kind:kind,device:device,position:position,localPosition:localPosition,obscured:obscured,pressure:0.0,pressureMin:pressureMin,pressureMax:pressureMax,distanceMax:distanceMax,radiusMin:radiusMin,radiusMax:radiusMax,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerRemovedEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerHoverEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerHoverEvent(TimeSpan timeStamp = default(TimeSpan),PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset),int buttons = 0,bool obscured = false,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,bool synthesized = false,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerHoverEvent original = default(FlutterSDK.Gestures.Events.PointerHoverEvent))
: base(timeStamp:timeStamp,kind:kind,device:device,position:position,localPosition:localPosition,delta:delta,localDelta:localDelta,buttons:buttons,down:false,obscured:obscured,pressure:0.0,pressureMin:pressureMin,pressureMax:pressureMax,distance:distance,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,synthesized:synthesized,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerHoverEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerEnterEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerEnterEvent(TimeSpan timeStamp = default(TimeSpan),PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset),int buttons = 0,bool obscured = false,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,bool down = false,bool synthesized = false,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerEnterEvent original = default(FlutterSDK.Gestures.Events.PointerEnterEvent))
: base(timeStamp:timeStamp,kind:kind,device:device,position:position,localPosition:localPosition,delta:delta,localDelta:localDelta,buttons:buttons,down:down,obscured:obscured,pressure:0.0,pressureMin:pressureMin,pressureMax:pressureMax,distance:distance,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,synthesized:synthesized,transform:transform,original:original)
{
throw new NotImplementedException(); }
public static PointerEnterEvent FromHoverEvent(FlutterSDK.Gestures.Events.PointerHoverEvent @event)
{
var instance =new PointerEnterEvent();throw new NotImplementedException(); }
public static PointerEnterEvent FromMouseEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
{
var instance =new PointerEnterEvent();throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerEnterEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerExitEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerExitEvent(TimeSpan timeStamp = default(TimeSpan),PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset),int buttons = 0,bool obscured = false,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,bool down = false,bool synthesized = false,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerExitEvent original = default(FlutterSDK.Gestures.Events.PointerExitEvent))
: base(timeStamp:timeStamp,kind:kind,device:device,position:position,localPosition:localPosition,delta:delta,localDelta:localDelta,buttons:buttons,down:down,obscured:obscured,pressure:0.0,pressureMin:pressureMin,pressureMax:pressureMax,distance:distance,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,synthesized:synthesized,transform:transform,original:original)
{
throw new NotImplementedException(); }
public static PointerExitEvent FromHoverEvent(FlutterSDK.Gestures.Events.PointerHoverEvent @event)
{
var instance =new PointerExitEvent();throw new NotImplementedException(); }
public static PointerExitEvent FromMouseEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
{
var instance =new PointerExitEvent();throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerExitEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerDownEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerDownEvent(TimeSpan timeStamp = default(TimeSpan),int pointer = 0,PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),int buttons = default(int),bool obscured = false,double pressure = 1.0,double pressureMin = 1.0,double pressureMax = 1.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerDownEvent original = default(FlutterSDK.Gestures.Events.PointerDownEvent))
: base(timeStamp:timeStamp,pointer:pointer,kind:kind,device:device,position:position,localPosition:localPosition,buttons:buttons,down:true,obscured:obscured,pressure:pressure,pressureMin:pressureMin,pressureMax:pressureMax,distance:0.0,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerDownEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerMoveEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerMoveEvent(TimeSpan timeStamp = default(TimeSpan),int pointer = 0,PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localDelta = default(FlutterBinding.UI.Offset),int buttons = default(int),bool obscured = false,double pressure = 1.0,double pressureMin = 1.0,double pressureMax = 1.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,int platformData = 0,bool synthesized = false,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerMoveEvent original = default(FlutterSDK.Gestures.Events.PointerMoveEvent))
: base(timeStamp:timeStamp,pointer:pointer,kind:kind,device:device,position:position,localPosition:localPosition,delta:delta,localDelta:localDelta,buttons:buttons,down:true,obscured:obscured,pressure:pressure,pressureMin:pressureMin,pressureMax:pressureMax,distance:0.0,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,platformData:platformData,synthesized:synthesized,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerMoveEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerUpEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerUpEvent(TimeSpan timeStamp = default(TimeSpan),int pointer = 0,PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),int buttons = 0,bool obscured = false,double pressure = 0.0,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerUpEvent original = default(FlutterSDK.Gestures.Events.PointerUpEvent))
: base(timeStamp:timeStamp,pointer:pointer,kind:kind,device:device,position:position,localPosition:localPosition,buttons:buttons,down:false,obscured:obscured,pressure:pressure,pressureMin:pressureMin,pressureMax:pressureMax,distance:distance,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerUpEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}


public class PointerSignalEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerSignalEvent(TimeSpan timeStamp = default(TimeSpan),int pointer = 0,PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerSignalEvent original = default(FlutterSDK.Gestures.Events.PointerSignalEvent))
: base(timeStamp:timeStamp,pointer:pointer,kind:kind,device:device,position:position,localPosition:localPosition,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class PointerScrollEvent : FlutterSDK.Gestures.Events.PointerSignalEvent
{
#region constructors
public PointerScrollEvent(TimeSpan timeStamp = default(TimeSpan),PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset scrollDelta = default(FlutterBinding.UI.Offset),Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerScrollEvent original = default(FlutterSDK.Gestures.Events.PointerScrollEvent))
: base(timeStamp:timeStamp,kind:kind,device:device,position:position,localPosition:localPosition,transform:transform,original:original)
{
this.ScrollDelta = scrollDelta;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Offset ScrollDelta{get;set;}
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerScrollEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class PointerCancelEvent : FlutterSDK.Gestures.Events.PointerEvent
{
#region constructors
public PointerCancelEvent(TimeSpan timeStamp = default(TimeSpan),int pointer = 0,PointerDeviceKind kind = default(PointerDeviceKind),int device = 0,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset),int buttons = 0,bool obscured = false,double pressureMin = 1.0,double pressureMax = 1.0,double distance = 0.0,double distanceMax = 0.0,double size = 0.0,double radiusMajor = 0.0,double radiusMinor = 0.0,double radiusMin = 0.0,double radiusMax = 0.0,double orientation = 0.0,double tilt = 0.0,Matrix4 transform = default(Matrix4),FlutterSDK.Gestures.Events.PointerCancelEvent original = default(FlutterSDK.Gestures.Events.PointerCancelEvent))
: base(timeStamp:timeStamp,pointer:pointer,kind:kind,device:device,position:position,localPosition:localPosition,buttons:buttons,down:false,obscured:obscured,pressure:0.0,pressureMin:pressureMin,pressureMax:pressureMax,distance:distance,distanceMax:distanceMax,size:size,radiusMajor:radiusMajor,radiusMinor:radiusMinor,radiusMin:radiusMin,radiusMax:radiusMax,orientation:orientation,tilt:tilt,transform:transform,original:original)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Gestures.Events.PointerCancelEvent Transformed(Matrix4 transform){ throw new NotImplementedException(); }

#endregion
}

}
