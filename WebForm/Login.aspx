<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="/assets/css/style.css" />
    <title>Đăng nhập</title>
</head>
<body>
    <form id="form1" runat="server" class="background-full">
        <div class="container d-flex-center" style="width: 100%; height: 100vh; margin: 16px 0">
            <div class="card">
                <div class="card-header">
                    <h2>Đăng nhập</h2>
                </div>
                <div class="card-body">
                    <div class="input-group">
                        <label class="input-group-text">Tên đăng nhập: </label>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-group">
                        <label class="input-group-text">Mật khẩu: </label>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </div>
                    <div class="btn-group">
                        <asp:Button ID="btnLogin" CssClass="btn" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
