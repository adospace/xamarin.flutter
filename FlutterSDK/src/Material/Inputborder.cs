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
using FlutterSDK.Foundation;
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
namespace FlutterSDK.Material.Inputborder
{
    internal static class InputborderDefaultClass
    {
    }

    /// <Summary>
    /// Defines the appearance of an [InputDecorator]'s border.
    ///
    /// An input decorator's border is specified by [InputDecoration.border].
    ///
    /// The border is drawn relative to the input decorator's "container" which
    /// is the optionally filled area above the decorator's helper, error,
    /// and counter.
    ///
    /// Input border's are decorated with a line whose weight and color are defined
    /// by [borderSide]. The input decorator's renderer animates the input border's
    /// appearance in response to state changes, like gaining or losing the focus,
    /// by creating new copies of its input border with [copyWith].
    ///
    /// See also:
    ///
    ///  * [UnderlineInputBorder], the default [InputDecorator] border which
    ///    draws a horizontal line at the bottom of the input decorator's container.
    ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
    ///    rounded rectangle around the input decorator's container.
    ///  * [InputDecoration], which is used to configure an [InputDecorator].
    /// </Summary>
    public interface IInputBorder
    {
        FlutterSDK.Material.Inputborder.InputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide));
        void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection));
        FlutterSDK.Material.Inputborder.InputBorder None { get; }
        FlutterSDK.Painting.Borders.BorderSide BorderSide { get; }
        bool IsOutline { get; }
    }


    /// <Summary>
    /// Defines the appearance of an [InputDecorator]'s border.
    ///
    /// An input decorator's border is specified by [InputDecoration.border].
    ///
    /// The border is drawn relative to the input decorator's "container" which
    /// is the optionally filled area above the decorator's helper, error,
    /// and counter.
    ///
    /// Input border's are decorated with a line whose weight and color are defined
    /// by [borderSide]. The input decorator's renderer animates the input border's
    /// appearance in response to state changes, like gaining or losing the focus,
    /// by creating new copies of its input border with [copyWith].
    ///
    /// See also:
    ///
    ///  * [UnderlineInputBorder], the default [InputDecorator] border which
    ///    draws a horizontal line at the bottom of the input decorator's container.
    ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
    ///    rounded rectangle around the input decorator's container.
    ///  * [InputDecoration], which is used to configure an [InputDecorator].
    /// </Summary>
    public class InputBorder : FlutterSDK.Painting.Borders.ShapeBorder
    {
        #region constructors
        public InputBorder(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Material.Inputborder.InputBorder None { get; set; }
    public virtual FlutterSDK.Painting.Borders.BorderSide BorderSide { get; set; }
    public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Creates a copy of this input border with the specified `borderSide`.
    /// </Summary>
    public virtual FlutterSDK.Material.Inputborder.InputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide))
    {
        return default(InputBorder);
    }


    /// <Summary>
    /// Paint this input border on [canvas].
    ///
    /// The [rect] parameter bounds the [InputDecorator]'s container.
    ///
    /// The additional `gap` parameters reflect the state of the [InputDecorator]'s
    /// floating label. When an input decorator gains the focus, its label
    /// animates upwards, to make room for the input child. The [gapStart] and
    /// [gapExtent] parameters define a floating label width interval, and
    /// [gapPercentage] defines the animation's progress (0.0 to 1.0).
    /// </Summary>
    public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
    {
    }

    #endregion
}


public class _NoInputBorder : FlutterSDK.Material.Inputborder.InputBorder
{
    #region constructors
    public _NoInputBorder()
    : base(borderSide: BordersDefaultClass.BorderSide.None)

}
#endregion

#region fields
public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Material.Inputborder._NoInputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide)) => new _NoInputBorder();



public new FlutterSDK.Material.Inputborder._NoInputBorder Scale(double t) => new _NoInputBorder();



public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRect(rect);
}




public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRect(rect);
}




public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
{
}



#endregion
}


/// <Summary>
/// Draws a horizontal line at the bottom of an [InputDecorator]'s container and
/// defines the container's shape.
///
/// The input decorator's "container" is the optionally filled area above the
/// decorator's helper, error, and counter.
///
/// See also:
///
///  * [OutlineInputBorder], an [InputDecorator] border which draws a
///    rounded rectangle around the input decorator's container.
///  * [InputDecoration], which is used to configure an [InputDecorator].
/// </Summary>
public class UnderlineInputBorder : FlutterSDK.Material.Inputborder.InputBorder
{
    #region constructors
    public UnderlineInputBorder(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
    : base(borderSide: borderSide)

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Material.Inputborder.UnderlineInputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius))
{
    return new UnderlineInputBorder(borderSide: borderSide ?? this.BorderSide, borderRadius: borderRadius ?? this.BorderRadius);
}




public new FlutterSDK.Material.Inputborder.UnderlineInputBorder Scale(double t)
{
    return new UnderlineInputBorder(borderSide: BorderSide.Scale(t));
}




