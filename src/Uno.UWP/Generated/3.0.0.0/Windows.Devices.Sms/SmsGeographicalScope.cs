#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sms
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum SmsGeographicalScope 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		CellWithImmediateDisplay,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		LocationArea,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Plmn,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Cell,
		#endif
	}
	#endif
}
