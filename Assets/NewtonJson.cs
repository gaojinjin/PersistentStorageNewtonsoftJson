using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;


public class NewtonJson : MonoBehaviour
{
    public List<Book> books = new List<Book>();
    void Start()
    {
        Book book0 = new Book();
        book0.id = 0;
        book0.name = "¶þ¾Ë";
        book0.author = "°ÂÌØÂê";
        Book book1 = new Book();
        book0.id = 11;
        book0.name = "¶þ¾ËÂè";
        book0.author = "µÏåÈ";
        books.Add(book0);
        books.Add(book1);
        string booksInfo = JsonConvert.SerializeObject(books,Formatting.Indented);
        Debug.Log(booksInfo);
        string filePath = Application.streamingAssetsPath + "/" + "newtonjson.json";
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }
        File.WriteAllText(filePath, booksInfo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Book {
    public int id;
    public string name;
    public string author;
}