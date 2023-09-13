using UnrealBuildTool;

public class WATC_DMX_Previs : ModuleRules
{
	public WATC_DMX_Previs(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
