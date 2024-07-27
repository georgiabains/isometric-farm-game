using Godot;
using System;

public partial class FarmPopup : CanvasLayer
{
	private EventBus.Event farmEvent;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		farmEvent = EventBus.Event.Listen("on-farm-click", OnFarmClick);
		GD.Print(Transform);
	}

	private void OnFarmClick(Node3D sender, string channel, object[] args)
	{
		GD.Print(args);
		GD.Print("event bus test");
	}
}
