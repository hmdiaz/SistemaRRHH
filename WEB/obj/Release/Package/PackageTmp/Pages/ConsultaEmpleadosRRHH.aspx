<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="ConsultaEmpleadosRRHH.aspx.cs" Inherits="WEB.Pages.ConsultaEmpleadosRRHH" %>
<%@ Register TagPrefix="CustomGridView" Namespace="SistemaRRHH" Assembly="WEB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
    <div class="container-fluid">
              <div class="row">
                  <div class="col-xs-6 col-md-1"></div>
                  <div class="col-xs-6 col-md-10">
                    <asp:ValidationSummary ID="ValidationSummary1" CssClass="alert alert-danger" runat="server" />
                        <table class="table table-striped">
                            <tr>
                                <th colspan="4">
                                    <center>BUSQUEDA DE EMPLEADOS</center> 
                                </th>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <center>
                                        <div class="form-inline">                                            
                                            <div class="input-group col-sm-3">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="Label1" runat="server" Text="Usuario Dominio : "></asp:Label>
                                                </div>
                                                <asp:TextBox ID="txtLogin" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="input-group col-sm-4">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="Label2" runat="server" Text="Número Empleado : "></asp:Label>
                                                </div>
                                                <asp:TextBox ID="txtNumeroEmpleado" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="input-group col-sm-3">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="Label6" runat="server" Text="Cédula Empleado : "></asp:Label>
                                                </div>
                                                <asp:TextBox ID="txtCedula" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                   </center>
                               </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <center>
                                                <div class="form-inline">     
                                                    <div class="input-group col-sm-5">
                                                        <div class="input-group-addon">
                                                            <asp:Label ID="Label3" runat="server" Text="Area : "></asp:Label>
                                                        </div>
                                                        <asp:DropDownList ID="ddlArea" runat="server" CssClass="form-control col-xs-10" AutoPostBack="true"
                                                            onselectedindexchanged="ddlArea_SelectedIndexChanged">
                                                        </asp:DropDownList>
                                                    </div>
                                                    <div class="input-group col-sm-5">
                                                        <div class="input-group-addon">
                                                            <asp:Label ID="Label4" runat="server" Text="Cargo : "></asp:Label>
                                                        </div>
                                                        <asp:DropDownList ID="ddlCargo" runat="server" CssClass="form-control col-xs-10">
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                           </center>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>   
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">                                    
                                    <div class="form-inline">
                                        <center>
                                            <div class="input-group col-sm-3">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="Label7" runat="server" Text="Primer Apellido : "></asp:Label>
                                                </div>
                                                <asp:TextBox ID="txtPrimerApellido" CssClass="form-control" runat="server"></asp:TextBox>                                            
                                            </div>
                                            <div class="input-group col-sm-3">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="Label8" runat="server" Text="Segundo Apellido : "></asp:Label>
                                                </div>
                                                <asp:TextBox ID="txtSegundoApellido" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="input-group col-sm-4">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="Label5" runat="server" Text="Nombres : "></asp:Label>
                                                </div>
                                                <asp:TextBox ID="txtNombres" CssClass="form-control" runat="server"></asp:TextBox>                                            
                                            </div>
                                        </center>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">                                    
                                    <div class="form-inline">
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                             <ContentTemplate>
                                                <center>
                                                    <asp:Button ID="btnBuscarEmpleados" runat="server" 
                                                            Text="Buscar Empleados" CssClass="btn btn-default" 
                                                        onclick="btnBuscarEmpleados_Click" />
                                                </center>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </td>
                            </tr>
                        </table>
                      <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <CustomGridView:GridViewPaginado
                                EmptyDataText="No se encontraron coincidencias" 
                                AutoGenerateColumns="false"
                                ID="grvEmpleados" 
                                DataKeyNames="EmpleadoID"
                                runat="server" 
                                CssClass="table table-striped table-hover"
                                BorderStyle="None" 
                                GridLines="None"
                                CustomPageIndex="0" 
                                AllowPaging="true" 
                                TotalRecords="0" 
                                onpageindexchanging="grvEmpleados_PageIndexChanging">
                                <EmptyDataRowStyle Font-Bold="True" Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle" />                                
                                    <Columns>
                                            <asp:BoundField DataField="NumeroEmpleado" HeaderText="Número Empleado" 
                                            SortExpression="DateField" />
                                            <asp:BoundField DataField="Documento" HeaderText="Documento"
                                            SortExpression="DateField" />
                                            <asp:BoundField DataField="PrimerApellido" HeaderText="Primer Apellido" 
                                            SortExpression="DateField" />
                                            <asp:BoundField DataField="SegundoApellido" HeaderText="Segundo Apellido" 
                                            SortExpression="DateField" />
                                            <asp:BoundField DataField="PrimerNombre" HeaderText="Primer Nombre" 
                                            SortExpression="DateField" />
                                            <asp:BoundField DataField="SegundoNombre" HeaderText="Segundo Nombre" 
                                            SortExpression="DateField" />                                                    
                                            <asp:BoundField DataField="NombreArea" HeaderText="Area" 
                                            SortExpression="DateField" />
                                            <asp:BoundField DataField="NombreCargo" HeaderText="Cargo" 
                                            SortExpression="DateField" />
                                            <asp:TemplateField HeaderText="">
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="ImgDescargar" runat="server" 
                                                        CommandName="Ver" 
                                                        CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' 
                                                        NavigateUrl='<%# "~/Pages/EditarHojaDeVida.aspx?Id=" + Eval("UsuarioID") + ""%>'
                                                        ImageUrl="~/Images/Icons/loop-circular-2x.png" ToolTip="Ver y Editar Hoja de Vida"
                                                        Target="_blank" />
                                                        <asp:HyperLink ID="HyperLink1" runat="server" 
                                                        CommandName="Ver" 
                                                        CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' 
                                                        NavigateUrl='<%# "~/Pages/VerHojaDeVida.aspx?Id=" + Eval("UsuarioID") + ""%>'
                                                        ImageUrl="~/Images/Icons/magnifying-glass-2x.png" ToolTip="Ver y Descargar Hoja de Vida"
                                                        Target="_blank" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                    </Columns>
                                    <PagerStyle CssClass="pagination pull-right" />
                                    <PagerSettings
                                        Mode="NumericFirstLast"
                                        PageButtonCount="10"
                                        FirstPageText="<<"
                                        LastPageText=">>"
                                        NextPageText=">"
                                        PreviousPageText="<" />
                              </CustomGridView:GridViewPaginado>
                        </ContentTemplate>
                      </asp:UpdatePanel>
                  </div>
              </div>
            </div>
            <asp:Panel ID="Panel4" runat="server">
                <asp:UpdateProgress 
                    ID="UpdateProgress3" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel3">
                    <ProgressTemplate>
                        <div class="divWaiting">	                        
	                    <asp:Image ID="imgWaitBuscar" 
                                    runat="server" 
	                                ImageAlign="AbsMiddle" 
                                    ImageUrl="~/Images/Loaders/image_717505.gif" />
                                    <br />
                        <asp:Label ID="lblWaitExperiencia" 
                                    runat="server" 
	                                Text=" Por favor espere la información esta siendo procesada... " />
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </asp:Panel>         
</asp:Content>
