// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class VISUAL_SCRIPTINGEditorTarget : TargetRules
{
	public VISUAL_SCRIPTINGEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "VISUAL_SCRIPTING" } );
	}
}
