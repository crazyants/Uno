#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct BitmapPlaneDescription 
	{
		// Forced skipping of method Windows.Graphics.Imaging.BitmapPlaneDescription.BitmapPlaneDescription()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int StartIndex;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Width;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Height;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  int Stride;
		#endif
	}
}
