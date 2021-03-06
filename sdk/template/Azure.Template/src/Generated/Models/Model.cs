// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Template.Models
{
    /// <summary> The Model. </summary>
    public partial class Model
    {
        /// <summary> A description about the set of tags. </summary>
        public string ModelProperty { get; set; }
        /// <summary> Fruit. </summary>
        public Fruit Fruit { get; set; }
        /// <summary> Day of week. </summary>
        public DaysOfWeek DaysOfWeek { get; set; }
    }
}
