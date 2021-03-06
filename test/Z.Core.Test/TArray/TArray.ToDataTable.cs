// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class TArray_ToDataTable
    {
        [TestMethod]
        public void ToDataTable()
        {
            // Type
            var @this = new[]
            {
                new TestObject
                {
                    IntColumn = 1,
                    StringColumn = "2"
                },
                new TestObject
                {
                    IntColumn = 3,
                    StringColumn = "4"
                }
            };

            // Exemples
            DataTable dt = @this.ToDataTable(); // Transorm entities to DataTable

            // Unit Test
            Assert.AreEqual(2, dt.Rows.Count);
            Assert.AreEqual(1, dt.Rows[0]["IntColumn"]);
            Assert.AreEqual("2", dt.Rows[0]["StringColumn"]);
            Assert.AreEqual(3, dt.Rows[1]["IntColumn"]);
            Assert.AreEqual("4", dt.Rows[1]["StringColumn"]);
        }

        public class TestObject
        {
            public int IntColumn;
            public string StringColumn { get; set; }
        }
    }
}