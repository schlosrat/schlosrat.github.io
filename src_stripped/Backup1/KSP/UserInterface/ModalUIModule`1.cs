// Decompiled with JetBrains decompiler
// Type: KSP.UserInterface.ModalUIModule`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
