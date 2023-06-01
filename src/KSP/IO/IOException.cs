// Decompiled with JetBrains decompiler
// Type: KSP.IO.IOException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.IO
{
  public class IOException : Exception
  {
    protected string message;
    protected string source;
    protected string stack;

    public override string Message
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override string Source
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override string StackTrace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IOException(string message, string source, string stack) => throw null;
  }
}
