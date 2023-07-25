// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PlaceholderEventEmitters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public static class PlaceholderEventEmitters
  {
    private static Dictionary<PlaceholderEventEmitters.Emitters, IEventEmitter> emitters;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IEventEmitter GetEmitter(PlaceholderEventEmitters.Emitters emitterType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PlaceholderEventEmitters() => throw null;

    public enum Emitters
    {
      LaunchSequence,
      Foo,
      Bar,
    }
  }
}
