// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class PartProvider
  {
    private readonly Dictionary<string, PartCore> _partData;
    private readonly Dictionary<string, string> _partJson;
    private bool _isDataLoaded;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPartData(PartCore jsonData, string rawJson) => throw null;

    public bool IsDataLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown(bool clearPartData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyCollection<PartCore> AllParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartCore Get(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetRawJson(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartProvider() => throw null;
  }
}
