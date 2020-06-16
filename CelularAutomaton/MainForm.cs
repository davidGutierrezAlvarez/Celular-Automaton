/*
 * Created by SharpDevelop.
 * User: David Gutierrez
 * Date: 14/06/2020
 * Time: 10:38 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace CelularAutomaton {
	public partial class MainForm : Form {
		//validar numero entr 1 y 99 con regex
		String number = @"[0-9]{0,2}$";
		Pen penBlack = new Pen(Color.Black);//lapiz negro
		Pen penWhite = new Pen(Color.White);//lapiz negro
		
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
			saveFile.Filter=	"Mapa Celular (*.ca)|*.ca" + "|"+
								"Todos los archivos (*.*)|*.*";
			
			saveAsFile.Title =	"Guardar Mapa Celular";
			saveAsFile.Filter=	"Mapa Celular (*.ca)|*.ca" + "|"+
								"Todos los archivos (*.*)|*.*";
			
			openFile.Title	= "Cargar Mapa Celular";
			openFile.Filter	= "Mapa Celular (*.ca)|*.ca";
			resize();
			textBoxRow.Text = "15";
			textBoxColumn.Text= "15";
			canvas = new Canvas(pictureBox.Width, pictureBox.Height, 15, 15);
			pictureBox.BackgroundImage = canvas.BackGroundVisible;
			pictureBox.Image = canvas.ForeGround;
			canvas.drawMatriz(MenuItemRendija.Checked ? penBlack : penWhite);
		}
		
		void ClickGenerate(object sender, EventArgs e) {
			canvas.clean();
			if(strVoid(textBoxRow.Text) || strVoid(textBoxColumn.Text)) {
				return;
			}
			//aqui recorger ancho
			canvas.Row = Int32.Parse(textBoxRow.Text);
			//aqui recoge el alto
			canvas.Column = Int32.Parse(textBoxColumn.Text);
			canvas.resetMatriz();
			canvas.drawMatriz(MenuItemRendija.Checked ? penBlack : penWhite);
			pictureBox.Refresh();
		}
		
		void WidthTextChanged(object sender, EventArgs e) {
			isValid(textBoxRow, number);
		}
		
		void HeightTextChanged(object sender, EventArgs e) {
			isValid(textBoxColumn, number);
		}
		
		
		void PictureBoxMouseMove(object sender, MouseEventArgs e) {
			canvas.cleanHover();
			if(MenuItemHover.Checked) {
				canvas.hoverCell(e);
			}
			
			if(e.Button == MouseButtons.Left) {
				canvas.drawCell(e);
			}
			pictureBox.Refresh();
		}
		
		void PictureBoxMouseClick(object sender, MouseEventArgs e) {
			canvas.drawCell(e);
			pictureBox.Refresh();
		}
		

		
		void MenuItemSave(object sender, EventArgs e) {
			String save = save64(canvas.save(textBox.Text));
			
			if(openFile.FileName != "") {
				System.IO.File.WriteAllText(@openFile.FileName, save);
				return;
			}
			if(saveFile.FileName != "") {
				System.IO.File.WriteAllText(@saveFile.FileName, save);
				return;
			}
			if(saveFile.ShowDialog() == DialogResult.OK) {
				System.IO.File.WriteAllText(@saveFile.FileName, save);
			}
			
		}
		
		void MenuItemSaveAs(object sender, EventArgs e) {
			saveAsFile.FileName = "";
			if(saveAsFile.ShowDialog() == DialogResult.OK) {
				String save = save64(canvas.save(textBox.Text));
				
				System.IO.File.WriteAllText(@saveAsFile.FileName, save);
				saveFile.FileName = saveAsFile.FileName;
			}
		}
		
		void MenuItemOpen(object sender, EventArgs e) {
			//cargar archivo, y dibujar celdas respectivas
			openFile.FileName = "";
			if(openFile.ShowDialog() == DialogResult.OK) {
				String fileText = open64(File.ReadAllText(openFile.FileName));
				if(fileText == "Error") { return; }
				
				saveFile.FileName = openFile.FileName;
				canvas.clean();
				//cargar y generar matriz
				textBox.Text = canvas.setDescripcion(fileText);
				canvas.drawMatriz(MenuItemRendija.Checked ? penBlack : penWhite);
				
				canvas.fillCells();
				textBoxRow.Text		= canvas.Row.ToString();
				textBoxColumn.Text	= canvas.Column.ToString();
				pictureBox.Refresh();
			}
		}
		
		
		void MenuItemNew(object sender, EventArgs e) {
			saveFile.FileName = "";
			openFile.FileName = "";
			canvas.clean();
			canvas.drawMatriz(MenuItemRendija.Checked ? penBlack : penWhite);
		}
		
		
		void MenuItemRendijaClick(object sender, EventArgs e) {
				canvas.drawMatriz(MenuItemRendija.Checked ? penBlack : penWhite);
		}
	}
}
