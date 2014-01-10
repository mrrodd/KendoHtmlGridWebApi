using Dapper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoHtmlGridWebApi.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace KendoHtmlGridWebApi.Controllers
{
    public class CustomerController : ApiController
    {
        // GET api/customer
        //public DataSourceResult Get([ModelBinder(typeof(DataSourceRequestModelBinder))] DataSourceRequest request, string state)
        //{
        //    var db = new SqlConnection(ConfigurationManager.ConnectionStrings[Constants.ConnectionStrings.Development].ConnectionString);
        //    var customers = db.Query<Customer>(Constants.SqlServer.Customers, new { state });
        //    return customers.ToDataSourceResult(request);
        //}

        public DataSourceResult Get([ModelBinder(typeof(DataSourceRequestModelBinder))] DataSourceRequest request)
        {
            var db = new SqlConnection(ConfigurationManager.ConnectionStrings["Development"].ConnectionString);
            var customers = db.Query<Customer>(@"
                SELECT  customerid, firstname, lastname, company, address, city, state, postalcode, phone, email
                FROM    dbo.customer
                ORDER   BY lastname"
            );
            return customers.ToDataSourceResult(request);
        }

    }
}
