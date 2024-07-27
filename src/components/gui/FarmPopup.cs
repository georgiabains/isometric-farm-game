using Godot;
using System;

public partial class FarmPopup : CanvasLayer
{
	private EventBus.Subscription farmSubscription;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		farmSubscription = EventBus.Subscription.Listen("on-farm-click", OnFarmClick);
	}

	private void OnFarmClick(Node3D sender, string channel, object[] args)
	{
		GD.Print("event bus test");
	}
}
