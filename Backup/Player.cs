using System;

namespace Typo_PoP
{
	[Serializable]
	public class Player
	{
		public double rank = 0; // Number of balloons % Interval
		private double totalPopped;
		private double interval;
		private string playerName;
		private string wordFile;

		public Player()
		{
			rank = 0;
			totalPopped = 0;
			playerName = "<Empty>";
			wordFile = "<None>";
		}

		public Player ( int totalPopped, int interval, string wordFile )
		{			
			this.interval = ( double ) interval;
			this.totalPopped = ( double ) totalPopped;
			rank = this.totalPopped / this.interval;
			playerName = "<Empty>";
			this.wordFile = wordFile;
		}

		public string PlayerName
		{
			set
			{
				if ( value != null )
					playerName = value;
				else playerName = "Unknown";
			}
		}

		public string getPlayerInfo()
		{
			string playerInfo = playerName;
			string totalPoppedStr = "" + totalPopped;
			for ( int i = 0; i < 15 - playerName.Length; i++ )
				playerInfo += " ";
			playerInfo += totalPoppedStr;
			for ( int i = 0; i < 12 - totalPoppedStr.Length; i++ )
				playerInfo += " ";
			return playerInfo + interval;
		}

		public string getCustomPlayerInfo()
		{
			string playerInfo = playerName;
			string totalPoppedStr = "" + totalPopped;
			for ( int i = 0; i < 15 - playerName.Length; i++ )
				playerInfo += " ";
			playerInfo += totalPoppedStr;
			for ( int i = 0; i < 12 - totalPoppedStr.Length; i++ )
				playerInfo += " ";
			return playerInfo + interval + "           " + wordFile;
		}
	}
}
