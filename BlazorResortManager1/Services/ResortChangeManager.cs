using BlazorResortManager1.Data.Models.Resorts;
namespace BlazorResortManager1.Services
{
    public class ResortChangeManager
    {
        public delegate void ResortChangeHandler(ResortChangeEventArgs eventArgs);
        public event ResortChangeHandler? ResortChange;
        private ResortChangeEventArgs EventArgs { get; set; }

        private Resort _tempResort { get; set; }
        public Resort resort
        {
            get
            {
                return _tempResort;
            }
            set
            {
                _tempResort = value;
                EventArgs = new ResortChangeEventArgs { resort = _tempResort };
                ResortChange?.Invoke(EventArgs);
            }
        }

        public async Task openLoading(Action action)
        {

        }
    }
    public class ResortChangeEventArgs
    {
        public Resort resort { get; set; }
    }
}
