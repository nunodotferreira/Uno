#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Xml.Dom
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IXmlNodeSerializer 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string InnerText
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string GetXml();
		#endif
		// Forced skipping of method Windows.Data.Xml.Dom.IXmlNodeSerializer.InnerText.get
		// Forced skipping of method Windows.Data.Xml.Dom.IXmlNodeSerializer.InnerText.set
	}
}
