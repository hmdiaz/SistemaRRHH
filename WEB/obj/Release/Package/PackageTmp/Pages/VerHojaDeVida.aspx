<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="VerHojaDeVida.aspx.cs" Inherits="WEB.Pages.VerHojaDeVida" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="container-fluid">
        <div class="row">
            <div class="col-xs-6 col-md-1"></div>
            <div class="col-xs-6 col-md-10">
                <rsweb:ReportViewer ID="rptHojaVida" runat="server" Width="1100" Height="800"></rsweb:ReportViewer>
            </div>
        </div>
    </div>    
</asp:Content>

