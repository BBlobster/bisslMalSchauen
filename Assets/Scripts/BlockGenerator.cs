using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour {

    /* Prefab Block Gameobject with Sprite, Rigidbody2D, BoxCollider2D
     */
    public GameObject prefabBlock;

    /* Transform of the Canvas organizing the Gamescreen
     * used to set generated prefabBlocks as Child of this Canvas
     */
    public Transform parent;

    /* Instance for the prefabBlocks to manipulate them. Set position etc.
     */
    private GameObject block;
    /* Instance for the Rigidbody of the prefabBlocks to manipulate them. Add Force etc.
     */
    private Rigidbody2D rigidbodyofBlock;
    private System.Random random;
    private int column, row, blocksPerColumn, thrust, usedOne, usedTwo, numberOfBlocks = 0;

    private static int numberOfBlockRows = 30;
    private static int verticalSpaceBetweenBlocks = 60;
    private static int horizontalSpaceBetweenBlocks = 20;


    /* Gameobject Array to store the generated Blocks
     */
    private static List<GameObject> blocks;

    
    
    void Start (){
        GenerateBlocks(numberOfBlockRows);
        GenerateFinalBlock(numberOfBlockRows);
    }

    /* Getter Setter for numberOfBlockRows
     */
    public int NumberOfBlocks
    {
        get { return numberOfBlocks; }
        set { numberOfBlocks = value; }
    }
    /* Getter for the array with all generated Blocks
     */
    public List<GameObject> Blocks
    {
        get { return blocks; }
    }
    /* generates Blocks from the PrefabBlock
     * positions the Blocks in a random Scheme
     * calls AddForce for each Block to make them go towards the Player
     */
    private void GenerateBlocks(int numberOfBlockRows)
    {
        blocks = new List<GameObject>();
        random = new System.Random();

        /* Outer loop for each row of blocks to generate
         */
        for (row = 1; row < numberOfBlockRows; row++)
        {
            /* random for 1 to 3 blocks in this row.
             */
            blocksPerColumn = random.Next(3);

            /* Ints to check if the column in this row already has a Block
             * to begin of a new row their are set to 5 to make sure all columns are free in a new row
             */
            usedOne = 5;
            usedTwo = 4;
            /* Inner loop for each block to generate in this row.
             */
            for(int i = 0; i <= blocksPerColumn; i++)
            {
                /* Sets a column which is not yet used in the row
                 */
                column = GiveMeANotUsedColumn();
 
                /* Instantiates a block from the prefabBlock in the specified column and row.
                 */
                block = Instantiate(prefabBlock, new Vector3(x: column * horizontalSpaceBetweenBlocks, y: row * verticalSpaceBetweenBlocks, z: 0), Quaternion.identity) as GameObject;

                /* Makes the block a child of the screenspace canvas
                 * sets the worldspce position false, so the localscale of the canvas(parent) is used
                 */
                block.transform.SetParent(parent, false);

                /* Adds Force to block, adds block to the blocklist, count blocks
                 */
                AddForceToBlock(block);
                blocks.Add(block);
                numberOfBlocks++;
            }
        }
    }
    /* Generates the finalBlock
     * It's a bigger version of the same prefabBlock
     * It's positioned above all the other blocks
     */
                private void GenerateFinalBlock(int numberOfBlockRows)
    {
       
        block = Instantiate(prefabBlock, new Vector3(x: 0, y: verticalSpaceBetweenBlocks * (numberOfBlockRows + 1), z: 0), Quaternion.identity);
        block.transform.localScale = block.transform.localScale + new Vector3(90, 90, 1);
        block.transform.SetParent(parent, false);
        AddForceToBlock(block);
    }
    /* Adds a vertical Force to move the blocks down torwards the player.
     */
    private void AddForceToBlock(GameObject block)
    {
        rigidbodyofBlock = block.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        thrust = -400;
        rigidbodyofBlock.AddForce(transform.up * thrust);
    }
    /* Local helperfunction to determine an row-unique column, for a block to be instanciated.
     */
    private int GiveMeANotUsedColumn()
    {
        /*Makes sure column is not set to an already used column.
         */
        rollAgain:
        column = random.Next(-2, 3);
        if (column == usedOne || column == usedTwo) { goto rollAgain; }

        /* saves first call column to usedOne and second call column to usedTwo
         */
        if (usedOne == 5) { usedOne = column; }
        if (usedTwo == 5) { usedTwo = column; }

        /* makes sure second call column is saved to usedTwo
         */
        if (usedTwo == 4) { usedTwo++; }

        return column;
    }
}
