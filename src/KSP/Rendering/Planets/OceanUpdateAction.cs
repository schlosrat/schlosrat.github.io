// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.OceanUpdateAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.Planets
{
  public class OceanUpdateAction : ILateUpdate, IPriorityOverride
  {
    public Action OnUpdateOceanAction;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OceanUpdateAction(PrevisGameInstance previsGameInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;
  }
}
