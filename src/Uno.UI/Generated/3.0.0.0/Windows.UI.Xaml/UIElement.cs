#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class UIElement 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.ManipulationModes ManipulationMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.ManipulationModes)this.GetValue(ManipulationModeProperty);
			}
			set
			{
				this.SetValue(ManipulationModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool IsTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool IsRightTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsRightTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsRightTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool IsHoldingEnabled
		{
			get
			{
				return (bool)this.GetValue(IsHoldingEnabledProperty);
			}
			set
			{
				this.SetValue(IsHoldingEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool IsDoubleTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsDoubleTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsDoubleTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.CacheMode CacheMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.CacheMode)this.GetValue(CacheModeProperty);
			}
			set
			{
				this.SetValue(CacheModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool AllowDrop
		{
			get
			{
				return (bool)this.GetValue(AllowDropProperty);
			}
			set
			{
				this.SetValue(AllowDropProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.RectangleGeometry Clip
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.RectangleGeometry)this.GetValue(ClipProperty);
			}
			set
			{
				this.SetValue(ClipProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool UseLayoutRounding
		{
			get
			{
				return (bool)this.GetValue(UseLayoutRoundingProperty);
			}
			set
			{
				this.SetValue(UseLayoutRoundingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Projection Projection
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Projection)this.GetValue(ProjectionProperty);
			}
			set
			{
				this.SetValue(ProjectionProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Size RenderSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size UIElement.RenderSize is not implemented in Uno.");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Xaml.Input.Pointer> PointerCaptures
		{
			get
			{
				return (global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Xaml.Input.Pointer>)this.GetValue(PointerCapturesProperty);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Size DesiredSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size UIElement.DesiredSize is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.ElementCompositeMode CompositeMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.ElementCompositeMode)this.GetValue(CompositeModeProperty);
			}
			set
			{
				this.SetValue(CompositeModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Media3D.Transform3D Transform3D
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Media3D.Transform3D)this.GetValue(Transform3DProperty);
			}
			set
			{
				this.SetValue(Transform3DProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool CanDrag
		{
			get
			{
				return (bool)this.GetValue(CanDragProperty);
			}
			set
			{
				this.SetValue(CanDragProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  string AccessKey
		{
			get
			{
				return (string)this.GetValue(AccessKeyProperty);
			}
			set
			{
				this.SetValue(AccessKeyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject AccessKeyScopeOwner
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(AccessKeyScopeOwnerProperty);
			}
			set
			{
				this.SetValue(AccessKeyScopeOwnerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool ExitDisplayModeOnAccessKeyInvoked
		{
			get
			{
				return (bool)this.GetValue(ExitDisplayModeOnAccessKeyInvokedProperty);
			}
			set
			{
				this.SetValue(ExitDisplayModeOnAccessKeyInvokedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase ContextFlyout
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)this.GetValue(ContextFlyoutProperty);
			}
			set
			{
				this.SetValue(ContextFlyoutProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool IsAccessKeyScope
		{
			get
			{
				return (bool)this.GetValue(IsAccessKeyScopeProperty);
			}
			set
			{
				this.SetValue(IsAccessKeyScopeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusDownNavigationStrategy
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusDownNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusDownNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusLeftNavigationStrategy
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusLeftNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusLeftNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.KeyboardNavigationMode TabFocusNavigation
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.KeyboardNavigationMode)this.GetValue(TabFocusNavigationProperty);
			}
			set
			{
				this.SetValue(TabFocusNavigationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode)this.GetValue(XYFocusKeyboardNavigationProperty);
			}
			set
			{
				this.SetValue(XYFocusKeyboardNavigationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  double KeyTipVerticalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipVerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.KeyTipPlacementMode KeyTipPlacementMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.KeyTipPlacementMode)this.GetValue(KeyTipPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyTipPlacementModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  double KeyTipHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.ElementHighContrastAdjustment HighContrastAdjustment
		{
			get
			{
				return (global::Windows.UI.Xaml.ElementHighContrastAdjustment)this.GetValue(HighContrastAdjustmentProperty);
			}
			set
			{
				this.SetValue(HighContrastAdjustmentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusUpNavigationStrategy
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusUpNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusUpNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy XYFocusRightNavigationStrategy
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)this.GetValue(XYFocusRightNavigationStrategyProperty);
			}
			set
			{
				this.SetValue(XYFocusRightNavigationStrategyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight> Lights
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight>)this.GetValue(LightsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Input.KeyboardAccelerator> KeyboardAccelerators
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<KeyboardAccelerator> UIElement.KeyboardAccelerators is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject KeyboardAcceleratorPlacementTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(KeyboardAcceleratorPlacementTargetProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorPlacementTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode KeyboardAcceleratorPlacementMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode)this.GetValue(KeyboardAcceleratorPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorPlacementModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject KeyTipTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(KeyTipTargetProperty);
			}
			set
			{
				this.SetValue(KeyTipTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AllowDropProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AllowDrop", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CacheModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CacheMode", typeof(global::Windows.UI.Xaml.Media.CacheMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.CacheMode)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ClipProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Clip", typeof(global::Windows.UI.Xaml.Media.RectangleGeometry), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.RectangleGeometry)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent DoubleTappedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DoubleTappedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent DragEnterEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DragEnterEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent DragLeaveEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DragLeaveEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent DragOverEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DragOverEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent DropEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.DropEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent HoldingEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.HoldingEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsDoubleTapEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsDoubleTapEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsHoldingEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsHoldingEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsRightTapEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsRightTapEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsTapEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsTapEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent KeyUpEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.KeyUpEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent ManipulationCompletedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ManipulationCompletedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent ManipulationDeltaEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ManipulationDeltaEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent ManipulationInertiaStartingEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ManipulationInertiaStartingEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ManipulationModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ManipulationMode", typeof(global::Windows.UI.Xaml.Input.ManipulationModes), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.ManipulationModes)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent ManipulationStartedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ManipulationStartedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent ManipulationStartingEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ManipulationStartingEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerCanceledEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerCanceledEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerCaptureLostEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerCaptureLostEvent is not implemented in Uno.");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PointerCapturesProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PointerCaptures", typeof(global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Xaml.Input.Pointer>), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Xaml.Input.Pointer>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerEnteredEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerEnteredEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerExitedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerExitedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerMovedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerMovedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerPressedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerPressedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerReleasedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerReleasedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PointerWheelChangedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PointerWheelChangedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ProjectionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Projection", typeof(global::Windows.UI.Xaml.Media.Projection), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Projection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent RightTappedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.RightTappedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent TappedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.TappedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty UseLayoutRoundingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"UseLayoutRounding", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent KeyDownEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.KeyDownEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CompositeModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CompositeMode", typeof(global::Windows.UI.Xaml.Media.ElementCompositeMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.ElementCompositeMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty Transform3DProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Transform3D", typeof(global::Windows.UI.Xaml.Media.Media3D.Transform3D), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Media3D.Transform3D)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CanDragProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CanDrag", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsAccessKeyScopeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsAccessKeyScope", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ExitDisplayModeOnAccessKeyInvoked", typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ContextFlyoutProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ContextFlyout", typeof(global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AccessKeyScopeOwnerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AccessKeyScopeOwner", typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AccessKeyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AccessKey", typeof(string), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty HighContrastAdjustmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"HighContrastAdjustment", typeof(global::Windows.UI.Xaml.ElementHighContrastAdjustment), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.ElementHighContrastAdjustment)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty XYFocusRightNavigationStrategyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"XYFocusRightNavigationStrategy", typeof(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty XYFocusUpNavigationStrategyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"XYFocusUpNavigationStrategy", typeof(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipHorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipHorizontalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipPlacementModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipPlacementMode", typeof(global::Windows.UI.Xaml.Input.KeyTipPlacementMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.KeyTipPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipVerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipVerticalOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty LightsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Lights", typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight>), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight>)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TabFocusNavigationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TabFocusNavigation", typeof(global::Windows.UI.Xaml.Input.KeyboardNavigationMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.KeyboardNavigationMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty XYFocusDownNavigationStrategyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"XYFocusDownNavigationStrategy", typeof(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty XYFocusKeyboardNavigationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"XYFocusKeyboardNavigation", typeof(global::Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.XYFocusKeyboardNavigationMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty XYFocusLeftNavigationStrategyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"XYFocusLeftNavigationStrategy", typeof(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.XYFocusNavigationStrategy)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent NoFocusCandidateFoundEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.NoFocusCandidateFoundEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent LosingFocusEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.LosingFocusEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent GettingFocusEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.GettingFocusEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PreviewKeyUpEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PreviewKeyUpEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent PreviewKeyDownEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PreviewKeyDownEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent CharacterReceivedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.CharacterReceivedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyboardAcceleratorPlacementTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyboardAcceleratorPlacementTarget", typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyboardAcceleratorPlacementModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyboardAcceleratorPlacementMode", typeof(global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"KeyTipTarget", typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent ContextRequestedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ContextRequestedEvent is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.RoutedEvent BringIntoViewRequestedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.BringIntoViewRequestedEvent is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.DesiredSize.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AllowDrop.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AllowDrop.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Opacity.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Opacity.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Clip.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Clip.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransform.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransform.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Projection.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Projection.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformOrigin.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformOrigin.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHitTestVisible.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHitTestVisible.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Visibility.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Visibility.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderSize.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.UseLayoutRounding.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.UseLayoutRounding.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transitions.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transitions.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.CacheMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CacheMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsTapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsTapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsDoubleTapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsDoubleTapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsRightTapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsRightTapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHoldingEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHoldingEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptures.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyUp.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyUp.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyDown.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyDown.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.GotFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.GotFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.LostFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.LostFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragEnter.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragEnter.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragLeave.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragLeave.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragOver.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragOver.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Drop.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.Drop.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerPressed.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerPressed.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerMoved.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerMoved.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerReleased.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerReleased.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerEntered.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerEntered.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerExited.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerExited.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptureLost.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptureLost.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCanceled.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCanceled.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerWheelChanged.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerWheelChanged.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Tapped.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.Tapped.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DoubleTapped.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DoubleTapped.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Holding.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.Holding.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.RightTapped.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.RightTapped.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarting.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarting.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationInertiaStarting.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationInertiaStarting.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarted.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarted.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationDelta.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationDelta.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationCompleted.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationCompleted.remove
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void Measure( global::Windows.Foundation.Size availableSize)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.Measure(Size availableSize)");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void Arrange( global::Windows.Foundation.Rect finalRect)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.Arrange(Rect finalRect)");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  bool CapturePointer( global::Windows.UI.Xaml.Input.Pointer value)
		{
			throw new global::System.NotImplementedException("The member bool UIElement.CapturePointer(Pointer value) is not implemented in Uno.");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void ReleasePointerCapture( global::Windows.UI.Xaml.Input.Pointer value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.ReleasePointerCapture(Pointer value)");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void ReleasePointerCaptures()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.ReleasePointerCaptures()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || false
		[global::Uno.NotImplemented]
		public  void AddHandler( global::Windows.UI.Xaml.RoutedEvent routedEvent,  object handler,  bool handledEventsToo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.AddHandler(RoutedEvent routedEvent, object handler, bool handledEventsToo)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  void RemoveHandler( global::Windows.UI.Xaml.RoutedEvent routedEvent,  object handler)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.RemoveHandler(RoutedEvent routedEvent, object handler)");
		}
		#endif
		#if false || false || NET46 || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.GeneralTransform TransformToVisual( global::Windows.UI.Xaml.UIElement visual)
		{
			throw new global::System.NotImplementedException("The member GeneralTransform UIElement.TransformToVisual(UIElement visual) is not implemented in Uno.");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void InvalidateMeasure()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.InvalidateMeasure()");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void InvalidateArrange()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.InvalidateArrange()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  void UpdateLayout()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.UpdateLayout()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual void OnDisconnectVisualChildren()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnDisconnectVisualChildren()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::Windows.Foundation.Point>> FindSubElementsForTouchTargeting( global::Windows.Foundation.Point point,  global::Windows.Foundation.Rect boundingRect)
		{
			throw new global::System.NotImplementedException("The member IEnumerable<IEnumerable<Point>> UIElement.FindSubElementsForTouchTargeting(Point point, Rect boundingRect) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.CompositeMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CompositeMode.set
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool CancelDirectManipulations()
		{
			throw new global::System.NotImplementedException("The member bool UIElement.CancelDirectManipulations() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transform3D.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transform3D.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanDrag.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanDrag.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragStarting.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragStarting.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DropCompleted.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DropCompleted.remove
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.DataTransfer.DataPackageOperation> StartDragAsync( global::Windows.UI.Input.PointerPoint pointerPoint)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<DataPackageOperation> UIElement.StartDragAsync(PointerPoint pointerPoint) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextFlyout.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextFlyout.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvoked.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvoked.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsAccessKeyScope.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsAccessKeyScope.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyScopeOwner.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyScopeOwner.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKey.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKey.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextRequested.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextRequested.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextCanceled.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextCanceled.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayDismissed.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayDismissed.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyInvoked.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyInvoked.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Lights.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipPlacementMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipPlacementMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipHorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipVerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipVerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigation.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigation.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusUpNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusUpNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusLeftNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusLeftNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusRightNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusRightNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.HighContrastAdjustment.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.HighContrastAdjustment.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.TabFocusNavigation.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TabFocusNavigation.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.GettingFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.GettingFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.LosingFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.LosingFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.NoFocusCandidateFound.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.NoFocusCandidateFound.remove
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void StartBringIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.StartBringIntoView()");
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  void StartBringIntoView( global::Windows.UI.Xaml.BringIntoViewOptions options)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.StartBringIntoView(BringIntoViewOptions options)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAccelerators.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CharacterReceived.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.CharacterReceived.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ProcessKeyboardAccelerators.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ProcessKeyboardAccelerators.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyDown.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyDown.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyUp.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyUp.remove
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  void TryInvokeKeyboardAccelerator( global::Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual global::System.Collections.Generic.IEnumerable<global::Windows.UI.Xaml.DependencyObject> GetChildrenInTabFocusOrder()
		{
			throw new global::System.NotImplementedException("The member IEnumerable<DependencyObject> UIElement.GetChildrenInTabFocusOrder() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual void OnProcessKeyboardAccelerators( global::Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnProcessKeyboardAccelerators(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipTarget.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipTarget.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.BringIntoViewRequested.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.BringIntoViewRequested.remove
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual void OnKeyboardAcceleratorInvoked( global::Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnKeyboardAcceleratorInvoked(KeyboardAcceleratorInvokedEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		protected virtual void OnBringIntoViewRequested( global::Windows.UI.Xaml.BringIntoViewRequestedEventArgs e)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnBringIntoViewRequested(BringIntoViewRequestedEventArgs e)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.BringIntoViewRequestedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextRequestedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementModeProperty.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static void RegisterAsScrollPort( global::Windows.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.RegisterAsScrollPort(UIElement element)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyDownEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CharacterReceivedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyUpEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.GettingFocusEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.LosingFocusEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.NoFocusCandidateFoundEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.LightsProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipPlacementModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipHorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipVerticalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigationProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusUpNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusLeftNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusRightNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.HighContrastAdjustmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TabFocusNavigationProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextFlyoutProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvokedProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsAccessKeyScopeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyScopeOwnerProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transform3DProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanDragProperty.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static bool TryStartDirectManipulation( global::Windows.UI.Xaml.Input.Pointer value)
		{
			throw new global::System.NotImplementedException("The member bool UIElement.TryStartDirectManipulation(Pointer value) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.CompositeModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyDownEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyUpEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerEnteredEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerPressedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerMovedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerReleasedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerExitedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptureLostEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCanceledEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerWheelChangedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TappedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DoubleTappedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.HoldingEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RightTappedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStartingEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationInertiaStartingEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStartedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationDeltaEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationCompletedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragEnterEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragLeaveEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragOverEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DropEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AllowDropProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.OpacityProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ClipProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ProjectionProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformOriginProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHitTestVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.VisibilityProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.UseLayoutRoundingProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TransitionsProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CacheModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsTapEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsDoubleTapEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsRightTapEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHoldingEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCapturesProperty.get
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.DoubleTappedEventHandler DoubleTapped
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DoubleTappedEventHandler UIElement.DoubleTapped");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DoubleTappedEventHandler UIElement.DoubleTapped");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.DragEventHandler DragEnter
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragEnter");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragEnter");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.DragEventHandler DragLeave
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragLeave");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragLeave");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.DragEventHandler DragOver
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragOver");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.DragOver");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.DragEventHandler Drop
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.Drop");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event DragEventHandler UIElement.Drop");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler GotFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event RoutedEventHandler UIElement.GotFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event RoutedEventHandler UIElement.GotFocus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.HoldingEventHandler Holding
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event HoldingEventHandler UIElement.Holding");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event HoldingEventHandler UIElement.Holding");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.KeyEventHandler KeyDown
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.KeyDown");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.KeyDown");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.KeyEventHandler KeyUp
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.KeyUp");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.KeyUp");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler LostFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event RoutedEventHandler UIElement.LostFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event RoutedEventHandler UIElement.LostFocus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.ManipulationCompletedEventHandler ManipulationCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationCompletedEventHandler UIElement.ManipulationCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationCompletedEventHandler UIElement.ManipulationCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.ManipulationDeltaEventHandler ManipulationDelta
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationDeltaEventHandler UIElement.ManipulationDelta");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationDeltaEventHandler UIElement.ManipulationDelta");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.ManipulationInertiaStartingEventHandler ManipulationInertiaStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationInertiaStartingEventHandler UIElement.ManipulationInertiaStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationInertiaStartingEventHandler UIElement.ManipulationInertiaStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.ManipulationStartedEventHandler ManipulationStarted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationStartedEventHandler UIElement.ManipulationStarted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationStartedEventHandler UIElement.ManipulationStarted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.ManipulationStartingEventHandler ManipulationStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationStartingEventHandler UIElement.ManipulationStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event ManipulationStartingEventHandler UIElement.ManipulationStarting");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerCanceled
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerCanceled");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerCanceled");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerCaptureLost
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerCaptureLost");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerCaptureLost");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerEntered
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerEntered");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerEntered");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerExited
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerExited");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerExited");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerMoved
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerMoved");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerMoved");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerPressed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerPressed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerPressed");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerReleased
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerReleased");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerReleased");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.PointerEventHandler PointerWheelChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerWheelChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event PointerEventHandler UIElement.PointerWheelChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.RightTappedEventHandler RightTapped
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event RightTappedEventHandler UIElement.RightTapped");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event RightTappedEventHandler UIElement.RightTapped");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.TappedEventHandler Tapped
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TappedEventHandler UIElement.Tapped");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TappedEventHandler UIElement.Tapped");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.DragStartingEventArgs> DragStarting
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DragStartingEventArgs> UIElement.DragStarting");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DragStartingEventArgs> UIElement.DragStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.DropCompletedEventArgs> DropCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DropCompletedEventArgs> UIElement.DropCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, DropCompletedEventArgs> UIElement.DropCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> UIElement.AccessKeyDisplayDismissed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> UIElement.AccessKeyDisplayDismissed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> UIElement.AccessKeyDisplayRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> UIElement.AccessKeyDisplayRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs> AccessKeyInvoked
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> UIElement.AccessKeyInvoked");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> UIElement.AccessKeyInvoked");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.RoutedEventArgs> ContextCanceled
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, RoutedEventArgs> UIElement.ContextCanceled");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, RoutedEventArgs> UIElement.ContextCanceled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.ContextRequestedEventArgs> ContextRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ContextRequestedEventArgs> UIElement.ContextRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ContextRequestedEventArgs> UIElement.ContextRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.GettingFocusEventArgs> GettingFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, GettingFocusEventArgs> UIElement.GettingFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, GettingFocusEventArgs> UIElement.GettingFocus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.LosingFocusEventArgs> LosingFocus
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, LosingFocusEventArgs> UIElement.LosingFocus");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, LosingFocusEventArgs> UIElement.LosingFocus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.NoFocusCandidateFoundEventArgs> NoFocusCandidateFound
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> UIElement.NoFocusCandidateFound");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> UIElement.NoFocusCandidateFound");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.CharacterReceivedRoutedEventArgs> CharacterReceived
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> UIElement.CharacterReceived");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> UIElement.CharacterReceived");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.KeyEventHandler PreviewKeyDown
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyDown");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyDown");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Input.KeyEventHandler PreviewKeyUp
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyUp");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyUp");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs> ProcessKeyboardAccelerators
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> UIElement.ProcessKeyboardAccelerators");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> UIElement.ProcessKeyboardAccelerators");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.BringIntoViewRequestedEventArgs> BringIntoViewRequested
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, BringIntoViewRequestedEventArgs> UIElement.BringIntoViewRequested");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, BringIntoViewRequestedEventArgs> UIElement.BringIntoViewRequested");
			}
		}
		#endif
	}
}
