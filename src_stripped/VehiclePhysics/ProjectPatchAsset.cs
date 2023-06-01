// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ProjectPatchAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [CreateAssetMenu(fileName = "New Project Patch Asset", menuName = "Vehicle Physics/Project Patch Asset", order = 520)]
  public class ProjectPatchAsset : ScriptableObject
  {
    [TextArea(4, 10)]
    public string description;
    [Tooltip("The patch will be applied to the files within this path including subfolders")]
    public string path;
    [Tooltip("Extensions to apply the patch to separated by semicolons. An empty value (trailing or duplicate semicolon) includes files without extension.")]
    public string extensions;
    public List<ProjectPatchAsset.Change> changes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectPatchAsset() => throw null;

    [Serializable]
    public class Change
    {
      public string name;
      public string fromGuid;
      public string toGuid;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Change() => throw null;
    }
  }
}
