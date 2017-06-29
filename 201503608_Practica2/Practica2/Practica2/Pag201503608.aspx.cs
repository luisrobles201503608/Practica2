using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica2
{
    public partial class Pag201503608 : System.Web.UI.Page
    {
        MiReferencia.APIClient re = new MiReferencia.APIClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            re.crearEstudiante(int.Parse(TextBox2.Text.Trim()),int.Parse(TextBox3.Text.Trim()),TextBox4.Text,TextBox5.Text);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            re.crearEvento(int.Parse(TextBox6.Text.Trim()),TextBox7.Text,TextBox8.Text,TextBox9.Text);
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            re.AsistirEvento(int.Parse(TextBox10.Text.Trim()), int.Parse(TextBox11.Text.Trim()), int.Parse(TextBox12.Text.Trim()));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            re.getEstudiantes(int.Parse(TextBox13.Text.Trim()));
            re.getTiposDeEvento(int.Parse(TextBox13.Text.Trim()));
            re.MostrarEventos(int.Parse(TextBox13.Text.Trim()));
        }
    }
}