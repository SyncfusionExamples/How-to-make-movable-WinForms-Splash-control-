# How to Make Movable WinForms Splash Control
This example demonstrates how to make the WinForms SplashControl movable using Syncfusion Windows Forms UI components. The SplashControl is typically used to display a loading screen or branding message while the main application initializes. By default, the splash screen is static and centered, but in some cases, you may want to allow users to reposition it for better accessibility or user experience.

## Overview
This sample shows how to enable movement of the splash screen by handling mouse events such as MouseDown and MouseMove. These events track the mouse position and update the splash screen’s location dynamically, mimicking the drag behavior of a standard window.

## Implementation
- Initialize the SplashControl with custom content.
- Capture mouse events to detect drag actions.
- Update the splash screen’s position dynamically during drag.
- Ensure smooth and responsive movement without flickering.

## Code Example
### Designer Initialization
```C#
#region Windows Form Designer generated code
private void InitializeComponent()
{
    this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
    this.SuspendLayout();
    // 
    // splashControl1
    // 
    this.splashControl1.HostForm = this;
    this.splashControl1.ShowInTaskbar = true;
    this.splashControl1.Text = "";
    this.splashControl1.TimerInterval = 60000;
    this.splashControl1.TransparentColor = System.Drawing.Color.Empty;
    // 
    // Form1
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(764, 380);
    this.Name = "Form1";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Form1";
    this.ResumeLayout(false);
}
```

### Enable Drag Behavior
```C#
public partial class Form1 : Form
{
    Point cursorPoint = new Point();

    public Form1()
    {
        InitializeComponent();
        this.splashControl1.SplashControlPanel.MouseDown += SplashControlPanel_MouseDown;
        this.splashControl1.SplashControlPanel.MouseMove += SplashControlPanel_MouseMove;
    }

    private void SplashControlPanel_MouseDown(object sender, MouseEventArgs e)
    {
        cursorPoint = e.Location;
    }

    private void SplashControlPanel_MouseMove(object sender, MouseEventArgs e)
    {
        if (Control.MouseButtons == MouseButtons.Left)
        {
            if (this.splashControl1.SplashControlPanel.Parent is Form)
            {
                var parentForm = this.splashControl1.SplashControlPanel.Parent as Form;
                parentForm.Left = Cursor.Position.X - cursorPoint.X;
                parentForm.Top = Cursor.Position.Y - cursorPoint.Y;
            }
        }
    }
}
```

## How It Works
- MouseDown stores the initial cursor position when the user clicks on the splash panel.
- MouseMove calculates the new position based on the cursor movement and updates the splash screen’s Left and Top properties.
- This creates a smooth drag effect similar to moving a normal window.
