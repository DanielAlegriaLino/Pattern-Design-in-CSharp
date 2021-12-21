// See https://aka.ms/new-console-template for more information

UIFactory factory_ui = new MacOsUIFactory();

var label_1 = factory_ui.CreateLabel("Hola");
var label_2 = factory_ui.CreateLabel("Text numero 2");

label_2.Display();


factory_ui = new WindowsUIFactory();
var label1 = factory_ui.CreateLabel("Text Windows 1");
var button1 = factory_ui.CreateButton();

label_1.Display();
button1.Display();
button1.onClick();


