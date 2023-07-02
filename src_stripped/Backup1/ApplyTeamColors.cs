// Decompiled with JetBrains decompiler
// Type: ApplyTeamColors
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class ApplyTeamColors : KerbalMonoBehaviour
{
  [FormerlySerializedAs("TeamColor01Override")]
  public bool isOverridingAccentColor;
  [FormerlySerializedAs("TeamColor01OverrideColor")]
  public Color accentOverrideColor;
  [FormerlySerializedAs("TeamColor02Override")]
  public bool isOverridingBaseColor;
  [FormerlySerializedAs("TeamColor02OverrideColor")]
  public Color baseOverrideColor;
  [HideInInspector]
  [FormerlySerializedAs("teamColor01_internal")]
  public Color TeamColor01;
  [HideInInspector]
  [FormerlySerializedAs("teamColor02_internal")]
  public Color TeamColor02;
  [HideInInspector]
  public List<Renderer> RendererList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator SetTeamColorCoroutine(
    Renderer targetMesh,
    Color baseColor,
    Color accentColor)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsMaterialAnInstance(Material targetMaterial) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetTeamColors(Color baseColor, Color accentColor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateTeamColorValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ApplyAccentColor(GameObject target, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ApplyBaseColor(GameObject target, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ApplyColorToMaterialWithName(GameObject target, string name, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ApplyBaseAndAccentColor(GameObject target, Color baseColor, Color accentColor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ApplyTeamColors() => throw null;
}
