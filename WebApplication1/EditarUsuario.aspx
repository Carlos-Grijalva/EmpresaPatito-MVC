﻿<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="WebApplication1.EditarUsuario" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form1" runat="server">
            <div id="mensaje" runat="server"></div>
            <div class="row">
                <div class="col-2">Editar Usuario</div>
                <div class="col-6">
                    <div class="mb-3">
                        <label for="txtNombre" class="form-label">Nombre</label>
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="txtNombre" ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label for="txtPrimerApellido" class="form-label">Primer Apellido</label>
                        <asp:TextBox ID="txtPrimerApellido" CssClass="form-control" runat="server"></asp:TextBox>

                        <asp:RequiredFieldValidator ControlToValidate="txtPrimerApellido" ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>

                    </div>
                    <div class="mb-3">
                        <label for="txtSegundoApellido" class="form-label">Segundo Apellido</label>
                        <asp:TextBox ID="txtSegundoApellido" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="txtSegundoApellido" ForeColor="Red" ID="RequiredFieldValidator3" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>

                    </div>
                    <div class="mb-3">
                        <label for="txtEmail" class="form-label">Correo Electronico</label>
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="txtEmail" ForeColor="Red" ID="RequiredFieldValidator4" runat="server" ErrorMessage="CampoRequerido" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ControlToValidate="txtEmail" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato Invalido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>

                    </div>
                    <div class="mb-3">
                        <label for="txtCelular" class="form-label">Celular</label>
                        <asp:TextBox ID="txtCelular" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" Text="Editar Usuario" OnClick="btnAgregar_Click" UseSubmitBehavior="false" />
                    </div>

                </div>

            </div>
        </form>
    </div>
</asp:Content>

    
