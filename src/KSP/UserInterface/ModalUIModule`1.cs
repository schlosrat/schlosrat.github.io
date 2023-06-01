// Decompiled with JetBrains decompiler
// Type: KSP.UserInterface.ModalUIModule`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UserInterface
{
  public class ModalUIModule<U> : UIModule where U : struct
  {
    public U Data;

    public event Action<U> OnResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnCancelled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Pool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cancel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModalUIModule() => throw null;
  }
}
