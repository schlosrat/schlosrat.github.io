// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadCelestialBodyDataFilesFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
