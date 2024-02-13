using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeybordCubeScript : MonoBehaviour
{
    GameObject[] nesneler;
    //bu fonksiyon, oyun nesnesi yaratıldığında ilk çağrılan fonksiyondur. Genellikle bir nesnenin başlangıç durumunu ayarlamak için kullanılır.
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello start");
        //GetComponent metoduna özel olarak başına gameObject yazmadan kullanılabilir
        //objenin MeshRenderer componentine erişilir ve işlem yapılır
        //GetComponent<MeshRenderer>().enabled = false;

        //bir nesneden başka bir nesneye adıyla erişmek için kullanılır 
        //bir nesneden başka nesnelere erişebilmek için GameObject'i g harfi büyük olarak yazmak gerekir
        //GameObject.Find("Capsule").GetComponent<MeshRenderer>().enabled = false;
        //bir nesneden başka bir nesne veya nesnelere tagıyla erişmek için kullanılır
        //GameObject.FindWithTag("Player").GetComponent<MeshRenderer>().enabled = false;
        /*
        nesneler = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject nesne in nesneler)
        {
            nesne.GetComponent<MeshRenderer>().enabled = false;
        }*/
    }

    //oyun nesnelerinin sürekli olarak(kare basına) güncellenmesi için kullanılır.
    // Update is called once per frame
    void Update()
    {

        //sag ok tusuna basildiginda loglara "sağ ok tuşuna basıldı" yazdırır
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("sağ ok tuşuna basıldı");
        }

        //sag ok tusundan parmagını çektiginde calıcak olan kod logalra "sağ ok tuşuna basılması bitti" yazdırır
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("sağ ok tuşuna basılması bitti");
        }

        //sag ok tusuna basıldıgı sürece calısması istenilen notlar loglara "sağ ok tuşuna basılıyor" yazdırır
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("sağ ok tuşuna basılıyor");

            //update fonksiyonu çalışma hızı bilgisayar gücü ile dogru orantılıdır bu nedenle bu nedenle hareket sırasında farklı pc lerde farklı sonuc almamak için Time.deltaTime kullanılır
            //1 * Time.deltaTime --> zamana baglı olarak 1 birim ilerle - parantez içinde sırasıyla x-y-z düzlemlerine edecekleri hareket degerleri girilir
            //-1 * Time.deltaTime şeklinde yazılırsa eksenin tersine gider 
            //Space.World ---> sahnenin eksenine göre hareket saglar
            //transform.Translate(1 * Time.deltaTime, 0, 0,Space.World);

            //cismi x ekseninde döndürme işlemi yapılır
            //transform.Rotate(500 * Time.deltaTime, 0, 0, Space.World);

            //transform metoduna özel olarak başına gameObject yazmadan kullanılabilir
            //gameObject.transform.Rotate(10, 10, 0);

            //objeyi hareket ettirmek için rigidbody componentine erişip nesneler hareket ettirilebilir
            //sahnenin x eksenine göre hareket eder(Vector3.right) eğer objenin x eksenine göre hareket etmesi gerekiyorsa transform kullanılır(transform.right)
            //GetComponent<Rigidbody>().velocity = Vector3.right * 50 * Time.deltaTime;


            //gittikçe hızlanan bir şekilde hareket etmesi için AddForce kullanılır
            GetComponent<Rigidbody>().AddForce(transform.right * 500 * Time.deltaTime);


        }


        //MAUSE İÇİN


        //mousa basildiginda loglara "sol tuşa basıldı" yazdırır
        //0 mousun sol tusunu 1 ise sag tusunu ifade eder
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mousun sol tuşuna basıldı");
        }

        //mousun sol tusundan parmagını çektiginde calıcak olan kod logalra "sağ ok tuşuna basılması bitti" yazdırır
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("mosunun sol tuşuna basılması bitti");
        }

        //mousun sol tusuna basıldıgı sürece calısması istenilen notlar loglara "sağ ok tuşuna basılıyor" yazdırır
        if (Input.GetMouseButton(0))
        {
            Debug.Log("mousun sol tuşuna basılıyor");
        }
    }


}
