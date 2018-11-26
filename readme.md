# Common.Logs

日志组件目标：

默认不依赖任何第三方组件，支持扩展和替换（默认实现了log4net的替换） 

启用log4net的步骤： 

- 1 程序启动代码中，调用LogHelper.Instance.Init()
- 2 web.config中，启用<add key="Common.Logs.Log4NetEnabled" value="true"/>
- 3 DONE！（根据需要修改log4net.config，无需重启）


## 关于LogHelper

简单接口： Debug, Info, Error
高级接口： Resolve => ILoggerManager => ILogger

## 高级接口的一些备注

名字区分大小写
var log1 = LogManager.GetLogger("hello");
var log2 = LogManager.GetLogger("HELLO");
Console.WriteLine(log1 == log2);
//result: false

...

## 部署注意事项：

- 1 注意，为了方便演示使用，[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]已经打在了Log4NetLoggerManager类上面（可根据需要自行调节）
- 2 log4net.config放到bin下（如果使用者是Web，使其位于web.config的同目录下即可）
- 3 放置log4net.dll, DONE！

