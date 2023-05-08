<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="AgregarCuenta.aspx.cs" Inherits="WebApplication1.AgregarCuenta" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form3" runat="server">
            <div id="mensaje" runat="server"></div>
            <div class="row">
                <div class="col-2"></div>
                <div class="col-6">

                    <div class="mb-3">
                        <label for="idUsuario" class="form-label">ID Usuario</label>
                        <asp:TextBox ID="idUsuario" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="idUsuario" ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="saldo" class="form-label">Saldo</label>
                        <asp:TextBox ID="saldo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="saldo" ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="numCuenta" class="form-label">Numero de Cuenta</label>
                        <asp:TextBox ID="numCuenta" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="numCuenta" ForeColor="Red" ID="RequiredFieldValidator3" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" Text="Agregar Tarjeta" OnClick="btnAgregar_Click" />
                    </div>

                </div>
            </div>
        </form>
    </div>
</asp:Content>

