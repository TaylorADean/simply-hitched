<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SimplyHitched.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Simply Hitched Contact Info.</h3>
    <address>
        #123 Simply Hitched Drive<br />
        Vancouver, BC V1A 2B3<br />
        <abbr title="Phone">P:</abbr>
        604.321.4567
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@simplyhitched.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@simplyhitched.com</a>
    </address>
</asp:Content>
