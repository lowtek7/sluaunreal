// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class democppTarget : TargetRules
{
	public democppTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;	

		bUsePCHFiles = false;
		ExtraModuleNames.AddRange( new string[] { "democpp" } );
    }
}
