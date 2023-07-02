// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.DoubleListConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (List<double>), "Array<Double>", new string[] {"System.Collections.Generic.List<double>"})]
  public class DoubleListConverter : ListConverters<double>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleListConverter(TypeInterop typeInterop) => throw null;
  }
}
