<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemplo.aspx.cs" Inherits="CapturaPrecontratos.ejemplo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/validaciones.js"></script>
    <!-- prestador-->
    <div class="container">
        <h1>Registro de Nuevo Prestador</h1>
        <div class="row">
            <!-- primer bloque-->
            <div class="col-sm-12">
                <div class="form-group col-sm-3">
                    <label for="paterno">Paterno:</label>
                    <asp:TextBox type="text" ID="paterno" class="form-control"  name="paterno" runat="server"></asp:TextBox>
                    
                </div>
                <div class="form-group col-sm-3">
                    <label for="materno">Materno:</label>
                    <asp:TextBox type="text" ID="materno" class="form-control"  name="materno" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-sm-3">
                    <label for="nombres">Nombres:</label>
                    <asp:TextBox runat="server" id="nombres" CssClass="form-control" name="nombres"/>
                    
                </div>
                <div class="form-group col-sm-3">
                    <label for="FechaNacimiento">Fecha de Nacimiento:</label>
                    <asp:TextBox runat="server" type="date" id="FechaNacimiento" CssClass="form-control" name="FechaNacimiento"/>

                </div>
            </div>
            <!-- Segundo bloque-->
            <div class="col-sm-12">
                 <!-- lista de Genero-->
                <div class="form-group col-sm-3">
                    <label for="genero">Genero:</label>
                    <!--<input type="email" class="form-control">-->
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqlDS_precontratos" DataTextField="Genero" DataValueField="id" class="form-control"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="sqlDS_precontratos" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [id], [Genero] FROM [Genero]"></asp:SqlDataSource>
                </div>
                 <!-- lista de lugar de nacimiento-->
                <div class="form-group col-sm-3">
                    <label for="lugarNacimiento">Lugar de Nacimiento:</label>
                    <asp:DropDownList ID="lugarNacimiento" runat="server" DataSourceID="estados2" DataTextField="estado" DataValueField="id" class="form-control"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="estados2" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [id], [estado] FROM [estados]"></asp:SqlDataSource>
                </div>
                <div class="form-group col-sm-3">
                    <label for="rfc">R.F.C:</label>
                    <asp:TextBox runat="server" type="text" id="rfc" CssClass="form-control" oninput="validarInputRFC(this)" name="rfc"/>

                </div>
                <div class="form-group col-sm-3">
                    <label for="materno">CURP:</label>
                    <asp:TextBox type="text" ID="curp" oninput="validarInputCURP(this)" class="form-control"  name="curp" runat="server"></asp:TextBox>
                    <!-- codigo de validacion  -->
                </div>
               
            </div>
            <!-- Tercer bloque-->
            <div class="col-sm-12">
                 <!-- Lista de Nacionalidad-->
                <div class="form-group col-sm-3">
                    <label for="nacionalidad">Nacionalidad:</label>
                    <asp:DropDownList ID="Nacionalidades" runat="server" DataSourceID="nacionalidad1" DataTextField="nacionalidad" CssClass="form-control" DataValueField="id"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="nacionalidad1" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [id], [nacionalidad] FROM [nacionalidad]"></asp:SqlDataSource>
                </div>
                <div class="form-group col-sm-3">
                    <label for="calle">Calle:</label>
                    <asp:TextBox runat="server" type="text" id="calle" CssClass="form-control" name="calle"/>
                </div>
                <div class="form-group col-sm-3">
                    <label for="exterior">No. Exterior:</label>
                    <asp:TextBox runat="server" type="text" id="exterior" CssClass="form-control" name="exterior"/>                    
                </div>
                <div class="form-group col-sm-3">
                    <label for="interior">No. Interior:</label>
                    <asp:TextBox runat="server" type="text" id="interior" CssClass="form-control" name="interior"/>
                </div>
                  
            </div>
            <!-- cuarto bloque-->
            <div class="col-sm-12">
                <div class="form-group col-sm-3">
                    <label for="colonia">Colonia:</label>
                    <asp:TextBox runat="server" type="text" id="colonia" CssClass="form-control" name="colonia"/>   
                </div>
                <!-- lista de Estados y Municipios-->
                <div class="form-group col-sm-3">
                    <label for="estado">Estado:</label>
                  <!--  <input type="email" class="form-control">-->
                    <asp:DropDownList ID="DropDownList3"  runat="server" class="form-control" DataSourceID="Estados" DataTextField="estado" DataValueField="id" OnTextChanged="DropDownList3_TextChanged"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="Estados" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [id], [estado] FROM [estados]"></asp:SqlDataSource>  
                   <asp:Button ID="Button2" runat="server" Text="Generar"  class="btn btn-default" />
                </div>
                <script></script> 
                <div class="form-group col-sm-3">
                    <label for="municipio">Municipio:</label>
                   <!-- <input type="email" class="form-control" >-->
                    <asp:DropDownList ID="DDLMunicipio" runat="server" class="form-control" DataSourceID="ssdl" DataTextField="municipio" DataValueField="id"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="ssdl" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="spGetMunicipios" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList3" PropertyName="SelectedValue" DefaultValue="1" Name="estado" Type="Int32" ></asp:ControlParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
                <div class="form-group col-sm-3">
                    <label for="cp">Codogo Postal:</label>
                    <asp:TextBox runat="server" type="number" id="cp" oninput="validarCodigoPostal(this)" CssClass="form-control" name="cp"/>

                </div>
                <!-- Lista de Estatus-->
              
            </div>
            <style>
                #div1{
                    padding-left: 31px;
                    padding-right: 11px;
                }
            </style>
        </div>
    </div>  
    <div class="row">
                    <div class="alert alert-danger alert-dismissible col-sm-3" id="resultadocp"> </div>
                    <div class="alert alert-danger alert-dismissible col-sm-3" id="resultadorfc"> </div>
        
                    <div class="alert alert-danger alert-dismissible col-sm-3" id="resultadocurp"> </div>
    </div>
    <br />

    <!-- contrato-->
    <div class="container">
        <h1>Registro PreContrato</h1>
        <div class="row">
            <!-- primer bloque-->
            <div class="col-sm-12">
                <div class="form-group col-sm-3">
                    <label for="FechaInicial">Fecha Inicial:</label>
                    <asp:TextBox runat="server" type="date" id="FechaInicial" CssClass="form-control" name="FechaInicial"/>
                   <asp:Button ID="Button4" runat="server" Text="Generar Partida y Unidad"  class="btn btn-default" />

                </div>
                <div class="form-group col-sm-3">
                    <label for="FechaFinal">Fecha Final:</label>
                    <asp:TextBox runat="server" type="date" id="FechaFinal" CssClass="form-control" name="FechaFinal"/>   
                </div>  
                <div class="form-group col-sm-3">
                    <label for="dependencia">Dependenca:</label>
                    <asp:DropDownList ID="dependencia" class="form-control" runat="server" name="dependencia" DataSourceID="sdlDependencia" DataTextField="Nombre" DataValueField="IDDependencia"></asp:DropDownList>
                   <asp:Button ID="Button3" runat="server" Text="Generar Departamento"  class="btn btn-default" />


                    <asp:SqlDataSource runat="server" ID="sdlDependencia" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [IDDependencia], [Nombre] FROM [Dependencia]"></asp:SqlDataSource>
                </div>
                <div class="form-group col-sm-3">
                    <label for="materno">Departamento:</label>
                    <asp:DropDownList ID="departamento" name="departamento" class="form-control" runat="server" DataSourceID="ddlDepartamentos" DataTextField="Nombre" DataValueField="IDDepartamento"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="ddlDepartamentos" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="spGetDepartamentos" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="dependencia" PropertyName="SelectedValue" DefaultValue="1" Name="dependencia" Type="String"></asp:ControlParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </div>
            <!-- Segundo bloque-->
            <br />
            <div class="col-sm-12">
                 <div class="form-group col-sm-3">
                     <br />
                </div>
                 <div class="form-group col-sm-3">
                    <label for="Unidad">Unidad Administrativa:</label>
                    <asp:DropDownList ID="unidadAdministrativa" runat="server" CssClass="form-control" DataSourceID="ddlUniAdmin" DataTextField="cDescripcionCorta" DataValueField="cIdUnidadAdministrativa"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="ddlUniAdmin" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="spGetUnidadAdmin" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="FechaInicial" PropertyName="Text" Name="ejercicio" Type="DateTime"></asp:ControlParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>       
                 <div class="form-group col-sm-3">
                    <label for="partida">Partida:</label>
                     <asp:DropDownList ID="partidaCodigo" runat="server" CssClass="form-control" DataSourceID="ssdpartida" DataTextField="COG" DataValueField="IdCOG"></asp:DropDownList>
                     <asp:SqlDataSource runat="server" ID="ssdpartida" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="spGetPartidas" SelectCommandType="StoredProcedure">
                         <SelectParameters>
                             <asp:ControlParameter ControlID="FechaInicial" PropertyName="Text" DefaultValue="" Name="ejercicio" Type="DateTime"></asp:ControlParameter>
                         </SelectParameters>
                     </asp:SqlDataSource>
                 </div>
                 <div class="form-group col-sm-3">
                    <label for="estatusContrato">Estatus:</label>
                      <asp:DropDownList ID="estatusContrato" class="form-control" runat="server" DataSourceID="estatusContrato2" DataTextField="Estatus" DataValueField="id"></asp:DropDownList>
                      <asp:SqlDataSource runat="server" ID="estatusContrato2" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [id], [Estatus] FROM [Estatus]"></asp:SqlDataSource>
                  </div>
         
            </div>
            <!-- Tercer bloque--> 
            <div class="col-sm-12">
                <div class="form-group col-sm-3">
                    <label for="ImporteMensual">
                    Importe Mensual:</label>
                    <asp:TextBox runat="server" type="number" id="ImporteMensual" CssClass="form-control" name="ImporteMensual" OnTextChanged="ImporteMensual_TextChanged"/>
                </div>
                <div class="form-group col-sm-3">
                    <label for="importeTotal">Importe Total:</label>
                    <asp:TextBox runat="server" type="number" id="importeTotal" CssClass="form-control" name="importeTotal"/>                    
                </div>
                <div class="form-group col-sm-3">
                    <label for="lugarNacimiento">Ocupacion:</label>
                    <asp:DropDownList ID="ocupacion" runat="server" DataSourceID="ocupaciones" DataTextField="Ocupacion" DataValueField="idOcupacion" class="form-control"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="ocupaciones" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [idOcupacion], [Ocupacion] FROM [Ocupacion]"></asp:SqlDataSource>
                </div>
                <div class="form-group col-sm-3">
                    <label for="estatus">SupTipo:</label>
                    <asp:DropDownList ID="subtipo" CssClass="form-control" runat="server" DataSourceID="ssdlsubtipo" DataTextField="tipo" DataValueField="id"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="ssdlsubtipo" ConnectionString='<%$ ConnectionStrings:PrecontratosConnectionString %>' SelectCommand="SELECT [id], [tipo] FROM [subtipo]"></asp:SqlDataSource>
                </div>
            </div>
            <!-- cuarto bloque-->
            <div class="col-sm-12">
                
                <div class="form-group col-sm-3">
                    <label for="actividades">Actividades:</label>
                    <asp:TextBox id="actividades" columns="34" rows="4" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-sm-3">
                    <label for="genero">Solicitante:</label>
                    <asp:TextBox runat="server" type="number" id="solicitante" CssClass="form-control" name="solicitante"/>
                    </div>
                <div class="form-group col-sm-3">
                    <label for="cp">Observaciones:</label>
                   <asp:TextBox id="observaciones" columns="34" rows="4" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
               <div class="form-group col-sm-3">
                    <label for="capturador">Nombre Capturador:</label>
                    <asp:TextBox runat="server" type="text" id="capturador" CssClass="form-control" name="capturador"/>
                    </div>
            </div>
            <div class="col-sm-12">           
                <div class="form-group col-sm-3">
                    <label for="pccapturador">PC-Capturador</label>
                    <asp:TextBox runat="server" type="text" id="pccapturador" CssClass="form-control" name="solicitante"/>
                    </div>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Guardar"  class="btn btn-primary" OnClick="btnGuardar_Click" /> <!--Enabled="false"   OnClick="btnGuardar_Click"-->
        </div>
    </div>
   

</asp:Content>
