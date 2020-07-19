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
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Widgets.Dismissible
{
    public delegate void DismissDirectionCallback(FlutterSDK.Widgets.Dismissible.DismissDirection direction);
    public delegate Future<bool> ConfirmDismissCallback(FlutterSDK.Widgets.Dismissible.DismissDirection direction);
    internal static class DismissibleDefaultClass
    {
        public static FlutterSDK.Animation.Curves.Curve _KResizeTimeCurve = default(FlutterSDK.Animation.Curves.Curve);
        public static double _KMinFlingVelocity = default(double);
        public static double _KMinFlingVelocityDelta = default(double);
        public static double _KFlingVelocityScale = default(double);
        public static double _KDismissThreshold = default(double);
    }

    /// <Summary>
    /// A widget that can be dismissed by dragging in the indicated [direction].
    ///
    /// Dragging or flinging this widget in the [DismissDirection] causes the child
    /// to slide out of view. Following the slide animation, if [resizeDuration] is
    /// non-null, the Dismissible widget animates its height (or width, whichever is
    /// perpendicular to the dismiss direction) to zero over the [resizeDuration].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=iEMgjrfuc58}
    ///
    /// Backgrounds can be used to implement the "leave-behind" idiom. If a background
    /// is specified it is stacked behind the Dismissible's child and is exposed when
    /// the child moves.
    ///
    /// The widget calls the [onDismissed] callback either after its size has
    /// collapsed to zero (if [resizeDuration] is non-null) or immediately after
    /// the slide animation (if [resizeDuration] is null). If the Dismissible is a
    /// list item, it must have a key that distinguishes it from the other items and
    /// its [onDismissed] callback must remove the item from the list.
    /// </Summary>
    public class Dismissible : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Dismissible(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget background = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget secondaryBackground = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Dismissible.ConfirmDismissCallback confirmDismiss = default(FlutterSDK.Widgets.Dismissible.ConfirmDismissCallback), VoidCallback onResize = default(VoidCallback), FlutterSDK.Widgets.Dismissible.DismissDirectionCallback onDismissed = default(FlutterSDK.Widgets.Dismissible.DismissDirectionCallback), FlutterSDK.Widgets.Dismissible.DismissDirection direction = default(FlutterSDK.Widgets.Dismissible.DismissDirection), TimeSpan resizeDuration = default(TimeSpan), Dictionary<FlutterSDK.Widgets.Dismissible.DismissDirection, double> dismissThresholds = default(Dictionary<FlutterSDK.Widgets.Dismissible.DismissDirection, double>), TimeSpan movementDuration = default(TimeSpan), double crossAxisEndOffset = 0.0, FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Child = child;
            this.Background = background;
            this.SecondaryBackground = secondaryBackground;
            this.ConfirmDismiss = confirmDismiss;
            this.OnResize = onResize;
            this.OnDismissed = onDismissed;
            this.Direction = direction;
            this.ResizeDuration = resizeDuration;
            this.DismissThresholds = dismissThresholds;
            this.MovementDuration = movementDuration;
            this.CrossAxisEndOffset = crossAxisEndOffset;
            this.DragStartBehavior = dragStartBehavior;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Background { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget SecondaryBackground { get; set; }
        public virtual FlutterSDK.Widgets.Dismissible.ConfirmDismissCallback ConfirmDismiss { get; set; }
        public virtual VoidCallback OnResize { get; set; }
        public virtual FlutterSDK.Widgets.Dismissible.DismissDirectionCallback OnDismissed { get; set; }
        public virtual FlutterSDK.Widgets.Dismissible.DismissDirection Direction { get; set; }
        public virtual TimeSpan ResizeDuration { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Dismissible.DismissDirection, double> DismissThresholds { get; set; }
        public virtual TimeSpan MovementDuration { get; set; }
        public virtual double CrossAxisEndOffset { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Dismissible._DismissibleState CreateState() => new _DismissibleState();


        #endregion
    }


    public class _DismissibleClipper : FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>
    {
        #region constructors
        public _DismissibleClipper(FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Animation.Animation.Animation<Offset> moveAnimation = default(FlutterSDK.Animation.Animation.Animation<Offset>))
        : base(reclip: moveAnimation)
        {
            this.Axis = axis;
            this.MoveAnimation = moveAnimation;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<Offset> MoveAnimation { get; set; }
        #endregion

        #region methods

        public new Rect GetClip(Size size)
        {

            switch (Axis) { case Axis.Horizontal: double offset = MoveAnimation.Value.Dx * size.Width; if (offset < 0) return Rect.FromLTRB(size.Width + offset, 0.0, size.Width, size.Height); return Rect.FromLTRB(0.0, 0.0, offset, size.Height); case Axis.Vertical: double offset = MoveAnimation.Value.Dy * size.Height; if (offset < 0) return Rect.FromLTRB(0.0, size.Height + offset, size.Width, size.Height); return Rect.FromLTRB(0.0, 0.0, size.Width, offset); }
            return null;
        }




        public new Rect GetApproximateClipRect(Size size) => GetClip(size);



        public new bool ShouldReclip(FlutterSDK.Widgets.Dismissible._DismissibleClipper oldClipper)
        {
            return oldClipper.Axis != Axis || oldClipper.MoveAnimation.Value != MoveAnimation.Value;
        }



        #endregion
    }


    public class _DismissibleState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Dismissible.Dismissible>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>, IAutomaticKeepAliveClientMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _DismissibleState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _MoveController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _MoveAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ResizeController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ResizeAnimation { get; set; }
        internal virtual double _DragExtent { get; set; }
        internal virtual bool _DragUnderway { get; set; }
        internal virtual Size _SizePriorToCollapse { get; set; }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _DirectionIsXAxis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Widgets.Dismissible.DismissDirection _DismissDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsActive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _OverallDragAxisExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            _MoveController = new AnimationController(duration: Widget.MovementDuration, vsync: this);
            new AnimationController(duration: Widget.MovementDuration, vsync: this).AddStatusListener(_HandleDismissStatusChanged);
            _UpdateMoveAnimation();
        }




        public new void Dispose()
        {
            _MoveController.Dispose();
            _ResizeController?.Dispose();
            base.Dispose();
        }




        private FlutterSDK.Widgets.Dismissible.DismissDirection _ExtentToDirection(double extent)
        {
            if (extent == 0.0) return null;
            if (_DirectionIsXAxis)
            {
                switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: return extent < 0 ? DismissDirection.StartToEnd : DismissDirection.EndToStart; case TextDirection.Ltr: return extent > 0 ? DismissDirection.StartToEnd : DismissDirection.EndToStart; }

                return null;
            }

            return extent > 0 ? DismissDirection.Down : DismissDirection.Up;
        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {
            _DragUnderway = true;
            if (_MoveController.IsAnimating)
            {
                _DragExtent = _MoveController.Value * _OverallDragAxisExtent * _DragExtent.Sign;
                _MoveController.Stop();
            }
            else
            {
                _DragExtent = 0.0;
                _MoveController.Value = 0.0;
            }

            SetState(() =>
            {
                _UpdateMoveAnimation();
            }
            );
        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            if (!_IsActive || _MoveController.IsAnimating) return;
            double delta = details.PrimaryDelta;
            double oldDragExtent = _DragExtent;
            switch (Widget.Direction) { case DismissDirection.Horizontal: case DismissDirection.Vertical: _DragExtent += delta; break; case DismissDirection.Up: if (_DragExtent + delta < 0) _DragExtent += delta; break; case DismissDirection.Down: if (_DragExtent + delta > 0) _DragExtent += delta; break; case DismissDirection.EndToStart: switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: if (_DragExtent + delta > 0) _DragExtent += delta; break; case TextDirection.Ltr: if (_DragExtent + delta < 0) _DragExtent += delta; break; } break; case DismissDirection.StartToEnd: switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: if (_DragExtent + delta < 0) _DragExtent += delta; break; case TextDirection.Ltr: if (_DragExtent + delta > 0) _DragExtent += delta; break; } break; }
            if (oldDragExtent.Sign != _DragExtent.Sign)
            {
                SetState(() =>
                {
                    _UpdateMoveAnimation();
                }
                );
            }

            if (!_MoveController.IsAnimating)
            {
                _MoveController.Value = _DragExtent.Abs() / _OverallDragAxisExtent;
            }

        }




        private void _UpdateMoveAnimation()
        {
            double end = _DragExtent.Sign;
            _MoveAnimation = _MoveController.Drive(new Tween<Offset>(begin: Dart:uiDefaultClass.Offset.Zero, end: _DirectionIsXAxis ? new Offset(end, Widget.CrossAxisEndOffset) : new Offset(Widget.CrossAxisEndOffset, end)));
        }




        private FlutterSDK.Widgets.Dismissible._FlingGestureKind _DescribeFlingGesture(FlutterSDK.Gestures.Velocitytracker.Velocity velocity)
        {

            if (_DragExtent == 0.0)
            {
                return _FlingGestureKind.None;
            }

            double vx = velocity.PixelsPerSecond.Dx;
            double vy = velocity.PixelsPerSecond.Dy;
            DismissDirection flingDirection = default(DismissDirection);
            if (_DirectionIsXAxis)
            {
                if (vx.Abs() - vy.Abs() < DismissibleDefaultClass._KMinFlingVelocityDelta || vx.Abs() < DismissibleDefaultClass._KMinFlingVelocity) return _FlingGestureKind.None;

                flingDirection = _ExtentToDirection(vx);
            }
            else
            {
                if (vy.Abs() - vx.Abs() < DismissibleDefaultClass._KMinFlingVelocityDelta || vy.Abs() < DismissibleDefaultClass._KMinFlingVelocity) return _FlingGestureKind.None;

                flingDirection = _ExtentToDirection(vy);
            }


            if (flingDirection == _DismissDirection) return _FlingGestureKind.Forward;
            return _FlingGestureKind.Reverse;
        }




        private Future<object> _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            if (!_IsActive || _MoveController.IsAnimating) return;
            _DragUnderway = false;
            if (_MoveController.IsCompleted && await _ConfirmStartResizeAnimation() == true)
            {
                _StartResizeAnimation();
                return;
            }

            double flingVelocity = _DirectionIsXAxis ? details.Velocity.PixelsPerSecond.Dx : details.Velocity.PixelsPerSecond.Dy;
            switch (_DescribeFlingGesture(details.Velocity))
            {
                case _FlingGestureKind.Forward:
                    if ((Widget.DismissThresholds[_DismissDirection] ?? DismissibleDefaultClass._KDismissThreshold) >= 1.0)
                    {
                        _MoveController.Reverse();
                        break;
                    }
                    _DragExtent = flingVelocity.Sign; _MoveController.Fling(velocity: flingVelocity.Abs() * DismissibleDefaultClass._KFlingVelocityScale); break;
                case _FlingGestureKind.Reverse: _DragExtent = flingVelocity.Sign; _MoveController.Fling(velocity: -flingVelocity.Abs() * DismissibleDefaultClass._KFlingVelocityScale); break;
                case _FlingGestureKind.None:
                    if (!_MoveController.IsDismissed)
                    {
                        if (_MoveController.Value > (Widget.DismissThresholds[_DismissDirection] ?? DismissibleDefaultClass._KDismissThreshold))
                        {
                            _MoveController.Forward();
                        }
                        else
                        {
                            _MoveController.Reverse();
                        }

                    }
                    break;
            }
        }




        private Future<object> _HandleDismissStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Completed && !_DragUnderway)
            {
                if (await _ConfirmStartResizeAnimation() == true) _StartResizeAnimation(); else _MoveController.Reverse();
            }

            UpdateKeepAlive();
        }




        private Future<bool> _ConfirmStartResizeAnimation()
        {
            if (Widget.ConfirmDismiss != null)
            {
                DismissDirection direction = _DismissDirection;

                return Widget.ConfirmDismiss(direction);
            }

            return true;
        }




        private void _StartResizeAnimation()
        {




            if (Widget.ResizeDuration == null)
            {
                if (Widget.OnDismissed != null)
                {
                    DismissDirection direction = _DismissDirection;

                    Widget.OnDismissed(direction);
                }

            }
            else
            {
                _ResizeController = new AnimationController(duration: Widget.ResizeDuration, vsync: this);
                new AnimationController(duration: Widget.ResizeDuration, vsync: this).AddListener(_HandleResizeProgressChanged);
                new AnimationController(duration: Widget.ResizeDuration, vsync: this).AddStatusListener((AnimationStatus status) => =>UpdateKeepAlive());
                _ResizeController.Forward();
                SetState(() =>
                {
                    _SizePriorToCollapse = Context.Size;
                    _ResizeAnimation = _ResizeController.Drive(new CurveTween(curve: DismissibleDefaultClass._KResizeTimeCurve)).Drive(new Tween<double>(begin: 1.0, end: 0.0));
                }
                );
            }

        }




        private void _HandleResizeProgressChanged()
        {
            if (_ResizeController.IsCompleted)
            {
                if (Widget.OnDismissed != null)
                {
                    DismissDirection direction = _DismissDirection;

                    Widget.OnDismissed(direction);
                }

            }
            else
            {
                if (Widget.OnResize != null) Widget.OnResize();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            base.Build(context);

            Widget background = Widget.Background;
            if (Widget.SecondaryBackground != null)
            {
                DismissDirection direction = _DismissDirection;
                if (direction == DismissDirection.EndToStart || direction == DismissDirection.Up) background = Widget.SecondaryBackground;
            }

            if (_ResizeAnimation != null)
            {

                return new SizeTransition(sizeFactor: _ResizeAnimation, axis: _DirectionIsXAxis ? Axis.Vertical : Axis.Horizontal, child: new SizedBox(width: _SizePriorToCollapse.Width, height: _SizePriorToCollapse.Height, child: background));
            }

            Widget content = new SlideTransition(position: _MoveAnimation, child: Widget.Child);
            if (background != null)
            {
                content = new Stack(children: new List<Widget>() { });
            }

            return new GestureDetector(onHorizontalDragStart: _DirectionIsXAxis ? _HandleDragStart : null, onHorizontalDragUpdate: _DirectionIsXAxis ? _HandleDragUpdate : null, onHorizontalDragEnd: _DirectionIsXAxis ? _HandleDragEnd : null, onVerticalDragStart: _DirectionIsXAxis ? null : _HandleDragStart, onVerticalDragUpdate: _DirectionIsXAxis ? null : _HandleDragUpdate, onVerticalDragEnd: _DirectionIsXAxis ? null : _HandleDragEnd, behavior: HitTestBehavior.Opaque, child: content, dragStartBehavior: Widget.DragStartBehavior);
        }



        #endregion
    }


    /// <Summary>
    /// The direction in which a [Dismissible] can be dismissed.
    /// </Summary>
    public enum DismissDirection
    {

        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging either up or down.
        /// </Summary>
        Vertical,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging either left or right.
        /// </Summary>
        Horizontal,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging in the reverse of the
        /// reading direction (e.g., from right to left in left-to-right languages).
        /// </Summary>
        EndToStart,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging in the reading direction
        /// (e.g., from left to right in left-to-right languages).
        /// </Summary>
        StartToEnd,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging up only.
        /// </Summary>
        Up,
        /// <Summary>
        /// The [Dismissible] can be dismissed by dragging down only.
        /// </Summary>
        Down,
    }


    public enum _FlingGestureKind
    {

        None,
        Forward,
        Reverse,
    }

}
