using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bunga
{
    public enum Tile
    {
        sand,
        empty,
        water,
        seeds,
        villager
    }

    public class Generator : MonoBehaviour
    {
        public Transform arrayPos;
        public GameObject sand;
        public GameObject empty;
        public GameObject villager;
        public GameObject seeds;
        public GameObject water;
        public Tile[,] grid;
        private void Start()
        {
            grid = new Tile[8, 6];
            transform.position = arrayPos.position;
            //transform.rotation = arrayPos.rotation;
            for (int i = 0; i < 8; i++)
            {
                transform.position = arrayPos.position;
                transform.position += Vector3.down * i;
                for (int j = 0; j < 6; j++)
                {
                    RandomUrMom(i, j);
                    GeneratePref(i, j);
                    transform.position += Vector3.right;
                }
            }
        }
        void GeneratePref(int i, int j)
        {
            if (grid[i, j] == Tile.sand) Instantiate(sand, transform.position, transform.rotation);
            if (grid[i, j] == Tile.empty) Instantiate(empty, transform.position, transform.rotation);
            if (grid[i, j] == Tile.villager)
            {
                Instantiate(villager, transform.position, transform.rotation);
                Instantiate(empty, transform.position, transform.rotation);
            }
            if (grid[i, j] == Tile.seeds) Instantiate(seeds, transform.position, transform.rotation);
        }
        void RandomUrMom(int i, int j)
        {
            float rand = Random.value;
            if (rand < 0.3) grid[i, j] = Tile.sand;
            else if (rand < 0.6) grid[i, j] = Tile.empty;
            else if (rand < 0.9) grid[i, j] = Tile.villager;
            else grid[i, j] = Tile.seeds;
        }
        /*private void Update()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    DestroyPref(i, j);
                }
            }
        }
        void DestroyPref(int i, int j)
        {
            if(grid[i,j] == Tile.empty)
            {
                if (grid[i,j-1] == Tile.water || grid[i,j+1] == Tile.water || grid[i-1,j] == Tile.water || grid[i+1,j] == Tile.water)
                {
                    Instantiate(water, transform.position, transform.rotation);
                    Destroy(empty);
                }
            }
        }*/





        /*transform.position = arrayPos.position;
    transform.rotation = arrayPos.rotation;
    for (int i = 0; i < 8; i++)
    {
        transform.position = arrayPos.position;
        transform.position += Vector3.down * i;
        for (int j = 0; j < 6; j++)
        {
            Generate();
            transform.position += Vector3.right;
        }
    }


    void Generate()
    {
        float rand = Random.value;
        if (rand < 0.4) Instantiate(sand, transform.position, transform.rotation);
        else if (rand < 0.8) Instantiate(empty, transform.position, transform.rotation);
        else if (rand < 0.9)
        {
            Instantiate(empty, transform.position, transform.rotation);
            Instantiate(villager, transform.position, transform.rotation);
        }
        else if (rand < 1) Instantiate(seeds, transform.position, transform.rotation);
        else Instantiate(sand, transform.position, transform.rotation);
    }*/
    }
}
