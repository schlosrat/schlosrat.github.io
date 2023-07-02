// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SteppedRangeAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
