using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Parcial2_Ap2_Anthony_Santana_.Ui.Consultas
{
    public partial class CPresupuesto : System.Web.UI.Page
    {
        public static List<Entidades.PresupuestoDetalles> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = BLL.PresupuestoDetalleBLL.GetListodo();
            Entidades.PresupuestoDetalles detalle = new Entidades.PresupuestoDetalles();
            presupuestoGrid.DataSource = Lista;
            presupuestoGrid.DataBind();

            buscaText.Focus();


        }

        public void Selecionar(int id)
        {

            if (DropFiltro.SelectedIndex == 0)
            {
                buscaText.Text = "";
                if (Lista.Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se ha registrado nada ');</script>");

                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {
                    Lista = BLL.PresupuestoDetalleBLL.GetListodo();
                    presupuestoGrid.DataSource = Lista;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Resultados ');</script>");


                }
            }
            else if (DropFiltro.SelectedIndex == 1)
            {

                Lista = BLL.PresupuestoDetalleBLL.GetList(p => p.PresupuestoId == id);

                if (Lista.Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No se ha registrado ');</script>");
                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {

                    presupuestoGrid.DataSource = Lista;
                    presupuestoGrid.DataBind();

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Rultados ');</script>");

                }



            }
       
            else if (DropFiltro.SelectedIndex == 3)
            {
                if (buscaText.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe ');</script>");


                    buscaText.Text = "";
                    buscaText.Focus();
                }
                else
                {
                    Lista = BLL.PresupuestoDetalleBLL.GetList(p => p.Descripcion == buscaText.Text);
                    if (Lista.Count == 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Error ');</script>");

                        buscaText.Text = "";
                        buscaText.Focus();
                    }
                    else
                    {
                        presupuestoGrid.DataSource = Lista;
                        presupuestoGrid.DataBind();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Rultados ');</script>");

                    }


                }

            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Selecionar(buscaText.Text)
        }
    }
}