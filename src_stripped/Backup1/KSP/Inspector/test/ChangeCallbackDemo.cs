// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.ChangeCallbackDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class ChangeCallbackDemo : MonoBehaviour
  {
    [Header("The ChangeCallback Attribute lets you have")]
    [Header("specify callbacks on a per-field basis")]
    [Space]
    [Space]
    [Header("By default callbacks are \"inactive\"")]
    [Header("When not in play mode.")]
    [Space]
    [Header("Try hitting play, and note the")]
    [Header("As well as the 'On Change Calls: Name(args)' preview")]
    [Header("Little eye icon and 'Active/Inactive' text")]
    [Space]
    [Space]
    [ChangeCallback("Callback01", false)]
    [Header("Basic Callback - no args")]
    [Space]
    [Space]
    public int a;
    [Space]
    [ChangeCallback("Callback02", false)]
    [Header("Callback with args gets cur value")]
    public int b;
    [Space]
    [Header("Static callbacks work too")]
    [ChangeCallback("Callback03", false)]
    public int c;
    [Space]
    [Space]
    [ChangeCallback("Callback04", true)]
    [Header("This callback is set to work in edit mode - try it!")]
    public int d;
    [Space]
    [Space]
    [Header("Can handle defaults args")]
    [ChangeCallback("Callblack05", false)]
    public int e;
    [Space]
    [Space]
    [Header("Invalid functions are handled")]
    [ChangeCallback("BogusFunc", false)]
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
