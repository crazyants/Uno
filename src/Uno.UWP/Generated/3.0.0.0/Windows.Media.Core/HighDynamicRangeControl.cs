#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HighDynamicRangeControl 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool Enabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool HighDynamicRangeControl.Enabled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.HighDynamicRangeControl", "bool HighDynamicRangeControl.Enabled");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Core.HighDynamicRangeControl.Enabled.set
		// Forced skipping of method Windows.Media.Core.HighDynamicRangeControl.Enabled.get
	}
}
