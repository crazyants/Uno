#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface INDDownloadEngine 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		uint BufferFullMaxThresholdInSamples
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		uint BufferFullMinThresholdInSamples
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanSeek
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Media.Protection.PlayReady.NDDownloadEngineNotifier Notifier
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Open( global::System.Uri uri,  byte[] sessionIDBytes);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Pause();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Resume();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Close();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Seek( global::System.TimeSpan startPosition);
		#endif
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDDownloadEngine.CanSeek.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDDownloadEngine.BufferFullMinThresholdInSamples.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDDownloadEngine.BufferFullMaxThresholdInSamples.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.INDDownloadEngine.Notifier.get
	}
}
