<%@ Page Title="" Language="C#" MasterPageFile="~/Ui/Base.Master" AutoEventWireup="true" CodeBehind="CPresupuesto.aspx.cs" Inherits="_Parcial2_Ap2_Anthony_Santana_.Ui.Consultas.CPresupuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
       <header>
            <h1 class="page-header text-center">

                  Consulta Clientes <span ></span></h1>
        </header>

  
      
    

          <script src="../../Scripts/popper.min.js"></script>
     <!-- Librerias para Toastr -->
    <link href="/../Content/toastr.css" rel="stylesheet" />
    <script src="../../Scripts/toastr.js"></script>
    <script src="../../Scripts/jquery-3.2.1.js"></script>

 <div class= "text-center">
     
          <span >Selecione-</span>
          <asp:DropDownList ID="DropFiltro"  runat="server" Height="45px"> 
            
              <asp:ListItem>Todo</asp:ListItem>
              <asp:ListItem>ID</asp:ListItem>
              <asp:ListItem>Fecha</asp:ListItem>
              <asp:ListItem>Nombre</asp:ListItem>
              <asp:ListItem>Categoria</asp:ListItem>
          </asp:DropDownList>
      
               

       
        
           
          <br />
      
               

       
        
           
          <span >ID/Nombre</span>
          <asp:TextBox ID="buscaText" runat="server"   placeholder="ID a buscar" Height="45px" ></asp:TextBox>
         <asp:Button ID="Button1" runat="server" Text="Buscar" Height="45px" Width="88px"  />
 
            
  
          <br />

  
         <span>Desde</span>
          
          
          <asp:TextBox ID="desdeFecha"  TextMode="Date"  runat="server" Width="212px" Height="45px"></asp:TextBox>
          <span >Hasta</span>
            
            <asp:TextBox ID="hastaFecha" TextMode="Date"  runat="server" Height="44px" Width="212px"></asp:TextBox>
 
              <br />
            
            
  

  
          <br />    
     
             
       
     </div>

          <div class="center-block" style="overflow: auto; width: 1434px; height: 315px;">



                <asp:GridView ID="presupuestoGrid" runat="server"   CssClass=" table table-striped table-hover table-bordered"  HorizontalAlign="Center" Height="244px" Width="942px" >   
                </asp:GridView>
        
    </div>
    
      <br />
        <a href="../Reportes/Ventanas/Clientereport.aspx" class="btn btn-info">
          <span ></span> Imprimir
        </a> 
       
               <br />
    <br />
     

</asp:Content>
