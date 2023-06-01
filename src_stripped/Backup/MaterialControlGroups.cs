// Decompiled with JetBrains decompiler
// Type: MaterialControlGroups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MaterialControlGroups : MonoBehaviour
{
  public MaterialControlGroups.EmissiveControlInfo[] EmissiveControlList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetMaterialValuesByColor(Color newColor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetMaterialValuesByPercentage(float valuePercentage) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MaterialControlGroups() => throw null;

  [Serializable]
  public class EmissiveControlInfo
  {
    public string ParamName;
    [GradientUsage(true)]
    public Gradient EmissiveGradient;
    public AnimationCurve ControlCurve;
    public Renderer[] Targets;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EmissiveControlInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyColor(Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyColorByPercentage(float newPercentage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Gradient GenerateDefaultEmissiveGradient() => throw null;
  }
}
