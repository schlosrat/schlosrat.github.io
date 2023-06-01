// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PAMDisplayControlAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [AttributeUsage(AttributeTargets.Field)]
  public class PAMDisplayControlAttribute : Attribute
  {
    public int SortIndex;
    public bool ExcludeFromContext;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PAMDisplayControlAttribute() => throw null;
  }
}
