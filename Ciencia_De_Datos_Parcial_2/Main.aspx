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
        <table class="auto-style1">
            <tr>
                <td colspan="5">Ingrese los valores historicos de los plazos fijos de los bancos: </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><strong>Banco Provincia:</strong></td>
                <td>&nbsp;</td>
                <td><strong>Banco Nación:</strong></td>
                <td>&nbsp;</td>
                <td><strong>Banco Hipotecario:</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtProv1" runat="server"></asp:TextBox>
                &nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="frvProv1" runat="server" ControlToValidate="txtProv1" ErrorMessage="Ingresar un valor para el primer año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revProv1" runat="server" ControlToValidate="txtProv1" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtNac1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvNac1" runat="server" ControlToValidate="txtNac1" ErrorMessage="Ingresar un valor para el primer año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revNac1" runat="server" ControlToValidate="txtNac1" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtHip1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvHip1" runat="server" ControlToValidate="txtHip1" ErrorMessage="Ingresar un valor para el primer año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revHip1" runat="server" ControlToValidate="txtHip1" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtProv2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvProv2" runat="server" ControlToValidate="txtProv2" ErrorMessage="Ingresar un valor para el segundo año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revProv2" runat="server" ControlToValidate="txtProv2" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtNac2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvNac2" runat="server" ControlToValidate="txtNac2" ErrorMessage="Ingresar un valor para el segundo año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revNac2" runat="server" ControlToValidate="txtNac2" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtHip2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvHip2" runat="server" ControlToValidate="txtHip2" ErrorMessage="Ingresar un valor para el segundo año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revHip2" runat="server" ControlToValidate="txtHip2" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtProv3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvProv3" runat="server" ControlToValidate="txtProv3" ErrorMessage="Ingresar un valor para el tercer año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revProv3" runat="server" ControlToValidate="txtProv3" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtNac3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvNac3" runat="server" ControlToValidate="txtNac3" ErrorMessage="Ingresar un valor para el tercer año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revNac3" runat="server" ControlToValidate="txtNac3" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtHip3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="frvHip3" runat="server" ControlToValidate="txtHip3" ErrorMessage="Ingresar un valor para el tercer año"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revHip3" runat="server" ControlToValidate="txtHip3" ErrorMessage="Solamente numeros" ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCalcularInversion" runat="server" Text="Calcular inversión" />
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>