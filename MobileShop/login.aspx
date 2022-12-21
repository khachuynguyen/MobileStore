<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MobileShop.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        
        <div class="noi-dung">
            <div class="form">
                <h2>Trang Đăng Nhập</h2>
                <form action="" runat="server" >
                    <div class="input-form">
                        <span>Tên Người Dùng</span>
                        <input type="text" name="" id="txtUsername" runat="server">
                    </div>
                    <div class="input-form">
                        <span>Mật Khẩu</span>
                        <input type="password" name="" runat="server" id="txtPass">
                    </div>
                    <div class="nho-dang-nhap">
                        <asp:Label ID="lblError" runat="server" Text="" CssClass="label"></asp:Label><br />
                        <label><input type="checkbox" name=""> Nhớ Đăng Nhập</label>
                        
                    </div>
                    <div class="input-form">
                        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng Nhập" OnClick="btnDangNhap_Click" />
                       
                    </div>
                    <div class="input-form">
                        <p>Bạn Chưa Có Tài Khoản? <a href="signup.aspx">Đăng Ký</a></p>
                    </div>
                </form>
                <h3>Đăng Nhập Bằng Mạng Xã Hội</h3>
                <ul class="icon-dang-nhap">
                    <li><i class="fa fa-facebook" aria-hidden="true"></i></li>
                    <li><i class="fa fa-google" aria-hidden="true"></i></li>
                    <li><i class="fa fa-twitter" aria-hidden="true"></i></li>
                </ul>
                
            </div>
        </div>
    </section>
</asp:Content>
