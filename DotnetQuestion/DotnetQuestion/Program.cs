﻿// See https://aka.ms/new-console-template for more information
using DotnetQuestion.Example;

Console.WriteLine("Hello, World!");
Ex3.ClassA clsB = new Ex3.ClassB();
clsB.Foo();

//К примеру 4
//var obj = new Ex4();
//obj.Foo();
//obj.Foo();
//obj.Bar();
//obj.Bar();

//К примеру 5
//var ex5 = new Ex5();
//ex5.Foo();
//ex5.Foo();
//ex5.Bar();
//ex5.Bar();

//var ex6 = new Ex6();
//ex6.First();
//ex6.Second();
//ex6.Third();

var ex6a = new Ex6a();
Console.WriteLine(ex6a.FOO());

var ex6b = new Ex6b();
Console.WriteLine(ex6b.Foo().Text);