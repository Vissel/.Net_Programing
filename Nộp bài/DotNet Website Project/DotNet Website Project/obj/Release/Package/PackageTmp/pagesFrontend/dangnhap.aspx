﻿    <%@ Page Title="Trang Đăng Nhập" Language="C#" MasterPageFile="~/pagesFrontend/FrontendLayout.Master" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="DotNet_Website_Project.dangnhap" %>
<asp:Content ID="dangnhapContent" ContentPlaceHolderID="MainContent" runat="server">

    <body>
        <div class="clearfix"></div>


<!-- Titlebar
================================================== -->
<div id="titlebar" class="single">
	<div class="container">

		<div class="sixteen columns">
			<h2>My Account</h2>
			<nav id="breadcrumbs">
				<ul>
					<li>You are here:</li>
					<li><a href="#">Home</a></li>
					<li>My Account</li>
				</ul>
			</nav>
		</div>

	</div>
</div>

<div class="container">

	<div class="my-account">
	

		<div class="tabs-container">
			<!-- Login -->
			<div class="tab-content" id="tab1" style="display: none;">

				<h3 style="text-align: center;" class="margin-bottom-10 margin-top-10">Đăng nhập</h3>

				<form method="post" class="login">

					
					<p class="form-row form-row-wide">
						<label for="username">Tài khoản :</label>
						<input type="text" class="input-text" name="username" id="username" value="" />
					</p>

					<p class="form-row form-row-wide">
						<label for="password">Mật khẩu:</label>
						<input class="input-text" type="password" name="password" id="password" />
					</p>


					<p style="width: 29%;margin : 0 auto" class="form-row">
						<input type="submit" class="button" name="login" value="Đăng nhập" />

						<label for="rememberme" class="rememberme">
					</p>
					<p style="width: 29%;margin : 0 auto" class="lost_password">
					<a href="#" > Quên mật khẩu ?</a>
					</p>
	
	
		<label style="width: 40%;font-size:12pt;margin : 0 auto">Đăng nhập với tài khoản </label>
		<div   style="width : 25%;margin: 0 auto;">
		<ul class="social-icons">
				<li><a class="facebook" href="#"><i class="icon-facebook"></i></a></li>
				<li><a class="gplus" href="#"><i class="icon-gplus"></i></a></li>
		</ul>
		</div>
				
					
				</form>
			</div>

				
	
		</div>
	</div>
</div>
      </body>
</asp:Content>
