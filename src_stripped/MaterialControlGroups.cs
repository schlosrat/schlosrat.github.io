// Decompiled with JetBrains decompiler
// Type: MaterialControlGroups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
