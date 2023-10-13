// Decompiled with JetBrains decompiler
// Type: ActorMaterialColors
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActorMaterialColors : MonoBehaviour
{
  private const string TINT_PARAM_HAIR_AND_SKIN_NAME = "_RandomColor";
  [ColorUsage(false, true)]
  public Color SkinColor;
  [ColorUsage(false, true)]
  public Color HairColor;
  [ColorUsage(true, true)]
  public Color TeamColorBase;
  [ColorUsage(true, true)]
  public Color TeamColorAccent;
  [HideInInspector]
  public bool AreHairColorOptionsUnrestricted;
  [HideInInspector]
  public bool AreSkinColorOptionsUnrestricted;
  private List<Renderer> managedRenderers;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitAndApplyAllColors() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void TryApplyAllColors() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void TryApplyColorToMaterial(
    Material material,
    string paramName,
    Color colorValue,
    bool pbrSafe = false)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ActorMaterialColors() => throw null;
}
