<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CapturaPrecontratos.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <table border="1" style="margin: 0 auto;">
                <tr>
                    <td colspan="3">
                        <h2>
                            <asp:Label ID="Label5" runat="server" Text="Contratos"></asp:Label></h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Ingrese Dependencia:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdDependencia" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                        <asp:Button ID="btnNuevoCliente" runat="server" OnClick="btnNuevoCliente_Click" Text="Nuevo" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <div style="overflow-x:auto;">
                        <asp:GridView ID="GridViewDatos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridViewDatos_RowDeleting" OnRowCommand="GridViewDatos_RowCommand" AllowPaging="True" OnPageIndexChanging="GridViewDatos_PageIndexChanging">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="#" ShowHeader="False">
                                    <ItemTemplate>
                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField ButtonType="button" CommandName="Actualizar"
                                    HeaderText="Editar" Text="Editar" />
                                <asp:BoundField DataField="idContratoServicio" HeaderText="id" />
                                <asp:BoundField DataField="idDependencia" HeaderText="Dependencia" />
                                <asp:BoundField DataField="idDepartamento" HeaderText="Departamento" />
                                <asp:BoundField DataField="UnidadAdministrativa" HeaderText="Unidad Admin" />
                                
                                
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                            </div>
                    </td>
                </tr>              
                          
            </table>
        </asp:Content>