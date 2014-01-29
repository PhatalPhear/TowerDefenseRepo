using UnityEngine;
using System.Collections;

public struct cell2
{
	public int xPos;
	public int yPos;
	public bool canHaveTower;
}
public class grid2 : MonoBehaviour {

	cell2[,] cells;
	public int gridWidth;
	public int gridHeight;
	public GameObject cellObject;
	
	// Use this for initialization
	void Start () {
		generateGrid();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void generateGrid()
	{
		cells = new cell2[gridWidth,gridHeight];
		//nested for loop
		for(int i = 0; i <gridWidth;i++)
		{
			for (int j= 0; j < gridHeight;j++)
			{
				cells[i,j].xPos = i;
				cells[i,j].yPos = j;
			}
		}
		for(int i = 0; i <gridWidth;i++)
			for (int j= 0 ; j<gridHeight;j++)
				Instantiate(cellObject, new Vector3(i,j,0), Quaternion.identity);
		
	}
	}
