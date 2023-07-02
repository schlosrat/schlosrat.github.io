// Decompiled with JetBrains decompiler
// Type: MaterialControlGroups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
