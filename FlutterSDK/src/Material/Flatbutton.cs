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
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
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
namespace FlutterSDK.Material.Flatbutton
{
    internal static class FlatbuttonDefaultClass
    {
    }

    /// <Summary>
    /// A material design "flat button".
    ///
    /// A flat button is a text label displayed on a (zero elevation) [Material]
    /// widget that reacts to touches by filling with color.
    ///
    /// Use flat buttons on toolbars, in dialogs, or inline with other content but
    /// offset from that content with padding so that the button's presence is
    /// obvious. Flat buttons intentionally do not have visible borders and must
    /// therefore rely on their position relative to other content for context. In
    /// dialogs and cards, they should be grouped together in one of the bottom
    /// corners. Avoid using flat buttons where they would blend in with other
    /// content, for example in the middle of lists.
    ///
    /// Material design flat buttons have an all-caps label, some internal padding,
    /// and some defined dimensions. To have a part of your application be
    /// interactive, with ink splashes, without also committing to these stylistic
    /// choices, consider using [InkWell] instead.
    ///
    /// If the [onPressed] and [onLongPress] callbacks are null, then this button will be disabled,
    /// will not react to touch, and will be colored as specified by
    /// the [disabledColor] property instead of the [color] property. If you are
    /// trying to change the button's [color] and it is not having any effect, check
    /// that you are passing a non-null [onPressed] handler.
    ///
    /// Flat buttons have a minimum size of 88.0 by 36.0 which can be overridden
    /// with [ButtonTheme].
    ///
    /// The [clipBehavior] argument must not be null.
    ///
    /// {@tool snippet}
    ///
    /// This example shows a simple [FlatButton].
    ///
    /// ![A simple FlatButton](https://flutter.github.io/assets-for-api-docs/assets/material/flat_button.png)
    ///
    /// ```dart
    /// FlatButton(
    ///   onPressed: () {
    ///     /*...*/
    ///   },
    ///   child: Text(
    ///     "Flat Button",
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    ///
    /// This example shows a [FlatButton] that is normally white-on-blue,
    /// with splashes rendered in a different shade of blue.
    /// It turns black-on-grey when disabled.
    /// The button has 8px of padding on each side, and the text is 20px high.
    ///
    /// ![A FlatButton with white text on a blue background](https://flutter.github.io/assets-for-api-docs/assets/material/flat_button_properties.png)
    ///
    /// ```dart
    /// FlatButton(
    ///   color: Colors.blue,
    ///   textColor: Colors.white,
    ///   disabledColor: Colors.grey,
    ///   disabledTextColor: Colors.black,
    ///   padding: EdgeInsets.all(8.0),
    ///   splashColor: Colors.blueAccent,
    ///   onPressed: () {
    ///     /*...*/
    ///   },
    ///   child: Text(
    ///     "Flat Button",
    ///     style: TextStyle(fontSize: 20.0),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RaisedButton], a filled button whose material elevates when pressed.
    ///  * [DropdownButton], which offers the user a choice of a number of options.
    ///  * [SimpleDialogOption], which is used in [SimpleDialog]s.
    ///  * [IconButton], to create buttons that just contain icons.
    ///  * [InkWell], which implements the ink splash part of a flat button.
    ///  * [RawMaterialButton], the widget this widget is based on.
    ///  * <https://material.io/design/components/buttons.html>
    /// </Summary>
    public class FlatButton : FlutterSDK.Material.Materialbutton.MaterialButton
    {
        /// <Summary>
        /// Create a simple text button.
        ///
        /// The [autofocus] and [clipBehavior] arguments must not be null.
        /// </Summary>
        public FlatButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), Brightness colorBrightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, onPressed: onPressed, onLongPress: onLongPress, onHighlightChanged: onHighlightChanged, textTheme: textTheme, textColor: textColor, disabledTextColor: disabledTextColor, color: color, disabledColor: disabledColor, focusColor: focusColor, hoverColor: hoverColor, highlightColor: highlightColor, splashColor: splashColor, colorBrightness: colorBrightness, padding: padding, visualDensity: visualDensity, shape: shape, clipBehavior: clipBehavior, focusNode: focusNode, autofocus: autofocus, materialTapTargetSize: materialTapTargetSize, child: child)
        {

        }
        /// <Summary>
        /// Create a text button from a pair of widgets that serve as the button's
        /// [icon] and [label].
        ///
        /// The icon and label are arranged in a row and padded by 12 logical pixels
        /// at the start, and 16 at the end, with an 8 pixel gap in between.
        ///
        /// The [icon], [label], and [clipBehavior] arguments must not be null.
        /// </Summary>
        public static FlatButton Icon(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), Brightness colorBrightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = default(bool), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))
        {

        }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            ButtonThemeData buttonTheme = ButtonthemeDefaultClass.ButtonTheme.Of(context);
            return new RawMaterialButton(onPressed: OnPressed, onLongPress: OnLongPress, onHighlightChanged: OnHighlightChanged, fillColor: buttonTheme.GetFillColor(this), textStyle: theme.TextTheme.Button.CopyWith(color: buttonTheme.GetTextColor(this)), focusColor: buttonTheme.GetFocusColor(this), hoverColor: buttonTheme.GetHoverColor(this), highlightColor: buttonTheme.GetHighlightColor(this), splashColor: buttonTheme.GetSplashColor(this), elevation: buttonTheme.GetElevation(this), focusElevation: buttonTheme.GetFocusElevation(this), hoverElevation: buttonTheme.GetHoverElevation(this), highlightElevation: buttonTheme.GetHighlightElevation(this), disabledElevation: buttonTheme.GetDisabledElevation(this), padding: buttonTheme.GetPadding(this), visualDensity: VisualDensity ?? theme.VisualDensity, constraints: buttonTheme.GetConstraints(this), shape: buttonTheme.GetShape(this), clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, materialTapTargetSize: buttonTheme.GetMaterialTapTargetSize(this), animationDuration: buttonTheme.GetAnimationDuration(this), child: Child);
        }



    }


    /// <Summary>
    /// The type of FlatButtons created with [FlatButton.icon].
    ///
    /// This class only exists to give FlatButtons created with [FlatButton.icon]
    /// a distinct class for the sake of [ButtonTheme]. It can not be instantiated.
    /// </Summary>
    public class _FlatButtonWithIcon : FlutterSDK.Material.Flatbutton.FlatButton, IMaterialButtonWithIconMixin
    {
        public _FlatButtonWithIcon(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), Brightness colorBrightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, onPressed: onPressed, onLongPress: onLongPress, onHighlightChanged: onHighlightChanged, textTheme: textTheme, textColor: textColor, disabledTextColor: disabledTextColor, color: color, disabledColor: disabledColor, focusColor: focusColor, hoverColor: hoverColor, highlightColor: highlightColor, splashColor: splashColor, colorBrightness: colorBrightness, padding: padding, shape: shape, clipBehavior: clipBehavior, focusNode: focusNode, autofocus: autofocus, materialTapTargetSize: materialTapTargetSize, child: new Row(mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { icon, new SizedBox(width: 8.0), label }))
        {

        }
    }

}
