#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICustomNavigationProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		object NavigateCustom( global::Windows.UI.Xaml.Automation.Peers.AutomationNavigationDirection direction);
		#endif
	}
}