using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;

[ExecuteInEditMode]
public class VoxelBodySeek : MonoBehaviour {

	const string HipsPattern = @"Hips";
	private Regex hipsRegex_ = null;
	const string LeftUpLegPattern = @"LeftUpLeg";
	private Regex leftUpLeg_ = null;
	const string RightUpLegPattern = @"RightUpLeg";
	private Regex rightUpLeg_ = null;

	const string RightLegPattern = @"RightLeg";
	private Regex rightLeg_ = null;

	const string LeftLegPattern = @"LeftLeg";
	private Regex leftLeg_ = null;

	const string RightFootPattern = @"RightFoot";
	private Regex rightFoot_ = null;

	const string LeftFootPattern = @"LeftFoot";
	private Regex leftFoot_ = null;



	const string Spine1Pattern = @"Spine1";
	private Regex spine1_ = null;

	const string Spine2Pattern = @"Spine2";
	private Regex spine2_ = null;


	const string LeftArmPattern = @"LeftArm";
	private Regex leftArm_ = null;


	const string RightArmPattern = @"RightArm";
	private Regex rightArm_ = null;

	const string LeftForeArmPattern = @"LeftForeArm";
	private Regex leftForeArm_ = null;


	const string RightForeArmPattern = @"RightForeArm";
	private Regex rightForeArm_ = null;


	const string LeftHandPattern = @"LeftHand";
	private Regex leftHand_ = null;


	const string RightHandPattern = @"RightHand";
	private Regex rightHand_ = null;


	const string HeadPattern = @"Head$";
	private Regex head_ = null;


	public VoxelBody _body = null;

	//Use this for initialization
	public bool _refresh = false;



	void makeOut(Transform transform){
		for (int i = 0; i < transform.childCount; ++i) {

			GameObject obj = transform.GetChild (i).gameObject;
			if (hipsRegex_.IsMatch (obj.name)) {
				_body._hips = obj;
			}else if(leftUpLeg_.IsMatch(obj.name)){
				_body._leftUpLeg = obj;
			}else if(rightUpLeg_.IsMatch(obj.name)){
				_body._rightUpLeg = obj;
			}else if(leftLeg_.IsMatch(obj.name)){
				_body._leftLeg = obj;
			}else if(rightLeg_.IsMatch(obj.name)){
				_body._rightLeg = obj;
			}else if(leftFoot_.IsMatch(obj.name)){
				_body._leftFoot = obj;
			}else if(rightFoot_.IsMatch(obj.name)){
				_body._rightFoot = obj;
			}else if(leftArm_.IsMatch(obj.name)){
				_body._leftArm = obj;
			}else if(rightArm_.IsMatch(obj.name)){
				_body._rightArm = obj;
			}else if(leftForeArm_.IsMatch(obj.name)){
				_body._leftForeArm = obj;
			}else if(rightForeArm_.IsMatch(obj.name)){
				_body._rightForeArm = obj;
			}else if(leftHand_.IsMatch(obj.name)){
				_body._leftHand = obj;
			}else if(rightHand_.IsMatch(obj.name)){
				_body._rightHand = obj;
			}else if(head_.IsMatch(obj.name)){
				_body._head = obj;
			}else if(spine1_.IsMatch(obj.name)){
				_body._spine1 = obj;
			}else if(spine2_.IsMatch(obj.name)){
				_body._spine2 = obj;
			}
			makeOut (transform.GetChild(i));
		}

	}
	// Update is called once per frame
	void Update () {
		if (_refresh) {
           // File.Exists();
			hipsRegex_ = new Regex(HipsPattern, RegexOptions.IgnoreCase);
			leftUpLeg_ = new Regex(LeftUpLegPattern, RegexOptions.IgnoreCase);
			rightUpLeg_ = new Regex(RightUpLegPattern, RegexOptions.IgnoreCase);
			leftLeg_ = new Regex(LeftLegPattern, RegexOptions.IgnoreCase);
			rightLeg_ = new Regex(RightLegPattern, RegexOptions.IgnoreCase);
			leftFoot_ = new Regex(LeftFootPattern, RegexOptions.IgnoreCase);
			rightFoot_ = new Regex(RightFootPattern, RegexOptions.IgnoreCase);
			leftArm_ = new Regex(LeftArmPattern, RegexOptions.IgnoreCase);
			rightArm_ = new Regex(RightArmPattern, RegexOptions.IgnoreCase);

			spine1_ = new Regex(Spine1Pattern, RegexOptions.IgnoreCase);
			spine2_ = new Regex(Spine2Pattern, RegexOptions.IgnoreCase);
			leftForeArm_ = new Regex(LeftForeArmPattern, RegexOptions.IgnoreCase);
			rightForeArm_ = new Regex(RightForeArmPattern, RegexOptions.IgnoreCase);
			leftHand_ = new Regex(LeftHandPattern, RegexOptions.IgnoreCase);
			rightHand_ = new Regex(RightHandPattern, RegexOptions.IgnoreCase);
			head_ = new Regex(HeadPattern, RegexOptions.IgnoreCase);
			if (_body == null) {
				_body = this.gameObject.AddComponent<VoxelBody> ();
			}
			makeOut (this.transform);
			_refresh = false;
		}

	}
}
