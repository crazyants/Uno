#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ColorPickerHsvChannel 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Hue,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Saturation,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Value,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Alpha,
		#endif
	}
	#endif
}
