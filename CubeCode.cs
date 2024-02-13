using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCode : MonoBehaviour

{

    //obje çarptığında olacaklar(sert çarpma-collision)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("carpti");

        //obje Cube_2 objesine çarpınca Cube_2 nesnesine olacakların yazıldığı kod
        if (collision.gameObject.name == "Cube_2")
        {
            collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    //obje çarpma bittiginde olacak olanlar (sert çarpma-collision)
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("carpma bitti");
    }

    //obje carpma anında olacak olanlar (sert çarpma-collision)
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("carpıyor");
    }




    //COllision mantıgının aynısı trigger yumusak carma içinde geçerli tek farkı nesneler carparken birbirlerinin içinden geçiyor

    /*//Collider burada çarpılan nesneyi temsil ediyor 
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("yumuşak carpti");
        //çarpılan nesne log döndürür
        Debug.Log(collider.gameObject.name+ "cube2 çarpma");

        if (collider.gameObject.name == "Cube_2") {
            collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("yumuşak carpma bitti");
    }

    private void OnTriggerStay(Collider collider)
    {
        Debug.Log("yumuşak carpıyor");
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// NOTLAR

//nesnelerde çarpışma olabilmesi için 2 temel kural vardır.
//Çarpışan tüm nesnelerde "collider" komponenti olmalıdır.
//çarpışan nesnelerin en az birinde "Rigidbody" komponenti olmalıdır.

//sert çarpıışma (collision)----yolda yürümek
//yumuşak çarpışma(Trigger)---suya basınca ayağımızın içine girmesi

//OnCollisionEnter ---> ilk çarpışmada bir kez çalışır
//OnCollisionExit --> çarpışma bittiğinde bir kez çalışır
//OnCollisionStay --> çarpışma devam ederken sürekli çalışır

/*Unity'de Rigidbody, bir nesnenin fiziksel davranışlarını simüle etmek için kullanılan bir bileşendir. 
 * Bir oyun nesnesine Rigidbody eklemek, nesnenin fizik yasalarına uygun olarak hareket etmesini sağlar. 
 * Örneğin, yerçekimi etkisi altında düşme, çarpışmaları işleme alma, ivmelenme ve hızlanma gibi fiziksel etkileri simüle edebilirsiniz.
 * 
 * Collider, Unity'de kullanılan bir bileşendir ve nesnelerin çarpışmalarını algılamak için kullanılır. 
 * Oyun nesnelerinin etkileşimli alanlarını belirlemek için kullanılır. 
 * Collider bileşenleri, nesnelerin fiziksel varlıklarını temsil eder ve bu nesnelerin birbiriyle etkileşime girmesini sağlar.*/

/*Rigidbody nesnenin fiziksel davranışlarını kontrol ederken Collider nesneler arasındaki 
 * çarpışmaları algılar ve bu çarpışmaların fiziksel etkileşimlerini yönetir. 
 * Bu iki bileşen genellikle birlikte kullanılır ve Unity oyun dünyasındaki fiziksel etkileşimlerin modellenmesinde önemli bir rol oynarlar.*/
