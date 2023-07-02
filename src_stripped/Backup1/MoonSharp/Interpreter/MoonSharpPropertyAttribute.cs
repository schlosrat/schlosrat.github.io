// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.MoonSharpPropertyAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
  public sealed class MoonSharpPropertyAttribute : Attribute
  {
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpPropertyAttribute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpPropertyAttribute(string name) => throw null;
  }
}
