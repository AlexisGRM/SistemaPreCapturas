<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CapturaPrecontratos.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<<<<<<< HEAD
    <h2>Pendientes</h2>
    <h3>Listado de PreContratos pendientes</h3>

                </asp:Content>
=======
    <h2><%: Title %></h2>
    <h3>Lista de Prestadores</h3>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idContratoServicio" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="idContratoServicio" HeaderText="idContratoServicio" InsertVisible="False" ReadOnly="True" SortExpression="idContratoServicio" />
                <asp:BoundField DataField="idDependencia" HeaderText="idDependencia" SortExpression="idDependencia" />
                <asp:BoundField DataField="idDepartamento" HeaderText="idDepartamento" SortExpression="idDepartamento" />
                <asp:BoundField DataField="idPartida" HeaderText="idPartida" SortExpression="idPartida" />
                <asp:BoundField DataField="Paterno" HeaderText="Paterno" SortExpression="Paterno" />
                <asp:BoundField DataField="Materno" HeaderText="Materno" SortExpression="Materno" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conexion %>" SelectCommand="spSelectContrato" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    
</asp:Content>
>>>>>>> 38dc533a13cdc32ea45469a30476a9431209085c
