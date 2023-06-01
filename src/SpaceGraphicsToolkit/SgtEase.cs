// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtEase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  public static class SgtEase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Evaluate(SgtEase.Type ease, float t) => throw null;

    public enum Type
    {
      Linear,
      Smoothstep,
      Sinusoidial,
      Quadratic,
      Circular,
      Cubic,
      Quartic,
      Quintic,
      Exponential,
    }
  }
}
