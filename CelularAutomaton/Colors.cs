/*
 * Created by SharpDevelop.
 * User: David Gutierrez
 * Date: 17/06/2020
 * Time: 05:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace CelularAutomaton {

	public class Color {
		static public Pen penBlack = new Pen(Color.Black);//lapiz negro
		static public Pen penWhite = new Pen(Color.White);//lapiz blanco
		
		static public Brush brushBlack = new SolidBrush(Color.Black);//lapiz negro
		static public Brush brushWhite = new SolidBrush(Color.White);//lapiz blanco
		static public Brush brushRed	 = new SolidBrush(Color.FromArgb(255, 64, 0));//lapiz negro
		static public Brush brushBlue = new SolidBrush(Color.FromArgb(0, 128, 255));//lapiz negro
		static public Brush brushBlueLight = new SolidBrush(Color.FromArgb(0, 211, 242));//lapiz negro
		static public Brush brushGold = new SolidBrush(Color.Gold);//lapiz negro
		
		public Color() { }
	}
}
