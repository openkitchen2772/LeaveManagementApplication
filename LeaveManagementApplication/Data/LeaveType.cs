namespace LeaveManagementApplication.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultOfDays { get; set; }

    }
}
