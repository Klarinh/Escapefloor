using UnrealBuildTool;

public class unyielding_corridorEditorTarget : TargetRules
{
	public unyielding_corridorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("unyielding_corridor");
	}
}
