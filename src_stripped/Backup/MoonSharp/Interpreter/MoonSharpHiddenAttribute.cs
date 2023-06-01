// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.MoonSharpHiddenAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = true, AllowMultiple = false)]
  public sealed class MoonSharpHiddenAttribute : Attribute
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpHiddenAttribute() => throw null;
  }
}
