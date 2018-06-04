#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum ContactChangeType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Created,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Modified,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Deleted,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ChangeTrackingLost,
		#endif
	}
	#endif
}