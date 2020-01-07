using UnityEditor;
using System.IO;

/// <summary>
/// 创建AssetBundle文件
/// </summary>
public class CreateAssetBundles
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        //设置assetBundle的根路径
        string assetBundleDirectory = "Assets/AssetBundles";
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
    }
}