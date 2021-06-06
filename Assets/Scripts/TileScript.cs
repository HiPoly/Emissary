using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    [SerializeField] int tileType;

    [SerializeField] private bool Road;


    [SerializeField] private bool Town;


    //BarrierVars
    private int difficulty;


    // Start is called before the first frame update
    void Start()
    {
        if (tileType == 11){
            //Road
        }
    }

    /* Use number in editor to select tile e.g. int 24 = Type 2, sub-type 4
    Type 1
        1 - Road Tile
        2 - Town Tile
        3 - Barrier Tile
        4 - Empty Tile
    Type 2
        1 - Lush Haven
        2 - Overgrown Haven
        3 - Waterfall Haven
        4 - River Haven
    */
}
