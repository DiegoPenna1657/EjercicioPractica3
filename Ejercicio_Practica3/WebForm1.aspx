<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio_Practica2.WebForm1" %>

<!DOCTYPE html>
<style>
html {
 background-color: gray;
 color: darkred;

}
</style>

<html>
<head>
<title>Tienda de tecnologia</title>
</head>
<body style="height: 363px; margin-bottom: 100px">
<form id="Form1" runat="server" method="POST">
<div style="border-radius: 25px;
            font-family:nunito,sans-serif;color:palegreen;
            margin:5px;padding:5px;width:10%;
            border:4px solid red">
<h1>TecForEve </h1>
    </div>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
        <asp:ListItem Value="0">Proveedor</asp:ListItem>
        <asp:ListItem Value="1">Cliente</asp:ListItem>
        <asp:ListItem Value="2">Producto</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    
    <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
        <asp:View ID="View3" runat="server">
            <div style= "font-family:nunito,sans-serif;color:palegreen;">
            <asp:Label ID="Label1" runat="server" Text="Cada uno de nuestros proveedores fueron elegidos menuciosamente para poder ofrecer la mayor calidad de los diferentes productos:"></asp:Label>
            <br />
            <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url" DisplayMode="HyperLink">
            </asp:BulletedList>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml"></asp:XmlDataSource>
            </div>
        </asp:View>

        <asp:View ID="View2" runat="server">
            <div style= "font-family:nunito,sans-serif;color:palegreen;">
            Ingresar DNI del cliente:
            </div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="90px" />
            <br />
            <hr />
        </asp:View>
        <asp:View ID="View1" runat="server" EnableTheming="True">
            <div style= "font-family:nunito,sans-serif;color:palegreen;">
                &nbsp;Seleccionar algunos de nuestros productos
                <select id="Lista" runat="server" name="D1"/>
                <br/>
                <br/>
                <input type="submit" id="boton" runat="server" value="Aceptar" OnServerClick ="boton_ServerClick" />
                <br/>
                <br />
                <br />
                <img id="Grafico" runat="server" />
                <div id="Descripcion" runat="server" style="font-weight:bold">
                </div>
                &nbsp;
                <div id="Precio" runat="server" style="font-weight:bold">
                </div>
                &nbsp;
                </div>

            <asp:HyperLink ID="HyperLink1" runat="server">[HyperLink1]</asp:HyperLink>
        </asp:View>
    </asp:MultiView>
</form>
</body>
</html>
 
 

