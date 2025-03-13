using UnrealBuildTool;

public class unyielding_corridorClientTarget : TargetRules
{
	public unyielding_corridorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("unyielding_corridor");
	}
}
