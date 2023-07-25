// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.ChangeCallbackDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class ChangeCallbackDemo : MonoBehaviour
  {
    [Space]
    [ChangeCallback("Callback01", false)]
    [Header("Basic Callback - no args")]
    [Space]
    [Space]
    [Header("As well as the 'On Change Calls: Name(args)' preview")]
    [Header("Little eye icon and 'Active/Inactive' text")]
    [Header("Try hitting play, and note the")]
    [Space]
    [Header("When not in play mode.")]
    [Header("By default callbacks are \"inactive\"")]
    [Space]
    [Space]
    [Header("specify callbacks on a per-field basis")]
    [Header("The ChangeCallback Attribute lets you have")]
    [Space]
    public int a;
    [Space]
    [ChangeCallback("Callback02", false)]
    [Header("Callback with args gets cur value")]
    public int b;
    [Header("Static callbacks work too")]
    [ChangeCallback("Callback03", false)]
    [Space]
    public int c;
    [Space]
    [Space]
    [Header("This callback is set to work in edit mode - try it!")]
    [ChangeCallback("Callback04", true)]
    public int d;
    [ChangeCallback("Callblack05", false)]
    [Header("Can handle defaults args")]
    [Space]
    [Space]
    public int e;
    [Space]
    [Header("Invalid functions are handled")]
    [ChangeCallback("BogusFunc", false)]
    [Space]
    public int f;
    [Header("functions with invalid args are too")]
    [Space]
    [ChangeCallback("Callback06", false)]
    public int g;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback01() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback02(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Callback03(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Callback04(int d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Callblack05(MonoBehaviour foo = null, int bar = 4) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Callback06(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChangeCallbackDemo() => throw null;
  }
}
