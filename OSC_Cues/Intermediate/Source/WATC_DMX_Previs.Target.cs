using UnrealBuildTool;

public class WATC_DMX_PrevisTarget : TargetRules
{
	public WATC_DMX_PrevisTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("WATC_DMX_Previs");
	}
}
