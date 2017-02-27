using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class ZipTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		string json = "gogogissiisisflkefal;kfjlafkj";

		GDGeek.Cache.HasKey ("test");
		GDGeek.Cache.SetBytes ("test", GDGeek.ZipFile.Compression(Encoding.UTF8.GetBytes(json)));
		byte[] ret = GDGeek.Cache.GetBytes ("test");
		Debug.Log (Encoding.UTF8.GetString(GDGeek.ZipFile.Decompressed(ret)));
		//byte[] ret  = GDGeek.Cache.GetBytes ("test");
		//GDGeek.Cache.Set ();
		//PlayerPrefs.HasKey
		/*
		var compressed = GDGeek.ZipFile.CompressBytes(System.Convert.FromBase64String(json));


		FileInfo mydir = new FileInfo( GDGeek.ZipFile.GetPath () + "test.zip");
		Debug.Log (mydir.Exists);
		GDGeek.ZipFile.CompressToFile (json, GDGeek.ZipFile.GetPath () + "test.zip");
		string json2 = GDGeek.ZipFile.DecompressFromFile (GDGeek.ZipFile.GetPath () + "test.zip");
		//Assert.AreEqual (json, json2);
		Debug.Log (json2);


		//var comp = GDGeek.ZipFile.Compression ("abc");

		//Debug.Log (comp);
		//Debug.Log (GDGeek.ZipFile.Decompressed(comp));
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
