using UnrealBuildTool;

public class unyielding_corridorTarget : TargetRules
{
	public unyielding_corridorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("unyielding_corridor");
	}
}
