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
namespace FlutterSDK.Painting.Textspan
{
    internal static class TextspanDefaultClass
    {
    }

    /// <Summary>
    /// An immutable span of text.
    ///
    /// A [TextSpan] object can be styled using its [style] property. The style will
    /// be applied to the [text] and the [children].
    ///
    /// A [TextSpan] object can just have plain text, or it can have children
    /// [TextSpan] objects with their own styles that (possibly only partially)
    /// override the [style] of this object. If a [TextSpan] has both [text] and
    /// [children], then the [text] is treated as if it was an un-styled [TextSpan]
    /// at the start of the [children] list. Leaving the [TextSpan.text] field null
    /// results in the [TextSpan] acting as an empty node in the [InlineSpan] tree
    /// with a list of children.
    ///
    /// To paint a [TextSpan] on a [Canvas], use a [TextPainter]. To display a text
    /// span in a widget, use a [RichText]. For text with a single style, consider
    /// using the [Text] widget.
    ///
    /// {@tool snippet}
    ///
    /// The text "Hello world!", in black:
    ///
    /// ```dart
    /// TextSpan(
    ///   text: 'Hello world!',
    ///   style: TextStyle(color: Colors.black),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// _There is some more detailed sample code in the documentation for the
    /// [recognizer] property._
    ///
    /// The [TextSpan.text] will be used as the semantics label unless overridden
    /// by the [TextSpan.semanticsLabel] property. Any [PlaceholderSpan]s in the
    /// [TextSpan.children] list will separate the text before and after it into two
    /// semantics nodes.
    ///
    /// See also:
    ///
    ///  * [WidgetSpan], a leaf node that represents an embedded inline widget in an
    ///    [InlineSpan] tree. Specify a widget within the [children] list by
    ///    wrapping the widget with a [WidgetSpan]. The widget will be laid out
    ///    inline within the paragraph.
    ///  * [Text], a widget for showing uniformly-styled text.
    ///  * [RichText], a widget for finer control of text rendering.
    ///  * [TextPainter], a class for painting [TextSpan] objects on a [Canvas].
    /// </Summary>
    public class TextSpan : FlutterSDK.Painting.Inlinespan.InlineSpan
    {
        #region constructors
        public TextSpan(string text = default(string), List<FlutterSDK.Painting.Inlinespan.InlineSpan> children = default(List<FlutterSDK.Painting.Inlinespan.InlineSpan>), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Gestures.Recognizer.GestureRecognizer recognizer = default(FlutterSDK.Gestures.Recognizer.GestureRecognizer), string semanticsLabel = default(string))
        : base(style: style)
    
}
    #endregion

    #region fields
    public new string Text { get; set; }
    public new List<FlutterSDK.Painting.Inlinespan.InlineSpan> Children { get; set; }
    public new FlutterSDK.Gestures.Recognizer.GestureRecognizer Recognizer { get; set; }
    public virtual string SemanticsLabel { get; set; }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Apply the [style], [text], and [children] of this object to the
    /// given [ParagraphBuilder], from which a [Paragraph] can be obtained.
    /// [Paragraph] objects can be drawn on [Canvas] objects.
    ///
    /// Rather than using this directly, it's simpler to use the
    /// [TextPainter] class to paint [TextSpan] objects onto [Canvas]
    /// objects.
    /// </Summary>
    public new void Build(ParagraphBuilder builder, double textScaleFactor = 1.0, List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions> dimensions = default(List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions>))
    {

        bool hasStyle = Style != null;
        if (hasStyle) builder.PushStyle(Style.GetTextStyle(textScaleFactor: textScaleFactor));
        if (Text != null) builder.AddText(Text);
        if (Children != null)
        {
            foreach (InlineSpan child in Children)
            {

                child.Build(builder, textScaleFactor: textScaleFactor, dimensions: dimensions);
            }

        }

        if (hasStyle) builder.Pop();
    }




    /// <Summary>
    /// Walks this [TextSpan] and its descendants in pre-order and calls [visitor]
    /// for each span that has text.
    ///
    /// When `visitor` returns true, the walk will continue. When `visitor`
    /// returns false, then the walk will end.
    /// </Summary>
    public new bool VisitChildren(FlutterSDK.Painting.Inlinespan.InlineSpanVisitor visitor)
    {
        if (Text != null)
        {
            if (!visitor(this)) return false;
        }

        if (Children != null)
        {
            foreach (InlineSpan child in Children)
            {
                if (!child.VisitChildren(visitor)) return false;
            }

        }

        return true;
    }




    /// <Summary>
    /// Walks this [TextSpan] and any descendants in pre-order and calls `visitor`
    /// for each span that has content.
    ///
    /// When `visitor` returns true, the walk will continue. When `visitor`
    /// returns false, then the walk will end.
    /// </Summary>
    public new bool VisitTextSpan(Func<bool, TextSpan> visitor)
    {
        if (Text != null)
        {
            if (!visitor(this)) return false;
        }

        if (Children != null)
        {
            foreach (InlineSpan child in Children)
            {

                TextSpan textSpanChild = child as TextSpan;
                if (!textSpanChild.VisitTextSpan(visitor)) return false;
            }

        }

        return true;
    }




