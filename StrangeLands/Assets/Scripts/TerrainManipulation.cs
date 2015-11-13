using UnityEngine;
using System.Collections;

public class TerrainManipulation : MonoBehaviour {

	public Terrain myTerrain;
	private int xResolution;
	private int zResolution;
	private float[,] heights;
	
	void Start()
	{
		xResolution = myTerrain.terrainData.heightmapWidth;
		zResolution = myTerrain.terrainData.heightmapHeight;
		heights = myTerrain.terrainData.GetHeights(0,0,xResolution,zResolution);

		for (int y = 0; y < xResolution; y++) {
			for (int x = 0; x < zResolution; x++) {
				if(Random.value<0.005)
					heights[x,y] = (Random.Range(0f, 1f) + heights[x,y]) * 0.5f;
			}
		}
		myTerrain.terrainData.SetHeights(0, 0, heights);
	}
	
	void Update()
	{
	
		if (Random.value < 0.05) {
			for (int y = 0; y < xResolution; y++) {
				for (int x = 0; x < zResolution; x++) {
					heights [x, y] = (Random.Range (0f, 1f) + heights [x, y]) * 0.5f;
				}
			}
		
			myTerrain.terrainData.SetHeights (0, 0, heights);
		}
		//myTerrain.terrainData.GetHeights(50, 75, 40, 40);
	}
	
	private void raiseTerrain(Vector3 point)
	{
		int terX =(int)((point.x / myTerrain.terrainData.size.x) * xResolution);
		int terZ =(int)((point.z / myTerrain.terrainData.size.z) * zResolution);
		float y = heights[terX,terZ];
		y += 0.001f;
		float[,] height = new float[1,1];
		height[0,0] = y;
		heights[terX,terZ] = y;
		myTerrain.terrainData.SetHeights(terX, terZ, height);
	}
	
	private void lowerTerrain(Vector3 point)
	{
		int terX =(int)((point.x / myTerrain.terrainData.size.x) * xResolution);
		int terZ =(int)((point.z / myTerrain.terrainData.size.z) * zResolution);
		float y = heights[terX,terZ];
		y -= 0.001f;
		float[,] height = new float[1,1];
		height[0,0] = y;
		heights[terX,terZ] = y;
		myTerrain.terrainData.SetHeights(terX, terZ, height);
	}
}