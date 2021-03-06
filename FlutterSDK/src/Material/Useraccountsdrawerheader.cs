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
namespace FlutterSDK.Material.Useraccountsdrawerheader
{
    internal static class UseraccountsdrawerheaderDefaultClass
    {
        public static double _KAccountDetailsHeight = default(double);
    }

    public class _AccountPictures : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _AccountPictures(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget currentAccountPicture = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> otherAccountsPictures = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key)
        {
            this.CurrentAccountPicture = currentAccountPicture;
            this.OtherAccountsPictures = otherAccountsPictures;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget CurrentAccountPicture { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> OtherAccountsPictures { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Stack(children: new List<Widget>(){new PositionedDirectional(top:0.0, end:0.0, child:new Row(children:(OtherAccountsPictures??new List<Widget>(){}).Take(3).Map((Widget picture) => {
return new Padding(padding:EdgeInsetsDirectional.Only(start:8.0), child:new Semantics(container:true , child:new Container(padding:EdgeInsets.Only(left:8.0, bottom:8.0), width:48.0, height:48.0, child:picture)));
}
).ToList())), new Positioned(top:0.0, child:new Semantics(explicitChildNodes:true , child:new SizedBox(width:72.0, height:72.0, child:CurrentAccountPicture)))});
        }



    }


    public class _AccountDetails : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _AccountDetails(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget accountName = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget accountEmail = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onTap = default(VoidCallback), bool isOpen = default(bool), FlutterBinding.UI.Color arrowColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.AccountName = accountName;
            this.AccountEmail = accountEmail;
            this.OnTap = onTap;
            this.IsOpen = isOpen;
            this.ArrowColor = arrowColor;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget AccountName { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget AccountEmail { get; set; }
        public virtual VoidCallback OnTap { get; set; }
        public virtual bool IsOpen { get; set; }
        public virtual FlutterBinding.UI.Color ArrowColor { get; set; }

        public new FlutterSDK.Material.Useraccountsdrawerheader._AccountDetailsState CreateState() => new _AccountDetailsState();


    }


    public class _AccountDetailsState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Useraccountsdrawerheader._AccountDetails>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _AccountDetailsState()
        { }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Animation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(value: Widget.IsOpen ? 1.0 : 0.0, duration: new TimeSpan(milliseconds: 200), vsync: this);
            _Animation = new CurvedAnimation(parent: _Controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn, reverseCurve: CurvesDefaultClass.Curves.FastOutSlowIn.Flipped);
            new CurvedAnimation(parent: _Controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn, reverseCurve: CurvesDefaultClass.Curves.FastOutSlowIn.Flipped).AddListener(() => =>SetState(() =>
            {
            }
            ));
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Useraccountsdrawerheader._AccountDetails oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.IsOpen == Widget.IsOpen)
            {
                return;
            }

            if (Widget.IsOpen)
            {
                _Controller.Forward();
            }
            else
            {
                _Controller.Reverse();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {



            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            Widget accountDetails = new CustomMultiChildLayout(@delegate: new _AccountDetailsLayout(textDirection: BasicDefaultClass.Directionality.Of(context)), children: new List<Widget>() { });
            if (Widget.OnTap != null)
            {
                accountDetails = new InkWell(onTap: Widget.OnTap, child: accountDetails, excludeFromSemantics: true);
            }

            return new SizedBox(height: UseraccountsdrawerheaderDefaultClass._KAccountDetailsHeight, child: accountDetails);
        }



    }


    public class _AccountDetailsLayout : FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate
    {
        public _AccountDetailsLayout(TextDirection textDirection = default(TextDirection))
        {
            this.TextDirection = textDirection;
        }
        public virtual string AccountName { get; set; }
        public virtual string AccountEmail { get; set; }
        public virtual string DropdownIcon { get; set; }
        public virtual TextDirection TextDirection { get; set; }

        public new void PerformLayout(Size size)
        {
            Size iconSize = default(Size);
            if (HasChild(DropdownIcon))
            {
                iconSize = LayoutChild(DropdownIcon, BoxConstraints.Loose(size));
                PositionChild(DropdownIcon, _OffsetForIcon(size, iconSize));
            }

            string bottomLine = HasChild(AccountEmail) ? AccountEmail : (HasChild(AccountName) ? AccountName : null);
            if (bottomLine != null)
            {
                Size constraintSize = iconSize == null ? size : new Size(size.Width - iconSize.Width, size.Height);
                iconSize = (iconSize == null ? new Size(UseraccountsdrawerheaderDefaultClass._KAccountDetailsHeight, UseraccountsdrawerheaderDefaultClass._KAccountDetailsHeight) : iconSize);
                Size bottomLineSize = LayoutChild(bottomLine, BoxConstraints.Loose(constraintSize));
                Offset bottomLineOffset = _OffsetForBottomLine(size, iconSize, bottomLineSize);
                PositionChild(bottomLine, bottomLineOffset);
                if (bottomLine == AccountEmail && HasChild(AccountName))
                {
                    Size nameSize = LayoutChild(AccountName, BoxConstraints.Loose(constraintSize));
                    PositionChild(AccountName, _OffsetForName(size, nameSize, bottomLineOffset));
                }

            }

        }




