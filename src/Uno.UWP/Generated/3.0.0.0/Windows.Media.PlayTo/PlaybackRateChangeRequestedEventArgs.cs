#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.PlayTo
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PlaybackRateChangeRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  double Rate
		{
			get
			{
				throw new global::System.NotImplementedException("The member double PlaybackRateChangeRequestedEventArgs.Rate is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs.Rate.get
	}
}
