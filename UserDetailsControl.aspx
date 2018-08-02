<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetailsControl.aspx.cs" Inherits="JsonExample.UserDetailsControl1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div  class="userdetails" runat="server" style="width:400px">
            <table>
		<tr>
			<td style="width:100px">
				User Id
			</td>
			<td>
				<asp:Label ID="userid" runat="server"/>
			</td>
		</tr>
        <tr>
			<td  style="width:100px">
				Id
			</td>
			<td>
				<asp:Label ID="id" runat="server"/>
			</td>
		</tr>
        <tr>
			<td style="width:100px">
				Title
			</td>
			<td>
				<asp:Label ID="title" runat="server"/>
			</td>
		</tr>
        <tr>
			<td style="width:100px">
				Completed
			</td>
			<td>
				<asp:Label ID="completed" runat="server"/>
			</td>
		</tr>
     </table>
        </div>
    </form>
</body>
</html>
