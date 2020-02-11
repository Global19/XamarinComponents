using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MaterialComponents
{
    // @protocol MDCElevatable <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCElevatable
    {
        // @required @property (readonly, assign, nonatomic) CGFloat mdc_currentElevation;
        [Abstract]
        [Export("mdc_currentElevation")]
        nfloat Mdc_currentElevation { get; }

        // @required @property (copy, nonatomic) void (^ _Nullable)(id<MDCElevatable> _Nonnull, CGFloat) mdc_elevationDidChangeBlock;
        [Abstract]
        [NullAllowed, Export("mdc_elevationDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCElevatable, nfloat> Mdc_elevationDidChangeBlock { get; set; }
    }

    // @protocol MDCElevationOverriding
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCElevationOverriding
    {
        // @required @property (assign, readwrite, nonatomic) CGFloat mdc_overrideBaseElevation;
        [Abstract]
        [Export("mdc_overrideBaseElevation")]
        nfloat Mdc_overrideBaseElevation { get; set; }
    }

    // @interface MaterialElevation (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_MaterialElevation
    {
        // -(UIColor * _Nonnull)mdc_resolvedColorWithElevation:(CGFloat)elevation;
        [Export("mdc_resolvedColorWithElevation:")]
        UIColor Mdc_resolvedColorWithElevation(nfloat elevation);

        // -(UIColor * _Nonnull)mdc_resolvedColorWithTraitCollection:(UITraitCollection * _Nonnull)traitCollection previousTraitCollection:(UITraitCollection * _Nonnull)previousTraitCollection elevation:(CGFloat)elevation;
        [Export("mdc_resolvedColorWithTraitCollection:previousTraitCollection:elevation:")]
        UIColor Mdc_resolvedColorWithTraitCollection(UITraitCollection traitCollection, UITraitCollection previousTraitCollection, nfloat elevation);

        // -(UIColor * _Nonnull)mdc_resolvedColorWithTraitCollection:(UITraitCollection * _Nonnull)traitCollection elevation:(CGFloat)elevation;
        [Export("mdc_resolvedColorWithTraitCollection:elevation:")]
        UIColor Mdc_resolvedColorWithTraitCollection(UITraitCollection traitCollection, nfloat elevation);
    }

    // @interface MaterialElevationResponding (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_MaterialElevationResponding
    {
        // @property (readonly, assign, nonatomic) CGFloat mdc_baseElevation;
        [Export("mdc_baseElevation")]
        nfloat Mdc_baseElevation { get; }

        // @property (readonly, assign, nonatomic) CGFloat mdc_absoluteElevation;
        [Export("mdc_absoluteElevation")]
        nfloat Mdc_absoluteElevation { get; }

        // -(void)mdc_elevationDidChange;
        [Export("mdc_elevationDidChange")]
        void Mdc_elevationDidChange();
    }

    // @interface MDCCornerTreatment : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCCornerTreatment : INSCopying
    {
        // @property (assign, nonatomic) MDCCornerTreatmentValueType valueType;
        [Export("valueType", ArgumentSemantic.Assign)]
        MDCCornerTreatmentValueType ValueType { get; set; }

        // -(MDCPathGenerator * _Nonnull)pathGeneratorForCornerWithAngle:(CGFloat)angle;
        [Export("pathGeneratorForCornerWithAngle:")]
        MDCPathGenerator PathGeneratorForCornerWithAngle(nfloat angle);

        // -(MDCPathGenerator * _Nonnull)pathGeneratorForCornerWithAngle:(CGFloat)angle forViewSize:(CGSize)size;
        [Export("pathGeneratorForCornerWithAngle:forViewSize:")]
        MDCPathGenerator PathGeneratorForCornerWithAngle(nfloat angle, CGSize size);
    }

    // @interface MDCEdgeTreatment : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCEdgeTreatment : INSCopying
    {
        // -(MDCPathGenerator * _Nonnull)pathGeneratorForEdgeWithLength:(CGFloat)length;
        [Export("pathGeneratorForEdgeWithLength:")]
        MDCPathGenerator PathGeneratorForEdgeWithLength(nfloat length);
    }

    // @interface MDCPathGenerator : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCPathGenerator
    {
        // @property (readonly, nonatomic) CGPoint startPoint;
        [Export("startPoint")]
        CGPoint StartPoint { get; }

        // @property (readonly, nonatomic) CGPoint endPoint;
        [Export("endPoint")]
        CGPoint EndPoint { get; }

        // +(instancetype _Nonnull)pathGenerator;
        [Static]
        [Export("pathGenerator")]
        MDCPathGenerator PathGenerator();

        // +(instancetype _Nonnull)pathGeneratorWithStartPoint:(CGPoint)startPoint;
        [Static]
        [Export("pathGeneratorWithStartPoint:")]
        MDCPathGenerator PathGeneratorWithStartPoint(CGPoint startPoint);

        // -(void)addLineToPoint:(CGPoint)point;
        [Export("addLineToPoint:")]
        void AddLineToPoint(CGPoint point);

        // -(void)addArcWithCenter:(CGPoint)center radius:(CGFloat)radius startAngle:(CGFloat)startAngle endAngle:(CGFloat)endAngle clockwise:(BOOL)clockwise;
        [Export("addArcWithCenter:radius:startAngle:endAngle:clockwise:")]
        void AddArcWithCenter(CGPoint center, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise);

        // -(void)addArcWithTangentPoint:(CGPoint)tangentPoint toPoint:(CGPoint)toPoint radius:(CGFloat)radius;
        [Export("addArcWithTangentPoint:toPoint:radius:")]
        void AddArcWithTangentPoint(CGPoint tangentPoint, CGPoint toPoint, nfloat radius);

        // -(void)addCurveWithControlPoint1:(CGPoint)controlPoint1 controlPoint2:(CGPoint)controlPoint2 toPoint:(CGPoint)toPoint;
        [Export("addCurveWithControlPoint1:controlPoint2:toPoint:")]
        void AddCurveWithControlPoint1(CGPoint controlPoint1, CGPoint controlPoint2, CGPoint toPoint);

        // -(void)addQuadCurveWithControlPoint:(CGPoint)controlPoint toPoint:(CGPoint)toPoint;
        [Export("addQuadCurveWithControlPoint:toPoint:")]
        void AddQuadCurveWithControlPoint(CGPoint controlPoint, CGPoint toPoint);

        // -(void)appendToCGPath:(CGMutablePathRef _Nonnull)cgPath transform:(CGAffineTransform * _Nullable)transform;
        [Export("appendToCGPath:transform:")]
        unsafe void AppendToCGPath(CGMutablePathRef* cgPath, [NullAllowed] CGAffineTransform* transform);
    }

    // @protocol MDCShapeGenerating <NSCopying>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCShapeGenerating : INSCopying
    {
        // @required -(CGPathRef _Nullable)pathForSize:(CGSize)size;
        [Abstract]
        [Export("pathForSize:")]
        [return: NullAllowed]
        unsafe CGPathRef* PathForSize(CGSize size);
    }

    // @interface MDCRectangleShapeGenerator : NSObject <MDCShapeGenerating>
    [BaseType(typeof(NSObject))]
    interface MDCRectangleShapeGenerator : IMDCShapeGenerating
    {
        // @property (nonatomic, strong) MDCCornerTreatment * topLeftCorner;
        [Export("topLeftCorner", ArgumentSemantic.Strong)]
        MDCCornerTreatment TopLeftCorner { get; set; }

        // @property (nonatomic, strong) MDCCornerTreatment * topRightCorner;
        [Export("topRightCorner", ArgumentSemantic.Strong)]
        MDCCornerTreatment TopRightCorner { get; set; }

        // @property (nonatomic, strong) MDCCornerTreatment * bottomLeftCorner;
        [Export("bottomLeftCorner", ArgumentSemantic.Strong)]
        MDCCornerTreatment BottomLeftCorner { get; set; }

        // @property (nonatomic, strong) MDCCornerTreatment * bottomRightCorner;
        [Export("bottomRightCorner", ArgumentSemantic.Strong)]
        MDCCornerTreatment BottomRightCorner { get; set; }

        // @property (assign, nonatomic) CGPoint topLeftCornerOffset;
        [Export("topLeftCornerOffset", ArgumentSemantic.Assign)]
        CGPoint TopLeftCornerOffset { get; set; }

        // @property (assign, nonatomic) CGPoint topRightCornerOffset;
        [Export("topRightCornerOffset", ArgumentSemantic.Assign)]
        CGPoint TopRightCornerOffset { get; set; }

        // @property (assign, nonatomic) CGPoint bottomLeftCornerOffset;
        [Export("bottomLeftCornerOffset", ArgumentSemantic.Assign)]
        CGPoint BottomLeftCornerOffset { get; set; }

        // @property (assign, nonatomic) CGPoint bottomRightCornerOffset;
        [Export("bottomRightCornerOffset", ArgumentSemantic.Assign)]
        CGPoint BottomRightCornerOffset { get; set; }

        // @property (nonatomic, strong) MDCEdgeTreatment * topEdge;
        [Export("topEdge", ArgumentSemantic.Strong)]
        MDCEdgeTreatment TopEdge { get; set; }

        // @property (nonatomic, strong) MDCEdgeTreatment * rightEdge;
        [Export("rightEdge", ArgumentSemantic.Strong)]
        MDCEdgeTreatment RightEdge { get; set; }

        // @property (nonatomic, strong) MDCEdgeTreatment * bottomEdge;
        [Export("bottomEdge", ArgumentSemantic.Strong)]
        MDCEdgeTreatment BottomEdge { get; set; }

        // @property (nonatomic, strong) MDCEdgeTreatment * leftEdge;
        [Export("leftEdge", ArgumentSemantic.Strong)]
        MDCEdgeTreatment LeftEdge { get; set; }

        // -(void)setCorners:(MDCCornerTreatment *)cornerShape;
        [Export("setCorners:")]
        void SetCorners(MDCCornerTreatment cornerShape);

        // -(void)setEdges:(MDCEdgeTreatment *)edgeShape;
        [Export("setEdges:")]
        void SetEdges(MDCEdgeTreatment edgeShape);
    }

    // @interface MDCShadowMetrics : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCShadowMetrics
    {
        // @property (readonly, nonatomic) CGFloat topShadowRadius;
        [Export("topShadowRadius")]
        nfloat TopShadowRadius { get; }

        // @property (readonly, nonatomic) CGSize topShadowOffset;
        [Export("topShadowOffset")]
        CGSize TopShadowOffset { get; }

        // @property (readonly, nonatomic) float topShadowOpacity;
        [Export("topShadowOpacity")]
        float TopShadowOpacity { get; }

        // @property (readonly, nonatomic) CGFloat bottomShadowRadius;
        [Export("bottomShadowRadius")]
        nfloat BottomShadowRadius { get; }

        // @property (readonly, nonatomic) CGSize bottomShadowOffset;
        [Export("bottomShadowOffset")]
        CGSize BottomShadowOffset { get; }

        // @property (readonly, nonatomic) float bottomShadowOpacity;
        [Export("bottomShadowOpacity")]
        float BottomShadowOpacity { get; }

        // +(MDCShadowMetrics * _Nonnull)metricsWithElevation:(CGFloat)elevation;
        [Static]
        [Export("metricsWithElevation:")]
        MDCShadowMetrics MetricsWithElevation(nfloat elevation);
    }

    // @interface MDCShadowLayer : CALayer
    [BaseType(typeof(CALayer))]
    interface MDCShadowLayer
    {
        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (getter = isShadowMaskEnabled, assign, nonatomic) BOOL shadowMaskEnabled;
        [Export("shadowMaskEnabled")]
        bool ShadowMaskEnabled { [Bind("isShadowMaskEnabled")] get; set; }

        // -(void)animateCornerRadius:(CGFloat)cornerRadius withTimingFunction:(CAMediaTimingFunction * _Nonnull)timingFunction duration:(NSTimeInterval)duration;
        [Export("animateCornerRadius:withTimingFunction:duration:")]
        void AnimateCornerRadius(nfloat cornerRadius, CAMediaTimingFunction timingFunction, double duration);
    }

    // @interface Subclassing (MDCShadowLayer) <CALayerDelegate>
    [Category]
    [BaseType(typeof(MDCShadowLayer))]
    interface MDCShadowLayer_Subclassing : ICALayerDelegate
    {
    }

    // @interface MDCShapedShadowLayer : MDCShadowLayer
    [BaseType(typeof(MDCShadowLayer))]
    interface MDCShapedShadowLayer
    {
        // @property (nonatomic, strong) UIColor * _Nullable shapedBackgroundColor;
        [NullAllowed, Export("shapedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ShapedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable shapedBorderColor;
        [NullAllowed, Export("shapedBorderColor", ArgumentSemantic.Strong)]
        UIColor ShapedBorderColor { get; set; }

        // @property (assign, nonatomic) CGFloat shapedBorderWidth;
        [Export("shapedBorderWidth")]
        nfloat ShapedBorderWidth { get; set; }

        // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
        [NullAllowed, Export("shapeGenerator", ArgumentSemantic.Strong)]
        MDCShapeGenerating ShapeGenerator { get; set; }

        // @property (nonatomic, strong) CAShapeLayer * _Nonnull shapeLayer;
        [Export("shapeLayer", ArgumentSemantic.Strong)]
        CAShapeLayer ShapeLayer { get; set; }

        // @property (nonatomic, strong) CAShapeLayer * _Nonnull colorLayer;
        [Export("colorLayer", ArgumentSemantic.Strong)]
        CAShapeLayer ColorLayer { get; set; }
    }

    // @interface MDCShapedView : UIView
    [BaseType(typeof(UIView))]
    interface MDCShapedView
    {
        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator __attribute__((iboutlet));
        [NullAllowed, Export("shapeGenerator", ArgumentSemantic.Strong)]
        MDCShapeGenerating ShapeGenerator { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame shapeGenerator:(id<MDCShapeGenerating> _Nullable)shapeGenerator __attribute__((objc_designated_initializer));
        [Export("initWithFrame:shapeGenerator:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, [NullAllowed] MDCShapeGenerating shapeGenerator);
    }

    // @interface MDCBottomSheetController : UIViewController <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIViewController))]
    [DisableDefaultCtor]
    interface MDCBottomSheetController : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (readonly, nonatomic, strong) UIViewController * _Nonnull contentViewController;
        [Export("contentViewController", ArgumentSemantic.Strong)]
        UIViewController ContentViewController { get; }

        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }

        // @property (assign, nonatomic) BOOL shouldFlashScrollIndicatorsOnAppearance;
        [Export("shouldFlashScrollIndicatorsOnAppearance")]
        bool ShouldFlashScrollIndicatorsOnAppearance { get; set; }

        // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
        [Export("dismissOnBackgroundTap")]
        bool DismissOnBackgroundTap { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        // @property (assign, nonatomic) BOOL isScrimAccessibilityElement;
        [Export("isScrimAccessibilityElement")]
        bool IsScrimAccessibilityElement { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityLabel;
        [NullAllowed, Export("scrimAccessibilityLabel")]
        string ScrimAccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityHint;
        [NullAllowed, Export("scrimAccessibilityHint")]
        string ScrimAccessibilityHint { get; set; }

        // @property (assign, nonatomic) UIAccessibilityTraits scrimAccessibilityTraits;
        [Export("scrimAccessibilityTraits")]
        ulong ScrimAccessibilityTraits { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCBottomSheetControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCBottomSheetControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) MDCSheetState state;
        [Export("state")]
        MDCSheetState State { get; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController;
        [Export("initWithContentViewController:")]
        IntPtr Constructor(UIViewController contentViewController);

        // -(void)setShapeGenerator:(id<MDCShapeGenerating> _Nullable)shapeGenerator forState:(MDCSheetState)state;
        [Export("setShapeGenerator:forState:")]
        void SetShapeGenerator([NullAllowed] MDCShapeGenerating shapeGenerator, MDCSheetState state);

        // -(id<MDCShapeGenerating> _Nullable)shapeGeneratorForState:(MDCSheetState)state;
        [Export("shapeGeneratorForState:")]
        [return: NullAllowed]
        MDCShapeGenerating ShapeGeneratorForState(MDCSheetState state);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBottomSheetController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBottomSheetController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCBottomSheetControllerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCBottomSheetControllerDelegate
    {
        // @optional -(void)bottomSheetControllerDidDismissBottomSheet:(MDCBottomSheetController * _Nonnull)controller;
        [Export("bottomSheetControllerDidDismissBottomSheet:")]
        void BottomSheetControllerDidDismissBottomSheet(MDCBottomSheetController controller);

        // @optional -(void)bottomSheetControllerStateChanged:(MDCBottomSheetController * _Nonnull)controller state:(MDCSheetState)state;
        [Export("bottomSheetControllerStateChanged:state:")]
        void BottomSheetControllerStateChanged(MDCBottomSheetController controller, MDCSheetState state);

        // @optional -(void)bottomSheetControllerDidChangeYOffset:(MDCBottomSheetController * _Nonnull)controller yOffset:(CGFloat)yOffset;
        [Export("bottomSheetControllerDidChangeYOffset:yOffset:")]
        void BottomSheetControllerDidChangeYOffset(MDCBottomSheetController controller, nfloat yOffset);
    }

    // @protocol MDCBottomSheetPresentationControllerDelegate <UIAdaptivePresentationControllerDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCBottomSheetPresentationControllerDelegate : IUIAdaptivePresentationControllerDelegate
    {
        // @optional -(void)prepareForBottomSheetPresentation:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet;
        [Export("prepareForBottomSheetPresentation:")]
        void PrepareForBottomSheetPresentation(MDCBottomSheetPresentationController bottomSheet);

        // @optional -(void)bottomSheetPresentationControllerDidDismissBottomSheet:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet;
        [Export("bottomSheetPresentationControllerDidDismissBottomSheet:")]
        void BottomSheetPresentationControllerDidDismissBottomSheet(MDCBottomSheetPresentationController bottomSheet);

        // @optional -(void)bottomSheetWillChangeState:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet sheetState:(MDCSheetState)sheetState;
        [Export("bottomSheetWillChangeState:sheetState:")]
        void BottomSheetWillChangeState(MDCBottomSheetPresentationController bottomSheet, MDCSheetState sheetState);

        // @optional -(void)bottomSheetDidChangeYOffset:(MDCBottomSheetPresentationController * _Nonnull)bottomSheet yOffset:(CGFloat)yOffset;
        [Export("bottomSheetDidChangeYOffset:yOffset:")]
        void BottomSheetDidChangeYOffset(MDCBottomSheetPresentationController bottomSheet, nfloat yOffset);
    }

    // @interface MDCBottomSheetPresentationController : UIPresentationController
    [BaseType(typeof(UIPresentationController))]
    interface MDCBottomSheetPresentationController
    {
        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }

        // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
        [Export("dismissOnBackgroundTap")]
        bool DismissOnBackgroundTap { get; set; }

        // @property (assign, nonatomic) CGFloat preferredSheetHeight;
        [Export("preferredSheetHeight")]
        nfloat PreferredSheetHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        // @property (assign, nonatomic) BOOL isScrimAccessibilityElement;
        [Export("isScrimAccessibilityElement")]
        bool IsScrimAccessibilityElement { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityLabel;
        [NullAllowed, Export("scrimAccessibilityLabel")]
        string ScrimAccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityHint;
        [NullAllowed, Export("scrimAccessibilityHint")]
        string ScrimAccessibilityHint { get; set; }

        // @property (assign, nonatomic) UIAccessibilityTraits scrimAccessibilityTraits;
        [Export("scrimAccessibilityTraits")]
        ulong ScrimAccessibilityTraits { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCBottomSheetPresentationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCBottomSheetPresentationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBottomSheetPresentationController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBottomSheetPresentationController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCBottomSheetTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>
    [BaseType(typeof(NSObject))]
    interface MDCBottomSheetTransitionController : IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
    {
        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }

        // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
        [Export("dismissOnBackgroundTap")]
        bool DismissOnBackgroundTap { get; set; }

        // @property (assign, nonatomic) CGFloat preferredSheetHeight;
        [Export("preferredSheetHeight")]
        nfloat PreferredSheetHeight { get; set; }
    }

    // @interface ScrimAccessibility (MDCBottomSheetTransitionController)
    [Category]
    [BaseType(typeof(MDCBottomSheetTransitionController))]
    interface MDCBottomSheetTransitionController_ScrimAccessibility
    {
        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        // @property (assign, nonatomic) BOOL isScrimAccessibilityElement;
        [Export("isScrimAccessibilityElement")]
        bool IsScrimAccessibilityElement { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityLabel;
        [NullAllowed, Export("scrimAccessibilityLabel")]
        string ScrimAccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityHint;
        [NullAllowed, Export("scrimAccessibilityHint")]
        string ScrimAccessibilityHint { get; set; }

        // @property (assign, nonatomic) UIAccessibilityTraits scrimAccessibilityTraits;
        [Export("scrimAccessibilityTraits")]
        ulong ScrimAccessibilityTraits { get; set; }
    }

    // @interface MaterialBottomSheet (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_MaterialBottomSheet
    {
        // @property (readonly, nonatomic) MDCBottomSheetPresentationController * _Nullable mdc_bottomSheetPresentationController;
        [NullAllowed, Export("mdc_bottomSheetPresentationController")]
        MDCBottomSheetPresentationController Mdc_bottomSheetPresentationController { get; }
    }

    // @interface MDCActionSheetController : UIViewController <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIViewController))]
    interface MDCActionSheetController : IMDCElevatable, IMDCElevationOverriding
    {
        // +(instancetype _Nonnull)actionSheetControllerWithTitle:(NSString * _Nullable)title message:(NSString * _Nullable)message;
        [Static]
        [Export("actionSheetControllerWithTitle:message:")]
        MDCActionSheetController ActionSheetControllerWithTitle([NullAllowed] string title, [NullAllowed] string message);

        // +(instancetype _Nonnull)actionSheetControllerWithTitle:(NSString * _Nullable)title;
        [Static]
        [Export("actionSheetControllerWithTitle:")]
        MDCActionSheetController ActionSheetControllerWithTitle([NullAllowed] string title);

        // -(void)addAction:(MDCActionSheetAction * _Nonnull)action;
        [Export("addAction:")]
        void AddAction(MDCActionSheetAction action);

        // @property (readonly, copy, nonatomic) NSArray<MDCActionSheetAction *> * _Nonnull actions;
        [Export("actions", ArgumentSemantic.Copy)]
        MDCActionSheetAction[] Actions { get; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCActionSheetController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCActionSheetController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // @property (nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (nonatomic, strong) UIFont * _Nonnull titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull messageFont;
        [Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable actionFont;
        [NullAllowed, Export("actionFont", ArgumentSemantic.Strong)]
        UIFont ActionFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleTextColor;
        [NullAllowed, Export("titleTextColor", ArgumentSemantic.Strong)]
        UIColor TitleTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable messageTextColor;
        [NullAllowed, Export("messageTextColor", ArgumentSemantic.Strong)]
        UIColor MessageTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable actionTextColor;
        [NullAllowed, Export("actionTextColor", ArgumentSemantic.Strong)]
        UIColor ActionTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable actionTintColor;
        [NullAllowed, Export("actionTintColor", ArgumentSemantic.Strong)]
        UIColor ActionTintColor { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rippleColor;
        [NullAllowed, Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (nonatomic) UIImageRenderingMode imageRenderingMode;
        [Export("imageRenderingMode", ArgumentSemantic.Assign)]
        UIImageRenderingMode ImageRenderingMode { get; set; }

        // @property (assign, nonatomic) BOOL showsHeaderDivider;
        [Export("showsHeaderDivider")]
        bool ShowsHeaderDivider { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull headerDividerColor;
        [Export("headerDividerColor", ArgumentSemantic.Copy)]
        UIColor HeaderDividerColor { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (assign, nonatomic) BOOL alwaysAlignTitleLeadingEdges;
        [Export("alwaysAlignTitleLeadingEdges")]
        bool AlwaysAlignTitleLeadingEdges { get; set; }

        // @property (readonly, nonatomic, strong) MDCBottomSheetTransitionController * _Nonnull transitionController;
        [Export("transitionController", ArgumentSemantic.Strong)]
        MDCBottomSheetTransitionController TransitionController { get; }
    }

    // typedef void (^MDCActionSheetHandler)(MDCActionSheetAction * _Nonnull);
    delegate void MDCActionSheetHandler(MDCActionSheetAction arg0);

    // @interface MDCActionSheetAction : NSObject <NSCopying, UIAccessibilityIdentification>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCActionSheetAction : INSCopying, IUIAccessibilityIdentification
    {
        // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nullable)image handler:(MDCActionSheetHandler _Nullable)handler;
        [Static]
        [Export("actionWithTitle:image:handler:")]
        MDCActionSheetAction ActionWithTitle(string title, [NullAllowed] UIImage image, [NullAllowed] MDCActionSheetHandler handler);

        // @property (readonly, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) UIImage * _Nullable image;
        [NullAllowed, Export("image")]
        UIImage Image { get; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
        [NullAllowed, Export("accessibilityIdentifier")]
        string AccessibilityIdentifier { get; set; }

        // @property (copy, nonatomic) UIColor * _Nullable titleColor;
        [NullAllowed, Export("titleColor", ArgumentSemantic.Copy)]
        UIColor TitleColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nullable tintColor;
        [NullAllowed, Export("tintColor", ArgumentSemantic.Copy)]
        UIColor TintColor { get; set; }
    }

    // @interface ToBeDeprecated (MDCActionSheetController)
    [Category]
    [BaseType(typeof(MDCActionSheetController))]
    interface MDCActionSheetController_ToBeDeprecated
    {
        // @property (nonatomic, strong) UIColor * _Nullable inkColor;
        [NullAllowed, Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }
    }

    // @protocol MDCColorScheme <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCColorScheme
    {
        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Abstract]
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; }

        // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryLightColor;
        [Export("primaryLightColor", ArgumentSemantic.Strong)]
        UIColor PrimaryLightColor { get; }

        // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryDarkColor;
        [Export("primaryDarkColor", ArgumentSemantic.Strong)]
        UIColor PrimaryDarkColor { get; }

        // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; }

        // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryLightColor;
        [Export("secondaryLightColor", ArgumentSemantic.Strong)]
        UIColor SecondaryLightColor { get; }

        // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryDarkColor;
        [Export("secondaryDarkColor", ArgumentSemantic.Strong)]
        UIColor SecondaryDarkColor { get; }
    }

    // @interface MDCBasicColorScheme : NSObject <MDCColorScheme, NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCBasicColorScheme : IMDCColorScheme, INSCopying
    {
        // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryLightColor;
        [Export("primaryLightColor", ArgumentSemantic.Strong)]
        UIColor PrimaryLightColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryDarkColor;
        [Export("primaryDarkColor", ArgumentSemantic.Strong)]
        UIColor PrimaryDarkColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryLightColor;
        [Export("secondaryLightColor", ArgumentSemantic.Strong)]
        UIColor SecondaryLightColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryDarkColor;
        [Export("secondaryDarkColor", ArgumentSemantic.Strong)]
        UIColor SecondaryDarkColor { get; }

        // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryLightColor:(UIColor * _Nonnull)primaryLightColor primaryDarkColor:(UIColor * _Nonnull)primaryDarkColor secondaryColor:(UIColor * _Nonnull)secondaryColor secondaryLightColor:(UIColor * _Nonnull)secondaryLightColor secondaryDarkColor:(UIColor * _Nonnull)secondaryDarkColor __attribute__((objc_designated_initializer));
        [Export("initWithPrimaryColor:primaryLightColor:primaryDarkColor:secondaryColor:secondaryLightColor:secondaryDarkColor:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIColor primaryColor, UIColor primaryLightColor, UIColor primaryDarkColor, UIColor secondaryColor, UIColor secondaryLightColor, UIColor secondaryDarkColor);

        // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
        [Export("initWithPrimaryColor:")]
        IntPtr Constructor(UIColor primaryColor);

        // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryLightColor:(UIColor * _Nonnull)primaryLightColor primaryDarkColor:(UIColor * _Nonnull)primaryDarkColor;
        [Export("initWithPrimaryColor:primaryLightColor:primaryDarkColor:")]
        IntPtr Constructor(UIColor primaryColor, UIColor primaryLightColor, UIColor primaryDarkColor);

        // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor;
        [Export("initWithPrimaryColor:secondaryColor:")]
        IntPtr Constructor(UIColor primaryColor, UIColor secondaryColor);
    }

    // @interface MDCTonalColorScheme : NSObject <MDCColorScheme, NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCTonalColorScheme : IMDCColorScheme, INSCopying
    {
        // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryLightColor;
        [Export("primaryLightColor", ArgumentSemantic.Strong)]
        UIColor PrimaryLightColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryDarkColor;
        [Export("primaryDarkColor", ArgumentSemantic.Strong)]
        UIColor PrimaryDarkColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryLightColor;
        [Export("secondaryLightColor", ArgumentSemantic.Strong)]
        UIColor SecondaryLightColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryDarkColor;
        [Export("secondaryDarkColor", ArgumentSemantic.Strong)]
        UIColor SecondaryDarkColor { get; }

        // @property (readonly, nonatomic, strong) MDCTonalPalette * _Nonnull primaryTonalPalette;
        [Export("primaryTonalPalette", ArgumentSemantic.Strong)]
        MDCTonalPalette PrimaryTonalPalette { get; }

        // @property (readonly, nonatomic, strong) MDCTonalPalette * _Nonnull secondaryTonalPalette;
        [Export("secondaryTonalPalette", ArgumentSemantic.Strong)]
        MDCTonalPalette SecondaryTonalPalette { get; }

        // -(instancetype _Nonnull)initWithPrimaryTonalPalette:(MDCTonalPalette * _Nonnull)primaryTonalPalette secondaryTonalPalette:(MDCTonalPalette * _Nonnull)secondaryTonalPalette __attribute__((objc_designated_initializer));
        [Export("initWithPrimaryTonalPalette:secondaryTonalPalette:")]
        [DesignatedInitializer]
        IntPtr Constructor(MDCTonalPalette primaryTonalPalette, MDCTonalPalette secondaryTonalPalette);
    }

    // @interface MDCTonalPalette : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCTonalPalette : INSCopying
    {
        // @property (readonly, copy, nonatomic) NSArray<UIColor *> * _Nonnull colors;
        [Export("colors", ArgumentSemantic.Copy)]
        UIColor[] Colors { get; }

        // @property (readonly, nonatomic) NSUInteger mainColorIndex;
        [Export("mainColorIndex")]
        nuint MainColorIndex { get; }

        // @property (readonly, nonatomic) NSUInteger lightColorIndex;
        [Export("lightColorIndex")]
        nuint LightColorIndex { get; }

        // @property (readonly, nonatomic) NSUInteger darkColorIndex;
        [Export("darkColorIndex")]
        nuint DarkColorIndex { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull mainColor;
        [Export("mainColor", ArgumentSemantic.Strong)]
        UIColor MainColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull lightColor;
        [Export("lightColor", ArgumentSemantic.Strong)]
        UIColor LightColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull darkColor;
        [Export("darkColor", ArgumentSemantic.Strong)]
        UIColor DarkColor { get; }

        // -(instancetype _Nonnull)initWithColors:(NSArray<UIColor *> * _Nonnull)colors mainColorIndex:(NSUInteger)mainColorIndex lightColorIndex:(NSUInteger)lightColorIndex darkColorIndex:(NSUInteger)darkColorIndex __attribute__((objc_designated_initializer));
        [Export("initWithColors:mainColorIndex:lightColorIndex:darkColorIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIColor[] colors, nuint mainColorIndex, nuint lightColorIndex, nuint darkColorIndex);
    }

    // @protocol MDCColorScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol(Name = "MDCColorScheming")]
    interface MDCColorScheming
    {
        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull primaryColor;
        [Abstract]
        [Export("primaryColor", ArgumentSemantic.Copy)]
        UIColor PrimaryColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull primaryColorVariant;
        [Abstract]
        [Export("primaryColorVariant", ArgumentSemantic.Copy)]
        UIColor PrimaryColorVariant { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull secondaryColor;
        [Abstract]
        [Export("secondaryColor", ArgumentSemantic.Copy)]
        UIColor SecondaryColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull errorColor;
        [Abstract]
        [Export("errorColor", ArgumentSemantic.Copy)]
        UIColor ErrorColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull surfaceColor;
        [Abstract]
        [Export("surfaceColor", ArgumentSemantic.Copy)]
        UIColor SurfaceColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull backgroundColor;
        [Abstract]
        [Export("backgroundColor", ArgumentSemantic.Copy)]
        UIColor BackgroundColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull onPrimaryColor;
        [Abstract]
        [Export("onPrimaryColor", ArgumentSemantic.Copy)]
        UIColor OnPrimaryColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull onSecondaryColor;
        [Abstract]
        [Export("onSecondaryColor", ArgumentSemantic.Copy)]
        UIColor OnSecondaryColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull onSurfaceColor;
        [Abstract]
        [Export("onSurfaceColor", ArgumentSemantic.Copy)]
        UIColor OnSurfaceColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull onBackgroundColor;
        [Abstract]
        [Export("onBackgroundColor", ArgumentSemantic.Copy)]
        UIColor OnBackgroundColor { get; }

        // @required @property (readonly, copy, nonatomic) UIColor * _Nonnull elevationOverlayColor;
        [Abstract]
        [Export("elevationOverlayColor", ArgumentSemantic.Copy)]
        UIColor ElevationOverlayColor { get; }

        // @required @property (readonly, assign, nonatomic) BOOL elevationOverlayEnabledForDarkMode;
        [Abstract]
        [Export("elevationOverlayEnabledForDarkMode")]
        bool ElevationOverlayEnabledForDarkMode { get; }
    }

    // @interface MDCSemanticColorScheme : NSObject <MDCColorScheming, NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCSemanticColorScheme : IMDCColorScheming, INSCopying
    {
        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Copy)]
        UIColor PrimaryColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull primaryColorVariant;
        [Export("primaryColorVariant", ArgumentSemantic.Copy)]
        UIColor PrimaryColorVariant { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Copy)]
        UIColor SecondaryColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull errorColor;
        [Export("errorColor", ArgumentSemantic.Copy)]
        UIColor ErrorColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull surfaceColor;
        [Export("surfaceColor", ArgumentSemantic.Copy)]
        UIColor SurfaceColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Copy)]
        UIColor BackgroundColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull onPrimaryColor;
        [Export("onPrimaryColor", ArgumentSemantic.Copy)]
        UIColor OnPrimaryColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull onSecondaryColor;
        [Export("onSecondaryColor", ArgumentSemantic.Copy)]
        UIColor OnSecondaryColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull onSurfaceColor;
        [Export("onSurfaceColor", ArgumentSemantic.Copy)]
        UIColor OnSurfaceColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull onBackgroundColor;
        [Export("onBackgroundColor", ArgumentSemantic.Copy)]
        UIColor OnBackgroundColor { get; set; }

        // @property (readwrite, copy, nonatomic) UIColor * _Nonnull elevationOverlayColor;
        [Export("elevationOverlayColor", ArgumentSemantic.Copy)]
        UIColor ElevationOverlayColor { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL elevationOverlayEnabledForDarkMode;
        [Export("elevationOverlayEnabledForDarkMode")]
        bool ElevationOverlayEnabledForDarkMode { get; set; }

        // -(instancetype _Nonnull)initWithDefaults:(MDCColorSchemeDefaults)defaults;
        [Export("initWithDefaults:")]
        IntPtr Constructor(MDCColorSchemeDefaults defaults);

        // +(UIColor * _Nonnull)blendColor:(UIColor * _Nonnull)color withBackgroundColor:(UIColor * _Nonnull)backgroundColor;
        [Static]
        [Export("blendColor:withBackgroundColor:")]
        UIColor BlendColor(UIColor color, UIColor backgroundColor);
    }

    // @interface MDCShapeCategory : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCShapeCategory : INSCopying
    {
        // @property (copy, nonatomic) MDCCornerTreatment * topLeftCorner;
        [Export("topLeftCorner", ArgumentSemantic.Copy)]
        MDCCornerTreatment TopLeftCorner { get; set; }

        // @property (copy, nonatomic) MDCCornerTreatment * topRightCorner;
        [Export("topRightCorner", ArgumentSemantic.Copy)]
        MDCCornerTreatment TopRightCorner { get; set; }

        // @property (copy, nonatomic) MDCCornerTreatment * bottomLeftCorner;
        [Export("bottomLeftCorner", ArgumentSemantic.Copy)]
        MDCCornerTreatment BottomLeftCorner { get; set; }

        // @property (copy, nonatomic) MDCCornerTreatment * bottomRightCorner;
        [Export("bottomRightCorner", ArgumentSemantic.Copy)]
        MDCCornerTreatment BottomRightCorner { get; set; }

        // -(instancetype)initCornersWithFamily:(MDCShapeCornerFamily)cornerFamily andSize:(CGFloat)cornerSize;
        [Export("initCornersWithFamily:andSize:")]
        IntPtr Constructor(MDCShapeCornerFamily cornerFamily, nfloat cornerSize);
    }

    // @protocol MDCShapeScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCShapeScheming
    {
        // @required @property (readonly, nonatomic) MDCShapeCategory * _Nonnull smallComponentShape;
        [Abstract]
        [Export("smallComponentShape")]
        MDCShapeCategory SmallComponentShape { get; }

        // @required @property (readonly, nonatomic) MDCShapeCategory * _Nonnull mediumComponentShape;
        [Abstract]
        [Export("mediumComponentShape")]
        MDCShapeCategory MediumComponentShape { get; }

        // @required @property (readonly, nonatomic) MDCShapeCategory * _Nonnull largeComponentShape;
        [Abstract]
        [Export("largeComponentShape")]
        MDCShapeCategory LargeComponentShape { get; }
    }

    // @interface MDCShapeScheme : NSObject <MDCShapeScheming>
    [BaseType(typeof(NSObject))]
    interface MDCShapeScheme : IMDCShapeScheming
    {
        // @property (readwrite, nonatomic) MDCShapeCategory * _Nonnull smallComponentShape;
        [Export("smallComponentShape", ArgumentSemantic.Assign)]
        MDCShapeCategory SmallComponentShape { get; set; }

        // @property (readwrite, nonatomic) MDCShapeCategory * _Nonnull mediumComponentShape;
        [Export("mediumComponentShape", ArgumentSemantic.Assign)]
        MDCShapeCategory MediumComponentShape { get; set; }

        // @property (readwrite, nonatomic) MDCShapeCategory * _Nonnull largeComponentShape;
        [Export("largeComponentShape", ArgumentSemantic.Assign)]
        MDCShapeCategory LargeComponentShape { get; set; }

        // -(instancetype _Nonnull)initWithDefaults:(MDCShapeSchemeDefaults)defaults;
        [Export("initWithDefaults:")]
        IntPtr Constructor(MDCShapeSchemeDefaults defaults);
    }

    // @protocol MDCFontScheme <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCFontScheme
    {
        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline1;
        [Abstract]
        [NullAllowed, Export("headline1", ArgumentSemantic.Strong)]
        UIFont Headline1 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline2;
        [Abstract]
        [NullAllowed, Export("headline2", ArgumentSemantic.Strong)]
        UIFont Headline2 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline3;
        [Abstract]
        [NullAllowed, Export("headline3", ArgumentSemantic.Strong)]
        UIFont Headline3 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline4;
        [Abstract]
        [NullAllowed, Export("headline4", ArgumentSemantic.Strong)]
        UIFont Headline4 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline5;
        [Abstract]
        [NullAllowed, Export("headline5", ArgumentSemantic.Strong)]
        UIFont Headline5 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline6;
        [Abstract]
        [NullAllowed, Export("headline6", ArgumentSemantic.Strong)]
        UIFont Headline6 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable subtitle1;
        [Abstract]
        [NullAllowed, Export("subtitle1", ArgumentSemantic.Strong)]
        UIFont Subtitle1 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable subtitle2;
        [Abstract]
        [NullAllowed, Export("subtitle2", ArgumentSemantic.Strong)]
        UIFont Subtitle2 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable body1;
        [Abstract]
        [NullAllowed, Export("body1", ArgumentSemantic.Strong)]
        UIFont Body1 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable body2;
        [Abstract]
        [NullAllowed, Export("body2", ArgumentSemantic.Strong)]
        UIFont Body2 { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable caption;
        [Abstract]
        [NullAllowed, Export("caption", ArgumentSemantic.Strong)]
        UIFont Caption { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable button;
        [Abstract]
        [NullAllowed, Export("button", ArgumentSemantic.Strong)]
        UIFont Button { get; }

        // @required @property (readonly, nonatomic, strong) UIFont * _Nullable overline;
        [Abstract]
        [NullAllowed, Export("overline", ArgumentSemantic.Strong)]
        UIFont Overline { get; }
    }

    // @interface MDCBasicFontScheme : NSObject <MDCFontScheme>
    [BaseType(typeof(NSObject))]
    interface MDCBasicFontScheme : IMDCFontScheme
    {
        // @property (nonatomic) UIFont * _Nullable headline1;
        [NullAllowed, Export("headline1", ArgumentSemantic.Assign)]
        UIFont Headline1 { get; set; }

        // @property (nonatomic) UIFont * _Nullable headline2;
        [NullAllowed, Export("headline2", ArgumentSemantic.Assign)]
        UIFont Headline2 { get; set; }

        // @property (nonatomic) UIFont * _Nullable headline3;
        [NullAllowed, Export("headline3", ArgumentSemantic.Assign)]
        UIFont Headline3 { get; set; }

        // @property (nonatomic) UIFont * _Nullable headline4;
        [NullAllowed, Export("headline4", ArgumentSemantic.Assign)]
        UIFont Headline4 { get; set; }

        // @property (nonatomic) UIFont * _Nullable headline5;
        [NullAllowed, Export("headline5", ArgumentSemantic.Assign)]
        UIFont Headline5 { get; set; }

        // @property (nonatomic) UIFont * _Nullable headline6;
        [NullAllowed, Export("headline6", ArgumentSemantic.Assign)]
        UIFont Headline6 { get; set; }

        // @property (nonatomic) UIFont * _Nullable subtitle1;
        [NullAllowed, Export("subtitle1", ArgumentSemantic.Assign)]
        UIFont Subtitle1 { get; set; }

        // @property (nonatomic) UIFont * _Nullable subtitle2;
        [NullAllowed, Export("subtitle2", ArgumentSemantic.Assign)]
        UIFont Subtitle2 { get; set; }

        // @property (nonatomic) UIFont * _Nullable body1;
        [NullAllowed, Export("body1", ArgumentSemantic.Assign)]
        UIFont Body1 { get; set; }

        // @property (nonatomic) UIFont * _Nullable body2;
        [NullAllowed, Export("body2", ArgumentSemantic.Assign)]
        UIFont Body2 { get; set; }

        // @property (nonatomic) UIFont * _Nullable caption;
        [NullAllowed, Export("caption", ArgumentSemantic.Assign)]
        UIFont Caption { get; set; }

        // @property (nonatomic) UIFont * _Nullable button;
        [NullAllowed, Export("button", ArgumentSemantic.Assign)]
        UIFont Button { get; set; }

        // @property (nonatomic) UIFont * _Nullable overline;
        [NullAllowed, Export("overline", ArgumentSemantic.Assign)]
        UIFont Overline { get; set; }
    }

    // @protocol MDCTypographyScheming <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTypographyScheming
    {
        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull headline1;
        [Abstract]
        [Export("headline1", ArgumentSemantic.Copy)]
        UIFont Headline1 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull headline2;
        [Abstract]
        [Export("headline2", ArgumentSemantic.Copy)]
        UIFont Headline2 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull headline3;
        [Abstract]
        [Export("headline3", ArgumentSemantic.Copy)]
        UIFont Headline3 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull headline4;
        [Abstract]
        [Export("headline4", ArgumentSemantic.Copy)]
        UIFont Headline4 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull headline5;
        [Abstract]
        [Export("headline5", ArgumentSemantic.Copy)]
        UIFont Headline5 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull headline6;
        [Abstract]
        [Export("headline6", ArgumentSemantic.Copy)]
        UIFont Headline6 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull subtitle1;
        [Abstract]
        [Export("subtitle1", ArgumentSemantic.Copy)]
        UIFont Subtitle1 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull subtitle2;
        [Abstract]
        [Export("subtitle2", ArgumentSemantic.Copy)]
        UIFont Subtitle2 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull body1;
        [Abstract]
        [Export("body1", ArgumentSemantic.Copy)]
        UIFont Body1 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull body2;
        [Abstract]
        [Export("body2", ArgumentSemantic.Copy)]
        UIFont Body2 { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull caption;
        [Abstract]
        [Export("caption", ArgumentSemantic.Copy)]
        UIFont Caption { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull button;
        [Abstract]
        [Export("button", ArgumentSemantic.Copy)]
        UIFont Button { get; }

        // @required @property (readonly, copy, nonatomic) UIFont * _Nonnull overline;
        [Abstract]
        [Export("overline", ArgumentSemantic.Copy)]
        UIFont Overline { get; }

        // @required @property (readonly, assign, nonatomic) BOOL useCurrentContentSizeCategoryWhenApplied;
        [Abstract]
        [Export("useCurrentContentSizeCategoryWhenApplied")]
        bool UseCurrentContentSizeCategoryWhenApplied { get; }
    }

    // @interface MDCTypographyScheme : NSObject <MDCTypographyScheming, NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCTypographyScheme : IMDCTypographyScheming, INSCopying
    {
        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull headline1;
        [Export("headline1", ArgumentSemantic.Copy)]
        UIFont Headline1 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull headline2;
        [Export("headline2", ArgumentSemantic.Copy)]
        UIFont Headline2 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull headline3;
        [Export("headline3", ArgumentSemantic.Copy)]
        UIFont Headline3 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull headline4;
        [Export("headline4", ArgumentSemantic.Copy)]
        UIFont Headline4 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull headline5;
        [Export("headline5", ArgumentSemantic.Copy)]
        UIFont Headline5 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull headline6;
        [Export("headline6", ArgumentSemantic.Copy)]
        UIFont Headline6 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull subtitle1;
        [Export("subtitle1", ArgumentSemantic.Copy)]
        UIFont Subtitle1 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull subtitle2;
        [Export("subtitle2", ArgumentSemantic.Copy)]
        UIFont Subtitle2 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull body1;
        [Export("body1", ArgumentSemantic.Copy)]
        UIFont Body1 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull body2;
        [Export("body2", ArgumentSemantic.Copy)]
        UIFont Body2 { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull caption;
        [Export("caption", ArgumentSemantic.Copy)]
        UIFont Caption { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull button;
        [Export("button", ArgumentSemantic.Copy)]
        UIFont Button { get; set; }

        // @property (readwrite, copy, nonatomic) UIFont * _Nonnull overline;
        [Export("overline", ArgumentSemantic.Copy)]
        UIFont Overline { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL useCurrentContentSizeCategoryWhenApplied;
        [Export("useCurrentContentSizeCategoryWhenApplied")]
        bool UseCurrentContentSizeCategoryWhenApplied { get; set; }

        // -(instancetype _Nonnull)initWithDefaults:(MDCTypographySchemeDefaults)defaults;
        [Export("initWithDefaults:")]
        IntPtr Constructor(MDCTypographySchemeDefaults defaults);
    }

    // @protocol MDCContainerScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCContainerScheming
    {
        // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Abstract]
        [Export("colorScheme")]
        MDCColorScheming ColorScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Abstract]
        [Export("typographyScheme")]
        MDCTypographyScheming TypographyScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCShapeScheming> _Nullable shapeScheme;
        [Abstract]
        [NullAllowed, Export("shapeScheme")]
        MDCShapeScheming ShapeScheme { get; }
    }

    // @interface MDCContainerScheme : NSObject <MDCContainerScheming>
    [BaseType(typeof(NSObject))]
    interface MDCContainerScheme : IMDCContainerScheming
    {
        // @property (readwrite, nonatomic) MDCSemanticColorScheme * _Nonnull colorScheme;
        [Export("colorScheme", ArgumentSemantic.Assign)]
        MDCSemanticColorScheme ColorScheme { get; set; }

        // @property (readwrite, nonatomic) MDCTypographyScheme * _Nonnull typographyScheme;
        [Export("typographyScheme", ArgumentSemantic.Assign)]
        MDCTypographyScheme TypographyScheme { get; set; }

        // @property (readwrite, nonatomic) MDCShapeScheme * _Nullable shapeScheme;
        [NullAllowed, Export("shapeScheme", ArgumentSemantic.Assign)]
        MDCShapeScheme ShapeScheme { get; set; }
    }

    // @interface MaterialTheming (MDCActionSheetController)
    [Category]
    [BaseType(typeof(MDCActionSheetController))]
    interface MDCActionSheetController_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCActivityIndicator : UIView
    [BaseType(typeof(UIView))]
    interface MDCActivityIndicator
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCActivityIndicatorDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCActivityIndicatorDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (getter = isAnimating, assign, nonatomic) BOOL animating;
        [Export("animating")]
        bool Animating { [Bind("isAnimating")] get; set; }

        // @property (assign, nonatomic) CGFloat radius __attribute__((annotate("ui_appearance_selector")));
        [Export("radius")]
        nfloat Radius { get; set; }

        // @property (assign, nonatomic) CGFloat strokeWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("strokeWidth")]
        nfloat StrokeWidth { get; set; }

        // @property (assign, nonatomic) BOOL trackEnabled;
        [Export("trackEnabled")]
        bool TrackEnabled { get; set; }

        // @property (assign, nonatomic) MDCActivityIndicatorMode indicatorMode;
        [Export("indicatorMode", ArgumentSemantic.Assign)]
        MDCActivityIndicatorMode IndicatorMode { get; set; }

        // -(void)setIndicatorMode:(MDCActivityIndicatorMode)mode animated:(BOOL)animated;
        [Export("setIndicatorMode:animated:")]
        void SetIndicatorMode(MDCActivityIndicatorMode mode, bool animated);

        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; set; }

        // -(void)setProgress:(float)progress animated:(BOOL)animated;
        [Export("setProgress:animated:")]
        void SetProgress(float progress, bool animated);

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull cycleColors __attribute__((annotate("ui_appearance_selector")));
        [Export("cycleColors", ArgumentSemantic.Copy)]
        UIColor[] CycleColors { get; set; }

        // -(void)startAnimating;
        [Export("startAnimating")]
        void StartAnimating();

        // -(void)startAnimatingWithTransition:(MDCActivityIndicatorTransition * _Nonnull)startTransition cycleStartIndex:(NSInteger)cycleStartIndex;
        [Export("startAnimatingWithTransition:cycleStartIndex:")]
        void StartAnimatingWithTransition(MDCActivityIndicatorTransition startTransition, nint cycleStartIndex);

        // -(void)stopAnimating;
        [Export("stopAnimating")]
        void StopAnimating();

        // -(void)stopAnimatingWithTransition:(MDCActivityIndicatorTransition * _Nonnull)stopTransition;
        [Export("stopAnimatingWithTransition:")]
        void StopAnimatingWithTransition(MDCActivityIndicatorTransition stopTransition);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCActivityIndicator * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCActivityIndicator, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCActivityIndicatorDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCActivityIndicatorDelegate
    {
        // @optional -(void)activityIndicatorAnimationDidFinish:(MDCActivityIndicator * _Nonnull)activityIndicator;
        [Export("activityIndicatorAnimationDidFinish:")]
        void ActivityIndicatorAnimationDidFinish(MDCActivityIndicator activityIndicator);

        // @optional -(void)activityIndicatorModeTransitionDidFinish:(MDCActivityIndicator * _Nonnull)activityIndicator;
        [Export("activityIndicatorModeTransitionDidFinish:")]
        void ActivityIndicatorModeTransitionDidFinish(MDCActivityIndicator activityIndicator);
    }

    // typedef void (^MDCActivityIndicatorAnimation)(CGFloat, CGFloat);
    delegate void MDCActivityIndicatorAnimation(nfloat arg0, nfloat arg1);

    // @interface MDCActivityIndicatorTransition : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCActivityIndicatorTransition
    {
        // @property (copy, nonatomic) MDCActivityIndicatorAnimation _Nonnull animation;
        [Export("animation", ArgumentSemantic.Copy)]
        MDCActivityIndicatorAnimation Animation { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) completion;
        [NullAllowed, Export("completion", ArgumentSemantic.Copy)]
        Action Completion { get; set; }

        // @property (assign, nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; set; }

        // -(instancetype _Nonnull)initWithAnimation:(MDCActivityIndicatorAnimation _Nonnull)animation __attribute__((objc_designated_initializer));
        [Export("initWithAnimation:")]
        [DesignatedInitializer]
        IntPtr Constructor(MDCActivityIndicatorAnimation animation);
    }

    // @interface ActivityIndicatorColorThemer : NSObject
    [BaseType(typeof(NSObject), Name = "MDCActivityIndicatorColorThemer")]
    interface ActivityIndicatorColorThemer
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toActivityIndicator:(MDCActivityIndicator * _Nonnull)activityIndicator __attribute__((deprecated("Please theme MDCActivityIndicator's colors directly instead.")));
        [Static]
        [Export("applySemanticColorScheme:toActivityIndicator:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCActivityIndicator activityIndicator);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toActivityIndicator:(MDCActivityIndicator * _Nonnull)activityIndicator __attribute__((deprecated("Please theme MDCActivityIndicator's colors directly instead.")));
        [Static]
        [Export("applyColorScheme:toActivityIndicator:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCActivityIndicator activityIndicator);
    }

    // @interface MDCAnimationTiming (CAMediaTimingFunction)
    [Category]
    [BaseType(typeof(CAMediaTimingFunction))]
    interface CAMediaTimingFunction_MDCAnimationTiming
    {
        // +(CAMediaTimingFunction * _Nullable)mdc_functionWithType:(MDCAnimationTimingFunction)type;
        [Static]
        [Export("mdc_functionWithType:")]
        [return: NullAllowed]
        CAMediaTimingFunction Mdc_functionWithType(MDCAnimationTimingFunction type);
    }

    // @interface MDCTimingFunction (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_MDCTimingFunction
    {
        // +(void)mdc_animateWithTimingFunction:(CAMediaTimingFunction * _Nullable)timingFunction duration:(NSTimeInterval)duration delay:(NSTimeInterval)delay options:(UIViewAnimationOptions)options animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
        [Static]
        [Export("mdc_animateWithTimingFunction:duration:delay:options:animations:completion:")]
        void Mdc_animateWithTimingFunction([NullAllowed] CAMediaTimingFunction timingFunction, double duration, double delay, UIViewAnimationOptions options, Action animations, [NullAllowed] Action<bool> completion);
    }

    // @interface MDCAppBarContainerViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    [DisableDefaultCtor]
    interface MDCAppBarContainerViewController
    {
        // -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController __attribute__((objc_designated_initializer));
        [Export("initWithContentViewController:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIViewController contentViewController);

        // @property (readonly, nonatomic, strong) MDCAppBarViewController * _Nonnull appBarViewController;
        [Export("appBarViewController", ArgumentSemantic.Strong)]
        MDCAppBarViewController AppBarViewController { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Nonnull contentViewController;
        [Export("contentViewController", ArgumentSemantic.Strong)]
        UIViewController ContentViewController { get; }

        // @property (getter = isTopLayoutGuideAdjustmentEnabled, nonatomic) BOOL topLayoutGuideAdjustmentEnabled;
        [Export("topLayoutGuideAdjustmentEnabled")]
        bool TopLayoutGuideAdjustmentEnabled { [Bind("isTopLayoutGuideAdjustmentEnabled")] get; set; }

        // @property (readonly, nonatomic, strong) MDCAppBar * _Nonnull appBar;
        [Export("appBar", ArgumentSemantic.Strong)]
        MDCAppBar AppBar { get; }
    }

    // @protocol MDCAppBarNavigationControllerDelegate <UINavigationControllerDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCAppBarNavigationControllerDelegate : IUINavigationControllerDelegate
    {
        // @optional -(void)appBarNavigationController:(MDCAppBarNavigationController * _Nonnull)navigationController willAddAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController asChildOfViewController:(UIViewController * _Nonnull)viewController;
        [Export("appBarNavigationController:willAddAppBarViewController:asChildOfViewController:")]
        void AppBarNavigationController(MDCAppBarNavigationController navigationController, MDCAppBarViewController appBarViewController, UIViewController viewController);

        // @optional -(UIScrollView * _Nullable)appBarNavigationController:(MDCAppBarNavigationController * _Nonnull)navigationController trackingScrollViewForViewController:(UIViewController * _Nonnull)viewController suggestedTrackingScrollView:(UIScrollView * _Nullable)scrollView;
        [Export("appBarNavigationController:trackingScrollViewForViewController:suggestedTrackingScrollView:")]
        [return: NullAllowed]
        UIScrollView AppBarNavigationController(MDCAppBarNavigationController navigationController, UIViewController viewController, [NullAllowed] UIScrollView scrollView);

        // @optional -(void)appBarNavigationController:(MDCAppBarNavigationController * _Nonnull)navigationController willAddAppBar:(MDCAppBar * _Nonnull)appBar asChildOfViewController:(UIViewController * _Nonnull)viewController;
        [Export("appBarNavigationController:willAddAppBar:asChildOfViewController:")]
        void AppBarNavigationController(MDCAppBarNavigationController navigationController, MDCAppBar appBar, UIViewController viewController);
    }

    // @interface MDCAppBarNavigationController : UINavigationController
    [BaseType(typeof(UINavigationController))]
    interface MDCAppBarNavigationController
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCAppBarNavigationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCAppBarNavigationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(MDCAppBarViewController * _Nullable)appBarViewControllerForViewController:(UIViewController * _Nonnull)viewController;
        [Export("appBarViewControllerForViewController:")]
        [return: NullAllowed]
        MDCAppBarViewController AppBarViewControllerForViewController(UIViewController viewController);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCFlexibleHeaderViewController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlockForAppBarController;
        [NullAllowed, Export("traitCollectionDidChangeBlockForAppBarController", ArgumentSemantic.Copy)]
        Action<MDCFlexibleHeaderViewController, UITraitCollection> TraitCollectionDidChangeBlockForAppBarController { get; set; }
    }

    // @interface ToBeDeprecated (MDCAppBarNavigationController)
    [Category]
    [BaseType(typeof(MDCAppBarNavigationController))]
    interface MDCAppBarNavigationController_ToBeDeprecated
    {
        // -(MDCAppBar * _Nullable)appBarForViewController:(UIViewController * _Nonnull)viewController;
        [Export("appBarForViewController:")]
        [return: NullAllowed]
        MDCAppBar AppBarForViewController(UIViewController viewController);
    }

    // @interface MDCFlexibleHeaderContainerViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface MDCFlexibleHeaderContainerViewController
    {
        // -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nullable)contentViewController __attribute__((objc_designated_initializer));
        [Export("initWithContentViewController:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] UIViewController contentViewController);

        // @property (readonly, nonatomic, strong) MDCFlexibleHeaderViewController * _Nonnull headerViewController;
        [Export("headerViewController", ArgumentSemantic.Strong)]
        MDCFlexibleHeaderViewController HeaderViewController { get; }

        // @property (nonatomic, strong) UIViewController * _Nullable contentViewController;
        [NullAllowed, Export("contentViewController", ArgumentSemantic.Strong)]
        UIViewController ContentViewController { get; set; }

        // @property (getter = isTopLayoutGuideAdjustmentEnabled, nonatomic) BOOL topLayoutGuideAdjustmentEnabled;
        [Export("topLayoutGuideAdjustmentEnabled")]
        bool TopLayoutGuideAdjustmentEnabled { [Bind("isTopLayoutGuideAdjustmentEnabled")] get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCFlexibleHeaderContainerViewController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCFlexibleHeaderContainerViewController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // typedef void (^MDCFlexibleHeaderChangeContentInsetsBlock)();
    delegate void MDCFlexibleHeaderChangeContentInsetsBlock();

    // typedef void (^MDCFlexibleHeaderShadowIntensityChangeBlock)(__kindof CALayer * _Nonnull, CGFloat);
    delegate void MDCFlexibleHeaderShadowIntensityChangeBlock(CALayer arg0, nfloat arg1);

    // @interface MDCFlexibleHeaderView : UIView <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCFlexibleHeaderView : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (nonatomic, strong) __kindof CALayer * _Nullable shadowLayer;
        [Export("shadowLayer", ArgumentSemantic.Strong)]
        CALayer ShadowLayer { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull shadowColor;
        [Export("shadowColor", ArgumentSemantic.Copy)]
        UIColor ShadowColor { get; set; }

        // -(void)setShadowLayer:(__kindof CALayer * _Nonnull)shadowLayer intensityDidChangeBlock:(MDCFlexibleHeaderShadowIntensityChangeBlock _Nonnull)block;
        [Export("setShadowLayer:intensityDidChangeBlock:")]
        void SetShadowLayer(CALayer shadowLayer, MDCFlexibleHeaderShadowIntensityChangeBlock block);

        // -(void)trackingScrollViewDidScroll;
        [Export("trackingScrollViewDidScroll")]
        void TrackingScrollViewDidScroll();

        // -(void)trackingScrollViewDidChangeAdjustedContentInset:(UIScrollView * _Nullable)trackingScrollView __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0)));
        [TV(11, 0), iOS(11, 0)]
        [Export("trackingScrollViewDidChangeAdjustedContentInset:")]
        void TrackingScrollViewDidChangeAdjustedContentInset([NullAllowed] UIScrollView trackingScrollView);

        // -(void)trackingScrollWillChangeToScrollView:(UIScrollView * _Nullable)scrollView;
        [Export("trackingScrollWillChangeToScrollView:")]
        void TrackingScrollWillChangeToScrollView([NullAllowed] UIScrollView scrollView);

        // @property (readonly, nonatomic) BOOL prefersStatusBarHidden;
        [Export("prefersStatusBarHidden")]
        bool PrefersStatusBarHidden { get; }

        // -(void)interfaceOrientationWillChange;
        [Export("interfaceOrientationWillChange")]
        void InterfaceOrientationWillChange();

        // -(void)interfaceOrientationIsChanging;
        [Export("interfaceOrientationIsChanging")]
        void InterfaceOrientationIsChanging();

        // -(void)interfaceOrientationDidChange;
        [Export("interfaceOrientationDidChange")]
        void InterfaceOrientationDidChange();

        // -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
        [Export("viewWillTransitionToSize:withTransitionCoordinator:")]
        void ViewWillTransitionToSize(CGSize size, UIViewControllerTransitionCoordinator coordinator);

        // -(void)changeContentInsets:(MDCFlexibleHeaderChangeContentInsetsBlock _Nonnull)block;
        [Export("changeContentInsets:")]
        void ChangeContentInsets(MDCFlexibleHeaderChangeContentInsetsBlock block);

        // -(void)forwardTouchEventsForView:(UIView * _Nonnull)view;
        [Export("forwardTouchEventsForView:")]
        void ForwardTouchEventsForView(UIView view);

        // -(void)stopForwardingTouchEventsForView:(UIView * _Nonnull)view;
        [Export("stopForwardingTouchEventsForView:")]
        void StopForwardingTouchEventsForView(UIView view);

        // @property (readonly, nonatomic) MDCFlexibleHeaderScrollPhase scrollPhase;
        [Export("scrollPhase")]
        MDCFlexibleHeaderScrollPhase ScrollPhase { get; }

        // @property (readonly, nonatomic) CGFloat scrollPhaseValue;
        [Export("scrollPhaseValue")]
        nfloat ScrollPhaseValue { get; }

        // @property (readonly, nonatomic) CGFloat scrollPhasePercentage;
        [Export("scrollPhasePercentage")]
        nfloat ScrollPhasePercentage { get; }

        // @property (nonatomic) CGFloat minimumHeight;
        [Export("minimumHeight")]
        nfloat MinimumHeight { get; set; }

        // @property (nonatomic) CGFloat maximumHeight;
        [Export("maximumHeight")]
        nfloat MaximumHeight { get; set; }

        // @property (nonatomic) BOOL minMaxHeightIncludesSafeArea;
        [Export("minMaxHeightIncludesSafeArea")]
        bool MinMaxHeightIncludesSafeArea { get; set; }

        // @property (readonly, nonatomic) id _Nonnull topSafeAreaGuide;
        [Export("topSafeAreaGuide")]
        NSObject TopSafeAreaGuide { get; }

        // @property (nonatomic) BOOL canOverExtend;
        [Export("canOverExtend")]
        bool CanOverExtend { get; set; }

        // @property (nonatomic) float visibleShadowOpacity;
        [Export("visibleShadowOpacity")]
        float VisibleShadowOpacity { get; set; }

        // @property (nonatomic) BOOL resetShadowAfterTrackingScrollViewIsReset;
        [Export("resetShadowAfterTrackingScrollViewIsReset")]
        bool ResetShadowAfterTrackingScrollViewIsReset { get; set; }

        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }

        // @property (nonatomic) BOOL observesTrackingScrollViewScrollEvents;
        [Export("observesTrackingScrollViewScrollEvents")]
        bool ObservesTrackingScrollViewScrollEvents { get; set; }

        // @property (getter = isInFrontOfInfiniteContent, nonatomic) BOOL inFrontOfInfiniteContent;
        [Export("inFrontOfInfiniteContent")]
        bool InFrontOfInfiniteContent { [Bind("isInFrontOfInfiniteContent")] get; set; }

        // @property (nonatomic) BOOL sharedWithManyScrollViews;
        [Export("sharedWithManyScrollViews")]
        bool SharedWithManyScrollViews { get; set; }

        // @property (nonatomic) BOOL disableContentInsetAdjustmentWhenContentInsetAdjustmentBehaviorIsNever __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0)));
        [TV(11, 0), iOS(11, 0)]
        [Export("disableContentInsetAdjustmentWhenContentInsetAdjustmentBehaviorIsNever")]
        bool DisableContentInsetAdjustmentWhenContentInsetAdjustmentBehaviorIsNever { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCFlexibleHeaderViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCFlexibleHeaderViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCFlexibleHeaderView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCFlexibleHeaderView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }
    }

    // @protocol MDCFlexibleHeaderViewDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCFlexibleHeaderViewDelegate
    {
        // @required -(void)flexibleHeaderViewNeedsStatusBarAppearanceUpdate:(MDCFlexibleHeaderView * _Nonnull)headerView;
        [Abstract]
        [Export("flexibleHeaderViewNeedsStatusBarAppearanceUpdate:")]
        void FlexibleHeaderViewNeedsStatusBarAppearanceUpdate(MDCFlexibleHeaderView headerView);

        // @required -(void)flexibleHeaderViewFrameDidChange:(MDCFlexibleHeaderView * _Nonnull)headerView;
        [Abstract]
        [Export("flexibleHeaderViewFrameDidChange:")]
        void FlexibleHeaderViewFrameDidChange(MDCFlexibleHeaderView headerView);
    }

    // @interface  (MDCFlexibleHeaderView)
    [Category]
    [BaseType(typeof(MDCFlexibleHeaderView))]
    interface MDCFlexibleHeaderView_
    {
        // @property (nonatomic, strong) UIView * _Nonnull contentView __attribute__((deprecated("Please register views directly to the flexible header.")));
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }
    }

    // @interface  (MDCFlexibleHeaderView)
    [Category]
    [BaseType(typeof(MDCFlexibleHeaderView))]
    interface MDCFlexibleHeaderView_
    {
        // @property (nonatomic) MDCFlexibleHeaderShiftBehavior shiftBehavior;
        [Export("shiftBehavior", ArgumentSemantic.Assign)]
        MDCFlexibleHeaderShiftBehavior ShiftBehavior { get; set; }

        // @property (nonatomic) MDCFlexibleHeaderContentImportance headerContentImportance;
        [Export("headerContentImportance", ArgumentSemantic.Assign)]
        MDCFlexibleHeaderContentImportance HeaderContentImportance { get; set; }

        // @property (nonatomic) BOOL trackingScrollViewIsBeingScrubbed;
        [Export("trackingScrollViewIsBeingScrubbed")]
        bool TrackingScrollViewIsBeingScrubbed { get; set; }

        // @property (nonatomic) BOOL contentIsTranslucent;
        [Export("contentIsTranslucent")]
        bool ContentIsTranslucent { get; set; }

        // @property (nonatomic) BOOL statusBarHintCanOverlapHeader;
        [Export("statusBarHintCanOverlapHeader")]
        bool StatusBarHintCanOverlapHeader { get; set; }

        // -(void)hideViewWhenShifted:(UIView * _Nonnull)view;
        [Export("hideViewWhenShifted:")]
        void HideViewWhenShifted(UIView view);

        // -(void)stopHidingViewWhenShifted:(UIView * _Nonnull)view;
        [Export("stopHidingViewWhenShifted:")]
        void StopHidingViewWhenShifted(UIView view);

        // -(void)shiftHeaderOnScreenAnimated:(BOOL)animated;
        [Export("shiftHeaderOnScreenAnimated:")]
        void ShiftHeaderOnScreenAnimated(bool animated);

        // -(void)shiftHeaderOffScreenAnimated:(BOOL)animated;
        [Export("shiftHeaderOffScreenAnimated:")]
        void ShiftHeaderOffScreenAnimated(bool animated);

        // -(void)trackingScrollViewDidEndDraggingWillDecelerate:(BOOL)willDecelerate;
        [Export("trackingScrollViewDidEndDraggingWillDecelerate:")]
        void TrackingScrollViewDidEndDraggingWillDecelerate(bool willDecelerate);

        // -(void)trackingScrollViewDidEndDecelerating;
        [Export("trackingScrollViewDidEndDecelerating")]
        void TrackingScrollViewDidEndDecelerating();

        // -(BOOL)trackingScrollViewWillEndDraggingWithVelocity:(CGPoint)velocity targetContentOffset:(CGPoint * _Nonnull)targetContentOffset;
        [Export("trackingScrollViewWillEndDraggingWithVelocity:targetContentOffset:")]
        unsafe bool TrackingScrollViewWillEndDraggingWithVelocity(CGPoint velocity, CGPoint* targetContentOffset);
    }

    // @interface MDCFlexibleHeaderViewController : UIViewController <UIScrollViewDelegate, UITableViewDelegate>
    [BaseType(typeof(UIViewController))]
    interface MDCFlexibleHeaderViewController : IUIScrollViewDelegate, IUITableViewDelegate
    {
        // @property (readonly, nonatomic, strong) MDCFlexibleHeaderView * _Nonnull headerView;
        [Export("headerView", ArgumentSemantic.Strong)]
        MDCFlexibleHeaderView HeaderView { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCFlexibleHeaderViewController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCFlexibleHeaderViewController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        [Wrap("WeakLayoutDelegate")]
        [NullAllowed]
        MDCFlexibleHeaderViewLayoutDelegate LayoutDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCFlexibleHeaderViewLayoutDelegate> _Nullable layoutDelegate;
        [NullAllowed, Export("layoutDelegate", ArgumentSemantic.Weak)]
        NSObject WeakLayoutDelegate { get; set; }

        [Wrap("WeakSafeAreaDelegate")]
        [NullAllowed]
        MDCFlexibleHeaderSafeAreaDelegate SafeAreaDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCFlexibleHeaderSafeAreaDelegate> _Nullable safeAreaDelegate;
        [NullAllowed, Export("safeAreaDelegate", ArgumentSemantic.Weak)]
        NSObject WeakSafeAreaDelegate { get; set; }

        // @property (getter = isTopLayoutGuideAdjustmentEnabled, nonatomic) BOOL topLayoutGuideAdjustmentEnabled;
        [Export("topLayoutGuideAdjustmentEnabled")]
        bool TopLayoutGuideAdjustmentEnabled { [Bind("isTopLayoutGuideAdjustmentEnabled")] get; set; }

        // @property (nonatomic, weak) UIViewController * _Nullable topLayoutGuideViewController;
        [NullAllowed, Export("topLayoutGuideViewController", ArgumentSemantic.Weak)]
        UIViewController TopLayoutGuideViewController { get; set; }

        // @property (nonatomic) BOOL inferTopSafeAreaInsetFromViewController;
        [Export("inferTopSafeAreaInsetFromViewController")]
        bool InferTopSafeAreaInsetFromViewController { get; set; }

        // @property (nonatomic) BOOL useAdditionalSafeAreaInsetsForWebKitScrollViews;
        [Export("useAdditionalSafeAreaInsetsForWebKitScrollViews")]
        bool UseAdditionalSafeAreaInsetsForWebKitScrollViews { get; set; }

        // -(BOOL)prefersStatusBarHidden;
        [Export("prefersStatusBarHidden")]
        [Verify(MethodToProperty)]
        bool PrefersStatusBarHidden { get; }

        // @property (nonatomic) UIStatusBarStyle preferredStatusBarStyle;
        [Export("preferredStatusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle PreferredStatusBarStyle { get; set; }

        // @property (nonatomic) BOOL inferPreferredStatusBarStyle;
        [Export("inferPreferredStatusBarStyle")]
        bool InferPreferredStatusBarStyle { get; set; }
    }

    // @protocol MDCFlexibleHeaderSafeAreaDelegate
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCFlexibleHeaderSafeAreaDelegate
    {
        // @required -(UIViewController * _Nullable)flexibleHeaderViewControllerTopSafeAreaInsetViewController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderViewController;
        [Abstract]
        [Export("flexibleHeaderViewControllerTopSafeAreaInsetViewController:")]
        [return: NullAllowed]
        UIViewController FlexibleHeaderViewControllerTopSafeAreaInsetViewController(MDCFlexibleHeaderViewController flexibleHeaderViewController);
    }

    // @protocol MDCFlexibleHeaderViewLayoutDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCFlexibleHeaderViewLayoutDelegate
    {
        // @required -(void)flexibleHeaderViewController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderViewController flexibleHeaderViewFrameDidChange:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
        [Abstract]
        [Export("flexibleHeaderViewController:flexibleHeaderViewFrameDidChange:")]
        void FlexibleHeaderViewFrameDidChange(MDCFlexibleHeaderViewController flexibleHeaderViewController, MDCFlexibleHeaderView flexibleHeaderView);
    }

    // @interface ToBeDeprecated (MDCFlexibleHeaderViewController)
    [Category]
    [BaseType(typeof(MDCFlexibleHeaderViewController))]
    interface MDCFlexibleHeaderViewController_ToBeDeprecated
    {
        // -(void)updateTopLayoutGuide;
        [Export("updateTopLayoutGuide")]
        void UpdateTopLayoutGuide();
    }

    // @interface MDCHeaderStackView : UIView
    [BaseType(typeof(UIView))]
    interface MDCHeaderStackView
    {
        // @property (nonatomic, strong) UIView * _Nullable topBar;
        [NullAllowed, Export("topBar", ArgumentSemantic.Strong)]
        UIView TopBar { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable bottomBar;
        [NullAllowed, Export("bottomBar", ArgumentSemantic.Strong)]
        UIView BottomBar { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCHeaderStackView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCHeaderStackView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCUINavigationItemObservables <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCUINavigationItemObservables
    {
        // @required @property (copy, nonatomic) NSString * _Nullable title;
        [Abstract]
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @required @property (nonatomic, strong) UIView * _Nullable titleView;
        [Abstract]
        [NullAllowed, Export("titleView", ArgumentSemantic.Strong)]
        UIView TitleView { get; set; }

        // @required @property (nonatomic) BOOL hidesBackButton;
        [Abstract]
        [Export("hidesBackButton")]
        bool HidesBackButton { get; set; }

        // @required @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leftBarButtonItems;
        [Abstract]
        [NullAllowed, Export("leftBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] LeftBarButtonItems { get; set; }

        // @required @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable rightBarButtonItems;
        [Abstract]
        [NullAllowed, Export("rightBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] RightBarButtonItems { get; set; }

        // @required @property (nonatomic) BOOL leftItemsSupplementBackButton;
        [Abstract]
        [Export("leftItemsSupplementBackButton")]
        bool LeftItemsSupplementBackButton { get; set; }

        // @required @property (nonatomic, strong) UIBarButtonItem * _Nullable leftBarButtonItem;
        [Abstract]
        [NullAllowed, Export("leftBarButtonItem", ArgumentSemantic.Strong)]
        UIBarButtonItem LeftBarButtonItem { get; set; }

        // @required @property (nonatomic, strong) UIBarButtonItem * _Nullable rightBarButtonItem;
        [Abstract]
        [NullAllowed, Export("rightBarButtonItem", ArgumentSemantic.Strong)]
        UIBarButtonItem RightBarButtonItem { get; set; }
    }

    // @interface MDCNavigationBarTextColorAccessibilityMutator : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCNavigationBarTextColorAccessibilityMutator
    {
        // -(void)mutate:(MDCNavigationBar * _Nonnull)navBar;
        [Export("mutate:")]
        void Mutate(MDCNavigationBar navBar);
    }

    // @interface MDCNavigationBar : UIView <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCNavigationBar : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable titleView;
        [NullAllowed, Export("titleView", ArgumentSemantic.Strong)]
        UIView TitleView { get; set; }

        // @property (nonatomic) MDCNavigationBarTitleViewLayoutBehavior titleViewLayoutBehavior;
        [Export("titleViewLayoutBehavior", ArgumentSemantic.Assign)]
        MDCNavigationBarTitleViewLayoutBehavior TitleViewLayoutBehavior { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets titleInsets;
        [Export("titleInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TitleInsets { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic) BOOL allowAnyTitleFontSize;
        [Export("allowAnyTitleFontSize")]
        bool AllowAnyTitleFontSize { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleTextColor;
        [NullAllowed, Export("titleTextColor", ArgumentSemantic.Strong)]
        UIColor TitleTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rippleColor;
        [NullAllowed, Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic) BOOL uppercasesButtonTitles;
        [Export("uppercasesButtonTitles")]
        bool UppercasesButtonTitles { get; set; }

        // -(void)setButtonsTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state;
        [Export("setButtonsTitleFont:forState:")]
        void SetButtonsTitleFont([NullAllowed] UIFont font, UIControlState state);

        // -(UIFont * _Nullable)buttonsTitleFontForState:(UIControlState)state;
        [Export("buttonsTitleFontForState:")]
        [return: NullAllowed]
        UIFont ButtonsTitleFontForState(UIControlState state);

        // -(void)setButtonsTitleColor:(UIColor * _Nullable)color forState:(UIControlState)state;
        [Export("setButtonsTitleColor:forState:")]
        void SetButtonsTitleColor([NullAllowed] UIColor color, UIControlState state);

        // @property (nonatomic, strong) UIColor * _Nullable leadingBarItemsTintColor;
        [NullAllowed, Export("leadingBarItemsTintColor", ArgumentSemantic.Strong)]
        UIColor LeadingBarItemsTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable trailingBarItemsTintColor;
        [NullAllowed, Export("trailingBarItemsTintColor", ArgumentSemantic.Strong)]
        UIColor TrailingBarItemsTintColor { get; set; }

        // -(UIColor * _Nullable)buttonsTitleColorForState:(UIControlState)state;
        [Export("buttonsTitleColorForState:")]
        [return: NullAllowed]
        UIColor ButtonsTitleColorForState(UIControlState state);

        // @property (nonatomic, strong) UIBarButtonItem * _Nullable backItem;
        [NullAllowed, Export("backItem", ArgumentSemantic.Strong)]
        UIBarButtonItem BackItem { get; set; }

        // @property (nonatomic) BOOL hidesBackButton;
        [Export("hidesBackButton")]
        bool HidesBackButton { get; set; }

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leadingBarButtonItems;
        [NullAllowed, Export("leadingBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] LeadingBarButtonItems { get; set; }

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable trailingBarButtonItems;
        [NullAllowed, Export("trailingBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] TrailingBarButtonItems { get; set; }

        // @property (nonatomic) BOOL leadingItemsSupplementBackButton;
        [Export("leadingItemsSupplementBackButton")]
        bool LeadingItemsSupplementBackButton { get; set; }

        // @property (nonatomic, strong) UIBarButtonItem * _Nullable leadingBarButtonItem;
        [NullAllowed, Export("leadingBarButtonItem", ArgumentSemantic.Strong)]
        UIBarButtonItem LeadingBarButtonItem { get; set; }

        // @property (nonatomic, strong) UIBarButtonItem * _Nullable trailingBarButtonItem;
        [NullAllowed, Export("trailingBarButtonItem", ArgumentSemantic.Strong)]
        UIBarButtonItem TrailingBarButtonItem { get; set; }

        // -(CGRect)rectForLeadingBarButtonItem:(UIBarButtonItem * _Nonnull)item inCoordinateSpace:(id<UICoordinateSpace> _Nonnull)coordinateSpace __attribute__((swift_name("rect(forLeading:in:)")));
        [Export("rectForLeadingBarButtonItem:inCoordinateSpace:")]
        CGRect RectForLeadingBarButtonItem(UIBarButtonItem item, UICoordinateSpace coordinateSpace);

        // -(CGRect)rectForTrailingBarButtonItem:(UIBarButtonItem * _Nonnull)item inCoordinateSpace:(id<UICoordinateSpace> _Nonnull)coordinateSpace __attribute__((swift_name("rect(forTrailing:in:)")));
        [Export("rectForTrailingBarButtonItem:inCoordinateSpace:")]
        CGRect RectForTrailingBarButtonItem(UIBarButtonItem item, UICoordinateSpace coordinateSpace);

        // @property (nonatomic) MDCNavigationBarTitleAlignment titleAlignment;
        [Export("titleAlignment", ArgumentSemantic.Assign)]
        MDCNavigationBarTitleAlignment TitleAlignment { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCNavigationBar * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCNavigationBar, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(void)observeNavigationItem:(UINavigationItem * _Nonnull)navigationItem;
        [Export("observeNavigationItem:")]
        void ObserveNavigationItem(UINavigationItem navigationItem);

        // -(void)unobserveNavigationItem;
        [Export("unobserveNavigationItem")]
        void UnobserveNavigationItem();

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leftBarButtonItems;
        [NullAllowed, Export("leftBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] LeftBarButtonItems { get; set; }

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable rightBarButtonItems;
        [NullAllowed, Export("rightBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] RightBarButtonItems { get; set; }

        // @property (nonatomic, strong) UIBarButtonItem * _Nullable leftBarButtonItem;
        [NullAllowed, Export("leftBarButtonItem", ArgumentSemantic.Strong)]
        UIBarButtonItem LeftBarButtonItem { get; set; }

        // @property (nonatomic, strong) UIBarButtonItem * _Nullable rightBarButtonItem;
        [NullAllowed, Export("rightBarButtonItem", ArgumentSemantic.Strong)]
        UIBarButtonItem RightBarButtonItem { get; set; }

        // @property (nonatomic) BOOL leftItemsSupplementBackButton;
        [Export("leftItemsSupplementBackButton")]
        bool LeftItemsSupplementBackButton { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable titleTextAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleTextAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> TitleTextAttributes { get; set; }
    }

    // @interface ToBeDeprecated (MDCNavigationBar)
    [Category]
    [BaseType(typeof(MDCNavigationBar))]
    interface MDCNavigationBar_ToBeDeprecated
    {
        // @property (nonatomic, strong) UIColor * _Nullable inkColor;
        [NullAllowed, Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }
    }

    // @interface MDCAppBarViewController : MDCFlexibleHeaderViewController
    [BaseType(typeof(MDCFlexibleHeaderViewController))]
    interface MDCAppBarViewController
    {
        // @property (nonatomic, strong) MDCNavigationBar * _Nonnull navigationBar;
        [Export("navigationBar", ArgumentSemantic.Strong)]
        MDCNavigationBar NavigationBar { get; set; }

        // @property (nonatomic, strong) MDCHeaderStackView * _Nonnull headerStackView;
        [Export("headerStackView", ArgumentSemantic.Strong)]
        MDCHeaderStackView HeaderStackView { get; set; }
    }

    // @interface MDCAppBar : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCAppBar
    {
        // -(void)addSubviewsToParent;
        [Export("addSubviewsToParent")]
        void AddSubviewsToParent();

        // @property (readonly, nonatomic, strong) MDCFlexibleHeaderViewController * _Nonnull headerViewController;
        [Export("headerViewController", ArgumentSemantic.Strong)]
        MDCFlexibleHeaderViewController HeaderViewController { get; }

        // @property (readonly, nonatomic, strong) MDCAppBarViewController * _Nonnull appBarViewController;
        [Export("appBarViewController", ArgumentSemantic.Strong)]
        MDCAppBarViewController AppBarViewController { get; }

        // @property (readonly, nonatomic, strong) MDCNavigationBar * _Nonnull navigationBar;
        [Export("navigationBar", ArgumentSemantic.Strong)]
        MDCNavigationBar NavigationBar { get; }

        // @property (readonly, nonatomic, strong) MDCHeaderStackView * _Nonnull headerStackView;
        [Export("headerStackView", ArgumentSemantic.Strong)]
        MDCHeaderStackView HeaderStackView { get; }

        // @property (nonatomic) BOOL inferTopSafeAreaInsetFromViewController;
        [Export("inferTopSafeAreaInsetFromViewController")]
        bool InferTopSafeAreaInsetFromViewController { get; set; }
    }

    // @interface MDCAppBarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCAppBarColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCAppBarColorThemer)
    [Category]
    [BaseType(typeof(MDCAppBarColorThemer))]
    interface MDCAppBarColorThemer_ToBeDeprecated
    {
        // +(void)applyColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
        [Static]
        [Export("applyColorScheme:toAppBarViewController:")]
        void ApplyColorScheme(MDCColorScheming colorScheme, MDCAppBarViewController appBarViewController);

        // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
        [Static]
        [Export("applySurfaceVariantWithColorScheme:toAppBarViewController:")]
        void ApplySurfaceVariantWithColorScheme(MDCColorScheming colorScheme, MDCAppBarViewController appBarViewController);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
        [Static]
        [Export("applyColorScheme:toAppBar:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCAppBar appBar);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
        [Static]
        [Export("applySemanticColorScheme:toAppBar:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCAppBar appBar);

        // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
        [Static]
        [Export("applySurfaceVariantWithColorScheme:toAppBar:")]
        void ApplySurfaceVariantWithColorScheme(MDCColorScheming colorScheme, MDCAppBar appBar);
    }

    // @interface MaterialTheming (MDCAppBarViewController)
    [Category]
    [BaseType(typeof(MDCAppBarViewController))]
    interface MDCAppBarViewController_MaterialTheming
    {
        // -(void)applyPrimaryThemeWithScheme:(id<MDCContainerScheming>)containerScheme;
        [Export("applyPrimaryThemeWithScheme:")]
        void ApplyPrimaryThemeWithScheme(MDCContainerScheming containerScheme);

        // -(void)applySurfaceThemeWithScheme:(id<MDCContainerScheming>)containerScheme;
        [Export("applySurfaceThemeWithScheme:")]
        void ApplySurfaceThemeWithScheme(MDCContainerScheming containerScheme);
    }

    // @interface MDCAppBarTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCAppBarTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCAppBarTypographyThemer)
    [Category]
    [BaseType(typeof(MDCAppBarTypographyThemer))]
    interface MDCAppBarTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
        [Static]
        [Export("applyTypographyScheme:toAppBarViewController:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCAppBarViewController appBarViewController);

        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
        [Static]
        [Export("applyTypographyScheme:toAppBar:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCAppBar appBar);
    }

    // @interface MDCInkGestureRecognizer : UIGestureRecognizer
    [BaseType(typeof(UIGestureRecognizer))]
    interface MDCInkGestureRecognizer
    {
        // @property (assign, nonatomic) CGFloat dragCancelDistance;
        [Export("dragCancelDistance")]
        nfloat DragCancelDistance { get; set; }

        // @property (assign, nonatomic) BOOL cancelOnDragOut;
        [Export("cancelOnDragOut")]
        bool CancelOnDragOut { get; set; }

        // @property (nonatomic) CGRect targetBounds;
        [Export("targetBounds", ArgumentSemantic.Assign)]
        CGRect TargetBounds { get; set; }

        // -(CGPoint)touchStartLocationInView:(UIView *)view;
        [Export("touchStartLocationInView:")]
        CGPoint TouchStartLocationInView(UIView view);

        // -(BOOL)isTouchWithinTargetBounds;
        [Export("isTouchWithinTargetBounds")]
        [Verify(MethodToProperty)]
        bool IsTouchWithinTargetBounds { get; }
    }

    // @interface MDCInkTouchController : NSObject <UIGestureRecognizerDelegate>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCInkTouchController : IUIGestureRecognizerDelegate
    {
        // @property (readonly, nonatomic, weak) UIView * _Nullable view;
        [NullAllowed, Export("view", ArgumentSemantic.Weak)]
        UIView View { get; }

        // @property (readonly, nonatomic, strong) MDCInkView * _Nonnull defaultInkView;
        [Export("defaultInkView", ArgumentSemantic.Strong)]
        MDCInkView DefaultInkView { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCInkTouchControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCInkTouchControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL delaysInkSpread;
        [Export("delaysInkSpread")]
        bool DelaysInkSpread { get; set; }

        // @property (assign, nonatomic) CGFloat dragCancelDistance;
        [Export("dragCancelDistance")]
        nfloat DragCancelDistance { get; set; }

        // @property (assign, nonatomic) BOOL cancelsOnDragOut;
        [Export("cancelsOnDragOut")]
        bool CancelsOnDragOut { get; set; }

        // @property (assign, nonatomic) BOOL requiresFailureOfScrollViewGestures;
        [Export("requiresFailureOfScrollViewGestures")]
        bool RequiresFailureOfScrollViewGestures { get; set; }

        // @property (nonatomic) CGRect targetBounds;
        [Export("targetBounds", ArgumentSemantic.Assign)]
        CGRect TargetBounds { get; set; }

        // @property (readonly, nonatomic, strong) MDCInkGestureRecognizer * _Nonnull gestureRecognizer;
        [Export("gestureRecognizer", ArgumentSemantic.Strong)]
        MDCInkGestureRecognizer GestureRecognizer { get; }

        // -(instancetype _Nonnull)initWithView:(UIView * _Nonnull)view __attribute__((objc_designated_initializer));
        [Export("initWithView:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIView view);

        // -(void)addInkView;
        [Export("addInkView")]
        void AddInkView();

        // -(void)cancelInkTouchProcessing;
        [Export("cancelInkTouchProcessing")]
        void CancelInkTouchProcessing();

        // -(MDCInkView * _Nullable)inkViewAtTouchLocation:(CGPoint)location;
        [Export("inkViewAtTouchLocation:")]
        [return: NullAllowed]
        MDCInkView InkViewAtTouchLocation(CGPoint location);
    }

    // @protocol MDCInkTouchControllerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCInkTouchControllerDelegate
    {
        // @optional -(void)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController insertInkView:(UIView * _Nonnull)inkView intoView:(UIView * _Nonnull)view;
        [Export("inkTouchController:insertInkView:intoView:")]
        void InkTouchController(MDCInkTouchController inkTouchController, UIView inkView, UIView view);

        // @optional -(MDCInkView * _Nullable)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController inkViewAtTouchLocation:(CGPoint)location;
        [Export("inkTouchController:inkViewAtTouchLocation:")]
        [return: NullAllowed]
        MDCInkView InkTouchController(MDCInkTouchController inkTouchController, CGPoint location);

        // @optional -(BOOL)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController shouldProcessInkTouchesAtTouchLocation:(CGPoint)location;
        [Export("inkTouchController:shouldProcessInkTouchesAtTouchLocation:")]
        bool InkTouchController(MDCInkTouchController inkTouchController, CGPoint location);

        // @optional -(void)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController didProcessInkView:(MDCInkView * _Nonnull)inkView atTouchLocation:(CGPoint)location;
        [Export("inkTouchController:didProcessInkView:atTouchLocation:")]
        void InkTouchController(MDCInkTouchController inkTouchController, MDCInkView inkView, CGPoint location);
    }

    // typedef void (^MDCInkCompletionBlock)();
    delegate void MDCInkCompletionBlock();

    // @interface MDCInkView : UIView
    [BaseType(typeof(UIView))]
    interface MDCInkView
    {
        [Wrap("WeakAnimationDelegate")]
        [NullAllowed]
        MDCInkViewDelegate AnimationDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCInkViewDelegate> _Nullable animationDelegate;
        [NullAllowed, Export("animationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAnimationDelegate { get; set; }

        // @property (assign, nonatomic) MDCInkStyle inkStyle;
        [Export("inkStyle", ArgumentSemantic.Assign)]
        MDCInkStyle InkStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull inkColor __attribute__((annotate("ui_appearance_selector")));
        [Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull defaultInkColor;
        [Export("defaultInkColor", ArgumentSemantic.Strong)]
        UIColor DefaultInkColor { get; }

        // @property (assign, nonatomic) CGFloat maxRippleRadius;
        [Export("maxRippleRadius")]
        nfloat MaxRippleRadius { get; set; }

        // @property (assign, nonatomic) BOOL usesLegacyInkRipple;
        [Export("usesLegacyInkRipple")]
        bool UsesLegacyInkRipple { get; set; }

        // @property (assign, nonatomic) BOOL usesCustomInkCenter;
        [Export("usesCustomInkCenter")]
        bool UsesCustomInkCenter { get; set; }

        // @property (assign, nonatomic) CGPoint customInkCenter;
        [Export("customInkCenter", ArgumentSemantic.Assign)]
        CGPoint CustomInkCenter { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCInkView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCInkView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(void)startTouchBeganAnimationAtPoint:(CGPoint)point completion:(MDCInkCompletionBlock _Nullable)completionBlock;
        [Export("startTouchBeganAnimationAtPoint:completion:")]
        void StartTouchBeganAnimationAtPoint(CGPoint point, [NullAllowed] MDCInkCompletionBlock completionBlock);

        // -(void)startTouchEndedAnimationAtPoint:(CGPoint)point completion:(MDCInkCompletionBlock _Nullable)completionBlock;
        [Export("startTouchEndedAnimationAtPoint:completion:")]
        void StartTouchEndedAnimationAtPoint(CGPoint point, [NullAllowed] MDCInkCompletionBlock completionBlock);

        // -(void)cancelAllAnimationsAnimated:(BOOL)animated;
        [Export("cancelAllAnimationsAnimated:")]
        void CancelAllAnimationsAnimated(bool animated);

        // -(void)startTouchBeganAtPoint:(CGPoint)point animated:(BOOL)animated withCompletion:(MDCInkCompletionBlock _Nullable)completionBlock;
        [Export("startTouchBeganAtPoint:animated:withCompletion:")]
        void StartTouchBeganAtPoint(CGPoint point, bool animated, [NullAllowed] MDCInkCompletionBlock completionBlock);

        // -(void)startTouchEndAtPoint:(CGPoint)point animated:(BOOL)animated withCompletion:(MDCInkCompletionBlock _Nullable)completionBlock;
        [Export("startTouchEndAtPoint:animated:withCompletion:")]
        void StartTouchEndAtPoint(CGPoint point, bool animated, [NullAllowed] MDCInkCompletionBlock completionBlock);

        // +(MDCInkView * _Nonnull)injectedInkViewForView:(UIView * _Nonnull)view;
        [Static]
        [Export("injectedInkViewForView:")]
        MDCInkView InjectedInkViewForView(UIView view);
    }

    // @protocol MDCInkViewDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCInkViewDelegate
    {
        // @optional -(void)inkAnimationDidStart:(MDCInkView * _Nonnull)inkView;
        [Export("inkAnimationDidStart:")]
        void InkAnimationDidStart(MDCInkView inkView);

        // @optional -(void)inkAnimationDidEnd:(MDCInkView * _Nonnull)inkView;
        [Export("inkAnimationDidEnd:")]
        void InkAnimationDidEnd(MDCInkView inkView);
    }

    // @interface MDCButton : UIButton <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIButton))]
    interface MDCButton : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (assign, nonatomic) MDCInkStyle inkStyle __attribute__((annotate("ui_appearance_selector")));
        [Export("inkStyle", ArgumentSemantic.Assign)]
        MDCInkStyle InkStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified inkColor __attribute__((annotate("ui_appearance_selector")));
        [Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }

        // @property (assign, nonatomic) CGFloat inkMaxRippleRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("inkMaxRippleRadius")]
        nfloat InkMaxRippleRadius { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic) CGFloat disabledAlpha;
        [Export("disabledAlpha")]
        nfloat DisabledAlpha { get; set; }

        // @property (getter = isUppercaseTitle, nonatomic) BOOL uppercaseTitle __attribute__((annotate("ui_appearance_selector")));
        [Export("uppercaseTitle")]
        bool UppercaseTitle { [Bind("isUppercaseTitle")] get; set; }

        // @property (nonatomic) UIEdgeInsets hitAreaInsets;
        [Export("hitAreaInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets HitAreaInsets { get; set; }

        // @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumSize", ArgumentSemantic.Assign)]
        CGSize MinimumSize { get; set; }

        // @property (assign, nonatomic) CGSize maximumSize __attribute__((annotate("ui_appearance_selector")));
        [Export("maximumSize", ArgumentSemantic.Assign)]
        CGSize MaximumSize { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable underlyingColorHint;
        [NullAllowed, Export("underlyingColorHint", ArgumentSemantic.Strong)]
        UIColor UnderlyingColorHint { get; set; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable;
        [Export("adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable")]
        bool AdjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable { get; set; }

        // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
        [NullAllowed, Export("shapeGenerator", ArgumentSemantic.Strong)]
        MDCShapeGenerating ShapeGenerator { get; set; }

        // @property (assign, nonatomic) BOOL accessibilityTraitsIncludesButton;
        [Export("accessibilityTraitsIncludesButton")]
        bool AccessibilityTraitsIncludesButton { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCButton * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCButton, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(UIColor * _Nullable)backgroundColorForState:(UIControlState)state;
        [Export("backgroundColorForState:")]
        [return: NullAllowed]
        UIColor BackgroundColorForState(UIControlState state);

        // -(void)setBackgroundColor:(UIColor * _Nullable)backgroundColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBackgroundColor:forState:")]
        void SetBackgroundColor([NullAllowed] UIColor backgroundColor, UIControlState state);

        // -(void)setBackgroundColor:(UIColor * _Nullable)backgroundColor;
        [Export("setBackgroundColor:")]
        void SetBackgroundColor([NullAllowed] UIColor backgroundColor);

        // -(UIFont * _Nullable)titleFontForState:(UIControlState)state;
        [Export("titleFontForState:")]
        [return: NullAllowed]
        UIFont TitleFontForState(UIControlState state);

        // -(void)setTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setTitleFont:forState:")]
        void SetTitleFont([NullAllowed] UIFont font, UIControlState state);

        // -(void)setEnabled:(BOOL)enabled animated:(BOOL)animated;
        [Export("setEnabled:animated:")]
        void SetEnabled(bool enabled, bool animated);

        // -(MDCShadowElevation)elevationForState:(UIControlState)state;
        [Export("elevationForState:")]
        double ElevationForState(UIControlState state);

        // -(void)setElevation:(MDCShadowElevation)elevation forState:(UIControlState)state;
        [Export("setElevation:forState:")]
        void SetElevation(double elevation, UIControlState state);

        // -(UIColor * _Nullable)borderColorForState:(UIControlState)state;
        [Export("borderColorForState:")]
        [return: NullAllowed]
        UIColor BorderColorForState(UIControlState state);

        // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderColor:forState:")]
        void SetBorderColor([NullAllowed] UIColor borderColor, UIControlState state);

        // -(UIColor * _Nullable)imageTintColorForState:(UIControlState)state;
        [Export("imageTintColorForState:")]
        [return: NullAllowed]
        UIColor ImageTintColorForState(UIControlState state);

        // -(void)setImageTintColor:(UIColor * _Nullable)imageTintColor forState:(UIControlState)state;
        [Export("setImageTintColor:forState:")]
        void SetImageTintColor([NullAllowed] UIColor imageTintColor, UIControlState state);

        // -(CGFloat)borderWidthForState:(UIControlState)state;
        [Export("borderWidthForState:")]
        nfloat BorderWidthForState(UIControlState state);

        // -(void)setBorderWidth:(CGFloat)borderWidth forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderWidth:forState:")]
        void SetBorderWidth(nfloat borderWidth, UIControlState state);

        // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setShadowColor:forState:")]
        void SetShadowColor([NullAllowed] UIColor shadowColor, UIControlState state);

        // -(UIColor * _Nullable)shadowColorForState:(UIControlState)state;
        [Export("shadowColorForState:")]
        [return: NullAllowed]
        UIColor ShadowColorForState(UIControlState state);
    }

    // @interface MDCFlatButton : MDCButton
    [BaseType(typeof(MDCButton))]
    interface MDCFlatButton
    {
        // @property (nonatomic) BOOL hasOpaqueBackground;
        [Export("hasOpaqueBackground")]
        bool HasOpaqueBackground { get; set; }
    }

    // @interface MDCFloatingButton : MDCButton
    [BaseType(typeof(MDCButton))]
    interface MDCFloatingButton
    {
        // @property (assign, nonatomic) MDCFloatingButtonMode mode;
        [Export("mode", ArgumentSemantic.Assign)]
        MDCFloatingButtonMode Mode { get; set; }

        // @property (assign, nonatomic) MDCFloatingButtonImageLocation imageLocation __attribute__((annotate("ui_appearance_selector")));
        [Export("imageLocation", ArgumentSemantic.Assign)]
        MDCFloatingButtonImageLocation ImageLocation { get; set; }

        // @property (assign, nonatomic) CGFloat imageTitleSpace __attribute__((annotate("ui_appearance_selector")));
        [Export("imageTitleSpace")]
        nfloat ImageTitleSpace { get; set; }

        // +(instancetype _Nonnull)floatingButtonWithShape:(MDCFloatingButtonShape)shape;
        [Static]
        [Export("floatingButtonWithShape:")]
        MDCFloatingButton FloatingButtonWithShape(MDCFloatingButtonShape shape);

        // +(CGFloat)defaultDimension;
        [Static]
        [Export("defaultDimension")]
        [Verify(MethodToProperty)]
        nfloat DefaultDimension { get; }

        // +(CGFloat)miniDimension;
        [Static]
        [Export("miniDimension")]
        [Verify(MethodToProperty)]
        nfloat MiniDimension { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame shape:(MDCFloatingButtonShape)shape __attribute__((objc_designated_initializer));
        [Export("initWithFrame:shape:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, MDCFloatingButtonShape shape);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);

        // -(void)setMinimumSize:(CGSize)minimumSize forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
        [Export("setMinimumSize:forShape:inMode:")]
        void SetMinimumSize(CGSize minimumSize, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

        // -(void)setMaximumSize:(CGSize)maximumSize forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
        [Export("setMaximumSize:forShape:inMode:")]
        void SetMaximumSize(CGSize maximumSize, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

        // -(void)setContentEdgeInsets:(UIEdgeInsets)contentEdgeInsets forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
        [Export("setContentEdgeInsets:forShape:inMode:")]
        void SetContentEdgeInsets(UIEdgeInsets contentEdgeInsets, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

        // -(void)setHitAreaInsets:(UIEdgeInsets)hitAreaInsets forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
        [Export("setHitAreaInsets:forShape:inMode:")]
        void SetHitAreaInsets(UIEdgeInsets hitAreaInsets, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);
    }

    // @interface Animation (MDCFloatingButton)
    [Category]
    [BaseType(typeof(MDCFloatingButton))]
    interface MDCFloatingButton_Animation
    {
        // -(void)expand:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("expand:completion:")]
        void Expand(bool animated, [NullAllowed] Action completion);

        // -(void)collapse:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("collapse:completion:")]
        void Collapse(bool animated, [NullAllowed] Action completion);
    }

    // @interface MDCRaisedButton : MDCButton
    [BaseType(typeof(MDCButton))]
    interface MDCRaisedButton
    {
    }

    // @interface MDCBannerView : UIView <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCBannerView : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (assign, readwrite, nonatomic) MDCBannerViewLayoutStyle bannerViewLayoutStyle;
        [Export("bannerViewLayoutStyle", ArgumentSemantic.Assign)]
        MDCBannerViewLayoutStyle BannerViewLayoutStyle { get; set; }

        // @property (readonly, nonatomic, strong) UITextView * _Nonnull textView;
        [Export("textView", ArgumentSemantic.Strong)]
        UITextView TextView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * _Nonnull imageView;
        [Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; }

        // @property (readonly, nonatomic, strong) MDCButton * _Nonnull leadingButton;
        [Export("leadingButton", ArgumentSemantic.Strong)]
        MDCButton LeadingButton { get; }

        // @property (readonly, nonatomic, strong) MDCButton * _Nonnull trailingButton;
        [Export("trailingButton", ArgumentSemantic.Strong)]
        MDCButton TrailingButton { get; }

        // @property (assign, readwrite, nonatomic) BOOL showsDivider;
        [Export("showsDivider")]
        bool ShowsDivider { get; set; }

        // @property (readwrite, nonatomic, strong) UIColor * _Nonnull dividerColor;
        [Export("dividerColor", ArgumentSemantic.Strong)]
        UIColor DividerColor { get; set; }

        // @property (assign, readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBannerView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBannerView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MaterialTheming (MDCBannerView)
    [Category]
    [BaseType(typeof(MDCBannerView))]
    interface MDCBannerView_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCBottomAppBarView : UIView <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCBottomAppBarView : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (getter = isFloatingButtonHidden, assign, nonatomic) BOOL floatingButtonHidden;
        [Export("floatingButtonHidden")]
        bool FloatingButtonHidden { [Bind("isFloatingButtonHidden")] get; set; }

        // @property (assign, nonatomic) MDCBottomAppBarFloatingButtonElevation floatingButtonElevation;
        [Export("floatingButtonElevation", ArgumentSemantic.Assign)]
        MDCBottomAppBarFloatingButtonElevation FloatingButtonElevation { get; set; }

        // @property (assign, nonatomic) MDCBottomAppBarFloatingButtonPosition floatingButtonPosition;
        [Export("floatingButtonPosition", ArgumentSemantic.Assign)]
        MDCBottomAppBarFloatingButtonPosition FloatingButtonPosition { get; set; }

        // @property (readonly, nonatomic, strong) MDCFloatingButton * _Nonnull floatingButton;
        [Export("floatingButton", ArgumentSemantic.Strong)]
        MDCFloatingButton FloatingButton { get; }

        // @property (assign, nonatomic) CGFloat floatingButtonVerticalOffset;
        [Export("floatingButtonVerticalOffset")]
        nfloat FloatingButtonVerticalOffset { get; set; }

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leadingBarButtonItems;
        [NullAllowed, Export("leadingBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] LeadingBarButtonItems { get; set; }

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable trailingBarButtonItems;
        [NullAllowed, Export("trailingBarButtonItems", ArgumentSemantic.Copy)]
        UIBarButtonItem[] TrailingBarButtonItems { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable barTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("barTintColor", ArgumentSemantic.Strong)]
        UIColor BarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull leadingBarItemsTintColor;
        [Export("leadingBarItemsTintColor", ArgumentSemantic.Strong)]
        UIColor LeadingBarItemsTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trailingBarItemsTintColor;
        [Export("trailingBarItemsTintColor", ArgumentSemantic.Strong)]
        UIColor TrailingBarItemsTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable shadowColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }

        // -(void)setFloatingButtonHidden:(BOOL)floatingButtonHidden animated:(BOOL)animated;
        [Export("setFloatingButtonHidden:animated:")]
        void SetFloatingButtonHidden(bool floatingButtonHidden, bool animated);

        // -(void)setFloatingButtonElevation:(MDCBottomAppBarFloatingButtonElevation)floatingButtonElevation animated:(BOOL)animated;
        [Export("setFloatingButtonElevation:animated:")]
        void SetFloatingButtonElevation(MDCBottomAppBarFloatingButtonElevation floatingButtonElevation, bool animated);

        // -(void)setFloatingButtonPosition:(MDCBottomAppBarFloatingButtonPosition)floatingButtonPosition animated:(BOOL)animated;
        [Export("setFloatingButtonPosition:animated:")]
        void SetFloatingButtonPosition(MDCBottomAppBarFloatingButtonPosition floatingButtonPosition, bool animated);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBottomAppBarView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBottomAppBarView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }
    }

    // @interface MDCBottomAppBarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCBottomAppBarColorThemer
    {
        // +(void)applySurfaceVariantWithSemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomAppBarView:(MDCBottomAppBarView * _Nonnull)bottomAppBarView __attribute__((deprecated("No replacement exists. Please comment on https://github.com/material-components/material-components-ios/issues/7172 in order to indicate interest in a replacement API.")));
        [Static]
        [Export("applySurfaceVariantWithSemanticColorScheme:toBottomAppBarView:")]
        void ApplySurfaceVariantWithSemanticColorScheme(MDCColorScheming colorScheme, MDCBottomAppBarView bottomAppBarView);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toBottomAppBarView:(MDCBottomAppBarView * _Nonnull)bottomAppBarView __attribute__((deprecated("No replacement exists. Please comment on https://github.com/material-components/material-components-ios/issues/7172 in order to indicate interest in a replacement API.")));
        [Static]
        [Export("applyColorScheme:toBottomAppBarView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCBottomAppBarView bottomAppBarView);
    }

    // @interface MDCBottomNavigationBar : UIView <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCBottomNavigationBar : IMDCElevatable, IMDCElevationOverriding
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCBottomNavigationBarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCBottomNavigationBarDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) MDCBottomNavigationBarTitleVisibility titleVisibility __attribute__((annotate("ui_appearance_selector")));
        [Export("titleVisibility", ArgumentSemantic.Assign)]
        MDCBottomNavigationBarTitleVisibility TitleVisibility { get; set; }

        // @property (assign, nonatomic) MDCBottomNavigationBarAlignment alignment __attribute__((annotate("ui_appearance_selector")));
        [Export("alignment", ArgumentSemantic.Assign)]
        MDCBottomNavigationBarAlignment Alignment { get; set; }

        // @property (copy, nonatomic) NSArray<UITabBarItem *> * _Nonnull items;
        [Export("items", ArgumentSemantic.Copy)]
        UITabBarItem[] Items { get; set; }

        // @property (nonatomic, weak) UITabBarItem * _Nullable selectedItem;
        [NullAllowed, Export("selectedItem", ArgumentSemantic.Weak)]
        UITabBarItem SelectedItem { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull itemTitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("itemTitleFont", ArgumentSemantic.Strong)]
        UIFont ItemTitleFont { get; set; }

        // @property (readwrite, nonatomic, strong) UIColor * _Nonnull selectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("selectedItemTintColor", ArgumentSemantic.Strong)]
        UIColor SelectedItemTintColor { get; set; }

        // @property (readwrite, nonatomic, strong) UIColor * _Nonnull selectedItemTitleColor;
        [Export("selectedItemTitleColor", ArgumentSemantic.Strong)]
        UIColor SelectedItemTitleColor { get; set; }

        // @property (readwrite, nonatomic, strong) UIColor * _Nonnull unselectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("unselectedItemTintColor", ArgumentSemantic.Strong)]
        UIColor UnselectedItemTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable barTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("barTintColor", ArgumentSemantic.Strong)]
        UIColor BarTintColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nullable backgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Copy)]
        UIColor BackgroundColor { get; set; }

        // @property (assign, nonatomic) UIBlurEffectStyle backgroundBlurEffectStyle;
        [Export("backgroundBlurEffectStyle", ArgumentSemantic.Assign)]
        UIBlurEffectStyle BackgroundBlurEffectStyle { get; set; }

        // @property (getter = isBackgroundBlurEnabled, assign, nonatomic) BOOL backgroundBlurEnabled;
        [Export("backgroundBlurEnabled")]
        bool BackgroundBlurEnabled { [Bind("isBackgroundBlurEnabled")] get; set; }

        // @property (assign, nonatomic) CGFloat itemsContentVerticalMargin;
        [Export("itemsContentVerticalMargin")]
        nfloat ItemsContentVerticalMargin { get; set; }

        // @property (assign, nonatomic) CGFloat itemsContentHorizontalMargin;
        [Export("itemsContentHorizontalMargin")]
        nfloat ItemsContentHorizontalMargin { get; set; }

        // @property (readonly, nonatomic) NSLayoutYAxisAnchor * _Nonnull barItemsBottomAnchor __attribute__((availability(ios, introduced=9.0)));
        [iOS(9, 0)]
        [Export("barItemsBottomAnchor")]
        NSLayoutYAxisAnchor BarItemsBottomAnchor { get; }

        // @property (assign, nonatomic) BOOL truncatesLongTitles;
        [Export("truncatesLongTitles")]
        bool TruncatesLongTitles { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull shadowColor;
        [Export("shadowColor", ArgumentSemantic.Copy)]
        UIColor ShadowColor { get; set; }

        // @property (assign, nonatomic) NSInteger titlesNumberOfLines;
        [Export("titlesNumberOfLines")]
        nint TitlesNumberOfLines { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBottomNavigationBar * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBottomNavigationBar, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(UIView * _Nullable)viewForItem:(UITabBarItem * _Nonnull)item;
        [Export("viewForItem:")]
        [return: NullAllowed]
        UIView ViewForItem(UITabBarItem item);
    }

    // @interface Deprecated (MDCBottomNavigationBar)
    [Category]
    [BaseType(typeof(MDCBottomNavigationBar))]
    interface MDCBottomNavigationBar_Deprecated
    {
        // @property (assign, nonatomic) BOOL sizeThatFitsIncludesSafeArea __attribute__((deprecated("This was a migration API and is being removed.")));
        [Export("sizeThatFitsIncludesSafeArea")]
        bool SizeThatFitsIncludesSafeArea { get; set; }
    }

    // @protocol MDCBottomNavigationBarDelegate <UINavigationBarDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCBottomNavigationBarDelegate : IUINavigationBarDelegate
    {
        // @optional -(BOOL)bottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar shouldSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("bottomNavigationBar:shouldSelectItem:")]
        bool BottomNavigationBar(MDCBottomNavigationBar bottomNavigationBar, UITabBarItem item);

        // @optional -(void)bottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar didSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("bottomNavigationBar:didSelectItem:")]
        void BottomNavigationBar(MDCBottomNavigationBar bottomNavigationBar, UITabBarItem item);
    }

    // @interface MDCBottomNavigationBarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCBottomNavigationBarColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCBottomNavigationBarColorThemer)
    [Category]
    [BaseType(typeof(MDCBottomNavigationBarColorThemer))]
    interface MDCBottomNavigationBarColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomNavigation:(MDCBottomNavigationBar * _Nonnull)bottomNavigation;
        [Static]
        [Export("applySemanticColorScheme:toBottomNavigation:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCBottomNavigationBar bottomNavigation);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toBottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar;
        [Static]
        [Export("applyColorScheme:toBottomNavigationBar:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCBottomNavigationBar bottomNavigationBar);
    }

    // @interface MaterialTheming (MDCBottomNavigationBar)
    [Category]
    [BaseType(typeof(MDCBottomNavigationBar))]
    interface MDCBottomNavigationBar_MaterialTheming
    {
        // -(void)applyPrimaryThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyPrimaryThemeWithScheme:")]
        void ApplyPrimaryThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applySurfaceThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applySurfaceThemeWithScheme:")]
        void ApplySurfaceThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCBottomNavigationBarTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCBottomNavigationBarTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCBottomNavigationBarTypographyThemer)
    [Category]
    [BaseType(typeof(MDCBottomNavigationBarTypographyThemer))]
    interface MDCBottomNavigationBarTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toBottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar;
        [Static]
        [Export("applyTypographyScheme:toBottomNavigationBar:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCBottomNavigationBar bottomNavigationBar);
    }

    // @interface MDCCurvedCornerTreatment : MDCCornerTreatment
    [BaseType(typeof(MDCCornerTreatment))]
    interface MDCCurvedCornerTreatment
    {
        // @property (assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // -(instancetype _Nonnull)initWithSize:(CGSize)size __attribute__((objc_designated_initializer));
        [Export("initWithSize:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGSize size);
    }

    // @interface MDCCutCornerTreatment : MDCCornerTreatment
    [BaseType(typeof(MDCCornerTreatment))]
    interface MDCCutCornerTreatment
    {
        // @property (assign, nonatomic) CGFloat cut;
        [Export("cut")]
        nfloat Cut { get; set; }

        // -(instancetype _Nonnull)initWithCut:(CGFloat)cut __attribute__((objc_designated_initializer));
        [Export("initWithCut:")]
        [DesignatedInitializer]
        IntPtr Constructor(nfloat cut);
    }

    // @interface MDCRoundedCornerTreatment : MDCCornerTreatment
    [BaseType(typeof(MDCCornerTreatment))]
    interface MDCRoundedCornerTreatment
    {
        // @property (assign, nonatomic) CGFloat radius;
        [Export("radius")]
        nfloat Radius { get; set; }

        // -(instancetype _Nonnull)initWithRadius:(CGFloat)radius __attribute__((objc_designated_initializer));
        [Export("initWithRadius:")]
        [DesignatedInitializer]
        IntPtr Constructor(nfloat radius);
    }

    // @interface CornerTypeInitalizer (MDCCornerTreatment)
    [Category]
    [BaseType(typeof(MDCCornerTreatment))]
    interface MDCCornerTreatment_CornerTypeInitalizer
    {
        // +(MDCRoundedCornerTreatment *)cornerWithRadius:(CGFloat)value;
        [Static]
        [Export("cornerWithRadius:")]
        MDCRoundedCornerTreatment CornerWithRadius(nfloat value);

        // +(MDCRoundedCornerTreatment *)cornerWithRadius:(CGFloat)value valueType:(MDCCornerTreatmentValueType)valueType;
        [Static]
        [Export("cornerWithRadius:valueType:")]
        MDCRoundedCornerTreatment CornerWithRadius(nfloat value, MDCCornerTreatmentValueType valueType);

        // +(MDCCutCornerTreatment *)cornerWithCut:(CGFloat)value;
        [Static]
        [Export("cornerWithCut:")]
        MDCCutCornerTreatment CornerWithCut(nfloat value);

        // +(MDCCutCornerTreatment *)cornerWithCut:(CGFloat)value valueType:(MDCCornerTreatmentValueType)valueType;
        [Static]
        [Export("cornerWithCut:valueType:")]
        MDCCutCornerTreatment CornerWithCut(nfloat value, MDCCornerTreatmentValueType valueType);

        // +(MDCCurvedCornerTreatment *)cornerWithCurve:(CGSize)value;
        [Static]
        [Export("cornerWithCurve:")]
        MDCCurvedCornerTreatment CornerWithCurve(CGSize value);

        // +(MDCCurvedCornerTreatment *)cornerWithCurve:(CGSize)value valueType:(MDCCornerTreatmentValueType)valueType;
        [Static]
        [Export("cornerWithCurve:valueType:")]
        MDCCurvedCornerTreatment CornerWithCurve(CGSize value, MDCCornerTreatmentValueType valueType);
    }

    // @interface MDCCurvedRectShapeGenerator : NSObject <MDCShapeGenerating>
    [BaseType(typeof(NSObject))]
    interface MDCCurvedRectShapeGenerator : IMDCShapeGenerating
    {
        // @property (assign, nonatomic) CGSize cornerSize;
        [Export("cornerSize", ArgumentSemantic.Assign)]
        CGSize CornerSize { get; set; }

        // -(instancetype)initWithCornerSize:(CGSize)cornerSize __attribute__((objc_designated_initializer));
        [Export("initWithCornerSize:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGSize cornerSize);
    }

    // @interface MDCPillShapeGenerator : NSObject <MDCShapeGenerating>
    [BaseType(typeof(NSObject))]
    interface MDCPillShapeGenerator : IMDCShapeGenerating
    {
    }

    // @interface MDCSlantedRectShapeGenerator : NSObject <MDCShapeGenerating>
    [BaseType(typeof(NSObject))]
    interface MDCSlantedRectShapeGenerator : IMDCShapeGenerating
    {
        // @property (assign, nonatomic) CGFloat slant;
        [Export("slant")]
        nfloat Slant { get; set; }
    }

    // @interface MDCTriangleEdgeTreatment : MDCEdgeTreatment
    [BaseType(typeof(MDCEdgeTreatment))]
    [DisableDefaultCtor]
    interface MDCTriangleEdgeTreatment
    {
        // @property (assign, nonatomic) CGFloat size;
        [Export("size")]
        nfloat Size { get; set; }

        // @property (assign, nonatomic) MDCTriangleEdgeStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MDCTriangleEdgeStyle Style { get; set; }

        // -(instancetype _Nonnull)initWithSize:(CGFloat)size style:(MDCTriangleEdgeStyle)style __attribute__((objc_designated_initializer));
        [Export("initWithSize:style:")]
        [DesignatedInitializer]
        IntPtr Constructor(nfloat size, MDCTriangleEdgeStyle style);
    }

    // @interface MDCBottomSheetControllerShapeThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCBottomSheetControllerShapeThemer
    {
    }

    // @interface ToBeDeprecated (MDCBottomSheetControllerShapeThemer)
    [Category]
    [BaseType(typeof(MDCBottomSheetControllerShapeThemer))]
    interface MDCBottomSheetControllerShapeThemer_ToBeDeprecated
    {
        // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toBottomSheetController:(MDCBottomSheetController * _Nonnull)bottomSheetController;
        [Static]
        [Export("applyShapeScheme:toBottomSheetController:")]
        void ApplyShapeScheme(MDCShapeScheming shapeScheme, MDCBottomSheetController bottomSheetController);
    }

    // @interface MDCButtonBar : UIView
    [BaseType(typeof(UIView))]
    interface MDCButtonBar
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCButtonBarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCButtonBarDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable items;
        [NullAllowed, Export("items", ArgumentSemantic.Copy)]
        UIBarButtonItem[] Items { get; set; }

        // -(CGRect)rectForItem:(UIBarButtonItem * _Nonnull)item inCoordinateSpace:(id<UICoordinateSpace> _Nonnull)coordinateSpace;
        [Export("rectForItem:inCoordinateSpace:")]
        CGRect RectForItem(UIBarButtonItem item, UICoordinateSpace coordinateSpace);

        // @property (nonatomic) CGFloat buttonTitleBaseline;
        [Export("buttonTitleBaseline")]
        nfloat ButtonTitleBaseline { get; set; }

        // @property (nonatomic) BOOL uppercasesButtonTitles;
        [Export("uppercasesButtonTitles")]
        bool UppercasesButtonTitles { get; set; }

        // -(void)setButtonsTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state;
        [Export("setButtonsTitleFont:forState:")]
        void SetButtonsTitleFont([NullAllowed] UIFont font, UIControlState state);

        // -(UIFont * _Nullable)buttonsTitleFontForState:(UIControlState)state;
        [Export("buttonsTitleFontForState:")]
        [return: NullAllowed]
        UIFont ButtonsTitleFontForState(UIControlState state);

        // -(void)setButtonsTitleColor:(UIColor * _Nullable)color forState:(UIControlState)state;
        [Export("setButtonsTitleColor:forState:")]
        void SetButtonsTitleColor([NullAllowed] UIColor color, UIControlState state);

        // -(UIColor * _Nullable)buttonsTitleColorForState:(UIControlState)state;
        [Export("buttonsTitleColorForState:")]
        [return: NullAllowed]
        UIColor ButtonsTitleColorForState(UIControlState state);

        // @property (nonatomic) MDCButtonBarLayoutPosition layoutPosition;
        [Export("layoutPosition", ArgumentSemantic.Assign)]
        MDCButtonBarLayoutPosition LayoutPosition { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rippleColor;
        [NullAllowed, Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // -(CGSize)sizeThatFits:(CGSize)size;
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCButtonBar * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCButtonBar, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface ToBeDeprecated (MDCButtonBar)
    [Category]
    [BaseType(typeof(MDCButtonBar))]
    interface MDCButtonBar_ToBeDeprecated
    {
        // @property (nonatomic, strong) UIColor * _Nullable inkColor;
        [NullAllowed, Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }
    }

    // @protocol MDCButtonBarDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCButtonBarDelegate
    {
        // @optional -(void)buttonBarDidInvalidateIntrinsicContentSize:(MDCButtonBar * _Nonnull)buttonBar;
        [Export("buttonBarDidInvalidateIntrinsicContentSize:")]
        void ButtonBarDidInvalidateIntrinsicContentSize(MDCButtonBar buttonBar);

        // @optional -(UIView * _Nonnull)buttonBar:(MDCButtonBar * _Nonnull)buttonBar viewForItem:(UIBarButtonItem * _Nonnull)barButtonItem layoutHints:(MDCBarButtonItemLayoutHints)layoutHints __attribute__((deprecated("There will be no replacement for this API.")));
        [Export("buttonBar:viewForItem:layoutHints:")]
        UIView ButtonBar(MDCButtonBar buttonBar, UIBarButtonItem barButtonItem, MDCBarButtonItemLayoutHints layoutHints);
    }

    // @interface MDCButtonBarButton : MDCFlatButton
    [BaseType(typeof(MDCFlatButton))]
    interface MDCButtonBarButton
    {
        // -(void)setTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setTitleFont:forState:")]
        void SetTitleFont([NullAllowed] UIFont font, UIControlState state);
    }

    // @interface MDCButtonBarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCButtonBarColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCButtonBarColorThemer)
    [Category]
    [BaseType(typeof(MDCButtonBarColorThemer))]
    interface MDCButtonBarColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
        [Static]
        [Export("applySemanticColorScheme:toButtonBar:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButtonBar buttonBar);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
        [Static]
        [Export("applyColorScheme:toButtonBar:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCButtonBar buttonBar);
    }

    // @interface MDCButtonBarTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCButtonBarTypographyThemer
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar __attribute__((deprecated("ButtonBar is not intended to be themed as a standalone component. Please theme it via the AppBar component's Theming extension instead.")));
        [Static]
        [Export("applyTypographyScheme:toButtonBar:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCButtonBar buttonBar);
    }

    // @protocol MDCButtonScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCButtonScheming
    {
        // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Abstract]
        [Export("colorScheme")]
        MDCColorScheming ColorScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
        [Abstract]
        [Export("shapeScheme")]
        MDCShapeScheming ShapeScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Abstract]
        [Export("typographyScheme")]
        MDCTypographyScheming TypographyScheme { get; }

        // @required @property (readonly, nonatomic) CGFloat cornerRadius;
        [Abstract]
        [Export("cornerRadius")]
        nfloat CornerRadius { get; }

        // @required @property (readonly, nonatomic) CGFloat minimumHeight;
        [Abstract]
        [Export("minimumHeight")]
        nfloat MinimumHeight { get; }
    }

    // @interface MDCButtonScheme : NSObject <MDCButtonScheming>
    [BaseType(typeof(NSObject))]
    interface MDCButtonScheme : IMDCButtonScheming
    {
        // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Export("colorScheme", ArgumentSemantic.Assign)]
        MDCColorScheming ColorScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
        [Export("shapeScheme", ArgumentSemantic.Assign)]
        MDCShapeScheming ShapeScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Export("typographyScheme", ArgumentSemantic.Assign)]
        MDCTypographyScheming TypographyScheme { get; set; }

        // @property (readwrite, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (readwrite, nonatomic) CGFloat minimumHeight;
        [Export("minimumHeight")]
        nfloat MinimumHeight { get; set; }
    }

    // @interface MDCContainedButtonThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCContainedButtonThemer
    {
    }

    // @interface ToBeDeprecated (MDCContainedButtonThemer)
    [Category]
    [BaseType(typeof(MDCContainedButtonThemer))]
    interface MDCContainedButtonThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applyScheme:toButton:")]
        void ApplyScheme(MDCButtonScheming scheme, MDCButton button);
    }

    // @interface MDCFloatingActionButtonThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFloatingActionButtonThemer
    {
    }

    // @interface ToBeDeprecated (MDCFloatingActionButtonThemer)
    [Category]
    [BaseType(typeof(MDCFloatingActionButtonThemer))]
    interface MDCFloatingActionButtonThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCFloatingButton * _Nonnull)button;
        [Static]
        [Export("applyScheme:toButton:")]
        void ApplyScheme(MDCButtonScheming scheme, MDCFloatingButton button);
    }

    // @interface MDCOutlinedButtonThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCOutlinedButtonThemer
    {
    }

    // @interface ToBeDeprecated (MDCOutlinedButtonThemer)
    [Category]
    [BaseType(typeof(MDCOutlinedButtonThemer))]
    interface MDCOutlinedButtonThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applyScheme:toButton:")]
        void ApplyScheme(MDCButtonScheming scheme, MDCButton button);
    }

    // @interface MDCTextButtonThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTextButtonThemer
    {
    }

    // @interface ToBeDeprecated (MDCTextButtonThemer)
    [Category]
    [BaseType(typeof(MDCTextButtonThemer))]
    interface MDCTextButtonThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applyScheme:toButton:")]
        void ApplyScheme(MDCButtonScheming scheme, MDCButton button);
    }

    // @interface MDCButtonColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCButtonColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCButtonColorThemer)
    [Category]
    [BaseType(typeof(MDCButtonColorThemer))]
    interface MDCButtonColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applySemanticColorScheme:toButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButton button);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlatButton:(MDCButton * _Nonnull)flatButton;
        [Static]
        [Export("applySemanticColorScheme:toFlatButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButton flatButton);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toRaisedButton:(MDCButton * _Nonnull)raisedButton;
        [Static]
        [Export("applySemanticColorScheme:toRaisedButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButton raisedButton);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFloatingButton:(MDCFloatingButton * _Nonnull)floatingButton;
        [Static]
        [Export("applySemanticColorScheme:toFloatingButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCFloatingButton floatingButton);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applyColorScheme:toButton:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCButton button);
    }

    // @interface MDCContainedButtonColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCContainedButtonColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCContainedButtonColorThemer)
    [Category]
    [BaseType(typeof(MDCContainedButtonColorThemer))]
    interface MDCContainedButtonColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applySemanticColorScheme:toButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButton button);
    }

    // @interface MDCFloatingButtonColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFloatingButtonColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCFloatingButtonColorThemer)
    [Category]
    [BaseType(typeof(MDCFloatingButtonColorThemer))]
    interface MDCFloatingButtonColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCFloatingButton * _Nonnull)button;
        [Static]
        [Export("applySemanticColorScheme:toButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCFloatingButton button);
    }

    // @interface MDCOutlinedButtonColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCOutlinedButtonColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCOutlinedButtonColorThemer)
    [Category]
    [BaseType(typeof(MDCOutlinedButtonColorThemer))]
    interface MDCOutlinedButtonColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applySemanticColorScheme:toButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButton button);
    }

    // @interface MDCTextButtonColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTextButtonColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCTextButtonColorThemer)
    [Category]
    [BaseType(typeof(MDCTextButtonColorThemer))]
    interface MDCTextButtonColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applySemanticColorScheme:toButton:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCButton button);
    }

    // @interface MDCButtonShapeThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCButtonShapeThemer
    {
    }

    // @interface ToBeDeprecated (MDCButtonShapeThemer)
    [Category]
    [BaseType(typeof(MDCButtonShapeThemer))]
    interface MDCButtonShapeThemer_ToBeDeprecated
    {
        // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applyShapeScheme:toButton:")]
        void ApplyShapeScheme(MDCShapeScheming shapeScheme, MDCButton button);
    }

    // @interface MDCFloatingButtonShapeThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFloatingButtonShapeThemer
    {
    }

    // @interface ToBeDeprecated (MDCFloatingButtonShapeThemer)
    [Category]
    [BaseType(typeof(MDCFloatingButtonShapeThemer))]
    interface MDCFloatingButtonShapeThemer_ToBeDeprecated
    {
        // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toButton:(MDCFloatingButton * _Nonnull)button;
        [Static]
        [Export("applyShapeScheme:toButton:")]
        void ApplyShapeScheme(MDCShapeScheming shapeScheme, MDCFloatingButton button);
    }

    // @interface MaterialTheming (MDCButton)
    [Category]
    [BaseType(typeof(MDCButton))]
    interface MDCButton_MaterialTheming
    {
        // -(void)applyContainedThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyContainedThemeWithScheme:")]
        void ApplyContainedThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applyOutlinedThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyOutlinedThemeWithScheme:")]
        void ApplyOutlinedThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applyTextThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyTextThemeWithScheme:")]
        void ApplyTextThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MaterialTheming (MDCFloatingButton)
    [Category]
    [BaseType(typeof(MDCFloatingButton))]
    interface MDCFloatingButton_MaterialTheming
    {
        // -(void)applySecondaryThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applySecondaryThemeWithScheme:")]
        void ApplySecondaryThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCButtonTitleColorAccessibilityMutator : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCButtonTitleColorAccessibilityMutator
    {
        // +(void)changeTitleColorOfButton:(MDCButton *)button;
        [Static]
        [Export("changeTitleColorOfButton:")]
        void ChangeTitleColorOfButton(MDCButton button);
    }

    // @interface MDCButtonTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCButtonTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCButtonTypographyThemer)
    [Category]
    [BaseType(typeof(MDCButtonTypographyThemer))]
    interface MDCButtonTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toButton:(MDCButton * _Nonnull)button;
        [Static]
        [Export("applyTypographyScheme:toButton:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCButton button);
    }

    // typedef void (^MDCRippleCompletionBlock)();
    delegate void MDCRippleCompletionBlock();

    // @interface MDCRippleView : UIView
    [BaseType(typeof(UIView))]
    interface MDCRippleView
    {
        [Wrap("WeakRippleViewDelegate")]
        [NullAllowed]
        MDCRippleViewDelegate RippleViewDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCRippleViewDelegate> _Nullable rippleViewDelegate;
        [NullAllowed, Export("rippleViewDelegate", ArgumentSemantic.Weak)]
        NSObject WeakRippleViewDelegate { get; set; }

        // @property (assign, nonatomic) MDCRippleStyle rippleStyle;
        [Export("rippleStyle", ArgumentSemantic.Assign)]
        MDCRippleStyle RippleStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull rippleColor;
        [Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (assign, nonatomic) CGFloat maximumRadius;
        [Export("maximumRadius")]
        nfloat MaximumRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull activeRippleColor;
        [Export("activeRippleColor", ArgumentSemantic.Strong)]
        UIColor ActiveRippleColor { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCRippleView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCRippleView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(void)cancelAllRipplesAnimated:(BOOL)animated completion:(MDCRippleCompletionBlock _Nullable)completion;
        [Export("cancelAllRipplesAnimated:completion:")]
        void CancelAllRipplesAnimated(bool animated, [NullAllowed] MDCRippleCompletionBlock completion);

        // -(void)fadeInRippleAnimated:(BOOL)animated completion:(MDCRippleCompletionBlock _Nullable)completion;
        [Export("fadeInRippleAnimated:completion:")]
        void FadeInRippleAnimated(bool animated, [NullAllowed] MDCRippleCompletionBlock completion);

        // -(void)fadeOutRippleAnimated:(BOOL)animated completion:(MDCRippleCompletionBlock _Nullable)completion;
        [Export("fadeOutRippleAnimated:completion:")]
        void FadeOutRippleAnimated(bool animated, [NullAllowed] MDCRippleCompletionBlock completion);

        // -(void)beginRippleTouchDownAtPoint:(CGPoint)point animated:(BOOL)animated completion:(MDCRippleCompletionBlock _Nullable)completion;
        [Export("beginRippleTouchDownAtPoint:animated:completion:")]
        void BeginRippleTouchDownAtPoint(CGPoint point, bool animated, [NullAllowed] MDCRippleCompletionBlock completion);

        // -(void)beginRippleTouchUpAnimated:(BOOL)animated completion:(MDCRippleCompletionBlock _Nullable)completion;
        [Export("beginRippleTouchUpAnimated:completion:")]
        void BeginRippleTouchUpAnimated(bool animated, [NullAllowed] MDCRippleCompletionBlock completion);
    }

    // @protocol MDCRippleViewDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCRippleViewDelegate
    {
        // @optional -(void)rippleTouchDownAnimationDidBegin:(MDCRippleView * _Nonnull)rippleView;
        [Export("rippleTouchDownAnimationDidBegin:")]
        void RippleTouchDownAnimationDidBegin(MDCRippleView rippleView);

        // @optional -(void)rippleTouchDownAnimationDidEnd:(MDCRippleView * _Nonnull)rippleView;
        [Export("rippleTouchDownAnimationDidEnd:")]
        void RippleTouchDownAnimationDidEnd(MDCRippleView rippleView);

        // @optional -(void)rippleTouchUpAnimationDidBegin:(MDCRippleView * _Nonnull)rippleView;
        [Export("rippleTouchUpAnimationDidBegin:")]
        void RippleTouchUpAnimationDidBegin(MDCRippleView rippleView);

        // @optional -(void)rippleTouchUpAnimationDidEnd:(MDCRippleView * _Nonnull)rippleView;
        [Export("rippleTouchUpAnimationDidEnd:")]
        void RippleTouchUpAnimationDidEnd(MDCRippleView rippleView);
    }

    // @interface MDCRippleTouchController : NSObject <UIGestureRecognizerDelegate>
    [BaseType(typeof(NSObject))]
    interface MDCRippleTouchController : IUIGestureRecognizerDelegate
    {
        // @property (readonly, nonatomic, weak) UIView * _Nullable view;
        [NullAllowed, Export("view", ArgumentSemantic.Weak)]
        UIView View { get; }

        // @property (readonly, nonatomic, strong) MDCRippleView * _Nonnull rippleView;
        [Export("rippleView", ArgumentSemantic.Strong)]
        MDCRippleView RippleView { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCRippleTouchControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCRippleTouchControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UILongPressGestureRecognizer * _Nonnull gestureRecognizer;
        [Export("gestureRecognizer", ArgumentSemantic.Strong)]
        UILongPressGestureRecognizer GestureRecognizer { get; }

        // @property (assign, nonatomic) BOOL shouldProcessRippleWithScrollViewGestures;
        [Export("shouldProcessRippleWithScrollViewGestures")]
        bool ShouldProcessRippleWithScrollViewGestures { get; set; }

        // -(instancetype _Nonnull)initWithView:(UIView * _Nonnull)view;
        [Export("initWithView:")]
        IntPtr Constructor(UIView view);

        // -(void)addRippleToView:(UIView * _Nonnull)view;
        [Export("addRippleToView:")]
        void AddRippleToView(UIView view);
    }

    // @protocol MDCRippleTouchControllerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCRippleTouchControllerDelegate
    {
        // @optional -(BOOL)rippleTouchController:(MDCRippleTouchController * _Nonnull)rippleTouchController shouldProcessRippleTouchesAtTouchLocation:(CGPoint)location;
        [Export("rippleTouchController:shouldProcessRippleTouchesAtTouchLocation:")]
        bool RippleTouchController(MDCRippleTouchController rippleTouchController, CGPoint location);

        // @optional -(void)rippleTouchController:(MDCRippleTouchController * _Nonnull)rippleTouchController didProcessRippleView:(MDCRippleView * _Nonnull)rippleView atTouchLocation:(CGPoint)location;
        [Export("rippleTouchController:didProcessRippleView:atTouchLocation:")]
        void RippleTouchController(MDCRippleTouchController rippleTouchController, MDCRippleView rippleView, CGPoint location);

        // @optional -(void)rippleTouchController:(MDCRippleTouchController * _Nonnull)rippleTouchController insertRippleView:(MDCRippleView * _Nonnull)rippleView intoView:(UIView * _Nonnull)view;
        [Export("rippleTouchController:insertRippleView:intoView:")]
        void RippleTouchController(MDCRippleTouchController rippleTouchController, MDCRippleView rippleView, UIView view);
    }

    // @interface MDCStatefulRippleView : MDCRippleView
    [BaseType(typeof(MDCRippleView))]
    interface MDCStatefulRippleView
    {
        // @property (getter = isSelected, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // @property (getter = isRippleHighlighted, nonatomic) BOOL rippleHighlighted;
        [Export("rippleHighlighted")]
        bool RippleHighlighted { [Bind("isRippleHighlighted")] get; set; }

        // @property (getter = isDragged, nonatomic) BOOL dragged;
        [Export("dragged")]
        bool Dragged { [Bind("isDragged")] get; set; }

        // @property (nonatomic) BOOL allowsSelection;
        [Export("allowsSelection")]
        bool AllowsSelection { get; set; }

        // -(void)setRippleColor:(UIColor * _Nullable)rippleColor forState:(MDCRippleState)state;
        [Export("setRippleColor:forState:")]
        void SetRippleColor([NullAllowed] UIColor rippleColor, MDCRippleState state);

        // -(UIColor * _Nullable)rippleColorForState:(MDCRippleState)state;
        [Export("rippleColorForState:")]
        [return: NullAllowed]
        UIColor RippleColorForState(MDCRippleState state);

        // -(void)touchesBegan:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesBegan:withEvent:")]
        void TouchesBegan([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesMoved:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesMoved:withEvent:")]
        void TouchesMoved([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesEnded:withEvent:")]
        void TouchesEnded([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesCancelled:withEvent:")]
        void TouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);
    }

    // @interface MDCCard : UIControl <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIControl))]
    interface MDCCard : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (readonly, nonatomic, strong) MDCInkView * _Nonnull inkView;
        [Export("inkView", ArgumentSemantic.Strong)]
        MDCInkView InkView { get; }

        // @property (readonly, nonatomic, strong) MDCStatefulRippleView * _Nonnull rippleView;
        [Export("rippleView", ArgumentSemantic.Strong)]
        MDCStatefulRippleView RippleView { get; }

        // @property (getter = isInteractable, nonatomic) BOOL interactable;
        [Export("interactable")]
        bool Interactable { [Bind("isInteractable")] get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // -(void)setShadowElevation:(MDCShadowElevation)shadowElevation forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setShadowElevation:forState:")]
        void SetShadowElevation(double shadowElevation, UIControlState state);

        // -(MDCShadowElevation)shadowElevationForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("shadowElevationForState:")]
        double ShadowElevationForState(UIControlState state);

        // -(void)setBorderWidth:(CGFloat)borderWidth forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderWidth:forState:")]
        void SetBorderWidth(nfloat borderWidth, UIControlState state);

        // -(CGFloat)borderWidthForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("borderWidthForState:")]
        nfloat BorderWidthForState(UIControlState state);

        // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderColor:forState:")]
        void SetBorderColor([NullAllowed] UIColor borderColor, UIControlState state);

        // -(UIColor * _Nullable)borderColorForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("borderColorForState:")]
        [return: NullAllowed]
        UIColor BorderColorForState(UIControlState state);

        // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setShadowColor:forState:")]
        void SetShadowColor([NullAllowed] UIColor shadowColor, UIControlState state);

        // -(UIColor * _Nullable)shadowColorForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("shadowColorForState:")]
        [return: NullAllowed]
        UIColor ShadowColorForState(UIControlState state);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCCard * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCCard, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
        [NullAllowed, Export("shapeGenerator", ArgumentSemantic.Strong)]
        MDCShapeGenerating ShapeGenerator { get; set; }
    }

    // @interface MDCCardCollectionCell : UICollectionViewCell <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UICollectionViewCell))]
    interface MDCCardCollectionCell : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (getter = isSelectable, assign, nonatomic) BOOL selectable;
        [Export("selectable")]
        bool Selectable { [Bind("isSelectable")] get; set; }

        // @property (getter = isDragged, nonatomic) BOOL dragged;
        [Export("dragged")]
        bool Dragged { [Bind("isDragged")] get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (readonly, nonatomic, strong) MDCInkView * _Nonnull inkView;
        [Export("inkView", ArgumentSemantic.Strong)]
        MDCInkView InkView { get; }

        // @property (readonly, nonatomic, strong) MDCStatefulRippleView * _Nonnull rippleView;
        [Export("rippleView", ArgumentSemantic.Strong)]
        MDCStatefulRippleView RippleView { get; }

        // @property (getter = isInteractable, nonatomic) BOOL interactable;
        [Export("interactable")]
        bool Interactable { [Bind("isInteractable")] get; set; }

        // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
        [NullAllowed, Export("shapeGenerator", ArgumentSemantic.Strong)]
        MDCShapeGenerating ShapeGenerator { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // -(void)setShadowElevation:(MDCShadowElevation)shadowElevation forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setShadowElevation:forState:")]
        void SetShadowElevation(double shadowElevation, MDCCardCellState state);

        // -(MDCShadowElevation)shadowElevationForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("shadowElevationForState:")]
        double ShadowElevationForState(MDCCardCellState state);

        // -(void)setBorderWidth:(CGFloat)borderWidth forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderWidth:forState:")]
        void SetBorderWidth(nfloat borderWidth, MDCCardCellState state);

        // -(CGFloat)borderWidthForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("borderWidthForState:")]
        nfloat BorderWidthForState(MDCCardCellState state);

        // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderColor:forState:")]
        void SetBorderColor([NullAllowed] UIColor borderColor, MDCCardCellState state);

        // -(UIColor * _Nullable)borderColorForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("borderColorForState:")]
        [return: NullAllowed]
        UIColor BorderColorForState(MDCCardCellState state);

        // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setShadowColor:forState:")]
        void SetShadowColor([NullAllowed] UIColor shadowColor, MDCCardCellState state);

        // -(UIColor * _Nullable)shadowColorForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("shadowColorForState:")]
        [return: NullAllowed]
        UIColor ShadowColorForState(MDCCardCellState state);

        // -(UIImage * _Nullable)imageForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("imageForState:")]
        [return: NullAllowed]
        UIImage ImageForState(MDCCardCellState state);

        // -(void)setImage:(UIImage * _Nullable)image forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setImage:forState:")]
        void SetImage([NullAllowed] UIImage image, MDCCardCellState state);

        // -(MDCCardCellHorizontalImageAlignment)horizontalImageAlignmentForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("horizontalImageAlignmentForState:")]
        MDCCardCellHorizontalImageAlignment HorizontalImageAlignmentForState(MDCCardCellState state);

        // -(void)setHorizontalImageAlignment:(MDCCardCellHorizontalImageAlignment)horizontalImageAlignment forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setHorizontalImageAlignment:forState:")]
        void SetHorizontalImageAlignment(MDCCardCellHorizontalImageAlignment horizontalImageAlignment, MDCCardCellState state);

        // -(MDCCardCellVerticalImageAlignment)verticalImageAlignmentForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("verticalImageAlignmentForState:")]
        MDCCardCellVerticalImageAlignment VerticalImageAlignmentForState(MDCCardCellState state);

        // -(void)setVerticalImageAlignment:(MDCCardCellVerticalImageAlignment)verticalImageAlignment forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setVerticalImageAlignment:forState:")]
        void SetVerticalImageAlignment(MDCCardCellVerticalImageAlignment verticalImageAlignment, MDCCardCellState state);

        // -(UIColor * _Nullable)imageTintColorForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("imageTintColorForState:")]
        [return: NullAllowed]
        UIColor ImageTintColorForState(MDCCardCellState state);

        // -(void)setImageTintColor:(UIColor * _Nullable)imageTintColor forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setImageTintColor:forState:")]
        void SetImageTintColor([NullAllowed] UIColor imageTintColor, MDCCardCellState state);

        // @property (readonly, nonatomic) MDCCardCellState state;
        [Export("state")]
        MDCCardCellState State { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCCardCollectionCell * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCCardCollectionCell, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCCardReordering (UICollectionViewController) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(UICollectionViewController))]
    interface UICollectionViewController_MDCCardReordering : IUIGestureRecognizerDelegate
    {
        // -(void)mdc_setupCardReordering;
        [Export("mdc_setupCardReordering")]
        void Mdc_setupCardReordering();
    }

    // @protocol MDCCardScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCCardScheming
    {
        // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Abstract]
        [Export("colorScheme")]
        MDCColorScheming ColorScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
        [Abstract]
        [Export("shapeScheme")]
        MDCShapeScheming ShapeScheme { get; }
    }

    // @interface MDCCardScheme : NSObject <MDCCardScheming>
    [BaseType(typeof(NSObject))]
    interface MDCCardScheme : IMDCCardScheming
    {
        // @property (readwrite, nonatomic) MDCSemanticColorScheme * _Nonnull colorScheme;
        [Export("colorScheme", ArgumentSemantic.Assign)]
        MDCSemanticColorScheme ColorScheme { get; set; }

        // @property (readwrite, nonatomic) MDCShapeScheme * _Nonnull shapeScheme;
        [Export("shapeScheme", ArgumentSemantic.Assign)]
        MDCShapeScheme ShapeScheme { get; set; }
    }

    // @interface MDCCardThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCCardThemer
    {
    }

    // @interface ToBeDeprecated (MDCCardThemer)
    [Category]
    [BaseType(typeof(MDCCardThemer))]
    interface MDCCardThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCCardScheming> _Nonnull)scheme toCard:(MDCCard * _Nonnull)card;
        [Static]
        [Export("applyScheme:toCard:")]
        void ApplyScheme(MDCCardScheming scheme, MDCCard card);

        // +(void)applyScheme:(id<MDCCardScheming> _Nonnull)scheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
        [Static]
        [Export("applyScheme:toCardCell:")]
        void ApplyScheme(MDCCardScheming scheme, MDCCardCollectionCell cardCell);

        // +(void)applyOutlinedVariantWithScheme:(id<MDCCardScheming> _Nonnull)scheme toCard:(MDCCard * _Nonnull)card;
        [Static]
        [Export("applyOutlinedVariantWithScheme:toCard:")]
        void ApplyOutlinedVariantWithScheme(MDCCardScheming scheme, MDCCard card);

        // +(void)applyOutlinedVariantWithScheme:(id<MDCCardScheming> _Nonnull)scheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
        [Static]
        [Export("applyOutlinedVariantWithScheme:toCardCell:")]
        void ApplyOutlinedVariantWithScheme(MDCCardScheming scheme, MDCCardCollectionCell cardCell);
    }

    // @interface MDCCardsColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCCardsColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCCardsColorThemer)
    [Category]
    [BaseType(typeof(MDCCardsColorThemer))]
    interface MDCCardsColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCard:(MDCCard * _Nonnull)card;
        [Static]
        [Export("applySemanticColorScheme:toCard:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCCard card);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
        [Static]
        [Export("applySemanticColorScheme:toCardCell:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCCardCollectionCell cardCell);

        // +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCard:(MDCCard * _Nonnull)card;
        [Static]
        [Export("applyOutlinedVariantWithColorScheme:toCard:")]
        void ApplyOutlinedVariantWithColorScheme(MDCColorScheming colorScheme, MDCCard card);

        // +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
        [Static]
        [Export("applyOutlinedVariantWithColorScheme:toCardCell:")]
        void ApplyOutlinedVariantWithColorScheme(MDCColorScheming colorScheme, MDCCardCollectionCell cardCell);
    }

    // @interface MDCCardsShapeThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCCardsShapeThemer
    {
    }

    // @interface ToBeDeprecated (MDCCardsShapeThemer)
    [Category]
    [BaseType(typeof(MDCCardsShapeThemer))]
    interface MDCCardsShapeThemer_ToBeDeprecated
    {
        // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toCard:(MDCCard * _Nonnull)card;
        [Static]
        [Export("applyShapeScheme:toCard:")]
        void ApplyShapeScheme(MDCShapeScheming shapeScheme, MDCCard card);

        // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
        [Static]
        [Export("applyShapeScheme:toCardCell:")]
        void ApplyShapeScheme(MDCShapeScheming shapeScheme, MDCCardCollectionCell cardCell);
    }

    // @interface MaterialTheming (MDCCard)
    [Category]
    [BaseType(typeof(MDCCard))]
    interface MDCCard_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applyOutlinedThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyOutlinedThemeWithScheme:")]
        void ApplyOutlinedThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MaterialTheming (MDCCardCollectionCell)
    [Category]
    [BaseType(typeof(MDCCardCollectionCell))]
    interface MDCCardCollectionCell_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applyOutlinedThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyOutlinedThemeWithScheme:")]
        void ApplyOutlinedThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCChipCollectionViewCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface MDCChipCollectionViewCell
    {
        // @property (readonly, nonatomic, strong) MDCChipView * _Nonnull chipView;
        [Export("chipView", ArgumentSemantic.Strong)]
        MDCChipView ChipView { get; }

        // @property (assign, nonatomic) BOOL alwaysAnimateResize;
        [Export("alwaysAnimateResize")]
        bool AlwaysAnimateResize { get; set; }

        // -(MDCChipView * _Nonnull)createChipView;
        [Export("createChipView")]
        [Verify(MethodToProperty)]
        MDCChipView CreateChipView { get; }
    }

    // @interface MDCChipCollectionViewFlowLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface MDCChipCollectionViewFlowLayout
    {
    }

    // @interface MDCChipView : UIControl <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIControl))]
    interface MDCChipView : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (readonly, nonatomic) UIImageView * _Nonnull imageView;
        [Export("imageView")]
        UIImageView ImageView { get; }

        // @property (readonly, nonatomic) UIImageView * _Nonnull selectedImageView;
        [Export("selectedImageView")]
        UIImageView SelectedImageView { get; }

        // @property (nonatomic, strong) UIView * _Nullable accessoryView;
        [NullAllowed, Export("accessoryView", ArgumentSemantic.Strong)]
        UIView AccessoryView { get; set; }

        // @property (readonly, nonatomic) UILabel * _Nonnull titleLabel;
        [Export("titleLabel")]
        UILabel TitleLabel { get; }

        // @property (assign, nonatomic) UIEdgeInsets contentPadding __attribute__((annotate("ui_appearance_selector")));
        [Export("contentPadding", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentPadding { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets imagePadding __attribute__((annotate("ui_appearance_selector")));
        [Export("imagePadding", ArgumentSemantic.Assign)]
        UIEdgeInsets ImagePadding { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets accessoryPadding __attribute__((annotate("ui_appearance_selector")));
        [Export("accessoryPadding", ArgumentSemantic.Assign)]
        UIEdgeInsets AccessoryPadding { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets titlePadding __attribute__((annotate("ui_appearance_selector")));
        [Export("titlePadding", ArgumentSemantic.Assign)]
        UIEdgeInsets TitlePadding { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable titleFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic) BOOL rippleAllowsSelection;
        [Export("rippleAllowsSelection")]
        bool RippleAllowsSelection { get; set; }

        // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("shapeGenerator", ArgumentSemantic.Strong)]
        MDCShapeGenerating ShapeGenerator { get; set; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable;
        [Export("adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable")]
        bool AdjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable { get; set; }

        // @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumSize", ArgumentSemantic.Assign)]
        CGSize MinimumSize { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets hitAreaInsets;
        [Export("hitAreaInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets HitAreaInsets { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCChipView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCChipView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(UIColor * _Nullable)backgroundColorForState:(UIControlState)state;
        [Export("backgroundColorForState:")]
        [return: NullAllowed]
        UIColor BackgroundColorForState(UIControlState state);

        // -(void)setBackgroundColor:(UIColor * _Nullable)backgroundColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBackgroundColor:forState:")]
        void SetBackgroundColor([NullAllowed] UIColor backgroundColor, UIControlState state);

        // -(UIColor * _Nullable)borderColorForState:(UIControlState)state;
        [Export("borderColorForState:")]
        [return: NullAllowed]
        UIColor BorderColorForState(UIControlState state);

        // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderColor:forState:")]
        void SetBorderColor([NullAllowed] UIColor borderColor, UIControlState state);

        // -(CGFloat)borderWidthForState:(UIControlState)state;
        [Export("borderWidthForState:")]
        nfloat BorderWidthForState(UIControlState state);

        // -(void)setBorderWidth:(CGFloat)borderWidth forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setBorderWidth:forState:")]
        void SetBorderWidth(nfloat borderWidth, UIControlState state);

        // -(MDCShadowElevation)elevationForState:(UIControlState)state;
        [Export("elevationForState:")]
        double ElevationForState(UIControlState state);

        // -(void)setElevation:(MDCShadowElevation)elevation forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setElevation:forState:")]
        void SetElevation(double elevation, UIControlState state);

        // -(UIColor * _Nullable)inkColorForState:(UIControlState)state;
        [Export("inkColorForState:")]
        [return: NullAllowed]
        UIColor InkColorForState(UIControlState state);

        // -(void)setInkColor:(UIColor * _Nullable)inkColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setInkColor:forState:")]
        void SetInkColor([NullAllowed] UIColor inkColor, UIControlState state);

        // -(UIColor * _Nullable)shadowColorForState:(UIControlState)state;
        [Export("shadowColorForState:")]
        [return: NullAllowed]
        UIColor ShadowColorForState(UIControlState state);

        // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setShadowColor:forState:")]
        void SetShadowColor([NullAllowed] UIColor shadowColor, UIControlState state);

        // -(UIColor * _Nullable)titleColorForState:(UIControlState)state;
        [Export("titleColorForState:")]
        [return: NullAllowed]
        UIColor TitleColorForState(UIControlState state);

        // -(void)setTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setTitleColor:forState:")]
        void SetTitleColor([NullAllowed] UIColor titleColor, UIControlState state);
    }

    // @interface MDCIntrinsicHeightTextView : UITextView
    [BaseType(typeof(UITextView))]
    interface MDCIntrinsicHeightTextView
    {
    }

    // @protocol MDCTextInput <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTextInput
    {
        // @required @property (copy, nonatomic) NSAttributedString * _Nullable attributedPlaceholder;
        [Abstract]
        [NullAllowed, Export("attributedPlaceholder", ArgumentSemantic.Copy)]
        NSAttributedString AttributedPlaceholder { get; set; }

        // @required @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
        [Abstract]
        [NullAllowed, Export("attributedText", ArgumentSemantic.Copy)]
        NSAttributedString AttributedText { get; set; }

        // @required @property (copy, nonatomic) UIBezierPath * _Nullable borderPath __attribute__((annotate("ui_appearance_selector")));
        [Abstract]
        [NullAllowed, Export("borderPath", ArgumentSemantic.Copy)]
        UIBezierPath BorderPath { get; set; }

        // @required @property (nonatomic, strong) MDCTextInputBorderView * _Nullable borderView;
        [Abstract]
        [NullAllowed, Export("borderView", ArgumentSemantic.Strong)]
        MDCTextInputBorderView BorderView { get; set; }

        // @required @property (readonly, nonatomic, strong) UIButton * _Nonnull clearButton;
        [Abstract]
        [Export("clearButton", ArgumentSemantic.Strong)]
        UIButton ClearButton { get; }

        // @required @property (assign, nonatomic) UITextFieldViewMode clearButtonMode __attribute__((annotate("ui_appearance_selector")));
        [Abstract]
        [Export("clearButtonMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode ClearButtonMode { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nullable cursorColor __attribute__((annotate("ui_appearance_selector")));
        [Abstract]
        [NullAllowed, Export("cursorColor", ArgumentSemantic.Strong)]
        UIColor CursorColor { get; set; }

        // @required @property (readonly, getter = isEditing, assign, nonatomic) BOOL editing;
        [Abstract]
        [Export("editing")]
        bool Editing { [Bind("isEditing")] get; }

        // @required @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
        [Abstract]
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @required @property (nonatomic, strong) UIFont * _Nullable font;
        [Abstract]
        [NullAllowed, Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @required @property (assign, nonatomic) BOOL hidesPlaceholderOnInput;
        [Abstract]
        [Export("hidesPlaceholderOnInput")]
        bool HidesPlaceholderOnInput { get; set; }

        // @required @property (readonly, nonatomic, strong) UILabel * _Nonnull leadingUnderlineLabel;
        [Abstract]
        [Export("leadingUnderlineLabel", ArgumentSemantic.Strong)]
        UILabel LeadingUnderlineLabel { get; }

        // @required @property (nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Abstract]
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @required @property (copy, nonatomic) NSString * _Nullable placeholder;
        [Abstract]
        [NullAllowed, Export("placeholder")]
        string Placeholder { get; set; }

        // @required @property (readonly, nonatomic, strong) UILabel * _Nonnull placeholderLabel;
        [Abstract]
        [Export("placeholderLabel", ArgumentSemantic.Strong)]
        UILabel PlaceholderLabel { get; }

        [Wrap("WeakPositioningDelegate"), Abstract]
        [NullAllowed]
        MDCTextInputPositioningDelegate PositioningDelegate { get; set; }

        // @required @property (nonatomic, weak) id<MDCTextInputPositioningDelegate> _Nullable positioningDelegate;
        [Abstract]
        [NullAllowed, Export("positioningDelegate", ArgumentSemantic.Weak)]
        NSObject WeakPositioningDelegate { get; set; }

        // @required @property (copy, nonatomic) NSString * _Nullable text;
        [Abstract]
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nullable textColor;
        [Abstract]
        [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @required @property (readonly, assign, nonatomic) UIEdgeInsets textInsets;
        [Abstract]
        [Export("textInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextInsets { get; }

        // @required @property (assign, nonatomic) MDCTextInputTextInsetsMode textInsetsMode __attribute__((annotate("ui_appearance_selector")));
        [Abstract]
        [Export("textInsetsMode", ArgumentSemantic.Assign)]
        MDCTextInputTextInsetsMode TextInsetsMode { get; set; }

        // @required @property (readonly, nonatomic, strong) UILabel * _Nonnull trailingUnderlineLabel;
        [Abstract]
        [Export("trailingUnderlineLabel", ArgumentSemantic.Strong)]
        UILabel TrailingUnderlineLabel { get; }

        // @required @property (nonatomic, strong) UIView * _Nullable trailingView;
        [Abstract]
        [NullAllowed, Export("trailingView", ArgumentSemantic.Strong)]
        UIView TrailingView { get; set; }

        // @required @property (assign, nonatomic) UITextFieldViewMode trailingViewMode;
        [Abstract]
        [Export("trailingViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode TrailingViewMode { get; set; }

        // @required @property (readonly, nonatomic, strong) MDCTextInputUnderlineView * _Nullable underline;
        [Abstract]
        [NullAllowed, Export("underline", ArgumentSemantic.Strong)]
        MDCTextInputUnderlineView Underline { get; }

        // @required @property (readonly, assign, nonatomic) BOOL hasTextContent;
        [Abstract]
        [Export("hasTextContent")]
        bool HasTextContent { get; }

        // @required -(void)clearText;
        [Abstract]
        [Export("clearText")]
        void ClearText();
    }

    // @protocol MDCLeadingViewTextInput <MDCTextInput>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCLeadingViewTextInput : IMDCTextInput
    {
        // @required @property (nonatomic, strong) UIView * _Nullable leadingView;
        [Abstract]
        [NullAllowed, Export("leadingView", ArgumentSemantic.Strong)]
        UIView LeadingView { get; set; }

        // @required @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
        [Abstract]
        [Export("leadingViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode LeadingViewMode { get; set; }
    }

    // @protocol MDCMultilineTextInput <MDCTextInput>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCMultilineTextInput : IMDCTextInput
    {
        // @required @property (assign, nonatomic) BOOL expandsOnOverflow;
        [Abstract]
        [Export("expandsOnOverflow")]
        bool ExpandsOnOverflow { get; set; }

        // @required @property (assign, nonatomic) NSUInteger minimumLines __attribute__((annotate("ui_appearance_selector")));
        [Abstract]
        [Export("minimumLines")]
        nuint MinimumLines { get; set; }
    }

    // @interface MDCMultilineTextField : UIView <MDCTextInput, MDCMultilineTextInput, MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCMultilineTextField : IMDCTextInput, IMDCMultilineTextInput, IMDCElevatable, IMDCElevationOverriding
    {
        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategory;
        [Export("adjustsFontForContentSizeCategory")]
        bool AdjustsFontForContentSizeCategory { get; set; }

        // @property (assign, nonatomic) BOOL expandsOnOverflow;
        [Export("expandsOnOverflow")]
        bool ExpandsOnOverflow { get; set; }

        [Wrap("WeakLayoutDelegate")]
        [NullAllowed]
        MDCMultilineTextInputLayoutDelegate LayoutDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCMultilineTextInputLayoutDelegate> _Nullable layoutDelegate __attribute__((iboutlet));
        [NullAllowed, Export("layoutDelegate", ArgumentSemantic.Weak)]
        NSObject WeakLayoutDelegate { get; set; }

        [Wrap("WeakMultilineDelegate")]
        [NullAllowed]
        MDCMultilineTextInputDelegate MultilineDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCMultilineTextInputDelegate> _Nullable multilineDelegate __attribute__((iboutlet));
        [NullAllowed, Export("multilineDelegate", ArgumentSemantic.Weak)]
        NSObject WeakMultilineDelegate { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable placeholder;
        [NullAllowed, Export("placeholder")]
        string Placeholder { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets textInsets;
        [Export("textInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextInsets { get; }

        // @property (nonatomic, strong) MDCIntrinsicHeightTextView * _Nullable textView __attribute__((iboutlet));
        [NullAllowed, Export("textView", ArgumentSemantic.Strong)]
        MDCIntrinsicHeightTextView TextView { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCMultilineTextField * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCMultilineTextField, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCMultilineTextInputLayoutDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCMultilineTextInputLayoutDelegate
    {
        // @optional -(void)multilineTextField:(id<MDCMultilineTextInput> _Nonnull)multilineTextField didChangeContentSize:(CGSize)size;
        [Export("multilineTextField:didChangeContentSize:")]
        void DidChangeContentSize(MDCMultilineTextInput multilineTextField, CGSize size);
    }

    // @protocol MDCMultilineTextInputDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCMultilineTextInputDelegate
    {
        // @optional -(BOOL)multilineTextFieldShouldClear:(UIView<MDCTextInput> *)textField;
        [Export("multilineTextFieldShouldClear:")]
        bool MultilineTextFieldShouldClear(MDCTextInput textField);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull MDCTextFieldTextDidSetTextNotification;
        [Field("MDCTextFieldTextDidSetTextNotification", "__Internal")]
        NSString MDCTextFieldTextDidSetTextNotification { get; }

        // extern NSString *const _Nonnull MDCTextInputDidToggleEnabledNotification;
        [Field("MDCTextInputDidToggleEnabledNotification", "__Internal")]
        NSString MDCTextInputDidToggleEnabledNotification { get; }
    }

    // @interface MDCTextField : UITextField <MDCTextInput, MDCLeadingViewTextInput, MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UITextField))]
    interface MDCTextField : IMDCTextInput, IMDCLeadingViewTextInput, IMDCElevatable, IMDCElevationOverriding
    {
        // @property (readonly, nonatomic, strong) UILabel * _Nonnull inputLayoutStrut;
        [Export("inputLayoutStrut", ArgumentSemantic.Strong)]
        UILabel InputLayoutStrut { get; }

        // @property (nonatomic, strong) UIView * _Nullable leadingView;
        [NullAllowed, Export("leadingView", ArgumentSemantic.Strong)]
        UIView LeadingView { get; set; }

        // @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
        [Export("leadingViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode LeadingViewMode { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCTextField * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCTextField, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCTextInputPositioningDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCTextInputPositioningDelegate
    {
        // @optional -(UIEdgeInsets)textInsets:(UIEdgeInsets)defaultInsets;
        [Export("textInsets:")]
        UIEdgeInsets TextInsets(UIEdgeInsets defaultInsets);

        // @optional -(CGRect)editingRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
        [Export("editingRectForBounds:defaultRect:")]
        CGRect EditingRectForBounds(CGRect bounds, CGRect defaultRect);

        // @optional -(CGRect)leadingViewRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
        [Export("leadingViewRectForBounds:defaultRect:")]
        CGRect LeadingViewRectForBounds(CGRect bounds, CGRect defaultRect);

        // @optional -(CGFloat)leadingViewTrailingPaddingConstant;
        [Export("leadingViewTrailingPaddingConstant")]
        [Verify(MethodToProperty)]
        nfloat LeadingViewTrailingPaddingConstant { get; }

        // @optional -(void)textInputDidLayoutSubviews;
        [Export("textInputDidLayoutSubviews")]
        void TextInputDidLayoutSubviews();

        // @optional -(void)textInputDidUpdateConstraints;
        [Export("textInputDidUpdateConstraints")]
        void TextInputDidUpdateConstraints();

        // @optional -(CGRect)trailingViewRectForBounds:(CGRect)bounds defaultRect:(CGRect)defaultRect;
        [Export("trailingViewRectForBounds:defaultRect:")]
        CGRect TrailingViewRectForBounds(CGRect bounds, CGRect defaultRect);

        // @optional -(CGFloat)trailingViewTrailingPaddingConstant;
        [Export("trailingViewTrailingPaddingConstant")]
        [Verify(MethodToProperty)]
        nfloat TrailingViewTrailingPaddingConstant { get; }
    }

    // @interface MDCTextInputBorderView : UIView <NSCopying>
    [BaseType(typeof(UIView))]
    interface MDCTextInputBorderView : INSCopying
    {
        // @property (nonatomic, strong) UIColor * _Nullable borderFillColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("borderFillColor", ArgumentSemantic.Strong)]
        UIColor BorderFillColor { get; set; }

        // @property (nonatomic, strong) UIBezierPath * _Nullable borderPath __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("borderPath", ArgumentSemantic.Strong)]
        UIBezierPath BorderPath { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable borderStrokeColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("borderStrokeColor", ArgumentSemantic.Strong)]
        UIColor BorderStrokeColor { get; set; }
    }

    // @protocol MDCTextInputCharacterCounter <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTextInputCharacterCounter
    {
        // @required -(NSUInteger)characterCountForTextInput:(UIView<MDCTextInput> * _Nullable)textInput;
        [Abstract]
        [Export("characterCountForTextInput:")]
        nuint CharacterCountForTextInput([NullAllowed] MDCTextInput textInput);
    }

    // @interface MDCTextInputAllCharactersCounter : NSObject <MDCTextInputCharacterCounter>
    [BaseType(typeof(NSObject))]
    interface MDCTextInputAllCharactersCounter : IMDCTextInputCharacterCounter
    {
    }

    // @protocol MDCTextInputController <NSObject, NSCopying, MDCTextInputPositioningDelegate>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTextInputController : INSCopying, IMDCTextInputPositioningDelegate
    {
        // @required @property (nonatomic, strong) UIColor * _Null_unspecified activeColor;
        [Abstract]
        [Export("activeColor", ArgumentSemantic.Strong)]
        UIColor ActiveColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified activeColorDefault;
        [Static, Abstract]
        [Export("activeColorDefault", ArgumentSemantic.Strong)]
        UIColor ActiveColorDefault { get; set; }

        // @required @property (nonatomic, weak) id<MDCTextInputCharacterCounter> _Null_unspecified characterCounter;
        [Abstract]
        [Export("characterCounter", ArgumentSemantic.Weak)]
        MDCTextInputCharacterCounter CharacterCounter { get; set; }

        // @required @property (assign, nonatomic) NSUInteger characterCountMax;
        [Abstract]
        [Export("characterCountMax")]
        nuint CharacterCountMax { get; set; }

        // @required @property (assign, nonatomic) UITextFieldViewMode characterCountViewMode;
        [Abstract]
        [Export("characterCountViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode CharacterCountViewMode { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified disabledColor;
        [Abstract]
        [Export("disabledColor", ArgumentSemantic.Strong)]
        UIColor DisabledColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified disabledColorDefault;
        [Static, Abstract]
        [Export("disabledColorDefault", ArgumentSemantic.Strong)]
        UIColor DisabledColorDefault { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified errorColor;
        [Abstract]
        [Export("errorColor", ArgumentSemantic.Strong)]
        UIColor ErrorColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified errorColorDefault;
        [Static, Abstract]
        [Export("errorColorDefault", ArgumentSemantic.Strong)]
        UIColor ErrorColorDefault { get; set; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable errorText;
        [Abstract]
        [NullAllowed, Export("errorText")]
        string ErrorText { get; }

        // @required @property (copy, nonatomic) NSString * _Nullable helperText;
        [Abstract]
        [NullAllowed, Export("helperText")]
        string HelperText { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified inlinePlaceholderColor;
        [Abstract]
        [Export("inlinePlaceholderColor", ArgumentSemantic.Strong)]
        UIColor InlinePlaceholderColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified inlinePlaceholderColorDefault;
        [Static, Abstract]
        [Export("inlinePlaceholderColorDefault", ArgumentSemantic.Strong)]
        UIColor InlinePlaceholderColorDefault { get; set; }

        // @required @property (nonatomic, strong) UIFont * _Null_unspecified textInputFont;
        [Abstract]
        [Export("textInputFont", ArgumentSemantic.Strong)]
        UIFont TextInputFont { get; set; }

        // @required @property (nonatomic, strong, class) UIFont * _Nullable textInputFontDefault;
        [Static, Abstract]
        [NullAllowed, Export("textInputFontDefault", ArgumentSemantic.Strong)]
        UIFont TextInputFontDefault { get; set; }

        // @required @property (nonatomic, strong) UIFont * _Null_unspecified inlinePlaceholderFont;
        [Abstract]
        [Export("inlinePlaceholderFont", ArgumentSemantic.Strong)]
        UIFont InlinePlaceholderFont { get; set; }

        // @required @property (nonatomic, strong, class) UIFont * _Null_unspecified inlinePlaceholderFontDefault;
        [Static, Abstract]
        [Export("inlinePlaceholderFontDefault", ArgumentSemantic.Strong)]
        UIFont InlinePlaceholderFontDefault { get; set; }

        // @required @property (nonatomic, strong) UIFont * _Null_unspecified leadingUnderlineLabelFont;
        [Abstract]
        [Export("leadingUnderlineLabelFont", ArgumentSemantic.Strong)]
        UIFont LeadingUnderlineLabelFont { get; set; }

        // @required @property (nonatomic, strong, class) UIFont * _Null_unspecified leadingUnderlineLabelFontDefault;
        [Static, Abstract]
        [Export("leadingUnderlineLabelFontDefault", ArgumentSemantic.Strong)]
        UIFont LeadingUnderlineLabelFontDefault { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified leadingUnderlineLabelTextColor;
        [Abstract]
        [Export("leadingUnderlineLabelTextColor", ArgumentSemantic.Strong)]
        UIColor LeadingUnderlineLabelTextColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified leadingUnderlineLabelTextColorDefault;
        [Static, Abstract]
        [Export("leadingUnderlineLabelTextColorDefault", ArgumentSemantic.Strong)]
        UIColor LeadingUnderlineLabelTextColorDefault { get; set; }

        // @required @property (assign, readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
        [Abstract]
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @required @property (assign, nonatomic, class) BOOL mdc_adjustsFontForContentSizeCategoryDefault;
        [Static, Abstract]
        [Export("mdc_adjustsFontForContentSizeCategoryDefault")]
        bool Mdc_adjustsFontForContentSizeCategoryDefault { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified normalColor;
        [Abstract]
        [Export("normalColor", ArgumentSemantic.Strong)]
        UIColor NormalColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified normalColorDefault;
        [Static, Abstract]
        [Export("normalColorDefault", ArgumentSemantic.Strong)]
        UIColor NormalColorDefault { get; set; }

        // @required @property (copy, nonatomic) NSString * _Nullable placeholderText;
        [Abstract]
        [NullAllowed, Export("placeholderText")]
        string PlaceholderText { get; set; }

        // @required @property (assign, nonatomic) UIRectCorner roundedCorners;
        [Abstract]
        [Export("roundedCorners", ArgumentSemantic.Assign)]
        UIRectCorner RoundedCorners { get; set; }

        // @required @property (assign, nonatomic, class) UIRectCorner roundedCornersDefault;
        [Static, Abstract]
        [Export("roundedCornersDefault", ArgumentSemantic.Assign)]
        UIRectCorner RoundedCornersDefault { get; set; }

        // @required @property (nonatomic, strong) UIView<MDCTextInput> * _Nullable textInput;
        [Abstract]
        [NullAllowed, Export("textInput", ArgumentSemantic.Strong)]
        MDCTextInput TextInput { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified textInputClearButtonTintColor;
        [Abstract]
        [Export("textInputClearButtonTintColor", ArgumentSemantic.Strong)]
        UIColor TextInputClearButtonTintColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Nullable textInputClearButtonTintColorDefault;
        [Static, Abstract]
        [NullAllowed, Export("textInputClearButtonTintColorDefault", ArgumentSemantic.Strong)]
        UIColor TextInputClearButtonTintColorDefault { get; set; }

        // @required @property (nonatomic, strong) UIFont * _Null_unspecified trailingUnderlineLabelFont;
        [Abstract]
        [Export("trailingUnderlineLabelFont", ArgumentSemantic.Strong)]
        UIFont TrailingUnderlineLabelFont { get; set; }

        // @required @property (nonatomic, strong, class) UIFont * _Null_unspecified trailingUnderlineLabelFontDefault;
        [Static, Abstract]
        [Export("trailingUnderlineLabelFontDefault", ArgumentSemantic.Strong)]
        UIFont TrailingUnderlineLabelFontDefault { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nullable trailingUnderlineLabelTextColor;
        [Abstract]
        [NullAllowed, Export("trailingUnderlineLabelTextColor", ArgumentSemantic.Strong)]
        UIColor TrailingUnderlineLabelTextColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Nullable trailingUnderlineLabelTextColorDefault;
        [Static, Abstract]
        [NullAllowed, Export("trailingUnderlineLabelTextColorDefault", ArgumentSemantic.Strong)]
        UIColor TrailingUnderlineLabelTextColorDefault { get; set; }

        // @required @property (assign, nonatomic) CGFloat underlineHeightActive;
        [Abstract]
        [Export("underlineHeightActive")]
        nfloat UnderlineHeightActive { get; set; }

        // @required @property (assign, nonatomic, class) CGFloat underlineHeightActiveDefault;
        [Static, Abstract]
        [Export("underlineHeightActiveDefault")]
        nfloat UnderlineHeightActiveDefault { get; set; }

        // @required @property (assign, nonatomic) CGFloat underlineHeightNormal;
        [Abstract]
        [Export("underlineHeightNormal")]
        nfloat UnderlineHeightNormal { get; set; }

        // @required @property (assign, nonatomic, class) CGFloat underlineHeightNormalDefault;
        [Static, Abstract]
        [Export("underlineHeightNormalDefault")]
        nfloat UnderlineHeightNormalDefault { get; set; }

        // @required @property (assign, nonatomic) UITextFieldViewMode underlineViewMode;
        [Abstract]
        [Export("underlineViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode UnderlineViewMode { get; set; }

        // @required @property (assign, nonatomic, class) UITextFieldViewMode underlineViewModeDefault;
        [Static, Abstract]
        [Export("underlineViewModeDefault", ArgumentSemantic.Assign)]
        UITextFieldViewMode UnderlineViewModeDefault { get; set; }

        // @required -(instancetype _Nonnull)initWithTextInput:(UIView<MDCTextInput> * _Nullable)input;
        [Abstract]
        [Export("initWithTextInput:")]
        IntPtr Constructor([NullAllowed] MDCTextInput input);

        // @required -(void)setErrorText:(NSString * _Nullable)errorText errorAccessibilityValue:(NSString * _Nullable)errorAccessibilityValue;
        [Abstract]
        [Export("setErrorText:errorAccessibilityValue:")]
        void SetErrorText([NullAllowed] string errorText, [NullAllowed] string errorAccessibilityValue);

        // @required -(void)setHelperText:(NSString * _Nullable)helperText helperAccessibilityLabel:(NSString * _Nullable)helperAccessibilityLabel;
        [Abstract]
        [Export("setHelperText:helperAccessibilityLabel:")]
        void SetHelperText([NullAllowed] string helperText, [NullAllowed] string helperAccessibilityLabel);
    }

    // @protocol MDCTextInputControllerFloatingPlaceholder <MDCTextInputController>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCTextInputControllerFloatingPlaceholder : IMDCTextInputController
    {
        // @required @property (nonatomic, strong) UIColor * _Null_unspecified floatingPlaceholderActiveColor;
        [Abstract]
        [Export("floatingPlaceholderActiveColor", ArgumentSemantic.Strong)]
        UIColor FloatingPlaceholderActiveColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified floatingPlaceholderActiveColorDefault;
        [Static, Abstract]
        [Export("floatingPlaceholderActiveColorDefault", ArgumentSemantic.Strong)]
        UIColor FloatingPlaceholderActiveColorDefault { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Null_unspecified floatingPlaceholderNormalColor;
        [Abstract]
        [Export("floatingPlaceholderNormalColor", ArgumentSemantic.Strong)]
        UIColor FloatingPlaceholderNormalColor { get; set; }

        // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified floatingPlaceholderNormalColorDefault;
        [Static, Abstract]
        [Export("floatingPlaceholderNormalColorDefault", ArgumentSemantic.Strong)]
        UIColor FloatingPlaceholderNormalColorDefault { get; set; }

        // @required @property (readonly, nonatomic) UIOffset floatingPlaceholderOffset;
        [Abstract]
        [Export("floatingPlaceholderOffset")]
        UIOffset FloatingPlaceholderOffset { get; }

        // @required @property (nonatomic, strong) NSNumber * _Null_unspecified floatingPlaceholderScale;
        [Abstract]
        [Export("floatingPlaceholderScale", ArgumentSemantic.Strong)]
        NSNumber FloatingPlaceholderScale { get; set; }

        // @required @property (assign, nonatomic, class) CGFloat floatingPlaceholderScaleDefault;
        [Static, Abstract]
        [Export("floatingPlaceholderScaleDefault")]
        nfloat FloatingPlaceholderScaleDefault { get; set; }

        // @required @property (getter = isFloatingEnabled, assign, nonatomic) BOOL floatingEnabled;
        [Abstract]
        [Export("floatingEnabled")]
        bool FloatingEnabled { [Bind("isFloatingEnabled")] get; set; }

        // @required @property (getter = isFloatingEnabledDefault, assign, nonatomic, class) BOOL floatingEnabledDefault;
        [Static, Abstract]
        [Export("floatingEnabledDefault")]
        bool FloatingEnabledDefault { [Bind("isFloatingEnabledDefault")] get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat MDCTextInputControllerBaseDefaultBorderRadius;
        [Field("MDCTextInputControllerBaseDefaultBorderRadius", "__Internal")]
        nfloat MDCTextInputControllerBaseDefaultBorderRadius { get; }
    }

    // @interface MDCTextInputControllerBase : NSObject <MDCTextInputControllerFloatingPlaceholder>
    [BaseType(typeof(NSObject))]
    interface MDCTextInputControllerBase : IMDCTextInputControllerFloatingPlaceholder
    {
        // @property (nonatomic, strong) UIColor * _Nullable borderFillColor;
        [NullAllowed, Export("borderFillColor", ArgumentSemantic.Strong)]
        UIColor BorderFillColor { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Null_unspecified borderFillColorDefault;
        [Static]
        [Export("borderFillColorDefault", ArgumentSemantic.Strong)]
        UIColor BorderFillColorDefault { get; set; }

        // @property (assign, nonatomic) BOOL expandsOnOverflow;
        [Export("expandsOnOverflow")]
        bool ExpandsOnOverflow { get; set; }

        // @property (assign, nonatomic) NSUInteger minimumLines;
        [Export("minimumLines")]
        nuint MinimumLines { get; set; }
    }

    // @interface MDCTextInputControllerFilled : MDCTextInputControllerBase
    [BaseType(typeof(MDCTextInputControllerBase))]
    interface MDCTextInputControllerFilled
    {
    }

    // @interface MDCTextInputControllerFullWidth : NSObject <MDCTextInputController>
    [BaseType(typeof(NSObject))]
    interface MDCTextInputControllerFullWidth : IMDCTextInputController
    {
        // @property (nonatomic, strong) UIColor * _Null_unspecified backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Null_unspecified backgroundColorDefault;
        [Static]
        [Export("backgroundColorDefault", ArgumentSemantic.Strong)]
        UIColor BackgroundColorDefault { get; set; }
    }

    // @interface MDCTextInputControllerLegacyDefault : MDCTextInputControllerBase
    [BaseType(typeof(MDCTextInputControllerBase))]
    interface MDCTextInputControllerLegacyDefault
    {
    }

    // @interface MDCTextInputControllerLegacyFullWidth : MDCTextInputControllerFullWidth
    [BaseType(typeof(MDCTextInputControllerFullWidth))]
    interface MDCTextInputControllerLegacyFullWidth
    {
    }

    // @interface MDCTextInputControllerOutlined : MDCTextInputControllerBase
    [BaseType(typeof(MDCTextInputControllerBase))]
    interface MDCTextInputControllerOutlined
    {
    }

    // @interface MDCTextInputControllerOutlinedTextArea : MDCTextInputControllerBase
    [BaseType(typeof(MDCTextInputControllerBase))]
    interface MDCTextInputControllerOutlinedTextArea
    {
    }

    // @interface MDCTextInputControllerUnderline : MDCTextInputControllerBase
    [BaseType(typeof(MDCTextInputControllerBase))]
    interface MDCTextInputControllerUnderline
    {
    }

    // @interface MDCTextInputUnderlineView : UIView <NSCopying>
    [BaseType(typeof(UIView))]
    interface MDCTextInputUnderlineView : INSCopying
    {
        // @property (nonatomic, strong) UIColor * color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (nonatomic, strong) UIColor * disabledColor;
        [Export("disabledColor", ArgumentSemantic.Strong)]
        UIColor DisabledColor { get; set; }

        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) CGFloat lineHeight;
        [Export("lineHeight")]
        nfloat LineHeight { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat MDCChipFieldDefaultMinTextFieldWidth;
        [Field("MDCChipFieldDefaultMinTextFieldWidth", "__Internal")]
        nfloat MDCChipFieldDefaultMinTextFieldWidth { get; }

        // extern const UIEdgeInsets MDCChipFieldDefaultContentEdgeInsets;
        [Field("MDCChipFieldDefaultContentEdgeInsets", "__Internal")]
        UIEdgeInsets MDCChipFieldDefaultContentEdgeInsets { get; }
    }

    // @interface MDCChipField : UIView
    [BaseType(typeof(UIView))]
    interface MDCChipField
    {
        // @property (readonly, nonatomic) MDCTextField * _Nonnull textField;
        [Export("textField")]
        MDCTextField TextField { get; }

        // @property (assign, nonatomic) CGFloat chipHeight;
        [Export("chipHeight")]
        nfloat ChipHeight { get; set; }

        // @property (assign, nonatomic) BOOL showPlaceholderWithChips;
        [Export("showPlaceholderWithChips")]
        bool ShowPlaceholderWithChips { get; set; }

        // @property (nonatomic) BOOL showChipsDeleteButton;
        [Export("showChipsDeleteButton")]
        bool ShowChipsDeleteButton { get; set; }

        // @property (assign, nonatomic) MDCChipFieldDelimiter delimiter;
        [Export("delimiter", ArgumentSemantic.Assign)]
        MDCChipFieldDelimiter Delimiter { get; set; }

        // @property (assign, nonatomic) CGFloat minTextFieldWidth;
        [Export("minTextFieldWidth")]
        nfloat MinTextFieldWidth { get; set; }

        // @property (copy, nonatomic) NSArray<MDCChipView *> * _Nonnull chips;
        [Export("chips", ArgumentSemantic.Copy)]
        MDCChipView[] Chips { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCChipFieldDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCChipFieldDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets;
        [Export("contentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeInsets { get; set; }

        // -(void)addChip:(MDCChipView * _Nonnull)chip;
        [Export("addChip:")]
        void AddChip(MDCChipView chip);

        // -(void)removeChip:(MDCChipView * _Nonnull)chip;
        [Export("removeChip:")]
        void RemoveChip(MDCChipView chip);

        // -(void)removeSelectedChips;
        [Export("removeSelectedChips")]
        void RemoveSelectedChips();

        // -(void)clearTextInput;
        [Export("clearTextInput")]
        void ClearTextInput();

        // -(void)selectChip:(MDCChipView * _Nonnull)chip;
        [Export("selectChip:")]
        void SelectChip(MDCChipView chip);

        // -(void)deselectAllChips;
        [Export("deselectAllChips")]
        void DeselectAllChips();

        // -(void)focusTextFieldForAccessibility;
        [Export("focusTextFieldForAccessibility")]
        void FocusTextFieldForAccessibility();
    }

    // @protocol MDCChipFieldDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCChipFieldDelegate
    {
        // @optional -(void)chipFieldDidBeginEditing:(MDCChipField * _Nonnull)chipField;
        [Export("chipFieldDidBeginEditing:")]
        void ChipFieldDidBeginEditing(MDCChipField chipField);

        // @optional -(void)chipFieldDidEndEditing:(MDCChipField * _Nonnull)chipField;
        [Export("chipFieldDidEndEditing:")]
        void ChipFieldDidEndEditing(MDCChipField chipField);

        // @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didAddChip:(MDCChipView * _Nonnull)chip;
        [Export("chipField:didAddChip:")]
        void ChipField(MDCChipField chipField, MDCChipView chip);

        // @optional -(BOOL)chipField:(MDCChipField * _Nonnull)chipField shouldAddChip:(MDCChipView * _Nonnull)chip;
        [Export("chipField:shouldAddChip:")]
        bool ChipField(MDCChipField chipField, MDCChipView chip);

        // @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didRemoveChip:(MDCChipView * _Nonnull)chip;
        [Export("chipField:didRemoveChip:")]
        void ChipField(MDCChipField chipField, MDCChipView chip);

        // @optional -(void)chipFieldHeightDidChange:(MDCChipField * _Nonnull)chipField;
        [Export("chipFieldHeightDidChange:")]
        void ChipFieldHeightDidChange(MDCChipField chipField);

        // @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didChangeInput:(NSString * _Nullable)input;
        [Export("chipField:didChangeInput:")]
        void ChipField(MDCChipField chipField, [NullAllowed] string input);

        // @optional -(void)chipField:(MDCChipField * _Nonnull)chipField didTapChip:(MDCChipView * _Nonnull)chip;
        [Export("chipField:didTapChip:")]
        void ChipField(MDCChipField chipField, MDCChipView chip);

        // @optional -(BOOL)chipFieldShouldReturn:(MDCChipField * _Nonnull)chipField;
        [Export("chipFieldShouldReturn:")]
        bool ChipFieldShouldReturn(MDCChipField chipField);

        // @optional -(BOOL)chipFieldShouldBecomeFirstResponder:(MDCChipField * _Nonnull)chipField;
        [Export("chipFieldShouldBecomeFirstResponder:")]
        bool ChipFieldShouldBecomeFirstResponder(MDCChipField chipField);
    }

    // @protocol MDCChipViewScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCChipViewScheming
    {
        // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Abstract]
        [Export("colorScheme")]
        MDCColorScheming ColorScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
        [Abstract]
        [Export("shapeScheme")]
        MDCShapeScheming ShapeScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Abstract]
        [Export("typographyScheme")]
        MDCTypographyScheming TypographyScheme { get; }
    }

    // @interface MDCChipViewScheme : NSObject <MDCChipViewScheming>
    [BaseType(typeof(NSObject))]
    interface MDCChipViewScheme : IMDCChipViewScheming
    {
        // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Export("colorScheme", ArgumentSemantic.Assign)]
        MDCColorScheming ColorScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
        [Export("shapeScheme", ArgumentSemantic.Assign)]
        MDCShapeScheming ShapeScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Export("typographyScheme", ArgumentSemantic.Assign)]
        MDCTypographyScheming TypographyScheme { get; set; }
    }

    // @interface MDCChipViewThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCChipViewThemer
    {
    }

    // @interface ToBeDeprecated (MDCChipViewThemer)
    [Category]
    [BaseType(typeof(MDCChipViewThemer))]
    interface MDCChipViewThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCChipViewScheming> _Nonnull)scheme toChipView:(MDCChipView * _Nonnull)chip;
        [Static]
        [Export("applyScheme:toChipView:")]
        void ApplyScheme(MDCChipViewScheming scheme, MDCChipView chip);

        // +(void)applyOutlinedVariantWithScheme:(id<MDCChipViewScheming> _Nonnull)scheme toChipView:(MDCChipView * _Nonnull)chip;
        [Static]
        [Export("applyOutlinedVariantWithScheme:toChipView:")]
        void ApplyOutlinedVariantWithScheme(MDCChipViewScheming scheme, MDCChipView chip);
    }

    // @interface MDCChipViewColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCChipViewColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCChipViewColorThemer)
    [Category]
    [BaseType(typeof(MDCChipViewColorThemer))]
    interface MDCChipViewColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toChipView:(MDCChipView * _Nonnull)chipView;
        [Static]
        [Export("applySemanticColorScheme:toChipView:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCChipView chipView);

        // +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toChipView:(MDCChipView * _Nonnull)chipView;
        [Static]
        [Export("applyOutlinedVariantWithColorScheme:toChipView:")]
        void ApplyOutlinedVariantWithColorScheme(MDCColorScheming colorScheme, MDCChipView chipView);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toStrokedChipView:(MDCChipView * _Nonnull)strokedChipView;
        [Static]
        [Export("applySemanticColorScheme:toStrokedChipView:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCChipView strokedChipView);
    }

    // @interface MDCChipViewFontThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCChipViewFontThemer
    {
    }

    // @interface ToBeDeprecated (MDCChipViewFontThemer)
    [Category]
    [BaseType(typeof(MDCChipViewFontThemer))]
    interface MDCChipViewFontThemer_ToBeDeprecated
    {
        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toChipView:(MDCChipView * _Nonnull)chipView;
        [Static]
        [Export("applyFontScheme:toChipView:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, MDCChipView chipView);
    }

    // @interface MDCChipViewShapeThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCChipViewShapeThemer
    {
    }

    // @interface ToBeDeprecated (MDCChipViewShapeThemer)
    [Category]
    [BaseType(typeof(MDCChipViewShapeThemer))]
    interface MDCChipViewShapeThemer_ToBeDeprecated
    {
        // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toChipView:(MDCChipView * _Nonnull)chipView;
        [Static]
        [Export("applyShapeScheme:toChipView:")]
        void ApplyShapeScheme(MDCShapeScheming shapeScheme, MDCChipView chipView);
    }

    // @interface MaterialTheming (MDCChipView)
    [Category]
    [BaseType(typeof(MDCChipView))]
    interface MDCChipView_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applyOutlinedThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyOutlinedThemeWithScheme:")]
        void ApplyOutlinedThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCChipViewTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCChipViewTypographyThemer
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toChipView:(MDCChipView * _Nonnull)chipView;
        [Static]
        [Export("applyTypographyScheme:toChipView:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCChipView chipView);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull kSelectedCellAccessibilityHintKey;
        [Field("kSelectedCellAccessibilityHintKey", "__Internal")]
        NSString kSelectedCellAccessibilityHintKey { get; }

        // extern NSString *const _Nonnull kDeselectedCellAccessibilityHintKey;
        [Field("kDeselectedCellAccessibilityHintKey", "__Internal")]
        NSString kDeselectedCellAccessibilityHintKey { get; }
    }

    // @interface MDCCollectionViewCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface MDCCollectionViewCell
    {
        // @property (nonatomic) MDCCollectionViewCellAccessoryType accessoryType;
        [Export("accessoryType", ArgumentSemantic.Assign)]
        MDCCollectionViewCellAccessoryType AccessoryType { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable accessoryView;
        [NullAllowed, Export("accessoryView", ArgumentSemantic.Strong)]
        UIView AccessoryView { get; set; }

        // @property (nonatomic) UIEdgeInsets accessoryInset;
        [Export("accessoryInset", ArgumentSemantic.Assign)]
        UIEdgeInsets AccessoryInset { get; set; }

        // @property (nonatomic) BOOL shouldHideSeparator;
        [Export("shouldHideSeparator")]
        bool ShouldHideSeparator { get; set; }

        // @property (nonatomic) UIEdgeInsets separatorInset;
        [Export("separatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SeparatorInset { get; set; }

        // @property (nonatomic) BOOL allowsCellInteractionsWhileEditing;
        [Export("allowsCellInteractionsWhileEditing")]
        bool AllowsCellInteractionsWhileEditing { get; set; }

        // @property (getter = isEditing, nonatomic) BOOL editing;
        [Export("editing")]
        bool Editing { [Bind("isEditing")] get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified editingSelectorColor __attribute__((annotate("ui_appearance_selector")));
        [Export("editingSelectorColor", ArgumentSemantic.Strong)]
        UIColor EditingSelectorColor { get; set; }

        // -(void)setEditing:(BOOL)editing animated:(BOOL)animated;
        [Export("setEditing:animated:")]
        void SetEditing(bool editing, bool animated);

        // @property (nonatomic, strong) MDCInkView * _Nullable inkView;
        [NullAllowed, Export("inkView", ArgumentSemantic.Strong)]
        MDCInkView InkView { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat MDCCellDefaultOneLineHeight;
        [Field("MDCCellDefaultOneLineHeight", "__Internal")]
        nfloat MDCCellDefaultOneLineHeight { get; }

        // extern const CGFloat MDCCellDefaultOneLineWithAvatarHeight;
        [Field("MDCCellDefaultOneLineWithAvatarHeight", "__Internal")]
        nfloat MDCCellDefaultOneLineWithAvatarHeight { get; }

        // extern const CGFloat MDCCellDefaultTwoLineHeight;
        [Field("MDCCellDefaultTwoLineHeight", "__Internal")]
        nfloat MDCCellDefaultTwoLineHeight { get; }

        // extern const CGFloat MDCCellDefaultThreeLineHeight;
        [Field("MDCCellDefaultThreeLineHeight", "__Internal")]
        nfloat MDCCellDefaultThreeLineHeight { get; }
    }

    // @interface MDCCollectionViewTextCell : MDCCollectionViewCell
    [BaseType(typeof(MDCCollectionViewCell))]
    interface MDCCollectionViewTextCell
    {
        // @property (readonly, nonatomic, strong) UILabel * _Nullable textLabel;
        [NullAllowed, Export("textLabel", ArgumentSemantic.Strong)]
        UILabel TextLabel { get; }

        // @property (readonly, nonatomic, strong) UILabel * _Nullable detailTextLabel;
        [NullAllowed, Export("detailTextLabel", ArgumentSemantic.Strong)]
        UILabel DetailTextLabel { get; }

        // @property (readonly, nonatomic, strong) UIImageView * _Nullable imageView;
        [NullAllowed, Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; }
    }

    // @interface MDCCollectionViewLayoutAttributes : UICollectionViewLayoutAttributes <NSCopying>
    [BaseType(typeof(UICollectionViewLayoutAttributes))]
    interface MDCCollectionViewLayoutAttributes : INSCopying
    {
        // @property (getter = isEditing, nonatomic) BOOL editing;
        [Export("editing")]
        bool Editing { [Bind("isEditing")] get; set; }

        // @property (assign, nonatomic) BOOL shouldShowReorderStateMask;
        [Export("shouldShowReorderStateMask")]
        bool ShouldShowReorderStateMask { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowSelectorStateMask;
        [Export("shouldShowSelectorStateMask")]
        bool ShouldShowSelectorStateMask { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowGridBackground;
        [Export("shouldShowGridBackground")]
        bool ShouldShowGridBackground { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable backgroundImage;
        [NullAllowed, Export("backgroundImage", ArgumentSemantic.Strong)]
        UIImage BackgroundImage { get; set; }

        // @property (nonatomic) UIEdgeInsets backgroundImageViewInsets;
        [Export("backgroundImageViewInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets BackgroundImageViewInsets { get; set; }

        // @property (assign, nonatomic) BOOL isGridLayout;
        [Export("isGridLayout")]
        bool IsGridLayout { get; set; }

        // @property (assign, nonatomic) MDCCollectionViewOrdinalPosition sectionOrdinalPosition;
        [Export("sectionOrdinalPosition", ArgumentSemantic.Assign)]
        MDCCollectionViewOrdinalPosition SectionOrdinalPosition { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable separatorColor;
        [NullAllowed, Export("separatorColor", ArgumentSemantic.Strong)]
        UIColor SeparatorColor { get; set; }

        // @property (nonatomic) UIEdgeInsets separatorInset;
        [Export("separatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SeparatorInset { get; set; }

        // @property (nonatomic) CGFloat separatorLineHeight;
        [Export("separatorLineHeight")]
        nfloat SeparatorLineHeight { get; set; }

        // @property (nonatomic) BOOL shouldHideSeparators;
        [Export("shouldHideSeparators")]
        bool ShouldHideSeparators { get; set; }

        // @property (assign, nonatomic) BOOL willAnimateCellsOnAppearance;
        [Export("willAnimateCellsOnAppearance")]
        bool WillAnimateCellsOnAppearance { get; set; }

        // @property (assign, nonatomic) NSTimeInterval animateCellsOnAppearanceDuration;
        [Export("animateCellsOnAppearanceDuration")]
        double AnimateCellsOnAppearanceDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval animateCellsOnAppearanceDelay;
        [Export("animateCellsOnAppearanceDelay")]
        double AnimateCellsOnAppearanceDelay { get; set; }
    }

    // @protocol MDCCollectionViewEditingDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCCollectionViewEditingDelegate
    {
        // @optional -(BOOL)collectionViewAllowsEditing:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewAllowsEditing:")]
        bool CollectionViewAllowsEditing(UICollectionView collectionView);

        // @optional -(void)collectionViewWillBeginEditing:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewWillBeginEditing:")]
        void CollectionViewWillBeginEditing(UICollectionView collectionView);

        // @optional -(void)collectionViewDidBeginEditing:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewDidBeginEditing:")]
        void CollectionViewDidBeginEditing(UICollectionView collectionView);

        // @optional -(void)collectionViewWillEndEditing:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewWillEndEditing:")]
        void CollectionViewWillEndEditing(UICollectionView collectionView);

        // @optional -(void)collectionViewDidEndEditing:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewDidEndEditing:")]
        void CollectionViewDidEndEditing(UICollectionView collectionView);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canEditItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:canEditItemAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSelectItemDuringEditingAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:canSelectItemDuringEditingAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionViewAllowsReordering:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewAllowsReordering:")]
        bool CollectionViewAllowsReordering(UICollectionView collectionView);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:canMoveItemAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
        [Export("collectionView:canMoveItemAtIndexPath:toIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath, NSIndexPath newIndexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
        [Export("collectionView:willMoveItemAtIndexPath:toIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath, NSIndexPath newIndexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
        [Export("collectionView:didMoveItemAtIndexPath:toIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath, NSIndexPath newIndexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willBeginDraggingItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:willBeginDraggingItemAtIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndDraggingItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:didEndDraggingItemAtIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willDeleteItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
        [Export("collectionView:willDeleteItemsAtIndexPaths:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath[] indexPaths);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeleteItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
        [Export("collectionView:didDeleteItemsAtIndexPaths:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath[] indexPaths);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willDeleteSections:(NSIndexSet * _Nonnull)sections;
        [Export("collectionView:willDeleteSections:")]
        void CollectionView(UICollectionView collectionView, NSIndexSet sections);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeleteSections:(NSIndexSet * _Nonnull)sections;
        [Export("collectionView:didDeleteSections:")]
        void CollectionView(UICollectionView collectionView, NSIndexSet sections);

        // @optional -(BOOL)collectionViewAllowsSwipeToDismissItem:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewAllowsSwipeToDismissItem:")]
        bool CollectionViewAllowsSwipeToDismissItem(UICollectionView collectionView);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:canSwipeToDismissItemAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSwipeInDirection:(UISwipeGestureRecognizerDirection)swipeDirection toDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:canSwipeInDirection:toDismissItemAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, UISwipeGestureRecognizerDirection swipeDirection, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willBeginSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:willBeginSwipeToDismissItemAtIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:didEndSwipeToDismissItemAtIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didCancelSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:didCancelSwipeToDismissItemAtIndexPath:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionViewAllowsSwipeToDismissSection:(UICollectionView * _Nonnull)collectionView;
        [Export("collectionViewAllowsSwipeToDismissSection:")]
        bool CollectionViewAllowsSwipeToDismissSection(UICollectionView collectionView);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSwipeToDismissSection:(NSInteger)section;
        [Export("collectionView:canSwipeToDismissSection:")]
        bool CollectionView(UICollectionView collectionView, nint section);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willBeginSwipeToDismissSection:(NSInteger)section;
        [Export("collectionView:willBeginSwipeToDismissSection:")]
        void CollectionView(UICollectionView collectionView, nint section);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndSwipeToDismissSection:(NSInteger)section;
        [Export("collectionView:didEndSwipeToDismissSection:")]
        void CollectionView(UICollectionView collectionView, nint section);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didCancelSwipeToDismissSection:(NSInteger)section;
        [Export("collectionView:didCancelSwipeToDismissSection:")]
        void CollectionView(UICollectionView collectionView, nint section);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat MDCCollectionViewCellStyleCardSectionInset;
        [Field("MDCCollectionViewCellStyleCardSectionInset", "__Internal")]
        nfloat MDCCollectionViewCellStyleCardSectionInset { get; }
    }

    // @protocol MDCCollectionViewStyling <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCCollectionViewStyling
    {
        // @required @property (readonly, nonatomic, weak) UICollectionView * _Nullable collectionView;
        [Abstract]
        [NullAllowed, Export("collectionView", ArgumentSemantic.Weak)]
        UICollectionView CollectionView { get; }

        [Wrap("WeakDelegate"), Abstract]
        [NullAllowed]
        MDCCollectionViewStylingDelegate Delegate { get; set; }

        // @required @property (nonatomic, weak) id<MDCCollectionViewStylingDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @required @property (assign, nonatomic) BOOL shouldInvalidateLayout;
        [Abstract]
        [Export("shouldInvalidateLayout")]
        bool ShouldInvalidateLayout { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nonnull cellBackgroundColor;
        [Abstract]
        [Export("cellBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CellBackgroundColor { get; set; }

        // @required @property (assign, nonatomic) MDCCollectionViewCellLayoutType cellLayoutType;
        [Abstract]
        [Export("cellLayoutType", ArgumentSemantic.Assign)]
        MDCCollectionViewCellLayoutType CellLayoutType { get; set; }

        // @required @property (assign, nonatomic) NSInteger gridColumnCount;
        [Abstract]
        [Export("gridColumnCount")]
        nint GridColumnCount { get; set; }

        // @required @property (assign, nonatomic) CGFloat gridPadding;
        [Abstract]
        [Export("gridPadding")]
        nfloat GridPadding { get; set; }

        // @required @property (assign, nonatomic) MDCCollectionViewCellStyle cellStyle;
        [Abstract]
        [Export("cellStyle", ArgumentSemantic.Assign)]
        MDCCollectionViewCellStyle CellStyle { get; set; }

        // @required @property (nonatomic) CGFloat cardBorderRadius;
        [Abstract]
        [Export("cardBorderRadius")]
        nfloat CardBorderRadius { get; set; }

        // @required -(void)setCellStyle:(MDCCollectionViewCellStyle)cellStyle animated:(BOOL)animated;
        [Abstract]
        [Export("setCellStyle:animated:")]
        void SetCellStyle(MDCCollectionViewCellStyle cellStyle, bool animated);

        // @required -(MDCCollectionViewCellStyle)cellStyleAtSectionIndex:(NSInteger)section;
        [Abstract]
        [Export("cellStyleAtSectionIndex:")]
        MDCCollectionViewCellStyle CellStyleAtSectionIndex(nint section);

        // @required -(UIEdgeInsets)backgroundImageViewOutsetsForCellWithAttribute:(MDCCollectionViewLayoutAttributes * _Nonnull)attr;
        [Abstract]
        [Export("backgroundImageViewOutsetsForCellWithAttribute:")]
        UIEdgeInsets BackgroundImageViewOutsetsForCellWithAttribute(MDCCollectionViewLayoutAttributes attr);

        // @required -(UIImage * _Nullable)backgroundImageForCellLayoutAttributes:(MDCCollectionViewLayoutAttributes * _Nonnull)attr;
        [Abstract]
        [Export("backgroundImageForCellLayoutAttributes:")]
        [return: NullAllowed]
        UIImage BackgroundImageForCellLayoutAttributes(MDCCollectionViewLayoutAttributes attr);

        // @required @property (nonatomic, strong) UIColor * _Nullable separatorColor;
        [Abstract]
        [NullAllowed, Export("separatorColor", ArgumentSemantic.Strong)]
        UIColor SeparatorColor { get; set; }

        // @required @property (nonatomic) UIEdgeInsets separatorInset;
        [Abstract]
        [Export("separatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SeparatorInset { get; set; }

        // @required @property (nonatomic) CGFloat separatorLineHeight;
        [Abstract]
        [Export("separatorLineHeight")]
        nfloat SeparatorLineHeight { get; set; }

        // @required @property (nonatomic) BOOL shouldHideSeparators;
        [Abstract]
        [Export("shouldHideSeparators")]
        bool ShouldHideSeparators { get; set; }

        // @required -(BOOL)shouldHideSeparatorForCellLayoutAttributes:(MDCCollectionViewLayoutAttributes * _Nonnull)attr;
        [Abstract]
        [Export("shouldHideSeparatorForCellLayoutAttributes:")]
        bool ShouldHideSeparatorForCellLayoutAttributes(MDCCollectionViewLayoutAttributes attr);

        // @required @property (assign, nonatomic) BOOL allowsItemInlay;
        [Abstract]
        [Export("allowsItemInlay")]
        bool AllowsItemInlay { get; set; }

        // @required @property (assign, nonatomic) BOOL allowsMultipleItemInlays;
        [Abstract]
        [Export("allowsMultipleItemInlays")]
        bool AllowsMultipleItemInlays { get; set; }

        // @required -(NSArray<NSIndexPath *> * _Nullable)indexPathsForInlaidItems;
        [Abstract]
        [NullAllowed, Export("indexPathsForInlaidItems")]
        [Verify(MethodToProperty)]
        NSIndexPath[] IndexPathsForInlaidItems { get; }

        // @required -(BOOL)isItemInlaidAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Abstract]
        [Export("isItemInlaidAtIndexPath:")]
        bool IsItemInlaidAtIndexPath(NSIndexPath indexPath);

        // @required -(void)applyInlayToItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
        [Abstract]
        [Export("applyInlayToItemAtIndexPath:animated:")]
        void ApplyInlayToItemAtIndexPath(NSIndexPath indexPath, bool animated);

        // @required -(void)removeInlayFromItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
        [Abstract]
        [Export("removeInlayFromItemAtIndexPath:animated:")]
        void RemoveInlayFromItemAtIndexPath(NSIndexPath indexPath, bool animated);

        // @required -(void)applyInlayToAllItemsAnimated:(BOOL)animated;
        [Abstract]
        [Export("applyInlayToAllItemsAnimated:")]
        void ApplyInlayToAllItemsAnimated(bool animated);

        // @required -(void)removeInlayFromAllItemsAnimated:(BOOL)animated;
        [Abstract]
        [Export("removeInlayFromAllItemsAnimated:")]
        void RemoveInlayFromAllItemsAnimated(bool animated);

        // @required -(void)resetIndexPathsForInlaidItems;
        [Abstract]
        [Export("resetIndexPathsForInlaidItems")]
        void ResetIndexPathsForInlaidItems();

        // @required @property (assign, nonatomic) BOOL shouldAnimateCellsOnAppearance;
        [Abstract]
        [Export("shouldAnimateCellsOnAppearance")]
        bool ShouldAnimateCellsOnAppearance { get; set; }

        // @required @property (readonly, assign, nonatomic) BOOL willAnimateCellsOnAppearance;
        [Abstract]
        [Export("willAnimateCellsOnAppearance")]
        bool WillAnimateCellsOnAppearance { get; }

        // @required @property (readonly, assign, nonatomic) CGFloat animateCellsOnAppearancePadding;
        [Abstract]
        [Export("animateCellsOnAppearancePadding")]
        nfloat AnimateCellsOnAppearancePadding { get; }

        // @required @property (readonly, assign, nonatomic) NSTimeInterval animateCellsOnAppearanceDuration;
        [Abstract]
        [Export("animateCellsOnAppearanceDuration")]
        double AnimateCellsOnAppearanceDuration { get; }

        // @required -(void)beginCellAppearanceAnimation;
        [Abstract]
        [Export("beginCellAppearanceAnimation")]
        void BeginCellAppearanceAnimation();
    }

    // @protocol MDCCollectionViewStylingDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCCollectionViewStylingDelegate
    {
        // @optional -(CGFloat)collectionView:(UICollectionView * _Nonnull)collectionView cellHeightAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:cellHeightAtIndexPath:")]
        nfloat CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(MDCCollectionViewCellStyle)collectionView:(UICollectionView * _Nonnull)collectionView cellStyleForSection:(NSInteger)section;
        [Export("collectionView:cellStyleForSection:")]
        MDCCollectionViewCellStyle CollectionView(UICollectionView collectionView, nint section);

        // @optional -(UIColor * _Nullable)collectionView:(UICollectionView * _Nonnull)collectionView cellBackgroundColorAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:cellBackgroundColorAtIndexPath:")]
        [return: NullAllowed]
        UIColor CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideItemBackgroundAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:shouldHideItemBackgroundAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideHeaderBackgroundForSection:(NSInteger)section;
        [Export("collectionView:shouldHideHeaderBackgroundForSection:")]
        bool CollectionView(UICollectionView collectionView, nint section);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideFooterBackgroundForSection:(NSInteger)section;
        [Export("collectionView:shouldHideFooterBackgroundForSection:")]
        bool CollectionView(UICollectionView collectionView, nint section);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideItemSeparatorAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:shouldHideItemSeparatorAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideHeaderSeparatorForSection:(NSInteger)section;
        [Export("collectionView:shouldHideHeaderSeparatorForSection:")]
        bool CollectionView(UICollectionView collectionView, nint section);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHideFooterSeparatorForSection:(NSInteger)section;
        [Export("collectionView:shouldHideFooterSeparatorForSection:")]
        bool CollectionView(UICollectionView collectionView, nint section);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didApplyInlayToItemAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
        [Export("collectionView:didApplyInlayToItemAtIndexPaths:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath[] indexPaths);

        // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didRemoveInlayFromItemAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
        [Export("collectionView:didRemoveInlayFromItemAtIndexPaths:")]
        void CollectionView(UICollectionView collectionView, NSIndexPath[] indexPaths);

        // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView hidesInkViewAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:hidesInkViewAtIndexPath:")]
        bool CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(UIColor * _Nullable)collectionView:(UICollectionView * _Nonnull)collectionView inkColorAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:inkColorAtIndexPath:")]
        [return: NullAllowed]
        UIColor CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // @optional -(MDCInkView * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController inkViewAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("collectionView:inkTouchController:inkViewAtIndexPath:")]
        MDCInkView CollectionView(UICollectionView collectionView, MDCInkTouchController inkTouchController, NSIndexPath indexPath);
    }

    // @interface MDCCollectionViewController : UICollectionViewController <MDCCollectionViewEditingDelegate, MDCCollectionViewStylingDelegate, UICollectionViewDelegateFlowLayout>
    [BaseType(typeof(UICollectionViewController))]
    interface MDCCollectionViewController : IMDCCollectionViewEditingDelegate, IMDCCollectionViewStylingDelegate, IUICollectionViewDelegateFlowLayout
    {
        // @property (readonly, nonatomic, strong) id<MDCCollectionViewStyling> _Nonnull styler;
        [Export("styler", ArgumentSemantic.Strong)]
        MDCCollectionViewStyling Styler { get; }

        // @property (readonly, nonatomic, strong) id<MDCCollectionViewEditing> _Nonnull editor;
        [Export("editor", ArgumentSemantic.Strong)]
        MDCCollectionViewEditing Editor { get; }

        // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
        [Export("collectionView:didHighlightItemAtIndexPath:")]
        [RequiresSuper]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didUnhighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
        [Export("collectionView:didUnhighlightItemAtIndexPath:")]
        [RequiresSuper]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
        [Export("collectionView:didSelectItemAtIndexPath:")]
        [RequiresSuper]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
        [Export("collectionView:didDeselectItemAtIndexPath:")]
        [RequiresSuper]
        void CollectionView(UICollectionView collectionView, NSIndexPath indexPath);

        // -(void)collectionViewWillBeginEditing:(UICollectionView * _Nonnull)collectionView __attribute__((objc_requires_super));
        [Export("collectionViewWillBeginEditing:")]
        [RequiresSuper]
        void CollectionViewWillBeginEditing(UICollectionView collectionView);

        // -(void)collectionViewWillEndEditing:(UICollectionView * _Nonnull)collectionView __attribute__((objc_requires_super));
        [Export("collectionViewWillEndEditing:")]
        [RequiresSuper]
        void CollectionViewWillEndEditing(UICollectionView collectionView);

        // -(CGFloat)cellWidthAtSectionIndex:(NSInteger)section;
        [Export("cellWidthAtSectionIndex:")]
        nfloat CellWidthAtSectionIndex(nint section);
    }

    // @protocol MDCCollectionViewEditing <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCCollectionViewEditing
    {
        // @required @property (readonly, nonatomic, weak) UICollectionView * _Nullable collectionView;
        [Abstract]
        [NullAllowed, Export("collectionView", ArgumentSemantic.Weak)]
        UICollectionView CollectionView { get; }

        [Wrap("WeakDelegate"), Abstract]
        [NullAllowed]
        MDCCollectionViewEditingDelegate Delegate { get; set; }

        // @required @property (nonatomic, weak) id<MDCCollectionViewEditingDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @required @property (readonly, nonatomic, strong) NSIndexPath * _Nullable reorderingCellIndexPath;
        [Abstract]
        [NullAllowed, Export("reorderingCellIndexPath", ArgumentSemantic.Strong)]
        NSIndexPath ReorderingCellIndexPath { get; }

        // @required @property (readonly, nonatomic, strong) NSIndexPath * _Nullable dismissingCellIndexPath;
        [Abstract]
        [NullAllowed, Export("dismissingCellIndexPath", ArgumentSemantic.Strong)]
        NSIndexPath DismissingCellIndexPath { get; }

        // @required @property (readonly, assign, nonatomic) NSInteger dismissingSection;
        [Abstract]
        [Export("dismissingSection")]
        nint DismissingSection { get; }

        // @required @property (assign, nonatomic) NSTimeInterval minimumPressDuration;
        [Abstract]
        [Export("minimumPressDuration")]
        double MinimumPressDuration { get; set; }

        // @required @property (getter = isEditing, nonatomic) BOOL editing;
        [Abstract]
        [Export("editing")]
        bool Editing { [Bind("isEditing")] get; set; }

        // @required -(void)setEditing:(BOOL)editing animated:(BOOL)animated;
        [Abstract]
        [Export("setEditing:animated:")]
        void SetEditing(bool editing, bool animated);

        // @required -(void)updateReorderCellPosition;
        [Abstract]
        [Export("updateReorderCellPosition")]
        void UpdateReorderCellPosition();
    }

    // @interface MDCCollectionViewFlowLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface MDCCollectionViewFlowLayout
    {
    }

    // @interface MDCAlertController : UIViewController <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIViewController))]
    interface MDCAlertController : IMDCElevatable, IMDCElevationOverriding
    {
        // +(instancetype _Nonnull)alertControllerWithTitle:(NSString * _Nullable)title message:(NSString * _Nullable)message;
        [Static]
        [Export("alertControllerWithTitle:message:")]
        MDCAlertController AlertControllerWithTitle([NullAllowed] string title, [NullAllowed] string message);

        // @property (nonatomic, strong) UIFont * _Nullable titleFont;
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleColor;
        [NullAllowed, Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (assign, nonatomic) NSTextAlignment titleAlignment;
        [Export("titleAlignment", ArgumentSemantic.Assign)]
        NSTextAlignment TitleAlignment { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable titleIcon;
        [NullAllowed, Export("titleIcon", ArgumentSemantic.Strong)]
        UIImage TitleIcon { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleIconTintColor;
        [NullAllowed, Export("titleIconTintColor", ArgumentSemantic.Strong)]
        UIColor TitleIconTintColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable messageFont;
        [NullAllowed, Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable messageColor;
        [NullAllowed, Export("messageColor", ArgumentSemantic.Strong)]
        UIColor MessageColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable buttonFont;
        [NullAllowed, Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonTitleColor;
        [NullAllowed, Export("buttonTitleColor", ArgumentSemantic.Strong)]
        UIColor ButtonTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonInkColor;
        [NullAllowed, Export("buttonInkColor", ArgumentSemantic.Strong)]
        UIColor ButtonInkColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull shadowColor;
        [Export("shadowColor", ArgumentSemantic.Copy)]
        UIColor ShadowColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; set; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCAlertController * _Nullable, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCAlertController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable;
        [Export("adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable")]
        bool AdjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable { get; set; }

        // @property (readonly, nonatomic) NSArray<MDCAlertAction *> * _Nonnull actions;
        [Export("actions")]
        MDCAlertAction[] Actions { get; }

        // -(void)addAction:(MDCAlertAction * _Nonnull)action;
        [Export("addAction:")]
        void AddAction(MDCAlertAction action);
    }

    // typedef void (^MDCActionHandler)(MDCAlertAction * _Nonnull);
    delegate void MDCActionHandler(MDCAlertAction arg0);

    // @interface MDCAlertAction : NSObject <NSCopying, UIAccessibilityIdentification>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCAlertAction : INSCopying, IUIAccessibilityIdentification
    {
        // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title handler:(MDCActionHandler _Nullable)handler;
        [Static]
        [Export("actionWithTitle:handler:")]
        MDCAlertAction ActionWithTitle(string title, [NullAllowed] MDCActionHandler handler);

        // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title emphasis:(MDCActionEmphasis)emphasis handler:(MDCActionHandler _Nullable)handler;
        [Static]
        [Export("actionWithTitle:emphasis:handler:")]
        MDCAlertAction ActionWithTitle(string title, MDCActionEmphasis emphasis, [NullAllowed] MDCActionHandler handler);

        // @property (readonly, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) MDCActionEmphasis emphasis;
        [Export("emphasis")]
        MDCActionEmphasis Emphasis { get; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
        [NullAllowed, Export("accessibilityIdentifier")]
        string AccessibilityIdentifier { get; set; }
    }

    // @interface MDCAlertControllerView : UIView
    [BaseType(typeof(UIView))]
    interface MDCAlertControllerView
    {
        // @property (nonatomic, strong) UIFont * _Nullable titleFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (assign, nonatomic) NSTextAlignment titleAlignment;
        [Export("titleAlignment", ArgumentSemantic.Assign)]
        NSTextAlignment TitleAlignment { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable titleIcon;
        [NullAllowed, Export("titleIcon", ArgumentSemantic.Strong)]
        UIImage TitleIcon { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleIconTintColor;
        [NullAllowed, Export("titleIconTintColor", ArgumentSemantic.Strong)]
        UIColor TitleIconTintColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable messageFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable messageColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("messageColor", ArgumentSemantic.Strong)]
        UIColor MessageColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable buttonFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonColor", ArgumentSemantic.Strong)]
        UIColor ButtonColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonInkColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonInkColor", ArgumentSemantic.Strong)]
        UIColor ButtonInkColor { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }
    }

    // @protocol MDCDialogPresentationControllerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCDialogPresentationControllerDelegate
    {
        // @optional -(void)dialogPresentationControllerDidDismiss:(MDCDialogPresentationController * _Nonnull)dialogPresentationController;
        [Export("dialogPresentationControllerDidDismiss:")]
        void DialogPresentationControllerDidDismiss(MDCDialogPresentationController dialogPresentationController);
    }

    // @interface MDCDialogPresentationController : UIPresentationController
    [BaseType(typeof(UIPresentationController))]
    interface MDCDialogPresentationController
    {
        [Wrap("WeakDialogPresentationControllerDelegate")]
        [NullAllowed]
        MDCDialogPresentationControllerDelegate DialogPresentationControllerDelegate { get; set; }

        // @property (nonatomic, weak) id<MDCDialogPresentationControllerDelegate> _Nullable dialogPresentationControllerDelegate;
        [NullAllowed, Export("dialogPresentationControllerDelegate", ArgumentSemantic.Weak)]
        NSObject WeakDialogPresentationControllerDelegate { get; set; }

        // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
        [Export("dismissOnBackgroundTap")]
        bool DismissOnBackgroundTap { get; set; }

        // @property (assign, nonatomic) CGFloat dialogCornerRadius;
        [Export("dialogCornerRadius")]
        nfloat DialogCornerRadius { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation dialogElevation;
        [Export("dialogElevation")]
        double DialogElevation { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull dialogShadowColor;
        [Export("dialogShadowColor", ArgumentSemantic.Copy)]
        UIColor DialogShadowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        // -(CGSize)sizeForChildContentContainer:(id<UIContentContainer> _Nonnull)container withParentContainerSize:(CGSize)parentSize;
        [Export("sizeForChildContentContainer:withParentContainerSize:")]
        CGSize SizeForChildContentContainer(UIContentContainer container, CGSize parentSize);

        // -(CGRect)frameOfPresentedViewInContainerView;
        [Export("frameOfPresentedViewInContainerView")]
        [Verify(MethodToProperty)]
        CGRect FrameOfPresentedViewInContainerView { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCDialogPresentationController * _Nullable, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCDialogPresentationController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCDialogTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>
    [BaseType(typeof(NSObject))]
    interface MDCDialogTransitionController : IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
    {
    }

    // @interface MaterialDialogs (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_MaterialDialogs
    {
        // @property (readonly, nonatomic) MDCDialogPresentationController * _Nullable mdc_dialogPresentationController;
        [NullAllowed, Export("mdc_dialogPresentationController")]
        MDCDialogPresentationController Mdc_dialogPresentationController { get; }
    }

    // @interface ButtonForAction (MDCAlertController)
    [Category]
    [BaseType(typeof(MDCAlertController))]
    interface MDCAlertController_ButtonForAction
    {
        // -(MDCButton * _Nullable)buttonForAction:(MDCAlertAction * _Nonnull)action;
        [Export("buttonForAction:")]
        [return: NullAllowed]
        MDCButton ButtonForAction(MDCAlertAction action);
    }

    // @interface MDCAlertColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCAlertColorThemer
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
        [Static]
        [Export("applySemanticColorScheme:toAlertController:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCAlertController alertController);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme;
        [Static]
        [Export("applyColorScheme:")]
        void ApplyColorScheme(MDCColorScheme colorScheme);
    }

    // @protocol MDCAlertScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCAlertScheming
    {
        // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Abstract]
        [Export("colorScheme")]
        MDCColorScheming ColorScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Abstract]
        [Export("typographyScheme")]
        MDCTypographyScheming TypographyScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCButtonScheming> _Nonnull buttonScheme;
        [Abstract]
        [Export("buttonScheme")]
        MDCButtonScheming ButtonScheme { get; }

        // @required @property (readonly, nonatomic) CGFloat cornerRadius;
        [Abstract]
        [Export("cornerRadius")]
        nfloat CornerRadius { get; }

        // @required @property (readonly, nonatomic) CGFloat elevation;
        [Abstract]
        [Export("elevation")]
        nfloat Elevation { get; }
    }

    // @interface MDCAlertScheme : NSObject <MDCAlertScheming>
    [BaseType(typeof(NSObject))]
    interface MDCAlertScheme : IMDCAlertScheming
    {
        // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Export("colorScheme", ArgumentSemantic.Assign)]
        MDCColorScheming ColorScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Export("typographyScheme", ArgumentSemantic.Assign)]
        MDCTypographyScheming TypographyScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCButtonScheming> _Nonnull buttonScheme;
        [Export("buttonScheme", ArgumentSemantic.Assign)]
        MDCButtonScheming ButtonScheme { get; set; }

        // @property (readwrite, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (readwrite, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }
    }

    // @interface MDCAlertControllerThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCAlertControllerThemer
    {
        // +(void)applyScheme:(id<MDCAlertScheming> _Nonnull)alertScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
        [Static]
        [Export("applyScheme:toAlertController:")]
        void ApplyScheme(MDCAlertScheming alertScheme, MDCAlertController alertController);
    }

    // @interface MaterialTheming (MDCAlertController)
    [Category]
    [BaseType(typeof(MDCAlertController))]
    interface MDCAlertController_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MaterialTheming (MDCDialogPresentationController)
    [Category]
    [BaseType(typeof(MDCDialogPresentationController))]
    interface MDCDialogPresentationController_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCAlertTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCAlertTypographyThemer
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
        [Static]
        [Export("applyTypographyScheme:toAlertController:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCAlertController alertController);
    }

    // @interface MDCFeatureHighlightView : UIView
    [BaseType(typeof(UIView))]
    interface MDCFeatureHighlightView
    {
        // @property (nonatomic, strong) UIColor * _Nullable innerHighlightColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("innerHighlightColor", ArgumentSemantic.Strong)]
        UIColor InnerHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable outerHighlightColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("outerHighlightColor", ArgumentSemantic.Strong)]
        UIColor OuterHighlightColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable titleFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable bodyFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("bodyFont", ArgumentSemantic.Strong)]
        UIFont BodyFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable bodyColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("bodyColor", ArgumentSemantic.Strong)]
        UIColor BodyColor { get; set; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (readwrite, nonatomic, setter = mdc_setLegacyFontScaling:) BOOL mdc_legacyFontScaling;
        [Export("mdc_legacyFontScaling")]
        bool Mdc_legacyFontScaling { get; [Bind("mdc_setLegacyFontScaling:")] set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCFeatureHighlightView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCFeatureHighlightView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat kMDCFeatureHighlightOuterHighlightAlpha;
        [Field("kMDCFeatureHighlightOuterHighlightAlpha", "__Internal")]
        nfloat kMDCFeatureHighlightOuterHighlightAlpha { get; }
    }

    // typedef void (^MDCFeatureHighlightCompletion)(BOOL);
    delegate void MDCFeatureHighlightCompletion(bool arg0);

    // @interface MDCFeatureHighlightViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    [DisableDefaultCtor]
    interface MDCFeatureHighlightViewController
    {
        // -(instancetype _Nonnull)initWithHighlightedView:(UIView * _Nonnull)highlightedView andShowView:(UIView * _Nonnull)displayedView completion:(MDCFeatureHighlightCompletion _Nullable)completion __attribute__((objc_designated_initializer));
        [Export("initWithHighlightedView:andShowView:completion:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIView highlightedView, UIView displayedView, [NullAllowed] MDCFeatureHighlightCompletion completion);

        // -(instancetype _Nonnull)initWithHighlightedView:(UIView * _Nonnull)highlightedView completion:(MDCFeatureHighlightCompletion _Nullable)completion;
        [Export("initWithHighlightedView:completion:")]
        IntPtr Constructor(UIView highlightedView, [NullAllowed] MDCFeatureHighlightCompletion completion);

        // @property (copy, nonatomic) NSString * _Nullable titleText;
        [NullAllowed, Export("titleText")]
        string TitleText { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bodyText;
        [NullAllowed, Export("bodyText")]
        string BodyText { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified outerHighlightColor;
        [Export("outerHighlightColor", ArgumentSemantic.Strong)]
        UIColor OuterHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified innerHighlightColor;
        [Export("innerHighlightColor", ArgumentSemantic.Strong)]
        UIColor InnerHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleColor;
        [NullAllowed, Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable bodyColor;
        [NullAllowed, Export("bodyColor", ArgumentSemantic.Strong)]
        UIColor BodyColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable titleFont;
        [NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable bodyFont;
        [NullAllowed, Export("bodyFont", ArgumentSemantic.Strong)]
        UIFont BodyFont { get; set; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (readwrite, nonatomic, setter = mdc_setLegacyFontScaling:) BOOL mdc_legacyFontScaling;
        [Export("mdc_legacyFontScaling")]
        bool Mdc_legacyFontScaling { get; [Bind("mdc_setLegacyFontScaling:")] set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCFeatureHighlightViewController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCFeatureHighlightViewController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // -(void)acceptFeature;
        [Export("acceptFeature")]
        void AcceptFeature();

        // -(void)rejectFeature;
        [Export("rejectFeature")]
        void RejectFeature();
    }

    // @interface MDCFeatureHighlightColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFeatureHighlightColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCFeatureHighlightColorThemer)
    [Category]
    [BaseType(typeof(MDCFeatureHighlightColorThemer))]
    interface MDCFeatureHighlightColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFeatureHighlightViewController:(MDCFeatureHighlightViewController * _Nonnull)featureHighlightViewController;
        [Static]
        [Export("applySemanticColorScheme:toFeatureHighlightViewController:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCFeatureHighlightViewController featureHighlightViewController);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toFeatureHighlightView:(MDCFeatureHighlightView * _Nonnull)featureHighlightView;
        [Static]
        [Export("applyColorScheme:toFeatureHighlightView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCFeatureHighlightView featureHighlightView);
    }

    // @interface MDFTextAccessibility : NSObject
    [BaseType(typeof(NSObject))]
    interface MDFTextAccessibility
    {
        // +(UIColor * _Nonnull)textColorOnBackgroundColor:(UIColor * _Nonnull)backgroundColor targetTextAlpha:(CGFloat)targetTextAlpha font:(UIFont * _Nullable)font;
        [Static]
        [Export("textColorOnBackgroundColor:targetTextAlpha:font:")]
        UIColor TextColorOnBackgroundColor(UIColor backgroundColor, nfloat targetTextAlpha, [NullAllowed] UIFont font);

        // +(UIColor * _Nullable)textColorOnBackgroundImage:(UIImage * _Nonnull)backgroundImage inRegion:(CGRect)region targetTextAlpha:(CGFloat)targetTextAlpha font:(UIFont * _Nullable)font;
        [Static]
        [Export("textColorOnBackgroundImage:inRegion:targetTextAlpha:font:")]
        [return: NullAllowed]
        UIColor TextColorOnBackgroundImage(UIImage backgroundImage, CGRect region, nfloat targetTextAlpha, [NullAllowed] UIFont font);

        // +(UIColor * _Nullable)textColorOnBackgroundColor:(UIColor * _Nonnull)backgroundColor targetTextAlpha:(CGFloat)targetTextAlpha options:(MDFTextAccessibilityOptions)options;
        [Static]
        [Export("textColorOnBackgroundColor:targetTextAlpha:options:")]
        [return: NullAllowed]
        UIColor TextColorOnBackgroundColor(UIColor backgroundColor, nfloat targetTextAlpha, MDFTextAccessibilityOptions options);

        // +(UIColor * _Nullable)textColorFromChoices:(NSArray<UIColor *> * _Nonnull)choices onBackgroundColor:(UIColor * _Nonnull)backgroundColor options:(MDFTextAccessibilityOptions)options;
        [Static]
        [Export("textColorFromChoices:onBackgroundColor:options:")]
        [return: NullAllowed]
        UIColor TextColorFromChoices(UIColor[] choices, UIColor backgroundColor, MDFTextAccessibilityOptions options);

        // +(CGFloat)minAlphaOfTextColor:(UIColor * _Nonnull)textColor onBackgroundColor:(UIColor * _Nonnull)backgroundColor options:(MDFTextAccessibilityOptions)options;
        [Static]
        [Export("minAlphaOfTextColor:onBackgroundColor:options:")]
        nfloat MinAlphaOfTextColor(UIColor textColor, UIColor backgroundColor, MDFTextAccessibilityOptions options);

        // +(CGFloat)contrastRatioForTextColor:(UIColor * _Nonnull)textColor onBackgroundColor:(UIColor * _Nonnull)backgroundColor;
        [Static]
        [Export("contrastRatioForTextColor:onBackgroundColor:")]
        nfloat ContrastRatioForTextColor(UIColor textColor, UIColor backgroundColor);

        // +(BOOL)textColor:(UIColor * _Nonnull)textColor passesOnBackgroundColor:(UIColor * _Nonnull)backgroundColor options:(MDFTextAccessibilityOptions)options;
        [Static]
        [Export("textColor:passesOnBackgroundColor:options:")]
        bool TextColor(UIColor textColor, UIColor backgroundColor, MDFTextAccessibilityOptions options);

        // +(BOOL)isLargeForContrastRatios:(UIFont * _Nullable)font;
        [Static]
        [Export("isLargeForContrastRatios:")]
        bool IsLargeForContrastRatios([NullAllowed] UIFont font);
    }

    // @interface MDCFeatureHighlightAccessibilityMutator : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFeatureHighlightAccessibilityMutator
    {
        // +(void)mutate:(MDCFeatureHighlightViewController *)featureHighlightViewController;
        [Static]
        [Export("mutate:")]
        void Mutate(MDCFeatureHighlightViewController featureHighlightViewController);
    }

    // @interface MDCFeatureHighlightFontThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFeatureHighlightFontThemer
    {
    }

    // @interface ToBeDeprecated (MDCFeatureHighlightFontThemer)
    [Category]
    [BaseType(typeof(MDCFeatureHighlightFontThemer))]
    interface MDCFeatureHighlightFontThemer_ToBeDeprecated
    {
        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toFeatureHighlightView:(MDCFeatureHighlightView * _Nonnull)featureHighlightView;
        [Static]
        [Export("applyFontScheme:toFeatureHighlightView:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, MDCFeatureHighlightView featureHighlightView);
    }

    // @interface MDCFeatureHighlightTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFeatureHighlightTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCFeatureHighlightTypographyThemer)
    [Category]
    [BaseType(typeof(MDCFeatureHighlightTypographyThemer))]
    interface MDCFeatureHighlightTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toFeatureHighlightViewController:(MDCFeatureHighlightViewController * _Nonnull)featureHighlightViewController;
        [Static]
        [Export("applyTypographyScheme:toFeatureHighlightViewController:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCFeatureHighlightViewController featureHighlightViewController);
    }

    // @interface  (MDCFlexibleHeaderView)
    [Category]
    [BaseType(typeof(MDCFlexibleHeaderView))]
    interface MDCFlexibleHeaderView_
    {
        // @property (nonatomic) BOOL canAlwaysExpandToMaximumHeight;
        [Export("canAlwaysExpandToMaximumHeight")]
        bool CanAlwaysExpandToMaximumHeight { get; set; }
    }

    // @interface MDCFlexibleHeaderColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFlexibleHeaderColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCFlexibleHeaderColorThemer)
    [Category]
    [BaseType(typeof(MDCFlexibleHeaderColorThemer))]
    interface MDCFlexibleHeaderColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
        [Static]
        [Export("applySemanticColorScheme:toFlexibleHeaderView:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCFlexibleHeaderView flexibleHeaderView);

        // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
        [Static]
        [Export("applySurfaceVariantWithColorScheme:toFlexibleHeaderView:")]
        void ApplySurfaceVariantWithColorScheme(MDCColorScheming colorScheme, MDCFlexibleHeaderView flexibleHeaderView);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toFlexibleHeaderView:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
        [Static]
        [Export("applyColorScheme:toFlexibleHeaderView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCFlexibleHeaderView flexibleHeaderView);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toMDCFlexibleHeaderController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderController;
        [Static]
        [Export("applyColorScheme:toMDCFlexibleHeaderController:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCFlexibleHeaderViewController flexibleHeaderController);
    }

    // @interface MDCHeaderStackViewColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCHeaderStackViewColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCHeaderStackViewColorThemer)
    [Category]
    [BaseType(typeof(MDCHeaderStackViewColorThemer))]
    interface MDCHeaderStackViewColorThemer_ToBeDeprecated
    {
        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toHeaderStackView:(MDCHeaderStackView * _Nonnull)headerStackView;
        [Static]
        [Export("applyColorScheme:toHeaderStackView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCHeaderStackView headerStackView);
    }

    // @interface MDCInkColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCInkColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCInkColorThemer)
    [Category]
    [BaseType(typeof(MDCInkColorThemer))]
    interface MDCInkColorThemer_ToBeDeprecated
    {
        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toInkView:(MDCInkView * _Nonnull)inkView;
        [Static]
        [Export("applyColorScheme:toInkView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCInkView inkView);
    }

    // @interface MDCLibraryInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCLibraryInfo
    {
        // @property (readonly, nonatomic, class) NSString * _Nonnull versionString;
        [Static]
        [Export("versionString")]
        string VersionString { get; }
    }

    // @interface MDCBaseCell : UICollectionViewCell <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UICollectionViewCell))]
    interface MDCBaseCell : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rippleColor;
        [NullAllowed, Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBaseCell * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBaseCell, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface ToBeDeprecated (MDCBaseCell)
    [Category]
    [BaseType(typeof(MDCBaseCell))]
    interface MDCBaseCell_ToBeDeprecated
    {
        // @property (nonatomic, strong) UIColor * _Nonnull inkColor;
        [Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }
    }

    // @interface MDCSelfSizingStereoCell : MDCBaseCell
    [BaseType(typeof(MDCBaseCell))]
    interface MDCSelfSizingStereoCell
    {
        // @property (readonly, nonatomic, strong) UIImageView * leadingImageView;
        [Export("leadingImageView", ArgumentSemantic.Strong)]
        UIImageView LeadingImageView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * trailingImageView;
        [Export("trailingImageView", ArgumentSemantic.Strong)]
        UIImageView TrailingImageView { get; }

        // @property (readonly, nonatomic, strong) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Strong)]
        UILabel TitleLabel { get; }

        // @property (readonly, nonatomic, strong) UILabel * detailLabel;
        [Export("detailLabel", ArgumentSemantic.Strong)]
        UILabel DetailLabel { get; }

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable;
        [Export("adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable")]
        bool AdjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable { get; set; }
    }

    // @interface MDCListColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCListColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCListColorThemer)
    [Category]
    [BaseType(typeof(MDCListColorThemer))]
    interface MDCListColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming>)colorScheme toSelfSizingStereoCell:(MDCSelfSizingStereoCell *)cell;
        [Static]
        [Export("applySemanticColorScheme:toSelfSizingStereoCell:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCSelfSizingStereoCell cell);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming>)colorScheme toBaseCell:(MDCBaseCell *)cell;
        [Static]
        [Export("applySemanticColorScheme:toBaseCell:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCBaseCell cell);
    }

    // @protocol MDCListScheming
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCListScheming
    {
        // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Abstract]
        [Export("colorScheme")]
        MDCColorScheming ColorScheme { get; }

        // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Abstract]
        [Export("typographyScheme")]
        MDCTypographyScheming TypographyScheme { get; }
    }

    // @interface MDCListScheme : NSObject <MDCListScheming>
    [BaseType(typeof(NSObject))]
    interface MDCListScheme : IMDCListScheming
    {
        // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
        [Export("colorScheme", ArgumentSemantic.Assign)]
        MDCColorScheming ColorScheme { get; set; }

        // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
        [Export("typographyScheme", ArgumentSemantic.Assign)]
        MDCTypographyScheming TypographyScheme { get; set; }
    }

    // @interface MDCListThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCListThemer
    {
    }

    // @interface ToBeDeprecated (MDCListThemer)
    [Category]
    [BaseType(typeof(MDCListThemer))]
    interface MDCListThemer_ToBeDeprecated
    {
        // +(void)applyScheme:(id<MDCListScheming>)scheme toSelfSizingStereoCell:(MDCSelfSizingStereoCell *)cell;
        [Static]
        [Export("applyScheme:toSelfSizingStereoCell:")]
        void ApplyScheme(MDCListScheming scheme, MDCSelfSizingStereoCell cell);

        // +(void)applyScheme:(id<MDCListScheming>)scheme toBaseCell:(MDCBaseCell *)cell;
        [Static]
        [Export("applyScheme:toBaseCell:")]
        void ApplyScheme(MDCListScheming scheme, MDCBaseCell cell);
    }

    // @interface MaterialTheming (MDCBaseCell)
    [Category]
    [BaseType(typeof(MDCBaseCell))]
    interface MDCBaseCell_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MaterialTheming (MDCSelfSizingStereoCell)
    [Category]
    [BaseType(typeof(MDCSelfSizingStereoCell))]
    interface MDCSelfSizingStereoCell_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCListTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCListTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCListTypographyThemer)
    [Category]
    [BaseType(typeof(MDCListTypographyThemer))]
    interface MDCListTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming>)typographyScheme toSelfSizingStereoCell:(MDCSelfSizingStereoCell *)cell;
        [Static]
        [Export("applyTypographyScheme:toSelfSizingStereoCell:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCSelfSizingStereoCell cell);
    }

    // @interface MDCMaskedTransitionController : NSObject <UIViewControllerTransitioningDelegate>
    [BaseType(typeof(NSObject))]
    interface MDCMaskedTransitionController : IUIViewControllerTransitioningDelegate
    {
        // -(instancetype _Nonnull)initWithSourceView:(UIView * _Nullable)sourceView;
        [Export("initWithSourceView:")]
        IntPtr Constructor([NullAllowed] UIView sourceView);

        // @property (readonly, nonatomic, strong) UIView * _Nullable sourceView;
        [NullAllowed, Export("sourceView", ArgumentSemantic.Strong)]
        UIView SourceView { get; }

        // @property (copy, nonatomic) CGRect (^ _Nullable)(UIPresentationController * _Nonnull) calculateFrameOfPresentedView;
        [NullAllowed, Export("calculateFrameOfPresentedView", ArgumentSemantic.Copy)]
        Func<UIPresentationController, CGRect> CalculateFrameOfPresentedView { get; set; }
    }

    // @interface MDCNavigationBarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCNavigationBarColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCNavigationBarColorThemer)
    [Category]
    [BaseType(typeof(MDCNavigationBarColorThemer))]
    interface MDCNavigationBarColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
        [Static]
        [Export("applySemanticColorScheme:toNavigationBar:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCNavigationBar navigationBar);

        // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
        [Static]
        [Export("applySurfaceVariantWithColorScheme:toNavigationBar:")]
        void ApplySurfaceVariantWithColorScheme(MDCColorScheming colorScheme, MDCNavigationBar navigationBar);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
        [Static]
        [Export("applyColorScheme:toNavigationBar:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCNavigationBar navigationBar);
    }

    // @interface MDCNavigationBarTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCNavigationBarTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCNavigationBarTypographyThemer)
    [Category]
    [BaseType(typeof(MDCNavigationBarTypographyThemer))]
    interface MDCNavigationBarTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
        [Static]
        [Export("applyTypographyScheme:toNavigationBar:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCNavigationBar navigationBar);
    }

    // @protocol MDCBottomDrawerHeader
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    interface MDCBottomDrawerHeader
    {
        // @optional -(void)updateDrawerHeaderTransitionRatio:(CGFloat)transitionToTopRatio;
        [Export("updateDrawerHeaderTransitionRatio:")]
        void UpdateDrawerHeaderTransitionRatio(nfloat transitionToTopRatio);
    }

    // @protocol MDCBottomDrawerPresentationControllerDelegate <UIAdaptivePresentationControllerDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCBottomDrawerPresentationControllerDelegate : IUIAdaptivePresentationControllerDelegate
    {
        // @required -(void)bottomDrawerWillChangeState:(MDCBottomDrawerPresentationController * _Nonnull)presentationController drawerState:(MDCBottomDrawerState)drawerState;
        [Abstract]
        [Export("bottomDrawerWillChangeState:drawerState:")]
        void BottomDrawerWillChangeState(MDCBottomDrawerPresentationController presentationController, MDCBottomDrawerState drawerState);

        // @required -(void)bottomDrawerTopTransitionRatio:(MDCBottomDrawerPresentationController * _Nonnull)presentationController transitionRatio:(CGFloat)transitionRatio;
        [Abstract]
        [Export("bottomDrawerTopTransitionRatio:transitionRatio:")]
        void BottomDrawerTopTransitionRatio(MDCBottomDrawerPresentationController presentationController, nfloat transitionRatio);
    }

    // @interface MDCBottomDrawerPresentationController : UIPresentationController
    [BaseType(typeof(UIPresentationController))]
    interface MDCBottomDrawerPresentationController
    {
        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCBottomDrawerPresentationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCBottomDrawerPresentationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (getter = isTopHandleHidden, assign, nonatomic) BOOL topHandleHidden;
        [Export("topHandleHidden")]
        bool TopHandleHidden { [Bind("isTopHandleHidden")] get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable topHandleColor;
        [NullAllowed, Export("topHandleColor", ArgumentSemantic.Strong)]
        UIColor TopHandleColor { get; set; }

        // @property (assign, nonatomic) CGFloat maximumInitialDrawerHeight;
        [Export("maximumInitialDrawerHeight")]
        nfloat MaximumInitialDrawerHeight { get; set; }

        // @property (assign, nonatomic) BOOL shouldIncludeSafeAreaInContentHeight;
        [Export("shouldIncludeSafeAreaInContentHeight")]
        bool ShouldIncludeSafeAreaInContentHeight { get; set; }

        // @property (readonly, nonatomic) BOOL contentReachesFullscreen;
        [Export("contentReachesFullscreen")]
        bool ContentReachesFullscreen { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull drawerShadowColor;
        [Export("drawerShadowColor", ArgumentSemantic.Strong)]
        UIColor DrawerShadowColor { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // -(void)setContentOffsetY:(CGFloat)contentOffsetY animated:(BOOL)animated;
        [Export("setContentOffsetY:animated:")]
        void SetContentOffsetY(nfloat contentOffsetY, bool animated);

        // -(void)expandToFullscreenWithDuration:(CGFloat)duration completion:(void (^ _Nullable)(BOOL))completion;
        [Export("expandToFullscreenWithDuration:completion:")]
        void ExpandToFullscreenWithDuration(nfloat duration, [NullAllowed] Action<bool> completion);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBottomDrawerPresentationController * _Nullable, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBottomDrawerPresentationController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCBottomDrawerTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>
    [BaseType(typeof(NSObject))]
    interface MDCBottomDrawerTransitionController : IUIViewControllerAnimatedTransitioning, IUIViewControllerTransitioningDelegate
    {
        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }
    }

    // @interface MDCBottomDrawerViewController : UIViewController <MDCBottomDrawerPresentationControllerDelegate, MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIViewController))]
    interface MDCBottomDrawerViewController : IMDCBottomDrawerPresentationControllerDelegate, IMDCElevatable, IMDCElevationOverriding
    {
        // @property (nonatomic) UIViewController * _Nullable contentViewController;
        [NullAllowed, Export("contentViewController", ArgumentSemantic.Assign)]
        UIViewController ContentViewController { get; set; }

        // @property (nonatomic) UIViewController<MDCBottomDrawerHeader> * _Nullable headerViewController;
        [NullAllowed, Export("headerViewController", ArgumentSemantic.Assign)]
        MDCBottomDrawerHeader HeaderViewController { get; set; }

        // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
        [NullAllowed, Export("trackingScrollView", ArgumentSemantic.Weak)]
        UIScrollView TrackingScrollView { get; set; }

        // @property (readonly, nonatomic) MDCBottomDrawerState drawerState;
        [Export("drawerState")]
        MDCBottomDrawerState DrawerState { get; }

        // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
        [NullAllowed, Export("scrimColor", ArgumentSemantic.Strong)]
        UIColor ScrimColor { get; set; }

        // @property (getter = isTopHandleHidden, assign, nonatomic) BOOL topHandleHidden;
        [Export("topHandleHidden")]
        bool TopHandleHidden { [Bind("isTopHandleHidden")] get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable topHandleColor;
        [NullAllowed, Export("topHandleColor", ArgumentSemantic.Strong)]
        UIColor TopHandleColor { get; set; }

        // @property (assign, nonatomic) CGFloat maximumInitialDrawerHeight;
        [Export("maximumInitialDrawerHeight")]
        nfloat MaximumInitialDrawerHeight { get; set; }

        // @property (assign, nonatomic) BOOL shouldIncludeSafeAreaInContentHeight;
        [Export("shouldIncludeSafeAreaInContentHeight")]
        bool ShouldIncludeSafeAreaInContentHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull drawerShadowColor;
        [Export("drawerShadowColor", ArgumentSemantic.Strong)]
        UIColor DrawerShadowColor { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCBottomDrawerViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCBottomDrawerViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)setTopCornersRadius:(CGFloat)radius forDrawerState:(MDCBottomDrawerState)drawerState;
        [Export("setTopCornersRadius:forDrawerState:")]
        void SetTopCornersRadius(nfloat radius, MDCBottomDrawerState drawerState);

        // -(CGFloat)topCornersRadiusForDrawerState:(MDCBottomDrawerState)drawerState;
        [Export("topCornersRadiusForDrawerState:")]
        nfloat TopCornersRadiusForDrawerState(MDCBottomDrawerState drawerState);

        // -(void)setContentOffsetY:(CGFloat)contentOffsetY animated:(BOOL)animated;
        [Export("setContentOffsetY:animated:")]
        void SetContentOffsetY(nfloat contentOffsetY, bool animated);

        // -(void)expandToFullscreenWithDuration:(CGFloat)duration completion:(void (^ _Nullable)(BOOL))completion;
        [Export("expandToFullscreenWithDuration:completion:")]
        void ExpandToFullscreenWithDuration(nfloat duration, [NullAllowed] Action<bool> completion);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCBottomDrawerViewController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCBottomDrawerViewController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCBottomDrawerViewControllerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCBottomDrawerViewControllerDelegate
    {
        // @required -(void)bottomDrawerControllerDidChangeTopInset:(MDCBottomDrawerViewController * _Nonnull)controller topInset:(CGFloat)topInset;
        [Abstract]
        [Export("bottomDrawerControllerDidChangeTopInset:topInset:")]
        void TopInset(MDCBottomDrawerViewController controller, nfloat topInset);
    }

    // @interface MDCBottomDrawerColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCBottomDrawerColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCBottomDrawerColorThemer)
    [Category]
    [BaseType(typeof(MDCBottomDrawerColorThemer))]
    interface MDCBottomDrawerColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomDrawer:(MDCBottomDrawerViewController * _Nonnull)bottomDrawer;
        [Static]
        [Export("applySemanticColorScheme:toBottomDrawer:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCBottomDrawerViewController bottomDrawer);
    }

    // @interface MDCOverlayWindow : UIWindow
    [BaseType(typeof(UIWindow))]
    interface MDCOverlayWindow
    {
        // -(void)activateOverlay:(UIView *)overlay withLevel:(UIWindowLevel)level;
        [Export("activateOverlay:withLevel:")]
        void ActivateOverlay(UIView overlay, double level);

        // -(void)deactivateOverlay:(UIView *)overlay;
        [Export("deactivateOverlay:")]
        void DeactivateOverlay(UIView overlay);
    }

    // @interface MDCPageControl : UIControl <UIScrollViewDelegate>
    [BaseType(typeof(UIControl))]
    interface MDCPageControl : IUIScrollViewDelegate
    {
        // @property (nonatomic) NSInteger numberOfPages;
        [Export("numberOfPages")]
        nint NumberOfPages { get; set; }

        // @property (nonatomic) NSInteger currentPage;
        [Export("currentPage")]
        nint CurrentPage { get; set; }

        // -(void)setCurrentPage:(NSInteger)currentPage animated:(BOOL)animated;
        [Export("setCurrentPage:animated:")]
        void SetCurrentPage(nint currentPage, bool animated);

        // @property (nonatomic) BOOL hidesForSinglePage;
        [Export("hidesForSinglePage")]
        bool HidesForSinglePage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable pageIndicatorTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("pageIndicatorTintColor", ArgumentSemantic.Strong)]
        UIColor PageIndicatorTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable currentPageIndicatorTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("currentPageIndicatorTintColor", ArgumentSemantic.Strong)]
        UIColor CurrentPageIndicatorTintColor { get; set; }

        // @property (nonatomic) BOOL defersCurrentPageDisplay;
        [Export("defersCurrentPageDisplay")]
        bool DefersCurrentPageDisplay { get; set; }

        // @property (nonatomic) BOOL respectsUserInterfaceLayoutDirection;
        [Export("respectsUserInterfaceLayoutDirection")]
        bool RespectsUserInterfaceLayoutDirection { get; set; }

        // -(void)updateCurrentPageDisplay;
        [Export("updateCurrentPageDisplay")]
        void UpdateCurrentPageDisplay();

        // +(CGSize)sizeForNumberOfPages:(NSInteger)pageCount;
        [Static]
        [Export("sizeForNumberOfPages:")]
        CGSize SizeForNumberOfPages(nint pageCount);

        // -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
        [Export("scrollViewDidScroll:")]
        void ScrollViewDidScroll(UIScrollView scrollView);

        // -(void)scrollViewDidEndDecelerating:(UIScrollView * _Nonnull)scrollView;
        [Export("scrollViewDidEndDecelerating:")]
        void ScrollViewDidEndDecelerating(UIScrollView scrollView);

        // -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
        [Export("scrollViewDidEndScrollingAnimation:")]
        void ScrollViewDidEndScrollingAnimation(UIScrollView scrollView);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCPageControl * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCPageControl, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCPageControlColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCPageControlColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCPageControlColorThemer)
    [Category]
    [BaseType(typeof(MDCPageControlColorThemer))]
    interface MDCPageControlColorThemer_ToBeDeprecated
    {
        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toPageControl:(MDCPageControl * _Nonnull)pageControl;
        [Static]
        [Export("applyColorScheme:toPageControl:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCPageControl pageControl);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint50Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint50Name", "__Internal")]
        NSString MDCPaletteTint50Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint100Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint100Name", "__Internal")]
        NSString MDCPaletteTint100Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint200Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint200Name", "__Internal")]
        NSString MDCPaletteTint200Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint300Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint300Name", "__Internal")]
        NSString MDCPaletteTint300Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint400Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint400Name", "__Internal")]
        NSString MDCPaletteTint400Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint500Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint500Name", "__Internal")]
        NSString MDCPaletteTint500Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint600Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint600Name", "__Internal")]
        NSString MDCPaletteTint600Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint700Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint700Name", "__Internal")]
        NSString MDCPaletteTint700Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint800Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint800Name", "__Internal")]
        NSString MDCPaletteTint800Name { get; }

        // extern MDCPaletteTint  _Nonnull const MDCPaletteTint900Name __attribute__((visibility("default")));
        [Field("MDCPaletteTint900Name", "__Internal")]
        NSString MDCPaletteTint900Name { get; }

        // extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent100Name __attribute__((visibility("default")));
        [Field("MDCPaletteAccent100Name", "__Internal")]
        NSString MDCPaletteAccent100Name { get; }

        // extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent200Name __attribute__((visibility("default")));
        [Field("MDCPaletteAccent200Name", "__Internal")]
        NSString MDCPaletteAccent200Name { get; }

        // extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent400Name __attribute__((visibility("default")));
        [Field("MDCPaletteAccent400Name", "__Internal")]
        NSString MDCPaletteAccent400Name { get; }

        // extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent700Name __attribute__((visibility("default")));
        [Field("MDCPaletteAccent700Name", "__Internal")]
        NSString MDCPaletteAccent700Name { get; }
    }

    // @interface MDCPalette : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCPalette
    {
        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull redPalette;
        [Static]
        [Export("redPalette", ArgumentSemantic.Strong)]
        MDCPalette RedPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull pinkPalette;
        [Static]
        [Export("pinkPalette", ArgumentSemantic.Strong)]
        MDCPalette PinkPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull purplePalette;
        [Static]
        [Export("purplePalette", ArgumentSemantic.Strong)]
        MDCPalette PurplePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull deepPurplePalette;
        [Static]
        [Export("deepPurplePalette", ArgumentSemantic.Strong)]
        MDCPalette DeepPurplePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull indigoPalette;
        [Static]
        [Export("indigoPalette", ArgumentSemantic.Strong)]
        MDCPalette IndigoPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull bluePalette;
        [Static]
        [Export("bluePalette", ArgumentSemantic.Strong)]
        MDCPalette BluePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull lightBluePalette;
        [Static]
        [Export("lightBluePalette", ArgumentSemantic.Strong)]
        MDCPalette LightBluePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull cyanPalette;
        [Static]
        [Export("cyanPalette", ArgumentSemantic.Strong)]
        MDCPalette CyanPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull tealPalette;
        [Static]
        [Export("tealPalette", ArgumentSemantic.Strong)]
        MDCPalette TealPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull greenPalette;
        [Static]
        [Export("greenPalette", ArgumentSemantic.Strong)]
        MDCPalette GreenPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull lightGreenPalette;
        [Static]
        [Export("lightGreenPalette", ArgumentSemantic.Strong)]
        MDCPalette LightGreenPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull limePalette;
        [Static]
        [Export("limePalette", ArgumentSemantic.Strong)]
        MDCPalette LimePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull yellowPalette;
        [Static]
        [Export("yellowPalette", ArgumentSemantic.Strong)]
        MDCPalette YellowPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull amberPalette;
        [Static]
        [Export("amberPalette", ArgumentSemantic.Strong)]
        MDCPalette AmberPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull orangePalette;
        [Static]
        [Export("orangePalette", ArgumentSemantic.Strong)]
        MDCPalette OrangePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull deepOrangePalette;
        [Static]
        [Export("deepOrangePalette", ArgumentSemantic.Strong)]
        MDCPalette DeepOrangePalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull brownPalette;
        [Static]
        [Export("brownPalette", ArgumentSemantic.Strong)]
        MDCPalette BrownPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull greyPalette;
        [Static]
        [Export("greyPalette", ArgumentSemantic.Strong)]
        MDCPalette GreyPalette { get; }

        // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull blueGreyPalette;
        [Static]
        [Export("blueGreyPalette", ArgumentSemantic.Strong)]
        MDCPalette BlueGreyPalette { get; }

        // +(instancetype _Nonnull)paletteGeneratedFromColor:(UIColor * _Nonnull)target500Color;
        [Static]
        [Export("paletteGeneratedFromColor:")]
        MDCPalette PaletteGeneratedFromColor(UIColor target500Color);

        // +(instancetype _Nonnull)paletteWithTints:(NSDictionary<MDCPaletteTint,UIColor *> * _Nonnull)tints accents:(NSDictionary<MDCPaletteAccent,UIColor *> * _Nullable)accents;
        [Static]
        [Export("paletteWithTints:accents:")]
        MDCPalette PaletteWithTints(NSDictionary<NSString, UIColor> tints, [NullAllowed] NSDictionary<NSString, UIColor> accents);

        // -(instancetype _Nonnull)initWithTints:(NSDictionary<MDCPaletteTint,UIColor *> * _Nonnull)tints accents:(NSDictionary<MDCPaletteAccent,UIColor *> * _Nullable)accents;
        [Export("initWithTints:accents:")]
        IntPtr Constructor(NSDictionary<NSString, UIColor> tints, [NullAllowed] NSDictionary<NSString, UIColor> accents);

        // @property (readonly, nonatomic) UIColor * _Nonnull tint50;
        [Export("tint50")]
        UIColor Tint50 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint100;
        [Export("tint100")]
        UIColor Tint100 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint200;
        [Export("tint200")]
        UIColor Tint200 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint300;
        [Export("tint300")]
        UIColor Tint300 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint400;
        [Export("tint400")]
        UIColor Tint400 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint500;
        [Export("tint500")]
        UIColor Tint500 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint600;
        [Export("tint600")]
        UIColor Tint600 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint700;
        [Export("tint700")]
        UIColor Tint700 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint800;
        [Export("tint800")]
        UIColor Tint800 { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tint900;
        [Export("tint900")]
        UIColor Tint900 { get; }

        // @property (readonly, nonatomic) UIColor * _Nullable accent100;
        [NullAllowed, Export("accent100")]
        UIColor Accent100 { get; }

        // @property (readonly, nonatomic) UIColor * _Nullable accent200;
        [NullAllowed, Export("accent200")]
        UIColor Accent200 { get; }

        // @property (readonly, nonatomic) UIColor * _Nullable accent400;
        [NullAllowed, Export("accent400")]
        UIColor Accent400 { get; }

        // @property (readonly, nonatomic) UIColor * _Nullable accent700;
        [NullAllowed, Export("accent700")]
        UIColor Accent700 { get; }
    }

    // @interface MDCProgressView : UIView
    [BaseType(typeof(UIView))]
    interface MDCProgressView
    {
        // @property (nonatomic, strong) UIColor * _Null_unspecified progressTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("progressTintColor", ArgumentSemantic.Strong)]
        UIColor ProgressTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified trackTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("trackTintColor", ArgumentSemantic.Strong)]
        UIColor TrackTintColor { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; set; }

        // @property (assign, nonatomic) MDCProgressViewBackwardAnimationMode backwardProgressAnimationMode;
        [Export("backwardProgressAnimationMode", ArgumentSemantic.Assign)]
        MDCProgressViewBackwardAnimationMode BackwardProgressAnimationMode { get; set; }

        // -(void)setProgress:(float)progress animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("setProgress:animated:completion:")]
        void SetProgress(float progress, bool animated, [NullAllowed] Action<bool> completion);

        // -(void)setHidden:(BOOL)hidden animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("setHidden:animated:completion:")]
        void SetHidden(bool hidden, bool animated, [NullAllowed] Action<bool> completion);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCProgressView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCProgressView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCProgressViewColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCProgressViewColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCProgressViewColorThemer)
    [Category]
    [BaseType(typeof(MDCProgressViewColorThemer))]
    interface MDCProgressViewColorThemer_ToBeDeprecated
    {
        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toProgressView:(MDCProgressView * _Nonnull)progressView;
        [Static]
        [Export("applyColorScheme:toProgressView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCProgressView progressView);
    }

    // @interface MaterialTheming (MDCProgressView)
    [Category]
    [BaseType(typeof(MDCProgressView))]
    interface MDCProgressView_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCSlider : UIControl <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIControl))]
    interface MDCSlider : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (getter = isStatefulAPIEnabled, assign, nonatomic) BOOL statefulAPIEnabled;
        [Export("statefulAPIEnabled")]
        bool StatefulAPIEnabled { [Bind("isStatefulAPIEnabled")] get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCSliderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCSliderDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)setThumbColor:(UIColor * _Nullable)thumbColor forState:(UIControlState)state;
        [Export("setThumbColor:forState:")]
        void SetThumbColor([NullAllowed] UIColor thumbColor, UIControlState state);

        // -(UIColor * _Nullable)thumbColorForState:(UIControlState)state;
        [Export("thumbColorForState:")]
        [return: NullAllowed]
        UIColor ThumbColorForState(UIControlState state);

        // -(void)setTrackFillColor:(UIColor * _Nullable)fillColor forState:(UIControlState)state;
        [Export("setTrackFillColor:forState:")]
        void SetTrackFillColor([NullAllowed] UIColor fillColor, UIControlState state);

        // -(UIColor * _Nullable)trackFillColorForState:(UIControlState)state;
        [Export("trackFillColorForState:")]
        [return: NullAllowed]
        UIColor TrackFillColorForState(UIControlState state);

        // -(void)setTrackBackgroundColor:(UIColor * _Nullable)backgroundColor forState:(UIControlState)state;
        [Export("setTrackBackgroundColor:forState:")]
        void SetTrackBackgroundColor([NullAllowed] UIColor backgroundColor, UIControlState state);

        // -(UIColor * _Nullable)trackBackgroundColorForState:(UIControlState)state;
        [Export("trackBackgroundColorForState:")]
        [return: NullAllowed]
        UIColor TrackBackgroundColorForState(UIControlState state);

        // -(void)setFilledTrackTickColor:(UIColor * _Nullable)tickColor forState:(UIControlState)state;
        [Export("setFilledTrackTickColor:forState:")]
        void SetFilledTrackTickColor([NullAllowed] UIColor tickColor, UIControlState state);

        // -(UIColor * _Nullable)filledTrackTickColorForState:(UIControlState)state;
        [Export("filledTrackTickColorForState:")]
        [return: NullAllowed]
        UIColor FilledTrackTickColorForState(UIControlState state);

        // -(void)setBackgroundTrackTickColor:(UIColor * _Nullable)tickColor forState:(UIControlState)state;
        [Export("setBackgroundTrackTickColor:forState:")]
        void SetBackgroundTrackTickColor([NullAllowed] UIColor tickColor, UIControlState state);

        // -(UIColor * _Nullable)backgroundTrackTickColorForState:(UIControlState)state;
        [Export("backgroundTrackTickColorForState:")]
        [return: NullAllowed]
        UIColor BackgroundTrackTickColorForState(UIControlState state);

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rippleColor;
        [NullAllowed, Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (assign, nonatomic) CGFloat thumbRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbRadius")]
        nfloat ThumbRadius { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation thumbElevation __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbElevation")]
        double ThumbElevation { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull thumbShadowColor;
        [Export("thumbShadowColor", ArgumentSemantic.Strong)]
        UIColor ThumbShadowColor { get; set; }

        // @property (assign, nonatomic) NSUInteger numberOfDiscreteValues;
        [Export("numberOfDiscreteValues")]
        nuint NumberOfDiscreteValues { get; set; }

        // @property (assign, nonatomic) CGFloat value;
        [Export("value")]
        nfloat Value { get; set; }

        // -(void)setValue:(CGFloat)value animated:(BOOL)animated;
        [Export("setValue:animated:")]
        void SetValue(nfloat value, bool animated);

        // @property (assign, nonatomic) CGFloat minimumValue;
        [Export("minimumValue")]
        nfloat MinimumValue { get; set; }

        // @property (assign, nonatomic) CGFloat maximumValue;
        [Export("maximumValue")]
        nfloat MaximumValue { get; set; }

        // @property (getter = isContinuous, assign, nonatomic) BOOL continuous;
        [Export("continuous")]
        bool Continuous { [Bind("isContinuous")] get; set; }

        // @property (assign, nonatomic) CGFloat filledTrackAnchorValue;
        [Export("filledTrackAnchorValue")]
        nfloat FilledTrackAnchorValue { get; set; }

        // @property (assign, nonatomic) BOOL shouldDisplayDiscreteValueLabel;
        [Export("shouldDisplayDiscreteValueLabel")]
        bool ShouldDisplayDiscreteValueLabel { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelTextColor;
        [Export("valueLabelTextColor", ArgumentSemantic.Strong)]
        UIColor ValueLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelBackgroundColor;
        [Export("valueLabelBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ValueLabelBackgroundColor { get; set; }

        // @property (getter = isThumbHollowAtStart, assign, nonatomic) BOOL thumbHollowAtStart;
        [Export("thumbHollowAtStart")]
        bool ThumbHollowAtStart { [Bind("isThumbHollowAtStart")] get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCSlider * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCSlider, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified disabledColor __attribute__((annotate("ui_appearance_selector")));
        [Export("disabledColor", ArgumentSemantic.Strong)]
        UIColor DisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified color __attribute__((annotate("ui_appearance_selector")));
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified trackBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("trackBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TrackBackgroundColor { get; set; }

        // @property (assign, nonatomic) BOOL hapticsEnabled;
        [Export("hapticsEnabled")]
        bool HapticsEnabled { get; set; }

        // @property (assign, nonatomic) BOOL shouldEnableHapticsForAllDiscreteValues;
        [Export("shouldEnableHapticsForAllDiscreteValues")]
        bool ShouldEnableHapticsForAllDiscreteValues { get; set; }
    }

    // @interface ToBeDeprecated (MDCSlider)
    [Category]
    [BaseType(typeof(MDCSlider))]
    interface MDCSlider_ToBeDeprecated
    {
        // @property (nonatomic, strong) UIColor * _Nullable inkColor;
        [NullAllowed, Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }
    }

    // @protocol MDCSliderDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCSliderDelegate
    {
        // @optional -(BOOL)slider:(MDCSlider * _Nonnull)slider shouldJumpToValue:(CGFloat)value;
        [Export("slider:shouldJumpToValue:")]
        bool Slider(MDCSlider slider, nfloat value);

        // @optional -(NSString * _Nonnull)slider:(MDCSlider * _Nonnull)slider displayedStringForValue:(CGFloat)value;
        [Export("slider:displayedStringForValue:")]
        string Slider(MDCSlider slider, nfloat value);

        // @optional -(NSString * _Nonnull)slider:(MDCSlider * _Nonnull)slider accessibilityLabelForValue:(CGFloat)value;
        [Export("slider:accessibilityLabelForValue:")]
        string Slider(MDCSlider slider, nfloat value);
    }

    // @interface MDCSliderColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCSliderColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCSliderColorThemer)
    [Category]
    [BaseType(typeof(MDCSliderColorThemer))]
    interface MDCSliderColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toSlider:(MDCSlider * _Nonnull)slider;
        [Static]
        [Export("applySemanticColorScheme:toSlider:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCSlider slider);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toSlider:(MDCSlider * _Nonnull)slider;
        [Static]
        [Export("applyColorScheme:toSlider:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCSlider slider);

        // +(MDCBasicColorScheme * _Nonnull)defaultSliderLightColorScheme;
        [Static]
        [Export("defaultSliderLightColorScheme")]
        [Verify(MethodToProperty)]
        MDCBasicColorScheme DefaultSliderLightColorScheme { get; }

        // +(MDCBasicColorScheme * _Nonnull)defaultSliderDarkColorScheme;
        [Static]
        [Export("defaultSliderDarkColorScheme")]
        [Verify(MethodToProperty)]
        MDCBasicColorScheme DefaultSliderDarkColorScheme { get; }
    }

    // @protocol MDCSnackbarManagerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarManagerDelegate
    {
        // @required -(void)willPresentSnackbarWithMessageView:(MDCSnackbarMessageView * _Nullable)messageView;
        [Abstract]
        [Export("willPresentSnackbarWithMessageView:")]
        void WillPresentSnackbarWithMessageView([NullAllowed] MDCSnackbarMessageView messageView);
    }

    // @interface MDCSnackbarManager : NSObject <MDCElevationOverriding>
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarManager : IMDCElevationOverriding
    {
        // @property (readonly, nonatomic, strong, class) MDCSnackbarManager * _Nonnull defaultManager;
        [Static]
        [Export("defaultManager", ArgumentSemantic.Strong)]
        MDCSnackbarManager DefaultManager { get; }

        // @property (assign, nonatomic) MDCSnackbarAlignment alignment;
        [Export("alignment", ArgumentSemantic.Assign)]
        MDCSnackbarAlignment Alignment { get; set; }

        // -(void)showMessage:(MDCSnackbarMessage * _Nullable)message;
        [Export("showMessage:")]
        void ShowMessage([NullAllowed] MDCSnackbarMessage message);

        // -(void)setPresentationHostView:(UIView * _Nullable)hostView;
        [Export("setPresentationHostView:")]
        void SetPresentationHostView([NullAllowed] UIView hostView);

        // -(BOOL)hasMessagesShowingOrQueued;
        [Export("hasMessagesShowingOrQueued")]
        [Verify(MethodToProperty)]
        bool HasMessagesShowingOrQueued { get; }

        // -(void)dismissAndCallCompletionBlocksWithCategory:(NSString * _Nullable)category;
        [Export("dismissAndCallCompletionBlocksWithCategory:")]
        void DismissAndCallCompletionBlocksWithCategory([NullAllowed] string category);

        // -(void)setBottomOffset:(CGFloat)offset;
        [Export("setBottomOffset:")]
        void SetBottomOffset(nfloat offset);

        // -(id<MDCSnackbarSuspensionToken> _Nullable)suspendAllMessages;
        [NullAllowed, Export("suspendAllMessages")]
        [Verify(MethodToProperty)]
        MDCSnackbarSuspensionToken SuspendAllMessages { get; }

        // -(id<MDCSnackbarSuspensionToken> _Nullable)suspendMessagesWithCategory:(NSString * _Nullable)category;
        [Export("suspendMessagesWithCategory:")]
        [return: NullAllowed]
        MDCSnackbarSuspensionToken SuspendMessagesWithCategory([NullAllowed] string category);

        // -(void)resumeMessagesWithToken:(id<MDCSnackbarSuspensionToken> _Nullable)token;
        [Export("resumeMessagesWithToken:")]
        void ResumeMessagesWithToken([NullAllowed] MDCSnackbarSuspensionToken token);

        // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewBackgroundColor;
        [NullAllowed, Export("snackbarMessageViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewShadowColor;
        [NullAllowed, Export("snackbarMessageViewShadowColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewShadowColor { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation messageElevation;
        [Export("messageElevation")]
        double MessageElevation { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable messageTextColor;
        [NullAllowed, Export("messageTextColor", ArgumentSemantic.Strong)]
        UIColor MessageTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable messageFont;
        [NullAllowed, Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable buttonFont;
        [NullAllowed, Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (assign, nonatomic) BOOL uppercaseButtonTitle;
        [Export("uppercaseButtonTitle")]
        bool UppercaseButtonTitle { get; set; }

        // @property (nonatomic) CGFloat disabledButtonAlpha;
        [Export("disabledButtonAlpha")]
        nfloat DisabledButtonAlpha { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonInkColor;
        [NullAllowed, Export("buttonInkColor", ArgumentSemantic.Strong)]
        UIColor ButtonInkColor { get; set; }

        // @property (assign, nonatomic) BOOL shouldApplyStyleChangesToVisibleSnackbars;
        [Export("shouldApplyStyleChangesToVisibleSnackbars")]
        bool ShouldApplyStyleChangesToVisibleSnackbars { get; set; }

        // -(UIColor * _Nullable)buttonTitleColorForState:(UIControlState)state;
        [Export("buttonTitleColorForState:")]
        [return: NullAllowed]
        UIColor ButtonTitleColorForState(UIControlState state);

        // -(void)setButtonTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state;
        [Export("setButtonTitleColor:forState:")]
        void SetButtonTitleColor([NullAllowed] UIColor titleColor, UIControlState state);

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable;
        [Export("adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable")]
        bool AdjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable { get; set; }

        // @property (assign, nonatomic) BOOL shouldEnableAccessibilityViewIsModal;
        [Export("shouldEnableAccessibilityViewIsModal")]
        bool ShouldEnableAccessibilityViewIsModal { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCSnackbarManagerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCSnackbarManagerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCSnackbarMessageView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlockForMessageView;
        [NullAllowed, Export("traitCollectionDidChangeBlockForMessageView", ArgumentSemantic.Copy)]
        Action<MDCSnackbarMessageView, UITraitCollection> TraitCollectionDidChangeBlockForMessageView { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(id<MDCElevatable> _Nonnull, CGFloat) mdc_elevationDidChangeBlockForMessageView;
        [NullAllowed, Export("mdc_elevationDidChangeBlockForMessageView", ArgumentSemantic.Copy)]
        Action<MDCElevatable, nfloat> Mdc_elevationDidChangeBlockForMessageView { get; set; }
    }

    // @protocol MDCSnackbarSuspensionToken <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarSuspensionToken
    {
    }

    // @interface LegacyAPI (MDCSnackbarManager)
    [Category]
    [BaseType(typeof(MDCSnackbarManager))]
    interface MDCSnackbarManager_LegacyAPI
    {
        // @property (assign, nonatomic, class) MDCSnackbarAlignment alignment;
        [Static]
        [Export("alignment", ArgumentSemantic.Assign)]
        MDCSnackbarAlignment Alignment { get; set; }

        // +(void)showMessage:(MDCSnackbarMessage * _Nullable)message;
        [Static]
        [Export("showMessage:")]
        void ShowMessage([NullAllowed] MDCSnackbarMessage message);

        // +(void)setPresentationHostView:(UIView * _Nullable)hostView;
        [Static]
        [Export("setPresentationHostView:")]
        void SetPresentationHostView([NullAllowed] UIView hostView);

        // +(BOOL)hasMessagesShowingOrQueued;
        [Static]
        [Export("hasMessagesShowingOrQueued")]
        [Verify(MethodToProperty)]
        bool HasMessagesShowingOrQueued { get; }

        // +(void)dismissAndCallCompletionBlocksWithCategory:(NSString * _Nullable)category;
        [Static]
        [Export("dismissAndCallCompletionBlocksWithCategory:")]
        void DismissAndCallCompletionBlocksWithCategory([NullAllowed] string category);

        // +(void)setBottomOffset:(CGFloat)offset;
        [Static]
        [Export("setBottomOffset:")]
        void SetBottomOffset(nfloat offset);

        // +(id<MDCSnackbarSuspensionToken> _Nullable)suspendAllMessages;
        [Static]
        [NullAllowed, Export("suspendAllMessages")]
        [Verify(MethodToProperty)]
        MDCSnackbarSuspensionToken SuspendAllMessages { get; }

        // +(id<MDCSnackbarSuspensionToken> _Nullable)suspendMessagesWithCategory:(NSString * _Nullable)category;
        [Static]
        [Export("suspendMessagesWithCategory:")]
        [return: NullAllowed]
        MDCSnackbarSuspensionToken SuspendMessagesWithCategory([NullAllowed] string category);

        // +(void)resumeMessagesWithToken:(id<MDCSnackbarSuspensionToken> _Nullable)token;
        [Static]
        [Export("resumeMessagesWithToken:")]
        void ResumeMessagesWithToken([NullAllowed] MDCSnackbarSuspensionToken token);

        // @property (nonatomic, strong, class) UIColor * _Nullable snackbarMessageViewBackgroundColor;
        [Static]
        [NullAllowed, Export("snackbarMessageViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewBackgroundColor { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nullable snackbarMessageViewShadowColor;
        [Static]
        [NullAllowed, Export("snackbarMessageViewShadowColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewShadowColor { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nullable messageTextColor;
        [Static]
        [NullAllowed, Export("messageTextColor", ArgumentSemantic.Strong)]
        UIColor MessageTextColor { get; set; }

        // @property (nonatomic, strong, class) UIFont * _Nullable messageFont;
        [Static]
        [NullAllowed, Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong, class) UIFont * _Nullable buttonFont;
        [Static]
        [NullAllowed, Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (assign, nonatomic, class) BOOL shouldApplyStyleChangesToVisibleSnackbars;
        [Static]
        [Export("shouldApplyStyleChangesToVisibleSnackbars")]
        bool ShouldApplyStyleChangesToVisibleSnackbars { get; set; }

        // +(UIColor * _Nullable)buttonTitleColorForState:(UIControlState)state;
        [Static]
        [Export("buttonTitleColorForState:")]
        [return: NullAllowed]
        UIColor ButtonTitleColorForState(UIControlState state);

        // +(void)setButtonTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state;
        [Static]
        [Export("setButtonTitleColor:forState:")]
        void SetButtonTitleColor([NullAllowed] UIColor titleColor, UIControlState state);

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:, class) BOOL mdc_adjustsFontForContentSizeCategory;
        [Static]
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        [Wrap("WeakDelegate"), Static]
        [NullAllowed]
        MDCSnackbarManagerDelegate Delegate { get; set; }

        // @property (nonatomic, weak, class) id<MDCSnackbarManagerDelegate> _Nullable delegate;
        [Static]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    // typedef void (^MDCSnackbarMessageCompletionHandler)(BOOL);
    delegate void MDCSnackbarMessageCompletionHandler(bool arg0);

    // typedef void (^MDCSnackbarMessageActionHandler)();
    delegate void MDCSnackbarMessageActionHandler();

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const NSTimeInterval MDCSnackbarMessageDurationMax;
        [Field("MDCSnackbarMessageDurationMax", "__Internal")]
        double MDCSnackbarMessageDurationMax { get; }

        // extern NSString *const _Nonnull MDCSnackbarMessageBoldAttributeName;
        [Field("MDCSnackbarMessageBoldAttributeName", "__Internal")]
        NSString MDCSnackbarMessageBoldAttributeName { get; }
    }

    // @interface MDCSnackbarMessage : NSObject <NSCopying, UIAccessibilityIdentification>
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarMessage : INSCopying, IUIAccessibilityIdentification
    {
        // +(instancetype _Nonnull)messageWithText:(NSString * _Nonnull)text;
        [Static]
        [Export("messageWithText:")]
        MDCSnackbarMessage MessageWithText(string text);

        // +(instancetype _Nonnull)messageWithAttributedText:(NSAttributedString * _Nonnull)attributedText;
        [Static]
        [Export("messageWithAttributedText:")]
        MDCSnackbarMessage MessageWithAttributedText(NSAttributedString attributedText);

        // @property (assign, nonatomic, class) BOOL usesLegacySnackbar;
        [Static]
        [Export("usesLegacySnackbar")]
        bool UsesLegacySnackbar { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
        [NullAllowed, Export("attributedText", ArgumentSemantic.Copy)]
        NSAttributedString AttributedText { get; set; }

        // @property (nonatomic, strong) MDCSnackbarMessageAction * _Nullable action;
        [NullAllowed, Export("action", ArgumentSemantic.Strong)]
        MDCSnackbarMessageAction Action { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonTextColor __attribute__((deprecated("Use MDCSnackbarMessageView's buttonTitleColorForState: instead.")));
        [NullAllowed, Export("buttonTextColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextColor { get; set; }

        // @property (assign, nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; set; }

        // @property (copy, nonatomic) MDCSnackbarMessageCompletionHandler _Nullable completionHandler;
        [NullAllowed, Export("completionHandler", ArgumentSemantic.Copy)]
        MDCSnackbarMessageCompletionHandler CompletionHandler { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
        [NullAllowed, Export("accessibilityLabel")]
        string AccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
        [NullAllowed, Export("accessibilityHint")]
        string AccessibilityHint { get; set; }

        // @property (readonly, nonatomic) NSString * _Nullable voiceNotificationText;
        [NullAllowed, Export("voiceNotificationText")]
        string VoiceNotificationText { get; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }
    }

    // @interface MDCSnackbarMessageAction : NSObject <UIAccessibilityIdentification, NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarMessageAction : IUIAccessibilityIdentification, INSCopying
    {
        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) MDCSnackbarMessageActionHandler _Nullable handler;
        [NullAllowed, Export("handler", ArgumentSemantic.Copy)]
        MDCSnackbarMessageActionHandler Handler { get; set; }
    }

    // @interface MDCSnackbarMessageView : UIView <MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCSnackbarMessageView : IMDCElevatable, IMDCElevationOverriding
    {
        // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("snackbarMessageViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewShadowColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("snackbarMessageViewShadowColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewShadowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable messageTextColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("messageTextColor", ArgumentSemantic.Strong)]
        UIColor MessageTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable messageFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("messageFont", ArgumentSemantic.Strong)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable buttonFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) NSMutableArray<MDCButton *> * _Nullable actionButtons;
        [NullAllowed, Export("actionButtons", ArgumentSemantic.Strong)]
        NSMutableArray<MDCButton> ActionButtons { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
        [NullAllowed, Export("accessibilityLabel")]
        string AccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
        [NullAllowed, Export("accessibilityHint")]
        string AccessibilityHint { get; set; }

        // -(UIColor * _Nullable)buttonTitleColorForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("buttonTitleColorForState:")]
        [return: NullAllowed]
        UIColor ButtonTitleColorForState(UIControlState state);

        // -(void)setButtonTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
        [Export("setButtonTitleColor:forState:")]
        void SetButtonTitleColor([NullAllowed] UIColor titleColor, UIControlState state);

        // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
        [Export("mdc_adjustsFontForContentSizeCategory")]
        bool Mdc_adjustsFontForContentSizeCategory { get; [Bind("mdc_setAdjustsFontForContentSizeCategory:")] set; }

        // @property (assign, nonatomic) BOOL adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable;
        [Export("adjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable")]
        bool AdjustsFontForContentSizeCategoryWhenScaledFontIsUnavailable { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(MDCSnackbarMessageView * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCSnackbarMessageView, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface  (MDCSnackbarMessageView)
    [Category]
    [BaseType(typeof(MDCSnackbarMessageView))]
    interface MDCSnackbarMessageView_
    {
        // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewTextColor __attribute__((annotate("ui_appearance_selector"))) __attribute__((deprecated("Use messsageTextColor instead.")));
        [NullAllowed, Export("snackbarMessageViewTextColor", ArgumentSemantic.Strong)]
        UIColor SnackbarMessageViewTextColor { get; set; }
    }

    // @interface MDCSnackbarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarColorThemer
    {
    }

    // @interface Deprecated (MDCSnackbarColorThemer)
    [Category]
    [BaseType(typeof(MDCSnackbarColorThemer))]
    interface MDCSnackbarColorThemer_Deprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme;
        [Static]
        [Export("applySemanticColorScheme:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toSnackbarManager:(MDCSnackbarManager * _Nonnull)snackbarManager;
        [Static]
        [Export("applySemanticColorScheme:toSnackbarManager:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCSnackbarManager snackbarManager);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toSnackbarMessageView:(MDCSnackbarMessageView * _Nonnull)snackbarMessageView __attribute__((deprecated("use applySemanticColorScheme: instead.")));
        [Static]
        [Export("applyColorScheme:toSnackbarMessageView:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCSnackbarMessageView snackbarMessageView);
    }

    // @interface MDCSnackbarFontThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarFontThemer
    {
    }

    // @interface Deprecated (MDCSnackbarFontThemer)
    [Category]
    [BaseType(typeof(MDCSnackbarFontThemer))]
    interface MDCSnackbarFontThemer_Deprecated
    {
        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toSnackbarMessageView:(MDCSnackbarMessageView * _Nonnull)snackbarMessageView;
        [Static]
        [Export("applyFontScheme:toSnackbarMessageView:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, MDCSnackbarMessageView snackbarMessageView);

        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme;
        [Static]
        [Export("applyFontScheme:")]
        void ApplyFontScheme(MDCFontScheme fontScheme);
    }

    // @interface MDCSnackbarTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCSnackbarTypographyThemer
    {
    }

    // @interface Deprecated (MDCSnackbarTypographyThemer)
    [Category]
    [BaseType(typeof(MDCSnackbarTypographyThemer))]
    interface MDCSnackbarTypographyThemer_Deprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme;
        [Static]
        [Export("applyTypographyScheme:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme);
    }

    // @interface MDCTabBar : UIView <UIBarPositioning, MDCElevatable, MDCElevationOverriding>
    [BaseType(typeof(UIView))]
    interface MDCTabBar : IUIBarPositioning, IMDCElevatable, IMDCElevationOverriding
    {
        // +(CGFloat)defaultHeightForBarPosition:(UIBarPosition)position itemAppearance:(MDCTabBarItemAppearance)appearance;
        [Static]
        [Export("defaultHeightForBarPosition:itemAppearance:")]
        nfloat DefaultHeightForBarPosition(UIBarPosition position, MDCTabBarItemAppearance appearance);

        // +(CGFloat)defaultHeightForItemAppearance:(MDCTabBarItemAppearance)appearance;
        [Static]
        [Export("defaultHeightForItemAppearance:")]
        nfloat DefaultHeightForItemAppearance(MDCTabBarItemAppearance appearance);

        // @property (copy, nonatomic) NSArray<UITabBarItem *> * _Nonnull items;
        [Export("items", ArgumentSemantic.Copy)]
        UITabBarItem[] Items { get; set; }

        // @property (nonatomic, strong) UITabBarItem * _Nullable selectedItem;
        [NullAllowed, Export("selectedItem", ArgumentSemantic.Strong)]
        UITabBarItem SelectedItem { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCTabBarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCTabBarDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (nonatomic) UIColor * _Nullable selectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("selectedItemTintColor", ArgumentSemantic.Assign)]
        UIColor SelectedItemTintColor { get; set; }

        // @property (nonatomic) UIColor * _Nonnull unselectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
        [Export("unselectedItemTintColor", ArgumentSemantic.Assign)]
        UIColor UnselectedItemTintColor { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic) UIColor * _Nonnull rippleColor;
        [Export("rippleColor", ArgumentSemantic.Assign)]
        UIColor RippleColor { get; set; }

        // @property (nonatomic) UIColor * _Nonnull bottomDividerColor;
        [Export("bottomDividerColor", ArgumentSemantic.Assign)]
        UIColor BottomDividerColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull selectedItemTitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("selectedItemTitleFont", ArgumentSemantic.Strong)]
        UIFont SelectedItemTitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull unselectedItemTitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("unselectedItemTitleFont", ArgumentSemantic.Strong)]
        UIFont UnselectedItemTitleFont { get; set; }

        // @property (nonatomic) UIColor * _Nullable barTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("barTintColor", ArgumentSemantic.Assign)]
        UIColor BarTintColor { get; set; }

        // @property (nonatomic) MDCTabBarAlignment alignment;
        [Export("alignment", ArgumentSemantic.Assign)]
        MDCTabBarAlignment Alignment { get; set; }

        // @property (nonatomic) MDCTabBarItemAppearance itemAppearance;
        [Export("itemAppearance", ArgumentSemantic.Assign)]
        MDCTabBarItemAppearance ItemAppearance { get; set; }

        // @property (nonatomic) BOOL displaysUppercaseTitles;
        [Export("displaysUppercaseTitles")]
        bool DisplaysUppercaseTitles { get; set; }

        // @property (nonatomic) MDCTabBarTextTransform titleTextTransform __attribute__((annotate("ui_appearance_selector")));
        [Export("titleTextTransform", ArgumentSemantic.Assign)]
        MDCTabBarTextTransform TitleTextTransform { get; set; }

        // @property (nonatomic) id<MDCTabBarIndicatorTemplate> _Null_unspecified selectionIndicatorTemplate __attribute__((annotate("ui_appearance_selector")));
        [Export("selectionIndicatorTemplate", ArgumentSemantic.Assign)]
        MDCTabBarIndicatorTemplate SelectionIndicatorTemplate { get; set; }

        // -(void)setSelectedItem:(UITabBarItem * _Nullable)selectedItem animated:(BOOL)animated;
        [Export("setSelectedItem:animated:")]
        void SetSelectedItem([NullAllowed] UITabBarItem selectedItem, bool animated);

        // -(void)setAlignment:(MDCTabBarAlignment)alignment animated:(BOOL)animated;
        [Export("setAlignment:animated:")]
        void SetAlignment(MDCTabBarAlignment alignment, bool animated);

        // -(void)setTitleColor:(UIColor * _Nullable)color forState:(MDCTabBarItemState)state;
        [Export("setTitleColor:forState:")]
        void SetTitleColor([NullAllowed] UIColor color, MDCTabBarItemState state);

        // -(UIColor * _Nullable)titleColorForState:(MDCTabBarItemState)state;
        [Export("titleColorForState:")]
        [return: NullAllowed]
        UIColor TitleColorForState(MDCTabBarItemState state);

        // -(void)setImageTintColor:(UIColor * _Nullable)color forState:(MDCTabBarItemState)state;
        [Export("setImageTintColor:forState:")]
        void SetImageTintColor([NullAllowed] UIColor color, MDCTabBarItemState state);

        // -(UIColor * _Nullable)imageTintColorForState:(MDCTabBarItemState)state;
        [Export("imageTintColorForState:")]
        [return: NullAllowed]
        UIColor ImageTintColorForState(MDCTabBarItemState state);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCTabBar * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCTabBar, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @interface MDCAccessibility (MDCTabBar)
    [Category]
    [BaseType(typeof(MDCTabBar))]
    interface MDCTabBar_MDCAccessibility
    {
        // -(id _Nullable)accessibilityElementForItem:(UITabBarItem * _Nonnull)item;
        [Export("accessibilityElementForItem:")]
        [return: NullAllowed]
        NSObject AccessibilityElementForItem(UITabBarItem item);
    }

    // @protocol MDCTabBarDelegate <UIBarPositioningDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCTabBarDelegate : IUIBarPositioningDelegate
    {
        // @optional -(BOOL)tabBar:(MDCTabBar * _Nonnull)tabBar shouldSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("tabBar:shouldSelectItem:")]
        bool TabBar(MDCTabBar tabBar, UITabBarItem item);

        // @optional -(void)tabBar:(MDCTabBar * _Nonnull)tabBar willSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("tabBar:willSelectItem:")]
        void TabBar(MDCTabBar tabBar, UITabBarItem item);

        // @optional -(void)tabBar:(MDCTabBar * _Nonnull)tabBar didSelectItem:(UITabBarItem * _Nonnull)item;
        [Export("tabBar:didSelectItem:")]
        void TabBar(MDCTabBar tabBar, UITabBarItem item);
    }

    // @interface ToBeDeprecated (MDCTabBar)
    [Category]
    [BaseType(typeof(MDCTabBar))]
    interface MDCTabBar_ToBeDeprecated
    {
        // @property (nonatomic) UIColor * _Nonnull inkColor __attribute__((annotate("ui_appearance_selector")));
        [Export("inkColor", ArgumentSemantic.Assign)]
        UIColor InkColor { get; set; }
    }

    // @interface MDCTabBarIndicatorAttributes : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface MDCTabBarIndicatorAttributes : INSCopying
    {
        // @property (nonatomic) UIBezierPath * _Nullable path;
        [NullAllowed, Export("path", ArgumentSemantic.Assign)]
        UIBezierPath Path { get; set; }
    }

    // @protocol MDCTabBarIndicatorContext <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTabBarIndicatorContext
    {
        // @required @property (readonly, nonatomic) UITabBarItem * _Nonnull item;
        [Abstract]
        [Export("item")]
        UITabBarItem Item { get; }

        // @required @property (readonly, nonatomic) CGRect bounds;
        [Abstract]
        [Export("bounds")]
        CGRect Bounds { get; }

        // @required @property (readonly, nonatomic) CGRect contentFrame;
        [Abstract]
        [Export("contentFrame")]
        CGRect ContentFrame { get; }
    }

    // @protocol MDCTabBarIndicatorTemplate <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTabBarIndicatorTemplate
    {
        // @required -(MDCTabBarIndicatorAttributes * _Nonnull)indicatorAttributesForContext:(id<MDCTabBarIndicatorContext> _Nonnull)context;
        [Abstract]
        [Export("indicatorAttributesForContext:")]
        MDCTabBarIndicatorAttributes IndicatorAttributesForContext(MDCTabBarIndicatorContext context);
    }

    // @interface MDCTabBarUnderlineIndicatorTemplate : NSObject <MDCTabBarIndicatorTemplate>
    [BaseType(typeof(NSObject))]
    interface MDCTabBarUnderlineIndicatorTemplate : IMDCTabBarIndicatorTemplate
    {
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat MDCTabBarViewControllerAnimationDuration;
        [Field("MDCTabBarViewControllerAnimationDuration", "__Internal")]
        nfloat MDCTabBarViewControllerAnimationDuration { get; }
    }

    // @interface MDCTabBarViewController : UIViewController <MDCTabBarDelegate, UIBarPositioningDelegate>
    [BaseType(typeof(UIViewController))]
    interface MDCTabBarViewController : IMDCTabBarDelegate, IUIBarPositioningDelegate
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCTabBarControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCTabBarControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSArray<UIViewController *> * _Nonnull viewControllers;
        [Export("viewControllers", ArgumentSemantic.Copy)]
        UIViewController[] ViewControllers { get; set; }

        // @property (nonatomic, weak) UIViewController * _Nullable selectedViewController;
        [NullAllowed, Export("selectedViewController", ArgumentSemantic.Weak)]
        UIViewController SelectedViewController { get; set; }

        // @property (readonly, nonatomic) MDCTabBar * _Nullable tabBar;
        [NullAllowed, Export("tabBar")]
        MDCTabBar TabBar { get; }

        // @property (nonatomic) BOOL tabBarHidden;
        [Export("tabBarHidden")]
        bool TabBarHidden { get; set; }

        // -(void)setTabBarHidden:(BOOL)hidden animated:(BOOL)animated;
        [Export("setTabBarHidden:animated:")]
        void SetTabBarHidden(bool hidden, bool animated);

        // @property (copy, nonatomic) void (^ _Nullable)(MDCTabBarViewController * _Nonnull, UITraitCollection * _Nullable) traitCollectionDidChangeBlock;
        [NullAllowed, Export("traitCollectionDidChangeBlock", ArgumentSemantic.Copy)]
        Action<MDCTabBarViewController, UITraitCollection> TraitCollectionDidChangeBlock { get; set; }
    }

    // @protocol MDCTabBarControllerDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCTabBarControllerDelegate
    {
        // @optional -(BOOL)tabBarController:(MDCTabBarViewController * _Nonnull)tabBarController shouldSelectViewController:(UIViewController * _Nonnull)viewController;
        [Export("tabBarController:shouldSelectViewController:")]
        bool TabBarController(MDCTabBarViewController tabBarController, UIViewController viewController);

        // @optional -(void)tabBarController:(MDCTabBarViewController * _Nonnull)tabBarController didSelectViewController:(UIViewController * _Nonnull)viewController;
        [Export("tabBarController:didSelectViewController:")]
        void TabBarController(MDCTabBarViewController tabBarController, UIViewController viewController);
    }

    // @protocol MDCTabBarDisplayDelegate
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCTabBarDisplayDelegate
    {
        // @required -(void)tabBar:(MDCTabBar * _Nonnull)tabBar willDisplayItem:(UITabBarItem * _Nonnull)item;
        [Abstract]
        [Export("tabBar:willDisplayItem:")]
        void WillDisplayItem(MDCTabBar tabBar, UITabBarItem item);

        // @required -(void)tabBar:(MDCTabBar * _Nonnull)tabBar didEndDisplayingItem:(UITabBarItem * _Nonnull)item;
        [Abstract]
        [Export("tabBar:didEndDisplayingItem:")]
        void DidEndDisplayingItem(MDCTabBar tabBar, UITabBarItem item);
    }

    // @interface MDCTabBarDisplayDelegate (MDCTabBar)
    [Category]
    [BaseType(typeof(MDCTabBar))]
    interface MDCTabBar_MDCTabBarDisplayDelegate
    {
        [Wrap("WeakDisplayDelegate")]
        [NullAllowed]
        MDCTabBarDisplayDelegate DisplayDelegate { get; set; }

        // @property (nonatomic, weak) NSObject<MDCTabBarDisplayDelegate> * _Nullable displayDelegate;
        [NullAllowed, Export("displayDelegate", ArgumentSemantic.Weak)]
        NSObject WeakDisplayDelegate { get; set; }
    }

    // @protocol MDCTabBarSizeClassDelegate
    [Protocol, Model(AutoGeneratedName = true)]
    interface MDCTabBarSizeClassDelegate
    {
        // @optional -(UIUserInterfaceSizeClass)horizontalSizeClassForObject:(id<UITraitEnvironment> _Nonnull)object;
        [Export("horizontalSizeClassForObject:")]
        UIUserInterfaceSizeClass HorizontalSizeClassForObject(UITraitEnvironment @object);
    }

    // @interface MDCTabBarSizeClassDelegate (MDCTabBar)
    [Category]
    [BaseType(typeof(MDCTabBar))]
    interface MDCTabBar_MDCTabBarSizeClassDelegate
    {
        [Wrap("WeakSizeClassDelegate")]
        [NullAllowed]
        MDCTabBarSizeClassDelegate SizeClassDelegate { get; set; }

        // @property (nonatomic, weak) NSObject<MDCTabBarSizeClassDelegate> * _Nullable sizeClassDelegate;
        [NullAllowed, Export("sizeClassDelegate", ArgumentSemantic.Weak)]
        NSObject WeakSizeClassDelegate { get; set; }
    }

    // @interface MDCTabBarColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTabBarColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCTabBarColorThemer)
    [Category]
    [BaseType(typeof(MDCTabBarColorThemer))]
    interface MDCTabBarColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTabs:(MDCTabBar * _Nonnull)tabBar;
        [Static]
        [Export("applySemanticColorScheme:toTabs:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCTabBar tabBar);

        // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTabs:(MDCTabBar * _Nonnull)tabBar;
        [Static]
        [Export("applySurfaceVariantWithColorScheme:toTabs:")]
        void ApplySurfaceVariantWithColorScheme(MDCColorScheming colorScheme, MDCTabBar tabBar);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
        [Static]
        [Export("applyColorScheme:toTabBar:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCTabBar tabBar);
    }

    // @interface MDCTabBarFontThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTabBarFontThemer
    {
    }

    // @interface ToBeDeprecated (MDCTabBarFontThemer)
    [Category]
    [BaseType(typeof(MDCTabBarFontThemer))]
    interface MDCTabBarFontThemer_ToBeDeprecated
    {
        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
        [Static]
        [Export("applyFontScheme:toTabBar:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, MDCTabBar tabBar);
    }

    // @interface MaterialTheming (MDCTabBar)
    [Category]
    [BaseType(typeof(MDCTabBar))]
    interface MDCTabBar_MaterialTheming
    {
        // -(void)applyPrimaryThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyPrimaryThemeWithScheme:")]
        void ApplyPrimaryThemeWithScheme(MDCContainerScheming scheme);

        // -(void)applySurfaceThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applySurfaceThemeWithScheme:")]
        void ApplySurfaceThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCTabBarTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTabBarTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCTabBarTypographyThemer)
    [Category]
    [BaseType(typeof(MDCTabBarTypographyThemer))]
    interface MDCTabBarTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
        [Static]
        [Export("applyTypographyScheme:toTabBar:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCTabBar tabBar);
    }

    // @interface MDCFilledTextFieldColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCFilledTextFieldColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCFilledTextFieldColorThemer)
    [Category]
    [BaseType(typeof(MDCFilledTextFieldColorThemer))]
    interface MDCFilledTextFieldColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputControllerFilled:(MDCTextInputControllerFilled * _Nonnull)textInputControllerFilled;
        [Static]
        [Export("applySemanticColorScheme:toTextInputControllerFilled:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCTextInputControllerFilled textInputControllerFilled);
    }

    // @interface MDCOutlinedTextFieldColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCOutlinedTextFieldColorThemer
    {
    }

    // @interface ToBeDeprecated (MDCOutlinedTextFieldColorThemer)
    [Category]
    [BaseType(typeof(MDCOutlinedTextFieldColorThemer))]
    interface MDCOutlinedTextFieldColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
        [Static]
        [Export("applySemanticColorScheme:toTextInputController:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCTextInputController textInputController);
    }

    // @interface MDCTextFieldColorThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTextFieldColorThemer
    {
        [Wrap("ApplySemanticColorScheme (colorScheme, textInputController)")]
        [Obsolete("Use ApplySemanticColorScheme instead.")]
        [Static]
        void ApplySemanticColorSchemeToTextInput(MDCColorScheming colorScheme, MDCTextInputController textInputController);

        [Static]
        [Wrap("ApplySemanticColorScheme (colorScheme, textInput)")]
        [Obsolete("Use ApplySemanticColorScheme instead.")]
        void ApplySemanticColorSchemeToTextInput(MDCColorScheming colorScheme, MDCTextInput textInput);

    }

    // @interface ToBeDeprecated (MDCTextFieldColorThemer)
    [Category]
    [BaseType(typeof(MDCTextFieldColorThemer))]
    interface MDCTextFieldColorThemer_ToBeDeprecated
    {
        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
        [Static]
        [Export("applySemanticColorScheme:toTextInputController:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCTextInputController textInputController);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass __attribute__((swift_name("apply(_:toAllControllersOfClass:)")));
        [Static]
        [Export("applySemanticColorScheme:toAllTextInputControllersOfClass:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCTextInputController textInputControllerClass);

        // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInput:(id<MDCTextInput> _Nonnull)textInput;
        [Static]
        [Export("applySemanticColorScheme:toTextInput:")]
        void ApplySemanticColorScheme(MDCColorScheming colorScheme, MDCTextInput textInput);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
        [Static]
        [Export("applyColorScheme:toTextInputController:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCTextInputController textInputController);

        // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass __attribute__((swift_name("apply(_:toAllControllersOfClass:)")));
        [Static]
        [Export("applyColorScheme:toAllTextInputControllersOfClass:")]
        void ApplyColorScheme(MDCColorScheme colorScheme, MDCTextInputController textInputControllerClass);
    }

    // @interface MDCBaseTextField : UITextField
    [BaseType(typeof(UITextField))]
    interface MDCBaseTextField
    {
        // @property (readonly, nonatomic, strong) UILabel * _Nonnull label;
        [Export("label", ArgumentSemantic.Strong)]
        UILabel Label { get; }

        // @property (assign, nonatomic) MDCTextControlLabelBehavior labelBehavior;
        [Export("labelBehavior", ArgumentSemantic.Assign)]
        MDCTextControlLabelBehavior LabelBehavior { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable leadingView;
        [NullAllowed, Export("leadingView", ArgumentSemantic.Strong)]
        UIView LeadingView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable trailingView;
        [NullAllowed, Export("trailingView", ArgumentSemantic.Strong)]
        UIView TrailingView { get; set; }

        // @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
        [Export("leadingViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode LeadingViewMode { get; set; }

        // @property (assign, nonatomic) UITextFieldViewMode trailingViewMode;
        [Export("trailingViewMode", ArgumentSemantic.Assign)]
        UITextFieldViewMode TrailingViewMode { get; set; }
    }

    // @interface MDCTextFieldFontThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTextFieldFontThemer
    {
    }

    // @interface ToBeDeprecated (MDCTextFieldFontThemer)
    [Category]
    [BaseType(typeof(MDCTextFieldFontThemer))]
    interface MDCTextFieldFontThemer_ToBeDeprecated
    {
        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
        [Static]
        [Export("applyFontScheme:toTextInputController:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, MDCTextInputController textInputController);

        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass __attribute__((swift_name("apply(_:toAllControllersOfClass:)")));
        [Static]
        [Export("applyFontScheme:toAllTextInputControllersOfClass:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, MDCTextInputController textInputControllerClass);

        // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTextField:(MDCTextField * _Nullable)textField;
        [Static]
        [Export("applyFontScheme:toTextField:")]
        void ApplyFontScheme(MDCFontScheme fontScheme, [NullAllowed] MDCTextField textField);
    }

    // @interface MaterialTheming (MDCTextInputControllerFilled)
    [Category]
    [BaseType(typeof(MDCTextInputControllerFilled))]
    interface MDCTextInputControllerFilled_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MaterialTheming (MDCTextInputControllerOutlined)
    [Category]
    [BaseType(typeof(MDCTextInputControllerOutlined))]
    interface MDCTextInputControllerOutlined_MaterialTheming
    {
        // -(void)applyThemeWithScheme:(id<MDCContainerScheming> _Nonnull)scheme;
        [Export("applyThemeWithScheme:")]
        void ApplyThemeWithScheme(MDCContainerScheming scheme);
    }

    // @interface MDCTextFieldTypographyThemer : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTextFieldTypographyThemer
    {
    }

    // @interface ToBeDeprecated (MDCTextFieldTypographyThemer)
    [Category]
    [BaseType(typeof(MDCTextFieldTypographyThemer))]
    interface MDCTextFieldTypographyThemer_ToBeDeprecated
    {
        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
        [Static]
        [Export("applyTypographyScheme:toTextInputController:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCTextInputController textInputController);

        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass __attribute__((swift_name("apply(_:toAllControllersOfClass:)")));
        [Static]
        [Export("applyTypographyScheme:toAllTextInputControllersOfClass:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCTextInputController textInputControllerClass);

        // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTextInput:(id<MDCTextInput> _Nonnull)textInput;
        [Static]
        [Export("applyTypographyScheme:toTextInput:")]
        void ApplyTypographyScheme(MDCTypographyScheming typographyScheme, MDCTextInput textInput);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const MDCTextStyle MDCTextStyleHeadline1 __attribute__((visibility("default")));
        [Field("MDCTextStyleHeadline1", "__Internal")]
        NSString MDCTextStyleHeadline1 { get; }

        // extern const MDCTextStyle MDCTextStyleHeadline2 __attribute__((visibility("default")));
        [Field("MDCTextStyleHeadline2", "__Internal")]
        NSString MDCTextStyleHeadline2 { get; }

        // extern const MDCTextStyle MDCTextStyleHeadline3 __attribute__((visibility("default")));
        [Field("MDCTextStyleHeadline3", "__Internal")]
        NSString MDCTextStyleHeadline3 { get; }

        // extern const MDCTextStyle MDCTextStyleHeadline4 __attribute__((visibility("default")));
        [Field("MDCTextStyleHeadline4", "__Internal")]
        NSString MDCTextStyleHeadline4 { get; }

        // extern const MDCTextStyle MDCTextStyleHeadline5 __attribute__((visibility("default")));
        [Field("MDCTextStyleHeadline5", "__Internal")]
        NSString MDCTextStyleHeadline5 { get; }

        // extern const MDCTextStyle MDCTextStyleHeadline6 __attribute__((visibility("default")));
        [Field("MDCTextStyleHeadline6", "__Internal")]
        NSString MDCTextStyleHeadline6 { get; }

        // extern const MDCTextStyle MDCTextStyleSubtitle1 __attribute__((visibility("default")));
        [Field("MDCTextStyleSubtitle1", "__Internal")]
        NSString MDCTextStyleSubtitle1 { get; }

        // extern const MDCTextStyle MDCTextStyleSubtitle2 __attribute__((visibility("default")));
        [Field("MDCTextStyleSubtitle2", "__Internal")]
        NSString MDCTextStyleSubtitle2 { get; }

        // extern const MDCTextStyle MDCTextStyleBody1 __attribute__((visibility("default")));
        [Field("MDCTextStyleBody1", "__Internal")]
        NSString MDCTextStyleBody1 { get; }

        // extern const MDCTextStyle MDCTextStyleBody2 __attribute__((visibility("default")));
        [Field("MDCTextStyleBody2", "__Internal")]
        NSString MDCTextStyleBody2 { get; }

        // extern const MDCTextStyle MDCTextStyleButton __attribute__((visibility("default")));
        [Field("MDCTextStyleButton", "__Internal")]
        NSString MDCTextStyleButton { get; }

        // extern const MDCTextStyle MDCTextStyleCaption __attribute__((visibility("default")));
        [Field("MDCTextStyleCaption", "__Internal")]
        NSString MDCTextStyleCaption { get; }

        // extern const MDCTextStyle MDCTextStyleOverline __attribute__((visibility("default")));
        [Field("MDCTextStyleOverline", "__Internal")]
        NSString MDCTextStyleOverline { get; }
    }

    // @interface MDCFontScaler : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCFontScaler
    {
        // -(instancetype _Nonnull)initForMaterialTextStyle:(MDCTextStyle)textStyle __attribute__((objc_designated_initializer));
        [Export("initForMaterialTextStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor(string textStyle);

        // +(instancetype _Nonnull)scalerForMaterialTextStyle:(MDCTextStyle)textStyle;
        [Static]
        [Export("scalerForMaterialTextStyle:")]
        MDCFontScaler ScalerForMaterialTextStyle(string textStyle);

        // -(UIFont * _Nonnull)scaledFontWithFont:(UIFont * _Nonnull)font;
        [Export("scaledFontWithFont:")]
        UIFont ScaledFontWithFont(UIFont font);

        // -(CGFloat)scaledValueForValue:(CGFloat)value;
        [Export("scaledValueForValue:")]
        nfloat ScaledValueForValue(nfloat value);
    }

    // @protocol MDCTypographyFontLoading <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCTypographyFontLoading
    {
        // @required -(UIFont * _Nullable)lightFontOfSize:(CGFloat)fontSize;
        [Abstract]
        [Export("lightFontOfSize:")]
        [return: NullAllowed]
        UIFont LightFontOfSize(nfloat fontSize);

        // @required -(UIFont * _Nonnull)regularFontOfSize:(CGFloat)fontSize;
        [Abstract]
        [Export("regularFontOfSize:")]
        UIFont RegularFontOfSize(nfloat fontSize);

        // @required -(UIFont * _Nullable)mediumFontOfSize:(CGFloat)fontSize;
        [Abstract]
        [Export("mediumFontOfSize:")]
        [return: NullAllowed]
        UIFont MediumFontOfSize(nfloat fontSize);

        // @optional -(UIFont * _Nonnull)boldFontOfSize:(CGFloat)fontSize;
        [Export("boldFontOfSize:")]
        UIFont BoldFontOfSize(nfloat fontSize);

        // @optional -(UIFont * _Nonnull)italicFontOfSize:(CGFloat)fontSize;
        [Export("italicFontOfSize:")]
        UIFont ItalicFontOfSize(nfloat fontSize);

        // @optional -(UIFont * _Nullable)boldItalicFontOfSize:(CGFloat)fontSize;
        [Export("boldItalicFontOfSize:")]
        [return: NullAllowed]
        UIFont BoldItalicFontOfSize(nfloat fontSize);

        // @optional -(UIFont * _Nonnull)boldFontFromFont:(UIFont * _Nonnull)font;
        [Export("boldFontFromFont:")]
        UIFont BoldFontFromFont(UIFont font);

        // @optional -(UIFont * _Nonnull)italicFontFromFont:(UIFont * _Nonnull)font;
        [Export("italicFontFromFont:")]
        UIFont ItalicFontFromFont(UIFont font);

        // @optional -(BOOL)isLargeForContrastRatios:(UIFont * _Nonnull)font;
        [Export("isLargeForContrastRatios:")]
        bool IsLargeForContrastRatios(UIFont font);
    }

    // @interface MDCTypography : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCTypography
    {
        // +(id<MDCTypographyFontLoading> _Nonnull)fontLoader;
        // +(void)setFontLoader:(id<MDCTypographyFontLoading> _Nonnull)fontLoader;
        [Static]
        [Export("fontLoader")]
        [Verify(MethodToProperty)]
        MDCTypographyFontLoading FontLoader { get; set; }

        // +(UIFont * _Nonnull)display4Font;
        [Static]
        [Export("display4Font")]
        [Verify(MethodToProperty)]
        UIFont Display4Font { get; }

        // +(CGFloat)display4FontOpacity;
        [Static]
        [Export("display4FontOpacity")]
        [Verify(MethodToProperty)]
        nfloat Display4FontOpacity { get; }

        // +(UIFont * _Nonnull)display3Font;
        [Static]
        [Export("display3Font")]
        [Verify(MethodToProperty)]
        UIFont Display3Font { get; }

        // +(CGFloat)display3FontOpacity;
        [Static]
        [Export("display3FontOpacity")]
        [Verify(MethodToProperty)]
        nfloat Display3FontOpacity { get; }

        // +(UIFont * _Nonnull)display2Font;
        [Static]
        [Export("display2Font")]
        [Verify(MethodToProperty)]
        UIFont Display2Font { get; }

        // +(CGFloat)display2FontOpacity;
        [Static]
        [Export("display2FontOpacity")]
        [Verify(MethodToProperty)]
        nfloat Display2FontOpacity { get; }

        // +(UIFont * _Nonnull)display1Font;
        [Static]
        [Export("display1Font")]
        [Verify(MethodToProperty)]
        UIFont Display1Font { get; }

        // +(CGFloat)display1FontOpacity;
        [Static]
        [Export("display1FontOpacity")]
        [Verify(MethodToProperty)]
        nfloat Display1FontOpacity { get; }

        // +(UIFont * _Nonnull)headlineFont;
        [Static]
        [Export("headlineFont")]
        [Verify(MethodToProperty)]
        UIFont HeadlineFont { get; }

        // +(CGFloat)headlineFontOpacity;
        [Static]
        [Export("headlineFontOpacity")]
        [Verify(MethodToProperty)]
        nfloat HeadlineFontOpacity { get; }

        // +(UIFont * _Nonnull)titleFont;
        [Static]
        [Export("titleFont")]
        [Verify(MethodToProperty)]
        UIFont TitleFont { get; }

        // +(CGFloat)titleFontOpacity;
        [Static]
        [Export("titleFontOpacity")]
        [Verify(MethodToProperty)]
        nfloat TitleFontOpacity { get; }

        // +(UIFont * _Nonnull)subheadFont;
        [Static]
        [Export("subheadFont")]
        [Verify(MethodToProperty)]
        UIFont SubheadFont { get; }

        // +(CGFloat)subheadFontOpacity;
        [Static]
        [Export("subheadFontOpacity")]
        [Verify(MethodToProperty)]
        nfloat SubheadFontOpacity { get; }

        // +(UIFont * _Nonnull)body2Font;
        [Static]
        [Export("body2Font")]
        [Verify(MethodToProperty)]
        UIFont Body2Font { get; }

        // +(CGFloat)body2FontOpacity;
        [Static]
        [Export("body2FontOpacity")]
        [Verify(MethodToProperty)]
        nfloat Body2FontOpacity { get; }

        // +(UIFont * _Nonnull)body1Font;
        [Static]
        [Export("body1Font")]
        [Verify(MethodToProperty)]
        UIFont Body1Font { get; }

        // +(CGFloat)body1FontOpacity;
        [Static]
        [Export("body1FontOpacity")]
        [Verify(MethodToProperty)]
        nfloat Body1FontOpacity { get; }

        // +(UIFont * _Nonnull)captionFont;
        [Static]
        [Export("captionFont")]
        [Verify(MethodToProperty)]
        UIFont CaptionFont { get; }

        // +(CGFloat)captionFontOpacity;
        [Static]
        [Export("captionFontOpacity")]
        [Verify(MethodToProperty)]
        nfloat CaptionFontOpacity { get; }

        // +(UIFont * _Nonnull)buttonFont;
        [Static]
        [Export("buttonFont")]
        [Verify(MethodToProperty)]
        UIFont ButtonFont { get; }

        // +(CGFloat)buttonFontOpacity;
        [Static]
        [Export("buttonFontOpacity")]
        [Verify(MethodToProperty)]
        nfloat ButtonFontOpacity { get; }

        // +(UIFont * _Nonnull)boldFontFromFont:(UIFont * _Nonnull)font;
        [Static]
        [Export("boldFontFromFont:")]
        UIFont BoldFontFromFont(UIFont font);

        // +(UIFont * _Nonnull)italicFontFromFont:(UIFont * _Nonnull)font;
        [Static]
        [Export("italicFontFromFont:")]
        UIFont ItalicFontFromFont(UIFont font);

        // +(BOOL)isLargeForContrastRatios:(UIFont * _Nonnull)font;
        [Static]
        [Export("isLargeForContrastRatios:")]
        bool IsLargeForContrastRatios(UIFont font);
    }

    // @interface MDCSystemFontLoader : NSObject <MDCTypographyFontLoading>
    [BaseType(typeof(NSObject))]
    interface MDCSystemFontLoader : IMDCTypographyFontLoading
    {
    }

    // @interface MaterialScalable (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_MaterialScalable
    {
        // @property (copy, nonatomic, setter = mdc_setScalingCurve:) MDCScalingCurve _Nullable mdc_scalingCurve;
        [NullAllowed, Export("mdc_scalingCurve", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSNumber> Mdc_scalingCurve { get; [Bind("mdc_setScalingCurve:")] set; }

        // -(UIFont * _Nonnull)mdc_scaledFontForSizeCategory:(UIContentSizeCategory _Nonnull)sizeCategory;
        [Export("mdc_scaledFontForSizeCategory:")]
        UIFont Mdc_scaledFontForSizeCategory(string sizeCategory);

        // -(UIFont * _Nonnull)mdc_scaledFontForTraitEnvironment:(id<UITraitEnvironment> _Nonnull)traitEnvironment;
        [Export("mdc_scaledFontForTraitEnvironment:")]
        UIFont Mdc_scaledFontForTraitEnvironment(UITraitEnvironment traitEnvironment);

        // -(UIFont * _Nonnull)mdc_scaledFontAtDefaultSize;
        [Export("mdc_scaledFontAtDefaultSize")]
        [Verify(MethodToProperty)]
        UIFont Mdc_scaledFontAtDefaultSize { get; }

        // -(UIFont * _Nonnull)mdc_scaledFontForCurrentSizeCategory;
        [Export("mdc_scaledFontForCurrentSizeCategory")]
        [Verify(MethodToProperty)]
        UIFont Mdc_scaledFontForCurrentSizeCategory { get; }
    }

    // @interface MaterialSimpleEquality (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_MaterialSimpleEquality
    {
        // -(BOOL)mdc_isSimplyEqual:(UIFont *)font;
        [Export("mdc_isSimplyEqual:")]
        bool Mdc_isSimplyEqual(UIFont font);
    }

    // @interface MaterialTypography (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_MaterialTypography
    {
        // +(UIFont * _Nonnull)mdc_preferredFontForMaterialTextStyle:(MDCFontTextStyle)style;
        [Static]
        [Export("mdc_preferredFontForMaterialTextStyle:")]
        UIFont Mdc_preferredFontForMaterialTextStyle(MDCFontTextStyle style);

        // +(UIFont * _Nonnull)mdc_standardFontForMaterialTextStyle:(MDCFontTextStyle)style;
        [Static]
        [Export("mdc_standardFontForMaterialTextStyle:")]
        UIFont Mdc_standardFontForMaterialTextStyle(MDCFontTextStyle style);

        // -(UIFont * _Nonnull)mdc_fontSizedForMaterialTextStyle:(MDCFontTextStyle)style scaledForDynamicType:(BOOL)scaled;
        [Export("mdc_fontSizedForMaterialTextStyle:scaledForDynamicType:")]
        UIFont Mdc_fontSizedForMaterialTextStyle(MDCFontTextStyle style, bool scaled);
    }

    // @interface MaterialTypography (UIFontDescriptor)
    [Category]
    [BaseType(typeof(UIFontDescriptor))]
    interface UIFontDescriptor_MaterialTypography
    {
        // +(UIFontDescriptor * _Nonnull)mdc_preferredFontDescriptorForMaterialTextStyle:(MDCFontTextStyle)style;
        [Static]
        [Export("mdc_preferredFontDescriptorForMaterialTextStyle:")]
        UIFontDescriptor Mdc_preferredFontDescriptorForMaterialTextStyle(MDCFontTextStyle style);

        // +(UIFontDescriptor * _Nonnull)mdc_standardFontDescriptorForMaterialTextStyle:(MDCFontTextStyle)style;
        [Static]
        [Export("mdc_standardFontDescriptorForMaterialTextStyle:")]
        UIFontDescriptor Mdc_standardFontDescriptorForMaterialTextStyle(MDCFontTextStyle style);
    }

    // @interface AppExtensions (UIApplication)
    [Category]
    [BaseType(typeof(UIApplication))]
    interface UIApplication_AppExtensions
    {
        // +(UIApplication *)mdc_safeSharedApplication;
        [Static]
        [Export("mdc_safeSharedApplication")]
        [Verify(MethodToProperty)]
        UIApplication Mdc_safeSharedApplication { get; }

        // +(BOOL)mdc_isAppExtension;
        [Static]
        [Export("mdc_isAppExtension")]
        [Verify(MethodToProperty)]
        bool Mdc_isAppExtension { get; }
    }

    // @interface MaterialBlending (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_MaterialBlending
    {
        // +(UIColor * _Nonnull)mdc_blendColor:(UIColor * _Nonnull)color withBackgroundColor:(UIColor * _Nonnull)backgroundColor;
        [Static]
        [Export("mdc_blendColor:withBackgroundColor:")]
        UIColor Mdc_blendColor(UIColor color, UIColor backgroundColor);
    }

    // @interface MaterialDynamic (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_MaterialDynamic
    {
        // +(UIColor * _Nonnull)colorWithUserInterfaceStyleDarkColor:(UIColor * _Nonnull)darkColor defaultColor:(UIColor * _Nonnull)defaultColor;
        [Static]
        [Export("colorWithUserInterfaceStyleDarkColor:defaultColor:")]
        UIColor ColorWithUserInterfaceStyleDarkColor(UIColor darkColor, UIColor defaultColor);

        // -(UIColor * _Nonnull)mdc_resolvedColorWithTraitCollection:(UITraitCollection * _Nonnull)traitCollection;
        [Export("mdc_resolvedColorWithTraitCollection:")]
        UIColor Mdc_resolvedColorWithTraitCollection(UITraitCollection traitCollection);
    }

    // @interface MDCIcons : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MDCIcons
    {
    }

    // @interface BundleLoader (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_BundleLoader
    {
        // +(NSString * _Nonnull)pathForIconName:(NSString * _Nonnull)iconName withBundleName:(NSString * _Nonnull)bundleName;
        [Static]
        [Export("pathForIconName:withBundleName:")]
        string PathForIconName(string iconName, string bundleName);

        // +(NSBundle * _Nullable)bundleNamed:(NSString * _Nonnull)bundleName;
        [Static]
        [Export("bundleNamed:")]
        [return: NullAllowed]
        NSBundle BundleNamed(string bundleName);
    }

    // @interface ic_arrow_back (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_arrow_back
    {
        // +(NSString * _Nonnull)pathFor_ic_arrow_back;
        [Static]
        [Export("pathFor_ic_arrow_back")]
        [Verify(MethodToProperty)]
        string PathFor_ic_arrow_back { get; }

        // +(void)ic_arrow_backUseNewStyle:(BOOL)useNewStyle;
        [Static]
        [Export("ic_arrow_backUseNewStyle:")]
        void Ic_arrow_backUseNewStyle(bool useNewStyle);

        // +(UIImage * _Nullable)imageFor_ic_arrow_back;
        [Static]
        [NullAllowed, Export("imageFor_ic_arrow_back")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_arrow_back { get; }
    }

    // @interface ic_check (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_check
    {
        // +(NSString * _Nonnull)pathFor_ic_check;
        [Static]
        [Export("pathFor_ic_check")]
        [Verify(MethodToProperty)]
        string PathFor_ic_check { get; }

        // +(UIImage * _Nullable)imageFor_ic_check;
        [Static]
        [NullAllowed, Export("imageFor_ic_check")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_check { get; }
    }

    // @interface ic_check_circle (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_check_circle
    {
        // +(NSString * _Nonnull)pathFor_ic_check_circle;
        [Static]
        [Export("pathFor_ic_check_circle")]
        [Verify(MethodToProperty)]
        string PathFor_ic_check_circle { get; }

        // +(UIImage * _Nullable)imageFor_ic_check_circle;
        [Static]
        [NullAllowed, Export("imageFor_ic_check_circle")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_check_circle { get; }
    }

    // @interface ic_chevron_right (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_chevron_right
    {
        // +(NSString * _Nonnull)pathFor_ic_chevron_right;
        [Static]
        [Export("pathFor_ic_chevron_right")]
        [Verify(MethodToProperty)]
        string PathFor_ic_chevron_right { get; }

        // +(UIImage * _Nullable)imageFor_ic_chevron_right;
        [Static]
        [NullAllowed, Export("imageFor_ic_chevron_right")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_chevron_right { get; }
    }

    // @interface ic_color_lens (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_color_lens
    {
        // +(NSString * _Nonnull)pathFor_ic_color_lens;
        [Static]
        [Export("pathFor_ic_color_lens")]
        [Verify(MethodToProperty)]
        string PathFor_ic_color_lens { get; }

        // +(UIImage * _Nullable)imageFor_ic_color_lens;
        [Static]
        [NullAllowed, Export("imageFor_ic_color_lens")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_color_lens { get; }
    }

    // @interface ic_help_outline (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_help_outline
    {
        // +(NSString * _Nonnull)pathFor_ic_help_outline;
        [Static]
        [Export("pathFor_ic_help_outline")]
        [Verify(MethodToProperty)]
        string PathFor_ic_help_outline { get; }

        // +(UIImage * _Nullable)imageFor_ic_help_outline;
        [Static]
        [NullAllowed, Export("imageFor_ic_help_outline")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_help_outline { get; }
    }

    // @interface ic_info (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_info
    {
        // +(NSString * _Nonnull)pathFor_ic_info;
        [Static]
        [Export("pathFor_ic_info")]
        [Verify(MethodToProperty)]
        string PathFor_ic_info { get; }

        // +(UIImage * _Nullable)imageFor_ic_info;
        [Static]
        [NullAllowed, Export("imageFor_ic_info")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_info { get; }
    }

    // @interface ic_more_horiz (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_more_horiz
    {
        // +(NSString * _Nonnull)pathFor_ic_more_horiz;
        [Static]
        [Export("pathFor_ic_more_horiz")]
        [Verify(MethodToProperty)]
        string PathFor_ic_more_horiz { get; }

        // +(UIImage * _Nullable)imageFor_ic_more_horiz;
        [Static]
        [NullAllowed, Export("imageFor_ic_more_horiz")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_more_horiz { get; }
    }

    // @interface ic_radio_button_unchecked (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_radio_button_unchecked
    {
        // +(NSString * _Nonnull)pathFor_ic_radio_button_unchecked;
        [Static]
        [Export("pathFor_ic_radio_button_unchecked")]
        [Verify(MethodToProperty)]
        string PathFor_ic_radio_button_unchecked { get; }

        // +(UIImage * _Nullable)imageFor_ic_radio_button_unchecked;
        [Static]
        [NullAllowed, Export("imageFor_ic_radio_button_unchecked")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_radio_button_unchecked { get; }
    }

    // @interface ic_reorder (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_reorder
    {
        // +(NSString * _Nonnull)pathFor_ic_reorder;
        [Static]
        [Export("pathFor_ic_reorder")]
        [Verify(MethodToProperty)]
        string PathFor_ic_reorder { get; }

        // +(UIImage * _Nullable)imageFor_ic_reorder;
        [Static]
        [NullAllowed, Export("imageFor_ic_reorder")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_reorder { get; }
    }

    // @interface ic_settings (MDCIcons)
    [Category]
    [BaseType(typeof(MDCIcons))]
    interface MDCIcons_ic_settings
    {
        // +(NSString * _Nonnull)pathFor_ic_settings;
        [Static]
        [Export("pathFor_ic_settings")]
        [Verify(MethodToProperty)]
        string PathFor_ic_settings { get; }

        // +(UIImage * _Nullable)imageFor_ic_settings;
        [Static]
        [NullAllowed, Export("imageFor_ic_settings")]
        [Verify(MethodToProperty)]
        UIImage ImageFor_ic_settings { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MDCKeyboardWatcherKeyboardWillShowNotification;
        [Field("MDCKeyboardWatcherKeyboardWillShowNotification", "__Internal")]
        NSString MDCKeyboardWatcherKeyboardWillShowNotification { get; }

        // extern NSString *const MDCKeyboardWatcherKeyboardWillHideNotification;
        [Field("MDCKeyboardWatcherKeyboardWillHideNotification", "__Internal")]
        NSString MDCKeyboardWatcherKeyboardWillHideNotification { get; }

        // extern NSString *const MDCKeyboardWatcherKeyboardWillChangeFrameNotification;
        [Field("MDCKeyboardWatcherKeyboardWillChangeFrameNotification", "__Internal")]
        NSString MDCKeyboardWatcherKeyboardWillChangeFrameNotification { get; }
    }

    // @interface MDCKeyboardWatcher : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCKeyboardWatcher
    {
        // +(instancetype)sharedKeyboardWatcher;
        [Static]
        [Export("sharedKeyboardWatcher")]
        MDCKeyboardWatcher SharedKeyboardWatcher();

        // +(NSTimeInterval)animationDurationFromKeyboardNotification:(NSNotification *)notification;
        [Static]
        [Export("animationDurationFromKeyboardNotification:")]
        double AnimationDurationFromKeyboardNotification(NSNotification notification);

        // +(UIViewAnimationOptions)animationCurveOptionFromKeyboardNotification:(NSNotification *)notification;
        [Static]
        [Export("animationCurveOptionFromKeyboardNotification:")]
        UIViewAnimationOptions AnimationCurveOptionFromKeyboardNotification(NSNotification notification);

        // @property (readonly, nonatomic) CGFloat visibleKeyboardHeight;
        [Export("visibleKeyboardHeight")]
        nfloat VisibleKeyboardHeight { get; }

        // @property (readonly, nonatomic) CGFloat keyboardOffset __attribute__((deprecated("Use visibleKeyboardHeight instead of keyboardOffset")));
        [Export("keyboardOffset")]
        nfloat KeyboardOffset { get; }
    }

    // @interface MDCOverlayObserver : NSObject
    [BaseType(typeof(NSObject))]
    interface MDCOverlayObserver
    {
        // +(instancetype)observerForScreen:(UIScreen *)screen;
        [Static]
        [Export("observerForScreen:")]
        MDCOverlayObserver ObserverForScreen(UIScreen screen);

        // -(void)addTarget:(id)target action:(SEL)action;
        [Export("addTarget:action:")]
        void AddTarget(NSObject target, Selector action);

        // -(void)removeTarget:(id)target action:(SEL)action;
        [Export("removeTarget:action:")]
        void RemoveTarget(NSObject target, Selector action);

        // -(void)removeTarget:(id)target;
        [Export("removeTarget:")]
        void RemoveTarget(NSObject target);
    }

    // @protocol MDCOverlay <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCOverlay
    {
        // @required @property (readonly, copy, nonatomic) NSString * identifier;
        [Abstract]
        [Export("identifier")]
        string Identifier { get; }

        // @required @property (readonly, nonatomic) CGRect frame;
        [Abstract]
        [Export("frame")]
        CGRect Frame { get; }
    }

    // @protocol MDCOverlayTransitioning <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface MDCOverlayTransitioning
    {
        // @required @property (readonly, nonatomic) NSTimeInterval duration;
        [Abstract]
        [Export("duration")]
        double Duration { get; }

        // @required @property (readonly, nonatomic) CAMediaTimingFunction * customTimingFunction;
        [Abstract]
        [Export("customTimingFunction")]
        CAMediaTimingFunction CustomTimingFunction { get; }

        // @required @property (readonly, nonatomic) UIViewAnimationCurve animationCurve;
        [Abstract]
        [Export("animationCurve")]
        UIViewAnimationCurve AnimationCurve { get; }

        // @required @property (readonly, nonatomic) CGRect compositeFrame;
        [Abstract]
        [Export("compositeFrame")]
        CGRect CompositeFrame { get; }

        // @required -(CGRect)compositeFrameInView:(UIView *)targetView;
        [Abstract]
        [Export("compositeFrameInView:")]
        CGRect CompositeFrameInView(UIView targetView);

        // @required -(void)enumerateOverlays:(void (^)(id<MDCOverlay>, NSUInteger, BOOL *))handler;
        [Abstract]
        [Export("enumerateOverlays:")]
        unsafe void EnumerateOverlays(Action<MDCOverlay, nuint, bool*> handler);

        // @required -(void)animateAlongsideTransition:(void (^)(void))animations;
        [Abstract]
        [Export("animateAlongsideTransition:")]
        void AnimateAlongsideTransition(Action animations);

        // @required -(void)animateAlongsideTransitionWithOptions:(UIViewAnimationOptions)options animations:(void (^)(void))animations completion:(void (^)(BOOL))completion;
        [Abstract]
        [Export("animateAlongsideTransitionWithOptions:animations:completion:")]
        void AnimateAlongsideTransitionWithOptions(UIViewAnimationOptions options, Action animations, Action<bool> completion);
    }

    // @interface MDCThumbTrack : UIControl
    [BaseType(typeof(UIControl))]
    interface MDCThumbTrack
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MDCThumbTrackDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MDCThumbTrackDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified thumbEnabledColor;
        [Export("thumbEnabledColor", ArgumentSemantic.Strong)]
        UIColor ThumbEnabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable thumbDisabledColor;
        [NullAllowed, Export("thumbDisabledColor", ArgumentSemantic.Strong)]
        UIColor ThumbDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified trackOnColor;
        [Export("trackOnColor", ArgumentSemantic.Strong)]
        UIColor TrackOnColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable trackOffColor;
        [NullAllowed, Export("trackOffColor", ArgumentSemantic.Strong)]
        UIColor TrackOffColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable trackDisabledColor;
        [NullAllowed, Export("trackDisabledColor", ArgumentSemantic.Strong)]
        UIColor TrackDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable trackOnTickColor;
        [NullAllowed, Export("trackOnTickColor", ArgumentSemantic.Strong)]
        UIColor TrackOnTickColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable trackOffTickColor;
        [NullAllowed, Export("trackOffTickColor", ArgumentSemantic.Strong)]
        UIColor TrackOffTickColor { get; set; }

        // @property (assign, nonatomic) BOOL enableRippleBehavior;
        [Export("enableRippleBehavior")]
        bool EnableRippleBehavior { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rippleColor;
        [NullAllowed, Export("rippleColor", ArgumentSemantic.Strong)]
        UIColor RippleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelTextColor;
        [Export("valueLabelTextColor", ArgumentSemantic.Strong)]
        UIColor ValueLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelBackgroundColor;
        [Export("valueLabelBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ValueLabelBackgroundColor { get; set; }

        // @property (assign, nonatomic) NSUInteger numDiscreteValues;
        [Export("numDiscreteValues")]
        nuint NumDiscreteValues { get; set; }

        // @property (assign, nonatomic) CGFloat value;
        [Export("value")]
        nfloat Value { get; set; }

        // @property (assign, nonatomic) CGFloat minimumValue;
        [Export("minimumValue")]
        nfloat MinimumValue { get; set; }

        // @property (assign, nonatomic) CGFloat maximumValue;
        [Export("maximumValue")]
        nfloat MaximumValue { get; set; }

        // @property (readonly, assign, nonatomic) CGPoint thumbPosition;
        [Export("thumbPosition", ArgumentSemantic.Assign)]
        CGPoint ThumbPosition { get; }

        // @property (assign, nonatomic) CGFloat trackHeight;
        [Export("trackHeight")]
        nfloat TrackHeight { get; set; }

        // @property (assign, nonatomic) CGFloat thumbRadius;
        [Export("thumbRadius")]
        nfloat ThumbRadius { get; set; }

        // @property (assign, nonatomic) MDCShadowElevation thumbElevation;
        [Export("thumbElevation")]
        double ThumbElevation { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull thumbShadowColor;
        [Export("thumbShadowColor", ArgumentSemantic.Strong)]
        UIColor ThumbShadowColor { get; set; }

        // @property (assign, nonatomic) BOOL thumbIsSmallerWhenDisabled;
        [Export("thumbIsSmallerWhenDisabled")]
        bool ThumbIsSmallerWhenDisabled { get; set; }

        // @property (assign, nonatomic) BOOL thumbIsHollowAtStart;
        [Export("thumbIsHollowAtStart")]
        bool ThumbIsHollowAtStart { get; set; }

        // @property (assign, nonatomic) BOOL thumbGrowsWhenDragging;
        [Export("thumbGrowsWhenDragging")]
        bool ThumbGrowsWhenDragging { get; set; }

        // @property (assign, nonatomic) CGFloat thumbRippleMaximumRadius;
        [Export("thumbRippleMaximumRadius")]
        nfloat ThumbRippleMaximumRadius { get; set; }

        // @property (assign, nonatomic) BOOL shouldDisplayRipple;
        [Export("shouldDisplayRipple")]
        bool ShouldDisplayRipple { get; set; }

        // @property (assign, nonatomic) BOOL shouldDisplayDiscreteDots;
        [Export("shouldDisplayDiscreteDots")]
        bool ShouldDisplayDiscreteDots { get; set; }

        // @property (assign, nonatomic) BOOL shouldDisplayDiscreteValueLabel;
        [Export("shouldDisplayDiscreteValueLabel")]
        bool ShouldDisplayDiscreteValueLabel { get; set; }

        // @property (assign, nonatomic) BOOL shouldDisplayFilledTrack;
        [Export("shouldDisplayFilledTrack")]
        bool ShouldDisplayFilledTrack { get; set; }

        // @property (assign, nonatomic) BOOL disabledTrackHasThumbGaps;
        [Export("disabledTrackHasThumbGaps")]
        bool DisabledTrackHasThumbGaps { get; set; }

        // @property (assign, nonatomic) BOOL trackEndsAreRounded;
        [Export("trackEndsAreRounded")]
        bool TrackEndsAreRounded { get; set; }

        // @property (assign, nonatomic) BOOL trackEndsAreInset;
        [Export("trackEndsAreInset")]
        bool TrackEndsAreInset { get; set; }

        // @property (assign, nonatomic) CGFloat filledTrackAnchorValue;
        [Export("filledTrackAnchorValue")]
        nfloat FilledTrackAnchorValue { get; set; }

        // @property (nonatomic, strong) MDCThumbView * _Nullable thumbView;
        [NullAllowed, Export("thumbView", ArgumentSemantic.Strong)]
        MDCThumbView ThumbView { get; set; }

        // @property (assign, nonatomic) BOOL continuousUpdateEvents;
        [Export("continuousUpdateEvents")]
        bool ContinuousUpdateEvents { get; set; }

        // @property (assign, nonatomic) BOOL panningAllowedOnEntireControl;
        [Export("panningAllowedOnEntireControl")]
        bool PanningAllowedOnEntireControl { get; set; }

        // @property (assign, nonatomic) BOOL tapsAllowedOnThumb;
        [Export("tapsAllowedOnThumb")]
        bool TapsAllowedOnThumb { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame onTintColor:(UIColor * _Nullable)onTintColor;
        [Export("initWithFrame:onTintColor:")]
        IntPtr Constructor(CGRect frame, [NullAllowed] UIColor onTintColor);

        // -(void)setValue:(CGFloat)value animated:(BOOL)animated;
        [Export("setValue:animated:")]
        void SetValue(nfloat value, bool animated);

        // -(void)setValue:(CGFloat)value animated:(BOOL)animated animateThumbAfterMove:(BOOL)animateThumbAfterMove userGenerated:(BOOL)userGenerated completion:(void (^ _Nullable)(void))completion;
        [Export("setValue:animated:animateThumbAfterMove:userGenerated:completion:")]
        void SetValue(nfloat value, bool animated, bool animateThumbAfterMove, bool userGenerated, [NullAllowed] Action completion);

        // -(void)setIcon:(UIImage * _Nullable)icon;
        [Export("setIcon:")]
        void SetIcon([NullAllowed] UIImage icon);

        // @property (nonatomic, strong) UIColor * _Nullable primaryColor;
        [NullAllowed, Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }
    }

    // @interface ToBeDeprecated (MDCThumbTrack)
    [Category]
    [BaseType(typeof(MDCThumbTrack))]
    interface MDCThumbTrack_ToBeDeprecated
    {
        // @property (nonatomic, strong) UIColor * _Nullable inkColor;
        [NullAllowed, Export("inkColor", ArgumentSemantic.Strong)]
        UIColor InkColor { get; set; }

        // @property (assign, nonatomic) BOOL shouldDisplayInk;
        [Export("shouldDisplayInk")]
        bool ShouldDisplayInk { get; set; }

        // @property (assign, nonatomic) CGFloat thumbMaxRippleRadius;
        [Export("thumbMaxRippleRadius")]
        nfloat ThumbMaxRippleRadius { get; set; }
    }

    // @protocol MDCThumbTrackDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface MDCThumbTrackDelegate
    {
        // @optional -(NSString * _Nonnull)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack stringForValue:(CGFloat)value;
        [Export("thumbTrack:stringForValue:")]
        string ThumbTrack(MDCThumbTrack thumbTrack, nfloat value);

        // @optional -(BOOL)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack shouldJumpToValue:(CGFloat)value;
        [Export("thumbTrack:shouldJumpToValue:")]
        bool ThumbTrack(MDCThumbTrack thumbTrack, nfloat value);

        // @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack willJumpToValue:(CGFloat)value;
        [Export("thumbTrack:willJumpToValue:")]
        void ThumbTrack(MDCThumbTrack thumbTrack, nfloat value);

        // @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack willAnimateToValue:(CGFloat)value;
        [Export("thumbTrack:willAnimateToValue:")]
        void ThumbTrack(MDCThumbTrack thumbTrack, nfloat value);

        // @optional -(void)thumbTrack:(MDCThumbTrack * _Nonnull)thumbTrack didAnimateToValue:(CGFloat)value;
        [Export("thumbTrack:didAnimateToValue:")]
        void ThumbTrack(MDCThumbTrack thumbTrack, nfloat value);
    }

    // @interface MDCThumbView : UIView
    [BaseType(typeof(UIView))]
    interface MDCThumbView
    {
        // @property (assign, nonatomic) MDCShadowElevation elevation;
        [Export("elevation")]
        double Elevation { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // -(void)setIcon:(UIImage * _Nullable)icon;
        [Export("setIcon:")]
        void SetIcon([NullAllowed] UIImage icon);

        // @property (nonatomic, strong) UIColor * _Nonnull shadowColor;
        [Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }
    }

    // @interface MDCNumericValueLabel : UIView
    [BaseType(typeof(UIView))]
    interface MDCNumericValueLabel
    {
        // @property (retain, nonatomic) UIColor * backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Retain)]
        UIColor BackgroundColor { get; set; }

        // @property (retain, nonatomic) UIColor * textColor;
        [Export("textColor", ArgumentSemantic.Retain)]
        UIColor TextColor { get; set; }

        // @property (nonatomic) CGFloat fontSize;
        [Export("fontSize")]
        nfloat FontSize { get; set; }

        // @property (copy, nonatomic) NSString * text;
        [Export("text")]
        string Text { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern double MaterialComponentsVersionNumber;
        [Field("MaterialComponentsVersionNumber", "__Internal")]
        double MaterialComponentsVersionNumber { get; }

        // extern const unsigned char [] MaterialComponentsVersionString;
        [Field("MaterialComponentsVersionString", "__Internal")]
        byte[] MaterialComponentsVersionString { get; }
    }
}