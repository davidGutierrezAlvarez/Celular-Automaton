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
		public int X {get; private set; }
		public int Y {get; private set; }
		
		//estados
		public CellType BeforeStatus {get; private set; }
		public CellType Status {get; private set; }
		
		//celulas vecinas
		public  Cell Top		{get; set; }
		public  Cell TopLeft	{get; set; }
		public  Cell TopRight	{get; set; }
		public  Cell Left		{get; set; }
		public  Cell Right		{get; set; }
		public  Cell Bottom		{get; set; }
		public  Cell BottomLeft	{get; set; }
		public  Cell BottomRight{get; set; }
		
		public Cell(int x, int y, CellType type) {
			X = x;
			Y = y;
			Status = BeforeStatus = type;
		}
		
		public void upDate() {
			BeforeStatus = Status;
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
		
		public void NextStatus() {
			int count = 0;
			if(Top.BeforeStatus == CellType.life)			{ count++; }
			if(TopLeft.BeforeStatus == CellType.life)		{ count++; }
			if(TopRight.BeforeStatus == CellType.life)		{ count++; }
			if(Left.BeforeStatus == CellType.life)			{ count++; }
			if(Right.BeforeStatus == CellType.life)			{ count++; }
			if(Bottom.BeforeStatus == CellType.life)		{ count++; }
			if(BottomLeft.BeforeStatus == CellType.life)	{ count++; }
			if(BottomRight.BeforeStatus == CellType.life)	{ count++; }
			//System.Windows.Forms.MessageBox.Show(string.Format("x: {0}, y: {1}, vecinos : {2},  estado {3}", X, Y, count, BeforeStatus));
			//System.Windows.Forms.MessageBox.Show(string.Format("x: {0}, y: {1}, vecinos : {2},  estado: {3}, estado: {4}", X, Y, count, BeforeStatus, Status));
			if( ((count == 2 || count == 3) && BeforeStatus == CellType.life) || (count == 3 && BeforeStatus == CellType.death))
					{ Status = CellType.life; }
			else	{ Status = CellType.death; }
		}
		
	}
	
	public enum CellType {
		life,
		death//Color.White
	}
}
