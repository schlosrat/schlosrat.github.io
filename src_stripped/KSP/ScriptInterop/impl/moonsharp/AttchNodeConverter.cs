// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.AttchNodeConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (AttachNodeType), "AttachNodeType", new string[] {"NodeType", "KSP.Sim.AttachNodeType"})]
  public class AttchNodeConverter : EnumConverter<AttachNodeType>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttchNodeConverter(TypeInterop typeInterop) => throw null;
  }
}
