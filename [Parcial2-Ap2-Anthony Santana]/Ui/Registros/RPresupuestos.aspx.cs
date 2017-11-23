using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial2_Ap2_Anthony_Santana_.Ui.Registros
{
    public partial class RPresupuestos : System.Web.UI.Page
    {

        DataTable dt = new DataTable();
        private static List<Entidades.PresupuestoDetalles> listaRelaciones;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[3] {  new DataColumn("Descripcion"), new DataColumn(" Meta"), new DataColumn("Logrado") });
                ViewState["Detalle"] = dt;
                TextFecha.Text = (DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
                listaRelaciones = new List<Entidades.PresupuestoDetalles>();
                presupuestosg = new Presupuestos();
            }
        }


        Presupuestos presupuestosg = new Presupuestos();

        private void Limpiar()
        {
          //  GridViewPresupuestos.DataSource = null;
      
        //    GridViewPresupuestos.DataSource = (DataTable)ViewState["Detalle"];
            dt.Rows.Clear();
            GridViewPresupuestos.DataBind();
            MontoTexbo.Text = "";
            TextBoxID.Text = "";
            MetaTexbox.Text = "";
            LogradoTexbox.Text = "";
            TextBoxNombre.Text = "";
            TextFecha.Text = (DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);

            listaRelaciones = new List<Entidades.PresupuestoDetalles>();
        }

        public void LlenarRegistro(List<Entidades.PresupuestoDetalles> nuevo)
        {

            foreach (var li in nuevo)
            {
                DataTable dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(li.Descripcion, li.Meta, li.Logrado);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }


        }

        protected void BindGrid()
        {
            GridViewPresupuestos.DataSource = (DataTable)ViewState["Detalle"];
            GridViewPresupuestos.DataBind();
        }


        public void LlenarCampos(Entidades.PresupuestoDetalles detalle)
        {

            


            foreach (GridViewRow dr in GridViewPresupuestos.Rows)
            {
                detalle.AgregarDetalle(0, 0, TextBoxNombre.Text, Convert.ToDecimal(MetaTexbox.Text), Convert.ToDecimal(LogradoTexbox.Text));
            }

            presupuestosg = new Presupuestos(0, Convert.ToDateTime(TextFecha.Text), TextBoxNombre.Text, Convert.ToDecimal(MontoTexbo.Text));

            
        }



        protected void Button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo buscar vacio ');</script>");

                Limpiar();
            }
            else

            {
                //Limpiar();

                int id = Convert.ToInt32(TextBoxID.Text);
                var usuar = BLL.PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
                if (usuar != null)
                {


                    TextBoxNombre.Text = usuar.Descripcion;
                    MontoTexbo.Text = Convert.ToString(usuar.Monto);  
                    TextFecha.Text = Convert.ToString(usuar.Fecha);
                  
                    listaRelaciones = BLL.PresupuestoDetalleBLL.GetList(A => A.PresupuestoId == presupuestosg.PresupuestoId);
                    

                    LlenarRegistro(listaRelaciones);

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Resultados ');</script>");

                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe ');</script>");

                    Limpiar();

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxID.Text))
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campo buscar vacio ');</script>");

                Limpiar();


            }
            else
            {
                int id = int.Parse(TextBoxID.Text);
             
                var user = BLL.PresupuestoBLL.Buscar(p => p.PresupuestoId == id);
                if (BLL.PresupuestoBLL.Eliminar(user))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Elimino Correctamente ');</script>");


                    Limpiar();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Error ');</script>");

                    Limpiar();

                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            


            Entidades.PresupuestoDetalles detallef = new Entidades.PresupuestoDetalles();
           
            LlenarCampos(detallef);



            if (BLL.PresupuestoBLL.Guardar2(presupuestosg, detallef.Detalle))
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardo Correctamente ');</script>");

                Limpiar();
              
            }

            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Errror!');</script>");


                Limpiar();
            }





         
        }

        protected void ButtoAgregar_Click(object sender, EventArgs e)
        {

            int id2 = 0;
            if (presupuestosg != null)
            {
                id2 = presupuestosg.PresupuestoId;

            }

         
         
             
                    DataTable dt = (DataTable)ViewState["Detalle"];
                    dt.Rows.Add( TextBoxNombre.Text, MetaTexbox.Text, LogradoTexbox.Text);
                    ViewState["Detalle"] = dt;
                    this.BindGrid();
                  
        
                


            }

        
    }
}