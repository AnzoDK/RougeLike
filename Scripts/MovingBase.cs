using Godot;
using System;

public class MovingBase : KinematicBody2D
{
	protected Vector2 velocity = Vector2.Zero;

	// Called when the node enters the scene tree for the first time.
	
	public override void _Ready()
	{

	}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
		MoveAndSlide(velocity);
  }
}