public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRect(Rect.FromLTWH(rect.Left, rect.Top, rect.Width, Math.Dart:mathDefaultClass.Max(0.0, rect.Height - BorderSide.Width)));
}




public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect));
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
{
    if (a is UnderlineInputBorder)
    {
        return new UnderlineInputBorder(borderSide: BordersDefaultClass.BorderSide.Lerp(((UnderlineInputBorder)a).BorderSide, BorderSide, t), borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(((UnderlineInputBorder)a).BorderRadius, BorderRadius, t));
    }

    return base.LerpFrom(a, t);
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
{
    if (b is UnderlineInputBorder)
    {
        return new UnderlineInputBorder(borderSide: BordersDefaultClass.BorderSide.Lerp(BorderSide, ((UnderlineInputBorder)b).BorderSide, t), borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(BorderRadius, ((UnderlineInputBorder)b).BorderRadius, t));
    }

    return base.LerpTo(b, t);
}




/// <Summary>
/// Draw a horizontal line at the bottom of [rect].
///
/// The [borderSide] defines the line's color and weight. The `textDirection`
/// `gap` and `textDirection` parameters are ignored.
/// </Summary>
public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
{
    if (BorderRadius.BottomLeft != Dart:uiDefaultClass.Radius.Zero || BorderRadius.BottomRight != Dart:uiDefaultClass.Radius.Zero)canvas.ClipPath(GetOuterPath(rect, textDirection: textDirection));
    canvas.DrawLine(rect.BottomLeft, rect.BottomRight, BorderSide.ToPaint());
}




public new bool Equals(@Object other)
{
    if (Dart:coreDefaultClass.Identical(this, other))return true;
    if (other.GetType() != GetType()) return false;
    return other is InputBorder && other.BorderSide == BorderSide;
}



#endregion
}


/// <Summary>
/// Draws a rounded rectangle around an [InputDecorator]'s container.
///
/// When the input decorator's label is floating, for example because its
/// input child has the focus, the label appears in a gap in the border outline.
///
/// The input decorator's "container" is the optionally filled area above the
/// decorator's helper, error, and counter.
///
/// See also:
///
///  * [UnderlineInputBorder], the default [InputDecorator] border which
///    draws a horizontal line at the bottom of the input decorator's container.
///  * [InputDecoration], which is used to configure an [InputDecorator].
/// </Summary>
public class OutlineInputBorder : FlutterSDK.Material.Inputborder.InputBorder
{
    #region constructors
    public OutlineInputBorder(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double gapPadding = 4.0)
    : base(borderSide: borderSide)

}
#endregion

#region fields
public virtual double GapPadding { get; set; }
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
public virtual bool IsOutline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private bool _CornersAreCircular(FlutterSDK.Painting.Borderradius.BorderRadius borderRadius)
{
    return borderRadius.TopLeft.x == borderRadius.TopLeft.y && borderRadius.BottomLeft.x == borderRadius.BottomLeft.y && borderRadius.TopRight.x == borderRadius.TopRight.y && borderRadius.BottomRight.x == borderRadius.BottomRight.y;
}




public new FlutterSDK.Material.Inputborder.OutlineInputBorder CopyWith(FlutterSDK.Painting.Borders.BorderSide borderSide = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double gapPadding = default(double))
{
    return new OutlineInputBorder(borderSide: borderSide ?? this.BorderSide, borderRadius: borderRadius ?? this.BorderRadius, gapPadding: gapPadding == default(double) ? this.gapPadding : gapPadding);
}




public new FlutterSDK.Material.Inputborder.OutlineInputBorder Scale(double t)
{
    return new OutlineInputBorder(borderSide: BorderSide.Scale(t), borderRadius: BorderRadius * t, gapPadding: GapPadding * t);
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
{
    if (a is OutlineInputBorder)
    {
        OutlineInputBorder outline = ((OutlineInputBorder)a);
        return new OutlineInputBorder(borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(outline.BorderRadius, BorderRadius, t), borderSide: BordersDefaultClass.BorderSide.Lerp(outline.BorderSide, BorderSide, t), gapPadding: outline.GapPadding);
    }

    return base.LerpFrom(a, t);
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
{
    if (b is OutlineInputBorder)
    {
        OutlineInputBorder outline = ((OutlineInputBorder)b);
        return new OutlineInputBorder(borderRadius: BorderradiusDefaultClass.BorderRadius.Lerp(BorderRadius, outline.BorderRadius, t), borderSide: BordersDefaultClass.BorderSide.Lerp(BorderSide, outline.BorderSide, t), gapPadding: outline.GapPadding);
    }

    return base.LerpTo(b, t);
}




public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect).Deflate(BorderSide.Width));
}




public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect));
}




