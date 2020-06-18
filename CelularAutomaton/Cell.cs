/*
 * Created by SharpDevelop.
 * User: David Gutierrez
 * Date: 16/06/2020
 * Time: 04:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CelularAutomaton {
	public class Cell {
		//posicion
		public int X { get; protected set; }
		public int Y { get; protected set; }
		
		
		//celulas vecinas
		public  Cell Top		{get; set; }
		public  Cell TopLeft	{get; set; }
		public  Cell TopRight	{get; set; }
		public  Cell Left		{get; set; }
		public  Cell Right		{get; set; }
		public  Cell Bottom		{get; set; }
		public  Cell BottomLeft	{get; set; }
		public  Cell BottomRight{get; set; }
		
		public Cell() { }
		public Cell(int x, int y) {
			X = x;
			Y = y;
		}
		
		public void getNeighboring (Cell top, Cell topLeft, Cell topRight, Cell left, Cell right,
		                     Cell bottom, Cell bottomLeft, Cell bottomRight) {
			Top			= top;
			TopLeft		= topLeft;
			TopRight	= topRight;
			Left		= left;
			Right		= right;
			Bottom		= bottom;
			BottomLeft	= bottomLeft;
			BottomRight = bottomRight;
		}
		
		
		
	}
	
	public class GameOfLife : Cell {
		//estados
		public TypeBinary BeforeStatus {get; private set; }
		public TypeBinary Status {get; set; }
		
		public GameOfLife(int x, int y, TypeBinary type) : base(x, y) {
			Status = BeforeStatus = type;
		}
		
		public GameOfLife(int x, int y) : base(x, y) { }
		
		public void upDate() {
			BeforeStatus = Status;

		}
		
		public void NextStatus() {
			int count = 0;
			if(((GameOfLife)Top).BeforeStatus == TypeBinary.life)			{ count++; }
			if(((GameOfLife)TopLeft).BeforeStatus == TypeBinary.life)		{ count++; }
			if(((GameOfLife)TopRight).BeforeStatus == TypeBinary.life)		{ count++; }
			if(((GameOfLife)Left).BeforeStatus == TypeBinary.life)			{ count++; }
			if(((GameOfLife)Right).BeforeStatus == TypeBinary.life)			{ count++; }
			if(((GameOfLife)Bottom).BeforeStatus == TypeBinary.life)		{ count++; }
			if(((GameOfLife)BottomLeft).BeforeStatus == TypeBinary.life)	{ count++; }
			if(((GameOfLife)BottomRight).BeforeStatus == TypeBinary.life)	{ count++; }
			
			//System.Windows.Forms.MessageBox.Show(string.Format("x: {0}, y: {1}, vecinos : {2},  estado: {3}, estado: {4}", X, Y, count, BeforeStatus, Status));
			if( ((count >= 2 && count <=3) && BeforeStatus == TypeBinary.life) || (count == 3 && BeforeStatus == TypeBinary.death))
					{ Status = TypeBinary.life; }
			else	{ Status = TypeBinary.death; }
		}
		
	
	}
	
	public class WireWorld : Cell {
		public TypeWireWorld BeforeStatus {get; private set; }
		public TypeWireWorld Status {get; set; }
		
		public WireWorld(int x, int y, TypeWireWorld type) : base(x, y) {
			Status = BeforeStatus = type;
		}
		
		public WireWorld(int x, int y) : base(x, y) { }
		
		public void upDate() {
			BeforeStatus = Status;
		}
		
		public void NextStatus() {
			if(BeforeStatus == TypeWireWorld.empty) {
				return;
			} else if(BeforeStatus == TypeWireWorld.head) {
				Status = TypeWireWorld.tail;
			} else if(BeforeStatus == TypeWireWorld.tail) {
				Status = TypeWireWorld.conductor;
			} else if(BeforeStatus == TypeWireWorld.conductor) {
				//si una o dos celdas vecinas son cabeza de electron
				//se convierte en cabeza de electron
					
				int count = 0;
				if(((WireWorld)Top).BeforeStatus == TypeWireWorld.head)			{ count++; }
				if(((WireWorld)TopLeft).BeforeStatus == TypeWireWorld.head)		{ count++; }
				if(((WireWorld)TopRight).BeforeStatus == TypeWireWorld.head)	{ count++; }
				if(((WireWorld)Left).BeforeStatus == TypeWireWorld.head)		{ count++; }
				if(((WireWorld)Right).BeforeStatus == TypeWireWorld.head)		{ count++; }
				if(((WireWorld)Bottom).BeforeStatus == TypeWireWorld.head)		{ count++; }
				if(((WireWorld)BottomLeft).BeforeStatus == TypeWireWorld.head)	{ count++; }
				if(((WireWorld)BottomRight).BeforeStatus == TypeWireWorld.head)	{ count++; }
				
				if(count == 1 || count == 2) {
					Status = TypeWireWorld.head;
				}
			}
			
		
		}
		
	}
	
	public class Rule30 : Cell{
		//estados
		public TypeBinary BeforeStatus {get; private set; }
		public TypeBinary Status {get; set; }
		
		public Rule30(int x, int y, TypeBinary type) : base(x, y) {
			Status = BeforeStatus = type;
		}
		public Rule30(int x, int y) : base(x, y) { }
		
		public void upDate() {
			BeforeStatus = Status;
		}
		
		
		public void NextStatus() {
			if(Status == TypeBinary.life) { return; }
			int count = 0;
			if(((Rule30)TopLeft).BeforeStatus == TypeBinary.life &&
			  ((Rule30)Top).BeforeStatus == TypeBinary.death && 
			  ((Rule30)TopRight).BeforeStatus == TypeBinary.death) {
				//caso 4
				count = 1;
			} else if(((Rule30)TopLeft).BeforeStatus == TypeBinary.death &&
			  ((Rule30)Top).BeforeStatus == TypeBinary.life && 
			  ((Rule30)TopRight).BeforeStatus == TypeBinary.life) {
				//caso 5
				count = 1;
			}  else if(((Rule30)TopLeft).BeforeStatus == TypeBinary.death &&
			  ((Rule30)Top).BeforeStatus == TypeBinary.life && 
			  ((Rule30)TopRight).BeforeStatus == TypeBinary.death) {
				//caso 6
				count = 1;
			}  else if(((Rule30)TopLeft).BeforeStatus == TypeBinary.death &&
			  ((Rule30)Top).BeforeStatus == TypeBinary.death && 
			  ((Rule30)TopRight).BeforeStatus == TypeBinary.life) {
				//caso 7
				count = 1;
			}
			
			if(count == 1) {
				Status = TypeBinary.life;
			} else {
				Status = TypeBinary.death;
			}
		}
	
	}
	
	public enum TypeBinary {
		death = 0,//Color.black
		life = 1
	}
	
	public enum TypeWireWorld {
		empty = 0,
		head = 1,
		tail = 2,
		conductor = 3
	}
}
