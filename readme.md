# Common.Logs

��־���Ŀ�꣺

Ĭ�ϲ������κε����������֧����չ���滻��Ĭ��ʵ����log4net���滻�� 

����log4net�Ĳ��裺 

- 1 �������������У�����LogHelper.Instance.Init()
- 2 web.config�У�����<add key="Common.Logs.Log4NetEnabled" value="true"/>
- 3 DONE����������Ҫ�޸�log4net.config������������


## ����LogHelper

�򵥽ӿڣ� Debug, Info, Error
�߼��ӿڣ� Resolve => ILoggerManager => ILogger

## �߼��ӿڵ�һЩ��ע

�������ִ�Сд
var log1 = LogManager.GetLogger("hello");
var log2 = LogManager.GetLogger("HELLO");
Console.WriteLine(log1 == log2);
//result: false

...

## ����ע�����

- 1 ע�⣬Ϊ�˷�����ʾʹ�ã�[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]�Ѿ�������Log4NetLoggerManager�����棨�ɸ�����Ҫ���е��ڣ�
- 2 log4net.config�ŵ�bin�£����ʹ������Web��ʹ��λ��web.config��ͬĿ¼�¼��ɣ�
- 3 ����log4net.dll, DONE��

