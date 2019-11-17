<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersona.aspx.cs" Inherits="MVC.Vista.frmPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
            <center>
                <p>
                    <asp:Button runat="server" OnClick="Unnamed1_Click" Text="Agregar" ID="Agregar" style="margin-left: 0px" CssClass="btn-outline-success"/><asp:Button runat="server" Text="Modificar" ID="Modificar" style="margin-left: 24px" OnClick="Unnamed2_Click" CssClass="btn-outline-info"/>
                </p>
                <p>
                     <input type="hidden" runat="server" id="id"/>
                </p>  
                <p>
                    <input type="text" runat="server" placeholder="Nombre" id="nombre" minlength="3" maxlength="40"/>
                </p>
                <p>
                    <input type="text" runat="server" placeholder="Apellidos" id="apellidos" minlength="5" maxlength="40"/>
                </p>
                 <p>
                     <input type="text" runat="server" placeholder="Teléfono" id="telefono" minlength="5" maxlength="40"/>
                 </p>
                <p>
                    <input type="text" runat="server" placeholder="Email" id="email" class="" fon="control" minlength="5" maxlength="40" required="@"/>
                </p>
                 <p>
                    <asp:Label ID="Label1" runat="server" Text="lblMensaje"></asp:Label>
                 </p>
    <asp:DataGrid ID="DgvDatos" runat="server" style="margin-left: 0px" OnDeleteCommand="dgv_DatosDelete" 
        OnEditCommand="dgv_Datos" OnSelectedIndexChanged="DgvDatos_SelectedIndexChanged" 
        Width="64px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundColumn DataField="id" HeaderText="ID" SortExpression="id"></asp:BoundColumn>
            <asp:BoundColumn DataField="nombre" HeaderText="Nombre" SortExpression="id"></asp:BoundColumn>
            <asp:BoundColumn DataField="apellidos" HeaderText="Apellidos" SortExpression="id"></asp:BoundColumn>
            <asp:BoundColumn DataField="telefono" HeaderText="Teléfono" SortExpression="id"></asp:BoundColumn>
            <asp:BoundColumn DataField="email" HeaderText="Email" SortExpression="id"></asp:BoundColumn>
            <asp:ButtonColumn CommandName="Delete" HeaderText="Eliminar" Text="Eliminar"></asp:ButtonColumn>
            <asp:EditCommandColumn CancelText="Cancelar" EditText="Editar" HeaderText="Modificar" UpdateText="Actualizar"></asp:EditCommandColumn>
        </Columns>
        <EditItemStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    </asp:DataGrid>
                </center>
</form>   
</body>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</html>
