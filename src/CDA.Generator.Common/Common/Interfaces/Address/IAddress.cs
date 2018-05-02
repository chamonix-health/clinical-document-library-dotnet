﻿/*
 * Copyright 2013 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;

using Nehta.VendorLibrary.Common;

namespace Nehta.VendorLibrary.CDA
{
    /// <summary>
    /// This interface defines and constrains the Address object so as it contains only those properties
    /// that are applicable for an address.
    /// 
    /// The IAddressAustralian and IAddressInternational further constrain the address object down to either
    /// an Australian address or an international address.
    /// </summary>
    public interface IAddress : IAddressAustralian, IAddressInternational
    {
        /// <summary>
        /// Validates this address object
        /// </summary>
        /// <param name="path">The path to this object as a string</param>
        /// <param name="messages">the validation messages to date, these may be added to within this method</param>
        new void Validate(string path, List<ValidationMessage> messages);

    }
}
