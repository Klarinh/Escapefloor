using UnrealBuildTool;

public class MindFackServerTarget : TargetRules
{
	public MindFackServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MindFack");
	}
}
