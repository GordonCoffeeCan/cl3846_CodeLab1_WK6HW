using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UtilScript : MonoBehaviour {

	public static void WriteStringToFile(string path, string fileName, string content) {
        StreamWriter _sw = new StreamWriter(path + "/" + fileName);

        _sw.WriteLine(content);

        _sw.Close();

    }

    public static Vector3 CloneVector3(Vector3 _vec) {
        return new Vector3(_vec.x, _vec.y, _vec.z);
    }

    public static Vector3 CloneModVector3(Vector3 vec, float xMod, float yMod, float zMod) {
        return new Vector3(vec.x + xMod, vec.y + yMod, vec.z + zMod);
    }
}
