namespace HotelPmsCore.Services
{
  
    public interface IModule
    {
       
        void New();
        void Edit();
        void Delete();
        void RefreshGrid();
        bool HasSelection { get; }
    }
}
