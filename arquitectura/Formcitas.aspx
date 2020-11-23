<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formcitas.aspx.cs" Inherits="arquitectura.Formcitas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="lblcod_cita" runat="server" Text="Codigo cita:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcod_cita" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btconsultar_cita" runat="server" OnClick="btconsultar_cita_Click" Text="Consultar  Cita" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblfecha" runat="server" Text="Fecha cita:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblhora" runat="server" Text="hora:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblid_paciente" runat="server" Text="Id paciente:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtid_paciente" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblresultado" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblid_medico" runat="server" Text="Id medico:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtid_medico" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblvalor" runat="server" Text="Valor:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbldiagnostico" runat="server" Text="Diagnostico:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtdiagnostico" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblnom_acompañante" runat="server" Text="Nombre del acompañante:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtnom_acompañante" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btguardar" runat="server" OnClick="btguardar_Click" Text="Guardar" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
