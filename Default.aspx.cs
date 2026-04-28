using System;
using HashLibrary;
using CSE445Project.MovieServiceRef;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445Project
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void btnTestService_Click(object sender, EventArgs e)
        {
            MovieServiceClient client = new MovieServiceClient();
            string result = client.GetRecommendation(txtServiceInput.Text);
            lblServiceResult.Text = "Movie: " + result;
            
        }

        protected void btnTestHash_Click(object sender, EventArgs e)
        {
            string result = HashClass.ComputeHash(txtHashInput.Text);
            lblHashResult.Text = "Hashed Value: " + result;
        }

        protected void btnTestGlobal_Click(object sender, EventArgs e)
        {
            if (Application["VisitorCount"] != null)
            {
                lblGlobalResult.Text = "Total App Visitors: " + Application["VisitorCount"].ToString();
            }
        }
    }
}