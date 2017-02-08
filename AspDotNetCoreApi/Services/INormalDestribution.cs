namespace WebApplication.Services
{
    public interface INormalDestribution{
        double _mi {get;set;}
        double _di {get;set;}

        double normalFunction();
    }
}
