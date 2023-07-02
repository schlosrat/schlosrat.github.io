// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ExplosionTypeConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ExplosionType), "ExplosionType", new string[] {"KSP.Sim.ExplosionType"})]
  public class ExplosionTypeConverter : EnumConverter<ExplosionType>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExplosionTypeConverter(TypeInterop typeInterop) => throw null;
  }
}
