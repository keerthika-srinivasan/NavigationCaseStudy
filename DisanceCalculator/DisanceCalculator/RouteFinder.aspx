<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteFinder.aspx.cs" Inherits="DisanceCalculator.RouteFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CurrentLocation:
            <asp:TextBox runat="server" ID="startPoint" />

        </div>
        <div>
            Destination Location:<asp:TextBox runat="server" ID="endPoint"></asp:TextBox>
        </div>
        <div>
            <asp:Button Text="FindRoute" runat="server" ID="Routes" OnClick="Routes_Click" />
        </div>
        <div>
            Possible Routes:
            <asp:Repeater runat="server" ID="RouteDetails">
                <HeaderTemplate>
                    <table>
                        <thead>
                            <tr>
                                <th>S.no</th>
                                <th>Route Details</th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody>
                        <tr>
                            <td><asp:Label ID="serialNumber" Text='<%#Eval("SerialDetails")%>' runat="server" ></asp:Label></td>
                            <td><asp:Label ID="Details" Text='<%#Eval("RouteAddress")%>' runat="server"></asp:Label></td>
                        </tr>
                    </tbody>
                </ItemTemplate>
                <FooterTemplate>
                    </table>

                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
