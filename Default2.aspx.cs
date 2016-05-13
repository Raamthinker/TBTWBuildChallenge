<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Spikyflower by TEMPLATED</title>
<link href="http://fonts.googleapis.com/css?family=Abel|Arvo" rel="stylesheet" type="text/css" />
<link href="style.css" rel="stylesheet" type="text/css" media="screen" />
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>
</head>
<body>
<div id="wrapper">
<div id="header">
		<div id="logo">
			<h1><a href="#">KNOWLEDGE AND INFORMATION USING MACHINE LEARNING</a></h1>
		</div>
	</div>
	<div id="page">
		<div id="content">
			<div class="post">
    <form id="form1" runat="server">
    <table  border="12" id="TABLE1" onclick="return TABLE1_onclick()"><tr><th colspan="2" style="height: 23px">
        <asp:Label ID="Label1" runat="server" Text="USER REGISTRATION"></asp:Label></th></tr>
        <tr><th>USER NAME</th><th style="width: 274px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></th></tr>
            <tr><th>PASSWORD</th><th style="width: 274px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></th></tr>
    <tr><th>CONFIRM PASSWORD</th><th style="width: 274px">
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></th></tr>
        <tr><th>GENDER</th><th style="width: 274px">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="20px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" Width="153px">
                <asp:ListItem>MALE</asp:ListItem>
                <asp:ListItem>FEMALE</asp:ListItem>
            </asp:RadioButtonList></th></tr>
        <tr><th>ADDRESS</th><th style="width: 274px">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </th></tr> 
            <tr><th>CONTACT</th><th style="width: 274px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></th></tr>
            <tr><th>E-MAIL</th><th style="width: 274px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></th></tr>
  <tr><th colspan="2" style="height: 31px">
      <asp:Button ID="Button3" runat="server" Text="SUBMIT" BackColor="#8080FF" OnClick="Button3_Click" /><asp:Button
              ID="Button4" runat="server" Text="LOGIN" BackColor="#8080FF" OnClick="Button4_Click" /></th>
      
      </tr>                         
    </table>
    </form>
</div>
		</div>
		<div id="sidebar">
			<ul>
				<li>
					<h2>Categories</h2>
				</li>
						<p>
                            EDUCATION PLUS</p>
                <p>
                    POLITICAL NEWS</p>
                <p>
                    CRIME</p>
                <p>
                    ARTICLE</p>
                <p>
                    SPORT</p>
                <p>
                    MEDIA AND THIER EVENTS</p>
						<li></li>
				<li>
					<h2>
                        MARKET REPORT</h2>
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
