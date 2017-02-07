using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelBodyInfo : MonoBehaviour {
    public class Data
    {
        public Vector3 position;
        public Vector3 scale;
        public Vector3 angles;

    }

    public Data head {
        get {
            Data data = new Data();
            data.position = new Vector3(0.005f, 0.07f, 0.035f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, 180, 0);
            return data;
        }
    }
    public Data leftHead {
        get
        {
            Data data = new Data();
            
        
            data.position = new Vector3(0.0f, 0.0f, 0f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, -90, 90);
            return data;
        }
    }

    public Data rightHead
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0.0f, 0.0f, 0f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, 90, -90);
            return data;
        }
    }
    public Data hips
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0.005f, -0.03f, 0);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, 180, 0);
            return data;
        }
    }

    public Data leftFoot
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0.01f, 0.02f, 0.02f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(135f, 30f, 20f);
            return data;
        }


    }
    public Data rightFoot
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(-0.01f, 0.02f, 0.01f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(120, 335, 340);
            return data;
        }

    }

    public Data leftUpLeg
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(-0, 0.12f, 0);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(180f, 0, 0);
            return data;
        }

    }
    public Data rightUpLeg
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0, 0.12f, 0);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(180, 0, 0);
            return data;
        }
    }

    public Data leftLeg
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0, 0.1f, 0);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(180, 0, 0);
            return data;
        }
    }
    public Data rightLeg
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0, 0.1f, 0);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(180, 0, 0);
            return data;
        }
    }

    public Data spine1
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0.005f, 0.125f, 0.0f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, 180, 0);
            return data;
        }

    }
    public Data spine2
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0.005f, -0.12f, 0.0025f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, 180, 0);
            return data;
        }
    }


    public Data leftForeArm
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0, 0.08f, 0.0f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, -90, 90);

            return data;
        }

    }
    public Data rightForeArm
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0, 0.08f, 0.0f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(180, -90, 90);
            return data;
        }

    }

    public Data leftArm
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0.0f, 0.08f, 0.0f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(0, -90, 90);
            return data;
        }
    }
    public Data rightArm
    {
        get
        {
            Data data = new Data();
            data.position = new Vector3(0, 0.08f, 0.003f);
            data.scale = new Vector3(0.01f, 0.01f, 0.01f);
            data.angles = new Vector3(180f, -90f, 90f);

            return data;
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
