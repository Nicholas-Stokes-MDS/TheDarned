// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TheDarned : ModuleRules
{
	public TheDarned(ReadOnlyTargetRules Target) : base(Target)
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
			"TheDarned",
			"TheDarned/Variant_Platforming",
			"TheDarned/Variant_Platforming/Animation",
			"TheDarned/Variant_Combat",
			"TheDarned/Variant_Combat/AI",
			"TheDarned/Variant_Combat/Animation",
			"TheDarned/Variant_Combat/Gameplay",
			"TheDarned/Variant_Combat/Interfaces",
			"TheDarned/Variant_Combat/UI",
			"TheDarned/Variant_SideScrolling",
			"TheDarned/Variant_SideScrolling/AI",
			"TheDarned/Variant_SideScrolling/Gameplay",
			"TheDarned/Variant_SideScrolling/Interfaces",
			"TheDarned/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
