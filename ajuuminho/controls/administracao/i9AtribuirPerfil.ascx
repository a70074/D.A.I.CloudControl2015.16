<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i9AtribuirPerfil.ascx.cs" Inherits="ajuUminho.controls.administracao.i9AtribuirPerfil" %>

        <div id="IdentidadesBox">
            <h3>Utilizadores</h3> <div class="hr-alignMore"> <hr /> </div>
            <div id="ListBoxIdentidades">
                       <asp:ListBox ID="ListBoxIdentidadesID" runat="server" CssClass="ListBoxIdentidades-Item" AutoPostBack="True"></asp:ListBox>
            </div>
        </div>

            <div id="RolesBox">
                <h3>Perfis</h3> <div class="hr-alignMore"> <hr /> </div>
                <div id="PerfisListBox1">
                    <div id="PerfisListBox3">
                        <h4>Perfis do Sistema</h4> <div class="hr-alignLess"> <hr /> </div>
                    <div class="PerfisListBox-Item">
                        <asp:ListBox ID="ListBoxPerfisID" runat="server" CssClass="PerfisList-Item" DataSourceID="SqlDataSource1" AutoPostBack="True"></asp:ListBox>
                    </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    </div>
                <div id="PerfisButtonsBox">
                    <asp:Button ID="ButtonMoreID" runat="server" Text=">" CssClass="MoreButton" />
                    <asp:Button ID="ButtonLessID" runat="server" Text="<" CssClass="LessButton" />
                </div>
                    <div id="PerfisListBox4">
                        <h4>Perfis Associados ao Utilizador</h4> <div class="hr-alignLess"> <hr /> </div>
                    <div class="PerfisListBox-Item">
                        <asp:ListBox ID="ListBoxPerfisAssociadosID" runat="server" CssClass="PerfisList-Item" AutoPostBack="True"></asp:ListBox>
                    </div>
                    </div>
                </div>

                <div id="PerfisListBox2">
                    <div id="AdicionarPerfilBox">
                    <h4>Adicionar novo perfil ao sistema</h4> <div class="hr-alignLess"> <hr /> </div>
                    <asp:TextBox ID="TextBoxAdicionarPerfilID" runat="server"></asp:TextBox>
                    <asp:Button ID="ButtonAdicionarPerfilID" runat="server" Text="+" Width="25px" CssClass="AdicionarPerfilButton" />
                    </div>
                   </div>
            </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" />
            <asp:Button ID="ButtonGravarID" runat="server" Text="Gravar" CssClass="ContentButton" />
            <asp:Button ID="ButtonAlterarPasswordID" runat="server" Text="Alterar Password" CssClass="ContentButton" />
        </div>

