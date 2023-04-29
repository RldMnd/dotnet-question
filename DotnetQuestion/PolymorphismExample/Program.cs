/*
 * Вопрос: Что выведет код в каждом из случаев?
 * Почему Print(cc) и cc.Print() дают разный результат?
 */

I ib = new B();
A ab = new B();
B bb = new B();

I ic = new C();
A ac = new C();
B bc = new C();
C cc = new C();

Print(ib);
Print(ab);
Print(bb);

Print(ic);
Print(ac);
Print(bc);
Print(cc);

ic.Print();
ac.Print();
bc.Print();
cc.Print();

void Print(I i)
{
    i.Print();
}

interface I
{
    void Print();
}

abstract class A : I
{
    public virtual void Print()
    {
        Console.WriteLine("class A");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("class B");
    }
}

class C : B
{
    public new void Print()
    {
        Console.WriteLine("class C");
    }
}