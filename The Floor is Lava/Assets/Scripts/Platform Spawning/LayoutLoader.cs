using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text; 

public class LayoutLoader : MonoBehaviour {

	public List<PlatformLayout> Load(string fileName)
	{

		List<PlatformLayout> platformLayouts = new List<PlatformLayout>();

		try
		{
			string line; 
			StreamReader reader = new StreamReader(fileName, Encoding.Default);

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
					platformLayout.startRails = new int[lineSplit.Length];

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
					lineSplit = lineSplit = line.Split(new char[] {','}, System.StringSplitOptions.RemoveEmptyEntries);
					platformLayout.endRails = new int[lineSplit.Length];
					
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
						platformLayout.platformArray[y] = new int[width];
						
						for(int x = 0; x < width; x++)
						{
							platformLayout.platformArray[y][x] = int.Parse(lineSplit[x]);
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

}
