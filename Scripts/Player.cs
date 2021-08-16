using Godot;
using System;

public class Player : Character
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        friendly = true;
    }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
        velocity = new Vector2(Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left"),
                               Input.GetActionStrength("move_up") - Input.GetActionStrength("move_down"));
        velocity = velocity.Normalized(); //velocity always needs to have length 1
  }
}
