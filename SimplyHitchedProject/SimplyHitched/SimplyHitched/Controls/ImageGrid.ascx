<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImageGrid.ascx.cs" Inherits="SimplyHitched.Controls.ImageGrid" %>


<asp:ListView runat="server" ID="ImageListView" ItemPlaceholderID="itemPlaceHolder" 
     GroupPlaceholderID="groupPlaceHolder" >
    <LayoutTemplate>
        <h1>
            <asp:Label Text="" runat="server" ID="titleLabel" OnLoad="titleLabel_Load" />
        </h1>
        <div runat="server" id="groupPlaceHolder">
        </div>
    </LayoutTemplate>
    <GroupTemplate>
        <span>
            <div id="itemPlaceHolder" runat="server"></div>
        </span>
    </GroupTemplate>
    <ItemTemplate>
        <asp:ImageButton ID="itemImageButton" runat="server" 
          CommandArgument="<%# Container.DataItem %>" 
          ImageUrl="<%# Container.DataItem %>" Width="320" Height="240" 
          OnCommand="itemImageButton_Command"/>
    </ItemTemplate>
    <EmptyItemTemplate>
        <td />
    </EmptyItemTemplate>
    <EmptyDataTemplate>
        <h3>No images available</h3>
    </EmptyDataTemplate>
</asp:ListView>