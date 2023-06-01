// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartStatusConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartStatus), "PartStatus", new string[] {"KSP.Sim.PartStatus"})]
  public class PartStatusConverter : EnumConverter<PartStatus>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartStatusConverter(TypeInterop typeInterop) => throw null;
  }
}
