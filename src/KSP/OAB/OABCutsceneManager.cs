// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABCutsceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class OABCutsceneManager
  {
    public bool CutsceneIsReady;
    public Action CutsceneLoaded;
    protected ObjectAssemblyBuilder builder;
    protected DynamicConfigurationDatabase ConfigDatabase;
    protected string chosenCutsceneName;
    protected GameObject cutsceneGO;
    protected CutsceneManager chosenCutscene;
    protected Transform cutsceneCameraTransform;
    protected string _cutsceneLabel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABCutsceneManager(DynamicConfigurationDatabase configDB, ObjectAssemblyBuilder _builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init(System.Type builderClass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AsyncLoadCutscene(string assetName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitRandomCutscene() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayCutscene() => throw null;
  }
}
