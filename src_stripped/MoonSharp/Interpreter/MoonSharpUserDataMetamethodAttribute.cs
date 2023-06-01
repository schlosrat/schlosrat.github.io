// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.MoonSharpUserDataMetamethodAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
  public sealed class MoonSharpUserDataMetamethodAttribute : Attribute
  {
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpUserDataMetamethodAttribute(string name) => throw null;
  }
}
