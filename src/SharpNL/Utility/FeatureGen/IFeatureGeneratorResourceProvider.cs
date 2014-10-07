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

namespace SharpNL.Utility.FeatureGen {
    /// <summary>
    /// The <see cref="IFeatureGeneratorResourceProvider"/> provides access to the resources
    /// provided in the model. Inside the model resources are identified by a name.
    /// </summary>
    /// <remarks>
    /// This class is not be intended to be implemented by users. <br />
    /// All implementing classes must be thread safe.
    /// </remarks>
    public interface IFeatureGeneratorResourceProvider {
        /// <summary>
        /// Retrieves the resource object for the given name/identifier.
        /// </summary>
        /// <param name="resourceIdentifier">The identifier which names the resource.</param>
        /// <returns>The resource object.</returns>
        object GetResource(string resourceIdentifier);
    }
}