using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Sql.Query
{
    public class ContactQueries
    {
        public static string AllContact => "SELECT * FROM [tblContact] (NOLOCK)";

        public static string ContactById => "SELECT * FROM [tblContact] (NOLOCK) WHERE [ContactId] = @ContactId";

        public static string AddContact =>
            @"INSERT INTO [tblContact] ([FirstName], [LastName], [Email], [PhoneNumber]) 
            VALUES (@FirstName, @LastName, @Email, @PhoneNumber)";

        public static string UpdateContact =>
            @"UPDATE [tblContact] 
        SET [FirstName] = @FirstName, 
            [LastName] = @LastName, 
            [Email] = @Email, 
            [PhoneNumber] = @PhoneNumber
        WHERE [ContactId] = @ContactId";

        public static string DeleteContact => "DELETE FROM [tblContact] WHERE [ContactId] = @ContactId";
    }
}
