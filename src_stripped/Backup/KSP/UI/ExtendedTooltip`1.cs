// Decompiled with JetBrains decompiler
// Type: KSP.UI.ExtendedTooltip`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public abstract class ExtendedTooltip<T> : StandardTooltip
  {
    protected T _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Configure(T data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ExtendedTooltip() => throw null;
  }
}
