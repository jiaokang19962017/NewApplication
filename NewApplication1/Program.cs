//使用using来引入命名空间
//解决命名冲突
using System;

namespace NewApplication1
{
    class Program
    {
        static void Main(string[] args)//应用程序的一个入口:main方法,方法名建议首字母大写
        {
            Console.WriteLine();//快捷键:cw+2次tab键
            Console.WriteLine("hello world");//屏幕输出
            Console.ReadLine();//输入
            Console.WriteLine("我叫{0},今年{1}", "焦康", 21);  //占位符 
            //string name = Console.ReadLine();
            //string age = Console.ReadLine();
            //Console.WriteLine("我的名字是:"+name+",我的年龄是:"+age+"岁");  //
            Console.WriteLine("这个值是:{0:c3}",500);//数字格式化,c后面是几就保留几位小数
            Console.ReadLine();//输入

        }
    }


}
