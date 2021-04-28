using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICursorUser
{
    public bool Enable { get; set; }
    public void Interact(Tile t);
    public bool Yields();
    public ICursorUser ChangeUser(Tile t);
}
