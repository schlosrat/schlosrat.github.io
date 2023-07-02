// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ModelViewBinding`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
