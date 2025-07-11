using UnityModManagerNet;

namespace LocoOwnership
{
	public class Settings : UnityModManager.ModSettings, IDrawable
	{
		public readonly string? version = Main.mod?.Info.Version;

		[Draw("Enable logging")]
		public bool isLoggingEnabled =
#if DEBUG
			true;
#else
            false;
#endif

		[Draw("Locomotives cost nothing in sandbox")]
		public bool freeSandboxOwnership = false;

		[Draw("Locomotives cost nothing at all")]
		public bool freeOwnership = false;

		[Draw("Free locomotive requesting")]
		public bool freeCarTeleport = false;

		[Draw("Purchasing locomotives does not require demonstrator restoration")]
		public bool skipDemonstrator = false;

		[Draw("The funny (enable at your own risk)")]
		public bool theFunny = false;

		[Draw("Maximum number of owned locomotives", Min = 0, Max = 100)]
		public int maxLocosLimit = 16;

		[Draw("Purchase price multiplier", Min = 1)]
		public float purchasePriceMultiplier = 2f;

		[Draw("Sell price multiplier", Min = 0, Max = 1)]
		public float sellPriceMultiplier = .5f;

		public override void Save(UnityModManager.ModEntry entry)
		{
			Save(this, entry);
		}

		public void OnChange() { }
	}
}
