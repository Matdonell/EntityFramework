// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Specification.Tests.TestModels.InheritanceRelationships
{
    public class ReferenceOnBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public BaseInheritanceRelationshipEntity Parent { get; set; }
    }
}
