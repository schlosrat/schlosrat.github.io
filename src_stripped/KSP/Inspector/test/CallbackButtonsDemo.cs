// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.test.CallbackButtonsDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector.test
{
  public class CallbackButtonsDemo : MonoBehaviour
  {
    [Header("callback is invoked, regardless of edit mode.")]
    [Header("The CallbackButtons Attribute lets you")]
    [Header("Add buttons on specific fields.")]
    [Header("One Callback Button")]
    [Space]
    [Space]
    [Header("When a button is clicked, its corresponding")]
    [Space]
    [Space]
    [CallbackButtons(new string[] {"Callback01"})]
    [Space]
    public int a;
    [Header("One Callback Button with a static callback")]
    [Space]
    [CallbackButtons(new string[] {"Callback02"})]
    public int b;
    [Header("Multiple Callback Buttons")]
    [Space]
    [CallbackButtons(new string[] {"Callback03", "Callback04", "Callback05"})]
    public int c;
    [Header("Can pass value of current field into callback")]
    [Space]
    [CallbackButtons(new string[] {"Callback06"})]
    [Space]
    public int d;
    [Header("And can resolve default arguments")]
    [CallbackButtons(new string[] {"Callback06"})]
    [Space]
    public int e;
    [Space]
    [Space]
    [Header("Handling invalid buttons")]
    [CallbackButtons(new string[] {"BogusFunc", "NonDefaultInstance", "NonDefaultStatic"})]
    public int f;
    [CallbackButtons(new string[] {"IncCount", "DecCount", "StaticDoPrint"}, new string[] {"Increment Counter", "Decrement Counter", "Print Current value"})]
    [Space]
    [Header("Can provide custom text for buttons")]
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
