<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="BuscarTarjetas.aspx.cs" Inherits="WebApplication1.BuscarTarjetas" EnableEventValidation="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form2" runat="server">
            <div id="mensaje" runat="server"></div>
            <div class="row">
                <div class="col-2">Buscar Tarjetas</div>
                <div class="col-6">
                    <div class="mb-3">
                        <asp:TextBox ID="txtCriterios" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar por criterios" OnClick="btnBuscar_Click" />
                        <asp:Button ID="btnBuscarID" runat="server" Text="Buscar por ID" OnClick="btnBuscarID_Click" />
                    </div>
                    <div class="mb-3">
                        <asp:GridView ID="dgvTarjetas" AutoGenerateColumns="false" runat="server" CssClass="table">
                            <Columns>
                                <asp:BoundField DataField="idTarjeta" HeaderText="ID" />
                                <asp:BoundField DataField="idCuenta" HeaderText="ID cuenta" />
                                <asp:BoundField DataField="nombreEntidad" HeaderText="Entidad" />
                                <asp:BoundField DataField="numeroTarjeta" HeaderText="Numero de tarjeta" />
                                <asp:BoundField DataField="fechaCaducidad" HeaderText="Fecha de caducidad" />
                                <asp:BoundField DataField="marca" HeaderText="Marca" />
                                <asp:BoundField DataField="cvv" HeaderText="CVV" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" OnClick="eliminar_tarjeta" CommandArgument='<%# Eval("idTarjeta") %>' />
                                        <asp:Button ID="btnEditar" Text="Editar" runat="server" OnClick="modificar_tarjeta" CommandArgument='<%# Eval("idTarjeta") %>' />
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
