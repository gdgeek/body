using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class VoxelBodyFileSeek : MonoBehaviour {
    public bool _refresh = false;
    public TextAsset _head = null;
    public TextAsset _hand = null;
    public TextAsset _hip = null;
    public TextAsset _arm = null;
    public TextAsset _foot = null;
    public TextAsset _forearm = null;
    public TextAsset _leg = null;
    public TextAsset _spine = null;
    public TextAsset _spine2 = null;
    public TextAsset _upleg = null;


   

    void init()
    {


#if UNITY_EDITOR
        if (_material == null)
        {

            _material = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>("Assets/GdGeek/Media/Voxel/Material/VoxelMesh.mat");
        }
        if (_head == null)
        {
            _head = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/head.bytes");
        }


        if (_hand == null)
        {
            _hand = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/hand.bytes");
        }



        if (_hip == null)
        {
            _hip = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/hip.bytes");
        }


        if (_arm == null)
        {
            _arm = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/arm.bytes");
        }
        if (_foot == null)
        {
            _foot = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/foot.bytes");
        }

        if (_forearm == null)
        {
            _forearm = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/forearm.bytes");
        }

        if (_leg == null)
        {
            _leg = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/leg.bytes");
        }

        if (_spine == null)
        {
            _spine = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/spine.bytes");
        }


        if (_spine2 == null)
        {
            _spine2 = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/spine2.bytes");
        }


        if (_upleg == null)
        {
            _upleg = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/upleg.bytes");
        }



#endif
}

    public Material _material = null;
    void Update()
    {
        if (_refresh)
        {
            init();
            _refresh = false;
        }

    }


}
