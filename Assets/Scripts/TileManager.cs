using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public GameObject[] obstcales;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 10;
    private float safeZone = 15.0f;
    private int amnTilesonScreen = 7;

    private List<GameObject> activeTiles = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < amnTilesonScreen; i++)
        {
            SpawnTile();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z -safeZone > (spawnZ - amnTilesonScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefab[0]) as GameObject;
        go.transform.SetParent(transform);
        Vector3 pos =  new Vector3(0f, 0f, 1f);
        go.transform.position =  pos * spawnZ;
        
        activeTiles.Add(go);

        
        int RandomNumOfObs = Random.Range(1, 2);

        for (int i = 0; i < RandomNumOfObs; i++)
        {
            GameObject obs = Instantiate(obstcales[RandomPrefabIndex()]);
            obs.transform.SetParent(go.transform);
            int RandomZ = Random.Range(-4, 4)+(int) go.transform.position.z;
            int RandomLane = Random.Range(-1, 1) * 2;
            Vector3 pos2 = new Vector3(RandomLane, 1f, RandomZ);
            obs.transform.position = pos2;
        }
        spawnZ += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles [0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        int RandomPrefabIndex = Random.Range(0, obstcales.Length);
        return RandomPrefabIndex;
    }
}
