 <%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Main.Master" AutoEventWireup="true" CodeBehind="EditarHojaDeVida.aspx.cs" Inherits="WEB.Pages.EditarHojaDeVida" Culture="es-CO" UICulture="Auto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
            <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </ajaxToolkit:ToolkitScriptManager>
            <script type="text/javascript">
                $(document).ready(function () {
                    $("#ContentPlaceHolder1_btnAdicionarIntegrante").on("click", function () {
                        $("#ContentPlaceHolder1_txtNombresIntegrante").val("");
                        $("#ContentPlaceHolder1_txtApellidosIntegrante").val("");
                        $("#ContentPlaceHolder1_txtFechaNacimientoIntegrante").val("");
                        $("#ContentPlaceHolder1_txtOcupacionIntegrante").val("");
                    })

                    $("#ContentPlaceHolder1_btnAdicionarEstudio").on("click", function () {
                        $("#ContentPlaceHolder1_txtInstitucion").val("");
                        $("#ContentPlaceHolder1_txtTituloObtenido").val("");
                        $("#ContentPlaceHolder1_txtFechaInicioEstudio").val("");
                        $("#ContentPlaceHolder1_txtFechaFinalizacionEstudio").val("");
                    })

                    $("#ContentPlaceHolder1_btnAdicionarExperienciaLaboral").on("click", function () {
                        $("#ContentPlaceHolder1_txtEmpresa").val("");
                        $("#ContentPlaceHolder1_txtCargo").val("");
                        $("#ContentPlaceHolder1_txtFechaIngreso").val("");
                        $("#ContentPlaceHolder1_txtFechaRetiro").val("");
                    })
                });
            </script>
            <div class="container-fluid">
              <div class="row">
                  <div class="col-xs-6 col-md-1"></div>
                  <div class="col-xs-6 col-md-10">
                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs" role="tablist">
                      <li class="active"><a href="#InfoPersonal" role="tab" data-toggle="tab">Información Personal</a></li>                      
                      <li><a href="#InfoFamiliar" role="tab" data-toggle="tab">Información Familiar</a></li>
                      <li><a href="#InfoAcademica" role="tab" data-toggle="tab">Información Académica</a></li>
                      <li><a href="#InfoLaboral" role="tab" data-toggle="tab">Experiencia Laboral</a></li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content">
                      <center><h2>Hoja de Vida del Empleado</h2></center>
                      <div class="tab-pane active" id="InfoPersonal">
                        <asp:ValidationSummary ID="ValidationSummary1" HeaderText="<h4><center>Resumen de Errores<center></h4>" CssClass="alert alert-danger" runat="server" />                        
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
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label2" runat="server" Text="Tipo de Documento : "></asp:Label>
                                            </div>
                                            <asp:DropDownList ID="ddlTipoIdentificacion" runat="server" CssClass="form-control col-xs-10">
                                            </asp:DropDownList>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                    ErrorMessage="(*) El Tipo de Identificación es requerido" Text="(*)" 
                                                    ControlToValidate="ddlTipoIdentificacion" ></asp:RequiredFieldValidator>
                                            </div>                                            
                                        </div>
                                        <div class="input-group col-sm-20">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label1" runat="server" Text="Documento de Identidad : "></asp:Label>
                                            </div>
                                            <asp:TextBox Enabled="false" ID="txtDocumentoIdentidad" CssClass="form-control" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ErrorMessage="(*) El Documento de Identidad es requerido" Text="(*)" 
                                                    ControlToValidate="txtDocumentoIdentidad" ></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>                        
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label4" runat="server" Text="Primer Nombre : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtPrimerNombre" CssClass="form-control uppercase" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                    ErrorMessage="(*) El Primer Nombre del Empleado es requerido" Text="(*)" 
                                                    ControlToValidate="txtPrimerNombre" ></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label5" runat="server" Text="Segundo Nombre : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtSegundoNombre" CssClass="form-control uppercase" runat="server"></asp:TextBox>
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
                                            <asp:TextBox ID="txtPrimerApellido" CssClass="form-control uppercase" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                    ErrorMessage="(*) El Primer Apellido del Empleado es requerido" Text="(*)" 
                                                    ControlToValidate="txtPrimerApellido" ></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label7" runat="server" Text="Segundo Apellido : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtSegundoApellido" CssClass="form-control uppercase" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <center>
                                        <asp:Button ID="btnSubirFoto" runat="server" Text="Subir Foto" CssClass="btn btn-default" />
                                    </center>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <div class="input-group col-sm-4">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label3" runat="server" Text="Fecha de Nacimiento : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtFechaNacimiento" CssClass="form-control col-sm-3" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:ImageButton ID="iBtnFechaNacimiento" runat="server" ImageUrl="~/Images/calendar32.png" />
                                                <asp:RequiredFieldValidator 
                                                    ID="RequiredFieldValidator5" 
                                                    runat="server" 
                                                    ErrorMessage="(*) La Fecha de Nacimiento del Empleado es requerida" 
                                                    Text="(*)" 
                                                    ControlToValidate="txtFechaNacimiento" >
                                                </asp:RequiredFieldValidator>
                                                <asp:CompareValidator 
                                                    ID="CompareValidator4" 
                                                    runat="server" 
                                                    ErrorMessage="(*) La Fecha de Nacimiento debe tener un formato de fecha correcto"
                                                    ControlToValidate="txtFechaNacimiento"
                                                    Operator="DataTypeCheck" 
                                                    Type="Date">
                                                </asp:CompareValidator>
                                            </div>
                                            <%----%>
                                            <ajaxToolkit:CalendarExtender 
                                                ID="txtFechaNacimiento_CalendarExtender" 
                                                PopupButtonID="iBtnFechaNacimiento"
                                                Format="yyyy-MM-dd" 
                                                runat="server" 
                                                Enabled="True" 
                                                TargetControlID="txtFechaNacimiento">
                                            </ajaxToolkit:CalendarExtender>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <div class="form-inline">
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <div class="input-group col-sm-3">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label8" runat="server" Text="País : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlPais" runat="server" CssClass="form-control col-xs-10" 
                                                        AutoPostBack="True" onselectedindexchanged="ddlPais_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" 
                                                            ErrorMessage="(*) El País de Nacimiento del Empleado es requerido" Text="(*)" 
                                                            ControlToValidate="ddlPais" ></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label9" runat="server" Text="Dpto/Estado : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlDepartamento" runat="server" 
                                                        CssClass="form-control col-xs-10" AutoPostBack="True" 
                                                        onselectedindexchanged="ddlDepartamento_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" 
                                                            ErrorMessage="(*) El Departamento de Nacimiento del Empleado es requerido" Text="(*)" 
                                                            ControlToValidate="ddlDepartamento" ></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>                        
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label10" runat="server" Text="Municipio/Ciudad : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlMunicipio" runat="server" CssClass="form-control col-xs-10">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                            ErrorMessage="(*) El Municipio de Nacimiento del Empleado es requerido" Text="(*)" 
                                                            ControlToValidate="ddlMunicipio" ></asp:RequiredFieldValidator>
                                                    </div>
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
                                            <asp:DropDownList ID="ddlRH" runat="server" CssClass="form-control col-xs-10">
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
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                                    ErrorMessage="(*) El RH es requerido" Text="(*)" 
                                                    ControlToValidate="ddlRH" ></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="input-group col-sm-4">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label16" runat="server" Text="Estado Civil : "></asp:Label>
                                            </div>
                                            <asp:DropDownList ID="ddlEstadoCivil" runat="server" CssClass="form-control col-xs-10">
                                                <asp:ListItem Value="" Text="[Seleccione uno...]"></asp:ListItem>
                                                <asp:ListItem Value="Casado" Text="Casado"></asp:ListItem>
                                                <asp:ListItem Value="Soltero" Text="Soltero"></asp:ListItem>
                                                <asp:ListItem Value="Unión Libre" Text="Unión Libre"></asp:ListItem>
                                            </asp:DropDownList>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" 
                                                    ErrorMessage="(*) El Estado Civil es requerido" Text="(*)" 
                                                    ControlToValidate="ddlEstadoCivil" ></asp:RequiredFieldValidator>
                                            </div>
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
                                            <asp:TextBox ID="txtDireccion" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                                                    ErrorMessage="(*) La Dirección es requerida" Text="(*)" 
                                                    ControlToValidate="txtDireccion" ></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="input-group col-sm-3">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label12" runat="server" Text="Barrio : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtBarrio" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" 
                                                    ErrorMessage="(*) El Barrio es requerido" Text="(*)" 
                                                    ControlToValidate="txtBarrio" ></asp:RequiredFieldValidator>
                                            </div>
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
                                            <asp:TextBox ID="txtTelefonoFijo" CssClass="form-control col-sm-3" runat="server"></asp:TextBox>
                                            <ajaxToolkit:MaskedEditExtender 
                                                ID="MaskedEditExtender2" runat="server"
                                                TargetControlID="txtTelefonoFijo"
                                                Mask="(9)999-99-99"
                                                MessageValidatorTip="true"
                                                OnFocusCssClass="txtTelefonoFijo"
                                                OnInvalidCssClass="MaskedEditError"
                                                MaskType="Number"
                                                InputDirection="RightToLeft"                                          
                                                ErrorTooltipEnabled="True" />
                                        </div>
                                        <div class="input-group col-sm-3">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label14" runat="server" Text="Celular : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCelular" CssClass="form-control col-sm-3" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator 
                                                    ID="RequiredFieldValidator10" 
                                                    runat="server" 
                                                    ErrorMessage="(*) El Celular Personal del Empleado es requerido" 
                                                    Text="(*)" 
                                                    ControlToValidate="txtCelular" >
                                                </asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator 
                                                    ID="RegularExpressionValidator4" 
                                                    runat="server" 
                                                    ErrorMessage="El Celular Personal debe llevar solo números y debe ser de máximo 10 digitos" 
                                                    ValidationExpression="\d{10}"                                                    
                                                    ControlToValidate="txtCelular">
                                                </asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <div class="input-group col-sm-5">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label21" runat="server" Text="Correo Personal : "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCorreoPersonal" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" 
                                                    ErrorMessage="(*) El Correo Personal es requerido" Text="(*)" 
                                                    ControlToValidate="txtCorreoPersonal" ></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="input-group-btn">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="(*) El formato debe ser correcto. Ejemplo: correo@azteca-comunicaciones.com" ControlToValidate="txtCorreoPersonal" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
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
                                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                            <ContentTemplate>
                                                <div class="input-group col-sm-3">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label46" runat="server" Text="País : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlPaisSede" runat="server" CssClass="form-control col-xs-10" 
                                                        AutoPostBack="True" 
                                                        onselectedindexchanged="ddlPaisSede_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" 
                                                            ErrorMessage="(*) El País de Nacimiento del Empleado es requerido" Text="(*)" 
                                                            ControlToValidate="ddlPaisSede" ></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label47" runat="server" Text="Dpto/Estado : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlDepartamentoSede" runat="server" 
                                                        CssClass="form-control col-xs-10" AutoPostBack="True" 
                                                        onselectedindexchanged="ddlDepartamentoSede_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" 
                                                            ErrorMessage="(*) El Departamento de Nacimiento del Empleado es requerido" Text="(*)" 
                                                            ControlToValidate="ddlDepartamentoSede" ></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>                        
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label48" runat="server" Text="Municipio/Ciudad : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlMunicipioSede" 
                                                                runat="server" 
                                                                CssClass="form-control col-xs-10" 
                                                                 AutoPostBack="True" 
                                                        onselectedindexchanged="ddlMunicipioSede_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" 
                                                            ErrorMessage="(*) El Municipio de Nacimiento del Empleado es requerido" Text="(*)" 
                                                            ControlToValidate="ddlMunicipioSede" ></asp:RequiredFieldValidator>
                                                    </div>
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
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label49" runat="server" Text="Sede : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlSede"
                                                                    runat="server" 
                                                                    CssClass="form-control col-xs-10" 
                                                                    AutoPostBack="true">
                                                    </asp:DropDownList>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" 
                                                            ErrorMessage="(*) La Sede es requerida" Text="(*)" 
                                                            ControlToValidate="ddlSede" ></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="input-group col-sm-3">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label17" runat="server" Text="Area : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlArea"
                                                                      runat="server" 
                                                                      CssClass="form-control col-xs-10" 
                                                                      AutoPostBack="true" 
                                                        onselectedindexchanged="ddlArea_SelectedIndexChanged" >
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label18" runat="server" Text="Cargo : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlCargo" 
                                                                      runat="server" 
                                                                      CssClass="form-control col-xs-10">
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
                                            <asp:TextBox ID="txtCelularCorporativo" CssClass="form-control col-sm-3" runat="server"></asp:TextBox>
                                            <%--<div class="input-group-btn">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                    ErrorMessage="(*) El Celular Corporativo es requerido" Text="(*)" 
                                                    ControlToValidate="txtCelularCorporativo" ></asp:RequiredFieldValidator>
                                            </div>--%>
                                            <div class="input-group-btn">
                                                <asp:RegularExpressionValidator 
                                                    ID="RegularExpressionValidator3" 
                                                    runat="server" 
                                                    ErrorMessage="El Celular Corporativo debe llevar solo números y debe ser de máximo 10 digitos" 
                                                    ValidationExpression="\d{10}"                                                    
                                                    ControlToValidate="txtCelularCorporativo">
                                                </asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <div class="input-group col-sm-7">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Label20" runat="server" Text="Correo Corporativo: "></asp:Label>
                                            </div>
                                            <asp:TextBox ID="txtCorreoCorporativo" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                            <div class="input-group-btn">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="(*) El formato debe ser correcto. Ejemplo: correo@azteca-comunicaciones.com" ControlToValidate="txtCorreoCorporativo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                            </div>
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
                                <table class="table table-striped">
                                    <tr>
                                        <th colspan="4">
                                            <center>
                                                <asp:Button ID="btnActualizarInformacion" runat="server" 
                                                    Text="Guardar Información" CssClass="btn btn-default" 
                                                    onclick="btnActualizarInformacion_Click" />
                                            </center>
                                        </th>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                      </div>
                      <div class="tab-pane" id="InfoFamiliar">
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>                   
                                <table class="table table-striped">
                                    <tr>
                                        <th colspan="4">
                                            <center>INFORMACIÓN FAMILIAR</center>
                                        </th>
                                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <asp:GridView EmptyDataText="No se ha agregado ninguna Información Familiar" 
                                                AutoGenerateColumns="false"
                                                ID="dgvInformacionFamiliar" 
                                                DataKeyNames="EmpleadoID, InformacionFamiliarID"
                                                runat="server" 
                                                onrowdatabound="dgvInformacionFamiliar_RowDataBound" 
                                                OnRowCommand="SeleccionGrillaInformacionFamiliar" 
                                                CssClass="table table-striped table-hover"
                                                BorderStyle="None" 
                                                GridLines="None">
                                                <EmptyDataRowStyle Font-Bold="True" Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <Columns>
                                                            <asp:BoundField DataField="Nombres" HeaderText="Nombres" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="NombreParentesco" HeaderText="Parentesco" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="Ocupacion" HeaderText="Ocupacion" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="FechaNacimiento" DataFormatString="{0:D}" HeaderText="Fecha de Nacimiento" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="Edad" HeaderText="Edad" 
                                                            SortExpression="DateField" />
                                                            <asp:TemplateField HeaderText="">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton 
                                                                            ID="iBtnEliminarIntegrante" 
                                                                            ImageUrl="~/Images/Icons/trash-2x.png" 
                                                                            CommandName="Eliminar Registro" 
                                                                            CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' 
                                                                            runat="server" 
                                                                            OnClientClick="return confirm('Está seguro que desea eliminar este registro?');" /> 
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                    </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                                <table class="table table-striped">
                                    <tr>
                                        <th colspan="4">
                                            <center>
                                                <asp:Button ID="btnAdicionarIntegrante" runat="server" 
                                                            Text="Adicionar Integrante" 
                                                            CssClass="btn btn-default" 
                                                    onclick="btnAdicionarIntegrante_Click" />
                                            </center>
                                        </th>
                                    </tr>
                                </table>
                                <asp:Panel ID="PanelAdicionarIntegrante" runat="server" Width="60%" CssClass="panel panel-info" BorderStyle="None">
                                    <div class="modal-header">
                                        <asp:LinkButton runat="server" ID="ClosePanel" CssClass="close" data-dismiss="modal" Text="&times;" />
                                        <h4 class="modal-title">Adicionar Integrante Grupo Familiar</h4>
                                    </div>
                                    <div class="modal-body">
                                        <asp:ValidationSummary ID="ValidationSummary2" HeaderText="<h4><center>Resumen de Errores<center></h4>" CssClass="alert alert-danger" runat="server" ValidationGroup="1" />
                                        <table class="table table-striped">
                                            <tr>
                                                <th><center>DATOS DEL INTEGRANTE DEL GRUPO FAMILIAR</center></th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="form-inline">
                                                        <div class="input-group col-sm-5">                                                        
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label22" runat="server" Text="Nombres: "></asp:Label>
                                                            </div>
                                                            <asp:TextBox ID="txtNombresIntegrante" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                            <div class="input-group-btn">
                                                                <asp:RequiredFieldValidator 
                                                                    ID="RequiredFieldValidator7" 
                                                                    runat="server" 
                                                                    ErrorMessage="(*) Los nombres son requeridos" 
                                                                    Text="(*)" 
                                                                    ControlToValidate="txtNombresIntegrante"  
                                                                    ValidationGroup="1">
                                                                    </asp:RequiredFieldValidator>
                                                            </div>
                                                        </div>
                                                        <div class="input-group col-sm-5">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label23" runat="server" Text="Apellidos: "></asp:Label>
                                                            </div>
                                                            <asp:TextBox ID="txtApellidosIntegrante" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                            <div class="input-group-btn">
                                                                <asp:RequiredFieldValidator 
                                                                    ID="RequiredFieldValidator11" 
                                                                    runat="server" 
                                                                    ErrorMessage="(*) Los Apellidos son requeridos" 
                                                                    Text="(*)" 
                                                                    ControlToValidate="txtApellidosIntegrante" 
                                                                    ValidationGroup="1"></asp:RequiredFieldValidator>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="form-inline">
                                                        <div class="input-group col-sm-5">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label24" runat="server" Text="Parentesco : "></asp:Label>
                                                            </div>
                                                            <asp:DropDownList ID="ddlParentesco" runat="server" CssClass="form-control col-xs-10">
                                                            </asp:DropDownList>
                                                            <div class="input-group-btn">
                                                                <asp:RequiredFieldValidator 
                                                                    ID="RequiredFieldValidator12" 
                                                                    runat="server" 
                                                                    ErrorMessage="(*) El Parentesco es requerido" 
                                                                    Text="(*)" 
                                                                    ControlToValidate="ddlParentesco" 
                                                                    ValidationGroup="1"></asp:RequiredFieldValidator>
                                                            </div>
                                                        </div>
                                                        <div class="input-group col-sm-5">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label25" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
                                                            </div>
                                                            <asp:TextBox ID="txtFechaNacimientoIntegrante" CssClass="form-control col-sm-5" runat="server"></asp:TextBox>
                                                            <div class="input-group-btn">
                                                                <asp:Image ID="iBtnFechaNacimientoIntegrante" runat="server" ImageUrl="~/Images/calendar32.png" />
                                                                <asp:RequiredFieldValidator 
                                                                    ID="RequiredFieldValidator13" 
                                                                    runat="server" 
                                                                    ErrorMessage="(*) La Fecha de Nacimiento es requerida" 
                                                                    Text="(*)" 
                                                                    ControlToValidate="txtFechaNacimientoIntegrante" 
                                                                    ValidationGroup="1">
                                                                </asp:RequiredFieldValidator>
                                                                <asp:CompareValidator 
                                                                    ID="CompareValidator3" 
                                                                    runat="server" 
                                                                    ErrorMessage="(*) La Fecha de Nacimiento debe tener un formato de fecha correcto"
                                                                    ControlToValidate="txtFechaNacimientoIntegrante"
                                                                    Operator="DataTypeCheck" 
                                                                    Type="Date" ValidationGroup="1">
                                                                </asp:CompareValidator>
                                                            </div>
                                                            <ajaxToolkit:CalendarExtender 
                                                                ID="CalendarExtender1" 
                                                                Format="yyyy-MM-dd" 
                                                                runat="server" 
                                                                ClearTime="true" 
                                                                PopupButtonID="iBtnFechaNacimientoIntegrante" 
                                                                TargetControlID="txtFechaNacimientoIntegrante">
                                                            </ajaxToolkit:CalendarExtender>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class="form-inline">
                                                        <div class="input-group col-sm-6">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label26" runat="server" Text="Ocupación : "></asp:Label>
                                                            </div>
                                                            <asp:TextBox ID="txtOcupacionIntegrante" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <center>
                                                        <asp:Button ID="btnGuardarIntegrante" runat="server" Text="Guardar Integrante" 
                                                            CssClass="btn btn-success"  ValidationGroup="1" 
                                                            onclick="btnGuardarIntegrante_Click" />
                                                    </center>                                                    
                                                </td>                                                
                                            </tr>
                                        </table>
                                    </div>
                                    <div class="modal-footer"></div>
                                </asp:Panel>
                                <ajaxToolkit:ModalPopupExtender 
                                        ID="ModalPopupExtender1" 
                                        runat="server"
                                        TargetControlID="btnAdicionarIntegrante"
                                        PopupControlID="PanelAdicionarIntegrante"
                                        BackgroundCssClass="PopUpBackground"
                                        CancelControlID="ClosePanel">
                                </ajaxToolkit:ModalPopupExtender>
                           </ContentTemplate> 
                           <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnAdicionarIntegrante" EventName="Click" />
                           </Triggers>
                      </asp:UpdatePanel>
                      </div>
                      <div class="tab-pane" id="InfoAcademica">
                                    <table class="table table-striped">
                                        <tr>
                                            <th colspan="4">
                                                <center>INFORMACIÓN DE ACADÉMICA</center>
                                            </th>
                                        </tr>
                                        <tr>
                                            <td colspan="4">
                                                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                    <ContentTemplate>
                                                        <asp:GridView EmptyDataText="No se ha agregado ninguna Información Académica" 
                                                            AutoGenerateColumns="false"
                                                            ID="dgvFormacionAcademica" 
                                                            DataKeyNames="EmpleadoID, FormacionAcademicaID"
                                                            runat="server" 
                                                            OnRowCommand="SeleccionGrillaFormacionAcademica" 
                                                            CssClass="table table-striped table-hover"
                                                            BorderStyle="None" 
                                                            GridLines="None">
                                                            <EmptyDataRowStyle Font-Bold="True" Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                                <Columns>
                                                                        <asp:BoundField DataField="Institucion" HeaderText="Institucion" 
                                                                        SortExpression="DateField" />
                                                                        <asp:BoundField DataField="TituloObtenido" HeaderText="Titulo Obtenido" 
                                                                        SortExpression="DateField" />
                                                                        <asp:BoundField DataField="NombreNivelFormacion" HeaderText="Nivel Formacion" 
                                                                        SortExpression="DateField" />
                                                                        <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                                                                        SortExpression="DateField" />
                                                                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                                                                        SortExpression="DateField" />
                                                                        <asp:BoundField DataField="FechaInicio" DataFormatString="{0:d}" HeaderText="Fecha de Inicio" 
                                                                        SortExpression="DateField" />
                                                                        <asp:BoundField DataField="FechaFinalizacion" DataFormatString="{0:d}" HeaderText="Fecha de Finzalizacion" 
                                                                        SortExpression="DateField" />
                                                                        <asp:TemplateField HeaderText="">
                                                                            <ItemTemplate>
                                                                                <asp:ImageButton 
                                                                                        ID="iBtnEliminarEstudio" 
                                                                                        ImageUrl="~/Images/Icons/trash-2x.png" 
                                                                                        CommandName="Eliminar" 
                                                                                        CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' 
                                                                                        runat="server"
                                                                                        OnClientClick="return confirm('Está seguro que desea eliminar este registro?');" />
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                </Columns>
                                                        </asp:GridView>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="table table-striped">
                                        <tr>
                                            <th colspan="4">
                                                <center>
                                                    <asp:Button ID="btnAdicionarEstudio" runat="server" 
                                                                Text="Adicionar Estudio" 
                                                                CssClass="btn btn-default" onclick="btnAdicionarEstudio_Click" />
                                                </center>
                                            </th>
                                        </tr>
                                    </table>
                                    <asp:Panel ID="PanelAdicionarEstudio" runat="server" Width="90%" CssClass="panel panel-info" BorderStyle="None">
                                        
                                            <div class="modal-header">
                                                <asp:LinkButton runat="server" ID="ClosePanelEstudio" CssClass="close" data-dismiss="modal" Text="&times;" />
                                                <h4 class="modal-title">Adicionar Estudio</h4>
                                            </div>
                                            <div class="modal-body">
                                                <asp:ValidationSummary ID="ValidationSummary3" HeaderText="<h4><center>Resumen de Errores<center></h4>" CssClass="alert alert-danger" runat="server" ValidationGroup="3" />                                            
                                                <table class="table table-striped">
                                                    <tr>
                                                        <th><center>DATOS DEL ESTUDIO</center></th>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div class="form-inline">
                                                                <div class="input-group col-sm-6">
                                                                    <div class="input-group-addon">
                                                                        <asp:Label ID="Label27" runat="server" Text="Institución : "></asp:Label>
                                                                    </div>
                                                                    <asp:TextBox ID="txtInstitucion" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                                    <div class="input-group-btn">
                                                                        <asp:RequiredFieldValidator 
                                                                            ID="RequiredFieldValidator17" 
                                                                            runat="server" 
                                                                            ErrorMessage="(*) La Institución  es requerida." 
                                                                            Text="(*)" 
                                                                            ControlToValidate="txtInstitucion" 
                                                                            ValidationGroup="3"></asp:RequiredFieldValidator>
                                                                    </div>
                                                                </div>
                                                                <div class="input-group col-sm-5">
                                                                    <div class="input-group-addon">
                                                                        <asp:Label ID="Label29" runat="server" Text="Título Obtenido : "></asp:Label>
                                                                    </div>
                                                                    <asp:TextBox ID="txtTituloObtenido" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                                    <div class="input-group-btn">
                                                                        <asp:RequiredFieldValidator 
                                                                            ID="RequiredFieldValidator18" 
                                                                            runat="server" 
                                                                            ErrorMessage="(*) El título es requerido." 
                                                                            Text="(*)" 
                                                                            ControlToValidate="txtTituloObtenido" 
                                                                            ValidationGroup="3"></asp:RequiredFieldValidator>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div class="form-inline">
                                                                <div class="input-group col-sm-3">
                                                                    <div class="input-group-addon">
                                                                        <asp:Label ID="Label34" runat="server" Text="Nivel de Formación : "></asp:Label>
                                                                    </div>
                                                                    <asp:DropDownList ID="ddlNivelFormacion" 
                                                                                        runat="server" 
                                                                                        CssClass="form-control col-xs-10">
                                                                    </asp:DropDownList>
                                                                    <div class="input-group-btn">
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                            ErrorMessage="(*) El Nivel de Formación es requerido" Text="(*)" 
                                                                            ControlToValidate="ddlNivelFormacion"
                                                                            ValidationGroup="3"></asp:RequiredFieldValidator>
                                                                    </div>
                                                                </div>
                                                                <div class="input-group col-sm-3">                                                                
                                                                    <div class="input-group-addon">
                                                                        <asp:Label ID="Label28" runat="server" Text="Fecha de Inicio: "></asp:Label>
                                                                    </div>
                                                                    <asp:TextBox ID="txtFechaInicioEstudio" CssClass="form-control col-sm-5" runat="server"></asp:TextBox>
                                                                    <div class="input-group-btn">
                                                                        <asp:Image ID="iBtnFechaInicioEstudio" runat="server" ImageUrl="~/Images/calendar32.png" />
                                                                        <asp:RequiredFieldValidator 
                                                                            ID="RequiredFieldValidator14" 
                                                                            runat="server" 
                                                                            ErrorMessage="(*) La Fecha de Inicio es requerida" 
                                                                            Text="(*)" 
                                                                            ControlToValidate="txtFechaInicioEstudio" 
                                                                            ValidationGroup="3">                                                                       
                                                                        </asp:RequiredFieldValidator>
                                                                        <asp:CompareValidator 
                                                                            ID="CompareValidator1" 
                                                                            runat="server" 
                                                                            ErrorMessage="(*) La Fecha de Incio del Estudio debe tener un formato de fecha correcto"
                                                                            ControlToValidate="txtFechaInicioEstudio"
                                                                            Operator="DataTypeCheck" 
                                                                            Type="Date" ValidationGroup="3">
                                                                        </asp:CompareValidator>
                                                                    </div>
                                                                    <ajaxToolkit:CalendarExtender 
                                                                        ID="CalendarExtender2" 
                                                                        Format="yyyy-MM-dd" 
                                                                        runat="server" 
                                                                        ClearTime="true" 
                                                                        PopupButtonID="iBtnFechaInicioEstudio" 
                                                                        TargetControlID="txtFechaInicioEstudio">
                                                                    </ajaxToolkit:CalendarExtender>                                                                
                                                                </div>
                                                                <div class="input-group col-sm-3">
                                                                    <div class="input-group-addon">
                                                                        <asp:Label ID="Label30" runat="server" Text="Fecha de Fin : "></asp:Label>
                                                                    </div>
                                                                    <asp:TextBox ID="txtFechaFinalizacionEstudio" CssClass="form-control col-sm-5" runat="server"></asp:TextBox>                                                                
                                                                    <div class="input-group-btn">
                                                                        <asp:Image ID="iBtnFechaFinalizacionEstudio" runat="server" ImageUrl="~/Images/calendar32.png" />
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" 
                                                                                    ErrorMessage="(*) La Fecha de Finalización es requerida" Text="(*)" 
                                                                                    ControlToValidate="txtFechaFinalizacionEstudio" 
                                                                                    ValidationGroup="3">
                                                                        </asp:RequiredFieldValidator>
                                                                        <asp:CompareValidator 
                                                                                ID="CompareValidator2" 
                                                                                runat="server" 
                                                                                ErrorMessage="(*) La Fecha de Finalización del Estudio debe tener un formato de fecha correcto"
                                                                                ControlToValidate="txtFechaFinalizacionEstudio"
                                                                                Operator="DataTypeCheck" 
                                                                                Type="Date" ValidationGroup="3">
                                                                        </asp:CompareValidator>
                                                                        <asp:CompareValidator 
                                                                                Id="CompararFechas" 
                                                                                runat="server" 
                                                                                ControlToCompare="txtFechaInicioEstudio" 
                                                                                Cultureinvariantvalues="true" 
                                                                                Display="Dynamic" 
                                                                                EnableClientScript="true"  
                                                                                ControlToValidate="txtFechaFinalizacionEstudio" 
                                                                                ErrorMessage="(*) La Fecha de Finalización del Estudio debe ser mayor que la Fecha de Inicio" 
                                                                                Type="Date" 
                                                                                SetFocusOnError="true" 
                                                                                Operator="GreaterThan" 
                                                                                Text="*"
                                                                                ValidationGroup="3">
                                                                       </asp:CompareValidator>
                                                                    </div>
                                                                    <ajaxToolkit:CalendarExtender 
                                                                        ID="CalendarExtender3" 
                                                                        Format="yyyy-MM-dd" 
                                                                        runat="server" 
                                                                        ClearTime="true" 
                                                                        PopupButtonID="iBtnFechaFinalizacionEstudio" 
                                                                        TargetControlID="txtFechaFinalizacionEstudio">
                                                                    </ajaxToolkit:CalendarExtender>
                                                                </div>

                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div class="form-inline">
                                                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                                    <ContentTemplate>
                                                                        <div class="input-group col-sm-3">
                                                                            <div class="input-group-addon">
                                                                                <asp:Label ID="Label31" runat="server" Text="País : "></asp:Label>
                                                                            </div>
                                                                            <asp:DropDownList ID="ddlPaisInfoAcademica" 
                                                                                              runat="server" 
                                                                                              CssClass="form-control col-xs-10" 
                                                                                              AutoPostBack="True" 
                                                                                              onselectedindexchanged="ddlPaisInfoAcademica_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <div class="input-group-btn">
                                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" 
                                                                                    ErrorMessage="(*) El País de Estudio es requerido" Text="(*)" 
                                                                                    ControlToValidate="ddlPaisInfoAcademica" 
                                                                                    ValidationGroup="3"></asp:RequiredFieldValidator>
                                                                            </div>
                                                                        </div>
                                                                        <div class="input-group col-sm-4">
                                                                            <div class="input-group-addon">
                                                                                <asp:Label ID="Label32" runat="server" Text="Dpto/Estado : "></asp:Label>
                                                                            </div>
                                                                            <asp:DropDownList ID="ddlDepartamentoInfoAcademica" 
                                                                                              runat="server" 
                                                                                              CssClass="form-control col-xs-10" 
                                                                                              AutoPostBack="True" 
                                                                                              onselectedindexchanged="ddlDepartamentoInfoAcademica_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <div class="input-group-btn">
                                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" 
                                                                                    ErrorMessage="(*) El Departamento de Estudio del Empleado es requerido" Text="(*)" 
                                                                                    ControlToValidate="ddlDepartamentoInfoAcademica" 
                                                                                    ValidationGroup="3"></asp:RequiredFieldValidator>
                                                                            </div>
                                                                        </div>                        
                                                                        <div class="input-group col-sm-4">
                                                                            <div class="input-group-addon">
                                                                                <asp:Label ID="Label33" runat="server" Text="Municipio/Ciudad : "></asp:Label>
                                                                            </div>
                                                                            <asp:DropDownList ID="ddlMunicipioInfoAcademica" 
                                                                                              runat="server" 
                                                                                              CssClass="form-control col-xs-10">
                                                                            </asp:DropDownList>
                                                                            <div class="input-group-btn">
                                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                                                                    ErrorMessage="(*) El Municipio de Estudio del Empleado es requerido" Text="(*)" 
                                                                                    ControlToValidate="ddlMunicipioInfoAcademica" 
                                                                                    ValidationGroup="3"></asp:RequiredFieldValidator>
                                                                            </div>
                                                                        </ContentTemplate>
                                                                     </asp:UpdatePanel>
                                                                </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <center>
                                                                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                                                    <ContentTemplate>
                                                                        <asp:Button 
                                                                            ID="btnGuardarEstudio" 
                                                                            runat="server" 
                                                                            Text="Guardar Estudio" 
                                                                            CssClass="btn btn-success" 
                                                                            ValidationGroup="3" 
                                                                            onclick="btnGuardarEstudio_Click" />
                                                                    </ContentTemplate>
                                                                    <Triggers>
                                                                        <asp:AsyncPostBackTrigger ControlID="btnGuardarEstudio" EventName="Click" />
                                                                   </Triggers>
                                                            </asp:UpdatePanel>                                                            
                                                                
                                                            </center>                                                    
                                                        </td>                                                
                                                    </tr>
                                                </table>
                                            </div>
                                            <div class="modal-footer"></div>                                            
                                    </asp:Panel>
                                    <ajaxToolkit:ModalPopupExtender 
                                        ID="ModalEstudios" 
                                        runat="server"
                                        TargetControlID="btnAdicionarEstudio"
                                        PopupControlID="PanelAdicionarEstudio"
                                        BackgroundCssClass="PopUpBackground"
                                        CancelControlID="ClosePanelEstudio">
                                    </ajaxToolkit:ModalPopupExtender>
                      </div>
                      <div class="tab-pane" id="InfoLaboral">
                          <table class="table table-striped">
                            <tr>
                                <th colspan="4">
                                    <center>INFORMACIÓN EXPERIENCIA LABORAL</center>
                                </th>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                        <ContentTemplate>
                                            <asp:GridView EmptyDataText="No se ha agregado ninguna Experiencia Laboral" 
                                                AutoGenerateColumns="false"
                                                ID="grvExperienciaLaboral" 
                                                DataKeyNames="EmpleadoID, ExperienciaLaboralID"
                                                runat="server" 
                                                OnRowCommand="SeleccionGrillaExperienciaLaboral"
                                                CssClass="table table-striped table-hover"
                                                BorderStyle="None" 
                                                GridLines="None">
                                                <EmptyDataRowStyle Font-Bold="True" Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <Columns>
                                                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="NombreSector" HeaderText="Sector Laboral" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="NombreAreaTrabajo" HeaderText="Área de Trabajo" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="FechaIngreso" HeaderText="Ingreso" DataFormatString="{0:d}" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="FechaRetiro" HeaderText="Retiro" DataFormatString="{0:d}"
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="Municipio" HeaderText="Municipio" 
                                                            SortExpression="DateField" />
                                                            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                                                            SortExpression="DateField" />
                                                            <asp:TemplateField HeaderText="">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton 
                                                                            ID="iBtnEliminarEstudio" 
                                                                            ImageUrl="~/Images/Icons/trash-2x.png" 
                                                                            CommandName="Eliminar" 
                                                                            CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' 
                                                                            runat="server"
                                                                            OnClientClick="return confirm('Está seguro que desea eliminar este registro?');" /></ItemTemplate>
                                                            </asp:TemplateField>
                                                    </Columns>
                                            </asp:GridView>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                        </table>
                        <table class="table table-striped">
                            <tr>
                                <th colspan="4">
                                    <center>
                                        <asp:Button ID="btnAdicionarExperienciaLaboral" runat="server" 
                                                    Text="Adicionar Experiencia Laboral"
                                                    CssClass="btn btn-default" 
                                            onclick="btnAdicionarExperienciaLaboral_Click" />
                                    </center>
                                </th>
                            </tr>
                        </table>
                        <asp:Panel ID="PanelExperienciaLaboral" runat="server" Width="80%" CssClass="panel panel-info" BorderStyle="None">                                        
                            <div class="modal-header">
                                <asp:LinkButton runat="server" ID="ClosePanelExperienciaLaboral" CssClass="close" data-dismiss="modal" Text="&times;" />
                                <h4 class="modal-title">Adicionar Experiencia Laboral</h4>
                            </div>
                            <div class="modal-body">
                                <asp:ValidationSummary ID="ValidationSummary4" HeaderText="<h4><center>Resumen de Errores<center></h4>" CssClass="alert alert-danger" runat="server" ValidationGroup="4" />                                            
                                <table class="table table-striped">
                                    <tr>
                                        <th><center>DATOS DEL EMPLEO</center></th>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="form-inline">
                                                <div class="input-group col-sm-6">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label35" runat="server" Text="Nombre de la Empresa : "></asp:Label>
                                                    </div>
                                                    <asp:TextBox ID="txtEmpresa" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator 
                                                            ID="RequiredFieldValidator15" 
                                                            runat="server" 
                                                            ErrorMessage="(*) El Nombre de la Empresa es requerida." 
                                                            Text="(*)" 
                                                            ControlToValidate="txtEmpresa" 
                                                            ValidationGroup="4"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="input-group col-sm-5">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label36" runat="server" Text="Cargo : "></asp:Label>
                                                    </div>
                                                    <asp:TextBox ID="txtCargo" CssClass="form-control col-sm-3 uppercase" runat="server"></asp:TextBox>
                                                    <div class="input-group-btn">
                                                        <asp:RequiredFieldValidator 
                                                            ID="RequiredFieldValidator19" 
                                                            runat="server" 
                                                            ErrorMessage="(*) El Cargo es requerido." 
                                                            Text="(*)" 
                                                            ControlToValidate="txtCargo" 
                                                            ValidationGroup="4"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="form-inline">
                                                <div class="input-group col-sm-3">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label37" runat="server" Text="Sector : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlSector" 
                                                                        runat="server" 
                                                                        CssClass="form-control col-xs-10">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label38" runat="server" Text="Area de Trabajo : "></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="ddlAreaTrabajo" 
                                                                        runat="server" 
                                                                        CssClass="form-control col-xs-10">
                                                    </asp:DropDownList>
                                                </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="form-inline">
                                                <div class="input-group col-sm-4">                                                                
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label39" runat="server" Text="Fecha de Ingreso: "></asp:Label>
                                                    </div>
                                                    <asp:TextBox ID="txtFechaIngreso" CssClass="form-control col-sm-5" runat="server"></asp:TextBox>
                                                    <div class="input-group-btn">
                                                        <asp:Image ID="iBtnFechaIngreso" runat="server" ImageUrl="~/Images/calendar32.png" />
                                                        <asp:RequiredFieldValidator 
                                                            ID="RequiredFieldValidator20" 
                                                            runat="server" 
                                                            ErrorMessage="(*) La Fecha de Inicio es requerida" 
                                                            Text="(*)" 
                                                            ControlToValidate="txtFechaIngreso" 
                                                            ValidationGroup="4">                                                                       
                                                        </asp:RequiredFieldValidator>
                                                        <asp:CompareValidator 
                                                            ID="CompareValidator5" 
                                                            runat="server" 
                                                            ErrorMessage="(*) La Fecha de Ingreso debe tener un formato de fecha correcto"
                                                            ControlToValidate="txtFechaIngreso"
                                                            Operator="DataTypeCheck" 
                                                            Type="Date" ValidationGroup="4">
                                                        </asp:CompareValidator>
                                                    </div>
                                                    <ajaxToolkit:CalendarExtender 
                                                        ID="CalendarExtender4" 
                                                        Format="yyyy-MM-dd" 
                                                        runat="server" 
                                                        ClearTime="true" 
                                                        PopupButtonID="iBtnFechaIngreso" 
                                                        TargetControlID="txtFechaIngreso">
                                                    </ajaxToolkit:CalendarExtender>                                                                
                                                </div>
                                                <div class="input-group col-sm-4">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label40" runat="server" Text="Fecha de Retiro : "></asp:Label>
                                                    </div>
                                                    <asp:TextBox ID="txtFechaRetiro" CssClass="form-control col-sm-5" runat="server"></asp:TextBox>                                                                
                                                    <div class="input-group-btn">
                                                        <asp:Image ID="iBtnFechaRetiro" runat="server" ImageUrl="~/Images/calendar32.png" />
                                                        <asp:RequiredFieldValidator 
                                                            ID="RequiredFieldValidator21" 
                                                            runat="server" 
                                                            ErrorMessage="(*) La Fecha de Retiro es requerida" 
                                                            Text="(*)" 
                                                            ControlToValidate="txtFechaRetiro" 
                                                            ValidationGroup="4">                                                                       
                                                        </asp:RequiredFieldValidator>
                                                        <asp:CompareValidator 
                                                                ID="CompareValidator6" 
                                                                runat="server" 
                                                                ErrorMessage="(*) La Fecha de Retiro del Estudio debe tener un formato de fecha correcto"
                                                                ControlToValidate="txtFechaRetiro"
                                                                Operator="DataTypeCheck" 
                                                                Type="Date" ValidationGroup="4">
                                                        </asp:CompareValidator>
                                                        <asp:CompareValidator 
                                                                Id="CompareValidator7" 
                                                                runat="server" 
                                                                ControlToCompare="txtFechaIngreso" 
                                                                Cultureinvariantvalues="true" 
                                                                Display="Dynamic" 
                                                                EnableClientScript="true"  
                                                                ControlToValidate="txtFechaRetiro" 
                                                                ErrorMessage="(*) La Fecha de Retiro ser mayor que la Fecha de Inicio" 
                                                                Type="Date" 
                                                                SetFocusOnError="true" 
                                                                Operator="GreaterThan" 
                                                                Text="*"
                                                                ValidationGroup="4">
                                                        </asp:CompareValidator>
                                                    </div>
                                                    <ajaxToolkit:CalendarExtender 
                                                        ID="CalendarExtender5" 
                                                        Format="yyyy-MM-dd" 
                                                        runat="server" 
                                                        ClearTime="true" 
                                                        PopupButtonID="iBtnFechaRetiro" 
                                                        TargetControlID="txtFechaRetiro">
                                                    </ajaxToolkit:CalendarExtender>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="form-inline">
                                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                    <ContentTemplate>
                                                        <div class="input-group col-sm-3">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label41" runat="server" Text="País : "></asp:Label>
                                                            </div>
                                                            <asp:DropDownList ID="ddlPaisExperienciaLaboral" 
                                                                                runat="server" 
                                                                                CssClass="form-control col-xs-10" 
                                                                                AutoPostBack="True" 
                                                                onselectedindexchanged="ddlPaisExperienciaLaboral_SelectedIndexChanged">
                                                            </asp:DropDownList>
                                                        </div>
                                                        <div class="input-group col-sm-4">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label42" runat="server" Text="Dpto/Estado : "></asp:Label>
                                                            </div>
                                                            <asp:DropDownList ID="ddlDepartamentoExperienciaLaboral" 
                                                                                runat="server" 
                                                                                CssClass="form-control col-xs-10" 
                                                                                AutoPostBack="True" 
                                                                onselectedindexchanged="ddlDepartamentoExperienciaLaboral_SelectedIndexChanged">
                                                            </asp:DropDownList>
                                                        </div>                        
                                                        <div class="input-group col-sm-4">
                                                            <div class="input-group-addon">
                                                                <asp:Label ID="Label43" runat="server" Text="Municipio/Ciudad : "></asp:Label>
                                                            </div>
                                                            <asp:DropDownList ID="ddlMunicipioExperienciaLaboral" 
                                                                                runat="server" 
                                                                                CssClass="form-control col-xs-10">
                                                            </asp:DropDownList>
                                                            <div class="input-group-btn">
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                                                    ErrorMessage="(*) El Municipio de Nacimiento del Empleado es requerido" Text="(*)" 
                                                                    ControlToValidate="ddlMunicipioExperienciaLaboral" ValidationGroup="4"></asp:RequiredFieldValidator>
                                                            </div>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                              </div>
                                         </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <center>
                                                <asp:Label ID="Label44" runat="server" Text="Tres Principales Funciones" Font-Bold="true"></asp:Label>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="form-inline">
                                                <center>
                                                    <asp:TextBox 
                                                                ID="txtFunciones" 
                                                                runat="server" 
                                                                TextMode="MultiLine" 
                                                                MaxLength="4000" 
                                                                Rows="3" 
                                                                Columns="130" 
                                                                CssClass="form-control uppercase"></asp:TextBox>
                                                </center>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <center>
                                                <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                                    <ContentTemplate>
                                                        <asp:Button 
                                                            ID="btnGuardarExperienciaLaboral" 
                                                            runat="server" 
                                                            Text="Guardar Experiencia Laboral" 
                                                            CssClass="btn btn-success" 
                                                            ValidationGroup="4" onclick="btnGuardarExperienciaLaboral_Click" />
                                                    </ContentTemplate>
                                                    <Triggers>
                                                        <asp:AsyncPostBackTrigger ControlID="btnGuardarExperienciaLaboral" />
                                                    </Triggers>
                                            </asp:UpdatePanel>                                                            
                                                                
                                            </center>                                                    
                                        </td>                                                
                                    </tr>
                                </table>
                                </div>
                                <div class="modal-footer"></div>
                        </asp:Panel>
                        <ajaxToolkit:ModalPopupExtender 
                            ID="ModalAdicionarExperienciaLaboral" 
                            runat="server"
                            TargetControlID="btnAdicionarExperienciaLaboral" 
                            PopupControlID="PanelExperienciaLaboral"
                            BackgroundCssClass="PopUpBackground"
                            CancelControlID="ClosePanelExperienciaLaboral">
                        </ajaxToolkit:ModalPopupExtender>
                      </div>
                  </div>
                  <div class="col-xs-6 col-md-1"></div>
                  </div>
              </div>
            </div>
              <asp:Panel ID="PanelSubirFoto" runat="server" Width="80%" CssClass="panel panel-info" BorderStyle="None">
                  <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate>
                        <div class="modal-header">
                            <asp:LinkButton runat="server" ID="CloseSubirFoto" CssClass="close" data-dismiss="modal" Text="&times;" />
                            <h4 class="modal-title">Subir Foto del Empleado</h4>
                        </div>
                        <div class="modal-body">
                        <asp:ValidationSummary ID="ValidationSummary5" HeaderText="<h4><center>Resumen de Errores<center></h4>" CssClass="alert alert-danger" runat="server" ValidationGroup="5" />
                            <table class="table table-striped">
                                <tr>
                                    <th><center>SUBIR FOTO DE EMPLEADO</center></th>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-inline">
                                            <center>
                                                <div class="input-group col-sm-8">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="Label45" runat="server" Text="Archivo : "></asp:Label>
                                                    </div>
                                                    <asp:FileUpload ID="fuFotoEmpleado" runat="server" CssClass="form-control uppercase" />
                                                </div>
                                                <div class="input-group-btn">
                                                    <asp:RequiredFieldValidator 
                                                        ID="valFoto" 
                                                        runat="server" 
                                                        ErrorMessage="(*) La Foto del Empleado es requerida" 
                                                        Text="  (*) La Foto del Empleado es requerida" 
                                                        ForeColor="Red"
                                                        ControlToValidate="fuFotoEmpleado" 
                                                        ValidationGroup="5">                                                                       
                                                    </asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator
                                                        id="valExtensionFoto"
                                                        runat="server"
                                                        ErrorMessage="(*) Solo se permite subir imagenes (Formatos: jpg, png, bmp)"
                                                        ValidationExpression ="^.+(.jpg|.JPG|.Jpg|.png|.PNG|.Png|.bmp|.Bmp|.BMP)$"
                                                        ControlToValidate="fuFotoEmpleado" 
                                                        ForeColor="Red"
                                                        ValidationGroup="5">
                                                    </asp:RegularExpressionValidator>
                                                </div>
                                            </center>                                        
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <center>
                                            <asp:Button 
                                                ID="btnSubirFotoModal" 
                                                runat="server" 
                                                ValidationGroup="5" 
                                                Text="Subir Foto" 
                                                CssClass="btn btn-info" onclick="btnSubirFotoModal_Click" />
                                        </center>
                                    
                                    </td>
                                </tr>
                            </table>                        
                        </div>
                        <div class="modal-footer"></div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="btnSubirFotoModal" />
                    </Triggers>
                  </asp:UpdatePanel>
              </asp:Panel>
              <ajaxToolkit:ModalPopupExtender 
                    ID="ModalSubirFoto" 
                    runat="server"
                    TargetControlID="btnSubirFoto"
                    PopupControlID="PanelSubirFoto"
                    BackgroundCssClass="PopUpBackground"
                    CancelControlID="CloseSubirFoto">
              </ajaxToolkit:ModalPopupExtender>
              <asp:Panel ID="Panel1" runat="server">
                  <asp:UpdateProgress ID="UpdateProgress1" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel4">
                        <ProgressTemplate>
                          <div class="divWaiting">	                        
	                        <asp:Image ID="imgWait" 
                                       runat="server" 
	                                   ImageAlign="AbsMiddle" 
                                       ImageUrl="~/Images/Loaders/image_717505.gif" />
                                       <br />
                            <asp:Label ID="lblWait" 
                                       runat="server" 
	                                   Text=" Por favor espere la información se esta actualizando... " />
                          </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
              </asp:Panel>
              <asp:Panel ID="Panel2" runat="server">
                  <asp:UpdateProgress ID="UpdateProgress2" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel5">
                        <ProgressTemplate>
                          <div class="divWaiting">	                        
	                        <asp:Image ID="imgWaitIntegrante" 
                                       runat="server" 
	                                   ImageAlign="AbsMiddle" 
                                       ImageUrl="~/Images/Loaders/image_717505.gif" />
                                       <br />
                            <asp:Label ID="lblWaitIntegrante" 
                                       runat="server" 
	                                   Text=" Por favor espere la solicitud se está procesando... " />
                          </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
              </asp:Panel>

              <asp:Panel ID="Panel3" runat="server">
                  <asp:UpdateProgress ID="UpdateProgress6" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel8">
                        <ProgressTemplate>
                          <div class="divWaiting">	                        
	                        <asp:Image ID="imgWaitEstudio" 
                                       runat="server" 
	                                   ImageAlign="AbsMiddle" 
                                       ImageUrl="~/Images/Loaders/image_717505.gif" />
                                       <br />
                            <asp:Label ID="lblWaitEstudio" 
                                       runat="server" 
	                                   Text=" Por favor espere la información se esta guardando... " />
                          </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
              </asp:Panel>
              <asp:Panel ID="Panel4" runat="server">
                  <asp:UpdateProgress ID="UpdateProgress3" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel10">
                        <ProgressTemplate>
                          <div class="divWaiting">	                        
	                        <asp:Image ID="imgWaitExperiencia" 
                                       runat="server" 
	                                   ImageAlign="AbsMiddle" 
                                       ImageUrl="~/Images/Loaders/image_717505.gif" />
                                       <br />
                            <asp:Label ID="lblWaitExperiencia" 
                                       runat="server" 
	                                   Text=" Por favor espere la información se esta guardando... " />
                          </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
              </asp:Panel>
              <asp:Panel ID="Panel5" runat="server">
                  <asp:UpdateProgress ID="UpdateProgress4" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel7">
                        <ProgressTemplate>
                          <div class="divWaiting">	                        
	                        <asp:Image ID="imgWaitGridFormacionAcademica" 
                                       runat="server" 
	                                   ImageAlign="AbsMiddle" 
                                       ImageUrl="~/Images/Loaders/image_717505.gif" />
                                       <br />
                            <asp:Label ID="lblWaitFormacionAcademica" 
                                       runat="server" 
	                                   Text=" Por favor espere la solicitud se está procesando... " />
                          </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
              </asp:Panel>
              <asp:Panel ID="Panel6" runat="server">
                  <asp:UpdateProgress ID="UpdateProgress5" DisplayAfter="10" 
                    runat="server" AssociatedUpdatePanelID="UpdatePanel9">
                        <ProgressTemplate>
                          <div class="divWaiting">	                        
	                        <asp:Image ID="imgWaitExpLaboral" 
                                       runat="server" 
	                                   ImageAlign="AbsMiddle" 
                                       ImageUrl="~/Images/Loaders/image_717505.gif" />
                                       <br />
                            <asp:Label ID="lblWaitExpLaboral" 
                                       runat="server" 
	                                   Text=" Por favor espere la solicitud se está procesando... " />
                          </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
              </asp:Panel>
 </asp:Content>