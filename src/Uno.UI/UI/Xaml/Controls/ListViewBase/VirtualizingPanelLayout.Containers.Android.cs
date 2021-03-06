﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.UI;
using System.Linq;

namespace Windows.UI.Xaml.Controls
{
	public partial class VirtualizingPanelLayout
	{
		/// <summary>
		/// A row or column.
		/// </summary>
		protected class Line
		{
			public int NumberOfViews { get; set; }
			/// <summary>
			/// Dimension of this line in the direction of scroll, in physical units
			/// </summary>
			public int Extent { get; set; }
			/// <summary>
			/// Dimension of this line orthogonal to the direction of scroll, in physical units
			/// </summary>
			public int Breadth { get; set; }

			public IndexPath FirstItem { get; set; }

			public IndexPath LastItem { get; set; }
		}

		/// <summary>
		/// A materialized group.
		/// </summary>
		private class Group
		{
			private readonly Deque<Line> _lines = new Deque<Line>();

			public Group(int groupIndex)
			{
				GroupIndex = groupIndex;
			}

			public IReadOnlyCollection<Line> Lines => _lines;
			/// <summary>
			/// The absolute index of this group within the source collection.
			/// </summary>
			public int GroupIndex { get; }

			public int Extent => RelativeHeaderPlacement == RelativeHeaderPlacement.Inline ?
				ItemsExtentOffset + ItemsExtent :
				Math.Max(ItemsExtent, HeaderExtent);

			public int Breadth => ItemsBreadthOffset + ItemsBreadth;
			/// <summary>
			/// The extent of all materialized lines.
			/// </summary>
			public int ItemsExtent => _lines.Sum(l => l.Extent);
			/// <summary>
			/// The breadth of the broadest materialized line.
			/// </summary>
			public int ItemsBreadth => _lines.Count > 0 ? _lines.Max(l => l.Breadth) : 0;

			/// <summary>
			/// The offset of the group relative to the top/left of panel (equivalent to GetChildStart()).
			/// </summary>
			public int Start
			{
				get;
				set;
			}

			public int End => Start + Extent;

			public RelativeHeaderPlacement RelativeHeaderPlacement { get; set; }

			/// <summary>
			/// The extent of the header, in physical units. 
			/// </summary>
			public int HeaderExtent { get; set; }

			/// <summary>
			/// The breadth of the header, in physical units.
			/// </summary>
			public int HeaderBreadth { get; set; }

			public int ItemsExtentOffset => RelativeHeaderPlacement == RelativeHeaderPlacement.Inline ? HeaderExtent : 0;

			public int ItemsBreadthOffset => RelativeHeaderPlacement == RelativeHeaderPlacement.Adjacent ? HeaderBreadth : 0;
			
			public Line GetTrailingLine(FillDirection fillDirection)
			{
				return fillDirection == FillDirection.Forward ?
					GetFirstLine() :
					GetLastLine();
			}

			public Line GetLeadingLine(FillDirection fillDirection)
			{
				return fillDirection == FillDirection.Forward ?
					GetLastLine() :
					GetFirstLine();
			}

			public void AddLine(Line newLine, FillDirection fillDirection)
			{
				if (fillDirection == FillDirection.Forward)
				{
					_lines.AddToBack(newLine);
				}
				else
				{
					_lines.AddToFront(newLine);
					Start -= newLine.Extent;
				}
			}

			public void RemoveTrailingLine(FillDirection fillDirection)
			{
				if (fillDirection == FillDirection.Forward)
				{
					var removed = _lines.RemoveFromFront();
					//Move Start forward because we are removing a line from the start
					Start += removed.Extent;
				}
				else
				{
					_lines.RemoveFromBack();
				}
			}

			public int GetLeadingEdge(FillDirection fillDirection)
			{
				return fillDirection == FillDirection.Forward ?
					End :
					Start;
			}

			public IndexPath GetLeadingMaterializedItem(FillDirection fillDirection)
			{
				return fillDirection == FillDirection.Forward ?
					GetLastLine().LastItem :
					GetFirstLine().FirstItem;
			}

			public IndexPath GetTrailingMaterializedItem(FillDirection fillDirection)
			{
				return fillDirection == FillDirection.Forward ?
					GetFirstLine().FirstItem :
					GetLastLine().LastItem;
			}

			private Line GetFirstLine()
			{
				if (_lines.Count == 0)
				{
					return null;
				}
				return _lines[0];
			}

			private Line GetLastLine()
			{
				if (_lines.Count == 0)
				{
					return null;
				}
				return _lines[_lines.Count - 1];
			}
		}
	}
}
