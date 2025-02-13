﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Storage.DataMovement.Models
{
    /// <summary>
    /// Options for Checkpointer used for saving transfer state to allow for
    /// resuming a transfer.
    /// </summary>
    public class TransferCheckpointerOptions
    {
        /// <summary>
        /// stub
        /// </summary>
        public string CheckpointerPath { get; private set; }

        /// <summary>
        /// Sets the checkpointer options to use a Local Checkpointer where
        /// the checkpoint information is stored at a local folder.
        /// </summary>
        /// <param name="localCheckpointerPath">
        /// The local folder where the checkpoint information will be stored.
        /// </param>
        public TransferCheckpointerOptions(string localCheckpointerPath)
        {
            CheckpointerPath = localCheckpointerPath;
        }
    }
}
