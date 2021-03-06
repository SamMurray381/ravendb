//-----------------------------------------------------------------------
// <copyright file="DatabaseStatistics.cs" company="Hibernating Rhinos LTD">
//     Copyright (c) Hibernating Rhinos LTD. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Raven.Abstractions.Data
{
	public class DatabaseStatistics
	{
		public string StorageEngine { get; set; }
		public Etag LastDocEtag { get; set; }

        [Obsolete("Use RavenFS instead.")]
		public Etag LastAttachmentEtag { get; set; }

		public int CountOfIndexes { get; set; }

		public int CountOfResultTransformers { get; set; }

		public int[] InMemoryIndexingQueueSizes { get; set; }

		public long ApproximateTaskCount { get; set; }

		public long CountOfDocuments { get; set; }

        [Obsolete("Use RavenFS instead.")]
		public long CountOfAttachments { get; set; }

		public string[] StaleIndexes { get; set; }

		public int CurrentNumberOfItemsToIndexInSingleBatch { get; set; }

		public int CurrentNumberOfItemsToReduceInSingleBatch { get; set; }

		public decimal DatabaseTransactionVersionSizeInMB { get; set; }

		public IndexStats[] Indexes { get; set; }

		public IndexingError[] Errors { get; set; }

		public IndexingBatchInfo[] IndexingBatchInfo { get; set; }

		public FutureBatchStats[] Prefetches { get; set; }

		public Guid DatabaseId { get; set; }

		public bool SupportsDtc { get; set; }
	}

	public class TriggerInfo
	{
		public string Type { get; set; }
		public string Name { get; set; }
	}

	public class PluginsInfo
	{
		public List<ExtensionsLog> Extensions { get; set; }
		public List<TriggerInfo> Triggers { get; set; }
	}
}
