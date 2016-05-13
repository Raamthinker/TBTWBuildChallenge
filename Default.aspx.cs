using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using WebChart;
using WebChart.Design;
using System.Drawing;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    DataTable dt = new DataTable("Chart");
   
    string X;
    string Y;

    protected void Page_Load(object sender, EventArgs e)
    {
        Button4.Visible = false;
        DataColumn dc = new DataColumn("Catagery", typeof(string));
        DataColumn dc1 = new DataColumn("Count", typeof(int));
        dt.Columns.Add(dc);
        dt.Columns.Add(dc1);
        
            DataRow dr1 = dt.NewRow();
            dr1[0] = "Sports";
            dr1[1] = Int32.Parse(Session["sports"].ToString());
            dt.Rows.Add(dr1);
        
            DataRow dr2 = dt.NewRow();
            dr2[0] = "Entertainmaent";
            dr2[1] = Int32.Parse(Session["entertainment"].ToString());
            dt.Rows.Add(dr2);
        
            DataRow dr3 = dt.NewRow();
            dr3[0] = "Buisness";
            dr3[1] = Int32.Parse(Session["business"].ToString()); 
            dt.Rows.Add(dr3);
        
        
            DataRow dr4 = dt.NewRow();
            dr4[0] = "Education";
            dr4[1] = Int32.Parse(Session["education"].ToString()); ;
            dt.Rows.Add(dr4);
       
        //DataRow dr5 = dt.NewRow();
        //dr5[0] = "May";
        //dr5[1] = 11167;
        //dt.Rows.Add(dr5);
        //DataRow dr6 = dt.NewRow();
        //dr6[0] = "June";
        //dr6[1] = 8838;
        //dt.Rows.Add(dr6);
        //DataRow dr7 = dt.NewRow();
        //dr7[0] = "July";
        //dr7[1] = 10800;
        //dt.Rows.Add(dr7);
        //DataRow dr8 = dt.NewRow();
        //dr8[0] = "August";
        //dr8[1] = 12115;
        //dt.Rows.Add(dr8);
        //DataRow dr9 = dt.NewRow();
        //dr9[0] = "September";
        //dr9[1] = 7298;
        //dt.Rows.Add(dr9);
        //DataRow dr10 = dt.NewRow();
        //dr10[0] = "October";
        //dr10[1] = 13186;
        //dt.Rows.Add(dr10);
        //DataRow dr11 = dt.NewRow();
        //dr11[0] = "November";
        //dr11[1] = 10460;
        //dt.Rows.Add(dr11);
        //DataRow dr12 = dt.NewRow();
        //dr12[0] = "December";
        //dr12[1] = 9964;
        //dt.Rows.Add(dr12);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        PieChart chart = new PieChart();

       chart.Fill.Color = Color.FromArgb(1, Color.SteelBlue);
       chart.Line.Color = Color.SteelBlue;
        chart.Line.Width = 1;
        chart.ShowLineMarkers = true;
        chart.DataLabels.Visible = true;

       X= "Catagery";
         Y = "Count";

        chart.DataXValueField = X;
        chart.DataYValueField = Y;

        //looping through datatable and adding to chart control
        foreach (DataRow dr2 in dt.Rows)
        {
            chart.Data.Add(new ChartPoint(dr2["Catagery"].ToString(),
                     (int)System.Convert.ToSingle(dr2["Count"])));
        }

        chart.ShowLegend = true;

        ConfigureColors();

        ChartControl1.Charts.Clear();
        ChartControl1.Charts.Add(chart);
        ChartControl1.HasChartLegend = true;
        ChartControl1.Legend.Width = 140;

        ChartControl1.RedrawChart();
    }
    private void ConfigureColors()
    {
        ChartControl1.Legend.Position = LegendPosition.Bottom;
        ChartControl1.Legend.Width = 80;
        ChartControl1.YAxisFont.ForeColor = Color.Black;
       ChartControl1.XAxisFont.ForeColor = Color.Black;
        ChartControl1.ChartTitle.Text = "Catagery Wise Classification Chart";
        ChartControl1.ChartTitle.ForeColor = Color.White;
        ChartControl1.XTitle.Text = "Catagery";
        ChartControl1.YTitle.Text = "Count";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
        //     Dim ds As DataSet = GetDataSet()
        //Dim view As DataView = ds.Tables(0).DefaultView
        
        //Dim chart As New SmoothLineChart()
        //chart.Legend = "Value 1"
        //chart.DataSource = view
        //chart.DataXValueField = "Description"
        //chart.DataYValueField = "Value1"
        //chart.DataBind()
        //ChartControl1.Charts.Add(chart)
        //ChartControl1.RedrawChart()

            //SqlConnection con=new SqlConnection("server=SERVER;uid=sa;pwd=stc;database=linechart");
            //con.Open();
            //SqlDataAdapter ad=new SqlDataAdapter("select * from line",con);
            //DataSet ds=new DataSet();
            //ad.Fill(ds,"a");
            //DataView dv=ds.
            


            LineChart chart = new LineChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X = "Catagery";
            Y = "Count";


            chart.DataXValueField = X;
            chart.DataYValueField = Y;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Catagery"].ToString(),
                     (int)System.Convert.ToSingle(dr2["Count"])));
            }

            ConfigureColors();
            ChartControl1.Charts.Clear();
            ChartControl1.Charts.Add(chart);

            ChartControl1.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl1.RedrawChart();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ColumnChart chart = new ColumnChart();
        chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
        chart.Line.Color = Color.Black;
        chart.Line.Width = 1;
        chart.ShowLineMarkers = true;
        chart.DataLabels.Visible = true;

        X = "Catagery";
        Y = "Count";


        chart.DataXValueField = X;
        chart.DataYValueField = Y;

        //looping through datatable and adding to chart control
        foreach (DataRow dr2 in dt.Rows)
        {
            chart.Data.Add(new ChartPoint(dr2["Catagery"].ToString(),
                    (int)System.Convert.ToSingle(dr2["Count"])));
        }

        ConfigureColors();
        ChartControl1.Charts.Clear();
        ChartControl1.Charts.Add(chart);

        ChartControl1.HasChartLegend = true;
        chart.ShowLegend = false;
        ChartControl1.RedrawChart();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.html");
    }
}
