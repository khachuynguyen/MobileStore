<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="MobileShop.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        
        <div class="noi-dung">
            <div class="form">
                <h2>Trang Đăng Ký</h2>
                <form action="" runat="server">
                    <div class="input-form">
                        <span>Tên Người Dùng</span>
                        <input type="text" name="" id="txtUsername" runat="server">
                    </div>
                    <div class="input-form">
                        <span>Email</span>
                        <input type="text" name="" id="txtEmail" runat="server">
                    </div>
                    <div class="input-form">
                        <span>Full name</span>
                        <input type="text" name=""  id="txtFullname" runat="server">
                    </div>
                    <div class="input-form">
                        <span>Mật Khẩu</span>
                        <input type="password" name=""  id="txtPass" runat="server">
                    </div>
                    <div class="input-form">
                        <span>Nhập Lại Mật Khẩu</span>
                        <input type="password" name=""  id="txtRetype" runat="server">
                    </div>
                    <div class="input-form">
                        <asp:Label ID="lblEr" runat="server" Text="" CssClass="label" ></asp:Label>
                    </div>
                    <div class="input-form">
                        <asp:Button ID="btnSignUp" runat="server" Text="Đăng Ký" OnClick="btnSignUp_Click" />
                        
                    </div>
                </form>
            </div>
        </div>
    </section>
</asp:Content>


