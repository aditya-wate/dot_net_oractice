<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><b><font size="5" face="courier" color=navy><%: ViewData["Message"] %></h2></font></b>
    <p>
        <p><font size="5" face="courier" color=navy><b>Click to see the list of movies - <%: Html.ActionLink("Movies List", "Index", "Movies")%></b></font>
    <p>
    <div>
        <img width="640" height="480" src="../../Content/App_LocalResources/thea.jpg" alt="Movies" />
    </div>   
</asp:Content>
