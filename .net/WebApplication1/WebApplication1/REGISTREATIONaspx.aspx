﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="REGISTREATIONaspx.aspx.cs" Inherits="WebApplication1.REGISTREATIONaspx" %>

<!DOCTYPE html>

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
                      Name:
                  </td>
                  <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
              </tr>
                  <tr>
                  <td>
                      Phone Num:
                  </td>
                      <td><asp:TextBox ID="txtphonenum" runat="server"></asp:TextBox></td>
              </tr>
                  <tr>
                  <td>
                      Address:
                  </td>
                      <td><asp:TextBox ID="txtaddress" runat="server"></asp:TextBox></td>
              </tr>
                <tr>
                    <td> <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                
                    
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
             
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /></td>
                </tr>
               
                

            </table>
        </div>
    <p>
        &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    </body>
</html>
