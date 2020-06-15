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

namespace CelularAutomaton {
	public partial class MainForm : Form {
		//validar numero entr 1 y 99 con regex
		String number = @"[0-9]{0,2}$";
		
		public MainForm() {
			InitializeComponent();
			//this.FormBorderStyle = FormBorderStyle.None;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//menubar.ResetRightToLeft();
			init();
			
		}
		
		void init() {
			saveFile.Title =	"Guardar Mapa Celular";
			saveFile.Filter =	"Mapa Celular (*.ca)|*.ca" + "|"+
								"Archivo de texto (*.txt)|*.txt" + "|" +
								"Todos los archivos (*.*)|*.*";
			resize();
			width.Text = "15";
			height.Text= "15";
			canvas = new Canvas(pictureBox.Width, pictureBox.Height, 15, 15);
			pictureBox.BackgroundImage = canvas.BackGroundVisible;
			pictureBox.Image = canvas.ForeGround;
			canvas.drawCells();
		}
		
		void ClickGenerate(object sender, EventArgs e) {
			canvas.clean();
			if(strVoid(width.Text) || strVoid(height.Text)) {
				return;
			}
			//aqui recorger ancho
			canvas.Row = Int32.Parse(width.Text);
			//aqui recoge el alto
			canvas.Column = Int32.Parse(height.Text);
			canvas.drawCells();
			pictureBox.Refresh();
		}
		
		void WidthTextChanged(object sender, EventArgs e) {
			isValid(width, number);
		}
		
		void HeightTextChanged(object sender, EventArgs e) {
			isValid(height, number);
		}
		
		
		void PictureBoxMouseMove(object sender, MouseEventArgs e) {
			canvas.hoverSquare(e);
			pictureBox.Refresh();
		}
		
		void PictureBoxMouseClick(object sender, MouseEventArgs e) {
			canvas.drawSquare(e);
			pictureBox.Refresh();
		}
		
		bool strVoid(String str) {
			if(str == "" || str == "0" || str == "00") {
				return true;
			}
			
			return false;
		}
		
		
	
		
		void OpcionesToolStripMenuItemClick(object sender, EventArgs e) {
			MessageBox.Show(canvas.save());
		}
		
		void GuardarToolStripMenuItemClick(object sender, EventArgs e) {
			if(saveFile.ShowDialog() == DialogResult.OK) {
				System.IO.File.WriteAllText(@saveFile.FileName, canvas.save());
			}
			
		}
		
		void AbrirToolStripMenuItemClick(object sender, EventArgs e) {
			
		}
	}
}
