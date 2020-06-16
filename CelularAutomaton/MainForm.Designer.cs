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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemHover = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemRendija = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.btnColorBlack = new System.Windows.Forms.Label();
			this.btnColorWhite = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Label();
			this.textBoxColumn = new System.Windows.Forms.TextBox();
			this.textBoxRow = new System.Windows.Forms.TextBox();
			this.saveAsFile = new System.Windows.Forms.SaveFileDialog();
			this.panelSize.SuspendLayout();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSize
			// 
			this.panelSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
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
			this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuFile,
									this.ayudaToolStripMenuItem,
									this.opcionesToolStripMenuItem});
			this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(852, 45);
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
			this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
			this.abrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
			this.abrirToolStripMenuItem.Text = "Abrir...";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.MenuItemOpen);
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemNew);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.guardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSave);
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.guardarComoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
			this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSaveAs);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(195, 1);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(68, 41);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuItemHover,
									this.MenuItemRendija});
			this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
			this.opcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(91, 41);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// MenuItemHover
			// 
			this.MenuItemHover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.MenuItemHover.CheckOnClick = true;
			this.MenuItemHover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemHover.Name = "MenuItemHover";
			this.MenuItemHover.Size = new System.Drawing.Size(152, 26);
			this.MenuItemHover.Text = "Hover";
			// 
			// MenuItemRendija
			// 
			this.MenuItemRendija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.MenuItemRendija.CheckOnClick = true;
			this.MenuItemRendija.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MenuItemRendija.Name = "MenuItemRendija";
			this.MenuItemRendija.Size = new System.Drawing.Size(152, 26);
			this.MenuItemRendija.Text = "Rendija";
			this.MenuItemRendija.Click += new System.EventHandler(this.MenuItemRendijaClick);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.White;
			this.pictureBox.Location = new System.Drawing.Point(1, 46);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(400, 400);
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseClick);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseMove);
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.textBox);
			this.panel.Controls.Add(this.btnColorBlack);
			this.panel.Controls.Add(this.btnColorWhite);
			this.panel.Controls.Add(this.label2);
			this.panel.Controls.Add(this.btnGenerate);
			this.panel.Controls.Add(this.textBoxColumn);
			this.panel.Controls.Add(this.textBoxRow);
			this.panel.Location = new System.Drawing.Point(407, 46);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(315, 400);
			this.panel.TabIndex = 10;
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
			// btnColorBlack
			// 
			this.btnColorBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(242)))));
			this.btnColorBlack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnColorBlack.Location = new System.Drawing.Point(29, 266);
			this.btnColorBlack.Name = "btnColorBlack";
			this.btnColorBlack.Size = new System.Drawing.Size(30, 30);
			this.btnColorBlack.TabIndex = 14;
			// 
			// btnColorWhite
			// 
			this.btnColorWhite.BackColor = System.Drawing.Color.White;
			this.btnColorWhite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnColorWhite.Location = new System.Drawing.Point(29, 236);
			this.btnColorWhite.Name = "btnColorWhite";
			this.btnColorWhite.Size = new System.Drawing.Size(30, 30);
			this.btnColorWhite.TabIndex = 14;
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
			this.btnGenerate.Click += new System.EventHandler(this.ClickGenerate);
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
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(852, 539);
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
			this.ResumeLayout(false);
		}
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
		private System.Windows.Forms.Timer timer1;
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
		
		void MenuMouseUp(object sender, MouseEventArgs e) {
			mov = 0;
		}
		
		void LblClosedClick(object sender, EventArgs e) {
			this.Close();
		}
		
		void LblMinimizedClick(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Minimized; 
		}
		
		Point ajustarZoom(Point e) {
			int X, Y;
			int w_i = pictureBox.Image.Width; 
            int h_i = pictureBox.Image.Height;
            int w_c = pictureBox.Width;
            int h_c = pictureBox.Height;
             float imageRatio = w_i / (float)h_i;
            float containerRatio = w_c / (float)h_c; 

            if (imageRatio >= containerRatio) {
                float scaleFactor = w_c / (float)w_i;
                float scaledHeight = h_i * scaleFactor;
                float filler = Math.Abs(h_c - scaledHeight) / 2;  
                X = (int)(e.X / scaleFactor);
                Y = (int)((e.Y - filler) / scaleFactor);
            } else {
                float scaleFactor = h_c / (float)h_i;
                float scaledWidth = w_i * scaleFactor;
                float filler = Math.Abs(w_c - scaledWidth) / 2;
             	X = (int)((e.X - filler) / scaleFactor);
               	Y = (int)(e.Y / scaleFactor);
            }
            return new Point(X,Y);
		}
		
		Point ajustarZoom(int x, int y) {
			return ajustarZoom(new Point(x,y));
		}
		
		Point ajustarZoom(MouseEventArgs e) {
			int X, Y;
			int w_i = pictureBox.Image.Width; 
            int h_i = pictureBox.Image.Height;
            int w_c = pictureBox.Width;
            int h_c = pictureBox.Height;
             float imageRatio = w_i / (float)h_i;
            float containerRatio = w_c / (float)h_c; 

            if (imageRatio >= containerRatio) {
                float scaleFactor = w_c / (float)w_i;
                float scaledHeight = h_i * scaleFactor;
                float filler = Math.Abs(h_c - scaledHeight) / 2;  
                X = (int)(e.X / scaleFactor);
                Y = (int)((e.Y - filler) / scaleFactor);
            } else {
                float scaleFactor = h_c / (float)h_i;
                float scaledWidth = w_i * scaleFactor;
                float filler = Math.Abs(w_c - scaledWidth) / 2;
             	X = (int)((e.X - filler) / scaleFactor);
               	Y = (int)(e.Y / scaleFactor);
            }
            return new Point(X,Y);
		}		
		
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
		}
		
	}
}
