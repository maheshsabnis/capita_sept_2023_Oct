namespace Core_API.Models
{
    public class ResponseObject<TEntity> where TEntity : class
    {
        // Response Collection
        public IEnumerable<TEntity>? Records { get; set; }
        // Response Single Record 
        public TEntity? Record { get; set; }
        // A Boolean flag that represents the success of failed execution
        public bool IsSuccess { get; set; } = false;
        // Response Status Message (Success or Error)
        public string? Message { get; set; }
        // Response Code
        public int ResponseCode { get; set; }
    }
}
