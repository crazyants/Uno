#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum CoreTextInputPaneDisplayPolicy 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Automatic,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Manual,
		#endif
	}
	#endif
}
