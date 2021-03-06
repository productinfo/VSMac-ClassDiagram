
// This file has been generated by the GUI designer. Do not modify.
namespace Diagram
{
	public partial class DiagramPadWidget
	{
		private global::Gtk.VBox rootVbox;

		private global::Gtk.HPaned mainHPaned;

		private global::Gtk.VBox leftMenuVBox;

		private global::Gtk.Frame frame7;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.ComboBox projectDropdown;

		private global::Gtk.Label GtkLabel3;

		private global::Gtk.Frame frame4;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.VBox classGroupsVBox;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button newClassGroupButton;

		private global::Gtk.CheckButton drawGroupsCheckbox;

		private global::Gtk.Label GtkLabel4;

		private global::Gtk.HBox statusBarHBox;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Diagram.DiagramPadWidget
			global::Stetic.BinContainer.Attach(this);
			this.WidthRequest = 1000;
			this.HeightRequest = 500;
			this.Name = "Diagram.DiagramPadWidget";
			// Container child Diagram.DiagramPadWidget.Gtk.Container+ContainerChild
			this.rootVbox = new global::Gtk.VBox();
			this.rootVbox.Name = "rootVbox";
			// Container child rootVbox.Gtk.Box+BoxChild
			this.mainHPaned = new global::Gtk.HPaned();
			this.mainHPaned.CanFocus = true;
			this.mainHPaned.Name = "mainHPaned";
			this.mainHPaned.Position = 400;
			// Container child mainHPaned.Gtk.Paned+PanedChild
			this.leftMenuVBox = new global::Gtk.VBox();
			this.leftMenuVBox.WidthRequest = 200;
			this.leftMenuVBox.Name = "leftMenuVBox";
			// Container child leftMenuVBox.Gtk.Box+BoxChild
			this.frame7 = new global::Gtk.Frame();
			this.frame7.Name = "frame7";
			this.frame7.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame7.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.projectDropdown = global::Gtk.ComboBox.NewText();
			this.projectDropdown.Name = "projectDropdown";
			this.GtkAlignment2.Add(this.projectDropdown);
			this.frame7.Add(this.GtkAlignment2);
			this.GtkLabel3 = new global::Gtk.Label();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Projects</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame7.LabelWidget = this.GtkLabel3;
			this.leftMenuVBox.Add(this.frame7);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.leftMenuVBox[this.frame7]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child leftMenuVBox.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.classGroupsVBox = new global::Gtk.VBox();
			this.classGroupsVBox.Name = "classGroupsVBox";
			this.classGroupsVBox.Spacing = 6;
			// Container child classGroupsVBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.newClassGroupButton = new global::Gtk.Button();
			this.newClassGroupButton.Sensitive = false;
			this.newClassGroupButton.CanFocus = true;
			this.newClassGroupButton.Name = "newClassGroupButton";
			this.newClassGroupButton.Label = global::Mono.Unix.Catalog.GetString("New Group");
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.newClassGroupButton.Image = w4;
			this.hbox2.Add(this.newClassGroupButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.newClassGroupButton]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.drawGroupsCheckbox = new global::Gtk.CheckButton();
			this.drawGroupsCheckbox.Sensitive = false;
			this.drawGroupsCheckbox.CanFocus = true;
			this.drawGroupsCheckbox.Name = "drawGroupsCheckbox";
			this.drawGroupsCheckbox.Label = global::Mono.Unix.Catalog.GetString("Draw Groups");
			this.drawGroupsCheckbox.Active = true;
			this.drawGroupsCheckbox.DrawIndicator = true;
			this.drawGroupsCheckbox.UseUnderline = true;
			this.hbox2.Add(this.drawGroupsCheckbox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.drawGroupsCheckbox]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 1;
			w6.Expand = false;
			this.classGroupsVBox.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.classGroupsVBox[this.hbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.GtkAlignment.Add(this.classGroupsVBox);
			this.frame4.Add(this.GtkAlignment);
			this.GtkLabel4 = new global::Gtk.Label();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Class Groups</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel4;
			this.leftMenuVBox.Add(this.frame4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.leftMenuVBox[this.frame4]));
			w10.Position = 1;
			this.mainHPaned.Add(this.leftMenuVBox);
			global::Gtk.Paned.PanedChild w11 = ((global::Gtk.Paned.PanedChild)(this.mainHPaned[this.leftMenuVBox]));
			w11.Resize = false;
			w11.Shrink = false;
			this.rootVbox.Add(this.mainHPaned);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.rootVbox[this.mainHPaned]));
			w12.Position = 0;
			// Container child rootVbox.Gtk.Box+BoxChild
			this.statusBarHBox = new global::Gtk.HBox();
			this.statusBarHBox.HeightRequest = 20;
			this.statusBarHBox.Name = "statusBarHBox";
			this.statusBarHBox.Spacing = 6;
			this.rootVbox.Add(this.statusBarHBox);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.rootVbox[this.statusBarHBox]));
			w13.PackType = ((global::Gtk.PackType)(1));
			w13.Position = 1;
			w13.Expand = false;
			this.Add(this.rootVbox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.newClassGroupButton.Hide();
			this.Hide();
			this.newClassGroupButton.Clicked += new global::System.EventHandler(this.HandleNewGroupClicked);
			this.drawGroupsCheckbox.Toggled += new global::System.EventHandler(this.HandleGroupsCheckboxToggled);
		}
	}
}
