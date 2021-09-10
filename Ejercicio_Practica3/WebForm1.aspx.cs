using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Practica2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Lista.Items.Add(new ListItem("Iphone 12", "1"));
                Lista.Items.Add(new ListItem("Airpods Pro", "2"));
                Lista.Items.Add(new ListItem("Lenovo Legion i5", "3"));
                Lista.Items.Add(new ListItem("Ipad Pro", "4"));
                Lista.Items.Add(new ListItem("Mouse G203", "5"));
                Lista.Items.Add(new ListItem("Teclado GPro", "6"));
                Lista.Items.Add(new ListItem("Audifonos G432", "7"));
                HyperLink1.Text = " ";

            }

        }
        protected void boton_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Lista.Items[Lista.SelectedIndex];
            if (elemento.Value == "1")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.apple.com/la/iphone-12/";
                Precio.InnerText = "Precio: S/.4500  Incluye igv";
                Grafico.Src = "iphone12.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "2")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.apple.com/la/airpods-pro/";
                Precio.InnerText = "Precio: S/.540  Incluye igv";
                Grafico.Src = "airpodsPro.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "3")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.lenovo.com/pe/es/desktops-y-all-in-one/legion-desktops/torres-de-la-serie-t/Lenovo-Legion-T5-28IMB05/p/90NK0047PT?cid=pe:sem|se|google|ssc+todos+los+productos|grupo+de+anuncios||es_PE90NK0047PT|8981267480|96393509931|pla-1513661637592|shopping|mixed|all&gclid=Cj0KCQjwm9yJBhDTARIsABKIcGYsgybB_-_Ct4Tv8P0MxswvuLnoXAE2ep0wZisVU0bWm4IffzSzbUsaAiOwEALw_wcB";
                Precio.InnerText = "Precio: S/.8499  Incluye igv";
                Grafico.Src = "LenovoLegion.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "4")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.apple.com/la/ipad-pro/";
                Precio.InnerText = "Precio: S/.4750  Incluye igv";
                Grafico.Src = "ipadPro.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "5")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.logitechg.com/es-roam/products/gaming-mice/g203-lightsync-rgb-gaming-mouse.910-005791.html";
                Precio.InnerText = "Precio: S/.105  Incluye igv";
                Grafico.Src = "g203.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "6")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.logitechg.com/es-es/products/gaming-keyboards/pro-gaming-keyboard.html/";
                Precio.InnerText = "Precio: S/.440  Incluye igv";
                Grafico.Src = "gpro.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "7")
            {
                HyperLink1.Text = "Mas Informacion Sobre el Producto";
                HyperLink1.NavigateUrl = "https://www.logitechg.com/es-es/products/gaming-audio/g432-7-1-surround-sound-gaming-headset.981-000770.html";
                Precio.InnerText = "Precio: S/.235  Incluye igv";
                Grafico.Src = "g432.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }


        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex =Int32.Parse(RadioButtonList1.SelectedValue);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (FileUpload1.HasFile)
            {   
                FileUpload1.SaveAs(@"F:\Trabajos(Semestre VI)\DesarrolloA Prac\Fase1\Ejercicio_Practica2\Upload Cliente\"
                + TextBox1.Text+".jpg");
            }
        }


    }
}
