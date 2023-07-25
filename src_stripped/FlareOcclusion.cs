// Decompiled with JetBrains decompiler
// Type: FlareOcclusion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

[Serializable]
public class FlareOcclusion
{
  public bool occluded;
  public float occlusionScale;
  public FlareOcclusion.CullingState _CullingState;
  public float CullTimer;
  public float cullFader;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FlareOcclusion() => throw null;

  public enum CullingState
  {
    Visible,
    CullCountDown,
    CanCull,
    Culled,
    NeverCull,
  }
}
