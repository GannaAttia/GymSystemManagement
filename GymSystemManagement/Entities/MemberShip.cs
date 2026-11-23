namespace GymSystemManagement.Entities
{
    public class MemberShip :BaseEntity
    {
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public int MemberId { get; set; }   
        public Member Member { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Column Status (Not a Column In DB)
       // [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";
    }
}
