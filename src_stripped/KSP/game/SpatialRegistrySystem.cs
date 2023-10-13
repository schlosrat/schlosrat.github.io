// Decompiled with JetBrains decompiler
// Type: KSP.Game.SpatialRegistrySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class SpatialRegistrySystem : KerbalMonoBehaviour, IDisposable
  {
    protected List<SpatialInstance> _registeredInstances;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Register(SpatialInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Unregister(SpatialInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpatialRegistrySystem() => throw null;
  }
}
