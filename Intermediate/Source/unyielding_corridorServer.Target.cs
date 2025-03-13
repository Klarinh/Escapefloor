using UnrealBuildTool;

public class unyielding_corridorServerTarget : TargetRules
{
	public unyielding_corridorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("unyielding_corridor");
	}
}
