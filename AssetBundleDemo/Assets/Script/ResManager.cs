using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ResManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadFromLocalFile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// 从本地加载AssetBundle资源
    /// </summary>
    void LoadFromLocalFile() {
        
        //这里要传入指定AssetBundle所在的位置。
        var myLoadedAssetBundle 
            = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "cube"));
        if (myLoadedAssetBundle == null) {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        //通过对象名字来实例化对象。
        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("cube");
        Instantiate(prefab);
        
      
    }
}
