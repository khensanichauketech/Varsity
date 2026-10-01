using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamSess
{
    public class GradientPanel : Panel
    {
        //Create a properties to defie the colors for the gradient's top and bottom
        public Color gradientTop {  get; set; }

        public Color gradientBottom { get; set; }

        // Create  constructor for the Gradient Panel Class
        public GradientPanel() {
            //Subscribe to the resize event to handle when the control's size changes
            this.Resize += GradientPanel_Resize;
        }

        private void GradientPanel_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); //this marks the control as needing to be redrawn
        }
        //override the onPaint method to draw a gradient background
        protected override void OnPaint(PaintEventArgs e)
        {
            //Create a lineargradientbrush with the specified top and bottom gradient colors
            
            LinearGradientBrush linear = new LinearGradientBrush(
                this.ClientRectangle, //this area to fill with the gradient
                this.gradientTop, // the starting color (top of the gradient)
                this.gradientBottom, // the ending color( bottom of the gradient)
                90F // lastly the angle of the gradient (90 degrees = vertical)
                
                );

            //get the grapics context for the drawing
            Graphics g = e.Graphics;

            //Fill the entire control area with the gradient
            g.FillRectangle(linear, this.ClientRectangle);


            // lastly call the base class onpaint to ensure any additional paint is done
            base.OnPaint(e);
        }
    }
}
