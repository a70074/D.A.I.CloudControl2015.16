<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerirUtilizadoresSistema.aspx.cs" Inherits="ajuUminho.webforms.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; font-size: small">
    <form id="form1" runat="server">
    <div>
        <h4 style="font-size: medium">Register a new user</h4>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        <asp:Button ID="Button5" runat="server" OnClick="signOut" Text="Logout" />
        <hr />
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>                
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="UserName" />                
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                <asp:TextBox ID="Telefone" runat="server"></asp:TextBox>
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />                
            </div>
        </div>
        <div>
            <div>
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" />
            </div>
        </div>
    </div>
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server">Type a role name</asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Adicionar Role Ao sistema" />
    
        <hr />
    
    </div>
        <div>

            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" AutoPostBack="True">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [AspNetRoles]" OnDataBinding="Button1_Click"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="UserName" DataValueField="Id" AutoPostBack="True">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Id], [UserName] FROM [AspNetUsers]"></asp:SqlDataSource>
            
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Adicionar Role ao user selecionado" />
            <div>
                
                <hr />
                
            </div>
    </div>

        <div>

            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="UserName" DataValueField="Id">
            </asp:DropDownList>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ver Roles do user selecionado" />
            <hr />
            <div>
                <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource2" DataTextField="UserName" DataValueField="Id">
                </asp:DropDownList>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Alterar PWD do user selecionado" />
            </div>
            <br />


    </div>
    </form>
</body>
</html>