    /// <Summary>
    /// Returns the text span that contains the given position in the text.
    /// </Summary>
    public new FlutterSDK.Painting.Inlinespan.InlineSpan GetSpanForPositionVisitor(TextPosition position, FlutterSDK.Painting.Inlinespan.Accumulator offset)
    {
        if (Text == null)
        {
            return null;
        }

        TextAffinity affinity = position.Affinity;
        int targetOffset = position.Offset;
        int endOffset = offset.Value + Text.Length;
        if (offset.Value == targetOffset && affinity == TextAffinity.Downstream || offset.Value < targetOffset && targetOffset < endOffset || endOffset == targetOffset && affinity == TextAffinity.Upstream)
        {
            return this;
        }

        offset.Increment(Text.Length);
        return null;
    }




    public new void ComputeToPlainText(StringBuffer buffer, bool includeSemanticsLabels = true, bool includePlaceholders = true)
    {

        if (SemanticsLabel != null && includeSemanticsLabels)
        {
            buffer.Write(SemanticsLabel);
        }
        else if (Text != null)
        {
            buffer.Write(Text);
        }

        if (Children != null)
        {
            foreach (InlineSpan child in Children)
            {
                child.ComputeToPlainText(buffer, includeSemanticsLabels: includeSemanticsLabels, includePlaceholders: includePlaceholders);
            }

        }

    }




    public new void ComputeSemanticsInformation(List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> collector)
    {

        if (Text != null || SemanticsLabel != null)
        {
            collector.Add(new InlineSpanSemanticsInformation(Text, semanticsLabel: SemanticsLabel, recognizer: Recognizer));
        }

        if (Children != null)
        {
            foreach (InlineSpan child in Children)
            {
                child.ComputeSemanticsInformation(collector);
            }

        }

    }




    public new int CodeUnitAtVisitor(int index, FlutterSDK.Painting.Inlinespan.Accumulator offset)
    {
        if (Text == null)
        {
            return null;
        }

        if (index - offset.Value < Text.Length)
        {
            return Text.CodeUnitAt(index - offset.Value);
        }

        offset.Increment(Text.Length);
        return null;
    }




    public new void DescribeSemantics(FlutterSDK.Painting.Inlinespan.Accumulator offset, List<int> semanticsOffsets, List<object> semanticsElements)
    {
        if (Recognizer != null && (Recognizer is TapGestureRecognizer || Recognizer is LongPressGestureRecognizer))
        {
            int length = SemanticsLabel?.Length ?? Text.Length;
            semanticsOffsets.Add(offset.Value);
            semanticsOffsets.Add(offset.Value + length);
            semanticsElements.Add(((TapGestureRecognizer)Recognizer));
        }

        offset.Increment(Text != null ? Text.Length : 0);
    }




    /// <Summary>
    /// In checked mode, throws an exception if the object is not in a valid
    /// configuration. Otherwise, returns true.
    ///
    /// This is intended to be used as follows:
    ///
    /// ```dart
    /// assert(myTextSpan.debugAssertIsValid());
    /// ```
    /// </Summary>
    public new bool DebugAssertIsValid()
    {

        return base.DebugAssertIsValid();
    }




    public new FlutterSDK.Painting.Basictypes.RenderComparison CompareTo(FlutterSDK.Painting.Inlinespan.InlineSpan other)
    {
        if (Dart:coreDefaultClass.Identical(this, other))return RenderComparison.Identical;
        if (other.GetType() != GetType()) return RenderComparison.Layout;
        TextSpan textSpan = other as TextSpan;
        if (textSpan.Text != Text || Children?.Count != textSpan.Children?.Count || (Style == null) != (textSpan.Style == null)) return RenderComparison.Layout;
        RenderComparison result = Recognizer == textSpan.Recognizer ? RenderComparison.Identical : RenderComparison.Metadata;
        if (Style != null)
        {
            RenderComparison candidate = Style.CompareTo(textSpan.Style);
            if (candidate.Index > result.Index) result = candidate;
            if (result == RenderComparison.Layout) return result;
        }

        if (Children != null)
        {
            for (int index = 0; index < Children.Count; index += 1)
            {
                RenderComparison candidate = Children[index].CompareTo(textSpan.Children[index]);
                if (candidate.Index > result.Index) result = candidate;
                if (result == RenderComparison.Layout) return result;
            }

        }

        return result;
    }




    public new bool Equals(@Object other)
    {
        if (Dart:coreDefaultClass.Identical(this, other))return true;
        if (other.GetType() != GetType()) return false;
        if (base != other) return false;
        return other is TextSpan && other.Text == Text && other.Recognizer == Recognizer && other.SemanticsLabel == SemanticsLabel && CollectionsDefaultClass.ListEquals(other.Children, Children);
    }




    public new string ToStringShort() => ObjectDefaultClass.ObjectRuntimeType(this, "TextSpan");



    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new StringProperty("text", Text, showName: false, defaultValue: null));
        if (Style == null && Text == null && Children == null) properties.Add(DiagnosticsNode.Message("(empty)"));
        properties.Add(new DiagnosticsProperty<GestureRecognizer>("recognizer", Recognizer, description: Recognizer?.GetType()?.ToString(), defaultValue: null));
        if (SemanticsLabel != null)
        {
            properties.Add(new StringProperty("semanticsLabel", SemanticsLabel));
        }

    }




    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
    {
        if (Children == null) return new List, < DiagnosticsNode > (};
return Children.Map((InlineSpan child) => {
if (child!=null ){
return child.ToDiagnosticsNode();
}
else
{
    return DiagnosticsNode.Message("<null child>");
}

}
).ToList();
}



#endregion
}

}
