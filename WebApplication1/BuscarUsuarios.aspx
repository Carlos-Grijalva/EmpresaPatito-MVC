<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="BuscarUsuarios.aspx.cs" Inherits="WebApplication1.BuscarUsuarios" EnableEventValidation="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form2" runat="server">
            <div id="mensaje" runat="server"></div>
            <div class="row">
                <div class="col-2">Buscar Usuarios</div>
                <div class="col-6">
                    <div class="mb-3">
                        <asp:TextBox ID="txtCriterios" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar por criterios" OnClick="btnBuscar_Click" />
                        <asp:Button ID="btnBuscarID" runat="server" Text="Buscar por ID" OnClick="btnBuscarID_Click" />
                    </div>
                    <div class="mb-3">
                        <asp:GridView ID="dgvUsuarios" AutoGenerateColumns="false" runat="server" CssClass="table">
                            <Columns>
                                <asp:BoundField DataField="idUsuario" HeaderText="ID" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="ApellidoPaterno" HeaderText="ApellidoP" />
                                <asp:BoundField DataField="ApellidoMaterno" HeaderText="ApellidoM" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Celular" HeaderText="Celular" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" OnClick="eliminar_usuario" CommandArgument='<%# Eval("idUsuario") %>' />
                                        <asp:Button ID="btnEditar" Text="Editar" runat="server" OnClick="modificar_usuario" CommandArgument='<%# Eval("idUsuario") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                            </Columns>
                        </asp:GridView>

                    </div>

                </div>
            </div>
        </form>
    </div>
</asp:Content>


