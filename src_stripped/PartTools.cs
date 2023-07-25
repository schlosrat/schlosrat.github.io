// Decompiled with JetBrains decompiler
// Type: PartTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("KSP/Part Tools")]
public class PartTools : MonoBehaviour
{
  public string modelName;
  public string filePath;
  public string filename;
  public string fileExt;
  public bool copyTexturesToOutputDirectory;
  public bool autoRenameTextures;
  public bool convertTextures;
  public bool production;
  public PartTools.TextureFormat textureFormat;
  public Shader shaderUnlit;
  public Shader shaderDiffuse;
  public Shader shaderSpecular;
  public Shader shaderBumped;
  public Shader shaderBumpedSpecular;
  public Shader shaderEmissive;
  public Shader shaderEmissiveSpecular;
  public Shader shaderEmissiveBumpedSpecular;
  public Shader shaderCutout;
  public Shader shaderCutoutBumped;
  public Shader shaderAlpha;
  public Shader shaderAlphaSpecular;
  public Shader shaderUnlitTransparent;
  public int eventSelected;
  public List<PartTools.ModelPartEvent> events;
  public Material material;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetDefaultShaders() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PartTools() => throw null;

  [Serializable]
  public class ModelPartEvent
  {
    public string eventStart;
    public string code;
    public string eventFinish;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModelPartEvent() => throw null;
  }

  public enum TextureFormat
  {
    TGA_Compressed,
    TGA_Uncompressed,
    TGA_Smallest,
    MBM,
    PNG,
    Smallest,
  }
}
