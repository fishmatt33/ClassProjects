using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NUnit.Framework;

namespace DapperInClass
{
    [TestFixture]
    public class DapperTests
    {
        [Test]
        public void Test1()
        {
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = conn.Query<Employee>("SELECT * FROM Employees").ToList();

                Assert.AreEqual(9, employees.Count);
            }
        }

        [Test]
        public void TestWithAnnonymousParameters()
        {
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                var employees = conn.Query<Employee>("SELECT * FROM Employees WHERE EmployeeId > @EmployeeId",
                    new {EmployeeId = 5}).ToList();

                Assert.AreEqual(4, employees.Count);
            }
        }

        [Test]
        public void TestWithDynamicParamaters()
        {
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeId", 5);
                var employees = conn.Query<Employee>("SELECT * FROM Employees WHERE EmployeeId > @EmployeeId", p).ToList();

                Assert.AreEqual(4, employees.Count);
            }
        }
    }
}
