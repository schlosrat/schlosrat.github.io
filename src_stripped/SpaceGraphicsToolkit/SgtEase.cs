// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtEase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
