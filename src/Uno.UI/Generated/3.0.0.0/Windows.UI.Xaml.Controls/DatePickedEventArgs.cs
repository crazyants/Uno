#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DatePickedEventArgs : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.DateTimeOffset NewDate
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset DatePickedEventArgs.NewDate is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.DateTimeOffset OldDate
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset DatePickedEventArgs.OldDate is not implemented in Uno.");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public DatePickedEventArgs() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.DatePickedEventArgs", "DatePickedEventArgs.DatePickedEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.DatePickedEventArgs.DatePickedEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.DatePickedEventArgs.OldDate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.DatePickedEventArgs.NewDate.get
	}
}
