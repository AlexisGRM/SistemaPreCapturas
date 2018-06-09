<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CapturaPrecontratos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h1>Captura Contratos</h1>


    <div style="background-color: #eeeeee">
        <h3>Prestador de Servicios</h3>
    <table>
        <tr>
            <th>Apellido Paterno</th>
            <th>Apellido Materno</th>
            <th>Nombre</th>
            <th>Fecha de Nacimiento</th>
            <th>R.F.C.</th>
         
        </tr>
        <tr>
            
            <td><asp:TextBox ID="txbPaterno" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                  ControlToValidate="txbPaterno"
                  ErrorMessage="Campo necesario">
                </asp:RequiredFieldValidator>
            <td><asp:TextBox ID="txbMaterno" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbNombre" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbFechaNac" runat="server" ValidationGroup="Validar" TextMode="Date"></asp:TextBox></td>
            <td><asp:TextBox ID="txbRFC" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
           

    
        </tr>
        <tr>
            <th>Lugar de Nacimiento</th>
            <th>Nacionalidad</th>
            <th>Calle</th>
            <th># Exterior</th>
            <th>Interior</th>
        </tr>
         <tr>
            <td>
                            
                <asp:DropDownList ID="ddlLugarNac" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombreEstado" DataValueField="idEstados">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [idEstados], [nombreEstado] FROM [Estados]"></asp:SqlDataSource>
                            
             </td>
            <td><asp:DropDownList ID="ddlNacion" runat="server">
                <asp:listitem value ="1">Mexicana</asp:listitem>
                </asp:DropDownList></td>

            <td><asp:TextBox ID="txbCalle" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbExterior" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbInterior" runat="server" ValidationGroup="Validar"></asp:TextBox></td>

         </tr>
        <tr>
            <th>Colonia</th>
            <th>C.P.</th>
            <th>Ciudad</th>
            <th>Genero</th>
            <th>CURP</th>
        </tr>
        <tr>
            <td><asp:TextBox ID="txbColonia" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbCp" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td>
                
                <asp:DropDownList ID="ddlCiudad" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombreEstado" DataValueField="idEstados">
                </asp:DropDownList>
                
            </td>
            <td><asp:DropDownList ID="ddlGenero" runat="server">
                <asp:listitem value ="M">MASCULINO</asp:listitem>
                <asp:listitem value ="F">FEMENINO</asp:listitem>
                </asp:DropDownList></td>
            <td><asp:TextBox ID="txbCurp" runat="server" ValidationGroup="Validar"></asp:TextBox></td>

        </tr>
        
    </table>
    </div>

    <div style="background-color: #eeeeee">
         <h3>Contrato</h3>
    
    <table>
        <tr>
            <th>Unidad Administrativa</th>
            <th>Ejercicio</th>
            
            <th>Dependencia</th>
            <th></th>
            <th>Departamento</th>
            <th></th>
        </tr>
         <tr>
            <td><asp:DropDownList ID="ddlUnidAdmin" runat="server" DataSourceID="SqlDataSource6" DataTextField="cIdUnidadAdministrativa" DataValueField="cIdUnidadAdministrativa">
               
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="spSelectUnidadAdmin" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
             </td>
            <td>
                <asp:TextBox ID="txbUnidAdminEjerc" runat="server"  ValidationGroup="Validar"></asp:TextBox>
             </td>
            
            <td><asp:DropDownList ID="ddlDepend" runat="server" DataSourceID="SqlDataSource4" DataTextField="IDDependencia" DataValueField="IDDependencia"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [IDDependencia], [IDSecretaria], [Nombre] FROM [Dependencia]"></asp:SqlDataSource>
             </td>
            <td>
                <asp:TextBox ID="txbDepend" runat="server"></asp:TextBox>
             </td>
             <td><asp:DropDownList ID="ddlDepart" runat="server" DataSourceID="SqlDataSource5" DataTextField="IDDepartamento" DataValueField="IDDepartamento"></asp:DropDownList>
                 <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [IDDependencia], [IDDepartamento], [Nombre] FROM [Departamento]"></asp:SqlDataSource>
             </td>
            <td>
                <asp:TextBox ID="txbDepart" runat="server"></asp:TextBox>
             </td>

        </tr>
        <tr>
            <th>Partida</th>
            <th>Ejercicio</th>
            <th>Importe Mens</th>
            <th>Importe Total</th>
            <th>Fecha Inicio</th>
            <th>Fecha Fin</th>
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlPartida" runat="server" DataSourceID="SqlDataSource3" DataTextField="idCOG" DataValueField="IdCOG" OnSelectedIndexChanged="ddlPartida_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [IdCOG], [Ejercicio], [COG] FROM [Partidas]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:TextBox ID="txbEjercicioPart" runat="server"></asp:TextBox>
            </td>
            <td><asp:TextBox ID="txbImporMens" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbImporTotal" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbFechaIni" runat="server" ValidationGroup="Validar" TextMode="Date"></asp:TextBox></td>
            <td><asp:TextBox ID="txbFechaFin" runat="server" ValidationGroup="Validar" TextMode="Date"></asp:TextBox></td>

        </tr>
        <tr>
            <th>Puesto</th>
            <th></th>
            <th>Docente/No docente</th>
            <th>Actividades</th>
            
            
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlPuesto" runat="server" DataSourceID="SqlDataSource7" DataTextField="idOcupacion" DataValueField="idOcupacion">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [idOcupacion], [Ocupacion] FROM [Ocupacion]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:TextBox ID="txbPuesto" runat="server"></asp:TextBox>
            </td>
            <td><asp:DropDownList ID="ddlDocen" runat="server">
                    <asp:listitem value ="1">SIN SUBTIPO</asp:listitem>
                <asp:listitem value ="2">Docente</asp:listitem>
                <asp:listitem value ="3">NO Docente</asp:listitem>
                </asp:DropDownList></td>
            <td><asp:TextBox ID="txbActivi" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            

        </tr>
        <tr>
            <th>Solicitante</th>
            <th></th>
            <th>Estatus</th>
            <!--<th><asp:Label ID="lblComprobanteEstudios" runat="server" Text="Comprobante Estudios"></asp:Label><asp:CheckBox ID="cbCompEstu" runat="server"  AutoPostBack="true" /></th>
            <th><asp:Label ID="lblCurriculum" runat="server" Text="Curriculum"></asp:Label><asp:CheckBox ID="cbCurriculum" runat="server" AutoPostBack="true" /></th>
            <th><asp:Label ID="lblCartNoAnte" runat="server" Text="Carta No Antesedente"></asp:Label><asp:CheckBox ID="cbCartaNoAnt" runat="server" AutoPostBack="true" /></th>
            <th><asp:Label ID="lblIdentifi" runat="server" Text="Identificacion"></asp:Label><asp:CheckBox ID="cbIdentif" runat="server" AutoPostBack="true" /></th>-->
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlSolic" runat="server">
                 <asp:listitem value ="1">1</asp:listitem>
                </asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txbSolic" runat="server"></asp:TextBox>
            </td>
            <td>
               
                <asp:DropDownList ID="ddlStatus" runat="server" DataSourceID="SqlDataSource2" DataTextField="Estatus" DataValueField="id">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="SELECT [id], [Estatus] FROM [Estatus]"></asp:SqlDataSource>
               
            </td>
            <!--<th><asp:Label ID="lblCartNoInha" runat="server" Text="Carta No Inhabilitado"></asp:Label><asp:CheckBox ID="cbCartaNoInha" runat="server" AutoPostBack="true"  /></th>
            <th><asp:Label ID="lblActNac" runat="server" Text="Acta Nacimiento"></asp:Label><asp:CheckBox ID="cbActaNac" runat="server" AutoPostBack="true" /></th>
            <th><asp:Label ID="lblCurp" runat="server" Text="Curp"></asp:Label><asp:CheckBox ID="cbCurp" runat="server" AutoPostBack="true" /></th>
            <th><asp:Label ID="lblCompDom" runat="server" Text="ComprobanteDom"></asp:Label><asp:CheckBox ID="cbComprobDom" runat="server" AutoPostBack="true" /></th>-->               
        </tr>
        
        <tr>
            <th>Nombre Capturador</th>
            <th>Fecha de Captura</th>
            <th>Computadora de Captura</th>
            <th>Observaciones</th>
        </tr>
        <tr>
            <td><asp:TextBox ID="txbUsuarioCap" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbFechaCap" runat="server" ValidationGroup="Validar" TextMode="Date"></asp:TextBox></td>
            <td><asp:TextBox ID="txbCompuCap" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
            <td><asp:TextBox ID="txbObserv" runat="server" ValidationGroup="Validar"></asp:TextBox></td>
        </tr>
    </table>
     
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar"/>
        
         
    </div>

</asp:Content>
