using UnrealBuildTool;

public class MindFackClientTarget : TargetRules
{
	public MindFackClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MindFack");
	}
}
