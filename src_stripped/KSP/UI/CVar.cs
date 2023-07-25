// Decompiled with JetBrains decompiler
// Type: KSP.UI.CVar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public abstract class CVar
  {
    public event Action<CVar> onChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected CVar() => throw null;
  }
}
