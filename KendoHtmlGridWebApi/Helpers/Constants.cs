
namespace KendoHtmlGridWebApi
{
    // TODO: Repalce with a T4 Template
    public class Constants
    {
        public class ConnectionStrings
        {            
            public const string Default = "DefaultConnection";
            public const string Development = "Development";
        }

        public class SqlServer
        {
            public const string Customers = @"
                SELECT  customerid, firstname, lastname, company, address, city, state, postalcode, phone, email
                FROM    dbo.customer
                ORDER   BY lastname";
        }
    }
}