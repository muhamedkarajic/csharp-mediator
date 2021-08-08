using System;
using System.Drawing;
using System.Windows.Forms;

public class Marker : Label
{
    private MarkerMediator mediator;

    internal void SetMediator(MarkerMediator mediator)
    {
        this.mediator = mediator;
    }

    public Marker()
    {
        Text = "{Drag me}";
        TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        MouseDown += OnMouseDown;
        MouseMove += OnMouseMove;
    }

    private Point mouseDownLocation;

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
        {
            mouseDownLocation = e.Location;
        }
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
        {
            Text = this.Location.ToString();
            Left = e.X + Left - mouseDownLocation.X;
            Top = e.Y + Top - mouseDownLocation.Y;
            mediator.Send(Location, this);
        }
    }

    public void RecieveLocation(Point location)
    {
        var distance = CalcDistance(location);
        if (distance < 100 && BackColor != Color.Red)
            BackColor = Color.Red;
        else if (distance >= 100 && BackColor != Color.Green)
            BackColor = Color.Green;

        double CalcDistance(Point point) => Math.Sqrt(Math.Pow(point.X - Location.X, 2) + Math.Pow(point.Y - Location.Y, 2));
    }
}