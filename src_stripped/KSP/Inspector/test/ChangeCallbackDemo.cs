// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.ChangeCallbackDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class ChangeCallbackDemo : MonoBehaviour
  {
    [ChangeCallback("Callback01", false)]
    [Space]
    [Header("When not in play mode.")]
    [Header("By default callbacks are \"inactive\"")]
    [Space]
    [Header("The ChangeCallback Attribute lets you have")]
    [Header("specify callbacks on a per-field basis")]
    [Header("Try hitting play, and note the")]
    [Header("Basic Callback - no args")]
    [Space]
    [Header("Little eye icon and 'Active/Inactive' text")]
    [Space]
    [Space]
    [Header("As well as the 'On Change Calls: Name(args)' preview")]
    [Space]
    [Space]
    public int a;
    [Header("Callback with args gets cur value")]
    [Space]
    [ChangeCallback("Callback02", false)]
    public int b;
    [ChangeCallback("Callback03", false)]
    [Header("Static callbacks work too")]
    [Space]
    public int c;
    [Header("This callback is set to work in edit mode - try it!")]
    [Space]
    [Space]
    [ChangeCallback("Callback04", true)]
    public int d;
    [Header("Can handle defaults args")]
    [Space]
    [ChangeCallback("Callblack05", false)]
    [Space]
    public int e;
    [ChangeCallback("BogusFunc", false)]
    [Space]
    [Space]
    [Header("Invalid functions are handled")]
    public int f;
    [Space]
    [Header("functions with invalid args are too")]
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
