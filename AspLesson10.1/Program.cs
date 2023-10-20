//�������
//���������� � ������� ��� ���� ������ ������������: xml, json � ini.
//� ������ �� ��� ����� �������� ���������� � ��������� MicrosoftComp, AppleComp � Google.
//� �������� ������������� ��������� ������ ���� ���������� ����������� ������ ��������.
//�������� ������, ������� ����� ������������� ���������� �����������,
//���������� � ���������� ���� ������ ������������, � �������� �������� ��������, � ������� ���� ���������� ����

//������� 1
//�������� json-���� ������������, � ������� � ���������� ����� ����� �������� ��������� ������ � ���. �������� �� � ���� ��������

//������� 2
//�������� ��������� ������ � ��������� ������ Transient.
//������ ������ ������������� ������� ����� �� ������� �, � ����������� �� ����������,
//� ����� http-������ ���������� ������ ������� ����� (���� ����� ����� 12 � 16 ������),
//������� ����� (���� ����� 16 � ��������), ������� ����� (�� ������� �� 4 ����) �,
//��������������, ������� ���� (�� 4 �� 12)
using AspLesson10._1.Services;

namespace AspLesson10._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<IWorkerCount,WorkerCount>();
            builder.Services.AddTransient<ITimeNow,TimeNow>();
            builder.Services.AddControllersWithViews();
            builder.Configuration.AddJsonFile("App_Data/MyData.json");
            builder.Configuration.AddJsonFile("App_Data/MicrosoftWorkers.json");
            builder.Configuration.AddXmlFile("App_Data/AppleWorkers.xml");
            var app = builder.Build();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            
            app.Run();
        }
    }
}