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
using FlutterSDK.Material.Button;
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
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
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
namespace FlutterSDK.Material.Inputdecorator
{
    internal static class InputdecoratorDefaultClass
    {
        public static TimeSpan _KTransitionDuration = default(TimeSpan);
        public static FlutterSDK.Animation.Curves.Curve _KTransitionCurve = default(FlutterSDK.Animation.Curves.Curve);
    }

    public class _InputBorderGap : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        public _InputBorderGap()
        { }
        internal virtual double _Start { get; set; }
        internal virtual double _Extent { get; set; }
        public virtual double Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Extent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is _InputBorderGap && other.Start == Start && other.Extent == Extent;
        }



    }


    public class _InputBorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Material.Inputborder.InputBorder>
    {
        public _InputBorderTween(FlutterSDK.Material.Inputborder.InputBorder begin = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder end = default(FlutterSDK.Material.Inputborder.InputBorder))
        : base(begin: begin, end: end)
        {

        }

        public new FlutterSDK.Material.Inputborder.InputBorder Lerp(double t) => BordersDefaultClass.ShapeBorder.Lerp(Begin, End, t) as InputBorder;


    }


    public class _InputBorderPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _InputBorderPainter(FlutterSDK.Foundation.Changenotifier.Listenable repaint = default(FlutterSDK.Foundation.Changenotifier.Listenable), FlutterSDK.Animation.Animation.Animation<double> borderAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Material.Inputdecorator._InputBorderTween border = default(FlutterSDK.Material.Inputdecorator._InputBorderTween), FlutterSDK.Animation.Animation.Animation<double> gapAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Material.Inputdecorator._InputBorderGap gap = default(FlutterSDK.Material.Inputdecorator._InputBorderGap), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Animation.Animation<double> hoverAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Tween.ColorTween hoverColorTween = default(FlutterSDK.Animation.Tween.ColorTween))
        : base(repaint: repaint)
        {
            this.BorderAnimation = borderAnimation;
            this.Border = border;
            this.GapAnimation = gapAnimation;
            this.Gap = gap;
            this.TextDirection = textDirection;
            this.FillColor = fillColor;
            this.HoverAnimation = hoverAnimation;
            this.HoverColorTween = hoverColorTween;
        }
        public virtual FlutterSDK.Animation.Animation.Animation<double> BorderAnimation { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderTween Border { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> GapAnimation { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderGap Gap { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterSDK.Animation.Tween.ColorTween HoverColorTween { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> HoverAnimation { get; set; }
        public virtual FlutterBinding.UI.Color BlendedColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Paint(Canvas canvas, Size size)
        {
            InputBorder borderValue = Border.Evaluate(BorderAnimation);
            Rect canvasRect = Dart.UiDefaultClass.Offset.Zero & size;
            Color blendedFillColor = BlendedColor;
            if (blendedFillColor.Alpha > 0)
            {
                canvas.DrawPath(borderValue.GetOuterPath(canvasRect, textDirection: TextDirection), new Paint()..Color = blendedFillColor..Style = PaintingStyle.Fill);
            }

            borderValue.Paint(canvas, canvasRect, gapStart: Gap.Start, gapExtent: Gap.Extent, gapPercentage: GapAnimation.Value, textDirection: TextDirection);
        }




        public new bool ShouldRepaint(FlutterSDK.Material.Inputdecorator._InputBorderPainter oldPainter)
        {
            return BorderAnimation != oldPainter.BorderAnimation || HoverAnimation != oldPainter.HoverAnimation || GapAnimation != oldPainter.GapAnimation || Border != oldPainter.Border || Gap != oldPainter.Gap || TextDirection != oldPainter.TextDirection;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return BorderAnimation != oldPainter.BorderAnimation || HoverAnimation != oldPainter.HoverAnimation || GapAnimation != oldPainter.GapAnimation || Border != oldPainter.Border || Gap != oldPainter.Gap || TextDirection != oldPainter.TextDirection;
        }



    }


    public class _BorderContainer : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _BorderContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputdecorator._InputBorderGap gap = default(FlutterSDK.Material.Inputdecorator._InputBorderGap), FlutterSDK.Animation.Animation.Animation<double> gapAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), bool isHovering = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Border = border;
            this.Gap = gap;
            this.GapAnimation = gapAnimation;
            this.FillColor = fillColor;
            this.HoverColor = hoverColor;
            this.IsHovering = isHovering;
            this.Child = child;
        }
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderGap Gap { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> GapAnimation { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual bool IsHovering { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Material.Inputdecorator._BorderContainerState CreateState() => new _BorderContainerState();


    }


    public class _BorderContainerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inputdecorator._BorderContainer>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _BorderContainerState()
        { }
        internal virtual TimeSpan _KHoverDuration { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _HoverColorController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _BorderAnimation { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator._InputBorderTween _Border { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _HoverAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _HoverColorTween { get; set; }

        public new void InitState()
        {
            base.InitState();
            _HoverColorController = new AnimationController(duration: _KHoverDuration, value: Widget.IsHovering ? 1.0 : 0.0, vsync: this);
            _Controller = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this);
            _BorderAnimation = new CurvedAnimation(parent: _Controller, curve: InputdecoratorDefaultClass._KTransitionCurve);
            _Border = new _InputBorderTween(begin: Widget.Border, end: Widget.Border);
            _HoverAnimation = new CurvedAnimation(parent: _HoverColorController, curve: CurvesDefaultClass.Curves.Linear);
            _HoverColorTween = new ColorTween(begin: ColorsDefaultClass.Colors.Transparent, end: Widget.HoverColor);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            _HoverColorController.Dispose();
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator._BorderContainer oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Border != oldWidget.Border)
            {
                _Border = new _InputBorderTween(begin: oldWidget.Border, end: Widget.Border);
                ..Value = 0.0;
                _Controller.Forward();
            }

            if (Widget.HoverColor != oldWidget.HoverColor)
            {
                _HoverColorTween = new ColorTween(begin: ColorsDefaultClass.Colors.Transparent, end: Widget.HoverColor);
            }

            if (Widget.IsHovering != oldWidget.IsHovering)
            {
                if (Widget.IsHovering)
                {
                    _HoverColorController.Forward();
                }
                else
                {
                    _HoverColorController.Reverse();
                }

            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new CustomPaint(foregroundPainter: new _InputBorderPainter(repaint: Listenable.Merge(new List<Listenable>() { _BorderAnimation, Widget.Gap, _HoverColorController }), borderAnimation: _BorderAnimation, border: _Border, gapAnimation: Widget.GapAnimation, gap: Widget.Gap, textDirection: BasicDefaultClass.Directionality.Of(context), fillColor: Widget.FillColor, hoverColorTween: _HoverColorTween, hoverAnimation: _HoverAnimation), child: Widget.Child);
        }



    }


    public class _Shaker : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        public _Shaker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: animation)
        {
            this.Child = child;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TranslateX { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Transform(transform: Matrix4.TranslationValues(TranslateX, 0.0, 0.0), child: Child);
        }



    }


    public class _HelperError : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _HelperError(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), TextAlign textAlign = default(TextAlign), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int))
        : base(key: key)
        {
            this.TextAlign = textAlign;
            this.HelperText = helperText;
            this.HelperStyle = helperStyle;
            this.HelperMaxLines = helperMaxLines;
            this.ErrorText = errorText;
            this.ErrorStyle = errorStyle;
            this.ErrorMaxLines = errorMaxLines;
        }
        public virtual TextAlign TextAlign { get; set; }
        public virtual string HelperText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HelperStyle { get; set; }
        public virtual int HelperMaxLines { get; set; }
        public virtual string ErrorText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ErrorStyle { get; set; }
        public virtual int ErrorMaxLines { get; set; }

        public new FlutterSDK.Material.Inputdecorator._HelperErrorState CreateState() => new _HelperErrorState();


    }


    public class _HelperErrorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inputdecorator._HelperError>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _HelperErrorState()
        { }
        public virtual FlutterSDK.Widgets.Framework.Widget Empty { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Helper { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Error { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this);
            if (Widget.ErrorText != null)
            {
                _Error = _BuildError();
                _Controller.Value = 1.0;
            }
            else if (Widget.HelperText != null)
            {
                _Helper = _BuildHelper();
            }

            _Controller.AddListener(_HandleChange);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        private void _HandleChange()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator._HelperError old)
        {
            base.DidUpdateWidget(old);
            string newErrorText = Widget.ErrorText;
            string newHelperText = Widget.HelperText;
            string oldErrorText = old.ErrorText;
            string oldHelperText = old.HelperText;
            bool errorTextStateChanged = (newErrorText != null) != (oldErrorText != null);
            bool helperTextStateChanged = newErrorText == null && (newHelperText != null) != (oldHelperText != null);
            if (errorTextStateChanged || helperTextStateChanged)
            {
                if (newErrorText != null)
                {
                    _Error = _BuildError();
                    _Controller.Forward();
                }
                else if (newHelperText != null)
                {
                    _Helper = _BuildHelper();
                    _Controller.Reverse();
                }
                else
                {
                    _Controller.Reverse();
                }

            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHelper()
        {

            return new Semantics(container: true, child: new Opacity(opacity: 1.0 - _Controller.Value, child: new Text(Widget.HelperText, style: Widget.HelperStyle, textAlign: Widget.TextAlign, overflow: TextOverflow.Ellipsis, maxLines: Widget.HelperMaxLines)));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildError()
        {

            return new Semantics(container: true, liveRegion: true, child: new Opacity(opacity: _Controller.Value, child: new FractionalTranslation(translation: new Tween<Offset>(begin: new Offset(0.0, -0.25), end: new Offset(0.0, 0.0)).Evaluate(_Controller.View), child: new Text(Widget.ErrorText, style: Widget.ErrorStyle, textAlign: Widget.TextAlign, overflow: TextOverflow.Ellipsis, maxLines: Widget.ErrorMaxLines))));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_Controller.IsDismissed)
            {
                _Error = null;
                if (Widget.HelperText != null)
                {
                    return _Helper = _BuildHelper();
                }
                else
                {
                    _Helper = null;
                    return Empty;
                }

            }

            if (_Controller.IsCompleted)
            {
                _Helper = null;
                if (Widget.ErrorText != null)
                {
                    return _Error = _BuildError();
                }
                else
                {
                    _Error = null;
                    return Empty;
                }

            }

            if (_Helper == null && Widget.ErrorText != null) return _BuildError();
            if (_Error == null && Widget.HelperText != null) return _BuildHelper();
            if (Widget.ErrorText != null)
            {
                return new Stack(children: new List<Widget>() { new Opacity(opacity: 1.0 - _Controller.Value, child: _Helper), _BuildError() });
            }

            if (Widget.HelperText != null)
            {
                return new Stack(children: new List<Widget>() { _BuildHelper(), new Opacity(opacity: _Controller.Value, child: _Error) });
            }

            return Empty;
        }



    }


    public class _Decoration
    {
        public _Decoration(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = default(bool), double floatingLabelHeight = default(double), double floatingLabelProgress = default(double), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputdecorator._InputBorderGap borderGap = default(FlutterSDK.Material.Inputdecorator._InputBorderGap), bool alignLabelWithHint = default(bool), bool isDense = default(bool), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget input = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget hint = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget helperError = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget container = default(FlutterSDK.Widgets.Framework.Widget))
        : base()
        {
            this.ContentPadding = contentPadding;
            this.IsCollapsed = isCollapsed;
            this.FloatingLabelHeight = floatingLabelHeight;
            this.FloatingLabelProgress = floatingLabelProgress;
            this.Border = border;
            this.BorderGap = borderGap;
            this.AlignLabelWithHint = alignLabelWithHint;
            this.IsDense = isDense;
            this.VisualDensity = visualDensity;
            this.Icon = icon;
            this.Input = input;
            this.Label = label;
            this.Hint = hint;
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.PrefixIcon = prefixIcon;
            this.SuffixIcon = suffixIcon;
            this.HelperError = helperError;
            this.Counter = counter;
            this.Container = container;
        }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual bool IsCollapsed { get; set; }
        public virtual double FloatingLabelHeight { get; set; }
        public virtual double FloatingLabelProgress { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderGap BorderGap { get; set; }
        public virtual bool AlignLabelWithHint { get; set; }
        public virtual bool IsDense { get; set; }
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Input { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Hint { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Prefix { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Suffix { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget PrefixIcon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget SuffixIcon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget HelperError { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Counter { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Container { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is _Decoration && other.ContentPadding == ContentPadding && other.IsCollapsed == IsCollapsed && other.FloatingLabelHeight == FloatingLabelHeight && other.FloatingLabelProgress == FloatingLabelProgress && other.Border == Border && other.BorderGap == BorderGap && other.AlignLabelWithHint == AlignLabelWithHint && other.IsDense == IsDense && other.VisualDensity == VisualDensity && other.Icon == Icon && other.Input == Input && other.Label == Label && other.Hint == Hint && other.Prefix == Prefix && other.Suffix == Suffix && other.PrefixIcon == PrefixIcon && other.SuffixIcon == SuffixIcon && other.HelperError == HelperError && other.Counter == Counter && other.Container == Container;
        }



    }


    public class _RenderDecorationLayout
    {
        public _RenderDecorationLayout(Dictionary<FlutterSDK.Rendering.Box.RenderBox, double> boxToBaseline = default(Dictionary<FlutterSDK.Rendering.Box.RenderBox, double>), double inputBaseline = default(double), double outlineBaseline = default(double), double subtextBaseline = default(double), double containerHeight = default(double), double subtextHeight = default(double))
        {
            this.BoxToBaseline = boxToBaseline;
            this.InputBaseline = inputBaseline;
            this.OutlineBaseline = outlineBaseline;
            this.SubtextBaseline = subtextBaseline;
            this.ContainerHeight = containerHeight;
            this.SubtextHeight = subtextHeight;
        }
        public virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, double> BoxToBaseline { get; set; }
        public virtual double InputBaseline { get; set; }
        public virtual double OutlineBaseline { get; set; }
        public virtual double SubtextBaseline { get; set; }
        public virtual double ContainerHeight { get; set; }
        public virtual double SubtextHeight { get; set; }
    }


    public class _RenderDecoration : FlutterSDK.Rendering.Box.RenderBox
    {
        public _RenderDecoration(FlutterSDK.Material.Inputdecorator._Decoration decoration = default(FlutterSDK.Material.Inputdecorator._Decoration), TextDirection textDirection = default(TextDirection), TextBaseline textBaseline = default(TextBaseline), bool isFocused = default(bool), bool expands = default(bool), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical))
        : base()
        {

        }
        public virtual double SubtextGap { get; set; }
        public virtual Dictionary<FlutterSDK.Material.Inputdecorator._DecorationSlot, FlutterSDK.Rendering.Box.RenderBox> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Material.Inputdecorator._DecorationSlot> ChildToSlot { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Icon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Input { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Label { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Hint { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Prefix { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Suffix { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _PrefixIcon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _SuffixIcon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _HelperError { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Counter { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Container { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator._Decoration _Decoration { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual TextBaseline _TextBaseline { get; set; }
        internal virtual FlutterSDK.Painting.Alignment.TextAlignVertical _TextAlignVertical { get; set; }
        internal virtual bool _IsFocused { get; set; }
        internal virtual bool _Expands { get; set; }
        internal virtual Matrix4 _LabelTransform { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox Icon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Input { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Hint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Prefix { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Suffix { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox PrefixIcon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox SuffixIcon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox HelperError { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Counter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Container { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> _Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Inputdecorator._Decoration Decoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextBaseline TextBaseline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFocused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Expands { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsOutlineAligned { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ContentPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private FlutterSDK.Rendering.Box.RenderBox _UpdateChild(FlutterSDK.Rendering.Box.RenderBox oldChild, FlutterSDK.Rendering.Box.RenderBox newChild, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
        {
            if (oldChild != null)
            {
                DropChild(oldChild);
                ChildToSlot.Remove(oldChild);
                SlotToChild.Remove(slot);
            }

            if (newChild != null)
            {
                ChildToSlot[newChild] = slot;
                SlotToChild[slot] = newChild;
                AdoptChild(newChild);
            }

            return newChild;
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            foreach (RenderBox child in _Children) child.Attach(owner);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            foreach (RenderBox child in _Children) child.Attach(owner);
        }




        public new void Detach()
        {
            base.Detach();
            foreach (RenderBox child in _Children) child.Detach();
        }




        public new void RedepthChildren()
        {
            _Children.ForEach(RedepthChild);
        }




        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            _Children.ForEach(visitor);
        }




        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            if (Icon != null) visitor(Icon);
            if (Prefix != null) visitor(Prefix);
            if (PrefixIcon != null) visitor(PrefixIcon);
            if (Label != null)
            {
                visitor(Label);
            }

            if (Hint != null)
            {
                if (IsFocused)
                {
                    visitor(Hint);
                }
                else if (Label == null)
                {
                    visitor(Hint);
                }

            }

            if (Input != null) visitor(Input);
            if (SuffixIcon != null) visitor(SuffixIcon);
            if (Suffix != null) visitor(Suffix);
            if (Container != null) visitor(Container);
            if (HelperError != null) visitor(HelperError);
            if (Counter != null) visitor(Counter);
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> value = new List<DiagnosticsNode>() { };
            void Add(RenderBox child, string name)
            {
                if (child != null) value.Add(child.ToDiagnosticsNode(name: name));
            }

            Add(Icon, "icon");
            Add(Input, "input");
            Add(Label, "label");
            Add(Hint, "hint");
            Add(Prefix, "prefix");
            Add(Suffix, "suffix");
            Add(PrefixIcon, "prefixIcon");
            Add(SuffixIcon, "suffixIcon");
            Add(HelperError, "helperError");
            Add(Counter, "counter");
            Add(Container, "container");
            return value;
        }




        private double _MinWidth(FlutterSDK.Rendering.Box.RenderBox box, double height)
        {
            return box == null ? 0.0 : box.GetMinIntrinsicWidth(height);
        }




        private double _MaxWidth(FlutterSDK.Rendering.Box.RenderBox box, double height)
        {
            return box == null ? 0.0 : box.GetMaxIntrinsicWidth(height);
        }




        private double _MinHeight(FlutterSDK.Rendering.Box.RenderBox box, double width)
        {
            return box == null ? 0.0 : box.GetMinIntrinsicHeight(width);
        }




        private Size _BoxSize(FlutterSDK.Rendering.Box.RenderBox box) => box == null ? Dart.UiDefaultClass.Size.Zero : box.Size;



        private FlutterSDK.Rendering.Box.BoxParentData _BoxParentData(FlutterSDK.Rendering.Box.RenderBox box) => box.ParentData as BoxParentData;



        private double _LayoutLineBox(FlutterSDK.Rendering.Box.RenderBox box, FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            if (box == null)
            {
                return 0.0;
            }

            box.Layout(constraints, parentUsesSize: true);
            double baseline = box.GetDistanceToBaseline(TextBaseline.Alphabetic);

            return baseline;
        }




        private FlutterSDK.Material.Inputdecorator._RenderDecorationLayout _Layout(FlutterSDK.Rendering.Box.BoxConstraints layoutConstraints)
        {

            Dictionary<RenderBox, double> boxToBaseline = new Dictionary<RenderBox, double> { };
            BoxConstraints boxConstraints = layoutConstraints.Loosen();
            boxToBaseline[Prefix] = _LayoutLineBox(Prefix, boxConstraints);
            boxToBaseline[Suffix] = _LayoutLineBox(Suffix, boxConstraints);
            boxToBaseline[Icon] = _LayoutLineBox(Icon, boxConstraints);
            boxToBaseline[PrefixIcon] = _LayoutLineBox(PrefixIcon, boxConstraints);
            boxToBaseline[SuffixIcon] = _LayoutLineBox(SuffixIcon, boxConstraints);
            double inputWidth = Dart.Math.MathDefaultClass.Max(0.0, Constraints.MaxWidth - (_BoxSize(Icon).Width + ContentPadding.Left + _BoxSize(PrefixIcon).Width + _BoxSize(Prefix).Width + _BoxSize(Suffix).Width + _BoxSize(SuffixIcon).Width + ContentPadding.Right));
            boxToBaseline[Label] = _LayoutLineBox(Label, boxConstraints.CopyWith(maxWidth: inputWidth));
            boxToBaseline[Hint] = _LayoutLineBox(Hint, boxConstraints.CopyWith(minWidth: inputWidth, maxWidth: inputWidth));
            boxToBaseline[Counter] = _LayoutLineBox(Counter, boxConstraints);
            boxToBaseline[HelperError] = _LayoutLineBox(HelperError, boxConstraints.CopyWith(maxWidth: Dart.Math.MathDefaultClass.Max(0.0, boxConstraints.MaxWidth - _BoxSize(Icon).Width - _BoxSize(Counter).Width - ContentPadding.Horizontal)));
            double labelHeight = Label == null ? 0 : Decoration.FloatingLabelHeight;
            double topHeight = Decoration.Border.IsOutline ? Dart.Math.MathDefaultClass.Max(labelHeight - boxToBaseline[Label], 0) : labelHeight;
            double counterHeight = Counter == null ? 0 : boxToBaseline[Counter] + SubtextGap;
            bool helperErrorExists = HelperError?.Size != null && HelperError.Size.Height > 0;
            double helperErrorHeight = !helperErrorExists ? 0 : HelperError.Size.Height + SubtextGap;
            double bottomHeight = Dart.Math.MathDefaultClass.Max(counterHeight, helperErrorHeight);
            boxToBaseline[Input] = _LayoutLineBox(Input, boxConstraints.Deflate(EdgeInsets.Only(top: ContentPadding.Top + topHeight, bottom: ContentPadding.Bottom + bottomHeight)).CopyWith(minWidth: inputWidth, maxWidth: inputWidth));
            double hintHeight = Hint == null ? 0 : Hint.Size.Height;
            double inputDirectHeight = Input == null ? 0 : Input.Size.Height;
            double inputHeight = Dart.Math.MathDefaultClass.Max(hintHeight, inputDirectHeight);
            double inputInternalBaseline = Dart.Math.MathDefaultClass.Max(boxToBaseline[Input], boxToBaseline[Hint]);
            double prefixHeight = Prefix == null ? 0 : Prefix.Size.Height;
            double suffixHeight = Suffix == null ? 0 : Suffix.Size.Height;
            double fixHeight = Dart.Math.MathDefaultClass.Max(boxToBaseline[Prefix], boxToBaseline[Suffix]);
            double fixAboveInput = Dart.Math.MathDefaultClass.Max(0, fixHeight - inputInternalBaseline);
            double fixBelowBaseline = Dart.Math.MathDefaultClass.Max(prefixHeight - boxToBaseline[Prefix], suffixHeight - boxToBaseline[Suffix]);
            double fixBelowInput = Dart.Math.MathDefaultClass.Max(0, fixBelowBaseline - (inputHeight - inputInternalBaseline));
            Offset densityOffset = Decoration.VisualDensity.BaseSizeAdjustment;
            double prefixIconHeight = PrefixIcon == null ? 0 : PrefixIcon.Size.Height;
            double suffixIconHeight = SuffixIcon == null ? 0 : SuffixIcon.Size.Height;
            double fixIconHeight = Dart.Math.MathDefaultClass.Max(prefixIconHeight, suffixIconHeight);
            double contentHeight = Dart.Math.MathDefaultClass.Max(fixIconHeight, topHeight + ContentPadding.Top + fixAboveInput + inputHeight + fixBelowInput + ContentPadding.Bottom + densityOffset.Dy);
            double minContainerHeight = Decoration.IsDense || Expands ? 0.0 : ConstantsDefaultClass.KMinInteractiveDimension + densityOffset.Dy;
            double maxContainerHeight = boxConstraints.MaxHeight - bottomHeight + densityOffset.Dy;
            double containerHeight = Expands ? maxContainerHeight : Dart.Math.MathDefaultClass.Min(Dart.Math.MathDefaultClass.Max(contentHeight, minContainerHeight), maxContainerHeight);
            double interactiveAdjustment = minContainerHeight > contentHeight ? (minContainerHeight - contentHeight) / 2.0 : 0.0;
            double overflow = Dart.Math.MathDefaultClass.Max(0, contentHeight - maxContainerHeight);
            double textAlignVerticalFactor = (TextAlignVertical.y + 1.0) / 2.0;
            double baselineAdjustment = fixAboveInput - overflow * (1 - textAlignVerticalFactor);
            double topInputBaseline = ContentPadding.Top + topHeight + inputInternalBaseline + baselineAdjustment + interactiveAdjustment;
            double maxContentHeight = containerHeight - ContentPadding.Top - topHeight - ContentPadding.Bottom;
            double alignableHeight = fixAboveInput + inputHeight + fixBelowInput;
            double maxVerticalOffset = maxContentHeight - alignableHeight;
            double textAlignVerticalOffset = maxVerticalOffset * textAlignVerticalFactor;
            double inputBaseline = topInputBaseline + textAlignVerticalOffset + densityOffset.Dy / 2.0;
            double outlineCenterBaseline = inputInternalBaseline + baselineAdjustment / 2.0 + (containerHeight - (2.0 + inputHeight)) / 2.0;
            double outlineTopBaseline = topInputBaseline;
            double outlineBottomBaseline = topInputBaseline + maxVerticalOffset;
            double outlineBaseline = _InterpolateThree(outlineTopBaseline, outlineCenterBaseline, outlineBottomBaseline, TextAlignVertical);
            double subtextCounterBaseline = 0;
            double subtextHelperBaseline = 0;
            double subtextCounterHeight = 0;
            double subtextHelperHeight = 0;
            if (Counter != null)
            {
                subtextCounterBaseline = containerHeight + SubtextGap + boxToBaseline[Counter];
                subtextCounterHeight = Counter.Size.Height + SubtextGap;
            }

            if (helperErrorExists)
            {
                subtextHelperBaseline = containerHeight + SubtextGap + boxToBaseline[HelperError];
                subtextHelperHeight = helperErrorHeight;
            }

            double subtextBaseline = Dart.Math.MathDefaultClass.Max(subtextCounterBaseline, subtextHelperBaseline);
            double subtextHeight = Dart.Math.MathDefaultClass.Max(subtextCounterHeight, subtextHelperHeight);
            return new _RenderDecorationLayout(boxToBaseline: boxToBaseline, containerHeight: containerHeight, inputBaseline: inputBaseline, outlineBaseline: outlineBaseline, subtextBaseline: subtextBaseline, subtextHeight: subtextHeight);
        }




        private double _InterpolateThree(double begin, double middle, double end, FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical)
        {
            if (textAlignVertical.y <= 0)
            {
                if (begin >= middle)
                {
                    return middle;
                }

                double t = textAlignVertical.y + 1;
                return begin + (middle - begin) * t;
            }

            if (middle >= end)
            {
                return middle;
            }

            double t = textAlignVertical.y;
            return middle + (end - middle) * t;
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return _MinWidth(Icon, height) + ContentPadding.Left + _MinWidth(PrefixIcon, height) + _MinWidth(Prefix, height) + Dart.Math.MathDefaultClass.Max(_MinWidth(Input, height), _MinWidth(Hint, height)) + _MinWidth(Suffix, height) + _MinWidth(SuffixIcon, height) + ContentPadding.Right;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return _MaxWidth(Icon, height) + ContentPadding.Left + _MaxWidth(PrefixIcon, height) + _MaxWidth(Prefix, height) + Dart.Math.MathDefaultClass.Max(_MaxWidth(Input, height), _MaxWidth(Hint, height)) + _MaxWidth(Suffix, height) + _MaxWidth(SuffixIcon, height) + ContentPadding.Right;
        }




        private double _LineHeight(double width, List<FlutterSDK.Rendering.Box.RenderBox> boxes)
        {
            double height = 0.0;
            foreach (RenderBox box in boxes)
            {
                if (box == null) continue;
                height = Dart.Math.MathDefaultClass.Max(_MinHeight(box, width), height);
            }

            return height;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double subtextHeight = _LineHeight(width, new List<RenderBox>() { HelperError, Counter });
            if (subtextHeight > 0.0) subtextHeight += SubtextGap;
            return ContentPadding.Top + (Label == null ? 0.0 : Decoration.FloatingLabelHeight) + _LineHeight(width, new List<RenderBox>() { Prefix, Input, Suffix }) + subtextHeight + ContentPadding.Bottom;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return ComputeMinIntrinsicHeight(width);
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {
            return _BoxParentData(Input).Offset.Dy + Input.ComputeDistanceToActualBaseline(baseline);
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            _LabelTransform = null;
            _RenderDecorationLayout layout = _Layout(constraints);
            double overallWidth = constraints.MaxWidth;
            double overallHeight = layout.ContainerHeight + layout.SubtextHeight;
            if (Container != null)
            {
                BoxConstraints containerConstraints = BoxConstraints.TightFor(height: layout.ContainerHeight, width: overallWidth - _BoxSize(Icon).Width);
                Container.Layout(containerConstraints, parentUsesSize: true);
                double x = default(double);
                switch (TextDirection) { case TextDirection.Rtl: x = 0.0; break; case TextDirection.Ltr: x = _BoxSize(Icon).Width; break; }
                _BoxParentData(Container).Offset = new Offset(x, 0.0);
            }

            double height = default(double);
            double CenterLayout(RenderBox box, double x)
            {
                _BoxParentData(box).Offset = new Offset(x, (height - box.Size.Height) / 2.0);
                return box.Size.Width;
            }

            double baseline = default(double);
            double BaselineLayout(RenderBox box, double x)
            {
                _BoxParentData(box).Offset = new Offset(x, baseline - layout.BoxToBaseline[box]);
                return box.Size.Width;
            }

            double left = ContentPadding.Left;
            double right = overallWidth - ContentPadding.Right;
            height = layout.ContainerHeight;
            baseline = _IsOutlineAligned ? layout.OutlineBaseline : layout.InputBaseline;
            if (Icon != null)
            {
                double x = default(double);
                switch (TextDirection) { case TextDirection.Rtl: x = overallWidth - Icon.Size.Width; break; case TextDirection.Ltr: x = 0.0; break; }
                CenterLayout(Icon, x);
            }

            switch (TextDirection)
            {
                case TextDirection.Rtl:
                    {
                        double start = right - _BoxSize(Icon).Width;
                        double end = left;
                        if (PrefixIcon != null)
                        {
                            start += ContentPadding.Left;
                            start -= CenterLayout(PrefixIcon, start - PrefixIcon.Size.Width);
                        }

                        if (Label != null)
                        {
                            if (Decoration.AlignLabelWithHint)
                            {
                                BaselineLayout(Label, start - Label.Size.Width);
                            }
                            else
                            {
                                CenterLayout(Label, start - Label.Size.Width);
                            }

                        }

                        if (Prefix != null) start -= BaselineLayout(Prefix, start - Prefix.Size.Width);
                        if (Input != null) BaselineLayout(Input, start - Input.Size.Width);
                        if (Hint != null) BaselineLayout(Hint, start - Hint.Size.Width);
                        if (SuffixIcon != null)
                        {
                            end -= ContentPadding.Left;
                            end += CenterLayout(SuffixIcon, end);
                        }

                        if (Suffix != null) end += BaselineLayout(Suffix, end);
                        break;
                    }
                case TextDirection.Ltr:
                    {
                        double start = left + _BoxSize(Icon).Width;
                        double end = right;
                        if (PrefixIcon != null)
                        {
                            start -= ContentPadding.Left;
                            start += CenterLayout(PrefixIcon, start);
                        }

                        if (Label != null)
                        {
                            if (Decoration.AlignLabelWithHint)
                            {
                                BaselineLayout(Label, start);
                            }
                            else
                            {
                                CenterLayout(Label, start);
                            }

                        }

                        if (Prefix != null) start += BaselineLayout(Prefix, start);
                        if (Input != null) BaselineLayout(Input, start);
                        if (Hint != null) BaselineLayout(Hint, start);
                        if (SuffixIcon != null)
                        {
                            end += ContentPadding.Right;
                            end -= CenterLayout(SuffixIcon, end - SuffixIcon.Size.Width);
                        }

                        if (Suffix != null) end -= BaselineLayout(Suffix, end - Suffix.Size.Width);
                        break;
                    }
            }
            if (HelperError != null || Counter != null)
            {
                height = layout.SubtextHeight;
                baseline = layout.SubtextBaseline;
                switch (TextDirection) { case TextDirection.Rtl: if (HelperError != null) BaselineLayout(HelperError, right - HelperError.Size.Width - _BoxSize(Icon).Width); if (Counter != null) BaselineLayout(Counter, left); break; case TextDirection.Ltr: if (HelperError != null) BaselineLayout(HelperError, left + _BoxSize(Icon).Width); if (Counter != null) BaselineLayout(Counter, right - Counter.Size.Width); break; }
            }

            if (Label != null)
            {
                double labelX = _BoxParentData(Label).Offset.Dx;
                switch (TextDirection) { case TextDirection.Rtl: Decoration.BorderGap.Start = labelX + Label.Size.Width; break; case TextDirection.Ltr: Decoration.BorderGap.Start = labelX - _BoxSize(Icon).Width; break; }
                Decoration.BorderGap.Extent = Label.Size.Width * 0.75;
            }
            else
            {
                Decoration.BorderGap.Start = null;
                Decoration.BorderGap.Extent = 0.0;
            }

            Size = constraints.Constrain(new Size(overallWidth, overallHeight));


        }




        private void _PaintLabel(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            context.PaintChild(Label, offset);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            void DoPaint(RenderBox child)
            {
                if (child != null) context.PaintChild(child, _BoxParentData(child).Offset + offset);
            }

            DoPaint(Container);
            if (Label != null)
            {
                Offset labelOffset = _BoxParentData(Label).Offset;
                double labelHeight = Label.Size.Height;
                double t = Decoration.FloatingLabelProgress;
                bool isOutlineBorder = Decoration.Border != null && Decoration.Border.IsOutline;
                double floatingY = isOutlineBorder ? -labelHeight * 0.25 : ContentPadding.Top;
                double scale = Dart.UI.UiDefaultClass.LerpDouble(1.0, 0.75, t);
                double dx = default(double);
                switch (TextDirection) { case TextDirection.Rtl: dx = labelOffset.Dx + Label.Size.Width * (1.0 - scale); break; case TextDirection.Ltr: dx = labelOffset.Dx; break; }
                double dy = Dart.UI.UiDefaultClass.LerpDouble(0.0, floatingY - labelOffset.Dy, t);
                _LabelTransform = Matrix4.Identity();
                Matrix4.Identity().Translate(dx, labelOffset.Dy + dy);
                Matrix4.Identity().Scale(scale);
                context.PushTransform(NeedsCompositing, offset, _LabelTransform, _PaintLabel);
            }

            DoPaint(Icon);
            DoPaint(Prefix);
            DoPaint(Suffix);
            DoPaint(PrefixIcon);
            DoPaint(SuffixIcon);
            DoPaint(Hint);
            DoPaint(Input);
            DoPaint(HelperError);
            DoPaint(Counter);
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {

            foreach (RenderBox child in _Children)
            {
                Offset offset = _BoxParentData(child).Offset;
                bool isHit = result.AddWithPaintOffset(offset: offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
                {

                    return child.HitTest(result, position: transformed);
                }
                );
                if (isHit) return true;
            }

            return false;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {
            if (child == Label && _LabelTransform != null)
            {
                Offset labelOffset = _BoxParentData(Label).Offset;
                ;
                transform.Multiply(_LabelTransform);
                transform.Translate(-labelOffset.Dx, -labelOffset.Dy);
            }

            base.ApplyPaintTransform(child, transform);
        }



    }


    public class _RenderDecorationElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public _RenderDecorationElement(FlutterSDK.Material.Inputdecorator._Decorator widget)
        : base(widget)
        {

        }
        public virtual Dictionary<FlutterSDK.Material.Inputdecorator._DecorationSlot, FlutterSDK.Widgets.Framework.Element> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Material.Inputdecorator._DecorationSlot> ChildToSlot { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._Decorator Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Inputdecorator._RenderDecoration RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            SlotToChild.Values.ForEach(visitor);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {


            _DecorationSlot slot = ChildToSlot[child];
            ChildToSlot.Remove(child);
            SlotToChild.Remove(slot);
            base.ForgetChild(child);
        }




        private void _MountChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
        {
            Element oldChild = SlotToChild[slot];
            Element newChild = UpdateChild(oldChild, widget, slot);
            if (oldChild != null)
            {
                SlotToChild.Remove(slot);
                ChildToSlot.Remove(oldChild);
            }

            if (newChild != null)
            {
                SlotToChild[slot] = newChild;
                ChildToSlot[newChild] = slot;
            }

        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _MountChild(Widget.Decoration.Icon, _DecorationSlot.Icon);
            _MountChild(Widget.Decoration.Input, _DecorationSlot.Input);
            _MountChild(Widget.Decoration.Label, _DecorationSlot.Label);
            _MountChild(Widget.Decoration.Hint, _DecorationSlot.Hint);
            _MountChild(Widget.Decoration.Prefix, _DecorationSlot.Prefix);
            _MountChild(Widget.Decoration.Suffix, _DecorationSlot.Suffix);
            _MountChild(Widget.Decoration.PrefixIcon, _DecorationSlot.PrefixIcon);
            _MountChild(Widget.Decoration.SuffixIcon, _DecorationSlot.SuffixIcon);
            _MountChild(Widget.Decoration.HelperError, _DecorationSlot.HelperError);
            _MountChild(Widget.Decoration.Counter, _DecorationSlot.Counter);
            _MountChild(Widget.Decoration.Container, _DecorationSlot.Container);
        }




        private void _UpdateChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
        {
            Element oldChild = SlotToChild[slot];
            Element newChild = UpdateChild(oldChild, widget, slot);
            if (oldChild != null)
            {
                ChildToSlot.Remove(oldChild);
                SlotToChild.Remove(slot);
            }

            if (newChild != null)
            {
                SlotToChild[slot] = newChild;
                ChildToSlot[newChild] = slot;
            }

        }




        public new void Update(FlutterSDK.Material.Inputdecorator._Decorator newWidget)
        {
            base.Update(newWidget);

            _UpdateChild(Widget.Decoration.Icon, _DecorationSlot.Icon);
            _UpdateChild(Widget.Decoration.Input, _DecorationSlot.Input);
            _UpdateChild(Widget.Decoration.Label, _DecorationSlot.Label);
            _UpdateChild(Widget.Decoration.Hint, _DecorationSlot.Hint);
            _UpdateChild(Widget.Decoration.Prefix, _DecorationSlot.Prefix);
            _UpdateChild(Widget.Decoration.Suffix, _DecorationSlot.Suffix);
            _UpdateChild(Widget.Decoration.PrefixIcon, _DecorationSlot.PrefixIcon);
            _UpdateChild(Widget.Decoration.SuffixIcon, _DecorationSlot.SuffixIcon);
            _UpdateChild(Widget.Decoration.HelperError, _DecorationSlot.HelperError);
            _UpdateChild(Widget.Decoration.Counter, _DecorationSlot.Counter);
            _UpdateChild(Widget.Decoration.Container, _DecorationSlot.Container);
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            _UpdateChild(Widget.Decoration.Icon, _DecorationSlot.Icon);
            _UpdateChild(Widget.Decoration.Input, _DecorationSlot.Input);
            _UpdateChild(Widget.Decoration.Label, _DecorationSlot.Label);
            _UpdateChild(Widget.Decoration.Hint, _DecorationSlot.Hint);
            _UpdateChild(Widget.Decoration.Prefix, _DecorationSlot.Prefix);
            _UpdateChild(Widget.Decoration.Suffix, _DecorationSlot.Suffix);
            _UpdateChild(Widget.Decoration.PrefixIcon, _DecorationSlot.PrefixIcon);
            _UpdateChild(Widget.Decoration.SuffixIcon, _DecorationSlot.SuffixIcon);
            _UpdateChild(Widget.Decoration.HelperError, _DecorationSlot.HelperError);
            _UpdateChild(Widget.Decoration.Counter, _DecorationSlot.Counter);
            _UpdateChild(Widget.Decoration.Container, _DecorationSlot.Container);
        }




        private void _UpdateRenderObject(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
        {
            switch (slot) { case _DecorationSlot.Icon: RenderObject.Icon = child; break; case _DecorationSlot.Input: RenderObject.Input = child; break; case _DecorationSlot.Label: RenderObject.Label = child; break; case _DecorationSlot.Hint: RenderObject.Hint = child; break; case _DecorationSlot.Prefix: RenderObject.Prefix = child; break; case _DecorationSlot.Suffix: RenderObject.Suffix = child; break; case _DecorationSlot.PrefixIcon: RenderObject.PrefixIcon = child; break; case _DecorationSlot.SuffixIcon: RenderObject.SuffixIcon = child; break; case _DecorationSlot.HelperError: RenderObject.HelperError = child; break; case _DecorationSlot.Counter: RenderObject.Counter = child; break; case _DecorationSlot.Container: RenderObject.Container = child; break; }
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
        {


            _DecorationSlot slot = slotValue as _DecorationSlot;
            _UpdateRenderObject(child as RenderBox, slot);


        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {


            _UpdateRenderObject(null, RenderObject.ChildToSlot[child]);


        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
        {

        }



    }


    public class _Decorator : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        public _Decorator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), FlutterSDK.Material.Inputdecorator._Decoration decoration = default(FlutterSDK.Material.Inputdecorator._Decoration), TextDirection textDirection = default(TextDirection), TextBaseline textBaseline = default(TextBaseline), bool isFocused = default(bool), bool expands = default(bool))
        : base(key: key)
        {
            this.TextAlignVertical = textAlignVertical;
            this.Decoration = decoration;
            this.TextDirection = textDirection;
            this.TextBaseline = textBaseline;
            this.IsFocused = isFocused;
            this.Expands = expands;
        }
        public virtual FlutterSDK.Material.Inputdecorator._Decoration Decoration { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual TextBaseline TextBaseline { get; set; }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        public virtual bool IsFocused { get; set; }
        public virtual bool Expands { get; set; }

        public new FlutterSDK.Material.Inputdecorator._RenderDecorationElement CreateElement() => new _RenderDecorationElement(this);



        public new FlutterSDK.Material.Inputdecorator._RenderDecoration CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderDecoration(decoration: Decoration, textDirection: TextDirection, textBaseline: TextBaseline, textAlignVertical: TextAlignVertical, isFocused: IsFocused, expands: Expands);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Inputdecorator._RenderDecoration renderObject)
        {
            ..Decoration = Decoration..TextDirection = TextDirection..TextBaseline = TextBaseline..Expands = Expands..IsFocused = IsFocused;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Decoration = Decoration..TextDirection = TextDirection..TextBaseline = TextBaseline..Expands = Expands..IsFocused = IsFocused;
        }



    }


    public class _AffixText : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _AffixText(bool labelIsFloating = default(bool), string text = default(string), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            this.LabelIsFloating = labelIsFloating;
            this.Text = text;
            this.Style = style;
            this.Child = child;
        }
        public virtual bool LabelIsFloating { get; set; }
        public virtual string Text { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return TextDefaultClass.DefaultTextStyle.Merge(style: Style, child: new AnimatedOpacity(duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, opacity: LabelIsFloating ? 1.0 : 0.0, child: Child ?? new Text(Text, style: Style)));
        }



    }


    /// <Summary>
    /// Defines the appearance of a Material Design text field.
    ///
    /// [InputDecorator] displays the visual elements of a Material Design text
    /// field around its input [child]. The visual elements themselves are defined
    /// by an [InputDecoration] object and their layout and appearance depend
    /// on the `baseStyle`, `textAlign`, `isFocused`, and `isEmpty` parameters.
    ///
    /// [TextField] uses this widget to decorate its [EditableText] child.
    ///
    /// [InputDecorator] can be used to create widgets that look and behave like a
    /// [TextField] but support other kinds of input.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// See also:
    ///
    ///  * [TextField], which uses an [InputDecorator] to display a border,
    ///    labels, and icons, around its [EditableText] child.
    ///  * [Decoration] and [DecoratedBox], for drawing arbitrary decorations
    ///    around other widgets.
    /// </Summary>
    public class InputDecorator : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that displays a border, labels, and icons,
        /// for a [TextField].
        ///
        /// The [isFocused], [isHovering], [expands], and [isEmpty] arguments must not
        /// be null.
        /// </Summary>
        public InputDecorator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Inputdecorator.InputDecoration decoration = default(FlutterSDK.Material.Inputdecorator.InputDecoration), FlutterSDK.Painting.Textstyle.TextStyle baseStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), TextAlign textAlign = default(TextAlign), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), bool isFocused = false, bool isHovering = false, bool expands = false, bool isEmpty = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Decoration = decoration;
            this.BaseStyle = baseStyle;
            this.TextAlign = textAlign;
            this.TextAlignVertical = textAlignVertical;
            this.IsFocused = isFocused;
            this.IsHovering = isHovering;
            this.Expands = expands;
            this.IsEmpty = isEmpty;
            this.Child = child;
        }
        /// <Summary>
        /// The text and styles to use when decorating the child.
        ///
        /// If null, `const InputDecoration()` is used. Null [InputDecoration]
        /// properties are initialized with the corresponding values from
        /// [ThemeData.inputDecorationTheme].
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get; set; }
        /// <Summary>
        /// The style on which to base the label, hint, counter, and error styles
        /// if the [decoration] does not provide explicit styles.
        ///
        /// If null, `baseStyle` defaults to the `subtitle1` style from the
        /// current [Theme], see [ThemeData.textTheme].
        ///
        /// The [TextStyle.textBaseline] of the [baseStyle] is used to determine
        /// the baseline used for text alignment.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle BaseStyle { get; set; }
        /// <Summary>
        /// How the text in the decoration should be aligned horizontally.
        /// </Summary>
        public virtual TextAlign TextAlign { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.inputDecorator.textAlignVertical}
        /// How the text should be aligned vertically.
        ///
        /// Determines the alignment of the baseline within the available space of
        /// the input (typically a TextField). For example, TextAlignVertical.top will
        /// place the baseline such that the text, and any attached decoration like
        /// prefix and suffix, is as close to the top of the input as possible without
        /// overflowing. The heights of the prefix and suffix are similarly included
        /// for other alignment values. If the height is greater than the height
        /// available, then the prefix and suffix will be allowed to overflow first
        /// before the text scrolls.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        /// <Summary>
        /// Whether the input field has focus.
        ///
        /// Determines the position of the label text and the color and weight of the
        /// border, as well as the container fill color, which is a blend of
        /// [InputDecoration.focusColor] with [InputDecoration.fillColor] when
        /// focused, and [InputDecoration.fillColor] when not.
        ///
        /// Defaults to false.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.hoverColor], which is also blended into the focus
        ///    color and fill color when the [isHovering] is true to produce the final
        ///    color.
        /// </Summary>
        public virtual bool IsFocused { get; set; }
        /// <Summary>
        /// Whether the input field is being hovered over by a mouse pointer.
        ///
        /// Determines the container fill color, which is a blend of
        /// [InputDecoration.hoverColor] with [InputDecoration.fillColor] when
        /// true, and [InputDecoration.fillColor] when not.
        ///
        /// Defaults to false.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.focusColor], which is also blended into the hover
        ///    color and fill color when [isFocused] is true to produce the final
        ///    color.
        /// </Summary>
        public virtual bool IsHovering { get; set; }
        /// <Summary>
        /// If true, the height of the input field will be as large as possible.
        ///
        /// If wrapped in a widget that constrains its child's height, like Expanded
        /// or SizedBox, the input field will only be affected if [expands] is set to
        /// true.
        ///
        /// See [TextField.minLines] and [TextField.maxLines] for related ways to
        /// affect the height of an input. When [expands] is true, both must be null
        /// in order to avoid ambiguity in determining the height.
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool Expands { get; set; }
        /// <Summary>
        /// Whether the input field is empty.
        ///
        /// Determines the position of the label text and whether to display the hint
        /// text.
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool IsEmpty { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// Typically an [EditableText], [DropdownButton], or [InkWell].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        internal virtual bool _LabelShouldWithdraw { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Inputdecorator._InputDecoratorState CreateState() => new _InputDecoratorState();



        /// <Summary>
        /// The RenderBox that defines this decorator's "container". That's the
        /// area which is filled if [InputDecoration.filled] is true. It's the area
        /// adjacent to [InputDecoration.icon] and above the widgets that contain
        /// [InputDecoration.helperText], [InputDecoration.errorText], and
        /// [InputDecoration.counterText].
        ///
        /// [TextField] renders ink splashes within the container.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.RenderBox ContainerOf(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _RenderDecoration result = context.FindAncestorRenderObjectOfType();
            return result?.Container;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<InputDecoration>("decoration", Decoration));
            properties.Add(new DiagnosticsProperty<TextStyle>("baseStyle", BaseStyle, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("isFocused", IsFocused));
            properties.Add(new DiagnosticsProperty<bool>("expands", Expands, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("isEmpty", IsEmpty()));
        }



    }


    public class _InputDecoratorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inputdecorator.InputDecorator>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _InputDecoratorState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FloatingLabelController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ShakingLabelController { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator._InputBorderGap _BorderGap { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator.InputDecoration _EffectiveDecoration { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextAlign TextAlign { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFocused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsHovering { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEmpty { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _FloatingLabelEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasInlineLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _ShouldShowLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            bool labelIsInitiallyFloating = Widget.Decoration.FloatingLabelBehavior == FloatingLabelBehavior.Always || (Widget.Decoration.HasFloatingPlaceholder && Widget._LabelShouldWithdraw);
            _FloatingLabelController = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this, value: labelIsInitiallyFloating ? 1.0 : 0.0);
            _FloatingLabelController.AddListener(_HandleChange);
            _ShakingLabelController = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this);
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _EffectiveDecoration = null;
        }




        public new void Dispose()
        {
            _FloatingLabelController.Dispose();
            _ShakingLabelController.Dispose();
            base.Dispose();
        }




        private void _HandleChange()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator.InputDecorator old)
        {
            base.DidUpdateWidget(old);
            if (Widget.Decoration != old.Decoration) _EffectiveDecoration = null;
            bool floatBehaviourChanged = Widget.Decoration.FloatingLabelBehavior != old.Decoration.FloatingLabelBehavior || Widget.Decoration.HasFloatingPlaceholder != old.Decoration.HasFloatingPlaceholder;
            if (Widget._LabelShouldWithdraw != old._LabelShouldWithdraw || floatBehaviourChanged)
            {
                if (_FloatingLabelEnabled && (Widget._LabelShouldWithdraw || Widget.Decoration.FloatingLabelBehavior == FloatingLabelBehavior.Always)) _FloatingLabelController.Forward(); else _FloatingLabelController.Reverse();
            }

            string errorText = Decoration.ErrorText;
            string oldErrorText = old.Decoration.ErrorText;
            if (_FloatingLabelController.IsCompleted && errorText != null && errorText != oldErrorText)
            {
                ..Value = 0.0;
                _ShakingLabelController.Forward();
            }

        }




        private Color _GetActiveColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (IsFocused)
            {
                switch (themeData.Brightness) { case Brightness.Dark: return themeData.AccentColor; case Brightness.Light: return themeData.PrimaryColor; }
            }

            return themeData.HintColor;
        }




        private Color _GetDefaultBorderColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (IsFocused)
            {
                switch (themeData.Brightness) { case Brightness.Dark: return themeData.AccentColor; case Brightness.Light: return themeData.PrimaryColor; }
            }

            if (Decoration.Filled)
            {
                return themeData.HintColor;
            }

            Color enabledColor = themeData.ColorScheme.OnSurface.WithOpacity(0.38);
            if (IsHovering)
            {
                Color hoverColor = Decoration.HoverColor ?? themeData.InputDecorationTheme?.HoverColor ?? themeData.HoverColor;
                return Dart.UI.UiDefaultClass.Color.AlphaBlend(hoverColor.WithOpacity(0.12), enabledColor);
            }

            return enabledColor;
        }




        private Color _GetFillColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (Decoration.Filled != true) return ColorsDefaultClass.Colors.Transparent;
            if (Decoration.FillColor != null) return Decoration.FillColor;
            Color darkEnabled = new Color(0x1AFFFFFF);
            Color darkDisabled = new Color(0x0DFFFFFF);
            Color lightEnabled = new Color(0x0A000000);
            Color lightDisabled = new Color(0x05000000);
            switch (themeData.Brightness) { case Brightness.Dark: return Decoration.Enabled ? darkEnabled : darkDisabled; case Brightness.Light: return Decoration.Enabled ? lightEnabled : lightDisabled; }
            return lightEnabled;
        }




        private Color _GetHoverColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (Decoration.Filled == null || !Decoration.Filled || IsFocused || !Decoration.Enabled) return ColorsDefaultClass.Colors.Transparent;
            return Decoration.HoverColor ?? themeData.InputDecorationTheme?.HoverColor ?? themeData.HoverColor;
        }




        private Color _GetDefaultIconColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (!Decoration.Enabled) return themeData.DisabledColor;
            switch (themeData.Brightness) { case Brightness.Dark: return ColorsDefaultClass.Colors.White70; case Brightness.Light: return ColorsDefaultClass.Colors.Black45; default: return themeData.IconTheme.Color; }
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetInlineStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            return themeData.TextTheme.Subtitle1.Merge(Widget.BaseStyle).CopyWith(color: Decoration.Enabled ? themeData.HintColor : themeData.DisabledColor);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetFloatingLabelStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            Color color = Decoration.ErrorText != null ? Decoration.ErrorStyle?.Color ?? themeData.ErrorColor : _GetActiveColor(themeData);
            TextStyle style = themeData.TextTheme.Subtitle1.Merge(Widget.BaseStyle);
            return style.CopyWith(color: Decoration.Enabled ? color : themeData.DisabledColor).Merge(Decoration.LabelStyle);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetHelperStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            Color color = Decoration.Enabled ? themeData.HintColor : ColorsDefaultClass.Colors.Transparent;
            return themeData.TextTheme.Caption.CopyWith(color: color).Merge(Decoration.HelperStyle);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetErrorStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            Color color = Decoration.Enabled ? themeData.ErrorColor : ColorsDefaultClass.Colors.Transparent;
            return themeData.TextTheme.Caption.CopyWith(color: color).Merge(Decoration.ErrorStyle);
        }




        private FlutterSDK.Material.Inputborder.InputBorder _GetDefaultBorder(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (Decoration.Border?.BorderSide == BordersDefaultClass.BorderSide.None)
            {
                return Decoration.Border;
            }

            Color borderColor = default(Color);
            if (Decoration.Enabled)
            {
                borderColor = Decoration.ErrorText == null ? _GetDefaultBorderColor(themeData) : themeData.ErrorColor;
            }
            else
            {
                borderColor = (Decoration.Filled == true && Decoration.Border?.IsOutline != true) ? ColorsDefaultClass.Colors.Transparent : themeData.DisabledColor;
            }

            double borderWeight = default(double);
            if (Decoration.IsCollapsed || Decoration?.Border == InputborderDefaultClass.InputBorder.None || !Decoration.Enabled) borderWeight = 0.0; else borderWeight = IsFocused ? 2.0 : 1.0;
            InputBorder border = Decoration.Border ?? new UnderlineInputBorder();
            return border.CopyWith(borderSide: new BorderSide(color: borderColor, width: borderWeight));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            TextStyle inlineStyle = _GetInlineStyle(themeData);
            TextBaseline textBaseline = inlineStyle.TextBaseline;
            TextStyle hintStyle = inlineStyle.Merge(Decoration.HintStyle);
            Widget hint = Decoration.HintText == null ? null : new AnimatedOpacity(opacity: (IsEmpty() && !_HasInlineLabel) ? 1.0 : 0.0, duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, alwaysIncludeSemantics: true, child: new Text(Decoration.HintText, style: hintStyle, overflow: TextOverflow.Ellipsis, textAlign: TextAlign, maxLines: Decoration.HintMaxLines));
            bool isError = Decoration.ErrorText != null;
            InputBorder border = default(InputBorder);
            if (!Decoration.Enabled) border = isError ? Decoration.ErrorBorder : Decoration.DisabledBorder; else if (IsFocused) border = isError ? Decoration.FocusedErrorBorder : Decoration.FocusedBorder; else border = isError ? Decoration.ErrorBorder : Decoration.EnabledBorder;
            border = (border == null ? _GetDefaultBorder(themeData) : border);
            Widget container = new _BorderContainer(border: border, gap: _BorderGap, gapAnimation: _FloatingLabelController.View, fillColor: _GetFillColor(themeData), hoverColor: _GetHoverColor(themeData), isHovering: IsHovering);
            TextStyle inlineLabelStyle = inlineStyle.Merge(Decoration.LabelStyle);
            Widget label = Decoration.LabelText == null ? null : new _Shaker(animation: _ShakingLabelController.View, child: new AnimatedOpacity(duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, opacity: _ShouldShowLabel ? 1.0 : 0.0, child: new AnimatedDefaultTextStyle(duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, style: Widget._LabelShouldWithdraw ? _GetFloatingLabelStyle(themeData) : inlineLabelStyle, child: new Text(Decoration.LabelText, overflow: TextOverflow.Ellipsis, textAlign: TextAlign))));
            Widget prefix = Decoration.Prefix == null && Decoration.PrefixText == null ? null : new _AffixText(labelIsFloating: Widget._LabelShouldWithdraw, text: Decoration.PrefixText, style: Decoration.PrefixStyle ?? hintStyle, child: Decoration.Prefix);
            Widget suffix = Decoration.Suffix == null && Decoration.SuffixText == null ? null : new _AffixText(labelIsFloating: Widget._LabelShouldWithdraw, text: Decoration.SuffixText, style: Decoration.SuffixStyle ?? hintStyle, child: Decoration.Suffix);
            Color activeColor = _GetActiveColor(themeData);
            bool decorationIsDense = Decoration.IsDense == true;
            double iconSize = decorationIsDense ? 18.0 : 24.0;
            Color iconColor = IsFocused ? activeColor : _GetDefaultIconColor(themeData);
            Widget icon = Decoration.Icon == null ? null : new Padding(padding: EdgeInsetsDirectional.Only(end: 16.0), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: iconColor, size: iconSize), child: Decoration.Icon));
            Widget prefixIcon = Decoration.PrefixIcon == null ? null : new Center(widthFactor: 1.0, heightFactor: 1.0, child: new ConstrainedBox(constraints: Decoration.PrefixIconConstraints ?? themeData.VisualDensity.EffectiveConstraints(new BoxConstraints(minWidth: ConstantsDefaultClass.KMinInteractiveDimension, minHeight: ConstantsDefaultClass.KMinInteractiveDimension)), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: iconColor, size: iconSize), child: Decoration.PrefixIcon)));
            Widget suffixIcon = Decoration.SuffixIcon == null ? null : new Center(widthFactor: 1.0, heightFactor: 1.0, child: new ConstrainedBox(constraints: Decoration.SuffixIconConstraints ?? themeData.VisualDensity.EffectiveConstraints(new BoxConstraints(minWidth: ConstantsDefaultClass.KMinInteractiveDimension, minHeight: ConstantsDefaultClass.KMinInteractiveDimension)), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: iconColor, size: iconSize), child: Decoration.SuffixIcon)));
            Widget helperError = new _HelperError(textAlign: TextAlign, helperText: Decoration.HelperText, helperStyle: _GetHelperStyle(themeData), helperMaxLines: Decoration.HelperMaxLines, errorText: Decoration.ErrorText, errorStyle: _GetErrorStyle(themeData), errorMaxLines: Decoration.ErrorMaxLines);
            Widget counter = default(Widget);
            if (Decoration.Counter != null)
            {
                counter = Decoration.Counter;
            }
            else if (Decoration.CounterText != null && Decoration.CounterText != "")
            {
                counter = new Semantics(container: true, liveRegion: IsFocused, child: new Text(Decoration.CounterText, style: _GetHelperStyle(themeData).Merge(Decoration.CounterStyle), overflow: TextOverflow.Ellipsis, semanticsLabel: Decoration.SemanticCounterText));
            }

            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            EdgeInsets decorationContentPadding = Decoration.ContentPadding?.Resolve(textDirection);
            EdgeInsets contentPadding = default(EdgeInsets);
            double floatingLabelHeight = default(double);
            if (Decoration.IsCollapsed)
            {
                floatingLabelHeight = 0.0;
                contentPadding = decorationContentPadding ?? EdgeinsetsDefaultClass.EdgeInsets.Zero;
            }
            else if (!border.IsOutline)
            {
                floatingLabelHeight = (4.0 + 0.75 * inlineLabelStyle.FontSize) * MediaqueryDefaultClass.MediaQuery.TextScaleFactorOf(context);
                if (Decoration.Filled == true)
                {
                    contentPadding = decorationContentPadding ?? (decorationIsDense ? EdgeInsets.FromLTRB(12.0, 8.0, 12.0, 8.0) : EdgeInsets.FromLTRB(12.0, 12.0, 12.0, 12.0));
                }
                else
                {
                    contentPadding = decorationContentPadding ?? (decorationIsDense ? EdgeInsets.FromLTRB(0.0, 8.0, 0.0, 8.0) : EdgeInsets.FromLTRB(0.0, 12.0, 0.0, 12.0));
                }

            }
            else
            {
                floatingLabelHeight = 0.0;
                contentPadding = decorationContentPadding ?? (decorationIsDense ? EdgeInsets.FromLTRB(12.0, 20.0, 12.0, 12.0) : EdgeInsets.FromLTRB(12.0, 24.0, 12.0, 16.0));
            }

            return new _Decorator(decoration: new _Decoration(contentPadding: contentPadding, isCollapsed: Decoration.IsCollapsed, floatingLabelHeight: floatingLabelHeight, floatingLabelProgress: _FloatingLabelController.Value, border: border, borderGap: _BorderGap, alignLabelWithHint: Decoration.AlignLabelWithHint, isDense: Decoration.IsDense, visualDensity: themeData.VisualDensity, icon: icon, input: Widget.Child, label: label, hint: hint, prefix: prefix, suffix: suffix, prefixIcon: prefixIcon, suffixIcon: suffixIcon, helperError: helperError, counter: counter, container: container), textDirection: textDirection, textBaseline: textBaseline, textAlignVertical: Widget.TextAlignVertical, isFocused: IsFocused, expands: Widget.Expands);
        }



    }


    /// <Summary>
    /// The border, labels, icons, and styles used to decorate a Material
    /// Design text field.
    ///
    /// The [TextField] and [InputDecorator] classes use [InputDecoration] objects
    /// to describe their decoration. (In fact, this class is merely the
    /// configuration of an [InputDecorator], which does all the heavy lifting.)
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to style a `TextField` using an `InputDecorator`. The
    /// TextField displays a "send message" icon to the left of the input area,
    /// which is surrounded by a border an all sides. It displays the `hintText`
    /// inside the input area to help the user understand what input is required. It
    /// displays the `helperText` and `counterText` below the input area.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextField(
    ///     decoration: InputDecoration(
    ///       icon: Icon(Icons.send),
    ///       hintText: 'Hint Text',
    ///       helperText: 'Helper Text',
    ///       counterText: '0 characters',
    ///       border: const OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to style a "collapsed" `TextField` using an
    /// `InputDecorator`. The collapsed `TextField` surrounds the hint text and
    /// input area with a border, but does not add padding around them.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration_collapsed.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextField(
    ///     decoration: InputDecoration.collapsed(
    ///       hintText: 'Hint Text',
    ///       border: OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to create a `TextField` with hint text, a red border
    /// on all sides, and an error message. To display a red border and error
    /// message, provide `errorText` to the `InputDecoration` constructor.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration_error.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextField(
    ///     decoration: InputDecoration(
    ///       hintText: 'Hint Text',
    ///       errorText: 'Error Text',
    ///       border: OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to style a `TextField` with a round border and
    /// additional text before and after the input area. It displays "Prefix" before
    /// the input area, and "Suffix" after the input area.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration_prefix_suffix.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextFormField(
    ///     initialValue: 'abc',
    ///     decoration: const InputDecoration(
    ///       prefix: Text('Prefix'),
    ///       suffix: Text('Suffix'),
    ///       border: OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [TextField], which is a text input widget that uses an
    ///    [InputDecoration].
    ///  * [InputDecorator], which is a widget that draws an [InputDecoration]
    ///    around an input child widget.
    ///  * [Decoration] and [DecoratedBox], for drawing borders and backgrounds
    ///    around a child widget.
    /// </Summary>
    public class InputDecoration
    {
        /// <Summary>
        /// Creates a bundle of the border, labels, icons, and styles used to
        /// decorate a Material Design text field.
        ///
        /// Unless specified by [ThemeData.inputDecorationTheme],
        /// [InputDecorator] defaults [isDense] to false, and [filled] to false,
        /// and [maxLines] to 1. The default border is an instance
        /// of [UnderlineInputBorder]. If [border] is [InputBorder.none] then
        /// no border is drawn.
        ///
        /// The [enabled] argument must not be null.
        ///
        /// Only one of [prefix] and [prefixText] can be specified.
        ///
        /// Similarly, only one of [suffix] and [suffixText] can be specified.
        /// </Summary>
        public InputDecoration(FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), string labelText = default(string), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string hintText = default(string), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int hintMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = true, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.Box.BoxConstraints prefixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), string prefixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), string suffixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints suffixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), string counterText = default(string), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = true, string semanticCounterText = default(string), bool alignLabelWithHint = default(bool))
        : base()
        {
            this.Icon = icon;
            this.LabelText = labelText;
            this.LabelStyle = labelStyle;
            this.HelperText = helperText;
            this.HelperStyle = helperStyle;
            this.HelperMaxLines = helperMaxLines;
            this.HintText = hintText;
            this.HintStyle = hintStyle;
            this.HintMaxLines = hintMaxLines;
            this.ErrorText = errorText;
            this.ErrorStyle = errorStyle;
            this.ErrorMaxLines = errorMaxLines;
            this.HasFloatingPlaceholder = hasFloatingPlaceholder;
            this.FloatingLabelBehavior = floatingLabelBehavior;
            this.IsDense = isDense;
            this.ContentPadding = contentPadding;
            this.PrefixIcon = prefixIcon;
            this.PrefixIconConstraints = prefixIconConstraints;
            this.Prefix = prefix;
            this.PrefixText = prefixText;
            this.PrefixStyle = prefixStyle;
            this.SuffixIcon = suffixIcon;
            this.Suffix = suffix;
            this.SuffixText = suffixText;
            this.SuffixStyle = suffixStyle;
            this.SuffixIconConstraints = suffixIconConstraints;
            this.Counter = counter;
            this.CounterText = counterText;
            this.CounterStyle = counterStyle;
            this.Filled = filled;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.ErrorBorder = errorBorder;
            this.FocusedBorder = focusedBorder;
            this.FocusedErrorBorder = focusedErrorBorder;
            this.DisabledBorder = disabledBorder;
            this.EnabledBorder = enabledBorder;
            this.Border = border;
            this.Enabled = enabled;
            this.SemanticCounterText = semanticCounterText;
            this.AlignLabelWithHint = alignLabelWithHint;
        }
        /// <Summary>
        /// Defines an [InputDecorator] that is the same size as the input field.
        ///
        /// This type of input decoration does not include a border by default.
        ///
        /// Sets the [isCollapsed] property to true.
        /// </Summary>
        public static InputDecoration Collapsed(string hintText = default(string), bool hasFloatingPlaceholder = true, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = false, FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = true)
        => new InputDecoration(hintText, hasFloatingPlaceholder, floatingLabelBehavior, hintStyle, filled, fillColor, focusColor, hoverColor, border, enabled);

        private InputDecoration(string hintText, bool hasFloatingPlaceholder, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior, FlutterSDK.Painting.Textstyle.TextStyle hintStyle, bool filled, FlutterBinding.UI.Color fillColor, FlutterBinding.UI.Color focusColor, FlutterBinding.UI.Color hoverColor, FlutterSDK.Material.Inputborder.InputBorder border, bool enabled)
        : base()
        {
            this.HintText = hintText;
            this.HasFloatingPlaceholder = hasFloatingPlaceholder;
            this.FloatingLabelBehavior = floatingLabelBehavior;
            this.HintStyle = hintStyle;
            this.Filled = filled;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.Border = border;
            this.Enabled = enabled;
        }
        /// <Summary>
        /// An icon to show before the input field and outside of the decoration's
        /// container.
        ///
        /// The size and color of the icon is configured automatically using an
        /// [IconTheme] and therefore does not need to be explicitly given in the
        /// icon widget.
        ///
        /// The trailing edge of the icon is padded by 16dps.
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        ///
        /// See [Icon], [ImageIcon].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        /// <Summary>
        /// Text that describes the input field.
        ///
        /// When the input field is empty and unfocused, the label is displayed on
        /// top of the input field (i.e., at the same location on the screen where
        /// text may be entered in the input field). When the input field receives
        /// focus (or if the field is non-empty), the label moves above (i.e.,
        /// vertically adjacent to) the input field.
        /// </Summary>
        public virtual string LabelText { get; set; }
        /// <Summary>
        /// The style to use for the [labelText] when the label is above (i.e.,
        /// vertically adjacent to) the input field.
        ///
        /// When the [labelText] is on top of the input field, the text uses the
        /// [hintStyle] instead.
        ///
        /// If null, defaults to a value derived from the base [TextStyle] for the
        /// input field and the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        /// <Summary>
        /// Text that provides context about the input [child]'s value, such as how
        /// the value will be used.
        ///
        /// If non-null, the text is displayed below the input [child], in the same
        /// location as [errorText]. If a non-null [errorText] value is specified then
        /// the helper text is not shown.
        /// </Summary>
        public virtual string HelperText { get; set; }
        /// <Summary>
        /// The style to use for the [helperText].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HelperStyle { get; set; }
        /// <Summary>
        /// The maximum number of lines the [helperText] can occupy.
        ///
        /// Defaults to null, which means that the [helperText] will be limited
        /// to a single line with [TextOverflow.ellipsis].
        ///
        /// This value is passed along to the [Text.maxLines] attribute
        /// of the [Text] widget used to display the helper.
        ///
        /// See also:
        ///
        ///  * [errorMaxLines], the equivalent but for the [errorText].
        /// </Summary>
        public virtual int HelperMaxLines { get; set; }
        /// <Summary>
        /// Text that suggests what sort of input the field accepts.
        ///
        /// Displayed on top of the input [child] (i.e., at the same location on the
        /// screen where text may be entered in the input [child]) when the input
        /// [isEmpty] and either (a) [labelText] is null or (b) the input has the focus.
        /// </Summary>
        public virtual string HintText { get; set; }
        /// <Summary>
        /// The style to use for the [hintText].
        ///
        /// Also used for the [labelText] when the [labelText] is displayed on
        /// top of the input field (i.e., at the same location on the screen where
        /// text may be entered in the input [child]).
        ///
        /// If null, defaults to a value derived from the base [TextStyle] for the
        /// input field and the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HintStyle { get; set; }
        /// <Summary>
        /// The maximum number of lines the [hintText] can occupy.
        ///
        /// Defaults to the value of [TextField.maxLines] attribute.
        ///
        /// This value is passed along to the [Text.maxLines] attribute
        /// of the [Text] widget used to display the hint text. [TextOverflow.ellipsis] is
        /// used to handle the overflow when it is limited to single line.
        /// </Summary>
        public virtual int HintMaxLines { get; set; }
        /// <Summary>
        /// Text that appears below the input [child] and the border.
        ///
        /// If non-null, the border's color animates to red and the [helperText] is
        /// not shown.
        ///
        /// In a [TextFormField], this is overridden by the value returned from
        /// [TextFormField.validator], if that is not null.
        /// </Summary>
        public virtual string ErrorText { get; set; }
        /// <Summary>
        /// The style to use for the [errorText].
        ///
        /// If null, defaults of a value derived from the base [TextStyle] for the
        /// input field and the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ErrorStyle { get; set; }
        /// <Summary>
        /// The maximum number of lines the [errorText] can occupy.
        ///
        /// Defaults to null, which means that the [errorText] will be limited
        /// to a single line with [TextOverflow.ellipsis].
        ///
        /// This value is passed along to the [Text.maxLines] attribute
        /// of the [Text] widget used to display the error.
        ///
        /// See also:
        ///
        ///  * [helperMaxLines], the equivalent but for the [helperText].
        /// </Summary>
        public virtual int ErrorMaxLines { get; set; }
        /// <Summary>
        /// Whether the label floats on focus.
        ///
        /// If this is false, the placeholder disappears when the input has focus or
        /// text has been entered.
        /// If this is true, the placeholder will rise to the top of the input when
        /// the input has focus or text has been entered.
        ///
        /// Defaults to true.
        ///
        /// </Summary>
        public virtual bool HasFloatingPlaceholder { get; set; }
        /// <Summary>
        /// {@template flutter.material.inputDecoration.floatingLabelBehavior}
        /// Defines how the floating label should be displayed.
        ///
        /// When [FloatingLabelBehavior.auto] the label will float to the top only when
        /// the field is focused or has some text content, otherwise it will appear
        /// in the field in place of the content.
        ///
        /// When [FloatingLabelBehavior.always] the label will always float at the top
        /// of the field above the content.
        ///
        /// When [FloatingLabelBehavior.never] the label will always appear in an empty
        /// field in place of the content.
        ///
        /// Defaults to [FloatingLabelBehavior.auto].
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior FloatingLabelBehavior { get; set; }
        /// <Summary>
        /// Whether the input [child] is part of a dense form (i.e., uses less vertical
        /// space).
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool IsDense { get; set; }
        /// <Summary>
        /// The padding for the input decoration's container.
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        ///
        /// By default the `contentPadding` reflects [isDense] and the type of the
        /// [border].
        ///
        /// If [isCollapsed] is true then `contentPadding` is [EdgeInsets.zero].
        ///
        /// If `isOutline` property of [border] is false and if [filled] is true then
        /// `contentPadding` is `EdgeInsets.fromLTRB(12, 8, 12, 8)` when [isDense]
        /// is true and `EdgeInsets.fromLTRB(12, 12, 12, 12)` when [isDense] is false`.
        /// If `isOutline` property of [border] is false and if [filled] is false then
        /// `contentPadding` is `EdgeInsets.fromLTRB(0, 8, 0, 8)` when [isDense] is
        /// true and `EdgeInsets.fromLTRB(0, 12, 0, 12)` when [isDense] is false`.
        ///
        /// If `isOutline` property of [border] is true then `contentPaddding` is
        /// `EdgeInsets.fromLTRB(12, 20, 12, 12)` when [isDense] is true
        /// and `EdgeInsets.fromLTRB(12, 24, 12, 16)` when [isDense] is false.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        /// <Summary>
        /// Whether the decoration is the same size as the input field.
        ///
        /// A collapsed decoration cannot have [labelText], [errorText], an [icon].
        ///
        /// To create a collapsed input decoration, use [InputDecoration..collapsed].
        /// </Summary>
        public virtual bool IsCollapsed { get; set; }
        /// <Summary>
        /// An icon that appears before the [prefix] or [prefixText] and before
        /// the editable part of the text field, within the decoration's container.
        ///
        /// The size and color of the prefix icon is configured automatically using an
        /// [IconTheme] and therefore does not need to be explicitly given in the
        /// icon widget.
        ///
        /// The prefix icon is constrained with a minimum size of 48px by 48px, but
        /// can be expanded beyond that. Anything larger than 24px will require
        /// additional padding to ensure it matches the material spec of 12px padding
        /// between the left edge of the input and leading edge of the prefix icon.
        /// The following snippet shows how to pad the leading edge of the prefix
        /// icon:
        ///
        /// ```dart
        /// prefixIcon: Padding(
        ///   padding: const EdgeInsetsDirectional.only(start: 12.0),
        ///   child: myIcon, // myIcon is a 48px-wide widget.
        /// )
        /// ```
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        ///
        /// See also:
        ///
        ///  * [Icon] and [ImageIcon], which are typically used to show icons.
        ///  * [prefix] and [prefixText], which are other ways to show content
        ///    before the text field (but after the icon).
        ///  * [suffixIcon], which is the same but on the trailing edge.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget PrefixIcon { get; set; }
        /// <Summary>
        /// The constraints for the prefix icon.
        ///
        /// This can be used to modify the [BoxConstraints] surrounding [prefixIcon].
        ///
        /// This property is particularly useful for getting the decoration's height
        /// less than 48px. This can be achieved by setting [isDense] to true and
        /// setting the constraints' minimum height and width to a value lower than
        /// 48px.
        ///
        /// {@tool dartpad --template=stateless_widget_scaffold}
        /// This example shows the differences between two `TextField` widgets when
        /// [prefixIconConstraints] is set to the default value and when one is not.
        ///
        /// Note that [isDense] must be set to true to be able to
        /// set the constraints smaller than 48px.
        ///
        /// If null, [BoxConstraints] with a minimum width and height of 48px is
        /// used.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return Padding(
        ///     padding: const EdgeInsets.symmetric(horizontal: 8.0),
        ///     child: Column(
        ///       mainAxisAlignment: MainAxisAlignment.center,
        ///       children: <Widget>[
        ///         TextField(
        ///           decoration: InputDecoration(
        ///             hintText: 'Normal Icon Constraints',
        ///             prefixIcon: Icon(Icons.search),
        ///           ),
        ///         ),
        ///         SizedBox(height: 10),
        ///         TextField(
        ///           decoration: InputDecoration(
        ///             isDense: true,
        ///             hintText:'Smaller Icon Constraints',
        ///             prefixIcon: Icon(Icons.search),
        ///             prefixIconConstraints: BoxConstraints(
        ///               minHeight: 32,
        ///               minWidth: 32,
        ///             ),
        ///           ),
        ///         ),
        ///       ],
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints PrefixIconConstraints { get; set; }
        /// <Summary>
        /// Optional widget to place on the line before the input.
        ///
        /// This can be used, for example, to add some padding to text that would
        /// otherwise be specified using [prefixText], or to add a custom widget in
        /// front of the input. The widget's baseline is lined up with the input
        /// baseline.
        ///
        /// Only one of [prefix] and [prefixText] can be specified.
        ///
        /// The [prefix] appears after the [prefixIcon], if both are specified.
        ///
        /// See also:
        ///
        ///  * [suffix], the equivalent but on the trailing edge.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Prefix { get; set; }
        /// <Summary>
        /// Optional text prefix to place on the line before the input.
        ///
        /// Uses the [prefixStyle]. Uses [hintStyle] if [prefixStyle] isn't specified.
        /// The prefix text is not returned as part of the user's input.
        ///
        /// If a more elaborate prefix is required, consider using [prefix] instead.
        /// Only one of [prefix] and [prefixText] can be specified.
        ///
        /// The [prefixText] appears after the [prefixIcon], if both are specified.
        ///
        /// See also:
        ///
        ///  * [suffixText], the equivalent but on the trailing edge.
        /// </Summary>
        public virtual string PrefixText { get; set; }
        /// <Summary>
        /// The style to use for the [prefixText].
        ///
        /// If null, defaults to the [hintStyle].
        ///
        /// See also:
        ///
        ///  * [suffixStyle], the equivalent but on the trailing edge.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PrefixStyle { get; set; }
        /// <Summary>
        /// An icon that appears after the editable part of the text field and
        /// after the [suffix] or [suffixText], within the decoration's container.
        ///
        /// The size and color of the suffix icon is configured automatically using an
        /// [IconTheme] and therefore does not need to be explicitly given in the
        /// icon widget.
        ///
        /// The suffix icon is constrained with a minimum size of 48px by 48px, but
        /// can be expanded beyond that. Anything larger than 24px will require
        /// additional padding to ensure it matches the material spec of 12px padding
        /// between the right edge of the input and trailing edge of the prefix icon.
        /// The following snippet shows how to pad the trailing edge of the suffix
        /// icon:
        ///
        /// ```dart
        /// suffixIcon: Padding(
        ///   padding: const EdgeInsetsDirectional.only(end: 12.0),
        ///   child: myIcon, // myIcon is a 48px-wide widget.
        /// )
        /// ```
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        ///
        /// See also:
        ///
        ///  * [Icon] and [ImageIcon], which are typically used to show icons.
        ///  * [suffix] and [suffixText], which are other ways to show content
        ///    after the text field (but before the icon).
        ///  * [prefixIcon], which is the same but on the leading edge.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget SuffixIcon { get; set; }
        /// <Summary>
        /// Optional widget to place on the line after the input.
        ///
        /// This can be used, for example, to add some padding to the text that would
        /// otherwise be specified using [suffixText], or to add a custom widget after
        /// the input. The widget's baseline is lined up with the input baseline.
        ///
        /// Only one of [suffix] and [suffixText] can be specified.
        ///
        /// The [suffix] appears before the [suffixIcon], if both are specified.
        ///
        /// See also:
        ///
        ///  * [prefix], the equivalent but on the leading edge.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Suffix { get; set; }
        /// <Summary>
        /// Optional text suffix to place on the line after the input.
        ///
        /// Uses the [suffixStyle]. Uses [hintStyle] if [suffixStyle] isn't specified.
        /// The suffix text is not returned as part of the user's input.
        ///
        /// If a more elaborate suffix is required, consider using [suffix] instead.
        /// Only one of [suffix] and [suffixText] can be specified.
        ///
        /// The [suffixText] appears before the [suffixIcon], if both are specified.
        ///
        /// See also:
        ///
        ///  * [prefixText], the equivalent but on the leading edge.
        /// </Summary>
        public virtual string SuffixText { get; set; }
        /// <Summary>
        /// The style to use for the [suffixText].
        ///
        /// If null, defaults to the [hintStyle].
        ///
        /// See also:
        ///
        ///  * [prefixStyle], the equivalent but on the leading edge.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SuffixStyle { get; set; }
        /// <Summary>
        /// The constraints for the suffix icon.
        ///
        /// This can be used to modify the [BoxConstraints] surrounding [suffixIcon].
        ///
        /// This property is particularly useful for getting the decoration's height
        /// less than 48px. This can be achieved by setting [isDense] to true and
        /// setting the constraints' minimum height and width to a value lower than
        /// 48px.
        ///
        /// If null, a [BoxConstraints] with a minimum width and height of 48px is
        /// used.
        ///
        /// {@tool dartpad --template=stateless_widget_scaffold}
        /// This example shows the differences between two `TextField` widgets when
        /// [suffixIconConstraints] is set to the default value and when one is not.
        ///
        /// Note that [isDense] must be set to true to be able to
        /// set the constraints smaller than 48px.
        ///
        /// If null, [BoxConstraints] with a minimum width and height of 48px is
        /// used.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return Padding(
        ///     padding: const EdgeInsets.symmetric(horizontal: 8.0),
        ///     child: Column(
        ///       mainAxisAlignment: MainAxisAlignment.center,
        ///       children: <Widget>[
        ///         TextField(
        ///           decoration: InputDecoration(
        ///             hintText: 'Normal Icon Constraints',
        ///             suffixIcon: Icon(Icons.search),
        ///           ),
        ///         ),
        ///         SizedBox(height: 10),
        ///         TextField(
        ///           decoration: InputDecoration(
        ///             isDense: true,
        ///             hintText:'Smaller Icon Constraints',
        ///             suffixIcon: Icon(Icons.search),
        ///             suffixIconConstraints: BoxConstraints(
        ///               minHeight: 32,
        ///               minWidth: 32,
        ///             ),
        ///           ),
        ///         ),
        ///       ],
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.BoxConstraints SuffixIconConstraints { get; set; }
        /// <Summary>
        /// Optional text to place below the line as a character count.
        ///
        /// Rendered using [counterStyle]. Uses [helperStyle] if [counterStyle] is
        /// null.
        ///
        /// The semantic label can be replaced by providing a [semanticCounterText].
        ///
        /// If null or an empty string and [counter] isn't specified, then nothing
        /// will appear in the counter's location.
        /// </Summary>
        public virtual string CounterText { get; set; }
        /// <Summary>
        /// Optional custom counter widget to go in the place otherwise occupied by
        /// [counterText].  If this property is non null, then [counterText] is
        /// ignored.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Counter { get; set; }
        /// <Summary>
        /// The style to use for the [counterText].
        ///
        /// If null, defaults to the [helperStyle].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle CounterStyle { get; set; }
        /// <Summary>
        /// If true the decoration's container is filled with [fillColor].
        ///
        /// When [isFocused] is true, the [focusColor] is also blended into the final
        /// fill color.  When [isHovering] is true, the [hoverColor] is also blended
        /// into the final fill color.
        ///
        /// Typically this field set to true if [border] is an
        /// [UnderlineInputBorder].
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        ///
        /// This property is false by default.
        /// </Summary>
        public virtual bool Filled { get; set; }
        /// <Summary>
        /// The base fill color of the decoration's container color.
        ///
        /// When [isFocused] is true, the [focusColor] is also blended into the final
        /// fill color.  When [isHovering] is true, the [hoverColor] is also blended
        /// into the final fill color.
        ///
        /// By default the fillColor is based on the current [Theme].
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        ///
        /// This color is blended with [focusColor] if the decoration is focused.
        /// </Summary>
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        /// <Summary>
        /// The color to blend with [fillColor] and fill the decoration's container
        /// with, if [filled] is true and the container has input focus.
        ///
        /// When [isHovering] is true, the [hoverColor] is also blended into the final
        /// fill color.
        ///
        /// By default the [focusColor] is based on the current [Theme].
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        /// </Summary>
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        /// <Summary>
        /// The color of the focus highlight for the decoration shown if the container
        /// is being hovered over by a mouse.
        ///
        /// If [filled] is true, the color is blended with [fillColor] and fills the
        /// decoration's container. When [isFocused] is true, the [focusColor] is also
        /// blended into the final fill color.
        ///
        /// If [filled] is false, and [isFocused] is false, the color is blended over
        /// the [enabledBorder]'s color.
        ///
        /// By default the [hoverColor] is based on the current [Theme].
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [decoration.icon] and above the widgets that contain [helperText],
        /// [errorText], and [counterText].
        /// </Summary>
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] does not have the focus and
        /// is showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecorator.isFocused], which is true if the [InputDecorator]'s child
        ///    has the focus.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder ErrorBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] has the focus and is not
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecorator.isFocused], which is true if the [InputDecorator]'s child
        ///    has the focus.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] has the focus and is
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecorator.isFocused], which is true if the [InputDecorator]'s child
        ///    has the focus.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedErrorBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] is disabled and is not
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.enabled], which is false if the [InputDecorator] is disabled.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder DisabledBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] is enabled and is not
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.enabled], which is false if the [InputDecorator] is disabled.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder EnabledBorder { get; set; }
        /// <Summary>
        /// The shape of the border to draw around the decoration's container.
        ///
        /// This border's [InputBorder.borderSide], i.e. the border's color and width,
        /// will be overridden to reflect the input decorator's state. Only the
        /// border's shape is used. If custom  [BorderSide] values are desired for
        /// a given state, all four borders – [errorBorder], [focusedBorder],
        /// [enabledBorder], [disabledBorder] – must be set.
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [InputDecoration.icon] and above the widgets that contain
        /// [InputDecoration.helperText], [InputDecoration.errorText], and
        /// [InputDecoration.counterText].
        ///
        /// The border's bounds, i.e. the value of `border.getOuterPath()`, define
        /// the area to be filled.
        ///
        /// This property is only used when the appropriate one of [errorBorder],
        /// [focusedBorder], [focusedErrorBorder], [disabledBorder], or [enabledBorder]
        /// is not specified. This border's [InputBorder.borderSide] property is
        /// configured by the InputDecorator, depending on the values of
        /// [InputDecoration.errorText], [InputDecoration.enabled],
        /// [InputDecorator.isFocused] and the current [Theme].
        ///
        /// Typically one of [UnderlineInputBorder] or [OutlineInputBorder].
        /// If null, InputDecorator's default is `const UnderlineInputBorder()`.
        ///
        /// See also:
        ///
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [UnderlineInputBorder], which draws a horizontal line at the
        ///    bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        /// <Summary>
        /// If false [helperText],[errorText], and [counterText] are not displayed,
        /// and the opacity of the remaining visual elements is reduced.
        ///
        /// This property is true by default.
        /// </Summary>
        public virtual bool Enabled { get; set; }
        /// <Summary>
        /// A semantic label for the [counterText].
        ///
        /// Defaults to null.
        ///
        /// If provided, this replaces the semantic label of the [counterText].
        /// </Summary>
        public virtual string SemanticCounterText { get; set; }
        /// <Summary>
        /// Typically set to true when the [InputDecorator] contains a multiline
        /// [TextField] ([TextField.maxLines] is null or > 1) to override the default
        /// behavior of aligning the label with the center of the [TextField].
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool AlignLabelWithHint { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this input decoration with the given fields replaced
        /// by the new values.
        ///
        /// Always sets [isCollapsed] to false.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration CopyWith(FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), string labelText = default(string), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string hintText = default(string), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int hintMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = default(bool), FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), string prefixText = default(string), FlutterSDK.Rendering.Box.BoxConstraints prefixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), string suffixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints suffixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), string counterText = default(string), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = default(bool), string semanticCounterText = default(string), bool alignLabelWithHint = default(bool))
        {
            return new InputDecoration(icon: icon ?? this.Icon, labelText: labelText ?? this.LabelText, labelStyle: labelStyle ?? this.LabelStyle, helperText: helperText ?? this.HelperText, helperStyle: helperStyle ?? this.HelperStyle, helperMaxLines: helperMaxLines ?? this.HelperMaxLines, hintText: hintText ?? this.HintText, hintStyle: hintStyle ?? this.HintStyle, hintMaxLines: hintMaxLines ?? this.HintMaxLines, errorText: errorText ?? this.ErrorText, errorStyle: errorStyle ?? this.ErrorStyle, errorMaxLines: errorMaxLines ?? this.ErrorMaxLines, hasFloatingPlaceholder: hasFloatingPlaceholder ?? this.HasFloatingPlaceholder, floatingLabelBehavior: floatingLabelBehavior ?? this.FloatingLabelBehavior, isDense: isDense ?? this.IsDense, contentPadding: contentPadding ?? this.ContentPadding, prefixIcon: prefixIcon ?? this.PrefixIcon, prefix: prefix ?? this.Prefix, prefixText: prefixText ?? this.PrefixText, prefixStyle: prefixStyle ?? this.PrefixStyle, prefixIconConstraints: prefixIconConstraints ?? this.PrefixIconConstraints, suffixIcon: suffixIcon ?? this.SuffixIcon, suffix: suffix ?? this.Suffix, suffixText: suffixText ?? this.SuffixText, suffixStyle: suffixStyle ?? this.SuffixStyle, suffixIconConstraints: suffixIconConstraints ?? this.SuffixIconConstraints, counter: counter ?? this.Counter, counterText: counterText ?? this.CounterText, counterStyle: counterStyle ?? this.CounterStyle, filled: filled ?? this.Filled, fillColor: fillColor ?? this.FillColor, focusColor: focusColor ?? this.FocusColor, hoverColor: hoverColor ?? this.HoverColor, errorBorder: errorBorder ?? this.ErrorBorder, focusedBorder: focusedBorder ?? this.FocusedBorder, focusedErrorBorder: focusedErrorBorder ?? this.FocusedErrorBorder, disabledBorder: disabledBorder ?? this.DisabledBorder, enabledBorder: enabledBorder ?? this.EnabledBorder, border: border ?? this.Border, enabled: enabled ?? this.Enabled, semanticCounterText: semanticCounterText ?? this.SemanticCounterText, alignLabelWithHint: alignLabelWithHint ?? this.AlignLabelWithHint);
        }




        /// <Summary>
        /// Used by widgets like [TextField] and [InputDecorator] to create a new
        /// [InputDecoration] with default values taken from the [theme].
        ///
        /// Only null valued properties from this [InputDecoration] are replaced
        /// by the corresponding values from [theme].
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration ApplyDefaults(FlutterSDK.Material.Inputdecorator.InputDecorationTheme theme)
        {
            return CopyWith(labelStyle: LabelStyle ?? theme.LabelStyle, helperStyle: HelperStyle ?? theme.HelperStyle, helperMaxLines: HelperMaxLines ?? theme.HelperMaxLines, hintStyle: HintStyle ?? theme.HintStyle, errorStyle: ErrorStyle ?? theme.ErrorStyle, errorMaxLines: ErrorMaxLines ?? theme.ErrorMaxLines, hasFloatingPlaceholder: HasFloatingPlaceholder ?? theme.HasFloatingPlaceholder, floatingLabelBehavior: FloatingLabelBehavior ?? theme.FloatingLabelBehavior, isDense: IsDense ?? theme.IsDense, contentPadding: ContentPadding ?? theme.ContentPadding, prefixStyle: PrefixStyle ?? theme.PrefixStyle, suffixStyle: SuffixStyle ?? theme.SuffixStyle, counterStyle: CounterStyle ?? theme.CounterStyle, filled: Filled ?? theme.Filled, fillColor: FillColor ?? theme.FillColor, focusColor: FocusColor ?? theme.FocusColor, hoverColor: HoverColor ?? theme.HoverColor, errorBorder: ErrorBorder ?? theme.ErrorBorder, focusedBorder: FocusedBorder ?? theme.FocusedBorder, focusedErrorBorder: FocusedErrorBorder ?? theme.FocusedErrorBorder, disabledBorder: DisabledBorder ?? theme.DisabledBorder, enabledBorder: EnabledBorder ?? theme.EnabledBorder, border: Border ?? theme.Border, alignLabelWithHint: AlignLabelWithHint ?? theme.AlignLabelWithHint);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is InputDecoration && other.Icon == Icon && other.LabelText == LabelText && other.LabelStyle == LabelStyle && other.HelperText == HelperText && other.HelperStyle == HelperStyle && other.HelperMaxLines == HelperMaxLines && other.HintText == HintText && other.HintStyle == HintStyle && other.HintMaxLines == HintMaxLines && other.ErrorText == ErrorText && other.ErrorStyle == ErrorStyle && other.ErrorMaxLines == ErrorMaxLines && other.HasFloatingPlaceholder == HasFloatingPlaceholder && other.FloatingLabelBehavior == FloatingLabelBehavior && other.IsDense == IsDense && other.ContentPadding == ContentPadding && other.IsCollapsed == IsCollapsed && other.PrefixIcon == PrefixIcon && other.Prefix == Prefix && other.PrefixText == PrefixText && other.PrefixStyle == PrefixStyle && other.PrefixIconConstraints == PrefixIconConstraints && other.SuffixIcon == SuffixIcon && other.Suffix == Suffix && other.SuffixText == SuffixText && other.SuffixStyle == SuffixStyle && other.SuffixIconConstraints == SuffixIconConstraints && other.Counter == Counter && other.CounterText == CounterText && other.CounterStyle == CounterStyle && other.Filled == Filled && other.FillColor == FillColor && other.FocusColor == FocusColor && other.HoverColor == HoverColor && other.ErrorBorder == ErrorBorder && other.FocusedBorder == FocusedBorder && other.FocusedErrorBorder == FocusedErrorBorder && other.DisabledBorder == DisabledBorder && other.EnabledBorder == EnabledBorder && other.Border == Border && other.Enabled == Enabled && other.SemanticCounterText == SemanticCounterText && other.AlignLabelWithHint == AlignLabelWithHint;
        }




    }


    /// <Summary>
    /// Defines the default appearance of [InputDecorator]s.
    ///
    /// This class is used to define the value of [ThemeData.inputDecorationTheme].
    /// The [InputDecorator], [TextField], and [TextFormField] widgets use
    /// the current input decoration theme to initialize null [InputDecoration]
    /// properties.
    ///
    /// The [InputDecoration.applyDefaults] method is used to combine a input
    /// decoration theme with an [InputDecoration] object.
    /// </Summary>
    public class InputDecorationTheme : IDiagnosticable
    {
        /// <Summary>
        /// Creates a value for [ThemeData.inputDecorationTheme] that
        /// defines default values for [InputDecorator].
        ///
        /// The values of [isDense], [isCollapsed], [filled], and [border] must
        /// not be null.
        /// </Summary>
        public InputDecorationTheme(FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = true, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = false, FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = false, FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool alignLabelWithHint = false)
        : base()
        {
            this.LabelStyle = labelStyle;
            this.HelperStyle = helperStyle;
            this.HelperMaxLines = helperMaxLines;
            this.HintStyle = hintStyle;
            this.ErrorStyle = errorStyle;
            this.ErrorMaxLines = errorMaxLines;
            this.HasFloatingPlaceholder = hasFloatingPlaceholder;
            this.FloatingLabelBehavior = floatingLabelBehavior;
            this.IsDense = isDense;
            this.ContentPadding = contentPadding;
            this.IsCollapsed = isCollapsed;
            this.PrefixStyle = prefixStyle;
            this.SuffixStyle = suffixStyle;
            this.CounterStyle = counterStyle;
            this.Filled = filled;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.ErrorBorder = errorBorder;
            this.FocusedBorder = focusedBorder;
            this.FocusedErrorBorder = focusedErrorBorder;
            this.DisabledBorder = disabledBorder;
            this.EnabledBorder = enabledBorder;
            this.Border = border;
            this.AlignLabelWithHint = alignLabelWithHint;
        }
        /// <Summary>
        /// The style to use for [InputDecoration.labelText] when the label is
        /// above (i.e., vertically adjacent to) the input field.
        ///
        /// When the [labelText] is on top of the input field, the text uses the
        /// [hintStyle] instead.
        ///
        /// If null, defaults to a value derived from the base [TextStyle] for the
        /// input field and the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        /// <Summary>
        /// The style to use for [InputDecoration.helperText].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HelperStyle { get; set; }
        /// <Summary>
        /// The maximum number of lines the [helperText] can occupy.
        ///
        /// Defaults to null, which means that the [helperText] will be limited
        /// to a single line with [TextOverflow.ellipsis].
        ///
        /// This value is passed along to the [Text.maxLines] attribute
        /// of the [Text] widget used to display the helper.
        ///
        /// See also:
        ///
        ///  * [errorMaxLines], the equivalent but for the [errorText].
        /// </Summary>
        public virtual int HelperMaxLines { get; set; }
        /// <Summary>
        /// The style to use for the [InputDecoration.hintText].
        ///
        /// Also used for the [labelText] when the [labelText] is displayed on
        /// top of the input field (i.e., at the same location on the screen where
        /// text may be entered in the input field).
        ///
        /// If null, defaults to a value derived from the base [TextStyle] for the
        /// input field and the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HintStyle { get; set; }
        /// <Summary>
        /// The style to use for the [InputDecoration.errorText].
        ///
        /// If null, defaults of a value derived from the base [TextStyle] for the
        /// input field and the current [Theme].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ErrorStyle { get; set; }
        /// <Summary>
        /// The maximum number of lines the [errorText] can occupy.
        ///
        /// Defaults to null, which means that the [errorText] will be limited
        /// to a single line with [TextOverflow.ellipsis].
        ///
        /// This value is passed along to the [Text.maxLines] attribute
        /// of the [Text] widget used to display the error.
        ///
        /// See also:
        ///
        ///  * [helperMaxLines], the equivalent but for the [helperText].
        /// </Summary>
        public virtual int ErrorMaxLines { get; set; }
        /// <Summary>
        /// Whether the placeholder text floats to become a label on focus.
        ///
        /// If this is false, the placeholder disappears when the input has focus or
        /// text has been entered.
        /// If this is true, the placeholder will rise to the top of the input when
        /// the input has focus or text has been entered.
        ///
        /// Defaults to true.
        /// </Summary>
        public virtual bool HasFloatingPlaceholder { get; set; }
        /// <Summary>
        /// {@macro flutter.material.inputDecoration.floatingLabelBehavior}
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior FloatingLabelBehavior { get; set; }
        /// <Summary>
        /// Whether the input decorator's child is part of a dense form (i.e., uses
        /// less vertical space).
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool IsDense { get; set; }
        /// <Summary>
        /// The padding for the input decoration's container.
        ///
        /// The decoration's container is the area which is filled if
        /// [InputDecoration.filled] is true and bordered per the [border].
        /// It's the area adjacent to [InputDecoration.icon] and above the
        /// [InputDecoration.icon] and above the widgets that contain
        /// [InputDecoration.helperText], [InputDecoration.errorText], and
        /// [InputDecoration.counterText].
        ///
        /// By default the `contentPadding` reflects [isDense] and the type of the
        /// [border]. If [isCollapsed] is true then `contentPadding` is
        /// [EdgeInsets.zero].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        /// <Summary>
        /// Whether the decoration is the same size as the input field.
        ///
        /// A collapsed decoration cannot have [InputDecoration.labelText],
        /// [InputDecoration.errorText], or an [InputDecoration.icon].
        /// </Summary>
        public virtual bool IsCollapsed { get; set; }
        /// <Summary>
        /// The style to use for the [InputDecoration.prefixText].
        ///
        /// If null, defaults to the [hintStyle].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PrefixStyle { get; set; }
        /// <Summary>
        /// The style to use for the [InputDecoration.suffixText].
        ///
        /// If null, defaults to the [hintStyle].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SuffixStyle { get; set; }
        /// <Summary>
        /// The style to use for the [InputDecoration.counterText].
        ///
        /// If null, defaults to the [helperStyle].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle CounterStyle { get; set; }
        /// <Summary>
        /// If true the decoration's container is filled with [fillColor].
        ///
        /// Typically this field set to true if [border] is an
        /// [UnderlineInputBorder].
        ///
        /// The decoration's container is the area, defined by the border's
        /// [InputBorder.getOuterPath], which is filled if [filled] is
        /// true and bordered per the [border].
        ///
        /// This property is false by default.
        /// </Summary>
        public virtual bool Filled { get; set; }
        /// <Summary>
        /// The color to fill the decoration's container with, if [filled] is true.
        ///
        /// By default the fillColor is based on the current [Theme].
        ///
        /// The decoration's container is the area, defined by the border's
        /// [InputBorder.getOuterPath], which is filled if [filled] is
        /// true and bordered per the [border].
        /// </Summary>
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        /// <Summary>
        /// The color to blend with the decoration's [fillColor] with, if [filled] is
        /// true and the container has the input focus.
        ///
        /// By default the [focusColor] is based on the current [Theme].
        ///
        /// The decoration's container is the area, defined by the border's
        /// [InputBorder.getOuterPath], which is filled if [filled] is
        /// true and bordered per the [border].
        /// </Summary>
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        /// <Summary>
        /// The color to blend with the decoration's [fillColor] with, if the
        /// decoration is being hovered over by a mouse pointer.
        ///
        /// By default the [hoverColor] is based on the current [Theme].
        ///
        /// The decoration's container is the area, defined by the border's
        /// [InputBorder.getOuterPath], which is filled if [filled] is
        /// true and bordered per the [border].
        ///
        /// The container will be filled when hovered over even if [filled] is false.
        /// </Summary>
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] does not have the focus and
        /// is showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecorator.isFocused], which is true if the [InputDecorator]'s child
        ///    has the focus.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder ErrorBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] has the focus and is not
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecorator.isFocused], which is true if the [InputDecorator]'s child
        ///    has the focus.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] has the focus and is
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecorator.isFocused], which is true if the [InputDecorator]'s child
        ///    has the focus.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedErrorBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] is disabled and is not
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.enabled], which is false if the [InputDecorator] is disabled.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [enabledBorder], displayed when [InputDecoration.enabled] is true
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder DisabledBorder { get; set; }
        /// <Summary>
        /// The border to display when the [InputDecorator] is enabled and is not
        /// showing an error.
        ///
        /// See also:
        ///
        ///  * [InputDecoration.enabled], which is false if the [InputDecorator] is disabled.
        ///  * [InputDecoration.errorText], the error shown by the [InputDecorator], if non-null.
        ///  * [border], for a description of where the [InputDecorator] border appears.
        ///  * [UnderlineInputBorder], an [InputDecorator] border which draws a horizontal
        ///    line at the bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [errorBorder], displayed when [InputDecorator.isFocused] is false
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [focusedBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is null.
        ///  * [focusedErrorBorder], displayed when [InputDecorator.isFocused] is true
        ///    and [InputDecoration.errorText] is non-null.
        ///  * [disabledBorder], displayed when [InputDecoration.enabled] is false
        ///    and [InputDecoration.errorText] is null.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder EnabledBorder { get; set; }
        /// <Summary>
        /// The shape of the border to draw around the decoration's container.
        ///
        /// The decoration's container is the area which is filled if [filled] is
        /// true and bordered per the [border]. It's the area adjacent to
        /// [InputDecoration.icon] and above the widgets that contain
        /// [InputDecoration.helperText], [InputDecoration.errorText], and
        /// [InputDecoration.counterText].
        ///
        /// The border's bounds, i.e. the value of `border.getOuterPath()`, define
        /// the area to be filled.
        ///
        /// This property is only used when the appropriate one of [errorBorder],
        /// [focusedBorder], [focusedErrorBorder], [disabledBorder], or [enabledBorder]
        /// is not specified. This border's [InputBorder.borderSide] property is
        /// configured by the InputDecorator, depending on the values of
        /// [InputDecoration.errorText], [InputDecoration.enabled],
        /// [InputDecorator.isFocused] and the current [Theme].
        ///
        /// Typically one of [UnderlineInputBorder] or [OutlineInputBorder].
        /// If null, InputDecorator's default is `const UnderlineInputBorder()`.
        ///
        /// See also:
        ///
        ///  * [InputBorder.none], which doesn't draw a border.
        ///  * [UnderlineInputBorder], which draws a horizontal line at the
        ///    bottom of the input decorator's container.
        ///  * [OutlineInputBorder], an [InputDecorator] border which draws a
        ///    rounded rectangle around the input decorator's container.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        /// <Summary>
        /// Typically set to true when the [InputDecorator] contains a multiline
        /// [TextField] ([TextField.maxLines] is null or > 1) to override the default
        /// behavior of aligning the label with the center of the [TextField].
        /// </Summary>
        public virtual bool AlignLabelWithHint { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecorationTheme CopyWith(FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = default(bool), FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = default(bool), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool alignLabelWithHint = default(bool))
        {
            return new InputDecorationTheme(labelStyle: labelStyle ?? this.LabelStyle, helperStyle: helperStyle ?? this.HelperStyle, helperMaxLines: helperMaxLines ?? this.HelperMaxLines, hintStyle: hintStyle ?? this.HintStyle, errorStyle: errorStyle ?? this.ErrorStyle, errorMaxLines: errorMaxLines ?? this.ErrorMaxLines, hasFloatingPlaceholder: hasFloatingPlaceholder ?? this.HasFloatingPlaceholder, floatingLabelBehavior: floatingLabelBehavior ?? this.FloatingLabelBehavior, isDense: isDense ?? this.IsDense, contentPadding: contentPadding ?? this.ContentPadding, isCollapsed: isCollapsed ?? this.IsCollapsed, prefixStyle: prefixStyle ?? this.PrefixStyle, suffixStyle: suffixStyle ?? this.SuffixStyle, counterStyle: counterStyle ?? this.CounterStyle, filled: filled ?? this.Filled, fillColor: fillColor ?? this.FillColor, focusColor: focusColor ?? this.FocusColor, hoverColor: hoverColor ?? this.HoverColor, errorBorder: errorBorder ?? this.ErrorBorder, focusedBorder: focusedBorder ?? this.FocusedBorder, focusedErrorBorder: focusedErrorBorder ?? this.FocusedErrorBorder, disabledBorder: disabledBorder ?? this.DisabledBorder, enabledBorder: enabledBorder ?? this.EnabledBorder, border: border ?? this.Border, alignLabelWithHint: alignLabelWithHint ?? this.AlignLabelWithHint);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is InputDecorationTheme && other.LabelStyle == LabelStyle && other.HelperStyle == HelperStyle && other.HelperMaxLines == HelperMaxLines && other.HintStyle == HintStyle && other.ErrorStyle == ErrorStyle && other.ErrorMaxLines == ErrorMaxLines && other.IsDense == IsDense && other.ContentPadding == ContentPadding && other.IsCollapsed == IsCollapsed && other.PrefixStyle == PrefixStyle && other.SuffixStyle == SuffixStyle && other.CounterStyle == CounterStyle && other.FloatingLabelBehavior == FloatingLabelBehavior && other.Filled == Filled && other.FillColor == FillColor && other.FocusColor == FocusColor && other.HoverColor == HoverColor && other.ErrorBorder == ErrorBorder && other.FocusedBorder == FocusedBorder && other.FocusedErrorBorder == FocusedErrorBorder && other.DisabledBorder == DisabledBorder && other.EnabledBorder == EnabledBorder && other.Border == Border && other.AlignLabelWithHint == AlignLabelWithHint && other.DisabledBorder == DisabledBorder;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            InputDecorationTheme defaultTheme = new InputDecorationTheme();
            properties.Add(new DiagnosticsProperty<TextStyle>("labelStyle", LabelStyle, defaultValue: defaultTheme.LabelStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("helperStyle", HelperStyle, defaultValue: defaultTheme.HelperStyle));
            properties.Add(new IntProperty("helperMaxLines", HelperMaxLines, defaultValue: defaultTheme.HelperMaxLines));
            properties.Add(new DiagnosticsProperty<TextStyle>("hintStyle", HintStyle, defaultValue: defaultTheme.HintStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("errorStyle", ErrorStyle, defaultValue: defaultTheme.ErrorStyle));
            properties.Add(new IntProperty("errorMaxLines", ErrorMaxLines, defaultValue: defaultTheme.ErrorMaxLines));
            properties.Add(new DiagnosticsProperty<bool>("hasFloatingPlaceholder", HasFloatingPlaceholder, defaultValue: defaultTheme.HasFloatingPlaceholder));
            properties.Add(new DiagnosticsProperty<FloatingLabelBehavior>("floatingLabelBehavior", FloatingLabelBehavior, defaultValue: defaultTheme.FloatingLabelBehavior));
            properties.Add(new DiagnosticsProperty<bool>("isDense", IsDense, defaultValue: defaultTheme.IsDense));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("contentPadding", ContentPadding, defaultValue: defaultTheme.ContentPadding));
            properties.Add(new DiagnosticsProperty<bool>("isCollapsed", IsCollapsed, defaultValue: defaultTheme.IsCollapsed));
            properties.Add(new DiagnosticsProperty<TextStyle>("prefixStyle", PrefixStyle, defaultValue: defaultTheme.PrefixStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("suffixStyle", SuffixStyle, defaultValue: defaultTheme.SuffixStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("counterStyle", CounterStyle, defaultValue: defaultTheme.CounterStyle));
            properties.Add(new DiagnosticsProperty<bool>("filled", Filled, defaultValue: defaultTheme.Filled));
            properties.Add(new ColorProperty("fillColor", FillColor, defaultValue: defaultTheme.FillColor));
            properties.Add(new ColorProperty("focusColor", FocusColor, defaultValue: defaultTheme.FocusColor));
            properties.Add(new ColorProperty("hoverColor", HoverColor, defaultValue: defaultTheme.HoverColor));
            properties.Add(new DiagnosticsProperty<InputBorder>("errorBorder", ErrorBorder, defaultValue: defaultTheme.ErrorBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("focusedBorder", FocusedBorder, defaultValue: defaultTheme.FocusedErrorBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("focusedErrorBorder", FocusedErrorBorder, defaultValue: defaultTheme.FocusedErrorBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("disabledBorder", DisabledBorder, defaultValue: defaultTheme.DisabledBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("enabledBorder", EnabledBorder, defaultValue: defaultTheme.EnabledBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("border", Border, defaultValue: defaultTheme.Border));
            properties.Add(new DiagnosticsProperty<bool>("alignLabelWithHint", AlignLabelWithHint, defaultValue: defaultTheme.AlignLabelWithHint));
        }



    }


    /// <Summary>
    /// Defines the behaviour of the floating label
    /// </Summary>
    public enum FloatingLabelBehavior
    {

        /// <Summary>
        /// The label will always be positioned within the content, or hidden.
        /// </Summary>
        Never,
        /// <Summary>
        /// The label will float when the input is focused, or has content.
        /// </Summary>
        Auto,
        /// <Summary>
        /// The label will always float above the content.
        /// </Summary>
        Always,
    }


    public enum _DecorationSlot
    {

        Icon,
        Input,
        Label,
        Hint,
        Prefix,
        Suffix,
        PrefixIcon,
        SuffixIcon,
        HelperError,
        Counter,
        Container,
    }

}
