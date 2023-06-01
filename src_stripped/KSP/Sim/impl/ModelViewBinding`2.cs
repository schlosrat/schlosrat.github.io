// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ModelViewBinding`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ModelViewBinding<M, V>
    where M : class
    where V : class
  {
    private readonly IDictionary<M, V> _modelToViewMap;
    private readonly IDictionary<V, M> _viewToModelMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Bind(M model, V view, bool allowRebind) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unbind(M model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unbind(V view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public V FromModel(M model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public M FromView(V view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModelViewBinding() => throw null;
  }
}
