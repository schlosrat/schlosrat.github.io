// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.InteropRegistrationPolicy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.RegistrationPolicies;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public static class InteropRegistrationPolicy
  {
    public static IRegistrationPolicy Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [Obsolete("Please use InteropRegistrationPolicy.Default instead.")]
    public static IRegistrationPolicy Explicit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static IRegistrationPolicy Automatic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
