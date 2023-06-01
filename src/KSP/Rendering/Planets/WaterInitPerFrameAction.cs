// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.WaterInitPerFrameAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.Planets
{
  public class WaterInitPerFrameAction : ILateUpdate, IPriorityOverride
  {
    public Action OnWaterInitPerFrameAction;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaterInitPerFrameAction(PrevisGameInstance previsGameInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;
  }
}
