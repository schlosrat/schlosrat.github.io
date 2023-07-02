// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtEase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
