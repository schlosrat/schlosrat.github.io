// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PlaceholderEventEmitters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
