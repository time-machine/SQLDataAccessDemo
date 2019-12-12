using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB"));
            return connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).AsList();
        }

        public void InsertPerson(string firstName, string lastName, string email, string phone)
        {
            using IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB"));
            connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", new { FirstName = firstName, LastName = lastName, EmailAddress = email, PhoneNumber = phone });
        }
    }
}