// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SteppedRangeAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public sealed class SteppedRangeAttribute : PropertyAttribute
  {
    public readonly float min;
    public readonly float max;
    public readonly float step;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SteppedRangeAttribute(float min, float max, float step) => throw null;
  }
}
