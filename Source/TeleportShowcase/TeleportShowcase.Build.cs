// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TeleportShowcase : ModuleRules
{
	public TeleportShowcase(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TeleportShowcase",
			"TeleportShowcase/Variant_Platforming",
			"TeleportShowcase/Variant_Platforming/Animation",
			"TeleportShowcase/Variant_Combat",
			"TeleportShowcase/Variant_Combat/AI",
			"TeleportShowcase/Variant_Combat/Animation",
			"TeleportShowcase/Variant_Combat/Gameplay",
			"TeleportShowcase/Variant_Combat/Interfaces",
			"TeleportShowcase/Variant_Combat/UI",
			"TeleportShowcase/Variant_SideScrolling",
			"TeleportShowcase/Variant_SideScrolling/AI",
			"TeleportShowcase/Variant_SideScrolling/Gameplay",
			"TeleportShowcase/Variant_SideScrolling/Interfaces",
			"TeleportShowcase/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
