// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadCelestialBodyDataFilesFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  public class LoadCelestialBodyDataFilesFlowAction : SaveLoadGameFlowActionBase
  {
    private Action _resolve;
    private SerializedGalaxyDefinition _galaxy;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadCelestialBodyDataFilesFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGalaxyDefinitionLoaded(TextAsset asset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GalaxyHasBody(string body_name) => throw null;
  }
}
