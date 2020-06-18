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
using System.Collections.Generic;
using System.Windows.Forms;

namespace CelularAutomaton {
	public partial class MainForm : Form {
		//validar numero entr 1 y 99 con regex
		String number = @"[0-9]{0,2}$";
		
		Brush brushAlpha;
		Brush brushBeta;
		int brushValue;
		List<Cell> cells;
		public MainForm() {
			InitializeComponent();
			init();
			
		}
		
		void init() {
			brushAlpha = Colors.brushWhite;
			brushBeta = Colors.brushWhite;
			brushValue = 1;
			saveFile.Title =	"Guardar Mapa Celular";
			saveFile.Filter=	"Mapa Celular (*.ca)|*.ca" + "|"+
								"Todos los archivos (*.*)|*.*";
			
			saveAsFile.Title =	"Guardar Mapa Celular";
			saveAsFile.Filter=	"Mapa Celular (*.ca)|*.ca" + "|"+
								"Todos los archivos (*.*)|*.*";
			
			openFile.Title	= "Cargar Mapa Celular";
			openFile.Filter	= "Mapa Celular (*.ca)|*.ca";
			resize();
			textBoxRow.Text = "10";
			textBoxColumn.Text= "10";
			canvas = new Canvas(pictureBox.Width, pictureBox.Height, 10, 10);
			pictureBox.BackgroundImage = canvas.BackGroundVisible;
			pictureBox.Image = canvas.ForeGround;
			canvas.Clean();
			canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
			cells = new List<Cell>();
			//agregar una celula por cada celda...
			fillCells();
			anchorNeighbors();
		}
		
		void ClickGenerate(object sender, EventArgs e) {
			if(strVoid(textBoxRow.Text) || strVoid(textBoxColumn.Text)) {
				return;
			}
			if(canvas.Row == Int32.Parse(textBoxRow.Text) && canvas.Column == Int32.Parse(textBoxColumn.Text)) {
				//si los valores son iguales no modificar
				return;
			}
			//aqui recorger ancho
			canvas.Row = Int32.Parse(textBoxRow.Text);
			//aqui recoge el alto
			canvas.Column = Int32.Parse(textBoxColumn.Text);
			canvas.Clean();
			canvas.resetMatriz();
			canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
			//limpiar lista de celulas
			cells.Clear();
			//agregar una celula por cada celda...
			fillCells();
			anchorNeighbors();
			pictureBox.Refresh();
		}
		
		void WidthTextChanged(object sender, EventArgs e) { isValid(textBoxRow, number); }
		void HeightTextChanged(object sender, EventArgs e) { isValid(textBoxColumn, number); }
		
		void PictureBoxMouseMove(object sender, MouseEventArgs e) {
			if(e.X < 0 || e.X > pictureBox.Width || e.Y < 0 || e.Y > pictureBox.Height) {
				return;
			}
			canvas.cleanHover();
			if(MenuItemHover.Checked) {
				canvas.hoverCell(e, Colors.brushBlueLight);
			}
			if(e.Button == MouseButtons.Left) {
				canvas.drawCell(e, brushAlpha, brushValue);
				//canbiar estado de la celula
				getCell(e);
			}
			pictureBox.Refresh();
		}
		
		void PictureBoxMouseClick(object sender, MouseEventArgs e) {
			if(e.X < 0 || e.X > pictureBox.Width || e.Y < 0 || e.Y > pictureBox.Height) {
				return;
			}
			canvas.drawCell(e, brushAlpha, brushValue);
			getCell(e);
			pictureBox.Refresh();
		}
		
		void getCell(MouseEventArgs e) {
			int x = e.X / canvas.Width,
				y = e.Y / canvas.Height;
				if(x > canvas.Row || y > canvas.Height) {
					return;
				}
			if(MenuItemGameOfLife.Checked) {
				((GameOfLife)cells[x + y*canvas.Row]).Status = (TypeBinary)brushValue;
				((GameOfLife)cells[x + y*canvas.Row]).upDate();
			} else if(MenuItemWireWorld.Checked) {
				((WireWorld)cells[x + y*canvas.Row]).Status = (TypeWireWorld)brushValue;
				((WireWorld)cells[x + y*canvas.Row]).upDate();
			} else if(MenuItemRule30.Checked) {
				((Rule30)cells[x + y*canvas.Row]).Status = (TypeBinary)brushValue;
				((Rule30)cells[x + y*canvas.Row]).upDate();
			}
		}
		
