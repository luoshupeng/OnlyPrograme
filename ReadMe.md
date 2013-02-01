# OnlyPrograme

**The example for Runing Programe once.只让程序运行一次的例子。**  
*语言：CSharp*  
*环境：Visual Studio 2010 and DotNetFramework4.0 on Windows 7*

> 主要说明如何使程序只运行一次，主流有两种方法：  
> 1.互斥量方法  
> 2.遍历进程方法  
> 第一种方法简单效率高，但扩展性不强；  
> 第二种方法扩展性好，但效率有点低。  
> 两种方法的取舍，就看需求了，如果需要扩展的，如若程序已经运行则弹出到前面来，就需要
> 使用第二种方法；如果仅仅是为了程序只运行一次，可以简单地使用第一种方法。  

> 另外还演示了如何使用delegate在父窗体和子窗体之间传递数据
