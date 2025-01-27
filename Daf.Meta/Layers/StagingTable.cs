﻿// SPDX-License-Identifier: MIT
// Copyright © 2021 Oscar Björhn, Petter Löfgren and contributors

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Daf.Meta.Layers
{
	public class StagingTable
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "We need at least an init setter in order to support deserialization.")]
		public List<StagingColumn> Columns { get; init; } = new List<StagingColumn>();

		[JsonIgnore]
		public List<string> ColumnNames
		{
			get
			{
				List<string> names = new();

				foreach (StagingColumn? column in Columns)
				{
					names.Add(column.Name);
				}

				return names;
			}
		}
	}
}
