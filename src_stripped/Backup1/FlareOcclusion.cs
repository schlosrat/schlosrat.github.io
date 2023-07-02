// Decompiled with JetBrains decompiler
// Type: FlareOcclusion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
