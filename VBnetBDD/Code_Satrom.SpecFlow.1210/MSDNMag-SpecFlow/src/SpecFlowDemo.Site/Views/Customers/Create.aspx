<%@ Page Title="" Language="vb" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of SpecFlowDemo.Core.Models.Customer)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% Using Html.BeginForm()%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            <div>
                <%: Html.LabelFor(Function(m) m.Name) %>:
                <%: Html.TextBoxFor(Function(m) m.Name) %>
            </div>
            <div>
                <%: Html.LabelFor(Function(m) m.Email) %>:
                <%: Html.TextBoxFor(Function(m) m.Email) %>
            </div>
            <div>
                <%: Html.LabelFor(Function(m) m.Phone) %>:
                <%: Html.TextBoxFor(Function(m) m.Phone) %>
            </div>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% End Using%>

    <div>
        <%: Html.ActionLink("Back to List", "Index")%>
    </div>

</asp:Content>

