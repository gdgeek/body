using UnityEngine;
using System.Collections;
using GDGeek;
[ExecuteInEditMode]
public class VoxelBodyBuilder : MonoBehaviour {
	public bool _refresh = false;
	public VoxelBody _body;
    public VoxelBodyFileSeek _file;
    public VoxelBodyInfo _info;

    void mount(Material material, GameObject parent, TextAsset file, Vector3 position, Vector3 scale, Vector3 angles, int reversal = 0) {
        GameObject obj = null;
        Transform transform = parent.transform.Find("Mount");
        if (transform != null)
        {
            GameObject.DestroyImmediate(transform.gameObject);
        }
        obj = new GameObject("Mount");

        var br = VoxelReader.ReadFromFile(file);

        VoxelMaker.Building(obj, br, material, reversal);

        obj.transform.parent = parent.transform;

        obj.transform.localPosition = position;
        obj.transform.localScale = scale;
        obj.transform.localEulerAngles = angles;
    }
    void mount(Material material, GameObject parent, TextAsset file, VoxelBodyInfo.Data data, int reversal = 0){
        this.mount(material, parent, file, data.position, data.scale, data.angles, reversal);
    }
    void head(Material material)
    {
        mount(material,
              _body._head, _file._head,
              _info.head);/*
              new Vector3(0.005f, 0.07f, 0.035f),
              new Vector3(0.01f, 0.01f, 0.01f),
              new Vector3(0, 180, 0)
              );*/
   
    }

    void leftHead(Material material)
    {
        mount(material,
        _body._leftHand, _file._hand,
        _info.leftHead/*
        new Vector3(0.0f, 0.0f, 0f),
        new Vector3(0.01f, 0.01f, 0.01f),
        new Vector3(0, -90, 90)*/
        );


    }

    void rightHand(Material material)
    {
        mount(material,
            _body._rightHand, _file._hand,
            _info.rightHead,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    void hip(Material material)
    {
        mount(material,
            _body._hips, _file._hip,
            _info.hips/*
            new Vector3(0.005f, -0.03f, 0),
            new Vector3(0.01f, 0.01f, 0.01f),
            new Vector3(0, 180, 0)*/
            );

    }

    void leftFoot(Material material)
    {
        mount(material,
            _body._leftFoot, _file._foot,
          _info.leftFoot
            );

    }
    void rightFoot(Material material)
    {
        mount(material,
            _body._rightFoot, _file._foot,
            _info.rightFoot,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    void leftUpLeg(Material material)
    {
        mount(material,
            _body._leftUpLeg, _file._upleg,
          _info.leftUpLeg
            );

    }
    void rightUpLeg(Material material)
    {
        mount(material,
            _body._rightUpLeg, _file._upleg,
           _info.rightUpLeg,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    void leftLeg(Material material)
    {
        mount(material,
            _body._leftLeg, _file._leg,
          _info.leftLeg
            );

    }
    void rightLeg(Material material)
    {
        mount(material,
            _body._rightLeg, _file._leg,
         _info.rightLeg,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    void spine1(Material material)
    {
        mount(material,
            _body._spine1, _file._spine2,
          _info.spine1
            );

    }
    void spine2(Material material)
    {
        mount(material,
            _body._spine2, _file._spine,
          _info.spine2
            );

    }


    void leftForeArm(Material material)
    {
        mount(material,
            _body._leftForeArm, _file._forearm,
          _info.leftForeArm
            );

    }
    void rightForeArm(Material material)
    {
        mount(material,
            _body._rightForeArm, _file._forearm,
           _info.rightForeArm,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    void leftArm(Material material)
    {
        mount(material,
            _body._leftArm, _file._arm,
            _info.leftArm
            );

    }
    void rightArm(Material material)
    {
        mount(material,
            _body._rightArm, _file._arm,
           _info.rightArm,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    void init()
    {


#if UNITY_EDITOR
        if (_material == null)
        {

            _material = UnityEditor.AssetDatabase.LoadAssetAtPath<Material>("Assets/GdGeek/Media/Voxel/Material/VoxelMesh.mat");
        }
       /* if (_head == null)
        {
            Debug.Log("!!!!!");
            Debug.Log("!!!?!!"+ UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/usa/arm.bytes"));
            _head = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Voxer/Voxel/Voxel/usa/arm.bytes");
        }*/
#endif
    }

    public Material _material = null;
    void Update () {
		if (_refresh) {
            init();
            var mat = _material;

            _body = this.gameObject.GetComponent<VoxelBody> ();
            _file = this.gameObject.GetComponent<VoxelBodyFileSeek>();
            _info = this.gameObject.GetComponent<VoxelBodyInfo>();
            if (_info == null) {
                _info = this.gameObject.AddComponent<VoxelBodyInfo>();
            }
            head(mat);
            leftHead(mat);
            rightHand(mat);
            hip(mat);
            leftFoot(mat);
            rightFoot(mat);
            leftUpLeg(mat);
            rightUpLeg(mat);
            leftLeg(mat);
            rightLeg(mat);
            spine1(mat);
            spine2(mat);
            leftForeArm(mat);
            rightForeArm(mat);
            leftArm(mat);
            rightArm(mat);
            _refresh = false;
		}

	}
	

}
