#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionInfraredFrameSourceAddedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Perception.PerceptionInfraredFrameSource FrameSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionInfraredFrameSource PerceptionInfraredFrameSourceAddedEventArgs.FrameSource is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PerceptionInfraredFrameSource%20PerceptionInfraredFrameSourceAddedEventArgs.FrameSource");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.PerceptionInfraredFrameSourceAddedEventArgs.FrameSource.get
	}
}
