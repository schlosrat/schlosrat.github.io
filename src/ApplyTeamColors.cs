// Decompiled with JetBrains decompiler
// Type: ApplyTeamColors
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
  [FormerlySerializedAs("teamColor01_internal")]
  [HideInInspector]
  public Color TeamColor01;
  [FormerlySerializedAs("teamColor02_internal")]
  [HideInInspector]
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
