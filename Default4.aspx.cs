<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Spikyflower by TEMPLATED</title>
<link href="http://fonts.googleapis.com/css?family=Abel|Arvo" rel="stylesheet" type="text/css" />
<link href="style.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
<div id="wrapper">
<div id="header">
		<div id="logo">
			<h1><a href="#">KNOWLEDGE AND INFORMATION USING MACHINE LEARNING ALGORITHM</a></h1>
		</div>
	</div>
	<div id="page">
		<div id="content">
			<div class="post">
    <form id="form1" runat="server">
    <table border="12" id="TABLE1" style="width: 23px; height: 23px"><tr><th colspan="2" style="width: 321px">
        <asp:Label ID="Label11" runat="server" Text="MAIN FORM" Width="440px"></asp:Label></th></tr>
        <tr><th rowspan="4" style="width: 321px">
            <asp:ListBox ID="ListBox1" runat="server" Height="322px" Width="200px"></asp:ListBox></th>
            <th align="left">
                <asp:CheckBox ID="CheckBox1" runat="server" Width="123px" Text=" SPORTS" /><br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="BUSINESS" /><br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="EDUCATION" /><br />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="ENTERTAINMENT" /><br />
                
            </th></tr>
            <tr><th style="width: 321px; height: 30px;">
                <asp:Button ID="Button1" runat="server" Text="CLASSIFICATION" OnClick="Button1_Click" /><asp:Button ID="Button2"
                    runat="server" Text="LOAD FILE" OnClick="Button2_Click" /><br />
                <asp:Button ID="Button3" runat="server" Text="CHART" OnClick="Button3_Click" /></th></tr>
    </table>
    <table><tr><th align="left">
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label></th></tr>
        
        <tr><th align="left">
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label></th></tr>
        <tr><th align="left">
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label></th></tr>
        <tr><th align="left">
        <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label></th></tr>
        </table>
        <table><tr><th>SPORTS<br />
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox></th>
           <th>BUISNESS<br />
            <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox></th> </tr>
            <tr><th>EDUCATION<br />
            <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox></th>
           <th>ENTERTAINMENT<br />
            <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox></th> </tr></table>
    
    </form>
    </div>
		</div>
		<div id="sidebar">
			<ul>
				<li>
					<h2>Categories</h2>
				</li>
						<p> EDUCATION PLUS </p>
<p> POLITICAL NEWS  </p>
<p> CRIME</p>
<p> ARTICLE</p>
<P> SPORTS</p>
<p> MEDIA AND THEIR EVENTS</p>
						<li></li>
				<li>
					<h2>
                        MARKET REport</h2>
				</li>
			</ul>
            <p>
                &nbsp;</p>
            <p>
                GOLD &nbsp; &nbsp; &nbsp; 24ct(1 gm):2,707.00rs</p>
            <p>
                SILVER &nbsp; &nbsp; Bar(1 kg):37.00rs</p>
            <p>
                EXCHANGE&nbsp; US$:61.88rs Euro:70.28</p>
		</div>
		
	</div>
	</div>
<div id="footer">
	<p>
        www.facebook.com/decannews.....</p>
</div>
<!-- end #footer -->
</body>
</html>