		void MenuItemSave(object sender, EventArgs e) {
			getMatriz();
			String save = save64(canvas.save(textBox.Text, cells[0].GetType()));
			
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
			getMatriz();
			saveAsFile.FileName = "";
			if(saveAsFile.ShowDialog() == DialogResult.OK) {
				String save = save64(canvas.save(textBox.Text, cells[0].GetType()));
				//String save = canvas.save(textBox.Text, cells[0].GetType());
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
				//String fileText = File.ReadAllText(openFile.FileName);
				saveFile.FileName = openFile.FileName;
				canvas.Clean();
				//cargar y generar matriz
				textBox.Text = canvas.setDescripcion(fileText);
				canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
				
				
				if(canvas.type == "CelularAutomaton.GameOfLife") {
					MenuItemGameOfLifeClick(sender, e);
				} else if(canvas.type == "CelularAutomaton.WireWorld") {
					MenuItemWireWorldClick(sender, e);
				} else if(canvas.type == "CelularAutomaton.Rule30") {
					MenuItemRule30Click(sender, e);
				}
				
				canvas.fillCells();
				textBoxRow.Text		= canvas.Row.ToString();
				textBoxColumn.Text	= canvas.Column.ToString();
				pictureBox.Refresh();
				cells.Clear();
				fillCells();
				//recoger datos de la matriz y guardarlo en la lista de celulas
				anchorNeighbors();
				setMatriz();
			}
		}
		
		
		void MenuItemNew(object sender, EventArgs e) {
			saveFile.FileName = "";
			openFile.FileName = "";
			canvas.Clean();
			canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
			cells.Clear();
			fillCells();
			anchorNeighbors();
			textBox.Text = "";
		}
		
		void MenuItemRendijaClick(object sender, EventArgs e) {
				canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
		}
		
		void fillCells() {
			for(int y =0; y < canvas.Column; y++) {	
				for(int x =0; x < canvas.Row; x++) {
					if(MenuItemGameOfLife.Checked) {
						cells.Add(new GameOfLife(x, y));	
					} else if(MenuItemRule30.Checked) {
						cells.Add(new Rule30(x, y));	
					} else if(MenuItemWireWorld.Checked) {
						cells.Add(new WireWorld(x, y));
					}
				}
			}
		}
		
		void getMatriz() {
			for(int y =0; y < canvas.Column; y++) {	
				for(int x =0; x < canvas.Row; x++) {
					if(MenuItemGameOfLife.Checked) {
						canvas.matriz[y,x] = (int)(((GameOfLife)cells[x+y*canvas.Row]).Status);
					} else if(MenuItemWireWorld.Checked) {
						canvas.matriz[y,x] = (int)(((WireWorld)cells[x+y*canvas.Row]).Status);
					} else if(MenuItemRule30.Checked) {
						canvas.matriz[y,x] = (int)(((Rule30)cells[x+y*canvas.Row]).Status);
					}				
				}
			}
		}
		
		void setMatriz() {
			for(int y =0; y < canvas.Column; y++) {	
				for(int x =0; x < canvas.Row; x++) {
					if(MenuItemGameOfLife.Checked) {
						((GameOfLife)cells[x+y*canvas.Row]).Status = (TypeBinary)canvas.matriz[y,x];
					} else if(MenuItemWireWorld.Checked) {
						((WireWorld)cells[x+y*canvas.Row]).Status = (TypeWireWorld)canvas.matriz[y,x];
					} else if(MenuItemRule30.Checked) {
						((Rule30)cells[x+y*canvas.Row]).Status = (TypeBinary)canvas.matriz[y,x];
					}			
				}
			}
		}
		
		void anchorNeighbors() {
			int actual;
			int XLeft, XRight, YTop, YBottom;
			for(int y =0; y < canvas.Column; y++) {	
				for(int x =0; x < canvas.Row; x++) {
					actual = x+y*canvas.Column;
					
					XLeft	= x > 0 ? x-1 : canvas.Row-1;
					XRight	= x < canvas.Row-1 ? x+1 : 0;
					YTop	= y > 0 ? y-1: canvas.Column-1;
					YBottom	= y < canvas.Column-1 ? y+1 : 0;
					
					YTop	*= canvas.Row;
					YBottom *= canvas.Row;
					
					cells[actual].Top		= cells[x		+ YTop];
					cells[actual].TopLeft	= cells[XLeft	+ YTop];
					cells[actual].TopRight	= cells[XRight	+ YTop];
					cells[actual].Left		= cells[XLeft	+ y*canvas.Row];
					cells[actual].Right		= cells[XRight	+ y*canvas.Row];
					cells[actual].Bottom	= cells[x		+ YBottom];
					cells[actual].BottomLeft= cells[XLeft	+ YBottom];
					cells[actual].BottomRight=cells[XRight	+ YBottom];
				}
			}
		}
		
		void AnimarToolStripMenuItemClick(object sender, EventArgs e) {
			if(MenuItemAnimate.Checked) {
				timer.Enabled = true;
			} else {
				timer.Enabled = false;
			}
		}
		
		void TimerTick(object sender, EventArgs e) {
			if(MenuItemGameOfLife.Checked) {
				runGameofLife();
			}else if(MenuItemRule30.Checked) {
				runRule30();
			} else if(MenuItemWireWorld.Checked) {
				runWireWorld();
			}
			pictureBox.Refresh();
		}
		
