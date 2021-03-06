// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Update Azure Sql Advisor Recommended Action state.
    /// </summary>
    public partial class RecommendedActionUpdateStateInfo
    {
        private string _currentValue;
        
        /// <summary>
        /// Optional. Gets or sets requested recommended action state.We
        /// execute or cancel recommended action operations by altering state.
        /// You can set current value to :Pending     -> To (re-) apply an
        /// (reverted/ignored) active recommended action. Ignored     -> To
        /// ignore a recommended action so it will no longer show in active
        /// recommendations. Active      -> To restore ignored recommended
        /// action/ To cancel recommended action still in Pending. Pending
        /// Revert  -> To revert a recommended action that has been applied
        /// succesfully. Revert Canceled  -> To cancel revert operation while
        /// recommended action is Pending revert. See documentation for more.
        /// </summary>
        public string CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecommendedActionUpdateStateInfo
        /// class.
        /// </summary>
        public RecommendedActionUpdateStateInfo()
        {
        }
    }
}
