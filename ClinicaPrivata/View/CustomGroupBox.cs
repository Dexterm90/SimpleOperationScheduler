using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace ClinicaPrivata.Presenter
{
    public class CustomGroupBox : GroupBox
    {
        private Rectangle innerRectangle = new Rectangle();
        private GroupBoxState state = GroupBoxState.Normal;
        private FlowLayoutPanel panel = new FlowLayoutPanel();

        public CustomGroupBox()
            : base()
        {
            this.AutoSize = true;
            this.Location = new Point(10, 10);
            this.Controls.Add(panel);

            innerRectangle.X = ClientRectangle.X + 5;
            innerRectangle.Y = ClientRectangle.Y + 15;
            innerRectangle.Width = ClientRectangle.Width - 10;
            innerRectangle.Height = ClientRectangle.Height - 20;

            panel.BorderStyle = BorderStyle.None;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Location = new Point(innerRectangle.X + 5,
                innerRectangle.Y + 5);
            panel.Size = new Size(innerRectangle.Width - 10,
                innerRectangle.Height - 10);
        }

        // Draw the group box in the current state.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GroupBoxRenderer.DrawGroupBox(e.Graphics, ClientRectangle,
                this.Text, this.Font, state);

            // Draw an additional inner border if visual styles are enabled.
            if (Application.RenderWithVisualStyles)
            {
                GroupBoxRenderer.DrawGroupBox(e.Graphics, innerRectangle, state);
            }
        }

        // Pass added controls to the internal FlowLayoutPanel.
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            // Ensure that you do not add the panel itself.
            if (e.Control != this.panel)
            {
                this.Controls.Remove(e.Control);
                panel.Controls.Add(e.Control);
                panel.AutoSize = true;

                innerRectangle.X = ClientRectangle.X + 5;
                innerRectangle.Y = ClientRectangle.Y + 15;
                innerRectangle.Width = ClientRectangle.Width - 10;
                innerRectangle.Height = ClientRectangle.Height - 20;

                panel.BorderStyle = BorderStyle.None;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.Location = new Point(innerRectangle.X + 5,
                    innerRectangle.Y + 5);
                panel.Size = new Size(innerRectangle.Width - 10,
                    innerRectangle.Height - 10);
            }
        }
    }
}
