using GDGeek;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelBodyRuntime : MonoBehaviour {

    public VoxelBody _body;
    public VoxelBodyFileSeek _file;
    public VoxelBodyInfo _info;
    public Material _material = null;

	Task mount(Material material, GameObject parent, TextAsset file, Vector3 position, Vector3 scale, Vector3 angles, int reversal = 0)
    {
		Task task = new Task ();
		TaskManager.PushFront (task, delegate() {
			
		
			GameObject obj = null;
			Transform transform = parent.transform.Find ("Mount");
			if (transform != null) {
				GameObject.DestroyImmediate (transform.gameObject);
			}
			obj = new GameObject ("Mount");

			var br = VoxelReader.ReadFromFile (file);

			VoxelMaker.Building (obj, br, material, reversal);

			obj.transform.parent = parent.transform;

			obj.transform.localPosition = position;
			obj.transform.localScale = scale;
			obj.transform.localEulerAngles = angles;
		});
		return task;
			
    }
    Task mount(Material material, GameObject parent, TextAsset file, VoxelBodyInfo.Data data, int reversal = 0)
    {
        return this.mount(material, parent, file, data.position, data.scale, data.angles, reversal);
    }
    Task head(Material material)
    {
		
		return  mount(material,
              _body._head, _file._head,
              _info.head);

    }

    Task leftHead(Material material)
    {
		return mount(material,
        _body._leftHand, _file._hand,
        _info.leftHead
        );


    }

    Task rightHand(Material material)
    {
        return mount(material,
            _body._rightHand, _file._hand,
            _info.rightHead,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    Task hip(Material material)
    {
        return mount(material,
            _body._hips, _file._hip,
            _info.hips/*
            new Vector3(0.005f, -0.03f, 0),
            new Vector3(0.01f, 0.01f, 0.01f),
            new Vector3(0, 180, 0)*/
            );

    }

    Task leftFoot(Material material)
    {
		return  mount(material,
            _body._leftFoot, _file._foot,
          _info.leftFoot
            );

    }
    Task rightFoot(Material material)
    {
        return mount(material,
            _body._rightFoot, _file._foot,
            _info.rightFoot,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    Task leftUpLeg(Material material)
    {
		return  mount(material,
            _body._leftUpLeg, _file._upleg,
          _info.leftUpLeg
            );

    }
    Task rightUpLeg(Material material)
    {
		return mount(material,
            _body._rightUpLeg, _file._upleg,
           _info.rightUpLeg,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    Task leftLeg(Material material)
    {
		return mount(material,
            _body._leftLeg, _file._leg,
          _info.leftLeg
            );

    }
    Task rightLeg(Material material)
    {
		return mount(material,
            _body._rightLeg, _file._leg,
         _info.rightLeg,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    Task spine1(Material material)
    {
		return mount(material,
            _body._spine1, _file._spine2,
          _info.spine1
            );

    }
    Task spine2(Material material)
    {
		return mount(material,
            _body._spine2, _file._spine,
          _info.spine2
            );

    }


    Task leftForeArm(Material material)
    {
		return  mount(material,
            _body._leftForeArm, _file._forearm,
          _info.leftForeArm
            );

    }
    Task rightForeArm(Material material)
    {
		return mount(material,
            _body._rightForeArm, _file._forearm,
           _info.rightForeArm,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }

    Task leftArm(Material material)
    {
       return mount(material,
            _body._leftArm, _file._arm,
            _info.leftArm
            );

    }
   Task rightArm(Material material)
    {
       return  mount(material,
            _body._rightArm, _file._arm,
           _info.rightArm,
            (int)(VoxelStruct.ReversalAxis.XAxis)
            );

    }



    // Use this for initialization
    void Start () {

       
        var mat = _material;

        _body = this.gameObject.GetComponent<VoxelBody>();
        _file = this.gameObject.GetComponent<VoxelBodyFileSeek>();
        _info = this.gameObject.GetComponent<VoxelBodyInfo>();
        if (_info == null)
        {
            _info = this.gameObject.AddComponent<VoxelBodyInfo>();
        }

		TaskList  tl = new TaskList();
		tl.push(head(mat));
		tl.push(leftHead(mat));
		tl.push(rightHand(mat));
		tl.push(hip(mat));
		tl.push(leftFoot(mat));
		tl.push(rightFoot(mat));
		tl.push(leftUpLeg(mat));
		tl.push(rightUpLeg(mat));
		tl.push(leftLeg(mat));
		tl.push(rightLeg(mat));
		tl.push(spine1(mat));
		tl.push(spine2(mat));
		tl.push(leftForeArm(mat));
		tl.push(rightForeArm(mat));
		tl.push(leftArm(mat));
		tl.push(rightArm(mat));
		TaskManager.Run (tl);


        // _file._head

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
