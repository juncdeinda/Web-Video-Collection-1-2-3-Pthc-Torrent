#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebUIFileSavePickerContinuationEventArgs : global::Windows.ApplicationModel.Activation.IFileSavePickerContinuationEventArgs,global::Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIFileSavePickerContinuationEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ActivationKind%20WebUIFileSavePickerContinuationEventArgs.Kind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIFileSavePickerContinuationEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ApplicationExecutionState%20WebUIFileSavePickerContinuationEventArgs.PreviousExecutionState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIFileSavePickerContinuationEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SplashScreen%20WebUIFileSavePickerContinuationEventArgs.SplashScreen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User WebUIFileSavePickerContinuationEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20WebUIFileSavePickerContinuationEventArgs.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet ContinuationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet WebUIFileSavePickerContinuationEventArgs.ContinuationData is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ValueSet%20WebUIFileSavePickerContinuationEventArgs.ContinuationData");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.StorageFile File
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFile WebUIFileSavePickerContinuationEventArgs.File is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=StorageFile%20WebUIFileSavePickerContinuationEventArgs.File");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIFileSavePickerContinuationEventArgs.ActivatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ActivatedOperation%20WebUIFileSavePickerContinuationEventArgs.ActivatedOperation");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.File.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.ContinuationData.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.ActivatedOperation.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFileSavePickerContinuationEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IFileSavePickerContinuationEventArgs
		// Processing: Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
