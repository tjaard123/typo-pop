using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Typo_PoP
{
	public class Words
	{
		public static int amountOfWords = 0;
		private static string[] words;
		private static int i = 0;

		public static string[] customWordFiles = new string[4]; // Just to hold the global

		public static void loadWordFile( string wordFile )
		{
			try
			{
				string[] wordsTemp = new string [50];
				i = 0;			
				amountOfWords = 0;

				if ( wordFile == "default**1" )
					wordsTemp = recorded1();
				else if ( wordFile == "default**2" )
					wordsTemp = recorded2();
				else if ( wordFile == "default**3" )
					wordsTemp = recorded3();
				else if ( wordFile == "default**4" )
					wordsTemp = recorded4();
				else
				{
					FileStream file = new FileStream ( wordFile, FileMode.Open, FileAccess.Read );
					StreamReader sr = new StreamReader ( file );				
				
					string word = sr.ReadLine();
					while ( word != null )
					{					
						wordsTemp [ amountOfWords ] = word;
						amountOfWords++;
						word = sr.ReadLine();
					}
					sr.Close();
				}

				words = new string [ amountOfWords ];

				int[] randomInt = MyRandom.randomize ( amountOfWords, 7 );
				for ( int n = 0; n < randomInt.Length; n++ )
					words[n] = wordsTemp [ randomInt[n] ];
			}
			catch ( Exception exception )
			{
				MessageBox.Show ( exception + "" );
			}
		}

		public static string nextWord()
		{
			if ( i >= amountOfWords )
				return "-";			
				
			string word = words [ i ];
			i++;
			return word;
		}

		#region Hardcoded word files for recorded game
		private static string[] recorded1()
		{
			amountOfWords = 28;
			return new string[] { "Jas", "Regs", "Visse", "Refleks", "Nonsens",
								 "Hoekom", "Daar", "Groot", "Blikkie", "Wysheid",
								 "Poegaai", "Deposito", "Gemiddeld", "Outeniekwa", "Helikopter",
								 "Bus", "Rekening", "Slapeloos", "Uitstekend", "Zulu",
								 "Verbeelding", "Uitroep!", "Towenaar", "Valenteinsdag", "Digitaal",
								 "Publikasie", "Gevangenis", "Hernieu" };
								
		}
		private static string[] recorded2()
		{
			amountOfWords = 28;
			return new string[] { "Digter", "Huil", "Ontdooi", "Grens", "Funksie",
								 "Kennis", "Geld", "Leeu", "Potlood", "Rugby",
								 "Lat", "Depresiasie", "Demoralisasie", "Reduseer", "Saterdag",
								 "Pessimis", "Bedwelmde", "Genesis", "Chromaat", "Kameraderie",								 
								 "Onthou", "Vergelyking", "Uitdaging", "0827725924", "Aardse",
							     "Adresseer", "Smokkelary", "Gehandhaaf" };
		}
		private static string[] recorded3()
		{
			amountOfWords = 28;
			return new string[] { "Pen", "Skyf", "Radio", "Selfoon", "Prop",
								 "Hokkie", "Kas", "Hand", "Meisie", "Gaaf",
								 "Gedorie", "Tegnologie", "Kaapstadstraat", "Agterbaks", "Meganisme",
								 "Kompanjie", "Kwalifikasie", "Onnoukeurig", "Aanpassing", "Afskeidsoen",
								 "Verpleegster", "Wiskunde", "Vraag?", "Vergeet", "Rekenaar",
				                 "Drawwertjie", "Apparaat", "Herinnering" };
		}
		private static string[] recorded4()
		{
			amountOfWords = 28;
			return new string[] { "Agter", "Olifant", "Mes", "Sang", "Vinnige",
								 "Uiters", "Uil", "Grafies", "Saans", "Ja",
								 "Kattamakranka", "Eerstejaars", "Interessant", "Wrintiewaar", "Relevant",
								 "Kniehalter", "Nieu-seeland", "Vergrootglas", "Jakkaranda", "Siembamba",
								 "Gereed", "850628", "Matriekafskeid", "Spinnerak", "Uitgebrand",
							     "Eksplorasie", "Gehawende", "Jupiter" };
		}
		#endregion
	}
}
