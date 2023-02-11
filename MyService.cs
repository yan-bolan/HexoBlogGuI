using ChiSaTo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class MyService
    {
        private readonly IConfiguration configuration;

        public MyService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string getBlogAddr()
        {
            return Settings1.Default.BlogCateLog==null ? configuration.GetSection("BlogCateLog").Value : Settings1.Default.BlogCateLog;
               //configuration.GetSection("BlogCateLog").Value;
        }

        internal string getConnstr(string db_type)
        {
            return configuration.GetSection(db_type).Value;
        }

        public string getmdEditor()
        {
            return configuration.GetSection("editor").Value; 
        }
    }
    public static class ServiceProviderFactory
    {
        public static IServiceProvider ServiceProvider { get; }

        /// <summary>
        /// 类似于几种单例模式；抢占式；
        /// https://www.cnblogs.com/michaelxu/archive/2007/03/29/693401.html
        /// https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
        //1、静态构造函数既没有访问修饰符，也没有参数。因为是.NET调用的，所以像public和private等修饰符就没有意义了。

        //2、是在创建第一个类实例或任何静态成员被引用时，.NET将自动调用静态构造函数来初始化类，也就是说我们无法直接调用静态构造函数，也就无法控制什么时候执行静态构造函数了。

        //3、一个类只能有一个静态构造函数。

        //4、无参数的构造函数可以与静态构造函数共存。尽管参数列表相同，但一个属于类，一个属于实例，所以不会冲突。

        //5、最多只运行一次。

        //6、静态构造函数不可以被继承。

        //7、如果没有写静态构造函数，而类中包含带有初始值设定的静态成员，那么编译器会自动生成默认的静态构造函数。
        /// </summary>
        static ServiceProviderFactory()
        {
            // 1. crete a service collection for DI
            var serviceCollection = new ServiceCollection();
            // 2. Build a configuration 
            IConfiguration configuration;
            configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName).AddJsonFile("appsettings.json").Build(); ;
            //3. Add the configuration to the service collection 
            serviceCollection.AddSingleton(configuration);
            serviceCollection.AddSingleton<MyService>();
            //serviceCollection.AddLogging();
            //serviceCollection.AddWorkflow();
            // start service
              ServiceProvider = serviceCollection.BuildServiceProvider();

        }
    }

}
