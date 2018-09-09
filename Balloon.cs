using System;
using System.Drawing;

namespace Typo_PoP
{
	public class Balloon
	{		
		private Image image;
		private Bitmap popImage;
		private string word;
		private Rectangle frame = new Rectangle ( 0, 0, 32, 48 );
		private static Random random = new Random ( DateTime.Now.Second );
		
		public Balloon ( int xPos, int yPos, string word )
		{			
			int randomInt = random.Next ( 5 ) + 1;
			image = Image.FromFile ( "Images/Balloon" +
				randomInt + ".gif" );
			popImage = ( Bitmap ) Image.FromFile ( "Images//Pop" +
				randomInt + ".gif" );
			this.word = word.ToUpper();
			setLocation ( xPos, yPos );
		}

		public void draw ( Graphics graphics )
		{
			graphics.DrawImage ( image, frame );

			SolidBrush brush = new SolidBrush ( Color.WhiteSmoke );
			Font font = new Font ( new FontFamily ( "Arial" ),
				9, FontStyle.Bold );			

			double length = word.Length / 18.0;
			length *= 116;
			int xOffset = ( int ) ( ( 0.539 * ( length ) ) - 17.5 );
			graphics.DrawString ( word, font, brush,
				frame.X - xOffset, frame.Y + 48 );
		}

		public void pop ( int popFrame )
		{
			image = popImage.Clone ( new Rectangle ( ( popFrame * 99 ) + 1, 1, 98, 148 ),
				System.Drawing.Imaging.PixelFormat.DontCare );
		}

		public Rectangle Frame
		{
			get
			{
				return frame;
			}
		}

		public void setLocation ( int xPos, int yPos )
		{
			frame.X = xPos;
			frame.Y = yPos;
		}

		public string Word
		{
			get
			{
				return word;
			}
		}
	}
}
