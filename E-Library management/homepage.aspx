<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication4.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <section class="home-img">
        <img style="width:100%; height:40vh;" src="imgs/lib.jpeg" class="img-fluid "/>
    </section>
    <section class="features">
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Features</h2>
                  <p><b>Our 3 Primary Features -</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/digital-inventory.png"/>
                  <h4>Digital Book Inventory</h4>
                  <p class="text-justify">Find all kinds of books you need for your study and research purposes. They come in electronic forms making it posssible to use remotely from anywhere offcampus</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/search-online.png"/>
                  <h4>Search Books</h4>
                  <p class="text-justify">Search for all books that are physically available in the library before going to the library to pick them. You can also get books that are electronic and read from anywhere</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/defaulters-list.png"/>
                  <h4>Defaulter List</h4>
                  <p class="text-justify">Log in to check if you are a defaulter such that you can find a ay forward with the librarian </p>
               </center>
            </div>
         </div>
      </div>
   </section>
   <section class="process">
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Process</h2>
                  <p><b>We have a Simple 3 Step Process</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                  <img width="150" src="imgs/sign-up.png" />
                  <h4><a href="usersignup.aspx">Sign Up</a></h4>
                  <p class="text-justify">If you have not yet created an account, create one and be able to access all our services</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150" src="imgs/search-online.png"/>
                  <h4>Search Books</h4>
                  <p class="text-justify">You can also search for all books that you need for your studies and research</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150" src="imgs/library.png"/>
                  <h4>Visit Us</h4>
                  <p class="text-justify">Visit us for any consultation that you need. We are here to help you enjoy the services of the library</p>
               </center>
            </div>
         </div>
      </div>
   </section>

</asp:Content>
