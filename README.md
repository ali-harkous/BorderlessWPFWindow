# BorderlessWPFWindow (With Custom Title Bar)
 A borderless WPF window with basic title bar. Can be used as a startup for modern designed apps.
 
 # Characteristics
 - Custom transparent title bar
 - Aero snap
 - Maximize and minimize default windows animation behaviour
 - Window border
 - Easy integration in apps
 
 # Preview
 
 ![Preview](Pictures/preview1.jpg)
 
 # Usage
 To use this custom title bar, you have to include [TitleBar](TitleBar.xaml) component, and add it to your main window xaml in the following way:
 ```
 <local:TitleBar x:Name="titleBar2" Margin="0,0,0,0" VerticalAlignment="Top"/>
 ```
 Then add WindowChrome to your window to remove default title bar and border:
 ```
 <WindowChrome.WindowChrome>
        <WindowChrome GlassFrameThickness="0" CornerRadius="0" CaptionHeight="0" ResizeBorderThickness="2"/>
    </WindowChrome.WindowChrome>
 ```
 Remember to keep title bar at the top (always at the end of your XAML).
 Now, in code, you have to register Window_StateChanged event:
 ```
 private void Window_StateChanged(object sender, EventArgs e)
 {
     titleBar2.WindowStateChanged(WindowState);
     
     if (this.WindowState == WindowState.Maximized)
     {
         //to remove 
         this.BorderThickness = new Thickness(7);
         return;
     }

     this.BorderThickness = new Thickness(0);
 }
 ```
 And that's it.
 # Customization
 You can customize color and animation (on MouseOver) of the title bar buttons by altering its style.
 You can also check the methods exposed by [TitleBar](TitleBar.xaml.cs) class to see what else can be customized and what fields can be altered. This will change with time as I update the project.
 
 # More to Come
 As of writing this, there still some features that normally exists in a default bordered window and doesn't exist in this customization, these includes:
 - Right click context menu
 - Drag & Move when window is maximized
 - Maybe some other?
