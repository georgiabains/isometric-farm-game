/**
 * Farm.
 * - A tile from which to grow plants.
 *
 * Has:
 * - crop / isGrowingCrop ?
 * - water -- is this something I want to keep track of?
 * - nutrient/fertility -- boost? buff?
 *
 * Does:
 * - plantCrop() -- its kind of a setter? but not rly
 * - growCrop()
 * - harvestCrop()
 * - spawnDisease()
 * - spawnPest()
 */

using Godot;
using System;

public partial class Farm : StaticBody3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("ready");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private static void OnMouseEntered()
	{
		GD.Print("test");
	}

	private void OnInputEvent(Node camera, InputEvent @event, Vector3 position, Vector3 normal, long shape_idx)
	{
		if (@event is InputEventMouseButton mouseButton)
		{
			if (mouseButton.Pressed)
			{
				return;
			}

			Vector2 farmPosition2D = GetViewport().GetCamera3D().UnprojectPosition(GlobalPosition);
			EventBus.Event.Emit(this, "on-farm-click", farmPosition2D);
		}
	}
}