private Path _GapBorderPath(Canvas canvas, FlutterBinding.UI.RRect center, double start, double extent)
{
    RRect scaledRRect = center.ScaleRadii();
    Rect tlCorner = Rect.FromLTWH(scaledRRect.Left, scaledRRect.Top, scaledRRect.TlRadiusX * 2.0, scaledRRect.TlRadiusY * 2.0);
    Rect trCorner = Rect.FromLTWH(scaledRRect.Right - scaledRRect.TrRadiusX * 2.0, scaledRRect.Top, scaledRRect.TrRadiusX * 2.0, scaledRRect.TrRadiusY * 2.0);
    Rect brCorner = Rect.FromLTWH(scaledRRect.Right - scaledRRect.BrRadiusX * 2.0, scaledRRect.Bottom - scaledRRect.BrRadiusY * 2.0, scaledRRect.BrRadiusX * 2.0, scaledRRect.BrRadiusY * 2.0);
    Rect blCorner = Rect.FromLTWH(scaledRRect.Left, scaledRRect.Bottom - scaledRRect.BlRadiusY * 2.0, scaledRRect.BlRadiusX * 2.0, scaledRRect.BlRadiusX * 2.0);
    double cornerArcSweep = Math.Dart:mathDefaultClass.Pi / 2.0;
double tlCornerArcSweep = start < scaledRRect.TlRadiusX ? Math.Dart : mathDefaultClass.Asin((start / scaledRRect.TlRadiusX).Clamp(-1.0, 1.0)):Math.Dart:mathDefaultClass.Pi / 2.0;
Path path = new Path();
new Path().AddArc(tlCorner, Math.Dart:mathDefaultClass.Pi, tlCornerArcSweep);
new Path().MoveTo(scaledRRect.Left + scaledRRect.TlRadiusX, scaledRRect.Top);
if (start > scaledRRect.TlRadiusX) path.LineTo(scaledRRect.Left + start, scaledRRect.Top);
double trCornerArcStart = (3 * Math.Dart:mathDefaultClass.Pi)/ 2.0;
double trCornerArcSweep = cornerArcSweep;
if (start + extent < scaledRRect.Width - scaledRRect.TrRadiusX)
{
    ;
    path.RelativeMoveTo(extent, 0.0);
    path.LineTo(scaledRRect.Right - scaledRRect.TrRadiusX, scaledRRect.Top);
    path.AddArc(trCorner, trCornerArcStart, trCornerArcSweep);
}
else if (start + extent < scaledRRect.Width)
{
    double dx = scaledRRect.Width - (start + extent);
    double sweep = Math.Dart:mathDefaultClass.Acos(dx / scaledRRect.TrRadiusX);
    path.AddArc(trCorner, trCornerArcStart + sweep, trCornerArcSweep - sweep);
}

return;
path.MoveTo(scaledRRect.Right, scaledRRect.Top + scaledRRect.TrRadiusY);
path.LineTo(scaledRRect.Right, scaledRRect.Bottom - scaledRRect.BrRadiusY);
path.AddArc(brCorner, 0.0, cornerArcSweep);
path.LineTo(scaledRRect.Left + scaledRRect.BlRadiusX, scaledRRect.Bottom);
path.AddArc(blCorner, Math.Dart:mathDefaultClass.Pi / 2.0, cornerArcSweep);
path.LineTo(scaledRRect.Left, scaledRRect.Top + scaledRRect.TlRadiusY);
}




/// <Summary>
/// Draw a rounded rectangle around [rect] using [borderRadius].
///
/// The [borderSide] defines the line's color and weight.
///
/// The top side of the rounded rectangle may be interrupted by a single gap
/// if [gapExtent] is non-null. In that case the gap begins at
/// `gapStart - gapPadding` (assuming that the [textDirection] is [TextDirection.ltr]).
/// The gap's width is `(gapPadding + gapExtent + gapPadding) * gapPercentage`.
/// </Summary>
public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, double gapStart = default(double), double gapExtent = 0.0, double gapPercentage = 0.0, TextDirection textDirection = default(TextDirection))
{



    Paint paint = BorderSide.ToPaint();
    RRect outer = BorderRadius.ToRRect(rect);
    RRect center = outer.Deflate(BorderSide.Width / 2.0);
    if (gapStart == null || gapExtent <= 0.0 || gapPercentage == 0.0)
    {
        canvas.DrawRRect(center, paint);
    }
    else
    {
        double extent = Dart:uiDefaultClass.LerpDouble(0.0, gapExtent + GapPadding * 2.0, gapPercentage);
        switch (textDirection) { case TextDirection.Rtl: Path path = _GapBorderPath(canvas, center, Math.Dart:mathDefaultClass.Max(0.0, gapStart + GapPadding - extent), extent); canvas.DrawPath(path, paint); break; case TextDirection.Ltr: Path path = _GapBorderPath(canvas, center, Math.Dart:mathDefaultClass.Max(0.0, gapStart - GapPadding), extent); canvas.DrawPath(path, paint); break; }
    }

}




public new bool Equals(@Object other)
{
    if (Dart:coreDefaultClass.Identical(this, other))return true;
    if (other.GetType() != GetType()) return false;
    return other is OutlineInputBorder && other.BorderSide == BorderSide && other.BorderRadius == BorderRadius && other.GapPadding == GapPadding;
}



#endregion
}

}
