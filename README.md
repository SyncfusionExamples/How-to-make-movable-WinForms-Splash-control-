# How-to-make-movable-WinForms-Splash-control-
This example demonstrates how to make the WinForms Splash control movable using Syncfusion’s Windows Forms UI components. The SplashControl is typically used to display a loading screen or branding message while the main application is initializing. By default, the splash screen is static and centered, but in some cases, you may want to allow users to reposition it for better accessibility or user experience.
This sample shows how to enable movement of the splash screen by handling mouse events such as MouseDown, and MouseMove. These events are used to track the mouse position and update the splash screen’s location accordingly. This approach mimics the drag behavior of a standard window, giving users more control over the UI.
The implementation includes:
    • Initializing the SplashControl with custom content.
    • Capturing mouse events to detect drag actions.
    • Updating the splash screen’s position dynamically during drag.
    • Ensuring smooth and responsive movement without flickering.
