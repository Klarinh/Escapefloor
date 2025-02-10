using UnrealBuildTool;

public class MindFackEditorTarget : TargetRules
{
	public MindFackEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MindFack");
	}
}
