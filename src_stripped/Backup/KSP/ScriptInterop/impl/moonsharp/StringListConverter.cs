// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.StringListConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (List<string>), "Array<String>", new string[] {"System.Collections.Generic.List<string>"})]
  public class StringListConverter : ListConverters<string>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringListConverter(TypeInterop typeInterop) => throw null;
  }
}
