<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearDatos.aspx.cs" Inherits="CapturaPrecontratos.CrearDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Demo Capas ASP.NET - SQL Server</title>
    <style type="text/css">
        .auto-style1 {
            width: 323px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #0099CC">
        <div style="text-align: center;">
            <table border="1" style="margin: 0 auto;">
                <tr>
                    <td colspan="2">
                        <h2>
                            <asp:Label ID="Label5" runat="server" Text="Demo Programación en Capas"></asp:Label></h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtIdContrato" runat="server" MaxLength="5"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Dependencia:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtIdDependencia" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Departamento:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtIdDepartamento" runat="server" Width="259px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Partida:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtIdPartida" runat="server" Width="270px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" Width="100px" />
                        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Enabled="False" Width="100px" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="False" OnClick="btnCancelar_Click" Width="100px" />
                        <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <a href="http://sistemasddm.blogspot.com/" target="_blank" style="font-weight: 700">Sistemas DDM</a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
