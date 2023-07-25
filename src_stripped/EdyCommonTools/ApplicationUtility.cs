// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ApplicationUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public static class ApplicationUtility
  {
    private static PropertyInfo s_internalIsActive;
    private static PropertyInfo s_wheelColliderSprungMass;
    private static bool s_writableSprungMass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsActivated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WritableSprungMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FixSprungMass(WheelCollider wheelCollider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ApplicationUtility() => throw null;
  }
}
