<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="MobileShop.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: aliceblue; margin-top: 100px">
        <table class="table">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">UserName</th>
                    <th scope="col">ProductID</th>
                    <th scope="col">Quantity</th>
                    <th scope="col">Price</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="repeatCart" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("ProductID") %></td>
                            <td><%#Eval("Quantity") %></td>
                            <td><%#Eval("Price") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td></td>
                    <td></td>
                    <td>TotalPrice:</td>
                    <td>
                        <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>Your Wallet:</td>
                    <td>
                        <asp:Label ID="lblYourMoney" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="width:100%">
            <form runat="server">
                 <asp:Button OnClick="btnThanhToan_Click" ID="btnThanhToan" style="float:right" runat="server"  class="btn btn-primary" Text="Thanh toán" />
            </form>
            <%--<button style="float:right" type="button" class="btn btn-primary">Thanh toán</button>--%>
        </div>
    </div>
</asp:Content>
