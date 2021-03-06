#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Management.Deployment
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum DeploymentOptions 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ForceApplicationShutdown,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DevelopmentMode,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		InstallAllResources,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ForceTargetApplicationShutdown,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		RequiredContentGroupOnly,
		#endif
	}
	#endif
}
