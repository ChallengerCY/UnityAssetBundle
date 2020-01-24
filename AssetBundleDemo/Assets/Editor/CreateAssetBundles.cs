using UnityEditor;
using System.IO;

/// <summary>
/// 创建AssetBundle文件
/// </summary>
public class CreateAssetBundles
{
    /// <summary>
    /// 创建mac系统用的AssetBundle
    /// </summary>
    [MenuItem("Assets/Build AssetBundles/macOS")]
    static void BuildMacOsAllAssetBundles()
    {
        //设置assetBundle的根路径
        string assetBundleDirectory = "Assets/StreamingAssets/AssetBundles/MacOS";
        //判断文件夹是否存在
        if(!Directory.Exists(assetBundleDirectory))
        {
            //如果不存在则创建文件夹
            Directory.CreateDirectory(assetBundleDirectory);
        }
        
        //调用Assetbundle构建API 
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
            BuildAssetBundleOptions.None, 
            BuildTarget.StandaloneOSX);
        
        AssetDatabase.Refresh();
    }
    
    /// <summary>
    /// 创建android系统用的Assetbundle
    /// </summary>
    [MenuItem("Assets/Build AssetBundles/android")]
    static void BuildAndroidAllAssetBundles()
    {
        //设置assetBundle的根路径
        string assetBundleDirectory = "Assets/StreamingAssets/AssetBundles/Android";
        //判断文件夹是否存在
        if(!Directory.Exists(assetBundleDirectory))
        {
            //如果不存在则创建文件夹
            Directory.CreateDirectory(assetBundleDirectory);
        }
        
        //调用Assetbundle构建API 
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
            BuildAssetBundleOptions.None, 
            BuildTarget.Android);
        
        AssetDatabase.Refresh();
    }
    
    /// <summary>
    /// 创建ios系统用的Assetbundle
    /// </summary>
    [MenuItem("Assets/Build AssetBundles/ios")]
    static void BuildIosAllAssetBundles()
    {
        //设置assetBundle的根路径
        string assetBundleDirectory = "Assets/StreamingAssets/AssetBundles/Ios";
        //判断文件夹是否存在
        if(!Directory.Exists(assetBundleDirectory))
        {
            //如果不存在则创建文件夹
            Directory.CreateDirectory(assetBundleDirectory);
        }
        
        //调用Assetbundle构建API 
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
            BuildAssetBundleOptions.None, 
            BuildTarget.iOS);
        
        AssetDatabase.Refresh();
    }
    
    
}