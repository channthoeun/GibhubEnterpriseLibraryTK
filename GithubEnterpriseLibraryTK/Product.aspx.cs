using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

namespace GithubEnterpriseLibraryTK
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! Page.IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            //This code is used to call stored procedure without parameter and bind gridview
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database objDataBase = factory.Create("Sales"); 
            DataSet ds = new DataSet();
            try
            {
                ds = objDataBase.ExecuteDataSet(CommandType.StoredProcedure, 
                                                    "roducts_GetProducts");
                // ds = objDataBase.ExecuteDataSet("SELECT * FROM tblProducts;");
                // ds = objDataBase.ExecuteDataSet(CommandType.Text, sql);
                grvProduct.DataSource = ds;
                grvProduct.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);

            }

        }
    }
}