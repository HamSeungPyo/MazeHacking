using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {
    public GameObject[] map = new GameObject[4];
	void Start ()
    {
        float angle = 75.5f;
        Vector3[] mapPos =
            {new Vector3(0,0,0), new Vector3(0, 0, angle), new Vector3(angle, 0, 0), new Vector3(angle, 0, angle) };
        float[] mapAngle = { 0,90,180,270};
        int mapArray = 0;
        int array = -1;
        int[] MapArraySave = new int[4];
        while (true)
        {

            int randomPos = Random.Range(0, 4);
            if (MapArraySave[randomPos] != 1)
            {
                MapArraySave[randomPos] = 1;
                array += 1;
            }
            if (mapArray== array)
            {
                int randomAngle = Random.Range(0, 4);
                Instantiate(map[mapArray], mapPos[randomPos], Quaternion.Euler(-90, mapAngle[randomAngle], 0));
                mapArray += 1;
                if (mapArray == 4)
                    break;
            }

        }
		
	}
	void Update ()
    {
		
	}
}
