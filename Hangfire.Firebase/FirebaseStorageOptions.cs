﻿using System;

namespace Hangfire.Firebase
{
    /// <summary>
    /// Options for FirebaseStorage
    /// </summary>
    public class FirebaseStorageOptions
    {
        /// <summary>
        /// Get or sets the request timemout for IFirebaseConfig. Default value set to 30 seconds
        /// </summary>
        public TimeSpan? RequestTimeout { get; set; }

        /// <summary>
        /// Get or set list of queues to process. Default values "default", "critical"
        /// </summary>
        public string[] Queues { get; set; }

        /// <summary>
        /// Get or set the interval timespan to process expired enteries. Default value 15 minutes
        /// Expired items under "locks", "jobs", "lists", "sets", "hashs", "counters/aggregrated" will be checked 
        /// </summary>
        public TimeSpan ExpirationCheckInterval { get; set; }

        /// <summary>
        /// Get or sets the interval timespan to aggreated the counters. Default value 1 minute
        /// </summary>
        public TimeSpan CountersAggregateInterval { get; set; }

        /// <summary>
        /// Gets or sets the interval timespan to poll the queue for processing any new jobs. Default value 2 minutes
        /// </summary>
        public TimeSpan QueuePollInterval { get; set; }

        /// <summary>
        /// Initialize the FirebaseStorageOptions class
        /// </summary>
        public FirebaseStorageOptions()
        {
            RequestTimeout = TimeSpan.FromSeconds(30);
            Queues = new[] { "default", "critical" };
            ExpirationCheckInterval = TimeSpan.FromMinutes(15);
            CountersAggregateInterval = TimeSpan.FromMinutes(1);
            QueuePollInterval = TimeSpan.FromSeconds(2);
        }
    }
}
