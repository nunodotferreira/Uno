#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ApplicationSettings
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void CredentialCommandCredentialDeletedHandler(global::Windows.UI.ApplicationSettings.CredentialCommand @command);
	#endif
}