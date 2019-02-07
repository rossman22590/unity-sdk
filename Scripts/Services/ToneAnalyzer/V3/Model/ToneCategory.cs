/**
* Copyright 2018, 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using FullSerializer;

namespace IBM.Watson.ToneAnalyzer.V3.Model
{
    /// <summary>
    /// ToneCategory.
    /// </summary>
    public class ToneCategory
    {
        /// <summary>
        /// An array of `ToneScore` objects that provides the results for the tones of the category.
        /// </summary>
        [fsProperty("tones")]
        public List<ToneScore> Tones { get; set; }
        /// <summary>
        /// The unique, non-localized identifier of the category for the results. The service can return results for the
        /// following category IDs: `emotion_tone`, `language_tone`, and `social_tone`.
        /// </summary>
        [fsProperty("category_id")]
        public string CategoryId { get; set; }
        /// <summary>
        /// The user-visible, localized name of the category.
        /// </summary>
        [fsProperty("category_name")]
        public string CategoryName { get; set; }
    }


}