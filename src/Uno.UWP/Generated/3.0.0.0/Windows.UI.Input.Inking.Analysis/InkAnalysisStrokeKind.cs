#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking.Analysis
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum InkAnalysisStrokeKind 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Auto,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Writing,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Drawing,
		#endif
	}
	#endif
}
