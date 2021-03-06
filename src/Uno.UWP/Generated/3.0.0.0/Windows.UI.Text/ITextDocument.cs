#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextDocument 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Text.CaretType CaretType
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		float DefaultTabStop
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Text.ITextSelection Selection
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		uint UndoLimit
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.UI.Text.ITextDocument.CaretType.get
		// Forced skipping of method Windows.UI.Text.ITextDocument.CaretType.set
		// Forced skipping of method Windows.UI.Text.ITextDocument.DefaultTabStop.get
		// Forced skipping of method Windows.UI.Text.ITextDocument.DefaultTabStop.set
		// Forced skipping of method Windows.UI.Text.ITextDocument.Selection.get
		// Forced skipping of method Windows.UI.Text.ITextDocument.UndoLimit.get
		// Forced skipping of method Windows.UI.Text.ITextDocument.UndoLimit.set
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanCopy();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanPaste();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanRedo();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool CanUndo();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		int ApplyDisplayUpdates();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		int BatchDisplayUpdates();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void BeginUndoGroup();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void EndUndoGroup();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Text.ITextCharacterFormat GetDefaultCharacterFormat();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Text.ITextParagraphFormat GetDefaultParagraphFormat();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Text.ITextRange GetRange( int startPosition,  int endPosition);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Text.ITextRange GetRangeFromPoint( global::Windows.Foundation.Point point,  global::Windows.UI.Text.PointOptions options);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void GetText( global::Windows.UI.Text.TextGetOptions options, out string value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void LoadFromStream( global::Windows.UI.Text.TextSetOptions options,  global::Windows.Storage.Streams.IRandomAccessStream value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Redo();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SaveToStream( global::Windows.UI.Text.TextGetOptions options,  global::Windows.Storage.Streams.IRandomAccessStream value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SetDefaultCharacterFormat( global::Windows.UI.Text.ITextCharacterFormat value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SetDefaultParagraphFormat( global::Windows.UI.Text.ITextParagraphFormat value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SetText( global::Windows.UI.Text.TextSetOptions options,  string value);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Undo();
		#endif
	}
}