		void runGameofLife() {
			cells.ForEach(cell => ((GameOfLife)cell).upDate());
			cells.ForEach(cell => ((GameOfLife)cell).NextStatus());
			
			foreach(Cell cell in cells) {
				if(((GameOfLife)cell).BeforeStatus != ((GameOfLife)cell).Status) {
					brushBeta = ((GameOfLife)cell).Status == TypeBinary.life ?  Colors.brushWhite: Colors.brushBlack;
			    	canvas.drawCell(cell.X, cell.Y, brushBeta);
			    }
			}
		}
		
		void runWireWorld() {
			cells.ForEach(cell => ((WireWorld)cell).NextStatus());
			
			foreach(Cell cell in cells) {
				if(((WireWorld)cell).BeforeStatus != ((WireWorld)cell).Status) {
					if(((WireWorld)cell).Status == TypeWireWorld.conductor) {
						brushBeta = Colors.brushGold;
					} else if(((WireWorld)cell).Status == TypeWireWorld.head) {
						brushBeta = Colors.brushBlue;
					} else if(((WireWorld)cell).Status == TypeWireWorld.tail) {
						brushBeta = Colors.brushRed;
					}
		    		canvas.drawCell(cell.X, cell.Y, brushBeta);
				}
			}
			cells.ForEach(cell => ((WireWorld)cell).upDate());
		}
		
		void runRule30() {
			cells.ForEach(cell => ((Rule30)cell).NextStatus());
			
			foreach(Cell cell in cells) {
				if(((Rule30)cell).BeforeStatus != ((Rule30)cell).Status) {
					brushBeta = ((Rule30)cell).Status == TypeBinary.life ?  Colors.brushWhite: Colors.brushBlack;
			    	canvas.drawCell(cell.X, cell.Y, brushBeta);
				
			    }
			}
			cells.ForEach(cell => ((Rule30)cell).upDate());
		}
		
		void MenuItemGameOfLifeClick(object sender, EventArgs e) {
			MenuItemGameOfLife.Checked = true;
			if(MenuItemAnimate.Checked) {
				//si ya se esta animando no se puede cambiar
				return;
			}
			//activar grupo actual
			groupBoxGameOfLife.Visible = true;
			//desactivar los demas grupos
			groupBoxWireWorld.Visible = false;
			groupBoxRule30.Visible = false;
			//descativar los demas menus
			MenuItemWireWorld.Checked = false;
			MenuItemRule30.Checked = false;
			canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
			canvas.Clean();
			cells.Clear();
			fillCells();
			
			brushAlpha = Colors.brushWhite;
			brushValue = 1;
			radioButtonGameOfLife_1.Checked = true;
		}
		
		void MenuItemWireWorldClick(object sender, EventArgs e) {
			MenuItemWireWorld.Checked = true;
			if(MenuItemAnimate.Checked) {
				//si ya se esta animando no se puede cambiar
				return;
			}
			//activar grupo actual
			groupBoxWireWorld.Visible = true;
			//desactivar los demas grupos
			groupBoxGameOfLife.Visible = false;
			groupBoxRule30.Visible = false;
			//descativar los demas menus
			MenuItemGameOfLife.Checked = false;
			MenuItemRule30.Checked = false;
			canvas.Clean();
			canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
			cells.Clear();
			fillCells();
			
			
			brushAlpha = Colors.brushGold;
			brushValue = 3;
			radioButtonWireWorld_3.Checked = true;
			
		}
		
		void MenuItemRule30Click(object sender, EventArgs e) {
			MenuItemRule30.Checked = true;
			if(MenuItemAnimate.Checked) {
				//si ya se esta animando no se puede cambiar
				return;
			}
			//activar grupo actual
			groupBoxRule30.Visible = true;
			//desactivar los demas grupos
			groupBoxGameOfLife.Visible = false;
			groupBoxWireWorld.Visible = false;
			//descativar los demas menus
			MenuItemGameOfLife.Checked = false;
			MenuItemWireWorld.Checked = false;
			canvas.Clean();
			canvas.drawMatriz(MenuItemRendija.Checked ? Colors.penBlack : Colors.penWhite);
			cells.Clear();
			fillCells();
			
			
			brushAlpha = Colors.brushWhite;
			brushValue = 1;
			radioButtonRule30_1.Checked = true;
		}

		
		void RadioButtonGameOfLife_0CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushBlack; brushValue = 0; }
		void RadioButtonGameOfLife_1CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushWhite; brushValue = 1; }
		void RadioButtonWireWorld_0CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushBlack; brushValue = 0; }
		void RadioButtonWireWorld_1CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushBlue; brushValue = 1; }
		void RadioButtonWireWorld_2CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushRed; brushValue = 2; }
		void RadioButtonWireWorld_3CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushGold; brushValue = 3; }
		void RadioButtonRule30_0CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushBlack; brushValue = 0; }
		void RadioButtonRule30_1CheckedChanged(object sender, EventArgs e) { brushAlpha = Colors.brushWhite; brushValue = 1; }

		
	}
}
