﻿// 
//  Copyright 2014 Gustavo J Knuppe (https://github.com/knuppe)
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  

namespace SharpNL.Java {
    /// <summary>
    /// An iterator over a collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>C# port of java.until.Iterator{T}.</remarks>
    internal interface IIterator<out T> {

        /// <summary>
        /// Determines whether the iteration has more elements.
        /// </summary>
        /// <returns><c>true</c> if the iteration has more elements.; otherwise, <c>false</c>.</returns>
        bool HasNext();

        /// <summary>
        /// Gets the next element in the iteration.
        /// </summary>
        /// <returns>The next element in the iteration.</returns>
        T Next();

    }
}