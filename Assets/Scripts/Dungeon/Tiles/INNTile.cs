using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INNTile : Tile
{
    public override void EnterTile()
    {
        // Player sprite invisible
        // Restore full health
        GameController.Instance.Player.RestoreHealth();
        // Start Cinematic
        // End Cinematic -> Player sprite visible + player pos front INN
    }
}
