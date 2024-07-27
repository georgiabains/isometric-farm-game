using Godot;
using System;

public partial class FarmPopup : CanvasLayer
{
	private EventBus.Event farmEvent;
	private Transform2D transformRelativeToFarm;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		transformRelativeToFarm = Transform;
		farmEvent = EventBus.Event.Listen("on-farm-click", OnFarmClick);
	}

	private void OnFarmClick(Node3D sender, string channel, dynamic args)
	{
		transformRelativeToFarm.Origin = args.farmCoordinates;
		Transform = transformRelativeToFarm;
	}
}
