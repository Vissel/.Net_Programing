﻿<%@ Page Title="Trang Đăng Ký" Language="C#" MasterPageFile="~/pagesFrontend/FrontendLayout.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="DotNet_Website_Project.Frontend.dangky" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="clearfix"></div>


<!-- Titlebar
================================================== -->
<div id="titlebar" class="single">
	<div class="container">

		<div class="sixteen columns">
			<h2>Đăng Ký Tài Khoản</h2>
			<nav id="breadcrumbs">
				<ul>
					<li></li>
					<li><a href="#">Home</a></li>
					<li>Đăng ký tài khoản</li>
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

				<h3 style="text-align: center;" class="margin-bottom-10 margin-top-10">Đăng ký</h3>

				<form method="post" class="login">

					
					<p class="form-row form-row-wide">
						<label for="username">Tài khoản :</label>
						<input type="text" class="input-text" name="username" id="username" value="" />
					</p>

					<p class="form-row form-row-wide">
						<label for="password">Mật khẩu:</label>
						<input class="input-text" type="password" name="password" id="password" />
					</p>
					<p class="form-row form-row-wide">
						<label for="password">Nhập lại mật khẩu:</label>
						<input class="input-text" type="password" name="passwordagain" id="passwordagain" />
					</p>	
					<p class="form-row form-row-wide">
						<label for="password">Chức vụ :</label>
						<select style="height:50px;" name="chucvu">
						<option value"1">Người tìm việc</option>
						<option value"2">Người thuê việc</option>
						</select>
					</p>

					
					<p style="width: 29%;margin : 0 auto" class="form-row">
						<input type="submit" class="button" name="login" value="Đăng ký" />

						<label for="rememberme" class="rememberme">
					</p>
				
				
					
				</form>
			</div>

				
	
		</div>
	</div>
</div>

</asp:Content>
