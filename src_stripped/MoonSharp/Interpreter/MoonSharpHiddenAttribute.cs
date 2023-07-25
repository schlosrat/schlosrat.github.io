// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.MoonSharpHiddenAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
