// Decompiled with JetBrains decompiler
// Type: KSP.Game.DataBus`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public abstract class DataBus<T> where T : class
  {
    protected T _dataSource;

    public T DataSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DataContext Context
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataBus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataBus(T dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SyncTo(T dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ValidateProperties() => throw null;
  }
}
