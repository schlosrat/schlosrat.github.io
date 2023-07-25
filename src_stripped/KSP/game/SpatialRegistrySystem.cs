// Decompiled with JetBrains decompiler
// Type: KSP.Game.SpatialRegistrySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
