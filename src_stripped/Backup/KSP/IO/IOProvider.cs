// Decompiled with JetBrains decompiler
// Type: KSP.IO.IOProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.UnityConverters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.IO
{
  public class IOProvider
  {
    public const string JSONFileExtension = "json";
    public const string PreviewImageExtension = "jpg";
    public const string PreviewWithTransparancyImageExtension = "png";
    public const string MetadataExtension = "meta";
    public const string GlobalFolder = "Global";
    public const string SavesFolder = "Saves";
    public const string OABAssemblyFolder = "ObjectAssembly";
    public const string OABWorkspacesFolder = "Workspaces";
    public const string OABStockWorkspacesFolder = "StockWorkspaces/OAB";
    private static List<JsonConverter> _cachedConverters;
    private static JsonSerializerSettings _defaultUnitySerializerSettings;
    private static JsonSerializerSettings _dontSerializeKspDefinitionSerializerSettings;
    private static JsonSerializerSettings _dontDeserializeKspStateSerializerSettings;

    public static IConsoleStorage ConsoleStorage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnSerializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<JsonConverter> CreateDefaultConverters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JsonSerializerSettings GetDefaultSerializerSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JsonSerializerSettings GetDontSerializeKspDefinitionSerializerSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JsonSerializerSettings GetDontDeserializeKspStateSerializerSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JsonSerializerSettings CloneSerializerSettings(JsonSerializerSettings original) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IOProvider(Transform parentTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string JoinPath(string parentDirectory, string subDirectory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GameDataPath() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToJson(object toSerialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToJson(object toSerialize, JsonSerializerSettings serializationSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeJsonInto(JToken jToken, object destObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeJsonInto(
      JToken jToken,
      object destObject,
      JsonSerializerSettings serializationSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeJsonInto(string strJson, object destObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeJsonInto(
      string strJson,
      object destObject,
      JsonSerializerSettings serializationSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeJsonInto(byte[] buffer, object destObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeJsonInto(
      byte[] buffer,
      object destObject,
      JsonSerializerSettings serializationSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToBuffer(object toSerialize, out byte[] outputBuffer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToBuffer(
      object toSerialize,
      out byte[] outputBuffer,
      JsonSerializerSettings serializationSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string BufferToString(byte[] buffer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] StringToBuffer(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object FromBuffer(byte[] buffer, System.Type objectType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object FromBuffer(
      byte[] buffer,
      System.Type objectType,
      JsonSerializerSettings serializationSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T FromBuffer<T>(byte[] buffer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T FromBuffer<T>(byte[] buffer, JsonSerializerSettings serializationSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T FromJson<T>(string toDeserialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T FromJson<T>(string toDeserialize, JsonSerializerSettings serializationSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object FromJson(string toDeserialize, System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string PathOfDataType(IOProvider.DataLocation dataType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetFilePath(
      IOProvider.DataLocation location,
      string fileName,
      string extension)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BuildAbsoluteGameDataPathFileName(
      string relativePath,
      out string absolutePath)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BuildRelativeGameDataPathFileName(
      string absolutePath,
      out string relativePath)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveExtension(
      string fileNameOrPath,
      string extensionToRemove,
      bool removeTrailingDot = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ReplaceExtension(string filepath, string newExtension) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetExtentionLettersOnly(string filePath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToJsonFile(string targetFilepath, object toSerialize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToJsonFile(
      string targetFilepath,
      object toSerialize,
      JsonSerializerSettings serializationSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ToJsonFile(
      IOProvider.DataLocation dataType,
      string rawFilename,
      object data,
      string fileExtension = "json")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ToJsonFile(
      IOProvider.DataLocation dataType,
      string rawFilename,
      object data,
      JsonSerializerSettings serializationSettings,
      string fileExtension = "json")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FromJsonFile<T>(string filepath, out T resultObject) where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FromJsonFile<T>(
      IOProvider.DataLocation dataType,
      string filename,
      out T parsedValue)
      where T : class
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FromJsonFile<T>(
      IOProvider.DataLocation dataType,
      string filename,
      JsonSerializerSettings serializationSettings,
      out T parsedValue)
      where T : class
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T FromJsonFile<T>(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T FromJsonFile<T>(string filepath, JsonSerializerSettings serializationSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DeleteJSONFile(IOProvider.DataLocation dataType, string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ReadAllText(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WriteAllText(string path, string contents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WriteAllBytes(string path, byte[] bytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] ReadAllBytes(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool JsonFileExists(IOProvider.DataLocation dataType, string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string CleanFilename(string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FileExists(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeleteFile(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsFileReadonly(string filepath) => throw null;

    public static char DirectorySeparatorCharacter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DirectoryExists(string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeleteDirectory(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDirectoryName(string filepath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetFileName(string filePath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateDirectory(string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] GetFilesNamesFromDirectory(
      string directoryPath,
      string searchPattern,
      bool includeSubDirectories)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOProvider.IGFileInfo[] GetFilesInfosFromDirectory(
      string directoryPath,
      string searchPattern,
      bool includeSubDirectories)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DirectoryInfo[] GetDirectoriesFromDirectory(string directoryPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FillTexture2DWithColor(
      Texture2D texture2d,
      float r,
      float g,
      float b,
      float a)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D GetTexture2DFromPath(string path) => throw null;

    public enum DataLocation
    {
      Global = 0,
      Save = 1,
      OABWorkspaces = 3,
      OABStockWorkspaces = 4,
      OABWorkspacesActiveCampaign = 5,
    }

    private class DontSerializeKSPDefinitionsContractResolver : UnityTypeContractResolver
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override JsonProperty CreateProperty(
        MemberInfo member,
        MemberSerialization memberSerialization)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DontSerializeKSPDefinitionsContractResolver() => throw null;
    }

    private class DontDeserializeKSPStatesContractResolver : UnityTypeContractResolver
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override JsonProperty CreateProperty(
        MemberInfo member,
        MemberSerialization memberSerialization)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DontDeserializeKSPStatesContractResolver() => throw null;
    }

    public class IGFileInfo
    {
      private string _fullName;
      private DateTime _lastWriteTime;
      private DateTime _lastWriteTimeUtc;
      private string _name;
      private string _directoryFullName;

      public string Name
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string FullName
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public DateTime LastWriteTime
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public DateTime LastWriteTimeUtc
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string DirectoryFullName
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IGFileInfo(SerializedSavedGame fileInfo) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IGFileInfo(
        string fileName,
        string fullName,
        DateTime lastWriteTime,
        string directoryFullName)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IGFileInfo(FileInfo fileInfo) => throw null;
    }
  }
}
