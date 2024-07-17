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
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
