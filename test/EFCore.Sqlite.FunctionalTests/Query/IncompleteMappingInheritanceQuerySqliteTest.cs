﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.Query;

public class IncompleteMappingInheritanceQuerySqliteTest : TPHInheritanceQueryTestBase<
    IncompleteMappingInheritanceQuerySqliteFixture>
{
    public IncompleteMappingInheritanceQuerySqliteTest(
        IncompleteMappingInheritanceQuerySqliteFixture fixture,
        ITestOutputHelper testOutputHelper)
        : base(fixture, testOutputHelper)
    {
    }

    public override void Can_insert_update_delete()
    {
        // Test from InheritanceSqliteTest causes transaction failure. We only need to test it once.
    }
}
