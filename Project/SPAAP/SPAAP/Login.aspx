﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SPAAP.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 
       <meta charset="utf-8" />
        <title>Login</title>
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

        <meta content="A fully featured admin theme which can be used to build CRM, CMS, etc." name="description" />
        <meta content="Coderthemes" name="author" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />

        <!-- App favicon -->
        <link rel="shortcut icon" href="assets/images/favicon.ico">

        <!-- App css -->
        <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <link href="assets/css/metismenu.min.css" rel="stylesheet" type="text/css" />
        <link href="assets/css/icons.css" rel="stylesheet" type="text/css" />
        <link href="assets/css/style.css" rel="stylesheet" type="text/css" />

        <link href="../plugins/bootstrap-select/css/bootstrap-select.min.css" rel="stylesheet" />

        <script src="assets/js/modernizr.min.js"></script>
</head>
     <form runat="server">
  <body class="bg-transparent">

        <!-- HOME -->
        <section>
            <div class="container">
                <div class="row">
                    <div class="col-sm-12">

                        <div class="wrapper-page">

                            <div class="m-t-40 account-pages">
                                <div class="text-center account-logo-box">
                                    <h2 class="text-uppercase">
                                        <a href="index.html" class="text-success">
                                            <%--<span><img src="assets/images/logo_dark.png" alt="" height="30"></span>--%>
                                            Login
                                        </a>
                                    </h2>
                                    <!--<h4 class="text-uppercase font-bold m-b-0">Sign In</h4>-->
                                </div>
                                <div class="account-content">
                                    <form class="form-horizontal" action="#">

                                        <div class="form-group m-b-25">
                                            <div class="col-12">
                                                <label for="emailaddress">Email address</label>
                                               <%-- <input class="form-control input-lg" type="email" id="emailaddress" required="" placeholder="john@deo.com">--%>
                                                 <asp:TextBox ID="txtEmail" runat="server" type="email" required="" placeholder="john@deo.com"  class="form-control input-lg" ></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group m-b-25">
                                            <div class="col-12">
                                                <%--<a href="page-recoverpw.html" class="text-muted float-right">Forgot your password?</a>--%>
                                                <label for="password">Password</label>
                                               <%-- <input class="form-control input-lg" type="password" required="" id="password" placeholder="Enter your password">--%>
                                                 <asp:TextBox ID="txtPassword" runat="server" type="password" required="" placeholder="Enter your password" class="form-control input-lg" ></asp:TextBox>
                                            </div>
                                        </div>

                                        

                                        

                                        <div class="form-group account-btn text-center m-t-10">
                                            <div class="col-12">
                                               <asp:Button ID="btnSignin" class="btn w-lg btn-rounded btn-lg btn-primary waves-effect waves-light" text="SignIn" runat="server" onclick="OnSignIn_Click"/>
                                            </div>
                                        </div>

                                    </form>

                                    <div class="clearfix"></div>

                                </div>
                            </div>
                            <!-- end card-box-->


                            <div class="row m-t-50">
                                <div class="col-sm-12 text-center">
                                    <p class="text-muted">Don't have an account? <a href="page-register.html" class="text-dark m-l-5">Sign Up</a></p>
                                </div>
                            </div>

                        </div>
                        <!-- end wrapper -->

                    </div>
                </div>
            </div>
          </section>
          <!-- END HOME -->



        <script>
            var resizefunc = [];
        </script>

        <!-- jQuery  -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/bootstrap.bundle.min.js"></script>
        <script src="assets/js/metisMenu.min.js"></script>
        <script src="assets/js/waves.js"></script>
        <script src="assets/js/jquery.slimscroll.js"></script>
        <script src="../plugins/bootstrap-select/js/bootstrap-select.min.js"></script>

        <!-- App js -->
        <script src="assets/js/jquery.core.js"></script>
        <script src="assets/js/jquery.app.js"></script>

    </body>

</form>
</html>
