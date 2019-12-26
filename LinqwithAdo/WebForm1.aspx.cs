using System;
using System.Collections.Generic;

namespace LinqwithAdo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Student> result = Student.GetAllStudent();
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
    }
}