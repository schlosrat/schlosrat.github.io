// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.CallbackButtonsDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class CallbackButtonsDemo : MonoBehaviour
  {
    [Header("The CallbackButtons Attribute lets you")]
    [Header("When a button is clicked, its corresponding")]
    [Header("callback is invoked, regardless of edit mode.")]
    [Space]
    [Space]
    [Space]
    [Header("One Callback Button")]
    [Space]
    [Space]
    [Header("Add buttons on specific fields.")]
    [CallbackButtons(new string[] {"Callback01"})]
    public int a;
    [CallbackButtons(new string[] {"Callback02"})]
    [Header("One Callback Button with a static callback")]
    [Space]
    public int b;
    [Space]
    [CallbackButtons(new string[] {"Callback03", "Callback04", "Callback05"})]
    [Header("Multiple Callback Buttons")]
    public int c;
    [Header("Can pass value of current field into callback")]
    [CallbackButtons(new string[] {"Callback06"})]
    [Space]
    [Space]
    public int d;
    [Space]
    [CallbackButtons(new string[] {"Callback06"})]
    [Header("And can resolve default arguments")]
    public int e;
    [CallbackButtons(new string[] {"BogusFunc", "NonDefaultInstance", "NonDefaultStatic"})]
    [Header("Handling invalid buttons")]
    [Space]
    [Space]
    public int f;
    [Space]
    [Space]
    [Header("Can provide custom text for buttons")]
    [CallbackButtons(new string[] {"IncCount", "DecCount", "StaticDoPrint"}, new string[] {"Increment Counter", "Decrement Counter", "Print Current value"})]
    public int count;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback01() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Callback02() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback03() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback04() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Callback05() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback06(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Callback07(int val, string foo = "bar") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NonDefaultInstance(string foo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void NonDefaultStatic(string foo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IncCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StaticDoPrint(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackButtonsDemo() => throw null;
  }
}
