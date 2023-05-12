<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="BuscarCuentas.aspx.cs" Inherits="WebApplication1.BuscarCuentas" EnableEventValidation="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form2" runat="server">
            <div id="mensaje" runat="server"></div>
            <div class="row">
                <div class="col-2">Buscar Cuentas</div>
                <div class="col-6">
                    <div class="mb-3">
                        <asp:TextBox ID="txtCriterios" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar por criterios" OnClick="btnBuscar_Click" />
                        <asp:Button ID="btnBuscarID" runat="server" Text="Buscar por ID" OnClick="btnBuscarID_Click" />
                    </div>
                    <div class="mb-3">
                        <asp:GridView ID="dgvCuentas" AutoGenerateColumns="false" runat="server" CssClass="table">
                            <Columns>
                                <asp:BoundField DataField="idCuenta" HeaderText="ID" />
                                <asp:BoundField DataField="idUsuario" HeaderText="ID usuario" />
                                <asp:BoundField DataField="Saldo" HeaderText="Saldo" />
                                <asp:BoundField DataField="NumeroCuenta" HeaderText="NumeroCuenta" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" OnClick="eliminar_cuenta" CommandArgument='<%# Eval("idCuenta") %>' />
                                        <asp:Button ID="btnEditar" Text="Editar" runat="server" OnClick="modificar_cuenta" CommandArgument='<%# Eval("idCuenta") %>' />
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


