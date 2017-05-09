//使用using来引入命名空间
//解决命名冲突
using System;

namespace NewApplication1
{
    class Program
    {

        /// <summary>
        /// 这是文档注释
        /// </summary>
        /// <param name="args">文档注释</param>
        static void Main(string[] args)//应用程序的一个入口:main方法,方法名建议首字母大写
        {
            Console.WriteLine();//快捷键:cw+2次tab键
            Console.WriteLine("hello world");//屏幕输出
            Console.ReadLine();//输入
            Console.WriteLine("我叫{0},今年{1}", "焦康", 21);  //占位符 
            //string name = Console.ReadLine();
            //int age;
            //int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("我的名字是:" + name + ",我的年龄是:" + age + "岁");  
            Console.WriteLine("这个值是:{0:c3}", 500);//数字格式化,c后面是几就保留几位小数,对于货币单位来说
            Console.ReadLine();//输入
            Console.WriteLine("指定宽度:|{0,10}|",500);//指定宽度
            Console.WriteLine("货币:{0:c3}",500);
            Console.WriteLine("十进制:{0:d3}", 50);//十进制
            Console.WriteLine("定点:{0:f3}", 500.32414);//定点
            Console.WriteLine("常规:{0:g3}", 5.32145);//常规
            Console.WriteLine("十六进制:{0:x}", 500);//十六进制数
            Console.WriteLine("数字:{0:n2}", 12345678.54321);//数字
            Console.WriteLine("百分比:{0:p2}", 0.25414);//百分比
            Console.WriteLine("往返过程:{0:r}", 50.545);//往返过程
            Console.WriteLine("科学计数法:{0:e4}", 12.3456789);//科学计数法

            /*
             这是多行
             注释
             */

            //这是单行注释
            Console.WriteLine("请输入你的名字:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄:");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("你的名字是:{0},你的年龄是:{1}",name,age);


        }
    }


}
