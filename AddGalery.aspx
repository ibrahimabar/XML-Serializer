<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddGalery.aspx.cs" Inherits="AddGalery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td>
                    Galery Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Galery City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Galery District</td>
                <td>
                    <asp:TextBox ID="txtDistrict" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGotoCar" runat="server" onclick="btnGotoCar_Click" 
                        Text="Go to Car" />
                </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" 
                        Text="Save Galery" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
