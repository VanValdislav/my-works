#include <iostream>
using namespace std;
class DArray
{
    int* Array;
    int count;
    int Maxcount;
public:
    DArray(int n)
    {
        cout << "Constructor" << endl;
        count = n;
        Maxcount = 1.5 * count;
        Array = new int[Maxcount];
        for (int i = 0; i < count; i++)
            Array[i] = 0;
    }
    DArray(int n, int value)
    {
        cout << "Constructor" << endl;
        count = n;
        Maxcount = 1.5 * count;
        Array = new int[Maxcount];
        for (int i = 0; i < count; i++)
            Array[i] = value;
    }
    DArray(const DArray& A)
    {
        cout << "Constructor copy" << endl;
        count = A.count;
        Maxcount = A.Maxcount;
        Array = new int[Maxcount];
        for (int i = 0; i < count; i++)
            Array[i] = A.Array[i];
    }
    DArray(DArray&& A) noexcept :count(A.count), Maxcount(A.Maxcount)
    {
        cout << "Constructor peremechenia" << endl;
        Array = A.Array;
        A.Array = nullptr;
        A.count = 0;
        A.Maxcount = 0;
    }
    void Add(DArray A)
    {

        if (count > A.count)
            for (int i = 0; i < A.count; i++)
                Array[i] += A.Array[i];
        else
            for (int i = 0; i < count; i++)
                Array[i] += A.Array[i];

    }
    DArray()
    {
        cout << "Constructor" << endl;
        count = Maxcount = 0;
        Array = NULL;
    }
    ~DArray()
    {
        cout << "Destructor" << endl;
        if (Maxcount != 0)
            delete[]Array;
    }
    DArray(int* arry,int size)
    {
        cout << "Constructor  Object" << endl;
        count = size;
        Maxcount = size;
        Array = new int[Maxcount];
        for (int i = 0; i < count; i++)
            Array[i] = arry[i];

    }
    void Print();
    int GetCount()
    {
        return count;
    }
    int GetMaxcount()
    {
        return Maxcount;
    }
    void SetMaxCount(int maxcount)
    {
        if (maxcount > Maxcount)
        {
            int* temp = new int[maxcount];
            Maxcount = maxcount;
            for (int i = 0; i < count; i++)
                temp[i] = Array[i];
            delete[]Array;
            Array = temp;
        }
        else
            if (maxcount < Maxcount)
            {

            }

    }
    

    DArray operator+(DArray A);
    DArray operator+(int a);
    friend DArray operator+(int a, DArray A);
    DArray operator=(DArray A);
    //DArray operator=(DArray&& A);
    DArray operator++();
    DArray operator++(int);
    int& operator[](int i);
    DArray operator--();
    DArray operator--(int);
    DArray operator*(DArray& A);
    DArray operator*(int a);
    friend DArray operator*(int a, DArray A);
    
};

void DArray::Print()
{
    cout << Array << endl;
    if (count > 0)
    {
        for (int i = 0; i < count; i++)
            cout << Array[i] << " ";
        cout << endl;
    }
    else
        cout << "Empty" << endl;
}
DArray DArray::operator+(DArray A)
{

    if (count > A.count)
    {
        DArray temp = *this;
        for (int i = 0; i < A.count; i++)
            temp.Array[i] += A.Array[i];
        return temp;
    }
    else
    {
        DArray temp = A;
        for (int i = 0; i < count; i++)
            temp.Array[i] += this->Array[i];
        return temp;
    }

}
DArray DArray::operator=(DArray A)
{
    if (this != &A)
    {
        delete[]Array;
        count = A.count;
        Maxcount = A.Maxcount;
        Array = new int[Maxcount];
        for (int i = 0; i < count; i++)
        {
            Array[i] = A.Array[i];

        }
    }
    return *this;
}
DArray DArray::operator+(int a)
{
    DArray temp = *this;
    for (int i = 0; i < count; i++)
        temp.Array[i] += a;
    return temp;


}
DArray operator+(int a, DArray A)
{
    DArray temp = A;
    for (int i = 0; i < temp.count; i++)
        temp.Array[i] += a;
    return temp;
}
DArray DArray::operator++()
{
    for (int i = 0; i < count; i++)
        Array[i] ++;
    return *this;

}
DArray DArray::operator++(int)
{
    DArray temp = *this;
    for (int i = 0; i < count; i++)
        Array[i] ++;
    return temp;

}
DArray DArray::operator--()
{
    for (int i = 0; i < count; i++)
        Array[i] --;
    return *this;
}
DArray DArray::operator--(int) 
{
    DArray temp = *this;
    for (int i = 0; i < count; i++)
        Array[i] --;
    return temp;
}
DArray DArray::operator*(DArray& A) 
{
    if (count > A.count)
    {
        DArray temp = *this;
        for (int i = 0; i < A.count; i++)
            temp.Array[i] *= A.Array[i];
        return temp;
    }
    else
    {
        DArray temp = A;
        for (int i = 0; i < count; i++)
            temp.Array[i] *= this->Array[i];
        return temp;
    }
}
DArray DArray::operator*(int a) 
{
    DArray temp = *this;
    for (int i = 0; i < count; i++)
        temp.Array[i] *= a;
    return temp;

}
DArray operator*(int a, DArray A) 
{
    DArray temp = A;
    for (int i = 0; i < temp.count; i++)
        temp.Array[i] *= a;
    return temp;

}  


int& DArray::operator[](int i)
{
    if (i >= 0 && i < count)
        return Array[i];
    else
        cout << "Index out of range";
}
int main()
{
    
    int mass[4]{1,2,3,4};
    DArray D(mass,4);
    DArray A(10,5), B(11, 6), C;
    int a = 5;
    // // DArray F = B;
    // DArray G(6,8);
    //(A++).Print();
    //A[2] = 7;
    //A[5] = 10;
    (A).Print();
    //// B.Print();
    //// C.Print();
    //// //F.Print();
    //// G.Print();
    // C = B + 5;
    // C.Print();
    // C= 5 + C;
    // C.Print();
    //  // B.Print();
    //// /*B.Print();
    //// A.Print();*/
    /////* DArray* E;
    //// E = new DArray(15,3);
    //// E->Print();
    //// delete E;*/
    // 


    /*Числло * на вектор ,перегрузить -- ,*/
}

/*если класс опредделяем как шаблон класса то все методы класса становяться шаблон функций */
/*Порядок выполнения в 1 пункте важно !*/