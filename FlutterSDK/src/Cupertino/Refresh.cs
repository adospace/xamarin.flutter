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
namespace FlutterSDK.Cupertino.Refresh
{
    /// <Summary>
    /// Signature for a builder that can create a different widget to show in the
    /// refresh indicator space depending on the current state of the refresh
    /// control and the space available.
    ///
    /// The `refreshTriggerPullDistance` and `refreshIndicatorExtent` parameters are
    /// the same values passed into the [CupertinoSliverRefreshControl].
    ///
    /// The `pulledExtent` parameter is the currently available space either from
    /// overscrolling or as held by the sliver during refresh.
    /// </Summary>
    public delegate FlutterSDK.Widgets.Framework.Widget RefreshControlIndicatorBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Refresh.RefreshIndicatorMode refreshState, double pulledExtent, double refreshTriggerPullDistance, double refreshIndicatorExtent);
    /// <Summary>
    /// A callback function that's invoked when the [CupertinoSliverRefreshControl] is
    /// pulled a `refreshTriggerPullDistance`. Must return a [Future]. Upon
    /// completion of the [Future], the [CupertinoSliverRefreshControl] enters the
    /// [RefreshIndicatorMode.done] state and will start to go away.
    /// </Summary>
    public delegate Future<object> RefreshCallback();
    internal static class RefreshDefaultClass
    {
    }

    public class _CupertinoSliverRefresh : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _CupertinoSliverRefresh(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double refreshIndicatorLayoutExtent = 0.0, bool hasLayoutExtent = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.RefreshIndicatorLayoutExtent = refreshIndicatorLayoutExtent;
            this.HasLayoutExtent = hasLayoutExtent;
        }
        public virtual double RefreshIndicatorLayoutExtent { get; set; }
        public virtual bool HasLayoutExtent { get; set; }

        public new FlutterSDK.Cupertino.Refresh._RenderCupertinoSliverRefresh CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderCupertinoSliverRefresh(refreshIndicatorExtent: RefreshIndicatorLayoutExtent, hasLayoutExtent: HasLayoutExtent);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Refresh._RenderCupertinoSliverRefresh renderObject)
        {
            ..RefreshIndicatorLayoutExtent = RefreshIndicatorLayoutExtent..HasLayoutExtent = HasLayoutExtent;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..RefreshIndicatorLayoutExtent = RefreshIndicatorLayoutExtent..HasLayoutExtent = HasLayoutExtent;
        }



    }


    public class _RenderCupertinoSliverRefresh : FlutterSDK.Rendering.Sliver.RenderSliver, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>
    {
        public _RenderCupertinoSliverRefresh(double refreshIndicatorExtent = default(double), bool hasLayoutExtent = default(bool), FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base()
        {

            this.Child = child;
        }


        internal virtual double _RefreshIndicatorExtent { get; set; }
        internal virtual bool _HasLayoutExtent { get; set; }
        public virtual double LayoutExtentOffsetCompensation { get; set; }
        public virtual double RefreshIndicatorLayoutExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasLayoutExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void PerformLayout()
        {
            SliverConstraints constraints = this.Constraints;


            double layoutExtent = (_HasLayoutExtent ? 1.0 : 0.0) * _RefreshIndicatorExtent;
            if (layoutExtent != LayoutExtentOffsetCompensation)
            {
                Geometry = new SliverGeometry(scrollOffsetCorrection: layoutExtent - LayoutExtentOffsetCompensation);
                LayoutExtentOffsetCompensation = layoutExtent;
                return;
            }

            bool active = constraints.Overlap < 0.0 || layoutExtent > 0.0;
            double overscrolledExtent = constraints.Overlap < 0.0 ? constraints.Overlap.Abs() : 0.0;
            Child.Layout(constraints.AsBoxConstraints(maxExtent: layoutExtent + overscrolledExtent), parentUsesSize: true);
            if (active)
            {
                Geometry = new SliverGeometry(scrollExtent: layoutExtent, paintOrigin: -overscrolledExtent - constraints.ScrollOffset, paintExtent: Dart.Math.MathDefaultClass.Max(Dart.Math.MathDefaultClass.Max(Child.Size.Height, layoutExtent) - constraints.ScrollOffset, 0.0), maxPaintExtent: Dart.Math.MathDefaultClass.Max(Dart.Math.MathDefaultClass.Max(Child.Size.Height, layoutExtent) - constraints.ScrollOffset, 0.0), layoutExtent: Dart.Math.MathDefaultClass.Max(layoutExtent - constraints.ScrollOffset, 0.0));
            }
            else
            {
                Geometry = SliverDefaultClass.SliverGeometry.Zero;
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext paintContext, FlutterBinding.UI.Offset offset)
        {
            if (Constraints.Overlap < 0.0 || Constraints.ScrollOffset + Child.Size.Height > 0)
            {
                paintContext.PaintChild(Child, offset);
            }

        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {
        }



    }


    /// <Summary>
    /// A sliver widget implementing the iOS-style pull to refresh content control.
    ///
    /// When inserted as the first sliver in a scroll view or behind other slivers
    /// that still lets the scrollable overscroll in front of this sliver (such as
    /// the [CupertinoSliverNavigationBar], this widget will:
    ///
    ///  * Let the user draw inside the overscrolled area via the passed in [builder].
    ///  * Trigger the provided [onRefresh] function when overscrolled far enough to
    ///    pass [refreshTriggerPullDistance].
    ///  * Continue to hold [refreshIndicatorExtent] amount of space for the [builder]
    ///    to keep drawing inside of as the [Future] returned by [onRefresh] processes.
    ///  * Scroll away once the [onRefresh] [Future] completes.
    ///
    /// The [builder] function will be informed of the current [RefreshIndicatorMode]
    /// when invoking it, except in the [RefreshIndicatorMode.inactive] state when
    /// no space is available and nothing needs to be built. The [builder] function
    /// will otherwise be continuously invoked as the amount of space available
    /// changes from overscroll, as the sliver scrolls away after the [onRefresh]
    /// task is done, etc.
    ///
    /// Only one refresh can be triggered until the previous refresh has completed
    /// and the indicator sliver has retracted at least 90% of the way back.
    ///
    /// Can only be used in downward-scrolling vertical lists that overscrolls. In
    /// other words, refreshes can't be triggered with [Scrollable]s using
    /// [ClampingScrollPhysics] which is the default on Android. To allow overscroll
    /// on Android, use an overscrolling physics such as [BouncingScrollPhysics].
    /// This can be done via:
    ///
    ///  * Providing a [BouncingScrollPhysics] (possibly in combination with a
    ///    [AlwaysScrollableScrollPhysics]) while constructing the scrollable.
    ///  * By inserting a [ScrollConfiguration] with [BouncingScrollPhysics] above
    ///    the scrollable.
    ///  * By using [CupertinoApp], which always uses a [ScrollConfiguration]
    ///    with [BouncingScrollPhysics] regardless of platform.
    ///
    /// In a typical application, this sliver should be inserted between the app bar
    /// sliver such as [CupertinoSliverNavigationBar] and your main scrollable
    /// content's sliver.
    ///
    /// See also:
    ///
    ///  * [CustomScrollView], a typical sliver holding scroll view this control
    ///    should go into.
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/controls/refresh-content-controls/>
    ///  * [RefreshIndicator], a Material Design version of the pull-to-refresh
    ///    paradigm. This widget works differently than [RefreshIndicator] because
    ///    instead of being an overlay on top of the scrollable, the
    ///    [CupertinoSliverRefreshControl] is part of the scrollable and actively occupies
    ///    scrollable space.
    /// </Summary>
    public class CupertinoSliverRefreshControl : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Create a new refresh control for inserting into a list of slivers.
        ///
        /// The [refreshTriggerPullDistance] and [refreshIndicatorExtent] arguments
        /// must not be null and must be >= 0.
        ///
        /// The [builder] argument may be null, in which case no indicator UI will be
        /// shown but the [onRefresh] will still be invoked. By default, [builder]
        /// shows a [CupertinoActivityIndicator].
        ///
        /// The [onRefresh] argument will be called when pulled far enough to trigger
        /// a refresh.
        /// </Summary>
        public CupertinoSliverRefreshControl(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double refreshTriggerPullDistance = default(double), double refreshIndicatorExtent = default(double), FlutterSDK.Cupertino.Refresh.RefreshControlIndicatorBuilder builder = default(FlutterSDK.Cupertino.Refresh.RefreshControlIndicatorBuilder), FlutterSDK.Cupertino.Refresh.RefreshCallback onRefresh = default(FlutterSDK.Cupertino.Refresh.RefreshCallback))
        : base(key: key)
        {
            this.RefreshTriggerPullDistance = refreshTriggerPullDistance;
            this.RefreshIndicatorExtent = refreshIndicatorExtent;
            this.Builder = builder;
            this.OnRefresh = onRefresh;
        }
        /// <Summary>
        /// The amount of overscroll the scrollable must be dragged to trigger a reload.
        ///
        /// Must not be null, must be larger than 0.0 and larger than
        /// [refreshIndicatorExtent]. Defaults to 100px when not specified.
        ///
        /// When overscrolled past this distance, [onRefresh] will be called if not
        /// null and the [builder] will build in the [RefreshIndicatorMode.armed] state.
        /// </Summary>
        public virtual double RefreshTriggerPullDistance { get; set; }
        /// <Summary>
        /// The amount of space the refresh indicator sliver will keep holding while
        /// [onRefresh]'s [Future] is still running.
        ///
        /// Must not be null and must be positive, but can be 0.0, in which case the
        /// sliver will start retracting back to 0.0 as soon as the refresh is started.
        /// Defaults to 60px when not specified.
        ///
        /// Must be smaller than [refreshTriggerPullDistance], since the sliver
        /// shouldn't grow further after triggering the refresh.
        /// </Summary>
        public virtual double RefreshIndicatorExtent { get; set; }
        /// <Summary>
        /// A builder that's called as this sliver's size changes, and as the state
        /// changes.
        ///
        /// A default simple Twitter-style pull-to-refresh indicator is provided if
        /// not specified.
        ///
        /// Can be set to null, in which case nothing will be drawn in the overscrolled
        /// space.
        ///
        /// Will not be called when the available space is zero such as before any
        /// overscroll.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Refresh.RefreshControlIndicatorBuilder Builder { get; set; }
        /// <Summary>
        /// Callback invoked when pulled by [refreshTriggerPullDistance].
        ///
        /// If provided, must return a [Future] which will keep the indicator in the
        /// [RefreshIndicatorMode.refresh] state until the [Future] completes.
        ///
        /// Can be null, in which case a single frame of [RefreshIndicatorMode.armed]
        /// state will be drawn before going immediately to the [RefreshIndicatorMode.done]
        /// where the sliver will start retracting.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Refresh.RefreshCallback OnRefresh { get; set; }
        internal virtual double _DefaultRefreshTriggerPullDistance { get; set; }
        internal virtual double _DefaultRefreshIndicatorExtent { get; set; }

        /// <Summary>
        /// Retrieve the current state of the CupertinoSliverRefreshControl. The same as the
        /// state that gets passed into the [builder] function. Used for testing.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Refresh.RefreshIndicatorMode State(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _CupertinoSliverRefreshControlState state = context.FindAncestorStateOfType();
            return state.RefreshState;
        }




        /// <Summary>
        /// Builds a simple refresh indicator that fades in a bottom aligned down
        /// arrow before the refresh is triggered, a [CupertinoActivityIndicator]
        /// during the refresh and fades the [CupertinoActivityIndicator] away when
        /// the refresh is done.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildSimpleRefreshIndicator(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Cupertino.Refresh.RefreshIndicatorMode refreshState, double pulledExtent, double refreshTriggerPullDistance, double refreshIndicatorExtent)
        {
            Curve opacityCurve = new Interval(0.4, 0.8, curve: CurvesDefaultClass.Curves.EaseInOut);
            return new Align(alignment: AlignmentDefaultClass.Alignment.BottomCenter, child: new Padding(padding: EdgeInsets.Only(bottom: 16.0), child: refreshState == RefreshIndicatorMode.Drag ? new Opacity(opacity: opacityCurve.Transform(Dart.Math.MathDefaultClass.Min(pulledExtent / refreshTriggerPullDistance, 1.0)), child: new Icon(IconsDefaultClass.CupertinoIcons.Down_arrow, color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.InactiveGray, context), size: 36.0)) : new Opacity(opacity: opacityCurve.Transform(Dart.Math.MathDefaultClass.Min(pulledExtent / refreshIndicatorExtent, 1.0)), child: new CupertinoActivityIndicator(radius: 14.0))));
        }




        public new FlutterSDK.Cupertino.Refresh._CupertinoSliverRefreshControlState CreateState() => new _CupertinoSliverRefreshControlState();


    }


    public class _CupertinoSliverRefreshControlState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Refresh.CupertinoSliverRefreshControl>
    {
        public _CupertinoSliverRefreshControlState()
        { }
        internal virtual double _InactiveResetOverscrollFraction { get; set; }
        public virtual FlutterSDK.Cupertino.Refresh.RefreshIndicatorMode RefreshState { get; set; }
        public virtual Future<object> RefreshTask { get; set; }
        public virtual double LatestIndicatorBoxExtent { get; set; }
        public virtual bool HasSliverLayoutExtent { get; set; }

        public new void InitState()
        {
            base.InitState();
            RefreshState = RefreshIndicatorMode.Inactive;
        }




        public virtual FlutterSDK.Cupertino.Refresh.RefreshIndicatorMode TransitionNextState()
        {
            RefreshIndicatorMode nextState = default(RefreshIndicatorMode);
            void GoToDone()
            {
                nextState = RefreshIndicatorMode.Done;
                if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase == SchedulerPhase.Idle)
                {
                    SetState(() => =>HasSliverLayoutExtent = false);
                }
                else
                {
                    BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timestamp) =>
                    {
                        SetState(() => =>HasSliverLayoutExtent = false);
                    }
                    );
                }

            }

            switch (RefreshState)
            {
                case RefreshIndicatorMode.Inactive:
                    if (LatestIndicatorBoxExtent <= 0)
                    {
                        return RefreshIndicatorMode.Inactive;
                    }
                    else
                    {
                        nextState = RefreshIndicatorMode.Drag;
                    }
                    continue Drag; Drag:case RefreshIndicatorMode.Drag:
                    if (LatestIndicatorBoxExtent == 0)
                    {
                        return RefreshIndicatorMode.Inactive;
                    }
                    else if (LatestIndicatorBoxExtent < Widget.RefreshTriggerPullDistance)
                    {
                        return RefreshIndicatorMode.Drag;
                    }
                    else
                    {
                        if (Widget.OnRefresh != null)
                        {
                            HapticfeedbackDefaultClass.HapticFeedback.MediumImpact();
                            BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timestamp) =>
                            {
                                RefreshTask = Widget.OnRefresh();
                                Widget.OnRefresh().WhenComplete(() =>
                                {
                                    if (Mounted)
                                    {
                                        SetState(() => =>RefreshTask = null);
                                        RefreshState = TransitionNextState();
                                    }

                                }
                                );
                                SetState(() => =>HasSliverLayoutExtent = true);
                            }
                            );
                        }

                        return RefreshIndicatorMode.Armed;
                    }
                    break;
                case RefreshIndicatorMode.Armed:
                    if (RefreshState == RefreshIndicatorMode.Armed && RefreshTask == null)
                    {
                        GoToDone();
                        continue Done;
                    }
                    if (LatestIndicatorBoxExtent > Widget.RefreshIndicatorExtent)
                    {
                        return RefreshIndicatorMode.Armed;
                    }
                    else
                    {
                        nextState = RefreshIndicatorMode.Refresh;
                    }
                    continue Refresh; Refresh:case RefreshIndicatorMode.Refresh:
                    if (RefreshTask != null)
                    {
                        return RefreshIndicatorMode.Refresh;
                    }
                    else
                    {
                        GoToDone();
                    }
                    continue Done; Done:case RefreshIndicatorMode.Done:
                    if (LatestIndicatorBoxExtent > Widget.RefreshTriggerPullDistance * _InactiveResetOverscrollFraction)
                    {
                        return RefreshIndicatorMode.Done;
                    }
                    else
                    {
                        nextState = RefreshIndicatorMode.Inactive;
                    }
                    break;
            }
            return nextState;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _CupertinoSliverRefresh(refreshIndicatorLayoutExtent: Widget.RefreshIndicatorExtent, hasLayoutExtent: HasSliverLayoutExtent, child: new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
            {
                LatestIndicatorBoxExtent = constraints.MaxHeight;
                RefreshState = TransitionNextState();
                if (Widget.Builder != null && LatestIndicatorBoxExtent > 0)
                {
                    return Widget.Builder(context, RefreshState, LatestIndicatorBoxExtent, Widget.RefreshTriggerPullDistance, Widget.RefreshIndicatorExtent);
                }

                return new Container();
            }
            ));
        }



    }


    /// <Summary>
    /// The current state of the refresh control.
    ///
    /// Passed into the [RefreshControlIndicatorBuilder] builder function so
    /// users can show different UI in different modes.
    /// </Summary>
    public enum RefreshIndicatorMode
    {

        /// <Summary>
        /// Initial state, when not being overscrolled into, or after the overscroll
        /// is canceled or after done and the sliver retracted away.
        /// </Summary>
        Inactive,
        /// <Summary>
        /// While being overscrolled but not far enough yet to trigger the refresh.
        /// </Summary>
        Drag,
        /// <Summary>
        /// Dragged far enough that the onRefresh callback will run and the dragged
        /// displacement is not yet at the final refresh resting state.
        /// </Summary>
        Armed,
        /// <Summary>
        /// While the onRefresh task is running.
        /// </Summary>
        Refresh,
        /// <Summary>
        /// While the indicator is animating away after refreshing.
        /// </Summary>
        Done,
    }

}
