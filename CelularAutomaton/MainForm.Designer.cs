/*
 * Created by SharpDevelop.
 * User: David Gutierrez
 * Date: 14/06/2020
 * Time: 10:38 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
 
namespace CelularAutomaton {
	partial class MainForm {
		
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.panelSize = new System.Windows.Forms.Panel();
			this.lblMinimized = new System.Windows.Forms.Label();
			this.lblClosed = new System.Windows.Forms.Label();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemHover = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemRendija = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemAnimate = new System.Windows.Forms.ToolStripMenuItem();
			this.automatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemGameOfLife = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemWireWorld = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemRule30 = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panel = new System.Windows.Forms.Panel();
			this.groupBoxRule30 = new System.Windows.Forms.GroupBox();
			this.radioButtonRule30_1 = new System.Windows.Forms.RadioButton();
			this.radioButtonRule30_0 = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.groupBoxWireWorld = new System.Windows.Forms.GroupBox();
			this.radioButtonWireWorld_0 = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.radioButtonWireWorld_2 = new System.Windows.Forms.RadioButton();
			this.radioButtonWireWorld_1 = new System.Windows.Forms.RadioButton();
			this.radioButtonWireWorld_3 = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBoxGameOfLife = new System.Windows.Forms.GroupBox();
			this.radioButtonGameOfLife_1 = new System.Windows.Forms.RadioButton();
			this.radioButtonGameOfLife_0 = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnColorWhite = new System.Windows.Forms.Label();
			this.btnColorBlack = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Label();
			this.textBoxColumn = new System.Windows.Forms.TextBox();
			this.textBoxRow = new System.Windows.Forms.TextBox();
			this.saveAsFile = new System.Windows.Forms.SaveFileDialog();
			this.panelSize.SuspendLayout();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panel.SuspendLayout();
			this.groupBoxRule30.SuspendLayout();
			this.groupBoxWireWorld.SuspendLayout();
			this.groupBoxGameOfLife.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 150;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// panelSize
			// 
			this.panelSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.panelSize.Controls.Add(this.lblMinimized);
			this.panelSize.Controls.Add(this.lblClosed);
			this.panelSize.Location = new System.Drawing.Point(781, 2);
			this.panelSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelSize.Name = "panelSize";
			this.panelSize.Size = new System.Drawing.Size(71, 34);
			this.panelSize.TabIndex = 5;
			// 
			// lblMinimized
			// 
			this.lblMinimized.BackColor = System.Drawing.Color.Transparent;
			this.lblMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
			this.lblMinimized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMinimized.Location = new System.Drawing.Point(0, -5);
			this.lblMinimized.Name = "lblMinimized";
			this.lblMinimized.Size = new System.Drawing.Size(29, 46);
			this.lblMinimized.TabIndex = 1;
			this.lblMinimized.Text = "__";
			this.lblMinimized.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblMinimized.Click += new System.EventHandler(this.LblMinimizedClick);
			// 
			// lblClosed
			// 
			this.lblClosed.BackColor = System.Drawing.Color.Transparent;
			this.lblClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
			this.lblClosed.ForeColor = System.Drawing.Color.Red;
			this.lblClosed.Location = new System.Drawing.Point(34, 0);
			this.lblClosed.Name = "lblClosed";
			this.lblClosed.Size = new System.Drawing.Size(25, 34);
			this.lblClosed.TabIndex = 3;
			this.lblClosed.Text = "x";
			this.lblClosed.Click += new System.EventHandler(this.LblClosedClick);
			// 
			// menu
			// 
			this.menu.AutoSize = false;
			this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuFile,
									this.opcionesToolStripMenuItem,
									this.automatasToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(1389, 45);
			this.menu.TabIndex = 1;
			this.menu.Text = "menu";
			this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuMouseDown);
			this.menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuMouseMove);
			this.menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuMouseUp);
			// 
			// MenuFile
			// 
			this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.abrirToolStripMenuItem,
									this.nuevoToolStripMenuItem,
									this.guardarToolStripMenuItem,
									this.guardarComoToolStripMenuItem,
									this.exportarComoToolStripMenuItem1,
									this.toolStripSeparator1,
									this.salirToolStripMenuItem});
			this.MenuFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.MenuFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuFile.Name = "MenuFile";
			this.MenuFile.Size = new System.Drawing.Size(78, 41);
			this.MenuFile.Text = "Archivo";
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
			this.abrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
			this.abrirToolStripMenuItem.Text = "Abrir...";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.MenuItemOpen);
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemNew);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.guardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSave);
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.guardarComoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
			this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSaveAs);
			// 
			// exportarComoToolStripMenuItem1
			// 
			this.exportarComoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.exportarComoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exportarComoToolStripMenuItem1.Name = "exportarComoToolStripMenuItem1";
			this.exportarComoToolStripMenuItem1.Size = new System.Drawing.Size(200, 28);
			this.exportarComoToolStripMenuItem1.Text = "Exportar como...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(197, 1);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuItemHover,
									this.MenuItemRendija,
									this.MenuItemAnimate});
			this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.opcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(91, 41);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// MenuItemHover
			// 
			this.MenuItemHover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.MenuItemHover.CheckOnClick = true;
			this.MenuItemHover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemHover.Name = "MenuItemHover";
			this.MenuItemHover.Size = new System.Drawing.Size(134, 26);
			this.MenuItemHover.Text = "Hover";
			// 
			// MenuItemRendija
			// 
			this.MenuItemRendija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.MenuItemRendija.Checked = true;
			this.MenuItemRendija.CheckOnClick = true;
			this.MenuItemRendija.CheckState = System.Windows.Forms.CheckState.Checked;
			this.MenuItemRendija.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemRendija.Name = "MenuItemRendija";
			this.MenuItemRendija.Size = new System.Drawing.Size(134, 26);
			this.MenuItemRendija.Text = "Rendija";
			this.MenuItemRendija.Click += new System.EventHandler(this.MenuItemRendijaClick);
			// 
			// MenuItemAnimate
			// 
			this.MenuItemAnimate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.MenuItemAnimate.CheckOnClick = true;
			this.MenuItemAnimate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemAnimate.Name = "MenuItemAnimate";
			this.MenuItemAnimate.Size = new System.Drawing.Size(134, 26);
			this.MenuItemAnimate.Text = "Animar";
			this.MenuItemAnimate.Click += new System.EventHandler(this.MenuItemAnimarClick);
			// 
			// automatasToolStripMenuItem
			// 
			this.automatasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuItemGameOfLife,
									this.MenuItemWireWorld,
									this.MenuItemRule30});
			this.automatasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.automatasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.automatasToolStripMenuItem.Name = "automatasToolStripMenuItem";
			this.automatasToolStripMenuItem.Size = new System.Drawing.Size(101, 41);
			this.automatasToolStripMenuItem.Text = "Automatas";
			// 
			// MenuItemGameOfLife
			// 
			this.MenuItemGameOfLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.MenuItemGameOfLife.Checked = true;
			this.MenuItemGameOfLife.CheckOnClick = true;
			this.MenuItemGameOfLife.CheckState = System.Windows.Forms.CheckState.Checked;
			this.MenuItemGameOfLife.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.MenuItemGameOfLife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemGameOfLife.Name = "MenuItemGameOfLife";
			this.MenuItemGameOfLife.Size = new System.Drawing.Size(223, 26);
			this.MenuItemGameOfLife.Text = "Juego De La Vida";
			this.MenuItemGameOfLife.Click += new System.EventHandler(this.MenuItemGameOfLifeClick);
			// 
			// MenuItemWireWorld
			// 
			this.MenuItemWireWorld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.MenuItemWireWorld.CheckOnClick = true;
			this.MenuItemWireWorld.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.MenuItemWireWorld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemWireWorld.Name = "MenuItemWireWorld";
			this.MenuItemWireWorld.Size = new System.Drawing.Size(223, 26);
			this.MenuItemWireWorld.Text = "Mundo De Alambre";
			this.MenuItemWireWorld.Click += new System.EventHandler(this.MenuItemWireWorldClick);
			// 
			// MenuItemRule30
			// 
			this.MenuItemRule30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
			this.MenuItemRule30.CheckOnClick = true;
			this.MenuItemRule30.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.MenuItemRule30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemRule30.Name = "MenuItemRule30";
			this.MenuItemRule30.Size = new System.Drawing.Size(223, 26);
			this.MenuItemRule30.Text = "Wolfram - Regla 30";
			this.MenuItemRule30.Click += new System.EventHandler(this.MenuItemRule30Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(68, 41);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.White;
			this.pictureBox.Location = new System.Drawing.Point(1, 46);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(400, 481);
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseClick);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseMove);
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.panel.Controls.Add(this.groupBoxRule30);
			this.panel.Controls.Add(this.groupBoxWireWorld);
			this.panel.Controls.Add(this.groupBoxGameOfLife);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.textBox);
			this.panel.Controls.Add(this.label2);
			this.panel.Controls.Add(this.btnGenerate);
			this.panel.Controls.Add(this.textBoxColumn);
			this.panel.Controls.Add(this.textBoxRow);
			this.panel.Location = new System.Drawing.Point(407, 46);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(970, 492);
			this.panel.TabIndex = 10;
			// 
			// groupBoxRule30
			// 
			this.groupBoxRule30.Controls.Add(this.radioButtonRule30_1);
			this.groupBoxRule30.Controls.Add(this.radioButtonRule30_0);
			this.groupBoxRule30.Controls.Add(this.label8);
			this.groupBoxRule30.Controls.Add(this.label9);
			this.groupBoxRule30.Controls.Add(this.label16);
			this.groupBoxRule30.Controls.Add(this.label17);
			this.groupBoxRule30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxRule30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBoxRule30.Location = new System.Drawing.Point(332, 255);
			this.groupBoxRule30.Name = "groupBoxRule30";
			this.groupBoxRule30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBoxRule30.Size = new System.Drawing.Size(284, 246);
			this.groupBoxRule30.TabIndex = 20;
			this.groupBoxRule30.TabStop = false;
			this.groupBoxRule30.Text = "Rule30";
			this.groupBoxRule30.Visible = false;
			// 
			// radioButtonRule30_1
			// 
			this.radioButtonRule30_1.Checked = true;
			this.radioButtonRule30_1.Location = new System.Drawing.Point(10, 81);
			this.radioButtonRule30_1.Name = "radioButtonRule30_1";
			this.radioButtonRule30_1.Size = new System.Drawing.Size(18, 24);
			this.radioButtonRule30_1.TabIndex = 24;
			this.radioButtonRule30_1.TabStop = true;
			this.radioButtonRule30_1.UseVisualStyleBackColor = true;
			this.radioButtonRule30_1.CheckedChanged += new System.EventHandler(this.RadioButtonRule30_1CheckedChanged);
			// 
			// radioButtonRule30_0
			// 
			this.radioButtonRule30_0.Location = new System.Drawing.Point(10, 33);
			this.radioButtonRule30_0.Name = "radioButtonRule30_0";
			this.radioButtonRule30_0.Size = new System.Drawing.Size(18, 24);
			this.radioButtonRule30_0.TabIndex = 23;
			this.radioButtonRule30_0.UseVisualStyleBackColor = true;
			this.radioButtonRule30_0.CheckedChanged += new System.EventHandler(this.RadioButtonRule30_0CheckedChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(70, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "Viva";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(70, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Muerta";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label16.Location = new System.Drawing.Point(33, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(30, 30);
			this.label16.TabIndex = 19;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Black;
			this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label17.Location = new System.Drawing.Point(33, 30);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(30, 30);
			this.label17.TabIndex = 20;
			// 
			// groupBoxWireWorld
			// 
			this.groupBoxWireWorld.Controls.Add(this.radioButtonWireWorld_0);
			this.groupBoxWireWorld.Controls.Add(this.label14);
			this.groupBoxWireWorld.Controls.Add(this.label15);
			this.groupBoxWireWorld.Controls.Add(this.label13);
			this.groupBoxWireWorld.Controls.Add(this.label12);
			this.groupBoxWireWorld.Controls.Add(this.label11);
			this.groupBoxWireWorld.Controls.Add(this.radioButtonWireWorld_2);
			this.groupBoxWireWorld.Controls.Add(this.radioButtonWireWorld_1);
			this.groupBoxWireWorld.Controls.Add(this.radioButtonWireWorld_3);
			this.groupBoxWireWorld.Controls.Add(this.label10);
			this.groupBoxWireWorld.Controls.Add(this.label4);
			this.groupBoxWireWorld.Controls.Add(this.label5);
			this.groupBoxWireWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxWireWorld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBoxWireWorld.Location = new System.Drawing.Point(332, 3);
			this.groupBoxWireWorld.Name = "groupBoxWireWorld";
			this.groupBoxWireWorld.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBoxWireWorld.Size = new System.Drawing.Size(284, 246);
			this.groupBoxWireWorld.TabIndex = 19;
			this.groupBoxWireWorld.TabStop = false;
			this.groupBoxWireWorld.Text = "ELECTRICIDAD";
			this.groupBoxWireWorld.Visible = false;
			// 
			// radioButtonWireWorld_0
			// 
			this.radioButtonWireWorld_0.Location = new System.Drawing.Point(10, 33);
			this.radioButtonWireWorld_0.Name = "radioButtonWireWorld_0";
			this.radioButtonWireWorld_0.Size = new System.Drawing.Size(18, 24);
			this.radioButtonWireWorld_0.TabIndex = 26;
			this.radioButtonWireWorld_0.UseVisualStyleBackColor = true;
			this.radioButtonWireWorld_0.CheckedChanged += new System.EventHandler(this.RadioButtonWireWorld_0CheckedChanged);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(70, 35);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 25;
			this.label14.Text = "Vacio";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Black;
			this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label15.Location = new System.Drawing.Point(33, 32);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(30, 30);
			this.label15.TabIndex = 24;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(70, 83);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 23;
			this.label13.Text = "Cabeza";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(70, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "Cola";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(70, 183);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(111, 23);
			this.label11.TabIndex = 21;
			this.label11.Text = "Conductor";
			// 
			// radioButtonWireWorld_2
			// 
			this.radioButtonWireWorld_2.Location = new System.Drawing.Point(10, 131);
			this.radioButtonWireWorld_2.Name = "radioButtonWireWorld_2";
			this.radioButtonWireWorld_2.Size = new System.Drawing.Size(18, 24);
			this.radioButtonWireWorld_2.TabIndex = 20;
			this.radioButtonWireWorld_2.UseVisualStyleBackColor = true;
			this.radioButtonWireWorld_2.CheckedChanged += new System.EventHandler(this.RadioButtonWireWorld_2CheckedChanged);
			// 
			// radioButtonWireWorld_1
			// 
			this.radioButtonWireWorld_1.Location = new System.Drawing.Point(10, 81);
			this.radioButtonWireWorld_1.Name = "radioButtonWireWorld_1";
			this.radioButtonWireWorld_1.Size = new System.Drawing.Size(18, 24);
			this.radioButtonWireWorld_1.TabIndex = 19;
			this.radioButtonWireWorld_1.UseVisualStyleBackColor = true;
			this.radioButtonWireWorld_1.CheckedChanged += new System.EventHandler(this.RadioButtonWireWorld_1CheckedChanged);
			// 
			// radioButtonWireWorld_3
			// 
			this.radioButtonWireWorld_3.Checked = true;
			this.radioButtonWireWorld_3.Location = new System.Drawing.Point(10, 181);
			this.radioButtonWireWorld_3.Name = "radioButtonWireWorld_3";
			this.radioButtonWireWorld_3.Size = new System.Drawing.Size(18, 24);
			this.radioButtonWireWorld_3.TabIndex = 18;
			this.radioButtonWireWorld_3.TabStop = true;
			this.radioButtonWireWorld_3.UseVisualStyleBackColor = true;
			this.radioButtonWireWorld_3.CheckedChanged += new System.EventHandler(this.RadioButtonWireWorld_3CheckedChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label10.Location = new System.Drawing.Point(33, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 30);
			this.label10.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Gold;
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.Location = new System.Drawing.Point(33, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 30);
			this.label4.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label5.Location = new System.Drawing.Point(33, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 30);
			this.label5.TabIndex = 14;
			// 
			// groupBoxGameOfLife
			// 
			this.groupBoxGameOfLife.Controls.Add(this.radioButtonGameOfLife_1);
			this.groupBoxGameOfLife.Controls.Add(this.radioButtonGameOfLife_0);
			this.groupBoxGameOfLife.Controls.Add(this.label7);
			this.groupBoxGameOfLife.Controls.Add(this.label6);
			this.groupBoxGameOfLife.Controls.Add(this.btnColorWhite);
			this.groupBoxGameOfLife.Controls.Add(this.btnColorBlack);
			this.groupBoxGameOfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxGameOfLife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBoxGameOfLife.Location = new System.Drawing.Point(10, 235);
			this.groupBoxGameOfLife.Name = "groupBoxGameOfLife";
			this.groupBoxGameOfLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBoxGameOfLife.Size = new System.Drawing.Size(284, 246);
			this.groupBoxGameOfLife.TabIndex = 18;
			this.groupBoxGameOfLife.TabStop = false;
			this.groupBoxGameOfLife.Text = "JUEGO DE LA VIDA";
			// 
			// radioButtonGameOfLife_1
			// 
			this.radioButtonGameOfLife_1.Checked = true;
			this.radioButtonGameOfLife_1.Location = new System.Drawing.Point(10, 81);
			this.radioButtonGameOfLife_1.Name = "radioButtonGameOfLife_1";
			this.radioButtonGameOfLife_1.Size = new System.Drawing.Size(18, 24);
			this.radioButtonGameOfLife_1.TabIndex = 18;
			this.radioButtonGameOfLife_1.TabStop = true;
			this.radioButtonGameOfLife_1.UseVisualStyleBackColor = true;
			this.radioButtonGameOfLife_1.CheckedChanged += new System.EventHandler(this.RadioButtonGameOfLife_1CheckedChanged);
			// 
			// radioButtonGameOfLife_0
			// 
			this.radioButtonGameOfLife_0.Location = new System.Drawing.Point(10, 33);
			this.radioButtonGameOfLife_0.Name = "radioButtonGameOfLife_0";
			this.radioButtonGameOfLife_0.Size = new System.Drawing.Size(18, 24);
			this.radioButtonGameOfLife_0.TabIndex = 17;
			this.radioButtonGameOfLife_0.UseVisualStyleBackColor = true;
			this.radioButtonGameOfLife_0.CheckedChanged += new System.EventHandler(this.RadioButtonGameOfLife_0CheckedChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(70, 83);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Viva";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(70, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Muerta";
			// 
			// btnColorWhite
			// 
			this.btnColorWhite.BackColor = System.Drawing.Color.White;
			this.btnColorWhite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnColorWhite.Location = new System.Drawing.Point(33, 80);
			this.btnColorWhite.Name = "btnColorWhite";
			this.btnColorWhite.Size = new System.Drawing.Size(30, 30);
			this.btnColorWhite.TabIndex = 14;
			// 
			// btnColorBlack
			// 
			this.btnColorBlack.BackColor = System.Drawing.Color.Black;
			this.btnColorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnColorBlack.Location = new System.Drawing.Point(33, 30);
			this.btnColorBlack.Name = "btnColorBlack";
			this.btnColorBlack.Size = new System.Drawing.Size(30, 30);
			this.btnColorBlack.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(0, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(312, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "TAMAÑO DE LA MATRIZ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(0, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "DESCRIPCION";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox
			// 
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.Location = new System.Drawing.Point(10, 43);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(290, 96);
			this.textBox.TabIndex = 15;
			this.textBox.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(83, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "X";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGenerate.Location = new System.Drawing.Point(171, 195);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(123, 23);
			this.btnGenerate.TabIndex = 12;
			this.btnGenerate.Text = "GENERAR";
			this.btnGenerate.Click += new System.EventHandler(this.MenuItemGenerateClick);
			// 
			// textBoxColumn
			// 
			this.textBoxColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxColumn.Location = new System.Drawing.Point(119, 192);
			this.textBoxColumn.Name = "textBoxColumn";
			this.textBoxColumn.Size = new System.Drawing.Size(40, 28);
			this.textBoxColumn.TabIndex = 11;
			this.textBoxColumn.TextChanged += new System.EventHandler(this.HeightTextChanged);
			// 
			// textBoxRow
			// 
			this.textBoxRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.textBoxRow.Location = new System.Drawing.Point(34, 192);
			this.textBoxRow.Name = "textBoxRow";
			this.textBoxRow.Size = new System.Drawing.Size(40, 28);
			this.textBoxRow.TabIndex = 10;
			this.textBoxRow.TextChanged += new System.EventHandler(this.WidthTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(1389, 539);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.panelSize);
			this.Controls.Add(this.menu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menu;
			this.Name = "MainForm";
			this.Text = "CelularAutomaton";
			this.panelSize.ResumeLayout(false);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.groupBoxRule30.ResumeLayout(false);
			this.groupBoxWireWorld.ResumeLayout(false);
			this.groupBoxGameOfLife.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem exportarComoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemRule30;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.RadioButton radioButtonRule30_0;
		private System.Windows.Forms.RadioButton radioButtonRule30_1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RadioButton radioButtonWireWorld_0;
		private System.Windows.Forms.RadioButton radioButtonWireWorld_3;
		private System.Windows.Forms.RadioButton radioButtonWireWorld_1;
		private System.Windows.Forms.RadioButton radioButtonWireWorld_2;
		private System.Windows.Forms.RadioButton radioButtonGameOfLife_1;
		private System.Windows.Forms.RadioButton radioButtonGameOfLife_0;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBoxRule30;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBoxWireWorld;
		private System.Windows.Forms.ToolStripMenuItem MenuItemWireWorld;
		private System.Windows.Forms.ToolStripMenuItem MenuItemGameOfLife;
		private System.Windows.Forms.ToolStripMenuItem automatasToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxGameOfLife;
		private System.Windows.Forms.ToolStripMenuItem MenuItemAnimate;
		private System.Windows.Forms.ToolStripMenuItem MenuItemRendija;
		private System.Windows.Forms.ToolStripMenuItem MenuItemHover;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox textBox;
		private System.Windows.Forms.SaveFileDialog saveAsFile;
		private System.Windows.Forms.Label btnColorBlack;
		private System.Windows.Forms.Label btnColorWhite;
		private System.Windows.Forms.Label btnGenerate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxRow;
		private System.Windows.Forms.TextBox textBoxColumn;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.Label lblClosed;
		private System.Windows.Forms.Label lblMinimized;
		private System.Windows.Forms.Panel panelSize;
		private System.Windows.Forms.ToolStripMenuItem MenuFile;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.Timer timer;
		////////////////////////////////////////////////////////////
		int mov, movX, movY;
		Canvas canvas;
		
		
		void MenuMouseDown(object sender, MouseEventArgs e) {
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}
		void MenuMouseMove(object sender, MouseEventArgs e) {
			if(mov == 1)
				this.SetDesktopLocation(MousePosition.X-movX, MousePosition.Y-movY);
		}
		void MenuMouseUp(object sender, MouseEventArgs e) { mov = 0; }
		void LblClosedClick(object sender, EventArgs e) { this.Close(); }
		void LblMinimizedClick(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized;  }
		
		void isValid(TextBox textBox, String str) {
			if(!(Regex.IsMatch(textBox.Text, str) && Regex.Replace(textBox.Text, str, String.Empty).Length == 0)) {
	            textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
	            textBox.SelectionStart = textBox.Text.Length;
	            textBox.SelectionLength = 0;
			}
		}
		
		
		private static bool IsBase64(string base64String) {
		     if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
		        || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
		        return false;
		
		     try {
		         Convert.FromBase64String(base64String);
		         return true;
		     } catch(Exception exception) {
		     // Handle the exception
		     }
		     return false;
		}
		
		private static bool strVoid(String str) {
			if(str == "" || str == "0" || str == "00") {
				return true;
			}
			return false;
		}
		
		
			
		private static string save64(String dataSave) {
			byte[] bytes = System.Text.Encoding.UTF8.GetBytes(dataSave);
			var encodign = Convert.ToBase64String(bytes);
			
			return encodign;
		}
		
		private static string open64(String data64) {
			//validar que sea en base 64
			if(!IsBase64(data64)) {
				MessageBox.Show("Archivo no compatible o roto", "Error al abrir el archivo");
				return "Error";
			}
			byte[] bytes = Convert.FromBase64String(data64);
			String decoding = System.Text.Encoding.UTF8.GetString(bytes);
			
			return decoding;
		}
		
		
				
		void resize() {
			pictureBox.Height = 400;
			pictureBox.Width  =400;
			panel.Left = 402;
			panel.Top = pictureBox.Top;
			panel.Width = 235;
			this.Width = 638;
			groupBoxWireWorld.Top = groupBoxGameOfLife.Top;
			groupBoxWireWorld.Left= groupBoxGameOfLife.Left;
			groupBoxRule30.Top = groupBoxGameOfLife.Top;
			groupBoxRule30.Left= groupBoxGameOfLife.Left;
		}
		
	}
}
