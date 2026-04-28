<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445Project.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Tracker App</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Application and Components Summary Table</h2>
            <p>Deployment URL: 
            <a href="<%= Request.Url.AbsoluteUri %>"><%= Request.Url.AbsoluteUri %></a>
            </p>

            <table border="1" cellpadding="5" cellspacing="0">
                <tr>
                    <th>Provider Name</th>
                    <th>Page and component type (aspx, DLL, SVC, etc.)</th>
                    <th>Component description (Inputs/Outputs)</th>
                    <th>Actual resources and methods used (Where it's used)</th>
                    <th>TryIt Action</th>
                </tr>
                
                <tr>
                    <td>Vinh Pham</td>
                    <td>SVC Service</td>
                    <td>Movie Recommendation Service. Input: string. Output: string.</td>
                    <td>C# WCF Service. Called via REST/SOAP. Used on Default page.</td>
                    <td>
                        <asp:TextBox ID="txtServiceInput" runat="server"></asp:TextBox>
                        <asp:Button ID="btnTestService" runat="server" Text="Test Service" OnClick="btnTestService_Click" />
                        <asp:Label ID="lblServiceResult" runat="server"></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td>Vinh Pham</td>
                    <td>DLL</td>
                    <td>Hashing function for passwords. Input: String. Output: Hashed String.</td>
                    <td>Class library in C#. Used when saving XML data.</td>
                    <td>
                        <asp:TextBox ID="txtHashInput" runat="server"></asp:TextBox>
                        <asp:Button ID="btnTestHash" runat="server" Text="Test Hash" OnClick="btnTestHash_Click" />
                        <asp:Label ID="lblHashResult" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>Vinh Pham</td>
                    <td>Global.asax</td>
                    <td>Tracks total application visitors.</td>
                    <td>C# script inside Global.asax file.</td>
                    <td>
                        <asp:Button ID="btnTestGlobal" runat="server" Text="Check Visitor Count" OnClick="btnTestGlobal_Click" />
                        <br /><asp:Label ID="lblGlobalResult" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>