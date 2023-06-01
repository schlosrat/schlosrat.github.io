// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ExplosionTypeConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
