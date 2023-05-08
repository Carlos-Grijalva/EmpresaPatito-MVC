<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="WebApplication1.InicioSesión" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid m-5">
        <form id="form1" runat="server">
            <div class="row">
                <div class="col-4"></div>
                <div class="col-4">
                    <h1 class="h3 mb-3 fw-normal">Ingresar Sistema</h1>
                    <div class="form-floating p-4">
                        <label for="txtEmail">Correo Electronico</label>
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" * Campo Requerido" ControlToValidate="txtEmail" CssClass="alert-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" CssClass="alert" Display="Dynamic" ErrorMessage="Formato Incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                    <div class="form-floating p-4">
                        <label for="txtContrasena">Contrasena</label>
                        <asp:TextBox ID="txtContrasena" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* CampoRequerido" ControlToValidate="txtContrasena" CssClass="alert-danger" Display="Dynamic"></asp:RequiredFieldValidator>

                    </div>
                    <asp:Button ID="btnIngresar" CssClass="w-100 btn btn-lg btn-primary p-4" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />


                    <asp:Label ID="txtError" Visible="false" runat="server" Text="*" CssClass="alert-danger"></asp:Label>

                </div>
                <div class="col-4"></div>
            </div>
        </form>
    </div>

</asp:Content>


