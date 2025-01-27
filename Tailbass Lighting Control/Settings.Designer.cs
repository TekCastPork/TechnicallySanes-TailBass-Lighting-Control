﻿namespace Tailbass_Lighting_Control
{
	partial class Settings
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
			this.label5 = new System.Windows.Forms.Label();
			this.SettingsTabs = new System.Windows.Forms.TabControl();
			this.GlobalSettingsTab = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.CurrentShowFile = new System.Windows.Forms.TextBox();
			this.AutoLoadPrevShowFileCheckBox = new System.Windows.Forms.CheckBox();
			this.ThemesTab = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.SettingsTabs.SuspendLayout();
			this.GlobalSettingsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(8, 7);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 37);
			this.label5.TabIndex = 51;
			this.label5.Text = "Settings";
			// 
			// SettingsTabs
			// 
			this.SettingsTabs.Controls.Add(this.GlobalSettingsTab);
			this.SettingsTabs.Controls.Add(this.ThemesTab);
			this.SettingsTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SettingsTabs.Location = new System.Drawing.Point(0, 73);
			this.SettingsTabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SettingsTabs.Name = "SettingsTabs";
			this.SettingsTabs.SelectedIndex = 0;
			this.SettingsTabs.Size = new System.Drawing.Size(397, 365);
			this.SettingsTabs.TabIndex = 52;
			// 
			// GlobalSettingsTab
			// 
			this.GlobalSettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GlobalSettingsTab.Controls.Add(this.label1);
			this.GlobalSettingsTab.Controls.Add(this.CurrentShowFile);
			this.GlobalSettingsTab.Controls.Add(this.AutoLoadPrevShowFileCheckBox);
			this.GlobalSettingsTab.Location = new System.Drawing.Point(4, 34);
			this.GlobalSettingsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GlobalSettingsTab.Name = "GlobalSettingsTab";
			this.GlobalSettingsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GlobalSettingsTab.Size = new System.Drawing.Size(389, 327);
			this.GlobalSettingsTab.TabIndex = 0;
			this.GlobalSettingsTab.Text = "Global Settings";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current Show File:";
			// 
			// CurrentShowFile
			// 
			this.CurrentShowFile.BackColor = System.Drawing.Color.Black;
			this.CurrentShowFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CurrentShowFile.ForeColor = System.Drawing.Color.White;
			this.CurrentShowFile.Location = new System.Drawing.Point(4, 60);
			this.CurrentShowFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CurrentShowFile.Name = "CurrentShowFile";
			this.CurrentShowFile.ReadOnly = true;
			this.CurrentShowFile.Size = new System.Drawing.Size(373, 31);
			this.CurrentShowFile.TabIndex = 1;
			// 
			// AutoLoadPrevShowFileCheckBox
			// 
			this.AutoLoadPrevShowFileCheckBox.AutoSize = true;
			this.AutoLoadPrevShowFileCheckBox.Location = new System.Drawing.Point(7, 2);
			this.AutoLoadPrevShowFileCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AutoLoadPrevShowFileCheckBox.Name = "AutoLoadPrevShowFileCheckBox";
			this.AutoLoadPrevShowFileCheckBox.Size = new System.Drawing.Size(269, 29);
			this.AutoLoadPrevShowFileCheckBox.TabIndex = 0;
			this.AutoLoadPrevShowFileCheckBox.Text = "Auto Load Previous Show File";
			this.AutoLoadPrevShowFileCheckBox.UseVisualStyleBackColor = true;
			this.AutoLoadPrevShowFileCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// ThemesTab
			// 
			this.ThemesTab.Location = new System.Drawing.Point(4, 34);
			this.ThemesTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ThemesTab.Name = "ThemesTab";
			this.ThemesTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ThemesTab.Size = new System.Drawing.Size(706, 327);
			this.ThemesTab.TabIndex = 1;
			this.ThemesTab.Text = "Theme Settings";
			this.ThemesTab.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(248, 7);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 35);
			this.button1.TabIndex = 53;
			this.button1.Text = "Save Settings";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(397, 438);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SettingsTabs);
			this.Controls.Add(this.label5);
			this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Settings";
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.SettingsTabs.ResumeLayout(false);
			this.GlobalSettingsTab.ResumeLayout(false);
			this.GlobalSettingsTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label5;
		private TabControl SettingsTabs;
		private TabPage GlobalSettingsTab;
		private Label label1;
		private TextBox CurrentShowFile;
		private CheckBox AutoLoadPrevShowFileCheckBox;
		private TabPage ThemesTab;
		private Button button1;
	}
}