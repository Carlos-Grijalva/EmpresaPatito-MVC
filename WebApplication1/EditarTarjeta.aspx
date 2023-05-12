<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="EditarTarjeta.aspx.cs" Inherits="WebApplication1.EditarTarjeta" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form3" runat="server">
            <div id="mensaje" runat="server"></div>
            <div class="row">
                <div class="col-2">Editar Tarjeta</div>
                <div class="col-6">
                    <div class="mb-3">
                        <label for="idCuenta" class="form-label">ID Cuenta</label>
                        <asp:DropDownList ID="idCuenta" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="idCuenta" ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="nomEntidad" class="form-label">Nombre Entidad</label>
                        <asp:TextBox ID="nomEntidad" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="nomEntidad" ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="numTarjeta" class="form-label">Numero de Tarjeta</label>
                        <asp:TextBox ID="numTarjeta" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="numTarjeta" ForeColor="Red" ID="RequiredFieldValidator3" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="fechaCadu" class="form-label">Fecha Caducidad</label>
                        <asp:Calendar ID="fechaCadu" runat="server"></asp:Calendar>
                        
                    </div>
                    

                    <div class="mb-3">
                        <label for="marca" class="form-label">Marca</label>
                        <asp:TextBox ID="marca" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="marca" ForeColor="Red" ID="RequiredFieldValidator5" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="cvv" class="form-label">CVV</label>
                        <asp:TextBox ID="cvv" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="cvv" ForeColor="Red" ID="RequiredFieldValidator6" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>


                    <div class="mb-3">
                        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" Text="Editar Tarjeta" OnClick="btnAgregar_Click" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>


