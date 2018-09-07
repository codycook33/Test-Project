using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCube : MonoBehaviour {

	public MeshFilter filter;
	public Vector3[] verts;
	public int[] tris;








	// Use this for initialization
	void Start () {
			
		Mesh myNewMesh = new Mesh();
		myNewMesh.vertices = verts;
		myNewMesh.triangles = tris;

		filter.mesh = myNewMesh;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
