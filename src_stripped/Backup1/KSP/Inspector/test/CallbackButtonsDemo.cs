// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.CallbackButtonsDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class CallbackButtonsDemo : MonoBehaviour
  {
    [CallbackButtons(new string[] {"Callback01"})]
    [Space]
    [Space]
    [Header("One Callback Button")]
    [Header("The CallbackButtons Attribute lets you")]
    [Header("callback is invoked, regardless of edit mode.")]
    [Header("When a button is clicked, its corresponding")]
    [Space]
    [Space]
    [Space]
    [Header("Add buttons on specific fields.")]
    public int a;
    [Space]
    [Header("One Callback Button with a static callback")]
    [CallbackButtons(new string[] {"Callback02"})]
    public int b;
    [Header("Multiple Callback Buttons")]
    [Space]
    [CallbackButtons(new string[] {"Callback03", "Callback04", "Callback05"})]
    public int c;
    [Space]
    [Space]
    [Header("Can pass value of current field into callback")]
    [CallbackButtons(new string[] {"Callback06"})]
    public int d;
    [Space]
    [Header("And can resolve default arguments")]
    [CallbackButtons(new string[] {"Callback06"})]
    public int e;
    [Space]
    [Space]
    [Header("Handling invalid buttons")]
    [CallbackButtons(new string[] {"BogusFunc", "NonDefaultInstance", "NonDefaultStatic"})]
    public int f;
    [CallbackButtons(new string[] {"IncCount", "DecCount", "StaticDoPrint"}, new string[] {"Increment Counter", "Decrement Counter", "Print Current value"})]
    [Header("Can provide custom text for buttons")]
    [Space]
    [Space]
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
