using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text; 

public class LayoutLoader : MonoBehaviour {

	/*
	public List<PlatformLayout> Load(string fileName)
	{

		List<PlatformLayout> platformLayouts = new List<PlatformLayout>();

		try
		{
			string line; 
			//StreamReader reader = new StreamReader(Application.dataPath + "/Resources/layouts.csv");
			TextAsset testAsset = Resources.Load("layouts") as TextAsset; 
			StringReader reader = new StringReader(testAsset.text);

			switch (Application.platform)
			{ 
				case RuntimePlatform.WindowsEditor:
					break;
				case RuntimePlatform.Android:
					break;
				case RuntimePlatform.WindowsPlayer:
					break;
				case RuntimePlatform.WebGLPlayer:
					break;
			}

			using(reader)
			{
				//TODO make safer, on fail a single layout
				line = reader.ReadLine();

				do
				{
					PlatformLayout platformLayout = new PlatformLayout();

					string[] lineSplit;
					lineSplit = line.Split(','); 

					platformLayout.number = int.Parse(lineSplit[0]);
					platformLayout.name = lineSplit[1];

					int width = int.Parse(lineSplit[2]);
					int length = int.Parse(lineSplit[3]);
					platformLayout.width = width;
					platformLayout.length = length;

					//Parse rail-start line
					line = reader.ReadLine();
					lineSplit = line.Split(new char[] {','}, System.StringSplitOptions.RemoveEmptyEntries);
					int[] startRails = System.Array.ConvertAll(lineSplit, s => int.Parse(s));
					platformLayout.startRails = startRails;
					platformLayout.startRailsString = getRailString(startRails);

					for(int i = 0; i < lineSplit.Length; i++)
					{
						platformLayout.startRails[i] = int.Parse(lineSplit[i]);
					}

					//Parse platform array
					platformLayout.platformArray = new int[length][];

					for(int y = 0; y < length; y++)
					{
						line = reader.ReadLine();
						lineSplit = line.Split(new char[] {','}, System.StringSplitOptions.RemoveEmptyEntries);
						platformLayout.platformArray[y] = new int[width];

						for(int x = 0; x < width; x++)
						{
							platformLayout.platformArray[y][x] = int.Parse(lineSplit[x]);
						}
					}


					//Parse line-end rails
					line = reader.ReadLine();
					lineSplit = line.Split(new char[] {','}, System.StringSplitOptions.RemoveEmptyEntries);
					int[] endRails = System.Array.ConvertAll(lineSplit, s => int.Parse(s));
					platformLayout.endRails = endRails;
					platformLayout.endRailsString = getRailString(endRails);
					
					for(int i = 0; i < lineSplit.Length; i++)
					{
						platformLayout.endRails[i] = int.Parse(lineSplit[i]);
					}

					//parse notification array
					platformLayout.notificationArray = new int[length][];
				
					for(int y = 0; y < length; y++)
					{
						line = reader.ReadLine();
						lineSplit = line.Split(','); 
						platformLayout.notificationArray[y] = new int[width];
						
						for(int x = 0; x < width; x++)
						{
							platformLayout.notificationArray[y][x] = int.Parse(lineSplit[x]);
						}
					}

					//Skip final line
					reader.ReadLine();
					line = reader.ReadLine();

					platformLayouts.Add(platformLayout);
				}
				while (line != null);
			}
		}
		catch(UnityException uex)
		{
			print (uex.Message);
		}

		return platformLayouts;
	}



	//Produce a string of the integers of either incoming or outgoing rails to be used in picking platforms
	string getRailString (int[] rails)
	{
		string railName = ""; 
		for(int i = 0; i < rails.Length; i++)
		{
			railName = railName + rails[i].ToString();
		}
		return railName;
		
	}
		*/

}
