using System;
using Godot;

public class DmgTypeBase
{

}

public class Fire : DmgTypeBase
{

}


public class DmgManager : Node
{
    public enum DmgTypes
    {
        Fire = 0,
        Water
    }
    public enum DmgState
    {
        None = 1,
        Weak,
        Resistant

    }

    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        DmgState a = DmgState.None;
        switch(a)
        {

        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //
    //  }
}
