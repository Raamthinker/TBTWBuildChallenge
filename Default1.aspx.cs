using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection("server=USER-PC\\SQLEXPRESS;Integrated Security=True;database=sample");
            con.Open();
            SqlCommand com = new SqlCommand("select Username from Register where username='" + TextBox1.Text + "'", con);
            SqlCommand com1 = new SqlCommand("select Password from Register where username='" + TextBox1.Text + "'", con);
            string a = com.ExecuteScalar().ToString();
            string b = com1.ExecuteScalar().ToString();
            con.Close();
            if (a == TextBox1.Text && b == TextBox2.Text)
            {
                Session["UserName"] = TextBox1.Text;
                Response.Redirect("Default5.aspx");
                

            }
            else
            {
                Response.Write("<script>alert('invalid user')</script>");
            }


        }
        catch
        {
            Response.Write("<script>alert('invalid user')</script>");
        }
        
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");

    }
}
