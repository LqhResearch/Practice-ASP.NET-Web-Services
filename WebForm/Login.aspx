<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="https://kit.fontawesome.com/64d58efce2.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="/assets/css/login.css" />
    <link rel="icon" href="/assets/img/favicon.png" />
    <title>Đăng nhập / Đăng ký</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="forms-container">
                <div class="signin-signup">
                    <newform class="sign-in-form">
                        <h2 class="title">Đăng nhập</h2>
                        <div class="input-field">
                            <i class="fas fa-user"></i>
                            <asp:TextBox ID="txtUserName_SignIn" runat="server"></asp:TextBox>
                        </div>
                        <div class="input-field">
                            <i class="fas fa-lock"></i>
                            <asp:TextBox ID="txtPassword_SignIn" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSignIn" runat="server" CssClass="btn solid" Text="Đăng nhập" OnClick="btnSignIn_Click" />
                        <p class="social-text">hoặc</p>
                        <div class="social-media">
                            <a href="/GoogleLogin.aspx" class="social-icon">
                                <i class="fab fa-google"></i>
                            </a>
                            <a href="#" class="social-icon">
                                <i class="fab fa-microsoft"></i>
                            </a>
                        </div>
                    </newform>
                    <newform class="sign-up-form">
                        <h2 class="title">Đăng ký</h2>
                        <div class="input-field">
                            <i class="fas fa-user"></i>
                            <asp:TextBox ID="txtUsername_SignUp" runat="server"></asp:TextBox>
                        </div>
                        <div class="input-field">
                            <i class="fas fa-envelope"></i>
                            <asp:TextBox ID="txtEmail_SignUp" runat="server"></asp:TextBox>
                        </div>
                        <div class="input-field">
                            <i class="fas fa-lock"></i>
                            <asp:TextBox ID="txtPassword_SignUp" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSignUp" runat="server" CssClass="btn solid" Text="Đăng ký" />
                        <p class="social-text">hoặc</p>
                        <div class="social-media">
                            <a href="#" class="social-icon">
                                <i class="fab fa-google"></i>
                            </a>
                            <a href="#" class="social-icon">
                                <i class="fab fa-microsoft"></i>
                            </a>
                        </div>
                    </newform>
                </div>
            </div>

            <div class="panels-container">
                <div class="panel left-panel">
                    <div class="content">
                        <h3>Thành viên mới?</h3>
                        <p>Nếu bạn chưa có tài khoản, hãy nhấn vào đây để đăng ký</p>
                        <button type="button" class="btn transparent" id="sign-up-btn">Đăng ký</button>
                    </div>
                    <img src="/img/log.svg" class="image" alt="" />
                </div>
                <div class="panel right-panel">
                    <div class="content">
                        <h3>Thành viên</h3>
                        <p>Nếu bạn đã có tài khoản, hãy nhấn vào đây để đăng nhập</p>
                        <button type="button" class="btn transparent" id="sign-in-btn">Đăng nhập</button>
                    </div>
                    <img src="/img/register.svg" class="image" alt="" />
                </div>
            </div>
        </div>

        <script src="/assets/js/login.js"></script>
    </form>
</body>
</html>
