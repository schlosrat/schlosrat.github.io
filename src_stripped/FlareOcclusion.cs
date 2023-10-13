// Decompiled with JetBrains decompiler
// Type: FlareOcclusion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
