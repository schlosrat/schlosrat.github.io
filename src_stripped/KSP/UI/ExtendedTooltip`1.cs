// Decompiled with JetBrains decompiler
// Type: KSP.UI.ExtendedTooltip`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
