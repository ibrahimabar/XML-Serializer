<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCar.aspx.cs" Inherits="AddCar" %>

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
                    <asp:DropDownList ID="ddlGaleries" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Car ID</td>
                <td>
                    <asp:TextBox ID="txtCarId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Car Brand</td>
                <td>
                    <asp:TextBox ID="txtCarBrand" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Car Model</td>
                <td>
                    <asp:TextBox ID="txtCarModel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Car Price</td>
                <td>
                    <asp:TextBox ID="txtCarPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Car Color</td>
                <td>
                    <asp:TextBox ID="txtCarColor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" 
                        Text="Add Car" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
