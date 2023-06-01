// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkCurrent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
  internal class FrameworkCurrent : FrameworkClrBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsDbNull(object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool StringContainsChar(string str, char chr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type GetInterface(Type type, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FrameworkCurrent() => throw null;
  }
}
