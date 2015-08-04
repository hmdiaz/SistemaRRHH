 <%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="DetalleHojaDeVida.aspx.cs" Inherits="WEB.Pages.DetalleHojaDeVida" Culture="es-CO" UICulture="Auto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </ajaxToolkit:ToolkitScriptManager>
    
            <div class="container-fluid">
              <div class="row">
                  <div class="col-xs-6 col-md-1"></div>
                  <div class="col-xs-6 col-md-10">
                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs" role="tablist">
                      <li class="active"><a href="#InfoPersonal" role="tab" data-toggle="tab">Información Personal</a></li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content">
                      <center><h2>Hoja de Vida del Empleado</h2></center>
                      <div class="tab-pane active" id="InfoPersonal">
                        <asp:ValidationSummary ID="ValidationSummary1" CssClass="alert alert-danger" runat="server" />                        
                        <table class="table table-striped">
                            <tr>
                                <th colspan="3">
                                    <center>INFORMACIÓN PERSONAL DEL EMPLEADO</center> 
                                </th>
                                <td rowspan="4">
                                    <center>
                                        <asp:Image ID="FotoEmpleado" runat="server" ImageUrl="~/Images/Sin_foto.png" Width="110" Height="150" />
                                    </center>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <center>
                                        <strong>
                                            <asp:Label ID="lblNumeroEmpleado" runat="server" Text="Número de Empleado : "></asp:Label>
                                        </strong>
                                    </center>
                               </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label4" runat="server" Text="Primer Nombre : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtPrimerNombre" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label5" runat="server" Text="Segundo Nombre : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtSegundoNombre" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>                                
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label6" runat="server" Text="Primer Apellido : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtPrimerApellido" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label7" runat="server" Text="Segundo Apellido : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtSegundoApellido" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-4">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label3" runat="server" Text="Fecha de Nacimiento : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtFechaNacimiento" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>                                            
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <%--<tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <div class="input-group col-sm-3">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label8" runat="server" Text="País : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlPais" runat="server" CssClass="form-control col-xs-10" Enabled="false"
                                                        AutoPostBack="True" onselectedindexchanged="ddlPais_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label9" runat="server" Text="Dpto/Estado : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlDepartamento" runat="server" 
                                                        CssClass="form-control col-xs-10" AutoPostBack="True" Enabled="false"
                                                        onselectedindexchanged="ddlDepartamento_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </div>                        
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label10" runat="server" Text="Municipio/Ciudad : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlMunicipio" runat="server" CssClass="form-control col-xs-10" Enabled="false">
                                                    </asp:DropDownList>
                                                </div>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="ddlPais" />
                                            </Triggers>
                                       </asp:UpdatePanel>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-4">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label15" runat="server" Text="RH : "></asp:Label>
                                            </div>
                                            <asp:DropDownList ID="ddlRH" runat="server" CssClass="form-control col-xs-10" Enabled="false">
                                                <asp:ListItem Value="" Text="[Seleccione uno...]"></asp:ListItem>
                                                <asp:ListItem Value="O+" Text="O+"></asp:ListItem>
                                                <asp:ListItem Value="O-" Text="O-"></asp:ListItem>
                                                <asp:ListItem Value="A+" Text="A+"></asp:ListItem>
                                                <asp:ListItem Value="A-" Text="A-"></asp:ListItem>
                                                <asp:ListItem Value="B+" Text="B+"></asp:ListItem>
                                                <asp:ListItem Value="B-" Text="B-"></asp:ListItem>
                                                <asp:ListItem Value="AB+" Text="AB+"></asp:ListItem>
                                                <asp:ListItem Value="AB-" Text="AB-"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group col-sm-4">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label16" runat="server" Text="Estado Civil : "></asp:Label>
                                            </div>
                                            <asp:DropDownList ID="ddlEstadoCivil" runat="server" CssClass="form-control col-xs-10" Enabled="false">
                                                <asp:ListItem Value="" Text="[Seleccione uno...]"></asp:ListItem>
                                                <asp:ListItem Value="Casado" Text="Casado"></asp:ListItem>
                                                <asp:ListItem Value="Soltero" Text="Soltero"></asp:ListItem>
                                                <asp:ListItem Value="Unión Libre" Text="Unión Libre"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </table>
                        <table class="table table-striped">
                            <tr>
                                <th colspan="4">
                                    <center>INFORMACIÓN DE CONTACTO</center>
                                </th>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-8">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label11" runat="server" Text="Dirección de Residencia : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtDireccion" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group col-sm-3">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label12" runat="server" Text="Barrio : " Enabled="false"></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtBarrio" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-3">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label13" runat="server" Text="Teléfono Fijo : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtTelefonoFijo" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group col-sm-3">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label14" runat="server" Text="Celular : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCelular" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label21" runat="server" Text="Correo Personal : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCorreoPersonal" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            --%>
                        </table>
                        <table class="table table-striped">
                            <tr>
                                <th colspan="4">
                                    <center>INFORMACIÓN AZTECA COMUNICACIONES COLOMBIA</center> 
                                </th>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label17" runat="server" Text="Area : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList 
                                                            ID="ddlArea" 
                                                            runat="server" 
                                                            CssClass="form-control col-xs-10" 
                                                            AutoPostBack="true" 
                                                            Enabled="false"
                                                            onselectedindexchanged="ddlArea_SelectedIndexChanged" >
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label 
                                                            ID="Label18" 
                                                            runat="server" 
                                                            Text="Cargo : ">
                                                       </asp:Label>
                                                    </div>
                                                    <asp:DropDownList 
                                                        ID="ddlCargo" 
                                                        runat="server" 
                                                        CssClass="form-control col-xs-10" 
                                                        Enabled="false">
                                                    </asp:DropDownList>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-4">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label19" runat="server" Text="Celular Corporativo: "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCelularCorporativo" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group col-sm-7">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label20" runat="server" Text="Correo Corporativo: "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCorreoCorporativo" CssClass="form-control col-sm-3" runat="server" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                            </tr>                            
                         </table>
                         
                         <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <asp:Panel ID="pnlResultado" runat="server" CssClass="alert alert-success">
                                    <center>
                                        <asp:Label ID="lblResultado" runat="server" Text="" Font-Bold="true" Font-Size="Large"></asp:Label>
                                    </center>
                                </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                      </div>
                  </div>
                  <div class="col-xs-6 col-md-1"></div>
                  </div>
              </div>
 </asp:Content>
