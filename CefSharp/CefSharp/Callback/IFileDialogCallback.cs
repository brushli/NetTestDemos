// Copyright © 2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Collections.Generic;

namespace CefSharp
{
    /// <summary>
    /// Callback interface for asynchronous continuation of file dialog requests.
    /// </summary>
    public interface IFileDialogCallback : IDisposable
    {
        /// <summary>
        /// Continue the file selection.
        /// </summary>
        /// <param name="filePaths">should be a single value or a list of values depending on the dialog mode.
        /// An empty value is treated the same as calling Cancel().</param>
        void Continue(List<string> filePaths);

        /// <summary>
        /// Cancel the file selection.
        /// </summary>
        void Cancel();

        /// <summary>
        /// Gets a value indicating whether the callback has been disposed of.
        /// </summary>
        bool IsDisposed { get; }
    }
}
