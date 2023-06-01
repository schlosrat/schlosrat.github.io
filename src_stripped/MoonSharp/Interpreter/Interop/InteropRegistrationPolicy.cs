// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.InteropRegistrationPolicy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
