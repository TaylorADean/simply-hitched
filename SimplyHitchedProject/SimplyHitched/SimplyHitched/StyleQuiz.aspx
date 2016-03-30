<%@ Page Title="Style Quiz" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StyleQuiz.aspx.cs" Inherits="SimplyHitched._StyleQuiz" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
    
            <asp:ImageButton ID="ImageButton1" runat="server" Height="380px" ImageUrl="~/Images/StyleQuiz/Q0/wedding-1.jpg" OnClick="ImageButton1_Click" Width="420px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="380px" ImageUrl="~/Images/StyleQuiz/Q0/wedding-2.jpg" Width="420px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="380px" ImageUrl="~/Images/StyleQuiz/Q0/wedding-3.jpg" Width="420px" />
    
        </div>

        <div>


            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            
        </div>
</asp:Content>