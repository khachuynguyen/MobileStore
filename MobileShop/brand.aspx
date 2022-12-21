<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="brand.aspx.cs" Inherits="MobileShop.brand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- brand -->
    <div class="brand">
        <div class="container">

        </div>
        <div class="brand-bg">
            <div class="container">
                <div class="row">
                    <asp:Repeater ID="dsProduct" runat="server">
                        <ItemTemplate>
                        <div class="col-xl-4 col-lg-4 col-md-4 col-sm-6 margin">
                        <div class="brand_box">
                            <img src="images/<%#Eval("Image") %>" alt="img" />
                            <h4><strong class="red"><%#Eval("Price") %></strong> USD</h4>
                            <span><a href="productdetail.aspx?id=<%#Eval("ProductID") %>">     <%#Eval("Name") %> </a> </span>
                            <h5><%#Eval("Category") %></h5>
                            <a href="cart.aspx?id=<%#Eval("ProductID") %>">  <button type="button" class="btn btn-success">  Add to cart </button></a> 
                        </div>
                        </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>

    <!-- end brand -->
</asp:Content>
