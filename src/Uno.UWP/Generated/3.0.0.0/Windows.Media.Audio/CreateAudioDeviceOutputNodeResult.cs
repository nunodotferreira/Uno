#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CreateAudioDeviceOutputNodeResult 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Audio.AudioDeviceOutputNode DeviceOutputNode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceOutputNode CreateAudioDeviceOutputNodeResult.DeviceOutputNode is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Audio.AudioDeviceNodeCreationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceNodeCreationStatus CreateAudioDeviceOutputNodeResult.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceOutputNodeResult.Status.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceOutputNodeResult.DeviceOutputNode.get
	}
}
