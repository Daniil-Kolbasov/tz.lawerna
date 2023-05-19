namespace WeatherWinForms.Forms
{
	partial class OpenWeatherMapForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWeatherMapForm));
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			hasHttpsCheckBox1 = new CheckBox();
			countryCodeTextBox = new TextBox();
			label3 = new Label();
			stateCodeTextBox = new TextBox();
			label2 = new Label();
			cityNameTextBox = new TextBox();
			label1 = new Label();
			directButton = new Button();
			tabPage2 = new TabPage();
			latitudeMaskedTextBox = new MaskedTextBox();
			hasHttpsCheckBox2 = new CheckBox();
			label5 = new Label();
			label4 = new Label();
			reverseButton = new Button();
			groupBox1 = new GroupBox();
			weatherListBox = new ListBox();
			longitudeMaskedTextBox = new MaskedTextBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(219, 426);
			tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(hasHttpsCheckBox1);
			tabPage1.Controls.Add(countryCodeTextBox);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(stateCodeTextBox);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(cityNameTextBox);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(directButton);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(211, 398);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Direct geocoding";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// hasHttpsCheckBox1
			// 
			hasHttpsCheckBox1.AutoSize = true;
			hasHttpsCheckBox1.Location = new Point(6, 138);
			hasHttpsCheckBox1.Name = "hasHttpsCheckBox1";
			hasHttpsCheckBox1.Size = new Size(150, 19);
			hasHttpsCheckBox1.TabIndex = 7;
			hasHttpsCheckBox1.Text = "Use the HTTPS protocol";
			hasHttpsCheckBox1.UseVisualStyleBackColor = true;
			hasHttpsCheckBox1.CheckedChanged += hasHttpsCheckBox1_CheckedChanged;
			// 
			// countryCodeTextBox
			// 
			countryCodeTextBox.Location = new Point(6, 109);
			countryCodeTextBox.Name = "countryCodeTextBox";
			countryCodeTextBox.Size = new Size(199, 23);
			countryCodeTextBox.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 91);
			label3.Name = "label3";
			label3.Size = new Size(156, 15);
			label3.TabIndex = 5;
			label3.Text = "Country code (use ISO 3166)";
			// 
			// stateCodeTextBox
			// 
			stateCodeTextBox.Location = new Point(6, 65);
			stateCodeTextBox.Name = "stateCodeTextBox";
			stateCodeTextBox.Size = new Size(199, 23);
			stateCodeTextBox.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 47);
			label2.Name = "label2";
			label2.Size = new Size(151, 15);
			label2.TabIndex = 3;
			label2.Text = "State code (only for the US)";
			// 
			// cityNameTextBox
			// 
			cityNameTextBox.Location = new Point(6, 21);
			cityNameTextBox.Name = "cityNameTextBox";
			cityNameTextBox.Size = new Size(199, 23);
			cityNameTextBox.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 3);
			label1.Name = "label1";
			label1.Size = new Size(66, 15);
			label1.TabIndex = 1;
			label1.Text = "City name*";
			// 
			// directButton
			// 
			directButton.Location = new Point(6, 364);
			directButton.Name = "directButton";
			directButton.Size = new Size(199, 24);
			directButton.TabIndex = 0;
			directButton.Text = "Get current weather";
			directButton.UseVisualStyleBackColor = true;
			directButton.Click += directButton_Click;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(longitudeMaskedTextBox);
			tabPage2.Controls.Add(latitudeMaskedTextBox);
			tabPage2.Controls.Add(hasHttpsCheckBox2);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(reverseButton);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(211, 398);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Reverse geocoding";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// latitudeMaskedTextBox
			// 
			latitudeMaskedTextBox.Location = new Point(6, 21);
			latitudeMaskedTextBox.Mask = "###0.0000";
			latitudeMaskedTextBox.Name = "latitudeMaskedTextBox";
			latitudeMaskedTextBox.Size = new Size(199, 23);
			latitudeMaskedTextBox.TabIndex = 6;
			// 
			// hasHttpsCheckBox2
			// 
			hasHttpsCheckBox2.AutoSize = true;
			hasHttpsCheckBox2.Location = new Point(6, 94);
			hasHttpsCheckBox2.Name = "hasHttpsCheckBox2";
			hasHttpsCheckBox2.Size = new Size(150, 19);
			hasHttpsCheckBox2.TabIndex = 5;
			hasHttpsCheckBox2.Text = "Use the HTTPS protocol";
			hasHttpsCheckBox2.UseVisualStyleBackColor = true;
			hasHttpsCheckBox2.CheckedChanged += hasHttpsCheckBox2_CheckedChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 47);
			label5.Name = "label5";
			label5.Size = new Size(66, 15);
			label5.TabIndex = 3;
			label5.Text = "Longitude*";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 3);
			label4.Name = "label4";
			label4.Size = new Size(55, 15);
			label4.TabIndex = 1;
			label4.Text = "Latitude*";
			// 
			// reverseButton
			// 
			reverseButton.Location = new Point(6, 364);
			reverseButton.Name = "reverseButton";
			reverseButton.Size = new Size(199, 24);
			reverseButton.TabIndex = 0;
			reverseButton.Text = "Get current weather";
			reverseButton.UseVisualStyleBackColor = true;
			reverseButton.Click += reverseButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(weatherListBox);
			groupBox1.Location = new Point(237, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(269, 426);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Weather forecast";
			// 
			// weatherListBox
			// 
			weatherListBox.FormattingEnabled = true;
			weatherListBox.ItemHeight = 15;
			weatherListBox.Location = new Point(6, 18);
			weatherListBox.Name = "weatherListBox";
			weatherListBox.Size = new Size(257, 394);
			weatherListBox.TabIndex = 0;
			// 
			// longitudeMaskedTextBox
			// 
			longitudeMaskedTextBox.Location = new Point(6, 65);
			longitudeMaskedTextBox.Mask = "###0.0000";
			longitudeMaskedTextBox.Name = "longitudeMaskedTextBox";
			longitudeMaskedTextBox.Size = new Size(199, 23);
			longitudeMaskedTextBox.TabIndex = 7;
			// 
			// OpenWeatherMapForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(518, 449);
			Controls.Add(groupBox1);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "OpenWeatherMapForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Open Weather";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private CheckBox hasHttpsCheckBox1;
		private TextBox countryCodeTextBox;
		private Label label3;
		private TextBox stateCodeTextBox;
		private Label label2;
		private TextBox cityNameTextBox;
		private Label label1;
		private Button directButton;
		private CheckBox hasHttpsCheckBox2;
		private TextBox longitudeTextBox;
		private Label label5;
		private Label label4;
		private Button reverseButton;
		private GroupBox groupBox1;
		private ListBox weatherListBox;
		private MaskedTextBox latitudeMaskedTextBox;
		private MaskedTextBox longitudeMaskedTextBox;
	}
}