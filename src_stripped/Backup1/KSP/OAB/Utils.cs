// Decompiled with JetBrains decompiler
// Type: KSP.OAB.Utils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  internal class Utils
  {
    private const bool ENABLE_NOISY_OAB_FUNCTIONS = false;
    private const bool ENABLE_NOISY_OAB_FUNCTION_ASSEMBLY_DUMPING = false;
    private static int _trackingDepth;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartValid(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsNodeValid(IObjectAssemblyPartNode partNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsNotDestroyed(Object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPartIconNameFromPartName(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T InstantiateLocateExistingPrefabObject<T>(T prefab) where T : Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetLayerRecursive(Transform obj, int layer, int ignoreLayersMask = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetLayerRecursive(GameObject obj, int layer, int ignoreLayersMask = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ArrayIndexOf<T>(T[] array, T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T AddUnique<T>(IList<T> list, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject GetChild(GameObject obj, string childName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GetBoundsHelper(IObjectAssemblyPart part, ref Bounds totalbounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetBoundsHelper(IObjectAssembly assembly, ref Bounds totalbounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bounds GetBounds(IObjectAssemblyPart rootPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ObjectAssemblyPart GetOABPartFromCollider(Collider col, IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MessageUser(string unlocalizedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BeNoisyStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BeNoisyEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DumpSymmetrySets(
      string action,
      IReadOnlyCollection<SymmetrySet> symmetrySets)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Utils() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Utils() => throw null;
  }
}
