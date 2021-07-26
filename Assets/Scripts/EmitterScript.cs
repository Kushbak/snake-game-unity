using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterScript : MonoBehaviour
{ 
   

	public float minX, minZ; // край координат
	public float maxX, maxZ; // край координат


	public float minDist; // дистанция проверки на префабы вокруг
	public GameObject Food; // список префабов
	public Transform platform; // платформа
	public string prefab_tag; // тег для префабов - ставить на все префабы 
 
    void Update()
    { 
    	
		// public void Placement()
		// {
		//  Colliders[] ccc;
		//  bool check;
		//  do {
		//   check = false; // проверка пройдена
		//   float x = Random.Range(minX, maxX) + platform.x; // позиция
		//   float z = Random.Range(minZ, maxZ) + platform.z; // позиция
		//   ccc = Physics.OverlapSphere(new Vector3(x, platform.y, z), minDist); // берем список коллайдеров, которые есть вокруг точки
		//   foreach( Collider col in ccc) // перебираем все найденные коллайдеры
		//    if (c.tag == prefab_tag) check = true; // если хоть один имеет тег префаба - проверка не пройдена
		//  }
		//  while (check); // выйдем только при false - когда вокруг не будет ни одного префаба
		//  Instantiate(Food[Random.Range(0, Food.Length)], new Vector3(x, platform.y, z), transform.rotation); // собственно, ставим сам префаб
		// }
    	 
    }
  
}
