﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uno.Extensions;
using Uno.Logging;

namespace Windows.UI.Xaml.Media.Animation
{
	/// <summary>
	/// Value animator. Base on the Android ValueAnimator, this object is similar semantically. 
	/// 
	/// Used ONLY with DoubleAnimation, it will animate a float value on the animation loop
	/// See https://web.archive.org/web/20160303015227/https://www.bigspaceship.com/ios-animation-intervals/
	/// 
	/// </summary>
	internal static partial class AnimatorFactory
	{
		/// <summary>
		/// Creates the actual animator instance
		/// </summary>
		internal static IValueAnimator Create(Timeline timeline, double startingValue, double targetValue)
		{
			if (!timeline.GetIsHardwareAnimated())
			{
				return new FloatValueAnimator((float)startingValue, (float)targetValue);
			}
			// If we are animating a GPU-bound animation, create a GPU specific value animator
			else
			{
				return new GPUFloatValueAnimator((float)startingValue, (float)targetValue, timeline.PropertyInfo.GetPathItems());
			}
		}
	}
}
