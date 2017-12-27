﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("Apple");
            list.AddLast("Banana");
            list.AddLast("Lemon");

            LinkedListNode<string> node = list.Find("Banana");
            LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

            // 새 Grape 노드를 Banana 노드 뒤에 추가
            list.AddAfter(node, newNode);

            // 리스트 출력
            list.ToList().ForEach(p => Console.WriteLine(p));

            // Enumerator를 이용한 리스트 출력
            //foreach (var m in list)
            //{
            //    Console.WriteLine(m);
            //}
        }
    }
}
