<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="productdetail.aspx.cs" Inherits="MobileShop.productdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="brand">
        <div class="container">

        </div>
        <div class="brand-bg">
             
            <div class="container">
                <div class="row">

                    
                    <asp:Repeater ID="Product" runat="server">
                        <ItemTemplate>
                        
                        <div class="col-xl-4 col-lg-4 col-md-4 col-sm-6 margin">
                        <div class="brand_box">
                            <img src="images/<%#Eval("Image") %>" alt="img" />
                            <h4><strong class="red"><%#Eval("Price") %></strong> USD</h4>
                            <span><a href="productdetail.aspx?id=<%#Eval("ProductID") %>">     <%#Eval("Name") %> </a> </span>
                            <h5><%#Eval("Category") %></h5>
                            <i><img src="images/star.png"/></i>
                            <i><img src="images/star.png"/></i>
                            <i><img src="images/star.png"/></i>
                            <i><img src="images/star.png"/></i>
                        </div>
                        </div>
                        </ItemTemplate>
                        
                    </asp:Repeater>
                    
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
