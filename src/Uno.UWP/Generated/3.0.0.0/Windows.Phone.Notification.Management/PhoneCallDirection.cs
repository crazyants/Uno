#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Phone.Notification.Management
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum PhoneCallDirection 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Incoming,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Outgoing,
		#endif
	}
	#endif
}
