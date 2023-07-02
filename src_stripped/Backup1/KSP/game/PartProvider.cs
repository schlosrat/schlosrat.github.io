// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
