#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PolyLineSegment : global::Windows.UI.Xaml.Media.PathSegment
	{
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.PointCollection Points
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.PointCollection)this.GetValue(PointsProperty);
			}
			set
			{
				this.SetValue(PointsProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PointsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Points", typeof(global::Windows.UI.Xaml.Media.PointCollection), 
			typeof(global::Windows.UI.Xaml.Media.PolyLineSegment), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.PointCollection)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public PolyLineSegment() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.PolyLineSegment", "PolyLineSegment.PolyLineSegment()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.PolyLineSegment.PolyLineSegment()
		// Forced skipping of method Windows.UI.Xaml.Media.PolyLineSegment.Points.get
		// Forced skipping of method Windows.UI.Xaml.Media.PolyLineSegment.Points.set
		// Forced skipping of method Windows.UI.Xaml.Media.PolyLineSegment.PointsProperty.get
	}
}
