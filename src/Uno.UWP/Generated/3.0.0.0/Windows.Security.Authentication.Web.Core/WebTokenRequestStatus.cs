#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Web.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum WebTokenRequestStatus 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Success,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UserCancel,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AccountSwitch,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UserInteractionRequired,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		AccountProviderNotAvailable,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ProviderError,
		#endif
	}
	#endif
}
