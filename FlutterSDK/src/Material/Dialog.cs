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
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Dialog
{
    internal static class DialogDefaultClass
    {
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _DefaultInsetPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        internal static FlutterSDK.Widgets.Framework.Widget _BuildMaterialDialogTransitions(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new FadeTransition(opacity: new CurvedAnimation(parent: animation, curve: CurvesDefaultClass.Curves.EaseOut), child: child);
        }



        /// <Summary>
        /// Displays a Material dialog above the current contents of the app, with
        /// Material entrance and exit animations, modal barrier color, and modal
        /// barrier behavior (dialog is dismissible with a tap on the barrier).
        ///
        /// This function takes a `builder` which typically builds a [Dialog] widget.
        /// Content below the dialog is dimmed with a [ModalBarrier]. The widget
        /// returned by the `builder` does not share a context with the location that
        /// `showDialog` is originally called from. Use a [StatefulBuilder] or a
        /// custom [StatefulWidget] if the dialog needs to update dynamically.
        ///
        /// The `child` argument is deprecated, and should be replaced with `builder`.
        ///
        /// The `context` argument is used to look up the [Navigator] and [Theme] for
        /// the dialog. It is only used when the method is called. Its corresponding
        /// widget can be safely removed from the tree before the dialog is closed.
        ///
        /// The `useRootNavigator` argument is used to determine whether to push the
        /// dialog to the [Navigator] furthest from or nearest to the given `context`.
        /// By default, `useRootNavigator` is `true` and the dialog route created by
        /// this method is pushed to the root navigator.
        ///
        /// The `routeSettings` argument is passed to [showGeneralDialog],
        /// see [RouteSettings] for details.
        ///
        /// If the application has multiple [Navigator] objects, it may be necessary to
        /// call `Navigator.of(context, rootNavigator: true).pop(result)` to close the
        /// dialog rather than just `Navigator.pop(context, result)`.
        ///
        /// Returns a [Future] that resolves to the value (if any) that was passed to
        /// [Navigator.pop] when the dialog was closed.
        ///
        /// See also:
        ///
        ///  * [AlertDialog], for dialogs that have a row of buttons below a body.
        ///  * [SimpleDialog], which handles the scrolling of the contents and does
        ///    not show buttons below its body.
        ///  * [Dialog], on which [SimpleDialog] and [AlertDialog] are based.
        ///  * [showCupertinoDialog], which displays an iOS-style dialog.
        ///  * [showGeneralDialog], which allows for customization of the dialog popup.
        ///  * <https://material.io/design/components/dialogs.html>
        /// </Summary>
        internal static Future<T> ShowDialog<T>(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), bool barrierDismissible = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {



            ThemeData theme = ThemeDefaultClass.Theme.Of(context, shadowThemeOnly: true);
            return RoutesDefaultClass.ShowGeneralDialog(context: context, pageBuilder: (BuildContext buildContext, Animation<double> animation, Animation<double> secondaryAnimation) =>
            {
                Widget pageChild = child ?? new Builder(builder: builder);
                return new SafeArea(child: new Builder(builder: (BuildContext context) =>
                {
                    return theme != null ? new Theme(data: theme, child: pageChild) : pageChild;
                }
                ));
            }
            , barrierDismissible: barrierDismissible, barrierLabel: MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).ModalBarrierDismissLabel, barrierColor: ColorsDefaultClass.Colors.Black54, transitionDuration: new TimeSpan(milliseconds: 150), transitionBuilder: DialogDefaultClass._BuildMaterialDialogTransitions, useRootNavigator: useRootNavigator, routeSettings: routeSettings);
        }



    }

    /// <Summary>
    /// A material design dialog.
    ///
    /// This dialog widget does not have any opinion about the contents of the
    /// dialog. Rather than using this widget directly, consider using [AlertDialog]
    /// or [SimpleDialog], which implement specific kinds of material design
    /// dialogs.
    ///
    /// See also:
    ///
    ///  * [AlertDialog], for dialogs that have a message and some buttons.
    ///  * [SimpleDialog], for dialogs that offer a variety of options.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * <https://material.io/design/components/dialogs.html>
    /// </Summary>
    public class Dialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a dialog.
        ///
        /// Typically used in conjunction with [showDialog].
        /// </Summary>
        public Dialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), TimeSpan insetAnimationDuration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve insetAnimationCurve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Painting.Edgeinsets.EdgeInsets insetPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.InsetAnimationDuration = insetAnimationDuration;
            this.InsetAnimationCurve = insetAnimationCurve;
            this.InsetPadding = insetPadding;
            this.ClipBehavior = clipBehavior;
            this.Shape = shape;
            this.Child = child;
        }
        /// <Summary>
        /// {@template flutter.material.dialog.backgroundColor}
        /// The background color of the surface of this [Dialog].
        ///
        /// This sets the [Material.color] on this [Dialog]'s [Material].
        ///
        /// If `null`, [ThemeData.cardColor] is used.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// {@template flutter.material.dialog.elevation}
        /// The z-coordinate of this [Dialog].
        ///
        /// If null then [DialogTheme.elevation] is used, and if that's null then the
        /// dialog's elevation is 24.0.
        /// {@endtemplate}
        /// {@macro flutter.material.material.elevation}
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// {@template flutter.material.dialog.insetAnimationDuration}
        /// The duration of the animation to show when the system keyboard intrudes
        /// into the space that the dialog is placed in.
        ///
        /// Defaults to 100 milliseconds.
        /// {@endtemplate}
        /// </Summary>
        public virtual TimeSpan InsetAnimationDuration { get; set; }
        /// <Summary>
        /// {@template flutter.material.dialog.insetAnimationCurve}
        /// The curve to use for the animation shown when the system keyboard intrudes
        /// into the space that the dialog is placed in.
        ///
        /// Defaults to [Curves.decelerate].
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve InsetAnimationCurve { get; set; }
        /// <Summary>
        /// {@template flutter.material.dialog.insetPadding}
        /// The amount of padding added to [MediaQueryData.viewInsets] on the outside
        /// of the dialog. This defines the minimum space between the screen's edges
        /// and the dialog.
        ///
        /// Defaults to `EdgeInsets.symmetric(horizontal: 40.0, vertical: 24.0)`.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets InsetPadding { get; set; }
        /// <Summary>
        /// {@template flutter.material.dialog.clipBehavior}
        /// Controls how the contents of the dialog are clipped (or not) to the given
        /// [shape].
        ///
        /// See the enum [Clip] for details of all possible options and their common
        /// use cases.
        ///
        /// Defaults to [Clip.none], and must not be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        /// <Summary>
        /// {@template flutter.material.dialog.shape}
        /// The shape of this dialog's border.
        ///
        /// Defines the dialog's [Material.shape].
        ///
        /// The default shape is a [RoundedRectangleBorder] with a radius of 2.0.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        internal virtual FlutterSDK.Painting.Roundedrectangleborder.RoundedRectangleBorder _DefaultDialogShape { get; set; }
        internal virtual double _DefaultElevation { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            DialogTheme dialogTheme = DialogthemeDefaultClass.DialogTheme.Of(context);
            EdgeInsets effectivePadding = MediaqueryDefaultClass.MediaQuery.Of(context).ViewInsets + (InsetPadding ?? EdgeInsets.All(0.0));
            return new AnimatedPadding(padding: effectivePadding, duration: InsetAnimationDuration, curve: InsetAnimationCurve, child: MediaQuery.RemoveViewInsets(removeLeft: true, removeTop: true, removeRight: true, removeBottom: true, context: context, child: new Center(child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: 280.0), child: new Material(color: BackgroundColor ?? dialogTheme.BackgroundColor ?? ThemeDefaultClass.Theme.Of(context).DialogBackgroundColor, elevation: elevation == default(double) ? dialogTheme.elevation : elevation ?? _DefaultElevation, shape: Shape ?? dialogTheme.Shape ?? _DefaultDialogShape, type: MaterialType.Card, clipBehavior: ClipBehavior, child: Child)))));
        }



    }


    /// <Summary>
    /// A material design alert dialog.
    ///
    /// An alert dialog informs the user about situations that require
    /// acknowledgement. An alert dialog has an optional title and an optional list
    /// of actions. The title is displayed above the content and the actions are
    /// displayed below the content.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=75CsnyRXf5I}
    ///
    /// If the content is too large to fit on the screen vertically, the dialog will
    /// display the title and the actions and let the content overflow, which is
    /// rarely desired. Consider using a scrolling widget for [content], such as
    /// [SingleChildScrollView], to avoid overflow. (However, be aware that since
    /// [AlertDialog] tries to size itself using the intrinsic dimensions of its
    /// children, widgets such as [ListView], [GridView], and [CustomScrollView],
    /// which use lazy viewports, will not work. If this is a problem, consider
    /// using [Dialog] directly.)
    ///
    /// For dialogs that offer the user a choice between several options, consider
    /// using a [SimpleDialog].
    ///
    /// Typically passed as the child widget to [showDialog], which displays the
    /// dialog.
    ///
    /// {@animation 350 622 https://flutter.github.io/assets-for-api-docs/assets/material/alert_dialog.mp4}
    ///
    /// {@tool snippet}
    ///
    /// This snippet shows a method in a [State] which, when called, displays a dialog box
    /// and returns a [Future] that completes when the dialog is dismissed.
    ///
    /// ```dart
    /// Future<void> _showMyDialog() async {
    ///   return showDialog<void>(
    ///     context: context,
    ///     barrierDismissible: false, // user must tap button!
    ///     builder: (BuildContext context) {
    ///       return AlertDialog(
    ///         title: Text('AlertDialog Title'),
    ///         content: SingleChildScrollView(
    ///           child: ListBody(
    ///             children: <Widget>[
    ///               Text('This is a demo alert dialog.'),
    ///               Text('Would you like to approve of this message?'),
    ///             ],
    ///           ),
    ///         ),
    ///         actions: <Widget>[
    ///           FlatButton(
    ///             child: Text('Approve'),
    ///             onPressed: () {
    ///               Navigator.of(context).pop();
    ///             },
    ///           ),
    ///         ],
    ///       );
    ///     },
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SimpleDialog], which handles the scrolling of the contents but has no [actions].
    ///  * [Dialog], on which [AlertDialog] and [SimpleDialog] are based.
    ///  * [CupertinoAlertDialog], an iOS-styled alert dialog.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * <https://material.io/design/components/dialogs.html#alert-dialog>
    /// </Summary>
    public class AlertDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an alert dialog.
        ///
        /// Typically used in conjunction with [showDialog].
        ///
        /// The [contentPadding] must not be null. The [titlePadding] defaults to
        /// null, which implies a default that depends on the values of the other
        /// properties. See the documentation of [titlePadding] for details.
        /// </Summary>
        public AlertDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry titlePadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Textstyle.TextStyle titleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Textstyle.TextStyle contentTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry actionsPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Basictypes.VerticalDirection actionsOverflowDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), double actionsOverflowButtonSpacing = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry buttonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), string semanticLabel = default(string), FlutterSDK.Painting.Edgeinsets.EdgeInsets insetPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool scrollable = false)
        : base(key: key)
        {
            this.Title = title;
            this.TitlePadding = titlePadding;
            this.TitleTextStyle = titleTextStyle;
            this.Content = content;
            this.ContentPadding = contentPadding;
            this.ContentTextStyle = contentTextStyle;
            this.Actions = actions;
            this.ActionsPadding = actionsPadding;
            this.ActionsOverflowDirection = actionsOverflowDirection;
            this.ActionsOverflowButtonSpacing = actionsOverflowButtonSpacing;
            this.ButtonPadding = buttonPadding;
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.SemanticLabel = semanticLabel;
            this.InsetPadding = insetPadding;
            this.ClipBehavior = clipBehavior;
            this.Shape = shape;
            this.Scrollable = scrollable;
        }
        /// <Summary>
        /// The (optional) title of the dialog is displayed in a large font at the top
        /// of the dialog.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// Padding around the title.
        ///
        /// If there is no title, no padding will be provided. Otherwise, this padding
        /// is used.
        ///
        /// This property defaults to providing 24 pixels on the top, left, and right
        /// of the title. If the [content] is not null, then no bottom padding is
        /// provided (but see [contentPadding]). If it _is_ null, then an extra 20
        /// pixels of bottom padding is added to separate the [title] from the
        /// [actions].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry TitlePadding { get; set; }
        /// <Summary>
        /// Style for the text in the [title] of this [AlertDialog].
        ///
        /// If null, [DialogTheme.titleTextStyle] is used, if that's null, defaults to
        /// [ThemeData.textTheme.headline6].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TitleTextStyle { get; set; }
        /// <Summary>
        /// The (optional) content of the dialog is displayed in the center of the
        /// dialog in a lighter font.
        ///
        /// Typically this is a [SingleChildScrollView] that contains the dialog's
        /// message. As noted in the [AlertDialog] documentation, it's important
        /// to use a [SingleChildScrollView] if there's any risk that the content
        /// will not fit.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
        /// <Summary>
        /// Padding around the content.
        ///
        /// If there is no content, no padding will be provided. Otherwise, padding of
        /// 20 pixels is provided above the content to separate the content from the
        /// title, and padding of 24 pixels is provided on the left, right, and bottom
        /// to separate the content from the other edges of the dialog.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        /// <Summary>
        /// Style for the text in the [content] of this [AlertDialog].
        ///
        /// If null, [DialogTheme.contentTextStyle] is used, if that's null, defaults
        /// to [ThemeData.textTheme.subtitle1].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ContentTextStyle { get; set; }
        /// <Summary>
        /// The (optional) set of actions that are displayed at the bottom of the
        /// dialog.
        ///
        /// Typically this is a list of [FlatButton] widgets.
        ///
        /// These widgets will be wrapped in a [ButtonBar], which introduces 8 pixels
        /// of padding on each side.
        ///
        /// If the [title] is not null but the [content] _is_ null, then an extra 20
        /// pixels of padding is added above the [ButtonBar] to separate the [title]
        /// from the [actions].
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        /// <Summary>
        /// Padding around the set of [actions] at the bottom of the dialog.
        ///
        /// Typically used to provide padding to the button bar between the button bar
        /// and the edges of the dialog.
        ///
        /// If are no [actions], then no padding will be included. The padding around
        /// the button bar defaults to zero. It is also important to note that
        /// [buttonPadding] may contribute to the padding on the edges of [actions] as
        /// well.
        ///
        /// {@tool snippet}
        /// This is an example of a set of actions aligned with the content widget.
        /// ```dart
        /// AlertDialog(
        ///   title: Text('Title'),
        ///   content: Container(width: 200, height: 200, color: Colors.green),
        ///   actions: <Widget>[
        ///     RaisedButton(onPressed: () {}, child: Text('Button 1')),
        ///     RaisedButton(onPressed: () {}, child: Text('Button 2')),
        ///   ],
        ///   actionsPadding: EdgeInsets.symmetric(horizontal: 8.0),
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        /// * [ButtonBar], which [actions] configures to lay itself out.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ActionsPadding { get; set; }
        /// <Summary>
        /// The vertical direction of [actions] if the children overflow
        /// horizontally.
        ///
        /// If the dialog's [actions] do not fit into a single row, then they
        /// are arranged in a column. The first action is at the top of the
        /// column if this property is set to [VerticalDirection.down], since it
        /// "starts" at the top and "ends" at the bottom. On the other hand,
        /// the first action will be at the bottom of the column if this
        /// property is set to [VerticalDirection.up], since it "starts" at the
        /// bottom and "ends" at the top.
        ///
        /// If null then it will use the surrounding
        /// [ButtonBarTheme.overflowDirection]. If that is null, it will
        /// default to [VerticalDirection.down].
        ///
        /// See also:
        ///
        /// * [ButtonBar], which [actions] configures to lay itself out.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection ActionsOverflowDirection { get; set; }
        /// <Summary>
        /// The spacing between [actions] when the button bar overflows.
        ///
        /// If the widgets in [actions] do not fit into a single row, they are
        /// arranged into a column. This parameter provides additional
        /// vertical space in between buttons when it does overflow.
        ///
        /// Note that the button spacing may appear to be more than
        /// the value provided. This is because most buttons adhere to the
        /// [MaterialTapTargetSize] of 48px. So, even though a button
        /// might visually be 36px in height, it might still take up to
        /// 48px vertically.
        ///
        /// If null then no spacing will be added in between buttons in
        /// an overflow state.
        /// </Summary>
        public virtual double ActionsOverflowButtonSpacing { get; set; }
        /// <Summary>
        /// The padding that surrounds each button in [actions].
        ///
        /// This is different from [actionsPadding], which defines the padding
        /// between the entire button bar and the edges of the dialog.
        ///
        /// If this property is null, then it will use the surrounding
        /// [ButtonBarTheme.buttonPadding]. If that is null, it will default to
        /// 8.0 logical pixels on the left and right.
        ///
        /// See also:
        ///
        /// * [ButtonBar], which [actions] configures to lay itself out.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ButtonPadding { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.backgroundColor}
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.elevation}
        /// {@macro flutter.material.material.elevation}
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The semantic label of the dialog used by accessibility frameworks to
        /// announce screen transitions when the dialog is opened and closed.
        ///
        /// If this label is not provided, a semantic label will be inferred from the
        /// [title] if it is not null.  If there is no title, the label will be taken
        /// from [MaterialLocalizations.alertDialogLabel].
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.isRouteName], for a description of how this
        ///    value is used.
        /// </Summary>
        public virtual string SemanticLabel { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.insetPadding}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets InsetPadding { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.clipBehavior}
        /// </Summary>
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.shape}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// Determines whether the [title] and [content] widgets are wrapped in a
        /// scrollable.
        ///
        /// This configuration is used when the [title] and [content] are expected
        /// to overflow. Both [title] and [content] are wrapped in a scroll view,
        /// allowing all overflowed content to be visible while still showing the
        /// button bar.
        /// </Summary>
        public virtual bool Scrollable { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            DialogTheme dialogTheme = DialogthemeDefaultClass.DialogTheme.Of(context);
            string label = SemanticLabel;
            if (Title == null)
            {
                switch (theme.Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: label = SemanticLabel; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: label = SemanticLabel ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.AlertDialogLabel; }
            }

            Widget titleWidget = default(Widget);
            Widget contentWidget = default(Widget);
            Widget actionsWidget = default(Widget);
            if (Title != null) titleWidget = new Padding(padding: TitlePadding ?? EdgeInsets.FromLTRB(24.0, 24.0, 24.0, Content == null ? 20.0 : 0.0), child: new DefaultTextStyle(style: TitleTextStyle ?? dialogTheme.TitleTextStyle ?? theme.TextTheme.Headline6, child: new Semantics(child: Title, namesRoute: true, container: true)));
            if (Content != null) contentWidget = new Padding(padding: ContentPadding, child: new DefaultTextStyle(style: ContentTextStyle ?? dialogTheme.ContentTextStyle ?? theme.TextTheme.Subtitle1, child: Content));
            if (Actions != null) actionsWidget = new Padding(padding: ActionsPadding, child: new ButtonBar(buttonPadding: ButtonPadding, overflowDirection: ActionsOverflowDirection, overflowButtonSpacing: ActionsOverflowButtonSpacing, children: Actions));
            List<Widget> columnChildren = default(List<Widget>);
            if (Scrollable)
            {
                columnChildren = new List<Widget>() { };
            }
            else
            {
                columnChildren = new List<Widget>() { };
            }

            Widget dialogChild = new IntrinsicWidth(child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: columnChildren));
            if (label != null) dialogChild = new Semantics(namesRoute: true, label: label, child: dialogChild);
            return new Dialog(backgroundColor: BackgroundColor, elevation: Elevation, insetPadding: InsetPadding, clipBehavior: ClipBehavior, shape: Shape, child: dialogChild);
        }



    }


    /// <Summary>
    /// An option used in a [SimpleDialog].
    ///
    /// A simple dialog offers the user a choice between several options. This
    /// widget is commonly used to represent each of the options. If the user
    /// selects this option, the widget will call the [onPressed] callback, which
    /// typically uses [Navigator.pop] to close the dialog.
    ///
    /// The padding on a [SimpleDialogOption] is configured to combine with the
    /// default [SimpleDialog.contentPadding] so that each option ends up 8 pixels
    /// from the other vertically, with 20 pixels of spacing between the dialog's
    /// title and the first option, and 24 pixels of spacing between the last option
    /// and the bottom of the dialog.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// SimpleDialogOption(
    ///   onPressed: () { Navigator.pop(context, Department.treasury); },
    ///   child: const Text('Treasury department'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SimpleDialog], for a dialog in which to use this widget.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * [FlatButton], which are commonly used as actions in other kinds of
    ///    dialogs, such as [AlertDialog]s.
    ///  * <https://material.io/design/components/dialogs.html#simple-dialog>
    /// </Summary>
    public class SimpleDialogOption : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an option for a [SimpleDialog].
        /// </Summary>
        public SimpleDialogOption(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPressed = onPressed;
            this.Padding = padding;
            this.Child = child;
        }
        /// <Summary>
        /// The callback that is called when this option is selected.
        ///
        /// If this is set to null, the option cannot be selected.
        ///
        /// When used in a [SimpleDialog], this will typically call [Navigator.pop]
        /// with a value for [showDialog] to complete its future with.
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The amount of space to surround the [child] with.
        ///
        /// Defaults to EdgeInsets.symmetric(vertical: 8.0, horizontal: 24.0).
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new InkWell(onTap: OnPressed, child: new Padding(padding: Padding ?? EdgeInsets.Symmetric(vertical: 8.0, horizontal: 24.0), child: Child));
        }



    }


    /// <Summary>
    /// A simple material design dialog.
    ///
    /// A simple dialog offers the user a choice between several options. A simple
    /// dialog has an optional title that is displayed above the choices.
    ///
    /// Choices are normally represented using [SimpleDialogOption] widgets. If
    /// other widgets are used, see [contentPadding] for notes regarding the
    /// conventions for obtaining the spacing expected by Material Design.
    ///
    /// For dialogs that inform the user about a situation, consider using an
    /// [AlertDialog].
    ///
    /// Typically passed as the child widget to [showDialog], which displays the
    /// dialog.
    ///
    /// {@animation 350 622 https://flutter.github.io/assets-for-api-docs/assets/material/simple_dialog.mp4}
    ///
    /// {@tool snippet}
    ///
    /// In this example, the user is asked to select between two options. These
    /// options are represented as an enum. The [showDialog] method here returns
    /// a [Future] that completes to a value of that enum. If the user cancels
    /// the dialog (e.g. by hitting the back button on Android, or tapping on the
    /// mask behind the dialog) then the future completes with the null value.
    ///
    /// The return value in this example is used as the index for a switch statement.
    /// One advantage of using an enum as the return value and then using that to
    /// drive a switch statement is that the analyzer will flag any switch statement
    /// that doesn't mention every value in the enum.
    ///
    /// ```dart
    /// Future<void> _askedToLead() async {
    ///   switch (await showDialog<Department>(
    ///     context: context,
    ///     builder: (BuildContext context) {
    ///       return SimpleDialog(
    ///         title: const Text('Select assignment'),
    ///         children: <Widget>[
    ///           SimpleDialogOption(
    ///             onPressed: () { Navigator.pop(context, Department.treasury); },
    ///             child: const Text('Treasury department'),
    ///           ),
    ///           SimpleDialogOption(
    ///             onPressed: () { Navigator.pop(context, Department.state); },
    ///             child: const Text('State department'),
    ///           ),
    ///         ],
    ///       );
    ///     }
    ///   )) {
    ///     case Department.treasury:
    ///       // Let's go.
    ///       // ...
    ///     break;
    ///     case Department.state:
    ///       // ...
    ///     break;
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SimpleDialogOption], which are options used in this type of dialog.
    ///  * [AlertDialog], for dialogs that have a row of buttons below the body.
    ///  * [Dialog], on which [SimpleDialog] and [AlertDialog] are based.
    ///  * [showDialog], which actually displays the dialog and returns its result.
    ///  * <https://material.io/design/components/dialogs.html#simple-dialog>
    /// </Summary>
    public class SimpleDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a simple dialog.
        ///
        /// Typically used in conjunction with [showDialog].
        ///
        /// The [titlePadding] and [contentPadding] arguments must not be null.
        /// </Summary>
        public SimpleDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry titlePadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double elevation = default(double), string semanticLabel = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Title = title;
            this.TitlePadding = titlePadding;
            this.Children = children;
            this.ContentPadding = contentPadding;
            this.BackgroundColor = backgroundColor;
            this.Elevation = elevation;
            this.SemanticLabel = semanticLabel;
            this.Shape = shape;
        }
        /// <Summary>
        /// The (optional) title of the dialog is displayed in a large font at the top
        /// of the dialog.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// Padding around the title.
        ///
        /// If there is no title, no padding will be provided.
        ///
        /// By default, this provides the recommend Material Design padding of 24
        /// pixels around the left, top, and right edges of the title.
        ///
        /// See [contentPadding] for the conventions regarding padding between the
        /// [title] and the [children].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry TitlePadding { get; set; }
        /// <Summary>
        /// The (optional) content of the dialog is displayed in a
        /// [SingleChildScrollView] underneath the title.
        ///
        /// Typically a list of [SimpleDialogOption]s.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        /// <Summary>
        /// Padding around the content.
        ///
        /// By default, this is 12 pixels on the top and 16 pixels on the bottom. This
        /// is intended to be combined with children that have 24 pixels of padding on
        /// the left and right, and 8 pixels of padding on the top and bottom, so that
        /// the content ends up being indented 20 pixels from the title, 24 pixels
        /// from the bottom, and 24 pixels from the sides.
        ///
        /// The [SimpleDialogOption] widget uses such padding.
        ///
        /// If there is no [title], the [contentPadding] should be adjusted so that
        /// the top padding ends up being 24 pixels.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.backgroundColor}
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.elevation}
        /// {@macro flutter.material.material.elevation}
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The semantic label of the dialog used by accessibility frameworks to
        /// announce screen transitions when the dialog is opened and closed.
        ///
        /// If this label is not provided, a semantic label will be inferred from the
        /// [title] if it is not null.  If there is no title, the label will be taken
        /// from [MaterialLocalizations.dialogLabel].
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.isRouteName], for a description of how this
        ///    value is used.
        /// </Summary>
        public virtual string SemanticLabel { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dialog.shape}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            string label = SemanticLabel;
            if (Title == null)
            {
                switch (theme.Platform) { case TargetPlatform.MacOS: case TargetPlatform.IOS: label = SemanticLabel; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: label = SemanticLabel ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.DialogLabel; }
            }

            Widget dialogChild = new IntrinsicWidth(stepWidth: 56.0, child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: 280.0), child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { })));
            if (label != null) dialogChild = new Semantics(namesRoute: true, label: label, child: dialogChild);
            return new Dialog(backgroundColor: BackgroundColor, elevation: Elevation, shape: Shape, child: dialogChild);
        }



    }

}
