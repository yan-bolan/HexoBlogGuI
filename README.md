# UI

![这是图片](./UI.png "Magic Gardens")

# 安装

需要

安装Node环境

安装hexo

Git：配置好仓库和推送密钥

安装MarkText

安装Net9.0

# 配置appsetting.json

```json
{
  "editor": "C:\\Program Files\\MarkText\\MarkText.exe",
  "Connstr": "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1 )(PORT = 49161))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); user Id = OT; Password = 123456",
  //"NpgsqlConnstr": "Data Source = postgres://postgres:postgrespw@localhost:55000"
  //"NpgsqlConnstr": "Server=127.0.0.1;Port=55000;Database=postgres;User Id=postgres;Password=postgrespw;"
} 
```

# 配置App.config:可在程序里配置

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
        <sectionGroup name="userSettings" type="System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" >
            <section name="ChiSaTo.Settings1" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" requirePermission="false" />
        </sectionGroup>
    </configSections>
    <userSettings>
        <ChiSaTo.Settings1>
            <setting name="BlogCateLog" serializeAs="String">
                <value>D:\\博客\\YuriBlog</value>
            </setting>
            <setting name="Blog_Url" serializeAs="String">
                <value>http://www.yayi.site</value>
            </setting>
            <setting name="Blog_Repo" serializeAs="String">
                <value>https://github.com/TangxinGH/Blog</value>
            </setting>
        </ChiSaTo.Settings1>
    </userSettings>
</configuration>
```

# 在博客目录下放一个create_post.js文件

```javascript
// 首先，我们必须建立一个 Hexo 实例（instance），第一个参数是网站的根目录，也就是 base_dir，而第二个参数则是初始化的选项。接着执行 init 方法后，Hexo 会加载插件及配置文件。
var Hexo = require('hexo');
// const fs = require('hexo-fs');//npm install hexo-fs --save
var hexo = new Hexo(process.cwd(), {});

hexo.init().then(function(){
    // get input arguments if exists
    var args = process.argv.slice(2);
    var data = {
      title : args[0],
     tags : args.length>1? args[1].split(',') :"",
    // var categories = args[1];
    // var date = args[3];
        cover :"https://tuapi.eees.cc/api.php?category=dongman&type=302" // args[4];
    }
    hexo.post.create(data, false).then(function(post){
        console.log(post);
        var exec = require('child_process').exec;
        exec( 'explorer.exe' + ' ' + post.path);
    }); 

});
```

# Usage

 设置主目录。

点击新建，输入标题和tag确认

# Blog

p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
p.StartInfo.CreateNoWindow = true;//不显示程序窗口

//向cmd窗口发送输入信息
//process.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
//process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
//process.StandardInput.WriteLine(@"\r\n echo {fullfilename}" + "&exit");
//process.Kill();

### 配置文件

https://www.daveoncsharp.com/2009/07/using-the-settings-file-in-csharp/
https://docs.microsoft.com/zh-cn/dotnet/desktop/winforms/advanced/how-to-create-a-new-setting-at-design-time?view=netframeworkdesktop-4.8
保存用户设置;--使用Setting文件 net framework; net core使用json文件; https://docs.microsoft.com/en-us/aspnet/core/migration/configuration?view=aspnetcore-5.0

appsetting.json 1. 新建文件；2.要设置属性：复制到输出目录中；3.

Config.Net 配置库

setting.file save方法后保存的位置：

he path to that file is `%appdata%\%publisher_name%\%program_name%\%version%\user.config`

```csharp
Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
```

```bash
C:\Users\yayi\AppData\Local
C:\Users\yayi\AppData\Roaming
```

### 

### 单元测试

[Automated Unit Testing: MSTest vs XUnit vs NUnit (anarsolutions.com)](https://anarsolutions.com/automated-unit-testing-tools-comparison/)

### 全球化

```csharp
 CultureInfo info = CultureInfo.CreateSpecificCulture("en-US");
            //info.DateTimeFormat.FullDateTimePattern = "dd-MMM-yy HH:mm:ss";
            //CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            info.DateTimeFormat.ShortDatePattern = "dd-MMM-yyyy";
            //info.DateTimeFormat.ShortTimePattern = "HH:mm:ss"; 有PM AM
            info.DateTimeFormat.LongTimePattern = "HH:mm:ss"; //无
            info.DateTimeFormat.DateSeparator = "-";
            Thread.CurrentThread.CurrentCulture = info;
            //Thread.CurrentThread.CurrentCulture = newCulture;
            Console.WriteLine(DateTime.Now.ToString());
```