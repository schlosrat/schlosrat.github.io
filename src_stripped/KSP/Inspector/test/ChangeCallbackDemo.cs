// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.ChangeCallbackDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class ChangeCallbackDemo : MonoBehaviour
  {
    [Space]
    [Header("Try hitting play, and note the")]
    [Header("Little eye icon and 'Active/Inactive' text")]
    [Header("As well as the 'On Change Calls: Name(args)' preview")]
    [Space]
    [Space]
    [Space]
    [Header("Basic Callback - no args")]
    [Space]
    [ChangeCallback("Callback01", false)]
    [Space]
    [Space]
    [Header("specify callbacks on a per-field basis")]
    [Header("The ChangeCallback Attribute lets you have")]
    [Header("By default callbacks are \"inactive\"")]
    [Header("When not in play mode.")]
    public int a;
    [Header("Callback with args gets cur value")]
    [ChangeCallback("Callback02", false)]
    [Space]
    public int b;
    [Space]
    [Header("Static callbacks work too")]
    [ChangeCallback("Callback03", false)]
    public int c;
    [Header("This callback is set to work in edit mode - try it!")]
    [ChangeCallback("Callback04", true)]
    [Space]
    [Space]
    public int d;
    [Space]
    [Header("Can handle defaults args")]
    [Space]
    [ChangeCallback("Callblack05", false)]
    public int e;
    [Space]
    [Space]
    [Header("Invalid functions are handled")]
    [ChangeCallback("BogusFunc", false)]
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
