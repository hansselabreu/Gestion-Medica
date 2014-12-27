using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace UNITHEPID_Beta
{
    public partial class frmIlustracionPies : Form
    {
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object

        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton is down or not
 
        Bitmap mainimage = Properties.Resources.planta_derecho;


        public frmIlustracionPies()
        {
            InitializeComponent();
        }

        private void frmIlustracionPies_Load(object sender, EventArgs e)
        {
            pbPlantaDerecho.Image = Properties.Resources.planta_derecho;
            pbPieDerecho.Image = Properties.Resources.pie_derecho;
            pbPlantaIzquierdo.Image = Properties.Resources.planta_izquierdo;
            pbPieIzquierdo.Image = Properties.Resources.pie_izquierdo;

            string rutaCarpeta = AppDomain.CurrentDomain.BaseDirectory + @"\Imagenes";
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }


            
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            var manejador = sender as PictureBox;
            if (isMouseDown == true)//check to see if the mouse button is down
            {

                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above
                {

                    if (manejador.Image == null)//if no available bitmap exists on the picturebox to draw on
                    {
                        //create a new bitmap
                        Bitmap bmp = new Bitmap(manejador.Width, manejador.Height);

                        manejador.Image = bmp; //assign the picturebox.Image property to the bitmap created

                    }

                    using (Graphics g = Graphics.FromImage(manejador.Image))
                    {//we need to create a Graphics object to draw on the picture box, its our main tool

                        //when making a Pen object, you can just give it color only or give it color and pen size

                        g.DrawLine(new Pen(Color.Black, 2), lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        //this is to give the drawing a more smoother, less sharper look

                    }

                    manejador.Invalidate();//refreshes the picturebox

                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position
                }

            }
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;//we assign the lastPoint to the current mouse position: e.Location ('e' is from the MouseEventArgs passed into the MouseDown event)

            isMouseDown = true;//we set to true because our mouse button is down (clicked)

        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            lastPoint = Point.Empty;

            //set the previous point back to null if the user lets go of the mouse button
 
        }

        void ResetearImagen(PictureBox cuadro, Image imagen)
        {

            if (cuadro.Image != null)
            {

                cuadro.Image = null;
                cuadro.Invalidate();
            }
            cuadro.Image = imagen;
            cuadro.Invalidate();
        }


        private void btnBorrarPlantaDer(object sender, EventArgs e)
        {
            ResetearImagen(pbPlantaDerecho, Properties.Resources.planta_derecho);
        }

        private void btnBorrarPieDer_Click(object sender, EventArgs e)
        {
            ResetearImagen(pbPieDerecho, Properties.Resources.pie_derecho);
        }

        private void btnBorrarPlantaIzq_Click(object sender, EventArgs e)
        {
            ResetearImagen(pbPlantaIzquierdo, Properties.Resources.planta_izquierdo);
        }

        private void btnBorrarPieIzq_Click(object sender, EventArgs e)
        {
            ResetearImagen(pbPieIzquierdo, Properties.Resources.pie_izquierdo);
        }

    }
}