        public new bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate) => true;



        private Offset _OffsetForIcon(Size size, Size iconSize)
        {
            switch (TextDirection) { case TextDirection.Ltr: return new Offset(size.Width - iconSize.Width, size.Height - iconSize.Height); case TextDirection.Rtl: return new Offset(0.0, size.Height - iconSize.Height); }

            return null;
        }




        private Offset _OffsetForBottomLine(Size size, Size iconSize, Size bottomLineSize)
        {
            double y = size.Height - 0.5 * iconSize.Height - 0.5 * bottomLineSize.Height;
            switch (TextDirection) { case TextDirection.Ltr: return new Offset(0.0, y); case TextDirection.Rtl: return new Offset(size.Width - bottomLineSize.Width, y); }

            return null;
        }




        private Offset _OffsetForName(Size size, Size nameSize, FlutterBinding.UI.Offset bottomLineOffset)
        {
            double y = bottomLineOffset.Dy - nameSize.Height;
            switch (TextDirection) { case TextDirection.Ltr: return new Offset(0.0, y); case TextDirection.Rtl: return new Offset(size.Width - nameSize.Width, y); }

            return null;
        }



    }


    /// <Summary>
    /// A material design [Drawer] header that identifies the app's user.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// See also:
    ///
    ///  * [DrawerHeader], for a drawer header that doesn't show user accounts.
    ///  * <https://material.io/design/components/navigation-drawer.html#anatomy>
    /// </Summary>
    public class UserAccountsDrawerHeader : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a material design drawer header.
        ///
        /// Requires one of its ancestors to be a [Material] widget.
        /// </Summary>
        public UserAccountsDrawerHeader(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget currentAccountPicture = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> otherAccountsPictures = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget accountName = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget accountEmail = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDetailsPressed = default(VoidCallback), FlutterBinding.UI.Color arrowColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Decoration = decoration;
            this.Margin = margin;
            this.CurrentAccountPicture = currentAccountPicture;
            this.OtherAccountsPictures = otherAccountsPictures;
            this.AccountName = accountName;
            this.AccountEmail = accountEmail;
            this.OnDetailsPressed = onDetailsPressed;
            this.ArrowColor = arrowColor;
        }
        /// <Summary>
        /// The header's background. If decoration is null then a [BoxDecoration]
        /// with its background color set to the current theme's primaryColor is used.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        /// <Summary>
        /// The margin around the drawer header.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
        /// <Summary>
        /// A widget placed in the upper-left corner that represents the current
        /// user's account. Normally a [CircleAvatar].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget CurrentAccountPicture { get; set; }
        /// <Summary>
        /// A list of widgets that represent the current user's other accounts.
        /// Up to three of these widgets will be arranged in a row in the header's
        /// upper-right corner. Normally a list of [CircleAvatar] widgets.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> OtherAccountsPictures { get; set; }
        /// <Summary>
        /// A widget that represents the user's current account name. It is
        /// displayed on the left, below the [currentAccountPicture].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget AccountName { get; set; }
        /// <Summary>
        /// A widget that represents the email address of the user's current account.
        /// It is displayed on the left, below the [accountName].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget AccountEmail { get; set; }
        /// <Summary>
        /// A callback that is called when the horizontal area which contains the
        /// [accountName] and [accountEmail] is tapped.
        /// </Summary>
        public virtual VoidCallback OnDetailsPressed { get; set; }
        /// <Summary>
        /// The [Color] of the arrow icon.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ArrowColor { get; set; }

        public new FlutterSDK.Material.Useraccountsdrawerheader._UserAccountsDrawerHeaderState CreateState() => new _UserAccountsDrawerHeaderState();


    }


    public class _UserAccountsDrawerHeaderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Useraccountsdrawerheader.UserAccountsDrawerHeader>
    {
        public _UserAccountsDrawerHeaderState()
        { }
        internal virtual bool _IsOpen { get; set; }

        private void _HandleDetailsPressed()
        {
            SetState(() =>
            {
                _IsOpen = !_IsOpen;
            }
            );
            Widget.OnDetailsPressed();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            return new Semantics(container: true, label: MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).SignedInLabel, child: new DrawerHeader(decoration: Widget.Decoration ?? new BoxDecoration(color: ThemeDefaultClass.Theme.Of(context).PrimaryColor), margin: Widget.Margin, padding: EdgeInsetsDirectional.Only(top: 16.0, start: 16.0), child: new SafeArea(bottom: false, child: new Column(crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { new Expanded(child: new Padding(padding: EdgeInsetsDirectional.Only(end: 16.0), child: new _AccountPictures(currentAccountPicture: Widget.CurrentAccountPicture, otherAccountsPictures: Widget.OtherAccountsPictures))), new _AccountDetails(accountName: Widget.AccountName, accountEmail: Widget.AccountEmail, isOpen: _IsOpen, onTap: Widget.OnDetailsPressed == null ? null : _HandleDetailsPressed, arrowColor: Widget.ArrowColor) }))));
        }



    }

}
