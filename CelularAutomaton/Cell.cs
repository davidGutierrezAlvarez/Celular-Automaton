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
		protected int X {get; set; }
		protected int Y {get; set; }
		
		
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
		public TypeGameOfLife BeforeStatus {get; private set; }
		public TypeGameOfLife Status {get; private set; }
		
		public GameOfLife(int x, int y, TypeGameOfLife type) : base(x, y) {
			Status = BeforeStatus = type;
		}
		
		
		public void upDate() {
			BeforeStatus = Status;

		}
		
		public void NextStatus() {
			int count = 0;
			if(((GameOfLife)Top).BeforeStatus == TypeGameOfLife.life)			{ count++; }
			if(((GameOfLife)TopLeft).BeforeStatus == TypeGameOfLife.life)		{ count++; }
			if(((GameOfLife)TopRight).BeforeStatus == TypeGameOfLife.life)		{ count++; }
			if(((GameOfLife)Left).BeforeStatus == TypeGameOfLife.life)			{ count++; }
			if(((GameOfLife)Right).BeforeStatus == TypeGameOfLife.life)			{ count++; }
			if(((GameOfLife)Bottom).BeforeStatus == TypeGameOfLife.life)		{ count++; }
			if(((GameOfLife)BottomLeft).BeforeStatus == TypeGameOfLife.life)	{ count++; }
			if(((GameOfLife)BottomRight).BeforeStatus == TypeGameOfLife.life)	{ count++; }
			
			//System.Windows.Forms.MessageBox.Show(string.Format("x: {0}, y: {1}, vecinos : {2},  estado: {3}, estado: {4}", X, Y, count, BeforeStatus, Status));
			if( ((count == 2 || count == 3) && BeforeStatus == TypeGameOfLife.life) || (count == 3 && BeforeStatus == TypeGameOfLife.death))
					{ Status = TypeGameOfLife.life; }
			else	{ Status = TypeGameOfLife.death; }
		}
	}
	
	public class WireWorld : Cell {
		
	}
	
	public enum TypeGameOfLife {
		death = 0,//Color.White
		life = 1
	}
	
	public enum TypeWireWorld {
		empty = 0,
		head = 1,
		tail = 2,
		conductor = 3
	}
}
