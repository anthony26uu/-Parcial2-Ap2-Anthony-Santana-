<%@ Page Title="" Language="C#" MasterPageFile="~/Ui/Base.Master" AutoEventWireup="true" CodeBehind="RPresupuestos.aspx.cs" Inherits="_Parcial2_Ap2_Anthony_Santana_.Ui.Registros.RPresupuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





  <div class="text-center">
        <h1 class="page-header text-center text-info">Registro Presupuestos </h1>
    </div>





    <div class="text-center">

        <span class="badge badge-primary">ID</span>
        <br />


        <asp:TextBox ID="TextBoxID"  TextMode="Number"   class="input-lg" placeholder="ID a buscar " runat="server" Height="45px" Width="160px" ValidationGroup="buscar"></asp:TextBox>
        <asp:Button ID="BotonBuscar"   runat="server" Text="Buscar" Height="45px" OnClick="BotonBuscar_Click" />
        <br />

    <br />
    <!--Texbox -->
   
    

  
   
        <span class="badge badge-primary">Descripcion</span>


        <br />
             

        <asp:TextBox ID="TextBoxNombre" placeholder="Descripcion"  TextMode= "MultiLine" runat="server" Height="30px" Width="215px"></asp:TextBox>

        &nbsp;<br />

        <br />
                
        <span class="badge badge-primary">Fecha Registro</span><!--Texbox --><br />
        <asp:TextBox ID="TextFecha" runat="server" placeholder="00/00/0000 " class="input-lg" ReadOnly="True"  Height="30px" Width="215px"></asp:TextBox>


        <br />


        <span class="badge badge-primary">Monto</span><asp:TextBox ID="MontoTexbo" runat="server" placeholder="000.00" class="input-lg"  Height="30px" Width="215px"></asp:TextBox>


        <span class="badge badge-primary">Meta
        </span>


        <asp:TextBox ID="MetaTexbox" runat="server" placeholder="000.00" class="input-lg"  Height="30px" Width="215px"></asp:TextBox>


        <span class="badge badge-primary">Logrado
        </span>


        <asp:TextBox ID="LogradoTexbox" runat="server" placeholder="000.00" class="input-lg"  Height="30px" Width="215px"></asp:TextBox>


        <br />
        <asp:Button ID="ButtoAgregar"  runat="server" Text="Agregar" Height="36px" Width="88px" OnClick="ButtoAgregar_Click"   />


        

          <br />  <br />
        <!--Texbox -->
          <br />
          <div class="center-block" style="overflow: auto; width: 680px; height: 200px;">


                      <asp:GridView ID="GridViewPresupuestos" class="text-center" runat="server" Height="115px" Width="611px">
        </asp:GridView>
        </div>

        <!--Select -->

    
        <br />
    </div>
        
 

  
      
    <!--Botones -->

    <div class="text-center">
        <asp:Button ID="ButtoNuevo"  runat="server" Text="Nuevo" Height="36px" Width="88px" OnClick="Button4_Click"  />
        <asp:Button ID="ButtonGuardar"  runat="server" Text="Guardar" Height="36px" Width="88px" OnClick="Button2_Click" />
        <asp:Button ID="ButtonEliminar"  runat="server" Text="Eliminar" Height="36px" Width="88px" OnClick="Button3_Click" />
    </div>

    <br />


</asp:Content>
